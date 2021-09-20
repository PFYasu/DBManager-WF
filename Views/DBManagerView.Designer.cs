
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
            this.connectionServiceLayout = new System.Windows.Forms.TableLayoutPanel();
            this.setConnectionConfig = new System.Windows.Forms.Button();
            this.removeConnection = new System.Windows.Forms.Button();
            this.addConnection = new System.Windows.Forms.Button();
            this.connectionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.connectionTree = new System.Windows.Forms.TreeView();
            this.statusStrip.SuspendLayout();
            this.connectionServiceLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfConnections,
            this.activeConnection});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // numberOfConnections
            // 
            this.numberOfConnections.Name = "numberOfConnections";
            this.numberOfConnections.Size = new System.Drawing.Size(80, 17);
            this.numberOfConnections.Text = "Connections: ";
            // 
            // activeConnection
            // 
            this.activeConnection.Name = "activeConnection";
            this.activeConnection.Size = new System.Drawing.Size(46, 17);
            this.activeConnection.Text = "Active: ";
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
            this.connectionServiceLayout.Location = new System.Drawing.Point(12, 12);
            this.connectionServiceLayout.Name = "connectionServiceLayout";
            this.connectionServiceLayout.RowCount = 1;
            this.connectionServiceLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connectionServiceLayout.Size = new System.Drawing.Size(140, 42);
            this.connectionServiceLayout.TabIndex = 2;
            // 
            // setConnectionConfig
            // 
            this.setConnectionConfig.BackColor = System.Drawing.Color.White;
            this.setConnectionConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setConnectionConfig.BackgroundImage")));
            this.setConnectionConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setConnectionConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setConnectionConfig.Location = new System.Drawing.Point(95, 3);
            this.setConnectionConfig.Name = "setConnectionConfig";
            this.setConnectionConfig.Size = new System.Drawing.Size(42, 36);
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
            this.removeConnection.Location = new System.Drawing.Point(49, 3);
            this.removeConnection.Name = "removeConnection";
            this.removeConnection.Size = new System.Drawing.Size(40, 36);
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
            this.addConnection.Size = new System.Drawing.Size(40, 36);
            this.addConnection.TabIndex = 0;
            this.addConnection.UseVisualStyleBackColor = false;
            this.addConnection.Click += new System.EventHandler(this.addConnection_Click);
            // 
            // connectionsLayout
            // 
            this.connectionsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionsLayout.AutoSize = true;
            this.connectionsLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectionsLayout.ColumnCount = 1;
            this.connectionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionsLayout.Location = new System.Drawing.Point(159, 12);
            this.connectionsLayout.Name = "connectionsLayout";
            this.connectionsLayout.RowCount = 1;
            this.connectionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionsLayout.Size = new System.Drawing.Size(513, 413);
            this.connectionsLayout.TabIndex = 3;
            // 
            // connectionTree
            // 
            this.connectionTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.connectionTree.Location = new System.Drawing.Point(12, 58);
            this.connectionTree.Name = "connectionTree";
            this.connectionTree.Size = new System.Drawing.Size(137, 367);
            this.connectionTree.TabIndex = 4;
            this.connectionTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.connectionTree_NodeMouseClick);
            // 
            // DBManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.connectionTree);
            this.Controls.Add(this.connectionsLayout);
            this.Controls.Add(this.connectionServiceLayout);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "DBManagerView";
            this.Text = "DBManager";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.connectionServiceLayout.ResumeLayout(false);
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
    }
}