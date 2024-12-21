namespace ArgusTV.UI.Notifier
{
    partial class SettingsForm
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
            this._generalGroupBox = new System.Windows.Forms.GroupBox();
            this._browseMmcButton = new System.Windows.Forms.Button();
            this._mmcPathTextBox = new System.Windows.Forms.TextBox();
            this._mmcLabel = new System.Windows.Forms.Label();
            this._balloonTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._balloonSecsLabel = new System.Windows.Forms.Label();
            this._balloonTimeoutLabel = new System.Windows.Forms.Label();
            this._showRecordingBalloonsCheckBox = new System.Windows.Forms.CheckBox();
            this._notificationLabel = new System.Windows.Forms.Label();
            this._httpsGroupBox = new System.Windows.Forms.GroupBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._userNameTextBox = new System.Windows.Forms.TextBox();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._portHttpsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._httpsPortLabel = new System.Windows.Forms.Label();
            this._serverHttpsTextBox = new System.Windows.Forms.TextBox();
            this._httpsServerLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._openMmcFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._testConnectionsButton = new System.Windows.Forms.Button();
            this._generalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._balloonTimeoutNumericUpDown)).BeginInit();
            this._httpsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portHttpsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _generalGroupBox
            // 
            this._generalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._generalGroupBox.Controls.Add(this._browseMmcButton);
            this._generalGroupBox.Controls.Add(this._mmcPathTextBox);
            this._generalGroupBox.Controls.Add(this._mmcLabel);
            this._generalGroupBox.Controls.Add(this._balloonTimeoutNumericUpDown);
            this._generalGroupBox.Controls.Add(this._balloonSecsLabel);
            this._generalGroupBox.Controls.Add(this._balloonTimeoutLabel);
            this._generalGroupBox.Controls.Add(this._showRecordingBalloonsCheckBox);
            this._generalGroupBox.Controls.Add(this._notificationLabel);
            this._generalGroupBox.Location = new System.Drawing.Point(16, 114);
            this._generalGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._generalGroupBox.Name = "_generalGroupBox";
            this._generalGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._generalGroupBox.Size = new System.Drawing.Size(700, 123);
            this._generalGroupBox.TabIndex = 3;
            this._generalGroupBox.TabStop = false;
            this._generalGroupBox.Text = "General";
            // 
            // _browseMmcButton
            // 
            this._browseMmcButton.Location = new System.Drawing.Point(583, 79);
            this._browseMmcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._browseMmcButton.Name = "_browseMmcButton";
            this._browseMmcButton.Size = new System.Drawing.Size(100, 28);
            this._browseMmcButton.TabIndex = 22;
            this._browseMmcButton.Text = "Browse...";
            this._browseMmcButton.UseVisualStyleBackColor = true;
            this._browseMmcButton.Click += new System.EventHandler(this._browseMmcButton_Click);
            // 
            // _mmcPathTextBox
            // 
            this._mmcPathTextBox.Location = new System.Drawing.Point(108, 81);
            this._mmcPathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._mmcPathTextBox.Name = "_mmcPathTextBox";
            this._mmcPathTextBox.Size = new System.Drawing.Size(471, 22);
            this._mmcPathTextBox.TabIndex = 21;
            // 
            // _mmcLabel
            // 
            this._mmcLabel.AutoSize = true;
            this._mmcLabel.Location = new System.Drawing.Point(11, 85);
            this._mmcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._mmcLabel.Name = "_mmcLabel";
            this._mmcLabel.Size = new System.Drawing.Size(91, 16);
            this._mmcLabel.TabIndex = 20;
            this._mmcLabel.Text = "Console Path:";
            // 
            // _balloonTimeoutNumericUpDown
            // 
            this._balloonTimeoutNumericUpDown.Location = new System.Drawing.Point(199, 49);
            this._balloonTimeoutNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._balloonTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this._balloonTimeoutNumericUpDown.Name = "_balloonTimeoutNumericUpDown";
            this._balloonTimeoutNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this._balloonTimeoutNumericUpDown.TabIndex = 11;
            // 
            // _balloonSecsLabel
            // 
            this._balloonSecsLabel.AutoSize = true;
            this._balloonSecsLabel.Location = new System.Drawing.Point(281, 52);
            this._balloonSecsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._balloonSecsLabel.Name = "_balloonSecsLabel";
            this._balloonSecsLabel.Size = new System.Drawing.Size(60, 16);
            this._balloonSecsLabel.TabIndex = 12;
            this._balloonSecsLabel.Text = "seconds";
            // 
            // _balloonTimeoutLabel
            // 
            this._balloonTimeoutLabel.AutoSize = true;
            this._balloonTimeoutLabel.Location = new System.Drawing.Point(128, 52);
            this._balloonTimeoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._balloonTimeoutLabel.Name = "_balloonTimeoutLabel";
            this._balloonTimeoutLabel.Size = new System.Drawing.Size(64, 16);
            this._balloonTimeoutLabel.TabIndex = 10;
            this._balloonTimeoutLabel.Text = "Time-out:";
            // 
            // _showRecordingBalloonsCheckBox
            // 
            this._showRecordingBalloonsCheckBox.AutoSize = true;
            this._showRecordingBalloonsCheckBox.Location = new System.Drawing.Point(108, 25);
            this._showRecordingBalloonsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._showRecordingBalloonsCheckBox.Name = "_showRecordingBalloonsCheckBox";
            this._showRecordingBalloonsCheckBox.Size = new System.Drawing.Size(178, 20);
            this._showRecordingBalloonsCheckBox.TabIndex = 5;
            this._showRecordingBalloonsCheckBox.Text = "Show recording balloons";
            this._showRecordingBalloonsCheckBox.UseVisualStyleBackColor = true;
            this._showRecordingBalloonsCheckBox.CheckedChanged += new System.EventHandler(this._showRecordingBalloonsCheckBox_CheckedChanged);
            // 
            // _notificationLabel
            // 
            this._notificationLabel.AutoSize = true;
            this._notificationLabel.Location = new System.Drawing.Point(11, 26);
            this._notificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._notificationLabel.Name = "_notificationLabel";
            this._notificationLabel.Size = new System.Drawing.Size(77, 16);
            this._notificationLabel.TabIndex = 0;
            this._notificationLabel.Text = "Notification:";
            // 
            // _httpsGroupBox
            // 
            this._httpsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._httpsGroupBox.Controls.Add(this._passwordTextBox);
            this._httpsGroupBox.Controls.Add(this._passwordLabel);
            this._httpsGroupBox.Controls.Add(this._userNameTextBox);
            this._httpsGroupBox.Controls.Add(this._usernameLabel);
            this._httpsGroupBox.Controls.Add(this._portHttpsNumericUpDown);
            this._httpsGroupBox.Controls.Add(this._httpsPortLabel);
            this._httpsGroupBox.Controls.Add(this._serverHttpsTextBox);
            this._httpsGroupBox.Controls.Add(this._httpsServerLabel);
            this._httpsGroupBox.Location = new System.Drawing.Point(16, 15);
            this._httpsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._httpsGroupBox.Name = "_httpsGroupBox";
            this._httpsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._httpsGroupBox.Size = new System.Drawing.Size(700, 92);
            this._httpsGroupBox.TabIndex = 2;
            this._httpsGroupBox.TabStop = false;
            this._httpsGroupBox.Text = "ARGUS TV Scheduler service";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(483, 54);
            this._passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(199, 22);
            this._passwordTextBox.TabIndex = 18;
            this._passwordTextBox.UseSystemPasswordChar = true;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(393, 58);
            this._passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(71, 16);
            this._passwordLabel.TabIndex = 17;
            this._passwordLabel.Text = "Password:";
            // 
            // _userNameTextBox
            // 
            this._userNameTextBox.Location = new System.Drawing.Point(483, 22);
            this._userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._userNameTextBox.Name = "_userNameTextBox";
            this._userNameTextBox.Size = new System.Drawing.Size(199, 22);
            this._userNameTextBox.TabIndex = 16;
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Location = new System.Drawing.Point(393, 26);
            this._usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(77, 16);
            this._usernameLabel.TabIndex = 15;
            this._usernameLabel.Text = "User name:";
            // 
            // _portHttpsNumericUpDown
            // 
            this._portHttpsNumericUpDown.Location = new System.Drawing.Point(108, 55);
            this._portHttpsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._portHttpsNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this._portHttpsNumericUpDown.Name = "_portHttpsNumericUpDown";
            this._portHttpsNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this._portHttpsNumericUpDown.TabIndex = 14;
            // 
            // _httpsPortLabel
            // 
            this._httpsPortLabel.AutoSize = true;
            this._httpsPortLabel.Location = new System.Drawing.Point(11, 58);
            this._httpsPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._httpsPortLabel.Name = "_httpsPortLabel";
            this._httpsPortLabel.Size = new System.Drawing.Size(65, 16);
            this._httpsPortLabel.TabIndex = 12;
            this._httpsPortLabel.Text = "https port:";
            // 
            // _serverHttpsTextBox
            // 
            this._serverHttpsTextBox.Location = new System.Drawing.Point(108, 22);
            this._serverHttpsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._serverHttpsTextBox.Name = "_serverHttpsTextBox";
            this._serverHttpsTextBox.Size = new System.Drawing.Size(265, 22);
            this._serverHttpsTextBox.TabIndex = 11;
            // 
            // _httpsServerLabel
            // 
            this._httpsServerLabel.AutoSize = true;
            this._httpsServerLabel.Location = new System.Drawing.Point(11, 26);
            this._httpsServerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._httpsServerLabel.Name = "_httpsServerLabel";
            this._httpsServerLabel.Size = new System.Drawing.Size(51, 16);
            this._httpsServerLabel.TabIndex = 10;
            this._httpsServerLabel.Text = "Server:";
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(508, 252);
            this._okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(100, 28);
            this._okButton.TabIndex = 201;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(616, 252);
            this._cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(100, 28);
            this._cancelButton.TabIndex = 202;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _openMmcFileDialog
            // 
            this._openMmcFileDialog.DefaultExt = "exe";
            this._openMmcFileDialog.Filter = "Executable Files|*.exe";
            this._openMmcFileDialog.Title = "Select Scheduler Console Executable";
            // 
            // _testConnectionsButton
            // 
            this._testConnectionsButton.Location = new System.Drawing.Point(16, 252);
            this._testConnectionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._testConnectionsButton.Name = "_testConnectionsButton";
            this._testConnectionsButton.Size = new System.Drawing.Size(147, 28);
            this._testConnectionsButton.TabIndex = 203;
            this._testConnectionsButton.Text = "Test Connection";
            this._testConnectionsButton.UseVisualStyleBackColor = true;
            this._testConnectionsButton.Click += new System.EventHandler(this._testConnectionsButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(732, 294);
            this.ControlBox = false;
            this.Controls.Add(this._testConnectionsButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._generalGroupBox);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._httpsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARGUS TV Notifier Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this._generalGroupBox.ResumeLayout(false);
            this._generalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._balloonTimeoutNumericUpDown)).EndInit();
            this._httpsGroupBox.ResumeLayout(false);
            this._httpsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portHttpsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.GroupBox _httpsGroupBox;
        private System.Windows.Forms.TextBox _serverHttpsTextBox;
        private System.Windows.Forms.Label _httpsServerLabel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _userNameTextBox;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.GroupBox _generalGroupBox;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _notificationLabel;
        private System.Windows.Forms.NumericUpDown _balloonTimeoutNumericUpDown;
        private System.Windows.Forms.Label _balloonSecsLabel;
        private System.Windows.Forms.CheckBox _showRecordingBalloonsCheckBox;
        private System.Windows.Forms.Label _balloonTimeoutLabel;
        private System.Windows.Forms.Button _browseMmcButton;
        private System.Windows.Forms.TextBox _mmcPathTextBox;
        private System.Windows.Forms.Label _mmcLabel;
        private System.Windows.Forms.OpenFileDialog _openMmcFileDialog;
        private System.Windows.Forms.Button _testConnectionsButton;
        private System.Windows.Forms.NumericUpDown _portHttpsNumericUpDown;
        private System.Windows.Forms.Label _httpsPortLabel;
    }
}