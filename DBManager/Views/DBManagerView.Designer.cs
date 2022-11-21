
namespace DBManager.Views
{
    partial class DBManagerView
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
            this.ConnectionAction_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateConnection_Button = new System.Windows.Forms.Button();
            this.RemoveConnection_Button = new System.Windows.Forms.Button();
            this.AddConnection_Button = new System.Windows.Forms.Button();
            this.Connection_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ConnectionTree_ConnectionTreeView = new DBManager.Views.ConnectionTreeView();
            this.Status_ConnectionStatusStrip = new DBManager.Views.OverridedControls.ConnectionStatusStrip();
            this.Connections_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Connection_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Database_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Table_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Content_ContentManagerView = new DBManager.Views.OverridedControls.ContentTableLayoutPanel();
            this.ConnectionAction_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Connection_SplitContainer)).BeginInit();
            this.Connection_SplitContainer.Panel1.SuspendLayout();
            this.Connection_SplitContainer.Panel2.SuspendLayout();
            this.Connection_SplitContainer.SuspendLayout();
            this.Status_ConnectionStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionAction_TableLayoutPanel
            // 
            this.ConnectionAction_TableLayoutPanel.ColumnCount = 3;
            this.ConnectionAction_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ConnectionAction_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ConnectionAction_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ConnectionAction_TableLayoutPanel.Controls.Add(this.UpdateConnection_Button, 0, 0);
            this.ConnectionAction_TableLayoutPanel.Controls.Add(this.RemoveConnection_Button, 0, 0);
            this.ConnectionAction_TableLayoutPanel.Controls.Add(this.AddConnection_Button, 0, 0);
            this.ConnectionAction_TableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.ConnectionAction_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnectionAction_TableLayoutPanel.Name = "ConnectionAction_TableLayoutPanel";
            this.ConnectionAction_TableLayoutPanel.RowCount = 1;
            this.ConnectionAction_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionAction_TableLayoutPanel.Size = new System.Drawing.Size(140, 42);
            this.ConnectionAction_TableLayoutPanel.TabIndex = 2;
            // 
            // UpdateConnection_Button
            // 
            this.UpdateConnection_Button.BackColor = System.Drawing.Color.White;
            this.UpdateConnection_Button.BackgroundImage = global::DBManager.Properties.Resources.SetupConnection;
            this.UpdateConnection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateConnection_Button.Enabled = false;
            this.UpdateConnection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateConnection_Button.Location = new System.Drawing.Point(96, 3);
            this.UpdateConnection_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateConnection_Button.Name = "UpdateConnection_Button";
            this.UpdateConnection_Button.Size = new System.Drawing.Size(40, 35);
            this.UpdateConnection_Button.TabIndex = 2;
            this.UpdateConnection_Button.UseVisualStyleBackColor = false;
            this.UpdateConnection_Button.Click += new System.EventHandler(this.UpdateConnection_Button_Click);
            // 
            // RemoveConnection_Button
            // 
            this.RemoveConnection_Button.BackColor = System.Drawing.Color.White;
            this.RemoveConnection_Button.BackgroundImage = global::DBManager.Properties.Resources.RemoveConnection;
            this.RemoveConnection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveConnection_Button.Enabled = false;
            this.RemoveConnection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveConnection_Button.Location = new System.Drawing.Point(50, 3);
            this.RemoveConnection_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveConnection_Button.Name = "RemoveConnection_Button";
            this.RemoveConnection_Button.Size = new System.Drawing.Size(38, 35);
            this.RemoveConnection_Button.TabIndex = 1;
            this.RemoveConnection_Button.UseVisualStyleBackColor = false;
            this.RemoveConnection_Button.Click += new System.EventHandler(this.RemoveConnection_Button_Click);
            // 
            // AddConnection_Button
            // 
            this.AddConnection_Button.BackColor = System.Drawing.Color.White;
            this.AddConnection_Button.BackgroundImage = global::DBManager.Properties.Resources.AddConnection;
            this.AddConnection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddConnection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConnection_Button.Location = new System.Drawing.Point(4, 3);
            this.AddConnection_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddConnection_Button.Name = "AddConnection_Button";
            this.AddConnection_Button.Size = new System.Drawing.Size(38, 35);
            this.AddConnection_Button.TabIndex = 0;
            this.AddConnection_Button.UseVisualStyleBackColor = false;
            this.AddConnection_Button.Click += new System.EventHandler(this.AddConnection_Button_Click);
            // 
            // Connection_SplitContainer
            // 
            this.Connection_SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Connection_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Connection_SplitContainer.Location = new System.Drawing.Point(15, 61);
            this.Connection_SplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Connection_SplitContainer.Name = "Connection_SplitContainer";
            // 
            // Connection_SplitContainer.Panel1
            // 
            this.Connection_SplitContainer.Panel1.Controls.Add(this.ConnectionTree_ConnectionTreeView);
            this.Connection_SplitContainer.Panel1MinSize = 140;
            // 
            // Connection_SplitContainer.Panel2
            // 
            this.Connection_SplitContainer.Panel2.Controls.Add(this.Content_ContentManagerView);
            this.Connection_SplitContainer.Size = new System.Drawing.Size(657, 375);
            this.Connection_SplitContainer.SplitterDistance = 163;
            this.Connection_SplitContainer.SplitterWidth = 10;
            this.Connection_SplitContainer.TabIndex = 5;
            // 
            // ConnectionTree_ConnectionTreeView
            // 
            this.ConnectionTree_ConnectionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree_ConnectionTreeView.Location = new System.Drawing.Point(0, 0);
            this.ConnectionTree_ConnectionTreeView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ConnectionTree_ConnectionTreeView.Name = "ConnectionTree_ConnectionTreeView";
            this.ConnectionTree_ConnectionTreeView.Size = new System.Drawing.Size(159, 371);
            this.ConnectionTree_ConnectionTreeView.TabIndex = 0;
            // 
            // Status_ConnectionStatusStrip
            // 
            this.Status_ConnectionStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connections_ToolStripStatusLabel,
            this.Connection_ToolStripStatusLabel,
            this.Database_ToolStripStatusLabel,
            this.Table_ToolStripStatusLabel});
            this.Status_ConnectionStatusStrip.Location = new System.Drawing.Point(0, 440);
            this.Status_ConnectionStatusStrip.Name = "Status_ConnectionStatusStrip";
            this.Status_ConnectionStatusStrip.Size = new System.Drawing.Size(684, 22);
            this.Status_ConnectionStatusStrip.TabIndex = 6;
            this.Status_ConnectionStatusStrip.Text = "connectionStatusStrip1";
            // 
            // Connections_ToolStripStatusLabel
            // 
            this.Connections_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.ConnectionIcon;
            this.Connections_ToolStripStatusLabel.Name = "Connections_ToolStripStatusLabel";
            this.Connections_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            // 
            // Connection_ToolStripStatusLabel
            // 
            this.Connection_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.ConnectionIcon;
            this.Connection_ToolStripStatusLabel.Name = "Connection_ToolStripStatusLabel";
            this.Connection_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.Connection_ToolStripStatusLabel.Visible = false;
            // 
            // Database_ToolStripStatusLabel
            // 
            this.Database_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.DatabaseIcon;
            this.Database_ToolStripStatusLabel.Name = "Database_ToolStripStatusLabel";
            this.Database_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.Database_ToolStripStatusLabel.Visible = false;
            // 
            // Table_ToolStripStatusLabel
            // 
            this.Table_ToolStripStatusLabel.Image = global::DBManager.Properties.Resources.TableIcon;
            this.Table_ToolStripStatusLabel.Name = "Table_ToolStripStatusLabel";
            this.Table_ToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.Table_ToolStripStatusLabel.Visible = false;
            // 
            // Content_ContentManagerView
            // 
            this.Content_ContentManagerView.ColumnCount = 1;
            this.Content_ContentManagerView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Content_ContentManagerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_ContentManagerView.Location = new System.Drawing.Point(0, 0);
            this.Content_ContentManagerView.Name = "Content_ContentManagerView";
            this.Content_ContentManagerView.RowCount = 1;
            this.Content_ContentManagerView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Content_ContentManagerView.Size = new System.Drawing.Size(480, 371);
            this.Content_ContentManagerView.TabIndex = 0;
            // 
            // DBManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.Status_ConnectionStatusStrip);
            this.Controls.Add(this.Connection_SplitContainer);
            this.Controls.Add(this.ConnectionAction_TableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(700, 501);
            this.Name = "DBManagerView";
            this.Text = "DBManager";
            this.ConnectionAction_TableLayoutPanel.ResumeLayout(false);
            this.Connection_SplitContainer.Panel1.ResumeLayout(false);
            this.Connection_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Connection_SplitContainer)).EndInit();
            this.Connection_SplitContainer.ResumeLayout(false);
            this.Status_ConnectionStatusStrip.ResumeLayout(false);
            this.Status_ConnectionStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConnectionAction_TableLayoutPanel;
        private System.Windows.Forms.Button AddConnection_Button;
        private System.Windows.Forms.Button RemoveConnection_Button;
        private System.Windows.Forms.Button UpdateConnection_Button;
        private System.Windows.Forms.SplitContainer Connection_SplitContainer;
        private ConnectionTreeView ConnectionTree_ConnectionTreeView;
        private OverridedControls.ConnectionStatusStrip Status_ConnectionStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Connections_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Connection_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Database_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Table_ToolStripStatusLabel;
        private OverridedControls.ContentTableLayoutPanel Content_ContentManagerView;
    }
}