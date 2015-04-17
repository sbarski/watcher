using System.ComponentModel;

namespace watch.settings
{
    public class Settings
    {
        public Settings()
        {
            Locations = new BindingList<FileLocation>();
            Variables = new BindingList<Variable>();
        }

        public BindingList<FileLocation> Locations { get; set; }
        public BindingList<Variable> Variables { get; set; } 
    }
}
