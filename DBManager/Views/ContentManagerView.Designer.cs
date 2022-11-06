namespace DBManager.Views
{
    partial class ContentManagerView
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
            this.Content_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Content_TableLayoutPanel
            // 
            this.Content_TableLayoutPanel.AutoSize = true;
            this.Content_TableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Content_TableLayoutPanel.ColumnCount = 1;
            this.Content_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Content_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_TableLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.Content_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Content_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Content_TableLayoutPanel.Name = "Content_TableLayoutPanel";
            this.Content_TableLayoutPanel.RowCount = 1;
            this.Content_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Content_TableLayoutPanel.Size = new System.Drawing.Size(150, 150);
            this.Content_TableLayoutPanel.TabIndex = 4;
            // 
            // ConnectionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content_TableLayoutPanel);
            this.Name = "ConnectionManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Content_TableLayoutPanel;
    }
}
