
namespace DBManager.Views.Engines.MySql
{
    partial class MySqlDatabaseView
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
            this.databaseStructure_databaseStructureLabel = new System.Windows.Forms.Label();
            this.structure_databaseParametersDataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Records = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_comparingSubtitlesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure = new System.Windows.Forms.TabPage();
            this.structure_tablesCountLabel = new System.Windows.Forms.Label();
            this.databaseView = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.structure_databaseParametersDataGridView)).BeginInit();
            this.structure.SuspendLayout();
            this.databaseView.SuspendLayout();
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
            this.structure_databaseParametersDataGridView.AllowUserToResizeColumns = false;
            this.structure_databaseParametersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.structure_databaseParametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.structure_databaseParametersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.structure_databaseParametersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.structure_databaseParametersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.structure_databaseParametersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.structure_databaseParametersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.structure_databaseParametersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name,
            this.structure_Type,
            this.structure_Records,
            this.structure_size,
            this.structure_comparingSubtitlesMethod});
            this.structure_databaseParametersDataGridView.Location = new System.Drawing.Point(0, 36);
            this.structure_databaseParametersDataGridView.Name = "structure_databaseParametersDataGridView";
            this.structure_databaseParametersDataGridView.ReadOnly = true;
            this.structure_databaseParametersDataGridView.RowHeadersVisible = false;
            this.structure_databaseParametersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.structure_databaseParametersDataGridView.Size = new System.Drawing.Size(682, 332);
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
            this.structure.Controls.Add(this.structure_tablesCountLabel);
            this.structure.Controls.Add(this.structure_databaseParametersDataGridView);
            this.structure.Controls.Add(this.databaseStructure_databaseStructureLabel);
            this.structure.Location = new System.Drawing.Point(4, 22);
            this.structure.Margin = new System.Windows.Forms.Padding(0);
            this.structure.Name = "structure";
            this.structure.Padding = new System.Windows.Forms.Padding(3);
            this.structure.Size = new System.Drawing.Size(678, 364);
            this.structure.TabIndex = 1;
            this.structure.Text = "Structure";
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
            // databaseView
            // 
            this.databaseView.Controls.Add(this.structure);
            this.databaseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseView.Location = new System.Drawing.Point(0, 0);
            this.databaseView.Margin = new System.Windows.Forms.Padding(0);
            this.databaseView.Name = "databaseView";
            this.databaseView.Padding = new System.Drawing.Point(10, 3);
            this.databaseView.SelectedIndex = 0;
            this.databaseView.Size = new System.Drawing.Size(686, 390);
            this.databaseView.TabIndex = 4;
            // 
            // MySqlDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.databaseView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MySqlDatabaseView";
            this.Text = "MySqlDatabaseView";
            this.Shown += new System.EventHandler(this.MySqlDatabaseView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.structure_databaseParametersDataGridView)).EndInit();
            this.structure.ResumeLayout(false);
            this.structure.PerformLayout();
            this.databaseView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label databaseStructure_databaseStructureLabel;
        private System.Windows.Forms.DataGridView structure_databaseParametersDataGridView;
        private System.Windows.Forms.TabPage structure;
        private System.Windows.Forms.TabControl databaseView;
        private System.Windows.Forms.Label structure_tablesCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Records;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_comparingSubtitlesMethod;
    }
}