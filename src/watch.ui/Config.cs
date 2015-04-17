using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
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

            LogList.DataSource = WatchManager.Logs;

            variables.DataSource = Settings.Variables;
            variables.DisplayMember = "Name";

            friendlyName.DataBindings.Add("Text", locations.DataSource, "FriendlyName", true, DataSourceUpdateMode.OnPropertyChanged);
            watchFolder.DataBindings.Add("Text", locations.DataSource, "WatchFolder", true, DataSourceUpdateMode.OnPropertyChanged);
            watchSubdirectories.DataBindings.Add("Checked", locations.DataSource, "WatchSubdirectories", true, DataSourceUpdateMode.OnPropertyChanged);
            copyToFolder.DataBindings.Add("Text", locations.DataSource, "CopyToFolder", true, DataSourceUpdateMode.OnPropertyChanged);
            pattern.DataBindings.Add("Text", locations.DataSource, "Pattern", true, DataSourceUpdateMode.OnPropertyChanged);
            selfGeneratedId.DataBindings.Add("Text", locations.DataSource, "Id", true, DataSourceUpdateMode.OnPropertyChanged);

            variableName.DataBindings.Add("Text", variables.DataSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            variableValue.DataBindings.Add("Text", variables.DataSource, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            
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

            SaveSettings();
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

        private void metroToggle1_CheckedChanged(object sender, System.EventArgs e)
        {
            var checkedState = (sender as MetroToggle).CheckState;

            if (checkedState == CheckState.Checked)
            {
                watchStatus.Text = "(Running)";
                WatchManager.Start(Settings.Locations, Settings.Variables);
            }
            else
            {
                watchStatus.Text = "(Not Running)";
                WatchManager.Stop();
            }
        }

        private void saveVariables_Click(object sender, System.EventArgs e)
        {
            if (variables.Items.Count == 0)
            {
                var variable = Variable.Create();

                Settings.Variables.Add(variable);
            }

            SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Locations.ResetBindings();
            Settings.Variables.ResetBindings();

            if (Settings.Locations.Any(m => string.IsNullOrEmpty(m.CopyToFolder) || string.IsNullOrEmpty(m.FriendlyName) || string.IsNullOrEmpty(m.WatchFolder)))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill out all fields", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabControl.SelectedTab = configTabPage;
                return;
            }

            if (Settings.Variables.Any(v => string.IsNullOrEmpty(v.Name) || string.IsNullOrEmpty(v.Value)))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill out all fields", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabControl.SelectedTab = variablesTabPage;
                return;
            }

            if (Settings.Variables.Count(v => v.Name == variableName.Text) > 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Oops, the variable name already exists. Variable names must be unique.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TabControl.SelectedTab = variablesTabPage;
                return;
            }

            AppSettings.Save(Settings, _saveFile);
        }

        private void creatNewVariable_Click(object sender, System.EventArgs e)
        {
            Settings.Variables.Add(Variable.Create("New Variable " + variables.Items.Count));

            variables.SelectedIndex = variables.Items.Count - 1;
        }

        private void removeVariable_Click(object sender, System.EventArgs e)
        {
            if (variables.SelectedIndex < 0)
            {
                return;
            }

            Settings.Variables.RemoveAt(variables.SelectedIndex);

            AppSettings.Save(Settings, _saveFile);
        }
    }
}
