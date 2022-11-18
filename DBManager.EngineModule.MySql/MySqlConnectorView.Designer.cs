using DBManager.Core.Views.OverridedViews;

namespace DBManager.EngineModule.MySql
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
            this.ServerUrl_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.ServerUrl_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.validationError = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Port_Label = new System.Windows.Forms.Label();
            this.ConnectionParameters_Label = new System.Windows.Forms.Label();
            this.ConnectionLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Port_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ErrorProvider_DBManagerErrorProvider = new DBManager.Core.Views.OverridedViews.DBManagerErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionLogo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_DBManagerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerUrl_TextBox
            // 
            this.ServerUrl_TextBox.Location = new System.Drawing.Point(12, 120);
            this.ServerUrl_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServerUrl_TextBox.Name = "ServerUrl_TextBox";
            this.ServerUrl_TextBox.Size = new System.Drawing.Size(190, 23);
            this.ServerUrl_TextBox.TabIndex = 1;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(12, 177);
            this.Username_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(190, 23);
            this.Username_TextBox.TabIndex = 4;
            // 
            // ServerUrl_Label
            // 
            this.ServerUrl_Label.AutoSize = true;
            this.ServerUrl_Label.Location = new System.Drawing.Point(12, 102);
            this.ServerUrl_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerUrl_Label.Name = "ServerUrl_Label";
            this.ServerUrl_Label.Size = new System.Drawing.Size(63, 15);
            this.ServerUrl_Label.TabIndex = 4;
            this.ServerUrl_Label.Text = "Server URL";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(12, 158);
            this.Username_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(60, 15);
            this.Username_Label.TabIndex = 5;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(214, 158);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(57, 15);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(208, 177);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(164, 23);
            this.Password_TextBox.TabIndex = 5;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(89, 205);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(284, 23);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(12, 205);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(70, 23);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // validationError
            // 
            this.validationError.AutoSize = true;
            this.validationError.Location = new System.Drawing.Point(9, 231);
            this.validationError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.validationError.Name = "validationError";
            this.validationError.Size = new System.Drawing.Size(0, 15);
            this.validationError.TabIndex = 10;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(12, 48);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(39, 15);
            this.Name_Label.TabIndex = 12;
            this.Name_Label.Text = "Name";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(12, 66);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(190, 23);
            this.Name_TextBox.TabIndex = 0;
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.Location = new System.Drawing.Point(208, 102);
            this.Port_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(29, 15);
            this.Port_Label.TabIndex = 14;
            this.Port_Label.Text = "Port";
            // 
            // ConnectionParameters_Label
            // 
            this.ConnectionParameters_Label.AutoSize = true;
            this.ConnectionParameters_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectionParameters_Label.Location = new System.Drawing.Point(4, 9);
            this.ConnectionParameters_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnectionParameters_Label.Name = "ConnectionParameters_Label";
            this.ConnectionParameters_Label.Size = new System.Drawing.Size(229, 30);
            this.ConnectionParameters_Label.TabIndex = 15;
            this.ConnectionParameters_Label.Text = "Connection parameters";
            // 
            // ConnectionLogo_PictureBox
            // 
            this.ConnectionLogo_PictureBox.BackgroundImage = global::DBManager.EngineModule.MySql.Properties.Resource.MySqlIcon;
            this.ConnectionLogo_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConnectionLogo_PictureBox.Location = new System.Drawing.Point(275, 12);
            this.ConnectionLogo_PictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnectionLogo_PictureBox.Name = "ConnectionLogo_PictureBox";
            this.ConnectionLogo_PictureBox.Size = new System.Drawing.Size(100, 100);
            this.ConnectionLogo_PictureBox.TabIndex = 16;
            this.ConnectionLogo_PictureBox.TabStop = false;
            // 
            // Port_NumericUpDown
            // 
            this.Port_NumericUpDown.Location = new System.Drawing.Point(208, 120);
            this.Port_NumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Port_NumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Port_NumericUpDown.Name = "Port_NumericUpDown";
            this.Port_NumericUpDown.Size = new System.Drawing.Size(57, 23);
            this.Port_NumericUpDown.TabIndex = 3;
            // 
            // ErrorProvider_DBManagerErrorProvider
            // 
            this.ErrorProvider_DBManagerErrorProvider.ContainerControl = this;
            // 
            // MySqlConnectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 237);
            this.Controls.Add(this.Port_NumericUpDown);
            this.Controls.Add(this.ConnectionLogo_PictureBox);
            this.Controls.Add(this.ConnectionParameters_Label);
            this.Controls.Add(this.Port_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.validationError);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.ServerUrl_Label);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.ServerUrl_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MySqlConnectorView";
            this.Text = "DBManager - MySQL connector configuration";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionLogo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_DBManagerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerUrl_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Label ServerUrl_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label validationError;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label Port_Label;
        private System.Windows.Forms.Label ConnectionParameters_Label;
        private System.Windows.Forms.PictureBox ConnectionLogo_PictureBox;
        private System.Windows.Forms.NumericUpDown Port_NumericUpDown;
        private DBManagerErrorProvider ErrorProvider_DBManagerErrorProvider;
    }
}