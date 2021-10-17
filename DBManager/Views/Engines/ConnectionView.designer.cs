
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.connectionView_tabControl = new System.Windows.Forms.TabControl();
            this.structure = new System.Windows.Forms.TabPage();
            this.informations_typeLabel = new System.Windows.Forms.Label();
            this.informations_connectionNameLabel = new System.Windows.Forms.Label();
            this.informations_portLabel = new System.Windows.Forms.Label();
            this.informations_serverLabel = new System.Windows.Forms.Label();
            this.informations_loggedAsLabel = new System.Windows.Forms.Label();
            this.informations_informationsLabel = new System.Windows.Forms.Label();
            this.structure_databasesCountLabel = new System.Windows.Forms.Label();
            this.structure_connectionParametersDataGridView = new System.Windows.Forms.DataGridView();
            this.structure_columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structure_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStructure_connectionStructureLabel = new System.Windows.Forms.Label();
            this.connectionView_tabControl.SuspendLayout();
            this.structure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.structure_connectionParametersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionView_tabControl
            // 
            this.connectionView_tabControl.Controls.Add(this.structure);
            this.connectionView_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionView_tabControl.Location = new System.Drawing.Point(0, 0);
            this.connectionView_tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.connectionView_tabControl.Name = "connectionView_tabControl";
            this.connectionView_tabControl.Padding = new System.Drawing.Point(10, 3);
            this.connectionView_tabControl.SelectedIndex = 0;
            this.connectionView_tabControl.Size = new System.Drawing.Size(686, 390);
            this.connectionView_tabControl.TabIndex = 5;
            // 
            // structure
            // 
            this.structure.BackColor = System.Drawing.Color.White;
            this.structure.Controls.Add(this.informations_typeLabel);
            this.structure.Controls.Add(this.informations_connectionNameLabel);
            this.structure.Controls.Add(this.informations_portLabel);
            this.structure.Controls.Add(this.informations_serverLabel);
            this.structure.Controls.Add(this.informations_loggedAsLabel);
            this.structure.Controls.Add(this.informations_informationsLabel);
            this.structure.Controls.Add(this.structure_databasesCountLabel);
            this.structure.Controls.Add(this.structure_connectionParametersDataGridView);
            this.structure.Controls.Add(this.connectionStructure_connectionStructureLabel);
            this.structure.Location = new System.Drawing.Point(4, 22);
            this.structure.Margin = new System.Windows.Forms.Padding(0);
            this.structure.Name = "structure";
            this.structure.Padding = new System.Windows.Forms.Padding(3);
            this.structure.Size = new System.Drawing.Size(678, 364);
            this.structure.TabIndex = 1;
            this.structure.Text = "Structure";
            // 
            // informations_typeLabel
            // 
            this.informations_typeLabel.AutoSize = true;
            this.informations_typeLabel.BackColor = System.Drawing.Color.White;
            this.informations_typeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.informations_typeLabel.ForeColor = System.Drawing.Color.Black;
            this.informations_typeLabel.Location = new System.Drawing.Point(8, 53);
            this.informations_typeLabel.Name = "informations_typeLabel";
            this.informations_typeLabel.Size = new System.Drawing.Size(43, 20);
            this.informations_typeLabel.TabIndex = 23;
            this.informations_typeLabel.Text = "Type:";
            // 
            // informations_connectionNameLabel
            // 
            this.informations_connectionNameLabel.AutoSize = true;
            this.informations_connectionNameLabel.BackColor = System.Drawing.Color.White;
            this.informations_connectionNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.informations_connectionNameLabel.ForeColor = System.Drawing.Color.Black;
            this.informations_connectionNameLabel.Location = new System.Drawing.Point(8, 33);
            this.informations_connectionNameLabel.Name = "informations_connectionNameLabel";
            this.informations_connectionNameLabel.Size = new System.Drawing.Size(56, 20);
            this.informations_connectionNameLabel.TabIndex = 22;
            this.informations_connectionNameLabel.Text = "Name: ";
            // 
            // informations_portLabel
            // 
            this.informations_portLabel.AutoSize = true;
            this.informations_portLabel.BackColor = System.Drawing.Color.White;
            this.informations_portLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.informations_portLabel.ForeColor = System.Drawing.Color.Black;
            this.informations_portLabel.Location = new System.Drawing.Point(229, 73);
            this.informations_portLabel.Name = "informations_portLabel";
            this.informations_portLabel.Size = new System.Drawing.Size(42, 20);
            this.informations_portLabel.TabIndex = 21;
            this.informations_portLabel.Text = "Port: ";
            // 
            // informations_serverLabel
            // 
            this.informations_serverLabel.AutoSize = true;
            this.informations_serverLabel.BackColor = System.Drawing.Color.White;
            this.informations_serverLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.informations_serverLabel.ForeColor = System.Drawing.Color.Black;
            this.informations_serverLabel.Location = new System.Drawing.Point(229, 53);
            this.informations_serverLabel.Name = "informations_serverLabel";
            this.informations_serverLabel.Size = new System.Drawing.Size(57, 20);
            this.informations_serverLabel.TabIndex = 20;
            this.informations_serverLabel.Text = "Server: ";
            // 
            // informations_loggedAsLabel
            // 
            this.informations_loggedAsLabel.AutoSize = true;
            this.informations_loggedAsLabel.BackColor = System.Drawing.Color.White;
            this.informations_loggedAsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.informations_loggedAsLabel.ForeColor = System.Drawing.Color.Black;
            this.informations_loggedAsLabel.Location = new System.Drawing.Point(229, 33);
            this.informations_loggedAsLabel.Name = "informations_loggedAsLabel";
            this.informations_loggedAsLabel.Size = new System.Drawing.Size(81, 20);
            this.informations_loggedAsLabel.TabIndex = 19;
            this.informations_loggedAsLabel.Text = "Logged as:";
            // 
            // informations_informationsLabel
            // 
            this.informations_informationsLabel.AutoSize = true;
            this.informations_informationsLabel.BackColor = System.Drawing.Color.White;
            this.informations_informationsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.informations_informationsLabel.ForeColor = System.Drawing.Color.Black;
            this.informations_informationsLabel.Location = new System.Drawing.Point(5, 3);
            this.informations_informationsLabel.Name = "informations_informationsLabel";
            this.informations_informationsLabel.Size = new System.Drawing.Size(141, 30);
            this.informations_informationsLabel.TabIndex = 18;
            this.informations_informationsLabel.Text = "Informations";
            // 
            // structure_databasesCountLabel
            // 
            this.structure_databasesCountLabel.AutoSize = true;
            this.structure_databasesCountLabel.BackColor = System.Drawing.Color.White;
            this.structure_databasesCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.structure_databasesCountLabel.ForeColor = System.Drawing.Color.Black;
            this.structure_databasesCountLabel.Location = new System.Drawing.Point(229, 101);
            this.structure_databasesCountLabel.Name = "structure_databasesCountLabel";
            this.structure_databasesCountLabel.Size = new System.Drawing.Size(96, 21);
            this.structure_databasesCountLabel.TabIndex = 17;
            this.structure_databasesCountLabel.Text = "Databases: ";
            // 
            // structure_connectionParametersDataGridView
            // 
            this.structure_connectionParametersDataGridView.AllowUserToAddRows = false;
            this.structure_connectionParametersDataGridView.AllowUserToDeleteRows = false;
            this.structure_connectionParametersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.structure_connectionParametersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.structure_connectionParametersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.structure_connectionParametersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.structure_connectionParametersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.structure_connectionParametersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.structure_connectionParametersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.structure_connectionParametersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.structure_connectionParametersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.structure_connectionParametersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.structure_columnNumber,
            this.structure_Name});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.structure_connectionParametersDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.structure_connectionParametersDataGridView.EnableHeadersVisualStyles = false;
            this.structure_connectionParametersDataGridView.GridColor = System.Drawing.Color.Silver;
            this.structure_connectionParametersDataGridView.Location = new System.Drawing.Point(0, 127);
            this.structure_connectionParametersDataGridView.Name = "structure_connectionParametersDataGridView";
            this.structure_connectionParametersDataGridView.ReadOnly = true;
            this.structure_connectionParametersDataGridView.RowHeadersVisible = false;
            this.structure_connectionParametersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.structure_connectionParametersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.structure_connectionParametersDataGridView.Size = new System.Drawing.Size(678, 241);
            this.structure_connectionParametersDataGridView.TabIndex = 16;
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
            // connectionStructure_connectionStructureLabel
            // 
            this.connectionStructure_connectionStructureLabel.AutoSize = true;
            this.connectionStructure_connectionStructureLabel.BackColor = System.Drawing.Color.White;
            this.connectionStructure_connectionStructureLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.connectionStructure_connectionStructureLabel.ForeColor = System.Drawing.Color.Black;
            this.connectionStructure_connectionStructureLabel.Location = new System.Drawing.Point(3, 94);
            this.connectionStructure_connectionStructureLabel.Name = "connectionStructure_connectionStructureLabel";
            this.connectionStructure_connectionStructureLabel.Size = new System.Drawing.Size(220, 30);
            this.connectionStructure_connectionStructureLabel.TabIndex = 2;
            this.connectionStructure_connectionStructureLabel.Text = "Connection structure";
            // 
            // ConnectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.connectionView_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionView";
            this.Text = "MySqlConnectionView";
            this.Load += new System.EventHandler(this.MySqlConnectionView_Load);
            this.connectionView_tabControl.ResumeLayout(false);
            this.structure.ResumeLayout(false);
            this.structure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.structure_connectionParametersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl connectionView_tabControl;
        private System.Windows.Forms.TabPage structure;
        private System.Windows.Forms.Label structure_databasesCountLabel;
        private System.Windows.Forms.DataGridView structure_connectionParametersDataGridView;
        private System.Windows.Forms.Label connectionStructure_connectionStructureLabel;
        private System.Windows.Forms.Label informations_portLabel;
        private System.Windows.Forms.Label informations_serverLabel;
        private System.Windows.Forms.Label informations_loggedAsLabel;
        private System.Windows.Forms.Label informations_informationsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn structure_Name;
        private System.Windows.Forms.Label informations_typeLabel;
        private System.Windows.Forms.Label informations_connectionNameLabel;
    }
}