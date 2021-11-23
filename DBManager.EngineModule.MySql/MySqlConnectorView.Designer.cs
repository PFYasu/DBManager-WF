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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySqlConnectorView));
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
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionLogo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerUrl_TextBox
            // 
            this.ServerUrl_TextBox.Location = new System.Drawing.Point(10, 104);
            this.ServerUrl_TextBox.Name = "ServerUrl_TextBox";
            this.ServerUrl_TextBox.Size = new System.Drawing.Size(163, 20);
            this.ServerUrl_TextBox.TabIndex = 1;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(10, 153);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(163, 20);
            this.Username_TextBox.TabIndex = 4;
            // 
            // ServerUrl_Label
            // 
            this.ServerUrl_Label.AutoSize = true;
            this.ServerUrl_Label.Location = new System.Drawing.Point(10, 88);
            this.ServerUrl_Label.Name = "ServerUrl_Label";
            this.ServerUrl_Label.Size = new System.Drawing.Size(63, 13);
            this.ServerUrl_Label.TabIndex = 4;
            this.ServerUrl_Label.Text = "Server URL";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(10, 137);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(55, 13);
            this.Username_Label.TabIndex = 5;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(183, 137);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(178, 153);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(141, 20);
            this.Password_TextBox.TabIndex = 5;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(76, 178);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(243, 20);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(10, 178);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(60, 20);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // validationError
            // 
            this.validationError.AutoSize = true;
            this.validationError.Location = new System.Drawing.Point(8, 200);
            this.validationError.Name = "validationError";
            this.validationError.Size = new System.Drawing.Size(0, 13);
            this.validationError.TabIndex = 10;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(10, 42);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 12;
            this.Name_Label.Text = "Name";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(10, 57);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(163, 20);
            this.Name_TextBox.TabIndex = 0;
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.Location = new System.Drawing.Point(178, 88);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(26, 13);
            this.Port_Label.TabIndex = 14;
            this.Port_Label.Text = "Port";
            // 
            // ConnectionParameters_Label
            // 
            this.ConnectionParameters_Label.AutoSize = true;
            this.ConnectionParameters_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ConnectionParameters_Label.Location = new System.Drawing.Point(3, 8);
            this.ConnectionParameters_Label.Name = "ConnectionParameters_Label";
            this.ConnectionParameters_Label.Size = new System.Drawing.Size(229, 30);
            this.ConnectionParameters_Label.TabIndex = 15;
            this.ConnectionParameters_Label.Text = "Connection parameters";
            // 
            // ConnectionLogo_PictureBox
            // 
            this.ConnectionLogo_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConnectionLogo_PictureBox.BackgroundImage")));
            this.ConnectionLogo_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConnectionLogo_PictureBox.Location = new System.Drawing.Point(236, 10);
            this.ConnectionLogo_PictureBox.Name = "ConnectionLogo_PictureBox";
            this.ConnectionLogo_PictureBox.Size = new System.Drawing.Size(86, 87);
            this.ConnectionLogo_PictureBox.TabIndex = 16;
            this.ConnectionLogo_PictureBox.TabStop = false;
            // 
            // Port_NumericUpDown
            // 
            this.Port_NumericUpDown.Location = new System.Drawing.Point(178, 104);
            this.Port_NumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Port_NumericUpDown.Name = "Port_NumericUpDown";
            this.Port_NumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.Port_NumericUpDown.TabIndex = 3;
            // 
            // MySqlConnectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 205);
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
            this.Name = "MySqlConnectorView";
            this.Text = "DBManager - MySQL connector configuration";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionLogo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Port_NumericUpDown)).EndInit();
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
    }
}