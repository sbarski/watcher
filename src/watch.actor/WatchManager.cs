using System.Collections.Generic;
using System.IO;
using Akka.Actor;
using watch.settings;

namespace watch.actor
{
    public static class WatchManager
    {
        private static Dictionary<FileLocation, FileSystemWatcher> _fileSystemWatchers; 

        public static bool IsRunning { get; private set; }

        private static ActorSystem _actorSystem;
        private static IActorRef _fileMoveActor;
        private static IActorRef _logActor;

        public static void Init()
        {
            if (_actorSystem == null)
            {
                _actorSystem = ActorSystem.Create("FileActors");
                _logActor = _actorSystem.ActorOf(Props.Create<LogActor>(), "LogActor");
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

            _fileSystemWatchers.Add(location, watch);
        }

        private static void TellActor(FileSystemEventArgs args, string location)
        {
            location = string.Format("{0}\\{1}", location, args.Name);

            _fileMoveActor.Tell(new CopyAction(args.FullPath, location));
        }

        public static void Start(IList<FileLocation> locations)
        {
            _fileSystemWatchers = new Dictionary<FileLocation, FileSystemWatcher>();

            foreach (var location in locations)
            {
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
