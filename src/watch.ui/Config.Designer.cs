namespace watch.ui
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.watchSubdirectories = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.selfGeneratedId = new MetroFramework.Controls.MetroLabel();
            this.createNewLocation = new MetroFramework.Controls.MetroButton();
            this.removeLocation = new MetroFramework.Controls.MetroButton();
            this.saveLocation = new MetroFramework.Controls.MetroButton();
            this.pattern = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.copyToFolder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.locations = new System.Windows.Forms.ListBox();
            this.watchFolder = new MetroFramework.Controls.MetroTextBox();
            this.friendlyName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.LogList = new System.Windows.Forms.ListBox();
            this.watchStatus = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.TabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPage1);
            this.TabControl.Controls.Add(this.metroTabPage2);
            this.TabControl.Controls.Add(this.metroTabPage3);
            this.TabControl.Location = new System.Drawing.Point(24, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 2;
            this.TabControl.Size = new System.Drawing.Size(819, 389);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.watchSubdirectories);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.selfGeneratedId);
            this.metroTabPage1.Controls.Add(this.createNewLocation);
            this.metroTabPage1.Controls.Add(this.removeLocation);
            this.metroTabPage1.Controls.Add(this.saveLocation);
            this.metroTabPage1.Controls.Add(this.pattern);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.copyToFolder);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.locations);
            this.metroTabPage1.Controls.Add(this.watchFolder);
            this.metroTabPage1.Controls.Add(this.friendlyName);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(811, 347);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Configuration";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // watchSubdirectories
            // 
            this.watchSubdirectories.AutoSize = true;
            this.watchSubdirectories.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.watchSubdirectories.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.watchSubdirectories.Location = new System.Drawing.Point(195, 120);
            this.watchSubdirectories.Name = "watchSubdirectories";
            this.watchSubdirectories.Size = new System.Drawing.Size(148, 19);
            this.watchSubdirectories.TabIndex = 16;
            this.watchSubdirectories.Text = "Watch Subdirectories";
            this.watchSubdirectories.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(196, 270);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Task Id:";
            // 
            // selfGeneratedId
            // 
            this.selfGeneratedId.AutoSize = true;
            this.selfGeneratedId.Location = new System.Drawing.Point(252, 270);
            this.selfGeneratedId.Name = "selfGeneratedId";
            this.selfGeneratedId.Size = new System.Drawing.Size(117, 19);
            this.selfGeneratedId.TabIndex = 14;
            this.selfGeneratedId.Text = "Self Generated Id: ";
            // 
            // createNewLocation
            // 
            this.createNewLocation.Location = new System.Drawing.Point(746, 34);
            this.createNewLocation.Name = "createNewLocation";
            this.createNewLocation.Size = new System.Drawing.Size(53, 23);
            this.createNewLocation.TabIndex = 13;
            this.createNewLocation.Text = "+ new";
            this.createNewLocation.UseSelectable = true;
            this.createNewLocation.Click += new System.EventHandler(this.createNewLocation_Click);
            // 
            // removeLocation
            // 
            this.removeLocation.Location = new System.Drawing.Point(195, 303);
            this.removeLocation.Name = "removeLocation";
            this.removeLocation.Size = new System.Drawing.Size(114, 36);
            this.removeLocation.TabIndex = 12;
            this.removeLocation.Text = "Remove";
            this.removeLocation.UseSelectable = true;
            this.removeLocation.Click += new System.EventHandler(this.removeLocation_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(699, 303);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(100, 36);
            this.saveLocation.TabIndex = 11;
            this.saveLocation.Text = "Save";
            this.saveLocation.UseSelectable = true;
            this.saveLocation.Click += new System.EventHandler(this.saveLocation_Click);
            // 
            // pattern
            // 
            this.pattern.Lines = new string[] {
        "*"};
            this.pattern.Location = new System.Drawing.Point(195, 233);
            this.pattern.MaxLength = 32767;
            this.pattern.Name = "pattern";
            this.pattern.PasswordChar = '\0';
            this.pattern.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pattern.SelectedText = "";
            this.pattern.Size = new System.Drawing.Size(604, 23);
            this.pattern.TabIndex = 10;
            this.pattern.Text = "*";
            this.pattern.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(195, 211);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Pattern";
            // 
            // copyToFolder
            // 
            this.copyToFolder.Lines = new string[0];
            this.copyToFolder.Location = new System.Drawing.Point(195, 176);
            this.copyToFolder.MaxLength = 32767;
            this.copyToFolder.Name = "copyToFolder";
            this.copyToFolder.PasswordChar = '\0';
            this.copyToFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.copyToFolder.SelectedText = "";
            this.copyToFolder.Size = new System.Drawing.Size(604, 23);
            this.copyToFolder.TabIndex = 8;
            this.copyToFolder.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(195, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Copy To Folder";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(195, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Watch Folder";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(195, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Friendly Name";
            // 
            // locations
            // 
            this.locations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.locations.FormattingEnabled = true;
            this.locations.Location = new System.Drawing.Point(0, 12);
            this.locations.Name = "locations";
            this.locations.Size = new System.Drawing.Size(189, 327);
            this.locations.TabIndex = 4;
            // 
            // watchFolder
            // 
            this.watchFolder.Lines = new string[0];
            this.watchFolder.Location = new System.Drawing.Point(195, 91);
            this.watchFolder.MaxLength = 32767;
            this.watchFolder.Name = "watchFolder";
            this.watchFolder.PasswordChar = '\0';
            this.watchFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.watchFolder.SelectedText = "";
            this.watchFolder.Size = new System.Drawing.Size(604, 23);
            this.watchFolder.TabIndex = 3;
            this.watchFolder.UseSelectable = true;
            // 
            // friendlyName
            // 
            this.friendlyName.Lines = new string[] {
        "My File Watcher"};
            this.friendlyName.Location = new System.Drawing.Point(195, 34);
            this.friendlyName.MaxLength = 32767;
            this.friendlyName.Name = "friendlyName";
            this.friendlyName.PasswordChar = '\0';
            this.friendlyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.friendlyName.SelectedText = "";
            this.friendlyName.Size = new System.Drawing.Size(545, 23);
            this.friendlyName.TabIndex = 2;
            this.friendlyName.Text = "My File Watcher";
            this.friendlyName.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(811, 347);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Operation";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.LogList);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(811, 347);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Log";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.HorizontalScrollbar = true;
            this.LogList.Location = new System.Drawing.Point(0, 3);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(811, 342);
            this.LogList.TabIndex = 2;
            // 
            // watchStatus
            // 
            this.watchStatus.AutoSize = true;
            this.watchStatus.Location = new System.Drawing.Point(636, 22);
            this.watchStatus.Name = "watchStatus";
            this.watchStatus.Size = new System.Drawing.Size(90, 19);
            this.watchStatus.TabIndex = 1;
            this.watchStatus.Text = "(Not Running)";
            this.watchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Watch";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(638, 44);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 17;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 485);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.watchStatus);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.Name = "Config";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Watcher";
            this.Load += new System.EventHandler(this.Config_Load);
            this.TabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox friendlyName;
        private MetroFramework.Controls.MetroTextBox watchFolder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox locations;
        private MetroFramework.Controls.MetroTextBox copyToFolder;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox pattern;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton saveLocation;
        private MetroFramework.Controls.MetroButton removeLocation;
        private MetroFramework.Controls.MetroButton createNewLocation;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel watchStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroLabel selfGeneratedId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ListBox LogList;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroCheckBox watchSubdirectories;




    }
}

