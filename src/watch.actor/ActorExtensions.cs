using Akka.Actor;
using System;
using System.Threading.Tasks;

namespace watch.actor
{
    public static class ActorExtensions
    {
        public static T AskAndWait<T>(this IActorRef self, object message)
        {
            return Task.Run(() => self.Ask<T>(message)).Result;
        }

        public static T AskAndWait<T>(this IActorRef self, object message, TimeSpan timeout)
        {
            return Task.Run(() => self.Ask<T>(message, timeout)).Result;
        }
    }
}
