
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatabaseStructure_Structure_Label = new System.Windows.Forms.Label();
            this.Structure_Structure_DataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Records = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_comparingSubtitlesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Structure = new System.Windows.Forms.TabPage();
            this.Name_Structure_Label = new System.Windows.Forms.Label();
            this.Tables_Structure_Label = new System.Windows.Forms.Label();
            this.DatabaseView_TabControl = new System.Windows.Forms.TabControl();
            this.Query = new System.Windows.Forms.TabPage();
            this.TrackedQueries = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).BeginInit();
            this.Structure.SuspendLayout();
            this.DatabaseView_TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseStructure_Structure_Label
            // 
            this.DatabaseStructure_Structure_Label.AutoSize = true;
            this.DatabaseStructure_Structure_Label.BackColor = System.Drawing.Color.White;
            this.DatabaseStructure_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DatabaseStructure_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.DatabaseStructure_Structure_Label.Location = new System.Drawing.Point(4, 3);
            this.DatabaseStructure_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatabaseStructure_Structure_Label.Name = "DatabaseStructure_Structure_Label";
            this.DatabaseStructure_Structure_Label.Size = new System.Drawing.Size(196, 30);
            this.DatabaseStructure_Structure_Label.TabIndex = 2;
            this.DatabaseStructure_Structure_Label.Text = "Database structure";
            // 
            // Structure_Structure_DataGridView
            // 
            this.Structure_Structure_DataGridView.AllowUserToAddRows = false;
            this.Structure_Structure_DataGridView.AllowUserToDeleteRows = false;
            this.Structure_Structure_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Structure_Structure_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Structure_Structure_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Structure_Structure_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Structure_Structure_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Structure_Structure_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Structure_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Structure_Structure_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Structure_Structure_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name,
            this.structure_Type,
            this.structure_Records,
            this.structure_size,
            this.structure_comparingSubtitlesMethod});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Structure_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Structure_Structure_DataGridView.EnableHeadersVisualStyles = false;
            this.Structure_Structure_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.Structure_Structure_DataGridView.Location = new System.Drawing.Point(0, 42);
            this.Structure_Structure_DataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Structure_Structure_DataGridView.Name = "Structure_Structure_DataGridView";
            this.Structure_Structure_DataGridView.ReadOnly = true;
            this.Structure_Structure_DataGridView.RowHeadersVisible = false;
            this.Structure_Structure_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Structure_Structure_DataGridView.Size = new System.Drawing.Size(806, 383);
            this.Structure_Structure_DataGridView.TabIndex = 16;
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
            // Structure
            // 
            this.Structure.BackColor = System.Drawing.Color.White;
            this.Structure.Controls.Add(this.Name_Structure_Label);
            this.Structure.Controls.Add(this.Tables_Structure_Label);
            this.Structure.Controls.Add(this.Structure_Structure_DataGridView);
            this.Structure.Controls.Add(this.DatabaseStructure_Structure_Label);
            this.Structure.Location = new System.Drawing.Point(4, 24);
            this.Structure.Margin = new System.Windows.Forms.Padding(0);
            this.Structure.Name = "Structure";
            this.Structure.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Structure.Size = new System.Drawing.Size(808, 422);
            this.Structure.TabIndex = 1;
            this.Structure.Text = "Structure";
            // 
            // Name_Structure_Label
            // 
            this.Name_Structure_Label.AutoSize = true;
            this.Name_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Name_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Structure_Label.Location = new System.Drawing.Point(343, 12);
            this.Name_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Structure_Label.Name = "Name_Structure_Label";
            this.Name_Structure_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Structure_Label.TabIndex = 21;
            this.Name_Structure_Label.Text = "Name: ";
            // 
            // Tables_Structure_Label
            // 
            this.Tables_Structure_Label.AutoSize = true;
            this.Tables_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Tables_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tables_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Tables_Structure_Label.Location = new System.Drawing.Point(239, 12);
            this.Tables_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tables_Structure_Label.Name = "Tables_Structure_Label";
            this.Tables_Structure_Label.Size = new System.Drawing.Size(66, 21);
            this.Tables_Structure_Label.TabIndex = 17;
            this.Tables_Structure_Label.Text = "Tables: ";
            // 
            // DatabaseView_TabControl
            // 
            this.DatabaseView_TabControl.Controls.Add(this.Structure);
            this.DatabaseView_TabControl.Controls.Add(this.Query);
            this.DatabaseView_TabControl.Controls.Add(this.TrackedQueries);
            this.DatabaseView_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseView_TabControl.Location = new System.Drawing.Point(0, 0);
            this.DatabaseView_TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.DatabaseView_TabControl.Name = "DatabaseView_TabControl";
            this.DatabaseView_TabControl.Padding = new System.Drawing.Point(10, 3);
            this.DatabaseView_TabControl.SelectedIndex = 0;
            this.DatabaseView_TabControl.Size = new System.Drawing.Size(816, 450);
            this.DatabaseView_TabControl.TabIndex = 4;
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(4, 24);
            this.Query.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(808, 422);
            this.Query.TabIndex = 2;
            this.Query.Text = "Query";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Enter += new System.EventHandler(this.Query_Enter);
            // 
            // TrackedQueries
            // 
            this.TrackedQueries.Location = new System.Drawing.Point(4, 24);
            this.TrackedQueries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueries.Name = "TrackedQueries";
            this.TrackedQueries.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueries.Size = new System.Drawing.Size(808, 422);
            this.TrackedQueries.TabIndex = 3;
            this.TrackedQueries.Text = "Tracked Queries";
            this.TrackedQueries.UseVisualStyleBackColor = true;
            this.TrackedQueries.Enter += new System.EventHandler(this.TrackedQueries_Enter);
            // 
            // DatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.DatabaseView_TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DatabaseView";
            this.Text = "MySqlDatabaseView";
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).EndInit();
            this.Structure.ResumeLayout(false);
            this.Structure.PerformLayout();
            this.DatabaseView_TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label DatabaseStructure_Structure_Label;
        private System.Windows.Forms.DataGridView Structure_Structure_DataGridView;
        private System.Windows.Forms.TabPage Structure;
        private System.Windows.Forms.TabControl DatabaseView_TabControl;
        private System.Windows.Forms.Label Tables_Structure_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Records;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_comparingSubtitlesMethod;
        private System.Windows.Forms.TabPage Query;
        private System.Windows.Forms.Label Name_Structure_Label;
        private System.Windows.Forms.TabPage TrackedQueries;
    }
}