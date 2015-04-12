using System;
using Akka.Actor;

namespace watch.actor
{
    public class LogActor : ReceiveActor
    {
        public LogActor()
        {
            Receive<string>(m =>
            {
                Console.WriteLine(m);
            });

            Receive<Exception>(m =>
            {
                Console.WriteLine(m.InnerException);
            });
        }
    }
}
