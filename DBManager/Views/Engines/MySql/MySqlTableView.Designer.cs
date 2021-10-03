
namespace DBManager.Views.Engines.MySql
{
    partial class MySqlTableView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableView = new System.Windows.Forms.TabControl();
            this.browse = new System.Windows.Forms.TabPage();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.browse_rowsCountLabel = new System.Windows.Forms.Label();
            this.browse_browseLabel = new System.Windows.Forms.Label();
            this.structure = new System.Windows.Forms.TabPage();
            this.structure_tableParametersDataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_comparingSubtitlesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statistics_columnsCountLabel = new System.Windows.Forms.Label();
            this.statistics_rowsCountLabel = new System.Windows.Forms.Label();
            this.statistics_lastUpdateLabel = new System.Windows.Forms.Label();
            this.statistics_createdAtLabel = new System.Windows.Forms.Label();
            this.statistics_sizeLabel = new System.Windows.Forms.Label();
            this.statistics_statisticsLabel = new System.Windows.Forms.Label();
            this.tableStructure_tableStructureLabel = new System.Windows.Forms.Label();
            this.browse_tableNameLabel = new System.Windows.Forms.Label();
            this.statistics_tableNameLabel = new System.Windows.Forms.Label();
            this.tableView.SuspendLayout();
            this.browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.structure_tableParametersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.Controls.Add(this.browse);
            this.tableView.Controls.Add(this.structure);
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.Margin = new System.Windows.Forms.Padding(0);
            this.tableView.Name = "tableView";
            this.tableView.Padding = new System.Drawing.Point(10, 3);
            this.tableView.SelectedIndex = 0;
            this.tableView.Size = new System.Drawing.Size(686, 390);
            this.tableView.TabIndex = 3;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.White;
            this.browse.Controls.Add(this.browse_tableNameLabel);
            this.browse.Controls.Add(this.tableDataGridView);
            this.browse.Controls.Add(this.browse_rowsCountLabel);
            this.browse.Controls.Add(this.browse_browseLabel);
            this.browse.Location = new System.Drawing.Point(4, 22);
            this.browse.Name = "browse";
            this.browse.Padding = new System.Windows.Forms.Padding(3);
            this.browse.Size = new System.Drawing.Size(678, 364);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tableDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableDataGridView.EnableHeadersVisualStyles = false;
            this.tableDataGridView.GridColor = System.Drawing.Color.Silver;
            this.tableDataGridView.Location = new System.Drawing.Point(0, 33);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableDataGridView.RowHeadersVisible = false;
            this.tableDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDataGridView.Size = new System.Drawing.Size(678, 335);
            this.tableDataGridView.TabIndex = 6;
            // 
            // browse_rowsCountLabel
            // 
            this.browse_rowsCountLabel.AutoSize = true;
            this.browse_rowsCountLabel.BackColor = System.Drawing.Color.White;
            this.browse_rowsCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.browse_rowsCountLabel.ForeColor = System.Drawing.Color.Black;
            this.browse_rowsCountLabel.Location = new System.Drawing.Point(123, 9);
            this.browse_rowsCountLabel.Name = "browse_rowsCountLabel";
            this.browse_rowsCountLabel.Size = new System.Drawing.Size(88, 21);
            this.browse_rowsCountLabel.TabIndex = 5;
            this.browse_rowsCountLabel.Text = "Elements: ";
            // 
            // browse_browseLabel
            // 
            this.browse_browseLabel.AutoSize = true;
            this.browse_browseLabel.BackColor = System.Drawing.Color.White;
            this.browse_browseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.browse_browseLabel.ForeColor = System.Drawing.Color.Black;
            this.browse_browseLabel.Location = new System.Drawing.Point(7, 3);
            this.browse_browseLabel.Name = "browse_browseLabel";
            this.browse_browseLabel.Size = new System.Drawing.Size(113, 30);
            this.browse_browseLabel.TabIndex = 3;
            this.browse_browseLabel.Text = "Table data";
            // 
            // structure
            // 
            this.structure.BackColor = System.Drawing.Color.White;
            this.structure.Controls.Add(this.statistics_tableNameLabel);
            this.structure.Controls.Add(this.structure_tableParametersDataGridView);
            this.structure.Controls.Add(this.statistics_columnsCountLabel);
            this.structure.Controls.Add(this.statistics_rowsCountLabel);
            this.structure.Controls.Add(this.statistics_lastUpdateLabel);
            this.structure.Controls.Add(this.statistics_createdAtLabel);
            this.structure.Controls.Add(this.statistics_sizeLabel);
            this.structure.Controls.Add(this.statistics_statisticsLabel);
            this.structure.Controls.Add(this.tableStructure_tableStructureLabel);
            this.structure.Location = new System.Drawing.Point(4, 22);
            this.structure.Margin = new System.Windows.Forms.Padding(0);
            this.structure.Name = "structure";
            this.structure.Padding = new System.Windows.Forms.Padding(3);
            this.structure.Size = new System.Drawing.Size(678, 364);
            this.structure.TabIndex = 1;
            this.structure.Text = "Structure";
            // 
            // structure_tableParametersDataGridView
            // 
            this.structure_tableParametersDataGridView.AllowUserToAddRows = false;
            this.structure_tableParametersDataGridView.AllowUserToDeleteRows = false;
            this.structure_tableParametersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.structure_tableParametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.structure_tableParametersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.structure_tableParametersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.structure_tableParametersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.structure_tableParametersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.structure_tableParametersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.structure_tableParametersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.structure_tableParametersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.structure_tableParametersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name,
            this.structure_Type,
            this.structure_comparingSubtitlesMethod});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.structure_tableParametersDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.structure_tableParametersDataGridView.EnableHeadersVisualStyles = false;
            this.structure_tableParametersDataGridView.GridColor = System.Drawing.Color.Silver;
            this.structure_tableParametersDataGridView.Location = new System.Drawing.Point(0, 137);
            this.structure_tableParametersDataGridView.Name = "structure_tableParametersDataGridView";
            this.structure_tableParametersDataGridView.ReadOnly = true;
            this.structure_tableParametersDataGridView.RowHeadersVisible = false;
            this.structure_tableParametersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.structure_tableParametersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.structure_tableParametersDataGridView.Size = new System.Drawing.Size(678, 231);
            this.structure_tableParametersDataGridView.TabIndex = 16;
            // 
            // structure_columnNumber
            // 
            this.structure_columnNumber.HeaderText = "#";
            this.structure_columnNumber.Name = "structure_columnNumber";
            this.structure_columnNumber.ReadOnly = true;
            // 
            // structure_Name
            // 
            this.structure_Name.HeaderText = "Name";
            this.structure_Name.Name = "structure_Name";
            this.structure_Name.ReadOnly = true;
            // 
            // structure_Type
            // 
            this.structure_Type.HeaderText = "Type";
            this.structure_Type.Name = "structure_Type";
            this.structure_Type.ReadOnly = true;
            // 
            // structure_comparingSubtitlesMethod
            // 
            this.structure_comparingSubtitlesMethod.HeaderText = "Comparing Subtitles Method";
            this.structure_comparingSubtitlesMethod.Name = "structure_comparingSubtitlesMethod";
            this.structure_comparingSubtitlesMethod.ReadOnly = true;
            // 
            // statistics_columnsCountLabel
            // 
            this.statistics_columnsCountLabel.AutoSize = true;
            this.statistics_columnsCountLabel.BackColor = System.Drawing.Color.White;
            this.statistics_columnsCountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.statistics_columnsCountLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_columnsCountLabel.Location = new System.Drawing.Point(236, 53);
            this.statistics_columnsCountLabel.Name = "statistics_columnsCountLabel";
            this.statistics_columnsCountLabel.Size = new System.Drawing.Size(69, 20);
            this.statistics_columnsCountLabel.TabIndex = 15;
            this.statistics_columnsCountLabel.Text = "Columns:";
            // 
            // statistics_rowsCountLabel
            // 
            this.statistics_rowsCountLabel.AutoSize = true;
            this.statistics_rowsCountLabel.BackColor = System.Drawing.Color.White;
            this.statistics_rowsCountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.statistics_rowsCountLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_rowsCountLabel.Location = new System.Drawing.Point(236, 33);
            this.statistics_rowsCountLabel.Name = "statistics_rowsCountLabel";
            this.statistics_rowsCountLabel.Size = new System.Drawing.Size(69, 20);
            this.statistics_rowsCountLabel.TabIndex = 14;
            this.statistics_rowsCountLabel.Text = "Records: ";
            // 
            // statistics_lastUpdateLabel
            // 
            this.statistics_lastUpdateLabel.AutoSize = true;
            this.statistics_lastUpdateLabel.BackColor = System.Drawing.Color.White;
            this.statistics_lastUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.statistics_lastUpdateLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_lastUpdateLabel.Location = new System.Drawing.Point(8, 73);
            this.statistics_lastUpdateLabel.Name = "statistics_lastUpdateLabel";
            this.statistics_lastUpdateLabel.Size = new System.Drawing.Size(93, 20);
            this.statistics_lastUpdateLabel.TabIndex = 13;
            this.statistics_lastUpdateLabel.Text = "Last update: ";
            // 
            // statistics_createdAtLabel
            // 
            this.statistics_createdAtLabel.AutoSize = true;
            this.statistics_createdAtLabel.BackColor = System.Drawing.Color.White;
            this.statistics_createdAtLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.statistics_createdAtLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_createdAtLabel.Location = new System.Drawing.Point(8, 53);
            this.statistics_createdAtLabel.Name = "statistics_createdAtLabel";
            this.statistics_createdAtLabel.Size = new System.Drawing.Size(85, 20);
            this.statistics_createdAtLabel.TabIndex = 12;
            this.statistics_createdAtLabel.Text = "Created at: ";
            // 
            // statistics_sizeLabel
            // 
            this.statistics_sizeLabel.AutoSize = true;
            this.statistics_sizeLabel.BackColor = System.Drawing.Color.White;
            this.statistics_sizeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.statistics_sizeLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_sizeLabel.Location = new System.Drawing.Point(8, 33);
            this.statistics_sizeLabel.Name = "statistics_sizeLabel";
            this.statistics_sizeLabel.Size = new System.Drawing.Size(75, 20);
            this.statistics_sizeLabel.TabIndex = 11;
            this.statistics_sizeLabel.Text = "Size (KB): ";
            // 
            // statistics_statisticsLabel
            // 
            this.statistics_statisticsLabel.AutoSize = true;
            this.statistics_statisticsLabel.BackColor = System.Drawing.Color.White;
            this.statistics_statisticsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.statistics_statisticsLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_statisticsLabel.Location = new System.Drawing.Point(8, 3);
            this.statistics_statisticsLabel.Name = "statistics_statisticsLabel";
            this.statistics_statisticsLabel.Size = new System.Drawing.Size(99, 30);
            this.statistics_statisticsLabel.TabIndex = 10;
            this.statistics_statisticsLabel.Text = "Statistics";
            // 
            // tableStructure_tableStructureLabel
            // 
            this.tableStructure_tableStructureLabel.AutoSize = true;
            this.tableStructure_tableStructureLabel.BackColor = System.Drawing.Color.White;
            this.tableStructure_tableStructureLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.tableStructure_tableStructureLabel.ForeColor = System.Drawing.Color.Black;
            this.tableStructure_tableStructureLabel.Location = new System.Drawing.Point(7, 103);
            this.tableStructure_tableStructureLabel.Name = "tableStructure_tableStructureLabel";
            this.tableStructure_tableStructureLabel.Size = new System.Drawing.Size(158, 30);
            this.tableStructure_tableStructureLabel.TabIndex = 2;
            this.tableStructure_tableStructureLabel.Text = "Table structure";
            // 
            // browse_tableNameLabel
            // 
            this.browse_tableNameLabel.AutoSize = true;
            this.browse_tableNameLabel.BackColor = System.Drawing.Color.White;
            this.browse_tableNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.browse_tableNameLabel.ForeColor = System.Drawing.Color.Black;
            this.browse_tableNameLabel.Location = new System.Drawing.Point(248, 9);
            this.browse_tableNameLabel.Name = "browse_tableNameLabel";
            this.browse_tableNameLabel.Size = new System.Drawing.Size(64, 21);
            this.browse_tableNameLabel.TabIndex = 21;
            this.browse_tableNameLabel.Text = "Name: ";
            // 
            // statistics_tableNameLabel
            // 
            this.statistics_tableNameLabel.AutoSize = true;
            this.statistics_tableNameLabel.BackColor = System.Drawing.Color.White;
            this.statistics_tableNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.statistics_tableNameLabel.ForeColor = System.Drawing.Color.Black;
            this.statistics_tableNameLabel.Location = new System.Drawing.Point(113, 10);
            this.statistics_tableNameLabel.Name = "statistics_tableNameLabel";
            this.statistics_tableNameLabel.Size = new System.Drawing.Size(64, 21);
            this.statistics_tableNameLabel.TabIndex = 21;
            this.statistics_tableNameLabel.Text = "Name: ";
            // 
            // MySqlTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tableView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MySqlTableView";
            this.Text = "MySqlTableView";
            this.Load += new System.EventHandler(this.MySqlTableView_Load);
            this.tableView.ResumeLayout(false);
            this.browse.ResumeLayout(false);
            this.browse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.structure.ResumeLayout(false);
            this.structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.structure_tableParametersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tableView;
        private System.Windows.Forms.TabPage browse;
        private System.Windows.Forms.TabPage structure;
        private System.Windows.Forms.Label tableStructure_tableStructureLabel;
        private System.Windows.Forms.Label browse_browseLabel;
        private System.Windows.Forms.Label browse_rowsCountLabel;
        private System.Windows.Forms.Label statistics_columnsCountLabel;
        private System.Windows.Forms.Label statistics_rowsCountLabel;
        private System.Windows.Forms.Label statistics_lastUpdateLabel;
        private System.Windows.Forms.Label statistics_createdAtLabel;
        private System.Windows.Forms.Label statistics_sizeLabel;
        private System.Windows.Forms.Label statistics_statisticsLabel;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridView structure_tableParametersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_comparingSubtitlesMethod;
        private System.Windows.Forms.Label browse_tableNameLabel;
        private System.Windows.Forms.Label statistics_tableNameLabel;
    }
}