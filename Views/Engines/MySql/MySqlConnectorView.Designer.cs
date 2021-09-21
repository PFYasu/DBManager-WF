
namespace DBManager.Views.Engines.MySql
{
    partial class MySqlConnectorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySqlConnectorView));
            this.serverUrl = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.serverUrlLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.addConnection = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.validationError = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.setConnectorParametersLabel = new System.Windows.Forms.Label();
            this.connectionLogo = new System.Windows.Forms.PictureBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.connectionLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // serverUrl
            // 
            this.serverUrl.Location = new System.Drawing.Point(12, 120);
            this.serverUrl.Name = "serverUrl";
            this.serverUrl.Size = new System.Drawing.Size(190, 23);
            this.serverUrl.TabIndex = 1;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 176);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(190, 23);
            this.username.TabIndex = 4;
            // 
            // serverUrlLabel
            // 
            this.serverUrlLabel.AutoSize = true;
            this.serverUrlLabel.Location = new System.Drawing.Point(12, 102);
            this.serverUrlLabel.Name = "serverUrlLabel";
            this.serverUrlLabel.Size = new System.Drawing.Size(63, 15);
            this.serverUrlLabel.TabIndex = 4;
            this.serverUrlLabel.Text = "Server URL";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 158);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(214, 158);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(208, 176);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(164, 23);
            this.password.TabIndex = 5;
            // 
            // addConnection
            // 
            this.addConnection.Location = new System.Drawing.Point(73, 205);
            this.addConnection.Name = "addConnection";
            this.addConnection.Size = new System.Drawing.Size(299, 23);
            this.addConnection.TabIndex = 6;
            this.addConnection.Text = "Save";
            this.addConnection.UseVisualStyleBackColor = true;
            this.addConnection.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 205);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(55, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // validationError
            // 
            this.validationError.AutoSize = true;
            this.validationError.Location = new System.Drawing.Point(9, 231);
            this.validationError.Name = "validationError";
            this.validationError.Size = new System.Drawing.Size(0, 15);
            this.validationError.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 66);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(190, 23);
            this.name.TabIndex = 0;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(208, 102);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 15);
            this.portLabel.TabIndex = 14;
            this.portLabel.Text = "Port";
            // 
            // setConnectorParametersLabel
            // 
            this.setConnectorParametersLabel.AutoSize = true;
            this.setConnectorParametersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setConnectorParametersLabel.Location = new System.Drawing.Point(4, 9);
            this.setConnectorParametersLabel.Name = "setConnectorParametersLabel";
            this.setConnectorParametersLabel.Size = new System.Drawing.Size(261, 30);
            this.setConnectorParametersLabel.TabIndex = 15;
            this.setConnectorParametersLabel.Text = "Set connection parameters";
            // 
            // connectionLogo
            // 
            this.connectionLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectionLogo.BackgroundImage")));
            this.connectionLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectionLogo.Location = new System.Drawing.Point(275, 12);
            this.connectionLogo.Name = "connectionLogo";
            this.connectionLogo.Size = new System.Drawing.Size(100, 100);
            this.connectionLogo.TabIndex = 16;
            this.connectionLogo.TabStop = false;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(208, 120);
            this.port.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(57, 23);
            this.port.TabIndex = 3;
            // 
            // MySqlConnectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 237);
            this.Controls.Add(this.port);
            this.Controls.Add(this.connectionLogo);
            this.Controls.Add(this.setConnectorParametersLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.validationError);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addConnection);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serverUrlLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.serverUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MySqlConnectorView";
            this.Text = "DBManager - MySQL connector configuration";
            ((System.ComponentModel.ISupportInitialize)(this.connectionLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverUrl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label serverUrlLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button addConnection;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label validationError;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label setConnectorParametersLabel;
        private System.Windows.Forms.PictureBox connectionLogo;
        private System.Windows.Forms.NumericUpDown port;
    }
}