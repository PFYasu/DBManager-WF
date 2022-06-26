
namespace DBManager.Views
{
    partial class ExceptionView
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
            this.Close_Button = new System.Windows.Forms.Button();
            this.validationError = new System.Windows.Forms.Label();
            this.ExceptionType_Label = new System.Windows.Forms.Label();
            this.StackTrace_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.Location = new System.Drawing.Point(213, 179);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(309, 27);
            this.Close_Button.TabIndex = 6;
            this.Close_Button.Text = "Close application";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // validationError
            // 
            this.validationError.AutoSize = true;
            this.validationError.Location = new System.Drawing.Point(8, 200);
            this.validationError.Name = "validationError";
            this.validationError.Size = new System.Drawing.Size(0, 13);
            this.validationError.TabIndex = 10;
            // 
            // ExceptionType_Label
            // 
            this.ExceptionType_Label.AutoSize = true;
            this.ExceptionType_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ExceptionType_Label.Location = new System.Drawing.Point(3, 1);
            this.ExceptionType_Label.Name = "ExceptionType_Label";
            this.ExceptionType_Label.Size = new System.Drawing.Size(149, 30);
            this.ExceptionType_Label.TabIndex = 15;
            this.ExceptionType_Label.Text = "Exception type";
            // 
            // StackTrace_RichTextBox
            // 
            this.StackTrace_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StackTrace_RichTextBox.Location = new System.Drawing.Point(10, 34);
            this.StackTrace_RichTextBox.Name = "StackTrace_RichTextBox";
            this.StackTrace_RichTextBox.ReadOnly = true;
            this.StackTrace_RichTextBox.Size = new System.Drawing.Size(512, 139);
            this.StackTrace_RichTextBox.TabIndex = 16;
            this.StackTrace_RichTextBox.Text = "";
            // 
            // ExceptionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.StackTrace_RichTextBox);
            this.Controls.Add(this.ExceptionType_Label);
            this.Controls.Add(this.validationError);
            this.Controls.Add(this.Close_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(550, 250);
            this.Name = "ExceptionView";
            this.Text = "DBManager - exception view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label validationError;
        private System.Windows.Forms.Label ExceptionType_Label;
        private System.Windows.Forms.RichTextBox StackTrace_RichTextBox;
    }
}