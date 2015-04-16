using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using watch.settings;

namespace watch.actor
{
    public class FileMoveActor : ReceiveActor
    {
        public FileMoveActor()
        {
            Receive<CopyAction>(m =>
            {
                try
                {
                    File.Copy(@m.CopyFrom, @m.CopyTo, true);

                    Context.ActorSelection("/user/LogActor").Tell(string.Format("Copied {0} to {1}", @m.CopyFrom, @m.CopyTo));
                }
                catch (Exception e)
                {
                    Context.ActorSelection("/user/LogActor").Tell(e);
                }
            });
        }
    }
}
