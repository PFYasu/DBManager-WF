
namespace DBManager.Views.Engines
{
    partial class NewTrackedQueryView
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
            this.Query_Label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.validationError = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.TimePeriod_Label = new System.Windows.Forms.Label();
            this.TrackedQueryParameters_Label = new System.Windows.Forms.Label();
            this.TimePeriod_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Query_RichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimePeriod_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Query_Label
            // 
            this.Query_Label.AutoSize = true;
            this.Query_Label.Location = new System.Drawing.Point(10, 81);
            this.Query_Label.Name = "Query_Label";
            this.Query_Label.Size = new System.Drawing.Size(35, 13);
            this.Query_Label.TabIndex = 5;
            this.Query_Label.Text = "Query";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(75, 178);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(244, 20);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(10, 178);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(59, 20);
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
            this.Name_TextBox.Size = new System.Drawing.Size(188, 20);
            this.Name_TextBox.TabIndex = 0;
            // 
            // TimePeriod_Label
            // 
            this.TimePeriod_Label.AutoSize = true;
            this.TimePeriod_Label.Location = new System.Drawing.Point(201, 41);
            this.TimePeriod_Label.Name = "TimePeriod_Label";
            this.TimePeriod_Label.Size = new System.Drawing.Size(118, 13);
            this.TimePeriod_Label.TabIndex = 14;
            this.TimePeriod_Label.Text = "Time period (in minutes)";
            // 
            // TrackedQueryParameters_Label
            // 
            this.TrackedQueryParameters_Label.AutoSize = true;
            this.TrackedQueryParameters_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.TrackedQueryParameters_Label.Location = new System.Drawing.Point(3, 8);
            this.TrackedQueryParameters_Label.Name = "TrackedQueryParameters_Label";
            this.TrackedQueryParameters_Label.Size = new System.Drawing.Size(251, 30);
            this.TrackedQueryParameters_Label.TabIndex = 15;
            this.TrackedQueryParameters_Label.Text = "Tracked query parameters";
            // 
            // TimePeriod_NumericUpDown
            // 
            this.TimePeriod_NumericUpDown.Location = new System.Drawing.Point(204, 57);
            this.TimePeriod_NumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.TimePeriod_NumericUpDown.Name = "TimePeriod_NumericUpDown";
            this.TimePeriod_NumericUpDown.Size = new System.Drawing.Size(115, 20);
            this.TimePeriod_NumericUpDown.TabIndex = 3;
            this.TimePeriod_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Query_RichTextBox
            // 
            this.Query_RichTextBox.Location = new System.Drawing.Point(10, 97);
            this.Query_RichTextBox.Name = "Query_RichTextBox";
            this.Query_RichTextBox.Size = new System.Drawing.Size(309, 75);
            this.Query_RichTextBox.TabIndex = 16;
            this.Query_RichTextBox.Text = "";
            // 
            // NewTrackedQueryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 205);
            this.Controls.Add(this.Query_RichTextBox);
            this.Controls.Add(this.TimePeriod_NumericUpDown);
            this.Controls.Add(this.TrackedQueryParameters_Label);
            this.Controls.Add(this.TimePeriod_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.validationError);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Query_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTrackedQueryView";
            this.Text = "DBManager - New tracked query configuration";
            ((System.ComponentModel.ISupportInitialize)(this.TimePeriod_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Query_Label;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label validationError;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label TimePeriod_Label;
        private System.Windows.Forms.Label TrackedQueryParameters_Label;
        private System.Windows.Forms.NumericUpDown TimePeriod_NumericUpDown;
        private System.Windows.Forms.RichTextBox Query_RichTextBox;
    }
}