
namespace DBManager.Views
{
    partial class ConnectorSelectorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectorSelectorView));
            this.createMySql = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.selectConnectionLabel = new System.Windows.Forms.Label();
            this.createPostgreSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createMySql
            // 
            this.createMySql.BackColor = System.Drawing.Color.Silver;
            this.createMySql.Image = ((System.Drawing.Image)(resources.GetObject("createMySql.Image")));
            this.createMySql.Location = new System.Drawing.Point(12, 42);
            this.createMySql.Name = "createMySql";
            this.createMySql.Size = new System.Drawing.Size(150, 150);
            this.createMySql.TabIndex = 0;
            this.createMySql.UseVisualStyleBackColor = false;
            this.createMySql.Click += new System.EventHandler(this.createMySql_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 198);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // selectConnectionLabel
            // 
            this.selectConnectionLabel.AutoSize = true;
            this.selectConnectionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectConnectionLabel.Location = new System.Drawing.Point(12, 9);
            this.selectConnectionLabel.Name = "selectConnectionLabel";
            this.selectConnectionLabel.Size = new System.Drawing.Size(177, 30);
            this.selectConnectionLabel.TabIndex = 2;
            this.selectConnectionLabel.Text = "Select connection";
            // 
            // createPostgreSQL
            // 
            this.createPostgreSQL.BackColor = System.Drawing.Color.Silver;
            this.createPostgreSQL.Image = ((System.Drawing.Image)(resources.GetObject("createPostgreSQL.Image")));
            this.createPostgreSQL.Location = new System.Drawing.Point(168, 42);
            this.createPostgreSQL.Name = "createPostgreSQL";
            this.createPostgreSQL.Size = new System.Drawing.Size(150, 150);
            this.createPostgreSQL.TabIndex = 1;
            this.createPostgreSQL.UseVisualStyleBackColor = false;
            this.createPostgreSQL.Click += new System.EventHandler(this.createPostgreSQL_Click);
            // 
            // ConnectorSelectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 229);
            this.Controls.Add(this.createPostgreSQL);
            this.Controls.Add(this.selectConnectionLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createMySql);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectorSelectorView";
            this.Text = "DBManager - select connection type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createMySql;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label selectConnectionLabel;
        private System.Windows.Forms.Button createPostgreSQL;
    }
}