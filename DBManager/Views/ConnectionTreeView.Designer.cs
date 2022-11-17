
namespace DBManager.Views
{
    partial class ConnectionTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionTreeView));
            this.ConnectionTree_TreeView = new System.Windows.Forms.TreeView();
            this.ConnectionTree_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ConnectionTree_TreeView
            // 
            this.ConnectionTree_TreeView.BackColor = System.Drawing.Color.White;
            this.ConnectionTree_TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectionTree_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree_TreeView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnectionTree_TreeView.ForeColor = System.Drawing.Color.Black;
            this.ConnectionTree_TreeView.ImageIndex = 0;
            this.ConnectionTree_TreeView.ImageList = this.ConnectionTree_ImageList;
            this.ConnectionTree_TreeView.Indent = 8;
            this.ConnectionTree_TreeView.Location = new System.Drawing.Point(0, 0);
            this.ConnectionTree_TreeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnectionTree_TreeView.Name = "ConnectionTree_TreeView";
            this.ConnectionTree_TreeView.SelectedImageIndex = 0;
            this.ConnectionTree_TreeView.Size = new System.Drawing.Size(175, 173);
            this.ConnectionTree_TreeView.TabIndex = 5;
            this.ConnectionTree_TreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.ConnectionTree_TreeView_BeforeCollapse);
            this.ConnectionTree_TreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.ConnectionTree_TreeView_BeforeExpand);
            this.ConnectionTree_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ConnectionTree_TreeView_NodeMouseClick);
            // 
            // ConnectionTree_ImageList
            // 
            this.ConnectionTree_ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ConnectionTree_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConnectionTree_ImageList.ImageStream")));
            this.ConnectionTree_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ConnectionTree_ImageList.Images.SetKeyName(0, "ConnectionIcon.png");
            this.ConnectionTree_ImageList.Images.SetKeyName(1, "DatabaseIcon.png");
            this.ConnectionTree_ImageList.Images.SetKeyName(2, "TableIcon.png");
            // 
            // ConnectionTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConnectionTree_TreeView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConnectionTreeView";
            this.Size = new System.Drawing.Size(175, 173);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ConnectionTree_TreeView;
        private System.Windows.Forms.ImageList ConnectionTree_ImageList;
    }
}
