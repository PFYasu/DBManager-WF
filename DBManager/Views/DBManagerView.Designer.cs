
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.numberOfConnections = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.activeTable = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionServiceLayout = new System.Windows.Forms.TableLayoutPanel();
            this.setConnectionConfig = new System.Windows.Forms.Button();
            this.removeConnection = new System.Windows.Forms.Button();
            this.addConnection = new System.Windows.Forms.Button();
            this.connectionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connectionTree = new System.Windows.Forms.TreeView();
            this.connectionSplitContainer = new System.Windows.Forms.SplitContainer();
            this.statusStrip.SuspendLayout();
            this.connectionServiceLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionSplitContainer)).BeginInit();
            this.connectionSplitContainer.Panel1.SuspendLayout();
            this.connectionSplitContainer.Panel2.SuspendLayout();
            this.connectionSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfConnections,
            this.activeConnection,
            this.activeDatabase,
            this.activeTable});
            this.statusStrip.Location = new System.Drawing.Point(0, 378);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(586, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
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
            // connectionServiceLayout
            // 
            this.connectionServiceLayout.ColumnCount = 3;
            this.connectionServiceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionServiceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionServiceLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionServiceLayout.Controls.Add(this.setConnectionConfig, 0, 0);
            this.connectionServiceLayout.Controls.Add(this.removeConnection, 0, 0);
            this.connectionServiceLayout.Controls.Add(this.addConnection, 0, 0);
            this.connectionServiceLayout.Location = new System.Drawing.Point(10, 10);
            this.connectionServiceLayout.Name = "connectionServiceLayout";
            this.connectionServiceLayout.RowCount = 1;
            this.connectionServiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connectionServiceLayout.Size = new System.Drawing.Size(120, 36);
            this.connectionServiceLayout.TabIndex = 2;
            // 
            // setConnectionConfig
            // 
            this.setConnectionConfig.BackColor = System.Drawing.Color.White;
            this.setConnectionConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setConnectionConfig.BackgroundImage")));
            this.setConnectionConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setConnectionConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setConnectionConfig.Location = new System.Drawing.Point(83, 3);
            this.setConnectionConfig.Name = "setConnectionConfig";
            this.setConnectionConfig.Size = new System.Drawing.Size(34, 30);
            this.setConnectionConfig.TabIndex = 2;
            this.setConnectionConfig.UseVisualStyleBackColor = false;
            this.setConnectionConfig.Click += new System.EventHandler(this.setConnectionConfig_Click);
            // 
            // removeConnection
            // 
            this.removeConnection.BackColor = System.Drawing.Color.White;
            this.removeConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeConnection.BackgroundImage")));
            this.removeConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeConnection.Location = new System.Drawing.Point(43, 3);
            this.removeConnection.Name = "removeConnection";
            this.removeConnection.Size = new System.Drawing.Size(34, 30);
            this.removeConnection.TabIndex = 1;
            this.removeConnection.UseVisualStyleBackColor = false;
            this.removeConnection.Click += new System.EventHandler(this.removeConnection_Click);
            // 
            // addConnection
            // 
            this.addConnection.BackColor = System.Drawing.Color.White;
            this.addConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addConnection.BackgroundImage")));
            this.addConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addConnection.Location = new System.Drawing.Point(3, 3);
            this.addConnection.Name = "addConnection";
            this.addConnection.Size = new System.Drawing.Size(34, 30);
            this.addConnection.TabIndex = 0;
            this.addConnection.UseVisualStyleBackColor = false;
            this.addConnection.Click += new System.EventHandler(this.addConnection_Click);
            // 
            // connectionsLayout
            // 
            this.connectionsLayout.AutoSize = true;
            this.connectionsLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectionsLayout.ColumnCount = 1;
            this.connectionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsLayout.ForeColor = System.Drawing.Color.White;
            this.connectionsLayout.Location = new System.Drawing.Point(0, 0);
            this.connectionsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.connectionsLayout.Name = "connectionsLayout";
            this.connectionsLayout.RowCount = 1;
            this.connectionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionsLayout.Size = new System.Drawing.Size(410, 321);
            this.connectionsLayout.TabIndex = 3;
            // 
            // connectionTree
            // 
            this.connectionTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionTree.BackColor = System.Drawing.Color.White;
            this.connectionTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionTree.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionTree.ForeColor = System.Drawing.Color.Black;
            this.connectionTree.Indent = 8;
            this.connectionTree.Location = new System.Drawing.Point(3, 3);
            this.connectionTree.Name = "connectionTree";
            this.connectionTree.ShowPlusMinus = false;
            this.connectionTree.Size = new System.Drawing.Size(130, 315);
            this.connectionTree.TabIndex = 4;
            this.connectionTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.connectionTree_NodeMouseClick);
            // 
            // connectionSplitContainer
            // 
            this.connectionSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connectionSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectionSplitContainer.Location = new System.Drawing.Point(13, 53);
            this.connectionSplitContainer.Name = "connectionSplitContainer";
            // 
            // connectionSplitContainer.Panel1
            // 
            this.connectionSplitContainer.Panel1.Controls.Add(this.connectionTree);
            this.connectionSplitContainer.Panel1MinSize = 140;
            // 
            // connectionSplitContainer.Panel2
            // 
            this.connectionSplitContainer.Panel2.Controls.Add(this.connectionsLayout);
            this.connectionSplitContainer.Size = new System.Drawing.Size(563, 325);
            this.connectionSplitContainer.SplitterDistance = 140;
            this.connectionSplitContainer.SplitterWidth = 9;
            this.connectionSplitContainer.TabIndex = 5;
            // 
            // DBManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 400);
            this.Controls.Add(this.connectionSplitContainer);
            this.Controls.Add(this.connectionServiceLayout);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(602, 439);
            this.Name = "DBManagerView";
            this.Text = "DBManager";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.connectionServiceLayout.ResumeLayout(false);
            this.connectionSplitContainer.Panel1.ResumeLayout(false);
            this.connectionSplitContainer.Panel2.ResumeLayout(false);
            this.connectionSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionSplitContainer)).EndInit();
            this.connectionSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TableLayoutPanel connectionServiceLayout;
        private System.Windows.Forms.Button addConnection;
        private System.Windows.Forms.Button removeConnection;
        private System.Windows.Forms.Button setConnectionConfig;
        private System.Windows.Forms.ToolStripStatusLabel numberOfConnections;
        private System.Windows.Forms.ToolStripStatusLabel activeConnection;
        private System.Windows.Forms.TableLayoutPanel connectionsLayout;
        private System.Windows.Forms.TreeView connectionTree;
        private System.Windows.Forms.SplitContainer connectionSplitContainer;
        private System.Windows.Forms.ToolStripStatusLabel activeDatabase;
        private System.Windows.Forms.ToolStripStatusLabel activeTable;
    }
}