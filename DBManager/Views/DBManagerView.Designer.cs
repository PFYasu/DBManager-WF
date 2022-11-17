
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
            this.Content_ContentManagerView = new DBManager.Views.ContentManagerView();
            this.Status_StatusStripView = new DBManager.Views.StatusStripView();
            this.ConnectionAction_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Connection_SplitContainer)).BeginInit();
            this.Connection_SplitContainer.Panel1.SuspendLayout();
            this.Connection_SplitContainer.Panel2.SuspendLayout();
            this.Connection_SplitContainer.SuspendLayout();
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
            // Content_ContentManagerView
            // 
            this.Content_ContentManagerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_ContentManagerView.Location = new System.Drawing.Point(0, 0);
            this.Content_ContentManagerView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Content_ContentManagerView.Name = "Content_ContentManagerView";
            this.Content_ContentManagerView.Size = new System.Drawing.Size(480, 371);
            this.Content_ContentManagerView.TabIndex = 0;
            // 
            // Status_StatusStripView
            // 
            this.Status_StatusStripView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Status_StatusStripView.Location = new System.Drawing.Point(0, 439);
            this.Status_StatusStripView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Status_StatusStripView.Name = "Status_StatusStripView";
            this.Status_StatusStripView.Size = new System.Drawing.Size(684, 23);
            this.Status_StatusStripView.TabIndex = 6;
            // 
            // DBManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.Status_StatusStripView);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConnectionAction_TableLayoutPanel;
        private System.Windows.Forms.Button AddConnection_Button;
        private System.Windows.Forms.Button RemoveConnection_Button;
        private System.Windows.Forms.Button UpdateConnection_Button;
        private System.Windows.Forms.SplitContainer Connection_SplitContainer;
        private ConnectionTreeView ConnectionTree_ConnectionTreeView;
        private ContentManagerView Content_ContentManagerView;
        private StatusStripView Status_StatusStripView;
    }
}