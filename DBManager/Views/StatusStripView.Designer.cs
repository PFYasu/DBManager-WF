namespace DBManager.Views
{
    partial class StatusStripView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Status_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Connections_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Connection_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Database_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Table_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_StatusStrip
            // 
            this.Status_StatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Status_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connections_ToolStripStatusLabel,
            this.Connection_ToolStripStatusLabel,
            this.Database_ToolStripStatusLabel,
            this.Table_ToolStripStatusLabel});
            this.Status_StatusStrip.Location = new System.Drawing.Point(0, 0);
            this.Status_StatusStrip.Name = "Status_StatusStrip";
            this.Status_StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.Status_StatusStrip.Size = new System.Drawing.Size(175, 173);
            this.Status_StatusStrip.TabIndex = 0;
            this.Status_StatusStrip.Text = "statusStrip1";
            // 
            // Connections_ToolStripStatusLabel
            // 
            this.Connections_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.ConnectionIcon;
            this.Connections_ToolStripStatusLabel.Name = "Connections_ToolStripStatusLabel";
            this.Connections_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 168);
            // 
            // Connection_ToolStripStatusLabel
            // 
            this.Connection_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.ConnectionIcon;
            this.Connection_ToolStripStatusLabel.Name = "Connection_ToolStripStatusLabel";
            this.Connection_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 168);
            this.Connection_ToolStripStatusLabel.Visible = false;
            // 
            // Database_ToolStripStatusLabel
            // 
            this.Database_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.DatabaseIcon;
            this.Database_ToolStripStatusLabel.Name = "Database_ToolStripStatusLabel";
            this.Database_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 168);
            this.Database_ToolStripStatusLabel.Visible = false;
            // 
            // Table_ToolStripStatusLabel
            // 
            this.Table_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.TableIcon;
            this.Table_ToolStripStatusLabel.Name = "Table_ToolStripStatusLabel";
            this.Table_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 168);
            this.Table_ToolStripStatusLabel.Visible = false;
            // 
            // StatusStripView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Status_StatusStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StatusStripView";
            this.Size = new System.Drawing.Size(175, 173);
            this.Status_StatusStrip.ResumeLayout(false);
            this.Status_StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Connections_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Connection_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Database_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Table_ToolStripStatusLabel;
    }
}
