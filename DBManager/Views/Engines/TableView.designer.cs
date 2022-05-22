
namespace DBManager.Views.Engines
{
    partial class TableView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableView_TabControl = new System.Windows.Forms.TabControl();
            this.Browse = new System.Windows.Forms.TabPage();
            this.UnsupportedColumns_Browse_Button = new System.Windows.Forms.Button();
            this.Name_Browse_Label = new System.Windows.Forms.Label();
            this.Structure_Browse_DataGridView = new System.Windows.Forms.DataGridView();
            this.Elements_Browse_Label = new System.Windows.Forms.Label();
            this.TableData_Browse_Label = new System.Windows.Forms.Label();
            this.Structure = new System.Windows.Forms.TabPage();
            this.CustomInformations_Structure_ListView = new System.Windows.Forms.ListView();
            this.Name_Structure_Label = new System.Windows.Forms.Label();
            this.Structure_Structure_DataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_comparingSubtitlesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columns_Structure_Label = new System.Windows.Forms.Label();
            this.Records_Structure_Label = new System.Windows.Forms.Label();
            this.Statistics_Structure_Label = new System.Windows.Forms.Label();
            this.TableStructure_Structure_Label = new System.Windows.Forms.Label();
            this.CustomInformations_Structure_Label = new System.Windows.Forms.Label();
            this.TableView_TabControl.SuspendLayout();
            this.Browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Browse_DataGridView)).BeginInit();
            this.Structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView_TabControl
            // 
            this.TableView_TabControl.Controls.Add(this.Browse);
            this.TableView_TabControl.Controls.Add(this.Structure);
            this.TableView_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableView_TabControl.Location = new System.Drawing.Point(0, 0);
            this.TableView_TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TableView_TabControl.Name = "TableView_TabControl";
            this.TableView_TabControl.Padding = new System.Drawing.Point(10, 3);
            this.TableView_TabControl.SelectedIndex = 0;
            this.TableView_TabControl.Size = new System.Drawing.Size(686, 390);
            this.TableView_TabControl.TabIndex = 3;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.White;
            this.Browse.Controls.Add(this.UnsupportedColumns_Browse_Button);
            this.Browse.Controls.Add(this.Name_Browse_Label);
            this.Browse.Controls.Add(this.Structure_Browse_DataGridView);
            this.Browse.Controls.Add(this.Elements_Browse_Label);
            this.Browse.Controls.Add(this.TableData_Browse_Label);
            this.Browse.Location = new System.Drawing.Point(4, 22);
            this.Browse.Name = "Browse";
            this.Browse.Padding = new System.Windows.Forms.Padding(3);
            this.Browse.Size = new System.Drawing.Size(678, 364);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            // 
            // UnsupportedColumns_Browse_Button
            // 
            this.UnsupportedColumns_Browse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnsupportedColumns_Browse_Button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnsupportedColumns_Browse_Button.ForeColor = System.Drawing.Color.Black;
            this.UnsupportedColumns_Browse_Button.Location = new System.Drawing.Point(540, 6);
            this.UnsupportedColumns_Browse_Button.Name = "UnsupportedColumns_Browse_Button";
            this.UnsupportedColumns_Browse_Button.Size = new System.Drawing.Size(130, 23);
            this.UnsupportedColumns_Browse_Button.TabIndex = 22;
            this.UnsupportedColumns_Browse_Button.Text = "Unsupported columns";
            this.UnsupportedColumns_Browse_Button.UseVisualStyleBackColor = true;
            this.UnsupportedColumns_Browse_Button.Click += new System.EventHandler(this.UnsupportedColumns_Browse_Button_Click);
            // 
            // Name_Browse_Label
            // 
            this.Name_Browse_Label.AutoSize = true;
            this.Name_Browse_Label.BackColor = System.Drawing.Color.White;
            this.Name_Browse_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Name_Browse_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Browse_Label.Location = new System.Drawing.Point(248, 9);
            this.Name_Browse_Label.Name = "Name_Browse_Label";
            this.Name_Browse_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Browse_Label.TabIndex = 21;
            this.Name_Browse_Label.Text = "Name: ";
            // 
            // Structure_Browse_DataGridView
            // 
            this.Structure_Browse_DataGridView.AllowUserToAddRows = false;
            this.Structure_Browse_DataGridView.AllowUserToDeleteRows = false;
            this.Structure_Browse_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Browse_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Structure_Browse_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Structure_Browse_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Structure_Browse_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Structure_Browse_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Browse_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Structure_Browse_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Browse_DataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.Structure_Browse_DataGridView.EnableHeadersVisualStyles = false;
            this.Structure_Browse_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.Structure_Browse_DataGridView.Location = new System.Drawing.Point(0, 33);
            this.Structure_Browse_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.Structure_Browse_DataGridView.Name = "Structure_Browse_DataGridView";
            this.Structure_Browse_DataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Browse_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Structure_Browse_DataGridView.RowHeadersVisible = false;
            this.Structure_Browse_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Structure_Browse_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Structure_Browse_DataGridView.Size = new System.Drawing.Size(678, 331);
            this.Structure_Browse_DataGridView.TabIndex = 6;
            this.Structure_Browse_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Structure_Browse_DataGridView_DataError);
            // 
            // Elements_Browse_Label
            // 
            this.Elements_Browse_Label.AutoSize = true;
            this.Elements_Browse_Label.BackColor = System.Drawing.Color.White;
            this.Elements_Browse_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Elements_Browse_Label.ForeColor = System.Drawing.Color.Black;
            this.Elements_Browse_Label.Location = new System.Drawing.Point(123, 9);
            this.Elements_Browse_Label.Name = "Elements_Browse_Label";
            this.Elements_Browse_Label.Size = new System.Drawing.Size(88, 21);
            this.Elements_Browse_Label.TabIndex = 5;
            this.Elements_Browse_Label.Text = "Elements: ";
            // 
            // TableData_Browse_Label
            // 
            this.TableData_Browse_Label.AutoSize = true;
            this.TableData_Browse_Label.BackColor = System.Drawing.Color.White;
            this.TableData_Browse_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.TableData_Browse_Label.ForeColor = System.Drawing.Color.Black;
            this.TableData_Browse_Label.Location = new System.Drawing.Point(7, 3);
            this.TableData_Browse_Label.Name = "TableData_Browse_Label";
            this.TableData_Browse_Label.Size = new System.Drawing.Size(113, 30);
            this.TableData_Browse_Label.TabIndex = 3;
            this.TableData_Browse_Label.Text = "Table data";
            // 
            // Structure
            // 
            this.Structure.BackColor = System.Drawing.Color.White;
            this.Structure.Controls.Add(this.CustomInformations_Structure_Label);
            this.Structure.Controls.Add(this.CustomInformations_Structure_ListView);
            this.Structure.Controls.Add(this.Name_Structure_Label);
            this.Structure.Controls.Add(this.Structure_Structure_DataGridView);
            this.Structure.Controls.Add(this.Columns_Structure_Label);
            this.Structure.Controls.Add(this.Records_Structure_Label);
            this.Structure.Controls.Add(this.Statistics_Structure_Label);
            this.Structure.Controls.Add(this.TableStructure_Structure_Label);
            this.Structure.Location = new System.Drawing.Point(4, 22);
            this.Structure.Margin = new System.Windows.Forms.Padding(0);
            this.Structure.Name = "Structure";
            this.Structure.Padding = new System.Windows.Forms.Padding(3);
            this.Structure.Size = new System.Drawing.Size(678, 364);
            this.Structure.TabIndex = 1;
            this.Structure.Text = "Structure";
            // 
            // CustomInformations_Structure_ListView
            // 
            this.CustomInformations_Structure_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomInformations_Structure_ListView.HideSelection = false;
            this.CustomInformations_Structure_ListView.Location = new System.Drawing.Point(426, 33);
            this.CustomInformations_Structure_ListView.Name = "CustomInformations_Structure_ListView";
            this.CustomInformations_Structure_ListView.Size = new System.Drawing.Size(244, 93);
            this.CustomInformations_Structure_ListView.TabIndex = 22;
            this.CustomInformations_Structure_ListView.UseCompatibleStateImageBehavior = false;
            this.CustomInformations_Structure_ListView.View = System.Windows.Forms.View.List;
            // 
            // Name_Structure_Label
            // 
            this.Name_Structure_Label.AutoSize = true;
            this.Name_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Name_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Name_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Structure_Label.Location = new System.Drawing.Point(9, 33);
            this.Name_Structure_Label.Name = "Name_Structure_Label";
            this.Name_Structure_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Structure_Label.TabIndex = 21;
            this.Name_Structure_Label.Text = "Name: ";
            // 
            // Structure_Structure_DataGridView
            // 
            this.Structure_Structure_DataGridView.AllowUserToAddRows = false;
            this.Structure_Structure_DataGridView.AllowUserToDeleteRows = false;
            this.Structure_Structure_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Structure_Structure_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Structure_Structure_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Structure_Structure_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Structure_Structure_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Structure_Structure_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Structure_Structure_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Structure_Structure_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Structure_Structure_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name,
            this.structure_Type,
            this.structure_comparingSubtitlesMethod});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Structure_Structure_DataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.Structure_Structure_DataGridView.EnableHeadersVisualStyles = false;
            this.Structure_Structure_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.Structure_Structure_DataGridView.Location = new System.Drawing.Point(0, 132);
            this.Structure_Structure_DataGridView.Name = "Structure_Structure_DataGridView";
            this.Structure_Structure_DataGridView.ReadOnly = true;
            this.Structure_Structure_DataGridView.RowHeadersVisible = false;
            this.Structure_Structure_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Structure_Structure_DataGridView.Size = new System.Drawing.Size(678, 236);
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
            // structure_comparingSubtitlesMethod
            // 
            this.structure_comparingSubtitlesMethod.HeaderText = "Comparing Subtitles Method";
            this.structure_comparingSubtitlesMethod.Name = "structure_comparingSubtitlesMethod";
            this.structure_comparingSubtitlesMethod.ReadOnly = true;
            // 
            // Columns_Structure_Label
            // 
            this.Columns_Structure_Label.AutoSize = true;
            this.Columns_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Columns_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Columns_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Columns_Structure_Label.Location = new System.Drawing.Point(9, 74);
            this.Columns_Structure_Label.Name = "Columns_Structure_Label";
            this.Columns_Structure_Label.Size = new System.Drawing.Size(69, 20);
            this.Columns_Structure_Label.TabIndex = 15;
            this.Columns_Structure_Label.Text = "Columns:";
            // 
            // Records_Structure_Label
            // 
            this.Records_Structure_Label.AutoSize = true;
            this.Records_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Records_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Records_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Records_Structure_Label.Location = new System.Drawing.Point(9, 54);
            this.Records_Structure_Label.Name = "Records_Structure_Label";
            this.Records_Structure_Label.Size = new System.Drawing.Size(69, 20);
            this.Records_Structure_Label.TabIndex = 14;
            this.Records_Structure_Label.Text = "Records: ";
            // 
            // Statistics_Structure_Label
            // 
            this.Statistics_Structure_Label.AutoSize = true;
            this.Statistics_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Statistics_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Statistics_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Statistics_Structure_Label.Location = new System.Drawing.Point(8, 3);
            this.Statistics_Structure_Label.Name = "Statistics_Structure_Label";
            this.Statistics_Structure_Label.Size = new System.Drawing.Size(99, 30);
            this.Statistics_Structure_Label.TabIndex = 10;
            this.Statistics_Structure_Label.Text = "Statistics";
            // 
            // TableStructure_Structure_Label
            // 
            this.TableStructure_Structure_Label.AutoSize = true;
            this.TableStructure_Structure_Label.BackColor = System.Drawing.Color.White;
            this.TableStructure_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.TableStructure_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.TableStructure_Structure_Label.Location = new System.Drawing.Point(7, 99);
            this.TableStructure_Structure_Label.Name = "TableStructure_Structure_Label";
            this.TableStructure_Structure_Label.Size = new System.Drawing.Size(158, 30);
            this.TableStructure_Structure_Label.TabIndex = 2;
            this.TableStructure_Structure_Label.Text = "Table structure";
            // 
            // CustomInformations_Structure_Label
            // 
            this.CustomInformations_Structure_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomInformations_Structure_Label.AutoSize = true;
            this.CustomInformations_Structure_Label.BackColor = System.Drawing.Color.White;
            this.CustomInformations_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CustomInformations_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.CustomInformations_Structure_Label.Location = new System.Drawing.Point(422, 10);
            this.CustomInformations_Structure_Label.Name = "CustomInformations_Structure_Label";
            this.CustomInformations_Structure_Label.Size = new System.Drawing.Size(175, 21);
            this.CustomInformations_Structure_Label.TabIndex = 23;
            this.CustomInformations_Structure_Label.Text = "Custom informations:";
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.TableView_TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableView";
            this.Text = "MySqlTableView";
            this.Load += new System.EventHandler(this.MySqlTableView_Load);
            this.TableView_TabControl.ResumeLayout(false);
            this.Browse.ResumeLayout(false);
            this.Browse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Browse_DataGridView)).EndInit();
            this.Structure.ResumeLayout(false);
            this.Structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TableView_TabControl;
        private System.Windows.Forms.TabPage Browse;
        private System.Windows.Forms.TabPage Structure;
        private System.Windows.Forms.Label TableStructure_Structure_Label;
        private System.Windows.Forms.Label TableData_Browse_Label;
        private System.Windows.Forms.Label Elements_Browse_Label;
        private System.Windows.Forms.Label Columns_Structure_Label;
        private System.Windows.Forms.Label Records_Structure_Label;
        private System.Windows.Forms.Label Statistics_Structure_Label;
        private System.Windows.Forms.DataGridView Structure_Browse_DataGridView;
        private System.Windows.Forms.DataGridView Structure_Structure_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_comparingSubtitlesMethod;
        private System.Windows.Forms.Label Name_Browse_Label;
        private System.Windows.Forms.Label Name_Structure_Label;
        private System.Windows.Forms.Button UnsupportedColumns_Browse_Button;
        private System.Windows.Forms.ListView CustomInformations_Structure_ListView;
        private System.Windows.Forms.Label CustomInformations_Structure_Label;
    }
}