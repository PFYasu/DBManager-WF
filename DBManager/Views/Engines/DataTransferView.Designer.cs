
namespace DBManager.Views.Engines
{
    partial class DataTransferView
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
            this.TryCopyData_Button = new System.Windows.Forms.Button();
            this.SelectTable_Label = new System.Windows.Forms.Label();
            this.ConnectionTree_ConnectionTreeView = new DBManager.Views.ConnectionTreeView();
            this.Information_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TryCopyData_Button
            // 
            this.TryCopyData_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TryCopyData_Button.Location = new System.Drawing.Point(12, 366);
            this.TryCopyData_Button.Name = "TryCopyData_Button";
            this.TryCopyData_Button.Size = new System.Drawing.Size(201, 23);
            this.TryCopyData_Button.TabIndex = 2;
            this.TryCopyData_Button.Text = "Try copy data";
            this.TryCopyData_Button.UseVisualStyleBackColor = true;
            this.TryCopyData_Button.Click += new System.EventHandler(this.TryCopyData_Button_Click);
            // 
            // SelectTable_Label
            // 
            this.SelectTable_Label.AutoSize = true;
            this.SelectTable_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.SelectTable_Label.Location = new System.Drawing.Point(9, 4);
            this.SelectTable_Label.Name = "SelectTable_Label";
            this.SelectTable_Label.Size = new System.Drawing.Size(120, 30);
            this.SelectTable_Label.TabIndex = 16;
            this.SelectTable_Label.Text = "Select table";
            // 
            // ConnectionTree_ConnectionTreeView
            // 
            this.ConnectionTree_ConnectionTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionTree_ConnectionTreeView.Location = new System.Drawing.Point(12, 69);
            this.ConnectionTree_ConnectionTreeView.Name = "ConnectionTree_ConnectionTreeView";
            this.ConnectionTree_ConnectionTreeView.Size = new System.Drawing.Size(201, 291);
            this.ConnectionTree_ConnectionTreeView.TabIndex = 1;
            // 
            // Information_RichTextBox
            // 
            this.Information_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Information_RichTextBox.Location = new System.Drawing.Point(13, 38);
            this.Information_RichTextBox.Name = "Information_RichTextBox";
            this.Information_RichTextBox.ReadOnly = true;
            this.Information_RichTextBox.Size = new System.Drawing.Size(200, 33);
            this.Information_RichTextBox.TabIndex = 17;
            this.Information_RichTextBox.Text = "The selected table must match the query result.";
            // 
            // DataTransferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 401);
            this.Controls.Add(this.Information_RichTextBox);
            this.Controls.Add(this.SelectTable_Label);
            this.Controls.Add(this.TryCopyData_Button);
            this.Controls.Add(this.ConnectionTree_ConnectionTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DataTransferView";
            this.Text = "DBManager - data transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConnectionTreeView ConnectionTree_ConnectionTreeView;
        private System.Windows.Forms.Button TryCopyData_Button;
        private System.Windows.Forms.Label SelectTable_Label;
        private System.Windows.Forms.RichTextBox Information_RichTextBox;
    }
}