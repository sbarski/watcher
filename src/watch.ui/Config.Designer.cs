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
            this.configTabPage = new MetroFramework.Controls.MetroTabPage();
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
            this.logTabPage = new MetroFramework.Controls.MetroTabPage();
            this.LogList = new System.Windows.Forms.ListBox();
            this.variablesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.removeVariable = new MetroFramework.Controls.MetroButton();
            this.creatNewVariable = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.variableValue = new MetroFramework.Controls.MetroTextBox();
            this.variableName = new MetroFramework.Controls.MetroTextBox();
            this.variables = new System.Windows.Forms.ListBox();
            this.saveVariables = new MetroFramework.Controls.MetroButton();
            this.operationTabPage = new MetroFramework.Controls.MetroTabPage();
            this.watchStatus = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.TabControl.SuspendLayout();
            this.configTabPage.SuspendLayout();
            this.logTabPage.SuspendLayout();
            this.variablesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.configTabPage);
            this.TabControl.Controls.Add(this.variablesTabPage);
            this.TabControl.Controls.Add(this.logTabPage);
            this.TabControl.Controls.Add(this.operationTabPage);
            this.TabControl.Location = new System.Drawing.Point(24, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(819, 389);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // configTabPage
            // 
            this.configTabPage.Controls.Add(this.watchSubdirectories);
            this.configTabPage.Controls.Add(this.metroLabel6);
            this.configTabPage.Controls.Add(this.selfGeneratedId);
            this.configTabPage.Controls.Add(this.createNewLocation);
            this.configTabPage.Controls.Add(this.removeLocation);
            this.configTabPage.Controls.Add(this.saveLocation);
            this.configTabPage.Controls.Add(this.pattern);
            this.configTabPage.Controls.Add(this.metroLabel4);
            this.configTabPage.Controls.Add(this.copyToFolder);
            this.configTabPage.Controls.Add(this.metroLabel3);
            this.configTabPage.Controls.Add(this.metroLabel2);
            this.configTabPage.Controls.Add(this.metroLabel1);
            this.configTabPage.Controls.Add(this.locations);
            this.configTabPage.Controls.Add(this.watchFolder);
            this.configTabPage.Controls.Add(this.friendlyName);
            this.configTabPage.HorizontalScrollbarBarColor = true;
            this.configTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.configTabPage.HorizontalScrollbarSize = 10;
            this.configTabPage.Location = new System.Drawing.Point(4, 38);
            this.configTabPage.Name = "configTabPage";
            this.configTabPage.Size = new System.Drawing.Size(811, 347);
            this.configTabPage.TabIndex = 0;
            this.configTabPage.Text = "Configuration";
            this.configTabPage.VerticalScrollbarBarColor = true;
            this.configTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.configTabPage.VerticalScrollbarSize = 10;
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
            // logTabPage
            // 
            this.logTabPage.Controls.Add(this.LogList);
            this.logTabPage.HorizontalScrollbarBarColor = true;
            this.logTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.logTabPage.HorizontalScrollbarSize = 10;
            this.logTabPage.Location = new System.Drawing.Point(4, 38);
            this.logTabPage.Name = "logTabPage";
            this.logTabPage.Size = new System.Drawing.Size(811, 347);
            this.logTabPage.TabIndex = 2;
            this.logTabPage.Text = "Log";
            this.logTabPage.VerticalScrollbarBarColor = true;
            this.logTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.logTabPage.VerticalScrollbarSize = 10;
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.Location = new System.Drawing.Point(0, 3);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(811, 342);
            this.LogList.TabIndex = 2;
            // 
            // variablesTabPage
            // 
            this.variablesTabPage.Controls.Add(this.removeVariable);
            this.variablesTabPage.Controls.Add(this.creatNewVariable);
            this.variablesTabPage.Controls.Add(this.metroLabel5);
            this.variablesTabPage.Controls.Add(this.metroLabel7);
            this.variablesTabPage.Controls.Add(this.variableValue);
            this.variablesTabPage.Controls.Add(this.variableName);
            this.variablesTabPage.Controls.Add(this.variables);
            this.variablesTabPage.Controls.Add(this.saveVariables);
            this.variablesTabPage.HorizontalScrollbarBarColor = true;
            this.variablesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.variablesTabPage.HorizontalScrollbarSize = 10;
            this.variablesTabPage.Location = new System.Drawing.Point(4, 38);
            this.variablesTabPage.Name = "variablesTabPage";
            this.variablesTabPage.Size = new System.Drawing.Size(811, 347);
            this.variablesTabPage.TabIndex = 3;
            this.variablesTabPage.Text = "Variables";
            this.variablesTabPage.VerticalScrollbarBarColor = true;
            this.variablesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.variablesTabPage.VerticalScrollbarSize = 10;
            // 
            // removeVariable
            // 
            this.removeVariable.Location = new System.Drawing.Point(195, 303);
            this.removeVariable.Name = "removeVariable";
            this.removeVariable.Size = new System.Drawing.Size(114, 36);
            this.removeVariable.TabIndex = 19;
            this.removeVariable.Text = "Remove";
            this.removeVariable.UseSelectable = true;
            this.removeVariable.Click += new System.EventHandler(this.removeVariable_Click);
            // 
            // creatNewVariable
            // 
            this.creatNewVariable.Location = new System.Drawing.Point(746, 34);
            this.creatNewVariable.Name = "creatNewVariable";
            this.creatNewVariable.Size = new System.Drawing.Size(53, 23);
            this.creatNewVariable.TabIndex = 18;
            this.creatNewVariable.Text = "+ new";
            this.creatNewVariable.UseSelectable = true;
            this.creatNewVariable.Click += new System.EventHandler(this.creatNewVariable_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(195, 69);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Variable Value";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(195, 12);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Variable Name";
            // 
            // variableValue
            // 
            this.variableValue.Lines = new string[0];
            this.variableValue.Location = new System.Drawing.Point(195, 91);
            this.variableValue.MaxLength = 32767;
            this.variableValue.Name = "variableValue";
            this.variableValue.PasswordChar = '\0';
            this.variableValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variableValue.SelectedText = "";
            this.variableValue.Size = new System.Drawing.Size(604, 23);
            this.variableValue.TabIndex = 15;
            this.variableValue.UseSelectable = true;
            // 
            // variableName
            // 
            this.variableName.Lines = new string[0];
            this.variableName.Location = new System.Drawing.Point(195, 34);
            this.variableName.MaxLength = 32767;
            this.variableName.Name = "variableName";
            this.variableName.PasswordChar = '\0';
            this.variableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variableName.SelectedText = "";
            this.variableName.Size = new System.Drawing.Size(545, 23);
            this.variableName.TabIndex = 14;
            this.variableName.UseSelectable = true;
            // 
            // variables
            // 
            this.variables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.variables.ForeColor = System.Drawing.SystemColors.ControlText;
            this.variables.FormattingEnabled = true;
            this.variables.Location = new System.Drawing.Point(0, 12);
            this.variables.Name = "variables";
            this.variables.Size = new System.Drawing.Size(189, 327);
            this.variables.TabIndex = 13;
            // 
            // saveVariables
            // 
            this.saveVariables.Location = new System.Drawing.Point(699, 303);
            this.saveVariables.Name = "saveVariables";
            this.saveVariables.Size = new System.Drawing.Size(100, 36);
            this.saveVariables.TabIndex = 12;
            this.saveVariables.Text = "Save";
            this.saveVariables.UseSelectable = true;
            this.saveVariables.Click += new System.EventHandler(this.saveVariables_Click);
            // 
            // operationTabPage
            // 
            this.operationTabPage.HorizontalScrollbarBarColor = true;
            this.operationTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.operationTabPage.HorizontalScrollbarSize = 10;
            this.operationTabPage.Location = new System.Drawing.Point(4, 38);
            this.operationTabPage.Name = "operationTabPage";
            this.operationTabPage.Size = new System.Drawing.Size(811, 347);
            this.operationTabPage.TabIndex = 1;
            this.operationTabPage.Text = "Operation";
            this.operationTabPage.VerticalScrollbarBarColor = true;
            this.operationTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.operationTabPage.VerticalScrollbarSize = 10;
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
            this.configTabPage.ResumeLayout(false);
            this.configTabPage.PerformLayout();
            this.logTabPage.ResumeLayout(false);
            this.variablesTabPage.ResumeLayout(false);
            this.variablesTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage configTabPage;
        private MetroFramework.Controls.MetroTabPage operationTabPage;
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
        private MetroFramework.Controls.MetroTabPage logTabPage;
        private MetroFramework.Controls.MetroLabel watchStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroLabel selfGeneratedId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ListBox LogList;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroCheckBox watchSubdirectories;
        private MetroFramework.Controls.MetroTabPage variablesTabPage;
        private MetroFramework.Controls.MetroButton saveVariables;
        private MetroFramework.Controls.MetroButton removeVariable;
        private MetroFramework.Controls.MetroButton creatNewVariable;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox variableValue;
        private MetroFramework.Controls.MetroTextBox variableName;
        private System.Windows.Forms.ListBox variables;




    }
}

