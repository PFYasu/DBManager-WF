
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
            this.tableParametersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableStructure_numberLabel = new System.Windows.Forms.Label();
            this.tableStructure_comparingSubtitlesMethodLabel = new System.Windows.Forms.Label();
            this.tableStructure_typeLabel = new System.Windows.Forms.Label();
            this.tableStructure_nameLabel = new System.Windows.Forms.Label();
            this.tableView = new System.Windows.Forms.TabControl();
            this.browse = new System.Windows.Forms.TabPage();
            this.browse_rowsCountLabel = new System.Windows.Forms.Label();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.browse_browseLabel = new System.Windows.Forms.Label();
            this.structure = new System.Windows.Forms.TabPage();
            this.statistics_columnsCountLabel = new System.Windows.Forms.Label();
            this.statistics_recordsCountLabel = new System.Windows.Forms.Label();
            this.statistics_lastUpdateLabel = new System.Windows.Forms.Label();
            this.statistics_createdAtLabel = new System.Windows.Forms.Label();
            this.statistics_sizeLabel = new System.Windows.Forms.Label();
            this.statistics_statisticsLabel = new System.Windows.Forms.Label();
            this.tableStructure_recordsCountLabel = new System.Windows.Forms.Label();
            this.tableStructure_tableStructureLabel = new System.Windows.Forms.Label();
            this.tableParametersLayout.SuspendLayout();
            this.tableView.SuspendLayout();
            this.browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.structure.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableParametersLayout
            // 
            this.tableParametersLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableParametersLayout.AutoScroll = true;
            this.tableParametersLayout.AutoSize = true;
            this.tableParametersLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableParametersLayout.ColumnCount = 4;
            this.tableParametersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableParametersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableParametersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableParametersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableParametersLayout.Controls.Add(this.tableStructure_numberLabel, 0, 0);
            this.tableParametersLayout.Controls.Add(this.tableStructure_comparingSubtitlesMethodLabel, 3, 0);
            this.tableParametersLayout.Controls.Add(this.tableStructure_typeLabel, 2, 0);
            this.tableParametersLayout.Controls.Add(this.tableStructure_nameLabel, 1, 0);
            this.tableParametersLayout.Location = new System.Drawing.Point(9, 176);
            this.tableParametersLayout.Name = "tableParametersLayout";
            this.tableParametersLayout.RowCount = 1;
            this.tableParametersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableParametersLayout.Size = new System.Drawing.Size(773, 43);
            this.tableParametersLayout.TabIndex = 0;
            // 
            // tableStructure_numberLabel
            // 
            this.tableStructure_numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableStructure_numberLabel.AutoSize = true;
            this.tableStructure_numberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableStructure_numberLabel.ForeColor = System.Drawing.Color.White;
            this.tableStructure_numberLabel.Location = new System.Drawing.Point(5, 2);
            this.tableStructure_numberLabel.Name = "tableStructure_numberLabel";
            this.tableStructure_numberLabel.Size = new System.Drawing.Size(70, 39);
            this.tableStructure_numberLabel.TabIndex = 0;
            this.tableStructure_numberLabel.Text = "#";
            this.tableStructure_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStructure_comparingSubtitlesMethodLabel
            // 
            this.tableStructure_comparingSubtitlesMethodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableStructure_comparingSubtitlesMethodLabel.AutoSize = true;
            this.tableStructure_comparingSubtitlesMethodLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableStructure_comparingSubtitlesMethodLabel.ForeColor = System.Drawing.Color.White;
            this.tableStructure_comparingSubtitlesMethodLabel.Location = new System.Drawing.Point(467, 2);
            this.tableStructure_comparingSubtitlesMethodLabel.Name = "tableStructure_comparingSubtitlesMethodLabel";
            this.tableStructure_comparingSubtitlesMethodLabel.Size = new System.Drawing.Size(301, 39);
            this.tableStructure_comparingSubtitlesMethodLabel.TabIndex = 2;
            this.tableStructure_comparingSubtitlesMethodLabel.Text = "Comparing subtitles method";
            this.tableStructure_comparingSubtitlesMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStructure_typeLabel
            // 
            this.tableStructure_typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableStructure_typeLabel.AutoSize = true;
            this.tableStructure_typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableStructure_typeLabel.ForeColor = System.Drawing.Color.White;
            this.tableStructure_typeLabel.Location = new System.Drawing.Point(313, 2);
            this.tableStructure_typeLabel.Name = "tableStructure_typeLabel";
            this.tableStructure_typeLabel.Size = new System.Drawing.Size(146, 39);
            this.tableStructure_typeLabel.TabIndex = 3;
            this.tableStructure_typeLabel.Text = "Type";
            this.tableStructure_typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStructure_nameLabel
            // 
            this.tableStructure_nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableStructure_nameLabel.AutoSize = true;
            this.tableStructure_nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableStructure_nameLabel.ForeColor = System.Drawing.Color.White;
            this.tableStructure_nameLabel.Location = new System.Drawing.Point(83, 2);
            this.tableStructure_nameLabel.Name = "tableStructure_nameLabel";
            this.tableStructure_nameLabel.Size = new System.Drawing.Size(222, 39);
            this.tableStructure_nameLabel.TabIndex = 1;
            this.tableStructure_nameLabel.Text = "Name";
            this.tableStructure_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableView
            // 
            this.tableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableView.Controls.Add(this.browse);
            this.tableView.Controls.Add(this.structure);
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.Name = "tableView";
            this.tableView.Padding = new System.Drawing.Point(10, 3);
            this.tableView.SelectedIndex = 0;
            this.tableView.Size = new System.Drawing.Size(800, 450);
            this.tableView.TabIndex = 3;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browse.Controls.Add(this.browse_rowsCountLabel);
            this.browse.Controls.Add(this.tableDataGridView);
            this.browse.Controls.Add(this.browse_browseLabel);
            this.browse.Location = new System.Drawing.Point(4, 24);
            this.browse.Name = "browse";
            this.browse.Padding = new System.Windows.Forms.Padding(3);
            this.browse.Size = new System.Drawing.Size(792, 422);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            // 
            // browse_rowsCountLabel
            // 
            this.browse_rowsCountLabel.AutoSize = true;
            this.browse_rowsCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browse_rowsCountLabel.ForeColor = System.Drawing.Color.White;
            this.browse_rowsCountLabel.Location = new System.Drawing.Point(143, 10);
            this.browse_rowsCountLabel.Name = "browse_rowsCountLabel";
            this.browse_rowsCountLabel.Size = new System.Drawing.Size(88, 21);
            this.browse_rowsCountLabel.TabIndex = 5;
            this.browse_rowsCountLabel.Text = "Elements: ";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableDataGridView.EnableHeadersVisualStyles = false;
            this.tableDataGridView.Location = new System.Drawing.Point(9, 37);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersVisible = false;
            this.tableDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.tableDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableDataGridView.RowTemplate.Height = 25;
            this.tableDataGridView.Size = new System.Drawing.Size(775, 379);
            this.tableDataGridView.TabIndex = 4;
            // 
            // browse_browseLabel
            // 
            this.browse_browseLabel.AutoSize = true;
            this.browse_browseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browse_browseLabel.ForeColor = System.Drawing.Color.White;
            this.browse_browseLabel.Location = new System.Drawing.Point(8, 3);
            this.browse_browseLabel.Name = "browse_browseLabel";
            this.browse_browseLabel.Size = new System.Drawing.Size(113, 30);
            this.browse_browseLabel.TabIndex = 3;
            this.browse_browseLabel.Text = "Table data";
            // 
            // structure
            // 
            this.structure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.structure.Controls.Add(this.statistics_columnsCountLabel);
            this.structure.Controls.Add(this.statistics_recordsCountLabel);
            this.structure.Controls.Add(this.statistics_lastUpdateLabel);
            this.structure.Controls.Add(this.statistics_createdAtLabel);
            this.structure.Controls.Add(this.statistics_sizeLabel);
            this.structure.Controls.Add(this.statistics_statisticsLabel);
            this.structure.Controls.Add(this.tableStructure_recordsCountLabel);
            this.structure.Controls.Add(this.tableStructure_tableStructureLabel);
            this.structure.Controls.Add(this.tableParametersLayout);
            this.structure.Location = new System.Drawing.Point(4, 24);
            this.structure.Name = "structure";
            this.structure.Padding = new System.Windows.Forms.Padding(3);
            this.structure.Size = new System.Drawing.Size(792, 422);
            this.structure.TabIndex = 1;
            this.structure.Text = "Structure";
            // 
            // statistics_columnsCountLabel
            // 
            this.statistics_columnsCountLabel.AutoSize = true;
            this.statistics_columnsCountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statistics_columnsCountLabel.ForeColor = System.Drawing.Color.White;
            this.statistics_columnsCountLabel.Location = new System.Drawing.Point(251, 69);
            this.statistics_columnsCountLabel.Name = "statistics_columnsCountLabel";
            this.statistics_columnsCountLabel.Size = new System.Drawing.Size(69, 20);
            this.statistics_columnsCountLabel.TabIndex = 15;
            this.statistics_columnsCountLabel.Text = "Columns:";
            // 
            // statistics_recordsCountLabel
            // 
            this.statistics_recordsCountLabel.AutoSize = true;
            this.statistics_recordsCountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statistics_recordsCountLabel.ForeColor = System.Drawing.Color.White;
            this.statistics_recordsCountLabel.Location = new System.Drawing.Point(251, 37);
            this.statistics_recordsCountLabel.Name = "statistics_recordsCountLabel";
            this.statistics_recordsCountLabel.Size = new System.Drawing.Size(69, 20);
            this.statistics_recordsCountLabel.TabIndex = 14;
            this.statistics_recordsCountLabel.Text = "Records: ";
            // 
            // statistics_lastUpdateLabel
            // 
            this.statistics_lastUpdateLabel.AutoSize = true;
            this.statistics_lastUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statistics_lastUpdateLabel.ForeColor = System.Drawing.Color.White;
            this.statistics_lastUpdateLabel.Location = new System.Drawing.Point(9, 102);
            this.statistics_lastUpdateLabel.Name = "statistics_lastUpdateLabel";
            this.statistics_lastUpdateLabel.Size = new System.Drawing.Size(93, 20);
            this.statistics_lastUpdateLabel.TabIndex = 13;
            this.statistics_lastUpdateLabel.Text = "Last update: ";
            // 
            // statistics_createdAtLabel
            // 
            this.statistics_createdAtLabel.AutoSize = true;
            this.statistics_createdAtLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statistics_createdAtLabel.ForeColor = System.Drawing.Color.White;
            this.statistics_createdAtLabel.Location = new System.Drawing.Point(9, 69);
            this.statistics_createdAtLabel.Name = "statistics_createdAtLabel";
            this.statistics_createdAtLabel.Size = new System.Drawing.Size(85, 20);
            this.statistics_createdAtLabel.TabIndex = 12;
            this.statistics_createdAtLabel.Text = "Created at: ";
            // 
            // statistics_sizeLabel
            // 
            this.statistics_sizeLabel.AutoSize = true;
            this.statistics_sizeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statistics_sizeLabel.ForeColor = System.Drawing.Color.White;
            this.statistics_sizeLabel.Location = new System.Drawing.Point(9, 37);
            this.statistics_sizeLabel.Name = "statistics_sizeLabel";
            this.statistics_sizeLabel.Size = new System.Drawing.Size(75, 20);
            this.statistics_sizeLabel.TabIndex = 11;
            this.statistics_sizeLabel.Text = "Size (KB): ";
            // 
            // statistics_statisticsLabel
            // 
            this.statistics_statisticsLabel.AutoSize = true;
            this.statistics_statisticsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statistics_statisticsLabel.ForeColor = System.Drawing.Color.White;
            this.statistics_statisticsLabel.Location = new System.Drawing.Point(8, 3);
            this.statistics_statisticsLabel.Name = "statistics_statisticsLabel";
            this.statistics_statisticsLabel.Size = new System.Drawing.Size(99, 30);
            this.statistics_statisticsLabel.TabIndex = 10;
            this.statistics_statisticsLabel.Text = "Statistics";
            // 
            // tableStructure_recordsCountLabel
            // 
            this.tableStructure_recordsCountLabel.AutoSize = true;
            this.tableStructure_recordsCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableStructure_recordsCountLabel.ForeColor = System.Drawing.Color.White;
            this.tableStructure_recordsCountLabel.Location = new System.Drawing.Point(173, 141);
            this.tableStructure_recordsCountLabel.Name = "tableStructure_recordsCountLabel";
            this.tableStructure_recordsCountLabel.Size = new System.Drawing.Size(88, 21);
            this.tableStructure_recordsCountLabel.TabIndex = 6;
            this.tableStructure_recordsCountLabel.Text = "Elements: ";
            // 
            // tableStructure_tableStructureLabel
            // 
            this.tableStructure_tableStructureLabel.AutoSize = true;
            this.tableStructure_tableStructureLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableStructure_tableStructureLabel.ForeColor = System.Drawing.Color.White;
            this.tableStructure_tableStructureLabel.Location = new System.Drawing.Point(9, 134);
            this.tableStructure_tableStructureLabel.Name = "tableStructure_tableStructureLabel";
            this.tableStructure_tableStructureLabel.Size = new System.Drawing.Size(158, 30);
            this.tableStructure_tableStructureLabel.TabIndex = 2;
            this.tableStructure_tableStructureLabel.Text = "Table structure";
            // 
            // MySqlTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MySqlTableView";
            this.Text = "MySqlTableView";
            this.tableParametersLayout.ResumeLayout(false);
            this.tableParametersLayout.PerformLayout();
            this.tableView.ResumeLayout(false);
            this.browse.ResumeLayout(false);
            this.browse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.structure.ResumeLayout(false);
            this.structure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableParametersLayout;
        private System.Windows.Forms.Label tableStructure_nameLabel;
        private System.Windows.Forms.Label tableStructure_numberLabel;
        private System.Windows.Forms.Label tableStructure_comparingSubtitlesMethodLabel;
        private System.Windows.Forms.Label tableStructure_typeLabel;
        private System.Windows.Forms.TabControl tableView;
        private System.Windows.Forms.TabPage browse;
        private System.Windows.Forms.TabPage structure;
        private System.Windows.Forms.Label tableStructure_tableStructureLabel;
        private System.Windows.Forms.Label browse_browseLabel;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Label browse_rowsCountLabel;
        private System.Windows.Forms.Label tableStructure_recordsCountLabel;
        private System.Windows.Forms.Label statistics_columnsCountLabel;
        private System.Windows.Forms.Label statistics_recordsCountLabel;
        private System.Windows.Forms.Label statistics_lastUpdateLabel;
        private System.Windows.Forms.Label statistics_createdAtLabel;
        private System.Windows.Forms.Label statistics_sizeLabel;
        private System.Windows.Forms.Label statistics_statisticsLabel;
    }
}