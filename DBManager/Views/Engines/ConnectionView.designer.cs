
namespace DBManager.Views.Engines
{
    partial class ConnectionView
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
            this.ConnectionView_TabControl = new System.Windows.Forms.TabControl();
            this.Structure = new System.Windows.Forms.TabPage();
            this.Type_Structure_Label = new System.Windows.Forms.Label();
            this.Name_Structure_Label = new System.Windows.Forms.Label();
            this.Port_Structure_Label = new System.Windows.Forms.Label();
            this.Server_Structure_Label = new System.Windows.Forms.Label();
            this.LoggedAs_Structure_Label = new System.Windows.Forms.Label();
            this.Informations_Structure_Label = new System.Windows.Forms.Label();
            this.Databases_Structure_Label = new System.Windows.Forms.Label();
            this.Structure_Structure_DataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionStructure_Structure_Label = new System.Windows.Forms.Label();
            this.ConnectionView_TabControl.SuspendLayout();
            this.Structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionView_TabControl
            // 
            this.ConnectionView_TabControl.Controls.Add(this.Structure);
            this.ConnectionView_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionView_TabControl.Location = new System.Drawing.Point(0, 0);
            this.ConnectionView_TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.ConnectionView_TabControl.Name = "ConnectionView_TabControl";
            this.ConnectionView_TabControl.Padding = new System.Drawing.Point(10, 3);
            this.ConnectionView_TabControl.SelectedIndex = 0;
            this.ConnectionView_TabControl.Size = new System.Drawing.Size(800, 450);
            this.ConnectionView_TabControl.TabIndex = 5;
            // 
            // Structure
            // 
            this.Structure.BackColor = System.Drawing.Color.White;
            this.Structure.Controls.Add(this.Type_Structure_Label);
            this.Structure.Controls.Add(this.Name_Structure_Label);
            this.Structure.Controls.Add(this.Port_Structure_Label);
            this.Structure.Controls.Add(this.Server_Structure_Label);
            this.Structure.Controls.Add(this.LoggedAs_Structure_Label);
            this.Structure.Controls.Add(this.Informations_Structure_Label);
            this.Structure.Controls.Add(this.Databases_Structure_Label);
            this.Structure.Controls.Add(this.Structure_Structure_DataGridView);
            this.Structure.Controls.Add(this.ConnectionStructure_Structure_Label);
            this.Structure.Location = new System.Drawing.Point(4, 24);
            this.Structure.Margin = new System.Windows.Forms.Padding(0);
            this.Structure.Name = "Structure";
            this.Structure.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Structure.Size = new System.Drawing.Size(792, 422);
            this.Structure.TabIndex = 1;
            this.Structure.Text = "Structure";
            // 
            // Type_Structure_Label
            // 
            this.Type_Structure_Label.AutoSize = true;
            this.Type_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Type_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Type_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Type_Structure_Label.Location = new System.Drawing.Point(9, 61);
            this.Type_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type_Structure_Label.Name = "Type_Structure_Label";
            this.Type_Structure_Label.Size = new System.Drawing.Size(43, 20);
            this.Type_Structure_Label.TabIndex = 23;
            this.Type_Structure_Label.Text = "Type:";
            // 
            // Name_Structure_Label
            // 
            this.Name_Structure_Label.AutoSize = true;
            this.Name_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Name_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Structure_Label.Location = new System.Drawing.Point(9, 38);
            this.Name_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Structure_Label.Name = "Name_Structure_Label";
            this.Name_Structure_Label.Size = new System.Drawing.Size(56, 20);
            this.Name_Structure_Label.TabIndex = 22;
            this.Name_Structure_Label.Text = "Name: ";
            // 
            // Port_Structure_Label
            // 
            this.Port_Structure_Label.AutoSize = true;
            this.Port_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Port_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Port_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Port_Structure_Label.Location = new System.Drawing.Point(267, 84);
            this.Port_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Port_Structure_Label.Name = "Port_Structure_Label";
            this.Port_Structure_Label.Size = new System.Drawing.Size(42, 20);
            this.Port_Structure_Label.TabIndex = 21;
            this.Port_Structure_Label.Text = "Port: ";
            // 
            // Server_Structure_Label
            // 
            this.Server_Structure_Label.AutoSize = true;
            this.Server_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Server_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Server_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Server_Structure_Label.Location = new System.Drawing.Point(267, 61);
            this.Server_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Server_Structure_Label.Name = "Server_Structure_Label";
            this.Server_Structure_Label.Size = new System.Drawing.Size(57, 20);
            this.Server_Structure_Label.TabIndex = 20;
            this.Server_Structure_Label.Text = "Server: ";
            // 
            // LoggedAs_Structure_Label
            // 
            this.LoggedAs_Structure_Label.AutoSize = true;
            this.LoggedAs_Structure_Label.BackColor = System.Drawing.Color.White;
            this.LoggedAs_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoggedAs_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.LoggedAs_Structure_Label.Location = new System.Drawing.Point(267, 38);
            this.LoggedAs_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoggedAs_Structure_Label.Name = "LoggedAs_Structure_Label";
            this.LoggedAs_Structure_Label.Size = new System.Drawing.Size(81, 20);
            this.LoggedAs_Structure_Label.TabIndex = 19;
            this.LoggedAs_Structure_Label.Text = "Logged as:";
            // 
            // Informations_Structure_Label
            // 
            this.Informations_Structure_Label.AutoSize = true;
            this.Informations_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Informations_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Informations_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Informations_Structure_Label.Location = new System.Drawing.Point(6, 3);
            this.Informations_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Informations_Structure_Label.Name = "Informations_Structure_Label";
            this.Informations_Structure_Label.Size = new System.Drawing.Size(141, 30);
            this.Informations_Structure_Label.TabIndex = 18;
            this.Informations_Structure_Label.Text = "Informations";
            // 
            // Databases_Structure_Label
            // 
            this.Databases_Structure_Label.AutoSize = true;
            this.Databases_Structure_Label.BackColor = System.Drawing.Color.White;
            this.Databases_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Databases_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.Databases_Structure_Label.Location = new System.Drawing.Point(267, 117);
            this.Databases_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Databases_Structure_Label.Name = "Databases_Structure_Label";
            this.Databases_Structure_Label.Size = new System.Drawing.Size(96, 21);
            this.Databases_Structure_Label.TabIndex = 17;
            this.Databases_Structure_Label.Text = "Databases: ";
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
            this.structure_Name});
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
            this.Structure_Structure_DataGridView.Location = new System.Drawing.Point(0, 147);
            this.Structure_Structure_DataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Structure_Structure_DataGridView.Name = "Structure_Structure_DataGridView";
            this.Structure_Structure_DataGridView.ReadOnly = true;
            this.Structure_Structure_DataGridView.RowHeadersVisible = false;
            this.Structure_Structure_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Structure_Structure_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Structure_Structure_DataGridView.Size = new System.Drawing.Size(791, 278);
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
            // ConnectionStructure_Structure_Label
            // 
            this.ConnectionStructure_Structure_Label.AutoSize = true;
            this.ConnectionStructure_Structure_Label.BackColor = System.Drawing.Color.White;
            this.ConnectionStructure_Structure_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnectionStructure_Structure_Label.ForeColor = System.Drawing.Color.Black;
            this.ConnectionStructure_Structure_Label.Location = new System.Drawing.Point(4, 108);
            this.ConnectionStructure_Structure_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnectionStructure_Structure_Label.Name = "ConnectionStructure_Structure_Label";
            this.ConnectionStructure_Structure_Label.Size = new System.Drawing.Size(220, 30);
            this.ConnectionStructure_Structure_Label.TabIndex = 2;
            this.ConnectionStructure_Structure_Label.Text = "Connection structure";
            // 
            // ConnectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnectionView_TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConnectionView";
            this.Text = "MySqlConnectionView";
            this.ConnectionView_TabControl.ResumeLayout(false);
            this.Structure.ResumeLayout(false);
            this.Structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_Structure_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ConnectionView_TabControl;
        private System.Windows.Forms.TabPage Structure;
        private System.Windows.Forms.Label Databases_Structure_Label;
        private System.Windows.Forms.DataGridView Structure_Structure_DataGridView;
        private System.Windows.Forms.Label ConnectionStructure_Structure_Label;
        private System.Windows.Forms.Label Port_Structure_Label;
        private System.Windows.Forms.Label Server_Structure_Label;
        private System.Windows.Forms.Label LoggedAs_Structure_Label;
        private System.Windows.Forms.Label Informations_Structure_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.Label Type_Structure_Label;
        private System.Windows.Forms.Label Name_Structure_Label;
    }
}