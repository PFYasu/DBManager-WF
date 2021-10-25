
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
            this.tryCopyData_button = new System.Windows.Forms.Button();
            this.selectTable_label = new System.Windows.Forms.Label();
            this.connectionTreeView = new DBManager.Views.ConnectionTreeView();
            this.info_label = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tryCopyData_button
            // 
            this.tryCopyData_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tryCopyData_button.Location = new System.Drawing.Point(12, 366);
            this.tryCopyData_button.Name = "tryCopyData_button";
            this.tryCopyData_button.Size = new System.Drawing.Size(201, 23);
            this.tryCopyData_button.TabIndex = 2;
            this.tryCopyData_button.Text = "Try copy data";
            this.tryCopyData_button.UseVisualStyleBackColor = true;
            this.tryCopyData_button.Click += new System.EventHandler(this.tryCopyData_button_Click);
            // 
            // selectTable_label
            // 
            this.selectTable_label.AutoSize = true;
            this.selectTable_label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.selectTable_label.Location = new System.Drawing.Point(9, 4);
            this.selectTable_label.Name = "selectTable_label";
            this.selectTable_label.Size = new System.Drawing.Size(120, 30);
            this.selectTable_label.TabIndex = 16;
            this.selectTable_label.Text = "Select table";
            // 
            // connectionTreeView
            // 
            this.connectionTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionTreeView.Location = new System.Drawing.Point(12, 69);
            this.connectionTreeView.Name = "connectionTreeView";
            this.connectionTreeView.Size = new System.Drawing.Size(201, 291);
            this.connectionTreeView.TabIndex = 1;
            // 
            // info_label
            // 
            this.info_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_label.Location = new System.Drawing.Point(13, 38);
            this.info_label.Name = "info_label";
            this.info_label.ReadOnly = true;
            this.info_label.Size = new System.Drawing.Size(200, 33);
            this.info_label.TabIndex = 17;
            this.info_label.Text = "The selected table must match the query result.";
            // 
            // DataTransferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 401);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.selectTable_label);
            this.Controls.Add(this.tryCopyData_button);
            this.Controls.Add(this.connectionTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DataTransferView";
            this.Text = "DBManager - data transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConnectionTreeView connectionTreeView;
        private System.Windows.Forms.Button tryCopyData_button;
        private System.Windows.Forms.Label selectTable_label;
        private System.Windows.Forms.RichTextBox info_label;
    }
}