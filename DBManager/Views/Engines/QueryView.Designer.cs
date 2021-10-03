
namespace DBManager.Views.Engines
{
    partial class QueryView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.structureView = new System.Windows.Forms.SplitContainer();
            this.queryContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.query_updateButton = new System.Windows.Forms.Button();
            this.query_selectButton = new System.Windows.Forms.Button();
            this.query_insertButton = new System.Windows.Forms.Button();
            this.query_deleteButton = new System.Windows.Forms.Button();
            this.query_queryInput = new System.Windows.Forms.RichTextBox();
            this.query_queryResultsLabel = new System.Windows.Forms.Label();
            this.query_DataGridView = new System.Windows.Forms.DataGridView();
            this.query_queryLabel = new System.Windows.Forms.Label();
            this.query_queryInsertLabel = new System.Windows.Forms.Label();
            this.query_sendQueryButton = new System.Windows.Forms.Button();
            this.query_queryTypeLabel = new System.Windows.Forms.Label();
            this.query_databaseLabel = new System.Windows.Forms.Label();
            this.query_databaseNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.structureView)).BeginInit();
            this.structureView.Panel2.SuspendLayout();
            this.structureView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryContainer)).BeginInit();
            this.queryContainer.Panel1.SuspendLayout();
            this.queryContainer.Panel2.SuspendLayout();
            this.queryContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // structureView
            // 
            this.structureView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.structureView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.structureView.Location = new System.Drawing.Point(0, 34);
            this.structureView.Name = "structureView";
            this.structureView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // structureView.Panel2
            // 
            this.structureView.Panel2.Controls.Add(this.queryContainer);
            this.structureView.Size = new System.Drawing.Size(929, 337);
            this.structureView.SplitterDistance = 185;
            this.structureView.SplitterWidth = 9;
            this.structureView.TabIndex = 0;
            // 
            // queryContainer
            // 
            this.queryContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.queryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryContainer.Location = new System.Drawing.Point(0, 0);
            this.queryContainer.Name = "queryContainer";
            // 
            // queryContainer.Panel1
            // 
            this.queryContainer.Panel1.Controls.Add(this.query_sendQueryButton);
            this.queryContainer.Panel1.Controls.Add(this.query_queryInsertLabel);
            this.queryContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.queryContainer.Panel1.Controls.Add(this.query_queryInput);
            this.queryContainer.Panel1MinSize = 100;
            // 
            // queryContainer.Panel2
            // 
            this.queryContainer.Panel2.Controls.Add(this.query_queryTypeLabel);
            this.queryContainer.Panel2.Controls.Add(this.query_queryResultsLabel);
            this.queryContainer.Panel2.Controls.Add(this.query_DataGridView);
            this.queryContainer.Panel2.Controls.Add(this.query_queryLabel);
            this.queryContainer.Size = new System.Drawing.Size(929, 143);
            this.queryContainer.SplitterDistance = 329;
            this.queryContainer.SplitterWidth = 9;
            this.queryContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.query_updateButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.query_selectButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.query_insertButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.query_deleteButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 28);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // query_updateButton
            // 
            this.query_updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.query_updateButton.ForeColor = System.Drawing.Color.Black;
            this.query_updateButton.Location = new System.Drawing.Point(240, 3);
            this.query_updateButton.Name = "query_updateButton";
            this.query_updateButton.Size = new System.Drawing.Size(76, 22);
            this.query_updateButton.TabIndex = 16;
            this.query_updateButton.Text = "UPDATE";
            this.query_updateButton.UseVisualStyleBackColor = true;
            this.query_updateButton.Click += new System.EventHandler(this.query_updateButton_Click);
            // 
            // query_selectButton
            // 
            this.query_selectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_selectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.query_selectButton.ForeColor = System.Drawing.Color.Black;
            this.query_selectButton.Location = new System.Drawing.Point(3, 3);
            this.query_selectButton.Name = "query_selectButton";
            this.query_selectButton.Size = new System.Drawing.Size(73, 22);
            this.query_selectButton.TabIndex = 13;
            this.query_selectButton.Text = "SELECT";
            this.query_selectButton.UseVisualStyleBackColor = true;
            this.query_selectButton.Click += new System.EventHandler(this.query_selectButton_Click);
            // 
            // query_insertButton
            // 
            this.query_insertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_insertButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.query_insertButton.ForeColor = System.Drawing.Color.Black;
            this.query_insertButton.Location = new System.Drawing.Point(82, 3);
            this.query_insertButton.Name = "query_insertButton";
            this.query_insertButton.Size = new System.Drawing.Size(73, 22);
            this.query_insertButton.TabIndex = 14;
            this.query_insertButton.Text = "INSERT";
            this.query_insertButton.UseVisualStyleBackColor = true;
            this.query_insertButton.Click += new System.EventHandler(this.query_insertButton_Click);
            // 
            // query_deleteButton
            // 
            this.query_deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.query_deleteButton.ForeColor = System.Drawing.Color.Black;
            this.query_deleteButton.Location = new System.Drawing.Point(161, 3);
            this.query_deleteButton.Name = "query_deleteButton";
            this.query_deleteButton.Size = new System.Drawing.Size(73, 22);
            this.query_deleteButton.TabIndex = 15;
            this.query_deleteButton.Text = "DELETE";
            this.query_deleteButton.UseVisualStyleBackColor = true;
            this.query_deleteButton.Click += new System.EventHandler(this.query_deleteButton_Click);
            // 
            // query_queryInput
            // 
            this.query_queryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.query_queryInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.query_queryInput.Location = new System.Drawing.Point(1, 31);
            this.query_queryInput.Name = "query_queryInput";
            this.query_queryInput.Size = new System.Drawing.Size(322, 46);
            this.query_queryInput.TabIndex = 13;
            this.query_queryInput.Text = "";
            // 
            // query_queryResultsLabel
            // 
            this.query_queryResultsLabel.AutoSize = true;
            this.query_queryResultsLabel.BackColor = System.Drawing.Color.White;
            this.query_queryResultsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.query_queryResultsLabel.ForeColor = System.Drawing.Color.Black;
            this.query_queryResultsLabel.Location = new System.Drawing.Point(3, 1);
            this.query_queryResultsLabel.Name = "query_queryResultsLabel";
            this.query_queryResultsLabel.Size = new System.Drawing.Size(143, 30);
            this.query_queryResultsLabel.TabIndex = 11;
            this.query_queryResultsLabel.Text = "Query results";
            // 
            // query_DataGridView
            // 
            this.query_DataGridView.AllowUserToAddRows = false;
            this.query_DataGridView.AllowUserToDeleteRows = false;
            this.query_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.query_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.query_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.query_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.query_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.query_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.query_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.query_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.query_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.query_DataGridView.EnableHeadersVisualStyles = false;
            this.query_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.query_DataGridView.Location = new System.Drawing.Point(0, 31);
            this.query_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.query_DataGridView.Name = "query_DataGridView";
            this.query_DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.query_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.query_DataGridView.RowHeadersVisible = false;
            this.query_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.query_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.query_DataGridView.Size = new System.Drawing.Size(582, 108);
            this.query_DataGridView.TabIndex = 10;
            // 
            // query_queryLabel
            // 
            this.query_queryLabel.AutoSize = true;
            this.query_queryLabel.BackColor = System.Drawing.Color.White;
            this.query_queryLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.query_queryLabel.ForeColor = System.Drawing.Color.Black;
            this.query_queryLabel.Location = new System.Drawing.Point(-149, 1);
            this.query_queryLabel.Name = "query_queryLabel";
            this.query_queryLabel.Size = new System.Drawing.Size(155, 30);
            this.query_queryLabel.TabIndex = 9;
            this.query_queryLabel.Text = "Query results: ";
            // 
            // query_queryInsertLabel
            // 
            this.query_queryInsertLabel.AutoSize = true;
            this.query_queryInsertLabel.BackColor = System.Drawing.Color.White;
            this.query_queryInsertLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.query_queryInsertLabel.ForeColor = System.Drawing.Color.Black;
            this.query_queryInsertLabel.Location = new System.Drawing.Point(3, 1);
            this.query_queryInsertLabel.Name = "query_queryInsertLabel";
            this.query_queryInsertLabel.Size = new System.Drawing.Size(73, 30);
            this.query_queryInsertLabel.TabIndex = 12;
            this.query_queryInsertLabel.Text = "Query";
            // 
            // query_sendQueryButton
            // 
            this.query_sendQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.query_sendQueryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.query_sendQueryButton.ForeColor = System.Drawing.Color.Black;
            this.query_sendQueryButton.Location = new System.Drawing.Point(3, 114);
            this.query_sendQueryButton.Name = "query_sendQueryButton";
            this.query_sendQueryButton.Size = new System.Drawing.Size(319, 24);
            this.query_sendQueryButton.TabIndex = 15;
            this.query_sendQueryButton.Text = "Send Query";
            this.query_sendQueryButton.UseVisualStyleBackColor = true;
            this.query_sendQueryButton.Click += new System.EventHandler(this.query_sendQueryButton_Click);
            // 
            // query_queryTypeLabel
            // 
            this.query_queryTypeLabel.AutoSize = true;
            this.query_queryTypeLabel.BackColor = System.Drawing.Color.White;
            this.query_queryTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.query_queryTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.query_queryTypeLabel.Location = new System.Drawing.Point(152, 8);
            this.query_queryTypeLabel.Name = "query_queryTypeLabel";
            this.query_queryTypeLabel.Size = new System.Drawing.Size(0, 21);
            this.query_queryTypeLabel.TabIndex = 18;
            // 
            // query_databaseLabel
            // 
            this.query_databaseLabel.AutoSize = true;
            this.query_databaseLabel.BackColor = System.Drawing.Color.White;
            this.query_databaseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.query_databaseLabel.ForeColor = System.Drawing.Color.Black;
            this.query_databaseLabel.Location = new System.Drawing.Point(3, 1);
            this.query_databaseLabel.Name = "query_databaseLabel";
            this.query_databaseLabel.Size = new System.Drawing.Size(102, 30);
            this.query_databaseLabel.TabIndex = 19;
            this.query_databaseLabel.Text = "Database";
            // 
            // query_databaseNameLabel
            // 
            this.query_databaseNameLabel.AutoSize = true;
            this.query_databaseNameLabel.BackColor = System.Drawing.Color.White;
            this.query_databaseNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.query_databaseNameLabel.ForeColor = System.Drawing.Color.Black;
            this.query_databaseNameLabel.Location = new System.Drawing.Point(113, 8);
            this.query_databaseNameLabel.Name = "query_databaseNameLabel";
            this.query_databaseNameLabel.Size = new System.Drawing.Size(64, 21);
            this.query_databaseNameLabel.TabIndex = 20;
            this.query_databaseNameLabel.Text = "Name: ";
            // 
            // QueryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.query_databaseNameLabel);
            this.Controls.Add(this.query_databaseLabel);
            this.Controls.Add(this.structureView);
            this.Name = "QueryView";
            this.Size = new System.Drawing.Size(929, 371);
            this.structureView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.structureView)).EndInit();
            this.structureView.ResumeLayout(false);
            this.queryContainer.Panel1.ResumeLayout(false);
            this.queryContainer.Panel1.PerformLayout();
            this.queryContainer.Panel2.ResumeLayout(false);
            this.queryContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryContainer)).EndInit();
            this.queryContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.query_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer structureView;
        private System.Windows.Forms.SplitContainer queryContainer;
        private System.Windows.Forms.DataGridView query_DataGridView;
        private System.Windows.Forms.Label query_queryLabel;
        private System.Windows.Forms.Label query_queryResultsLabel;
        private System.Windows.Forms.RichTextBox query_queryInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button query_updateButton;
        private System.Windows.Forms.Button query_selectButton;
        private System.Windows.Forms.Button query_insertButton;
        private System.Windows.Forms.Button query_deleteButton;
        private System.Windows.Forms.Label query_queryInsertLabel;
        private System.Windows.Forms.Button query_sendQueryButton;
        private System.Windows.Forms.Label query_queryTypeLabel;
        private System.Windows.Forms.Label query_databaseLabel;
        private System.Windows.Forms.Label query_databaseNameLabel;
    }
}
