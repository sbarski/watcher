using System;

namespace watch.settings
{
    public class FileLocation
    {
        public static FileLocation Create(string friendlyName = "New Location")
        {
            var location = new FileLocation()
            {
                Id = Guid.NewGuid(),

                FriendlyName = friendlyName,
                WatchFolder = "",
                CopyToFolder = "",
                Pattern = "*"
            };

            return location;
        }

        public static FileLocation Create(string friendlyName, string watchFolder, string copyToFolder, string pattern)
        {
            var location = Create(friendlyName);

            location.WatchFolder = watchFolder;
            location.CopyToFolder = copyToFolder;
            location.Pattern = pattern;

            return location;
        }

        public Guid Id { get; set; }
        public string FriendlyName { get; set; }
        public string WatchFolder { get; set; }
        public string CopyToFolder { get; set; }
        public string Pattern { get; set; }
    }
}
