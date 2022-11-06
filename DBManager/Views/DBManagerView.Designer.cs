
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBManagerView));
            this.Status_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.numberOfConnections = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeTable = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionAction_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateConnection_Button = new System.Windows.Forms.Button();
            this.RemoveConnection_Button = new System.Windows.Forms.Button();
            this.AddConnection_Button = new System.Windows.Forms.Button();
            this.Connection_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ConnectionTree_ConnectionTreeView = new DBManager.Views.ConnectionTreeView();
            this.Content_ContentManagerView = new DBManager.Views.ContentManagerView();
            this.Status_StatusStrip.SuspendLayout();
            this.ConnectionAction_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Connection_SplitContainer)).BeginInit();
            this.Connection_SplitContainer.Panel1.SuspendLayout();
            this.Connection_SplitContainer.Panel2.SuspendLayout();
            this.Connection_SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_StatusStrip
            // 
            this.Status_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfConnections,
            this.activeConnection,
            this.activeDatabase,
            this.activeTable});
            this.Status_StatusStrip.Location = new System.Drawing.Point(0, 378);
            this.Status_StatusStrip.Name = "Status_StatusStrip";
            this.Status_StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.Status_StatusStrip.Size = new System.Drawing.Size(586, 22);
            this.Status_StatusStrip.TabIndex = 0;
            this.Status_StatusStrip.Text = "statusStrip1";
            // 
            // numberOfConnections
            // 
            this.numberOfConnections.ForeColor = System.Drawing.Color.Black;
            this.numberOfConnections.Name = "numberOfConnections";
            this.numberOfConnections.Size = new System.Drawing.Size(0, 17);
            // 
            // activeConnection
            // 
            this.activeConnection.ForeColor = System.Drawing.Color.Black;
            this.activeConnection.Name = "activeConnection";
            this.activeConnection.Size = new System.Drawing.Size(0, 17);
            // 
            // activeDatabase
            // 
            this.activeDatabase.ForeColor = System.Drawing.Color.Black;
            this.activeDatabase.Name = "activeDatabase";
            this.activeDatabase.Size = new System.Drawing.Size(0, 17);
            // 
            // activeTable
            // 
            this.activeTable.ForeColor = System.Drawing.Color.Black;
            this.activeTable.Name = "activeTable";
            this.activeTable.Size = new System.Drawing.Size(0, 17);
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
            this.ConnectionAction_TableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.ConnectionAction_TableLayoutPanel.Name = "ConnectionAction_TableLayoutPanel";
            this.ConnectionAction_TableLayoutPanel.RowCount = 1;
            this.ConnectionAction_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionAction_TableLayoutPanel.Size = new System.Drawing.Size(120, 36);
            this.ConnectionAction_TableLayoutPanel.TabIndex = 2;
            // 
            // UpdateConnection_Button
            // 
            this.UpdateConnection_Button.BackColor = System.Drawing.Color.White;
            this.UpdateConnection_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateConnection_Button.BackgroundImage")));
            this.UpdateConnection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateConnection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateConnection_Button.Location = new System.Drawing.Point(83, 3);
            this.UpdateConnection_Button.Name = "UpdateConnection_Button";
            this.UpdateConnection_Button.Size = new System.Drawing.Size(34, 30);
            this.UpdateConnection_Button.TabIndex = 2;
            this.UpdateConnection_Button.UseVisualStyleBackColor = false;
            this.UpdateConnection_Button.Click += new System.EventHandler(this.UpdateConnection_Button_Click);
            // 
            // RemoveConnection_Button
            // 
            this.RemoveConnection_Button.BackColor = System.Drawing.Color.White;
            this.RemoveConnection_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveConnection_Button.BackgroundImage")));
            this.RemoveConnection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveConnection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveConnection_Button.Location = new System.Drawing.Point(43, 3);
            this.RemoveConnection_Button.Name = "RemoveConnection_Button";
            this.RemoveConnection_Button.Size = new System.Drawing.Size(34, 30);
            this.RemoveConnection_Button.TabIndex = 1;
            this.RemoveConnection_Button.UseVisualStyleBackColor = false;
            this.RemoveConnection_Button.Click += new System.EventHandler(this.RemoveConnection_Button_Click);
            // 
            // AddConnection_Button
            // 
            this.AddConnection_Button.BackColor = System.Drawing.Color.White;
            this.AddConnection_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddConnection_Button.BackgroundImage")));
            this.AddConnection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddConnection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConnection_Button.Location = new System.Drawing.Point(3, 3);
            this.AddConnection_Button.Name = "AddConnection_Button";
            this.AddConnection_Button.Size = new System.Drawing.Size(34, 30);
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
            this.Connection_SplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Connection_SplitContainer.Location = new System.Drawing.Point(13, 53);
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
            this.Connection_SplitContainer.Size = new System.Drawing.Size(563, 325);
            this.Connection_SplitContainer.SplitterDistance = 140;
            this.Connection_SplitContainer.SplitterWidth = 9;
            this.Connection_SplitContainer.TabIndex = 5;
            // 
            // ConnectionTree_ConnectionTreeView
            // 
            this.ConnectionTree_ConnectionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree_ConnectionTreeView.Location = new System.Drawing.Point(0, 0);
            this.ConnectionTree_ConnectionTreeView.Name = "ConnectionTree_ConnectionTreeView";
            this.ConnectionTree_ConnectionTreeView.Size = new System.Drawing.Size(136, 321);
            this.ConnectionTree_ConnectionTreeView.TabIndex = 0;
            // 
            // Content_ContentManagerView
            // 
            this.Content_ContentManagerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_ContentManagerView.Location = new System.Drawing.Point(0, 0);
            this.Content_ContentManagerView.Name = "Content_ContentManagerView";
            this.Content_ContentManagerView.Size = new System.Drawing.Size(410, 321);
            this.Content_ContentManagerView.TabIndex = 0;
            // 
            // DBManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 400);
            this.Controls.Add(this.Connection_SplitContainer);
            this.Controls.Add(this.ConnectionAction_TableLayoutPanel);
            this.Controls.Add(this.Status_StatusStrip);
            this.MinimumSize = new System.Drawing.Size(602, 439);
            this.Name = "DBManagerView";
            this.Text = "DBManager";
            this.Status_StatusStrip.ResumeLayout(false);
            this.Status_StatusStrip.PerformLayout();
            this.ConnectionAction_TableLayoutPanel.ResumeLayout(false);
            this.Connection_SplitContainer.Panel1.ResumeLayout(false);
            this.Connection_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Connection_SplitContainer)).EndInit();
            this.Connection_SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status_StatusStrip;
        private System.Windows.Forms.TableLayoutPanel ConnectionAction_TableLayoutPanel;
        private System.Windows.Forms.Button AddConnection_Button;
        private System.Windows.Forms.Button RemoveConnection_Button;
        private System.Windows.Forms.Button UpdateConnection_Button;
        private System.Windows.Forms.ToolStripStatusLabel numberOfConnections;
        private System.Windows.Forms.ToolStripStatusLabel activeConnection;
        private System.Windows.Forms.SplitContainer Connection_SplitContainer;
        private System.Windows.Forms.ToolStripStatusLabel activeDatabase;
        private System.Windows.Forms.ToolStripStatusLabel activeTable;
        private ConnectionTreeView ConnectionTree_ConnectionTreeView;
        private ContentManagerView Content_ContentManagerView;
    }
}