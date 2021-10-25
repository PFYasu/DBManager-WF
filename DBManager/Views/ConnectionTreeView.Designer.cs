
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
            this.ConnectionTree_TreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ConnectionTree_TreeView
            // 
            this.ConnectionTree_TreeView.BackColor = System.Drawing.Color.White;
            this.ConnectionTree_TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectionTree_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree_TreeView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionTree_TreeView.ForeColor = System.Drawing.Color.Black;
            this.ConnectionTree_TreeView.Indent = 8;
            this.ConnectionTree_TreeView.Location = new System.Drawing.Point(0, 0);
            this.ConnectionTree_TreeView.Name = "ConnectionTree_TreeView";
            this.ConnectionTree_TreeView.ShowPlusMinus = false;
            this.ConnectionTree_TreeView.Size = new System.Drawing.Size(150, 150);
            this.ConnectionTree_TreeView.TabIndex = 5;
            this.ConnectionTree_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ConnectionTree_TreeView_NodeMouseClick);
            // 
            // ConnectionTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConnectionTree_TreeView);
            this.Name = "ConnectionTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ConnectionTree_TreeView;
    }
}
