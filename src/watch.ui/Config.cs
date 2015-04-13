using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using watch.actor;
using watch.settings;

namespace watch.ui
{
    public partial class Config : MetroFramework.Forms.MetroForm
    {
        private Settings Settings { get; set; }
        private string _saveFile { get; set; }

        public Config()
        {
            _saveFile = ConfigurationManager.AppSettings["save"] ?? "save.json";

            InitializeComponent();

            WatchManager.Init();

            Settings = AppSettings.Load(_saveFile);

            locations.DataSource = Settings.Locations;
            locations.DisplayMember = "FriendlyName";

            friendlyName.DataBindings.Add("Text", locations.DataSource, "FriendlyName", true, DataSourceUpdateMode.OnPropertyChanged);
            watchFolder.DataBindings.Add("Text", locations.DataSource, "WatchFolder", true, DataSourceUpdateMode.OnPropertyChanged);
            copyToFolder.DataBindings.Add("Text", locations.DataSource, "CopyToFolder", true, DataSourceUpdateMode.OnPropertyChanged);
            pattern.DataBindings.Add("Text", locations.DataSource, "Pattern", true, DataSourceUpdateMode.OnPropertyChanged);
            selfGeneratedId.DataBindings.Add("Text", locations.DataSource, "Id", true, DataSourceUpdateMode.OnPropertyChanged);

            Resize += Config_Resize;
            notifyIcon.MouseClick += notifyIcon_MouseClick;
        }

        void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }


        private void Config_Load(object sender, System.EventArgs e)
        {
        }

        private void saveLocation_Click(object sender, System.EventArgs e)
        {
            if (locations.Items.Count == 0)
            {
                var location = FileLocation.Create(friendlyName.Text, watchFolder.Text, copyToFolder.Text, pattern.Text);

                Settings.Locations.Add(location);
            }

            if (Settings.Locations.Any(m => string.IsNullOrEmpty(m.CopyToFolder) || string.IsNullOrEmpty(m.FriendlyName) || string.IsNullOrEmpty(m.WatchFolder)))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill out all fields", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Settings.Locations.ResetBindings();

            AppSettings.Save(Settings, _saveFile);
        }

        private void removeLocation_Click(object sender, System.EventArgs e)
        {
            if (locations.SelectedIndex < 0)
            {
                return;
            }

            Settings.Locations.RemoveAt(locations.SelectedIndex);

            AppSettings.Save(Settings, _saveFile);
        }

        private void createNewLocation_Click(object sender, System.EventArgs e)
        {
            Settings.Locations.Add(FileLocation.Create("New Location " + locations.Items.Count));

            locations.SelectedIndex = locations.Items.Count - 1;
        }

        private void Config_Resize(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.Text = "Click on the icon to maximize Watch";
                ShowInTaskbar = false;
            }
            else
            {
                notifyIcon.Visible = false;
                ShowInTaskbar = true;
            }
        }

        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            if (WatchManager.IsRunning)
            {
                watchStatus.Text = "(Not Running)";
                startWatch.Text = "Start";
                WatchManager.Stop();
            }
            else
            {
                watchStatus.Text = "(Running)";
                startWatch.Text = "Stop";
                WatchManager.Start(Settings.Locations);
            }
        }
    }
}
