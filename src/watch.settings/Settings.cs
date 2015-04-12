using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

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
