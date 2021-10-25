
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
            this.connectionTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // connectionTree
            // 
            this.connectionTree.BackColor = System.Drawing.Color.White;
            this.connectionTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionTree.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionTree.ForeColor = System.Drawing.Color.Black;
            this.connectionTree.Indent = 8;
            this.connectionTree.Location = new System.Drawing.Point(0, 0);
            this.connectionTree.Name = "connectionTree";
            this.connectionTree.ShowPlusMinus = false;
            this.connectionTree.Size = new System.Drawing.Size(150, 150);
            this.connectionTree.TabIndex = 5;
            this.connectionTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.connectionTree_NodeMouseClick);
            // 
            // ConnectionTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.connectionTree);
            this.Name = "ConnectionTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView connectionTree;
    }
}
