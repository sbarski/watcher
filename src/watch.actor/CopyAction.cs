using Akka.Dispatch.SysMsg;

namespace watch.actor
{
    public class CopyAction
    {
        public CopyAction(string copyFrom, string copyTo)
        {
            CopyFrom = copyFrom;
            CopyTo = copyTo;
        }

        public string CopyFrom { get; set; }
        public string CopyTo { get; set; }
    }
}
