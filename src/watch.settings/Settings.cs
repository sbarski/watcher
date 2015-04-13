using System.Collections.ObjectModel;
using System.ComponentModel;

namespace watch.settings
{
    public class Settings
    {
        public Settings()
        {
            Locations = new BindingList<FileLocation>();
        }

        public BindingList<FileLocation> Locations { get; set; }
    }
}
