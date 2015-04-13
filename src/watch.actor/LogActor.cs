using System;
using System.ComponentModel;
using Akka.Actor;

namespace watch.actor
{
    public class LogActor : ReceiveActor
    {
        public LogActor(BindingList<string> logs)
        {
            Receive<string>(m =>
            {
                if (logs.Count > 1000)
                {
                    logs.RemoveAt(logs.Count - 1);
                }

                logs.Insert(0, string.Format("{0} : {1}", DateTime.Now, m));
            });

            Receive<Exception>(m => logs.Insert(0, string.Format("{0} : {1}", DateTime.Now, m.Message)));
        }
    }
}
