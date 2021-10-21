
namespace DBManager.Views.Engines
{
    partial class DatabaseView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseStructure_databaseStructureLabel = new System.Windows.Forms.Label();
            this.structure_databaseParametersDataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Records = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_comparingSubtitlesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure = new System.Windows.Forms.TabPage();
            this.structure_databaseNameLabel = new System.Windows.Forms.Label();
            this.structure_tablesCountLabel = new System.Windows.Forms.Label();
            this.databaseView_tabControl = new System.Windows.Forms.TabControl();
            this.query = new System.Windows.Forms.TabPage();
            this.trackedQueries = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.structure_databaseParametersDataGridView)).BeginInit();
            this.structure.SuspendLayout();
            this.databaseView_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseStructure_databaseStructureLabel
            // 
            this.databaseStructure_databaseStructureLabel.AutoSize = true;
            this.databaseStructure_databaseStructureLabel.BackColor = System.Drawing.Color.White;
            this.databaseStructure_databaseStructureLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.databaseStructure_databaseStructureLabel.ForeColor = System.Drawing.Color.Black;
            this.databaseStructure_databaseStructureLabel.Location = new System.Drawing.Point(3, 3);
            this.databaseStructure_databaseStructureLabel.Name = "databaseStructure_databaseStructureLabel";
            this.databaseStructure_databaseStructureLabel.Size = new System.Drawing.Size(196, 30);
            this.databaseStructure_databaseStructureLabel.TabIndex = 2;
            this.databaseStructure_databaseStructureLabel.Text = "Database structure";
            // 
            // structure_databaseParametersDataGridView
            // 
            this.structure_databaseParametersDataGridView.AllowUserToAddRows = false;
            this.structure_databaseParametersDataGridView.AllowUserToDeleteRows = false;
            this.structure_databaseParametersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.structure_databaseParametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.structure_databaseParametersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.structure_databaseParametersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.structure_databaseParametersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.structure_databaseParametersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.structure_databaseParametersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.structure_databaseParametersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.structure_databaseParametersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.structure_databaseParametersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name,
            this.structure_Type,
            this.structure_Records,
            this.structure_size,
            this.structure_comparingSubtitlesMethod});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.structure_databaseParametersDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.structure_databaseParametersDataGridView.EnableHeadersVisualStyles = false;
            this.structure_databaseParametersDataGridView.GridColor = System.Drawing.Color.Silver;
            this.structure_databaseParametersDataGridView.Location = new System.Drawing.Point(0, 36);
            this.structure_databaseParametersDataGridView.Name = "structure_databaseParametersDataGridView";
            this.structure_databaseParametersDataGridView.ReadOnly = true;
            this.structure_databaseParametersDataGridView.RowHeadersVisible = false;
            this.structure_databaseParametersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.structure_databaseParametersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.structure_databaseParametersDataGridView.Size = new System.Drawing.Size(691, 332);
            this.structure_databaseParametersDataGridView.TabIndex = 16;
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
            // structure_Records
            // 
            this.structure_Records.HeaderText = "Records";
            this.structure_Records.Name = "structure_Records";
            this.structure_Records.ReadOnly = true;
            // 
            // structure_size
            // 
            this.structure_size.HeaderText = "Size (KB)";
            this.structure_size.Name = "structure_size";
            this.structure_size.ReadOnly = true;
            // 
            // structure_comparingSubtitlesMethod
            // 
            this.structure_comparingSubtitlesMethod.HeaderText = "Comparing Subtitles Method";
            this.structure_comparingSubtitlesMethod.Name = "structure_comparingSubtitlesMethod";
            this.structure_comparingSubtitlesMethod.ReadOnly = true;
            // 
            // structure
            // 
            this.structure.BackColor = System.Drawing.Color.White;
            this.structure.Controls.Add(this.structure_databaseNameLabel);
            this.structure.Controls.Add(this.structure_tablesCountLabel);
            this.structure.Controls.Add(this.structure_databaseParametersDataGridView);
            this.structure.Controls.Add(this.databaseStructure_databaseStructureLabel);
            this.structure.Location = new System.Drawing.Point(4, 22);
            this.structure.Margin = new System.Windows.Forms.Padding(0);
            this.structure.Name = "structure";
            this.structure.Padding = new System.Windows.Forms.Padding(3);
            this.structure.Size = new System.Drawing.Size(691, 364);
            this.structure.TabIndex = 1;
            this.structure.Text = "Structure";
            // 
            // structure_databaseNameLabel
            // 
            this.structure_databaseNameLabel.AutoSize = true;
            this.structure_databaseNameLabel.BackColor = System.Drawing.Color.White;
            this.structure_databaseNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.structure_databaseNameLabel.ForeColor = System.Drawing.Color.Black;
            this.structure_databaseNameLabel.Location = new System.Drawing.Point(294, 10);
            this.structure_databaseNameLabel.Name = "structure_databaseNameLabel";
            this.structure_databaseNameLabel.Size = new System.Drawing.Size(64, 21);
            this.structure_databaseNameLabel.TabIndex = 21;
            this.structure_databaseNameLabel.Text = "Name: ";
            // 
            // structure_tablesCountLabel
            // 
            this.structure_tablesCountLabel.AutoSize = true;
            this.structure_tablesCountLabel.BackColor = System.Drawing.Color.White;
            this.structure_tablesCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.structure_tablesCountLabel.ForeColor = System.Drawing.Color.Black;
            this.structure_tablesCountLabel.Location = new System.Drawing.Point(205, 10);
            this.structure_tablesCountLabel.Name = "structure_tablesCountLabel";
            this.structure_tablesCountLabel.Size = new System.Drawing.Size(66, 21);
            this.structure_tablesCountLabel.TabIndex = 17;
            this.structure_tablesCountLabel.Text = "Tables: ";
            // 
            // databaseView_tabControl
            // 
            this.databaseView_tabControl.Controls.Add(this.structure);
            this.databaseView_tabControl.Controls.Add(this.query);
            this.databaseView_tabControl.Controls.Add(this.trackedQueries);
            this.databaseView_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseView_tabControl.Location = new System.Drawing.Point(0, 0);
            this.databaseView_tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.databaseView_tabControl.Name = "databaseView_tabControl";
            this.databaseView_tabControl.Padding = new System.Drawing.Point(10, 3);
            this.databaseView_tabControl.SelectedIndex = 0;
            this.databaseView_tabControl.Size = new System.Drawing.Size(699, 390);
            this.databaseView_tabControl.TabIndex = 4;
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(4, 22);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(691, 364);
            this.query.TabIndex = 2;
            this.query.Text = "Query";
            this.query.UseVisualStyleBackColor = true;
            this.query.Enter += new System.EventHandler(this.query_Enter);
            // 
            // trackedQueries
            // 
            this.trackedQueries.Location = new System.Drawing.Point(4, 22);
            this.trackedQueries.Name = "trackedQueries";
            this.trackedQueries.Padding = new System.Windows.Forms.Padding(3);
            this.trackedQueries.Size = new System.Drawing.Size(691, 364);
            this.trackedQueries.TabIndex = 3;
            this.trackedQueries.Text = "Tracked Queries";
            this.trackedQueries.UseVisualStyleBackColor = true;
            this.trackedQueries.Enter += new System.EventHandler(this.trackedQueries_Enter);
            // 
            // DatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 390);
            this.Controls.Add(this.databaseView_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatabaseView";
            this.Text = "MySqlDatabaseView";
            this.Load += new System.EventHandler(this.MySqlDatabaseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.structure_databaseParametersDataGridView)).EndInit();
            this.structure.ResumeLayout(false);
            this.structure.PerformLayout();
            this.databaseView_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label databaseStructure_databaseStructureLabel;
        private System.Windows.Forms.DataGridView structure_databaseParametersDataGridView;
        private System.Windows.Forms.TabPage structure;
        private System.Windows.Forms.TabControl databaseView_tabControl;
        private System.Windows.Forms.Label structure_tablesCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Records;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_comparingSubtitlesMethod;
        private System.Windows.Forms.TabPage query;
        private System.Windows.Forms.Label structure_databaseNameLabel;
        private System.Windows.Forms.TabPage trackedQueries;
    }
}