
namespace DBManager.Views.Engines.MySql
{
    partial class MySqlView
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
            this.executeQueryResult = new System.Windows.Forms.DataGridView();
            this.inputQuery = new System.Windows.Forms.RichTextBox();
            this.setSelect = new System.Windows.Forms.Button();
            this.setUpdate = new System.Windows.Forms.Button();
            this.setInsertInto = new System.Windows.Forms.Button();
            this.setDelete = new System.Windows.Forms.Button();
            this.sendQuery = new System.Windows.Forms.Button();
            this.queryContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.executeQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryContainer)).BeginInit();
            this.queryContainer.Panel1.SuspendLayout();
            this.queryContainer.Panel2.SuspendLayout();
            this.queryContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // executeQueryResult
            // 
            this.executeQueryResult.AllowUserToAddRows = false;
            this.executeQueryResult.AllowUserToDeleteRows = false;
            this.executeQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executeQueryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.executeQueryResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.executeQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executeQueryResult.Location = new System.Drawing.Point(3, 3);
            this.executeQueryResult.Name = "executeQueryResult";
            this.executeQueryResult.RowTemplate.Height = 25;
            this.executeQueryResult.Size = new System.Drawing.Size(770, 96);
            this.executeQueryResult.TabIndex = 0;
            // 
            // inputQuery
            // 
            this.inputQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputQuery.Location = new System.Drawing.Point(3, 3);
            this.inputQuery.Name = "inputQuery";
            this.inputQuery.Size = new System.Drawing.Size(770, 65);
            this.inputQuery.TabIndex = 1;
            this.inputQuery.Text = "";
            // 
            // setSelect
            // 
            this.setSelect.Location = new System.Drawing.Point(12, 232);
            this.setSelect.Name = "setSelect";
            this.setSelect.Size = new System.Drawing.Size(98, 23);
            this.setSelect.TabIndex = 2;
            this.setSelect.Text = "SELECT";
            this.setSelect.UseVisualStyleBackColor = true;
            // 
            // setUpdate
            // 
            this.setUpdate.Location = new System.Drawing.Point(324, 232);
            this.setUpdate.Name = "setUpdate";
            this.setUpdate.Size = new System.Drawing.Size(98, 23);
            this.setUpdate.TabIndex = 3;
            this.setUpdate.Text = "UPDATE";
            this.setUpdate.UseVisualStyleBackColor = true;
            // 
            // setInsertInto
            // 
            this.setInsertInto.Location = new System.Drawing.Point(116, 232);
            this.setInsertInto.Name = "setInsertInto";
            this.setInsertInto.Size = new System.Drawing.Size(98, 23);
            this.setInsertInto.TabIndex = 4;
            this.setInsertInto.Text = "INSERT INTO";
            this.setInsertInto.UseVisualStyleBackColor = true;
            // 
            // setDelete
            // 
            this.setDelete.Location = new System.Drawing.Point(220, 232);
            this.setDelete.Name = "setDelete";
            this.setDelete.Size = new System.Drawing.Size(98, 23);
            this.setDelete.TabIndex = 5;
            this.setDelete.Text = "DELETE";
            this.setDelete.UseVisualStyleBackColor = true;
            // 
            // sendQuery
            // 
            this.sendQuery.Location = new System.Drawing.Point(630, 232);
            this.sendQuery.Name = "sendQuery";
            this.sendQuery.Size = new System.Drawing.Size(158, 23);
            this.sendQuery.TabIndex = 6;
            this.sendQuery.Text = "SEND QUERY";
            this.sendQuery.UseVisualStyleBackColor = true;
            this.sendQuery.Click += new System.EventHandler(this.sendQuery_Click);
            // 
            // queryContainer
            // 
            this.queryContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.queryContainer.Location = new System.Drawing.Point(12, 261);
            this.queryContainer.Name = "queryContainer";
            this.queryContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // queryContainer.Panel1
            // 
            this.queryContainer.Panel1.Controls.Add(this.inputQuery);
            // 
            // queryContainer.Panel2
            // 
            this.queryContainer.Panel2.Controls.Add(this.executeQueryResult);
            this.queryContainer.Size = new System.Drawing.Size(776, 177);
            this.queryContainer.SplitterDistance = 71;
            this.queryContainer.TabIndex = 7;
            // 
            // MySqlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryContainer);
            this.Controls.Add(this.sendQuery);
            this.Controls.Add(this.setDelete);
            this.Controls.Add(this.setInsertInto);
            this.Controls.Add(this.setUpdate);
            this.Controls.Add(this.setSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MySqlView";
            this.Text = "DBManager - MySql connection";
            ((System.ComponentModel.ISupportInitialize)(this.executeQueryResult)).EndInit();
            this.queryContainer.Panel1.ResumeLayout(false);
            this.queryContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryContainer)).EndInit();
            this.queryContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView executeQueryResult;
        private System.Windows.Forms.RichTextBox inputQuery;
        private System.Windows.Forms.Button setSelect;
        private System.Windows.Forms.Button setUpdate;
        private System.Windows.Forms.Button setInsertInto;
        private System.Windows.Forms.Button setDelete;
        private System.Windows.Forms.Button sendQuery;
        private System.Windows.Forms.SplitContainer queryContainer;
    }
}