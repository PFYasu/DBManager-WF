
namespace DBManager.Views
{
    partial class ConnectorSelectorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectorSelectorView));
            this.MySql_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SelectConnection_Label = new System.Windows.Forms.Label();
            this.PostgreSQL_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MySql_Button
            // 
            this.MySql_Button.BackColor = System.Drawing.Color.Silver;
            this.MySql_Button.Image = ((System.Drawing.Image)(resources.GetObject("MySql_Button.Image")));
            this.MySql_Button.Location = new System.Drawing.Point(10, 36);
            this.MySql_Button.Name = "MySql_Button";
            this.MySql_Button.Size = new System.Drawing.Size(129, 130);
            this.MySql_Button.TabIndex = 0;
            this.MySql_Button.UseVisualStyleBackColor = false;
            this.MySql_Button.Click += new System.EventHandler(this.MySql_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(10, 172);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(129, 20);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectConnection_Label
            // 
            this.SelectConnection_Label.AutoSize = true;
            this.SelectConnection_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.SelectConnection_Label.Location = new System.Drawing.Point(10, 8);
            this.SelectConnection_Label.Name = "SelectConnection_Label";
            this.SelectConnection_Label.Size = new System.Drawing.Size(177, 30);
            this.SelectConnection_Label.TabIndex = 2;
            this.SelectConnection_Label.Text = "Select connection";
            // 
            // PostgreSQL_Button
            // 
            this.PostgreSQL_Button.BackColor = System.Drawing.Color.Silver;
            this.PostgreSQL_Button.Image = ((System.Drawing.Image)(resources.GetObject("PostgreSQL_Button.Image")));
            this.PostgreSQL_Button.Location = new System.Drawing.Point(144, 36);
            this.PostgreSQL_Button.Name = "PostgreSQL_Button";
            this.PostgreSQL_Button.Size = new System.Drawing.Size(129, 130);
            this.PostgreSQL_Button.TabIndex = 1;
            this.PostgreSQL_Button.UseVisualStyleBackColor = false;
            this.PostgreSQL_Button.Click += new System.EventHandler(this.PostgreSQL_Button_Click);
            // 
            // ConnectorSelectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 198);
            this.Controls.Add(this.PostgreSQL_Button);
            this.Controls.Add(this.SelectConnection_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.MySql_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectorSelectorView";
            this.Text = "DBManager - select connection type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MySql_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label SelectConnection_Label;
        private System.Windows.Forms.Button PostgreSQL_Button;
    }
}