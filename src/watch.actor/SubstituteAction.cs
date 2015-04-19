using System.Collections.Generic;

namespace watch.actor
{
    public class SubstituteAction
    {
        public string Path { get; set; }
        public IDictionary<string, string> Variables { get; set; }

        public SubstituteAction(string path, IDictionary<string, string> variables)
        {
            Path = path;
            Variables = variables;
        }
    }
}
