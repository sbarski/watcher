using Akka.Actor;
using System.Text.RegularExpressions;

namespace watch.actor
{
    public class SubtituteActor : ReceiveActor
    {
        private readonly IActorRef _logActor;

        public SubtituteActor(IActorRef logActor)
        {
            _logActor = logActor;

            Receive<SubstituteAction>(m =>
            {
                var regex = new Regex("{([^}]+)?}");
                var match = regex.Match(m.Path);

                while (match.Success)
                {
                    var replacement = match.Groups[0].Value;
                    var variableName = match.Groups[1].Value;

                    if (m.Variables.ContainsKey(variableName))
                    {
                        m.Path = m.Path.Replace(replacement, m.Variables[variableName]);
                    }
                    else
                    {
                        _logActor.Tell(string.Format("Unable to substitute a variable named: {0}", variableName));
                    }

                    match = match.NextMatch();
                }

                Sender.Tell(m.Path);
            });
        }
    }
}
