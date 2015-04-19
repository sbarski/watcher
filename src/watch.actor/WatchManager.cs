using Akka.Actor;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using watch.settings;

namespace watch.actor
{
    public static class WatchManager
    {
        private static Dictionary<FileLocation, FileSystemWatcher> _fileSystemWatchers;
        private static Dictionary<string, string> _variables;

        public static bool IsRunning { get; private set; }

        private static ActorSystem _actorSystem;
        private static IActorRef _fileMoveActor;
        private static IActorRef _logActor;
        private static IActorRef _subtituteActor;

        public static BindingList<string> Logs;

        public static void Init()
        {
            Logs = new BindingList<string>();
            
            if (_actorSystem == null)
            {
                _actorSystem = ActorSystem.Create("FileActors");
                _logActor = _actorSystem.ActorOf(Props.Create<LogActor>(Logs), "LogActor");
                _subtituteActor = _actorSystem.ActorOf(Props.Create<SubtituteActor>(_logActor), "SubtitutionActor");
                _fileMoveActor = _actorSystem.ActorOf(Props.Create<FileMoveActor>(), "FileMoveActor");
            }

            _logActor.Tell("Actor System Initialised");

            IsRunning = false;
        }

        public static void Add(FileLocation location)
        {
            var watch = new FileSystemWatcher(location.WatchFolder, location.Pattern);
                
            watch.Changed += (sender, args) => TellActor(args, location.CopyToFolder);
            watch.Created += (sender, args) => TellActor(args, location.CopyToFolder);
            watch.Renamed += (sender, args) => TellActor(args, location.CopyToFolder);

            watch.EnableRaisingEvents = true;
            watch.IncludeSubdirectories = location.WatchSubdirectories;

            _fileSystemWatchers.Add(location, watch);
        }

        private static void TellActor(FileSystemEventArgs args, string location)
        {
            location = string.Format("{0}\\{1}", location, args.Name);

            _fileMoveActor.Tell(new CopyAction(args.FullPath, location));
        }

        public static void Start(IList<FileLocation> locations, IList<Variable> variables)
        {
            _fileSystemWatchers = new Dictionary<FileLocation, FileSystemWatcher>();
            _variables = variables.ToDictionary(v => v.Name, v => v.Value);

            foreach (var location in locations)
            {
                location.WatchFolder = _subtituteActor.AskAndWait<string>(new SubstituteAction(location.WatchFolder, _variables));
                location.CopyToFolder = _subtituteActor.AskAndWait<string>(new SubstituteAction(location.CopyToFolder, _variables));

                Add(location);
            }

            IsRunning = true;
            
            _logActor.Tell("Actor System Started");
        }

        public static void Stop()
        {
            foreach (var fileSystemWatcher in _fileSystemWatchers)
            {
                fileSystemWatcher.Value.EnableRaisingEvents = false;
                fileSystemWatcher.Value.Dispose();
            }

            _fileSystemWatchers = null;

            IsRunning = false;

            _logActor.Tell("Actor System Stopped");
        }
    }
}
