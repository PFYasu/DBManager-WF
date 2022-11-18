
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
            this.Information_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConnectionTree_ConnectionTreeView = new DBManager.Views.ConnectionTreeView();
            this.SuspendLayout();
            // 
            // TryCopyData_Button
            // 
            this.TryCopyData_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TryCopyData_Button.Enabled = false;
            this.TryCopyData_Button.Location = new System.Drawing.Point(14, 422);
            this.TryCopyData_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TryCopyData_Button.Name = "TryCopyData_Button";
            this.TryCopyData_Button.Size = new System.Drawing.Size(234, 27);
            this.TryCopyData_Button.TabIndex = 2;
            this.TryCopyData_Button.Text = "Try copy data";
            this.TryCopyData_Button.UseVisualStyleBackColor = true;
            this.TryCopyData_Button.Click += new System.EventHandler(this.TryCopyData_Button_Click);
            // 
            // SelectTable_Label
            // 
            this.SelectTable_Label.AutoSize = true;
            this.SelectTable_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTable_Label.Location = new System.Drawing.Point(10, 5);
            this.SelectTable_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectTable_Label.Name = "SelectTable_Label";
            this.SelectTable_Label.Size = new System.Drawing.Size(120, 30);
            this.SelectTable_Label.TabIndex = 16;
            this.SelectTable_Label.Text = "Select table";
            // 
            // Information_RichTextBox
            // 
            this.Information_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Information_RichTextBox.Location = new System.Drawing.Point(15, 44);
            this.Information_RichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Information_RichTextBox.Name = "Information_RichTextBox";
            this.Information_RichTextBox.ReadOnly = true;
            this.Information_RichTextBox.Size = new System.Drawing.Size(233, 38);
            this.Information_RichTextBox.TabIndex = 17;
            this.Information_RichTextBox.Text = "The selected table must match the query result.";
            // 
            // ConnectionTree_ConnectionTreeView
            // 
            this.ConnectionTree_ConnectionTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionTree_ConnectionTreeView.Location = new System.Drawing.Point(10, 88);
            this.ConnectionTree_ConnectionTreeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnectionTree_ConnectionTreeView.Name = "ConnectionTree_ConnectionTreeView";
            this.ConnectionTree_ConnectionTreeView.Size = new System.Drawing.Size(238, 328);
            this.ConnectionTree_ConnectionTreeView.TabIndex = 18;
            // 
            // DataTransferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 463);
            this.Controls.Add(this.ConnectionTree_ConnectionTreeView);
            this.Controls.Add(this.Information_RichTextBox);
            this.Controls.Add(this.SelectTable_Label);
            this.Controls.Add(this.TryCopyData_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(278, 502);
            this.Name = "DataTransferView";
            this.Text = "DBManager - data transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TryCopyData_Button;
        private System.Windows.Forms.Label SelectTable_Label;
        private System.Windows.Forms.RichTextBox Information_RichTextBox;
        private ConnectionTreeView ConnectionTree_ConnectionTreeView;
    }
}