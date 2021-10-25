
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
            this.StructureView = new System.Windows.Forms.SplitContainer();
            this.Structure_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.DatabaseStructure_ListView = new System.Windows.Forms.ListView();
            this.tableNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectedDatabase_Label = new System.Windows.Forms.Label();
            this.TableStructure_ListView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueryContainer_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.QueryAction_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SendQuery_Button = new System.Windows.Forms.Button();
            this.AddTrackedQuery_Button = new System.Windows.Forms.Button();
            this.Query_Label = new System.Windows.Forms.Label();
            this.Crud_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Select_Button = new System.Windows.Forms.Button();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Query_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CopyData_Button = new System.Windows.Forms.Button();
            this.QueryType_Label = new System.Windows.Forms.Label();
            this.QueryResult_Label = new System.Windows.Forms.Label();
            this.QueryResult_DataGridView = new System.Windows.Forms.DataGridView();
            this.query_queryLabel = new System.Windows.Forms.Label();
            this.Database_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StructureView)).BeginInit();
            this.StructureView.Panel1.SuspendLayout();
            this.StructureView.Panel2.SuspendLayout();
            this.StructureView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_SplitContainer)).BeginInit();
            this.Structure_SplitContainer.Panel1.SuspendLayout();
            this.Structure_SplitContainer.Panel2.SuspendLayout();
            this.Structure_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryContainer_SplitContainer)).BeginInit();
            this.QueryContainer_SplitContainer.Panel1.SuspendLayout();
            this.QueryContainer_SplitContainer.Panel2.SuspendLayout();
            this.QueryContainer_SplitContainer.SuspendLayout();
            this.QueryAction_TableLayoutPanel.SuspendLayout();
            this.Crud_TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResult_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StructureView
            // 
            this.StructureView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StructureView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StructureView.Location = new System.Drawing.Point(0, 34);
            this.StructureView.Name = "StructureView";
            this.StructureView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // StructureView.Panel1
            // 
            this.StructureView.Panel1.AutoScroll = true;
            this.StructureView.Panel1.Controls.Add(this.Structure_SplitContainer);
            this.StructureView.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // StructureView.Panel2
            // 
            this.StructureView.Panel2.Controls.Add(this.QueryContainer_SplitContainer);
            this.StructureView.Size = new System.Drawing.Size(929, 337);
            this.StructureView.SplitterDistance = 140;
            this.StructureView.SplitterWidth = 9;
            this.StructureView.TabIndex = 0;
            // 
            // Structure_SplitContainer
            // 
            this.Structure_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Structure_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Structure_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.Structure_SplitContainer.Name = "Structure_SplitContainer";
            // 
            // Structure_SplitContainer.Panel1
            // 
            this.Structure_SplitContainer.Panel1.Controls.Add(this.DatabaseStructure_ListView);
            // 
            // Structure_SplitContainer.Panel2
            // 
            this.Structure_SplitContainer.Panel2.Controls.Add(this.SelectedDatabase_Label);
            this.Structure_SplitContainer.Panel2.Controls.Add(this.TableStructure_ListView);
            this.Structure_SplitContainer.Size = new System.Drawing.Size(929, 140);
            this.Structure_SplitContainer.SplitterDistance = 310;
            this.Structure_SplitContainer.SplitterWidth = 9;
            this.Structure_SplitContainer.TabIndex = 0;
            // 
            // DatabaseStructure_ListView
            // 
            this.DatabaseStructure_ListView.BackColor = System.Drawing.Color.White;
            this.DatabaseStructure_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableNames});
            this.DatabaseStructure_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseStructure_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseStructure_ListView.HideSelection = false;
            this.DatabaseStructure_ListView.Location = new System.Drawing.Point(0, 0);
            this.DatabaseStructure_ListView.MultiSelect = false;
            this.DatabaseStructure_ListView.Name = "DatabaseStructure_ListView";
            this.DatabaseStructure_ListView.Size = new System.Drawing.Size(306, 136);
            this.DatabaseStructure_ListView.TabIndex = 1;
            this.DatabaseStructure_ListView.UseCompatibleStateImageBehavior = false;
            this.DatabaseStructure_ListView.View = System.Windows.Forms.View.Details;
            this.DatabaseStructure_ListView.SelectedIndexChanged += new System.EventHandler(this.DatabaseStructure_ListView_SelectedIndexChanged);
            // 
            // tableNames
            // 
            this.tableNames.Text = "Table";
            // 
            // SelectedDatabase_Label
            // 
            this.SelectedDatabase_Label.AutoSize = true;
            this.SelectedDatabase_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectedDatabase_Label.ForeColor = System.Drawing.Color.Black;
            this.SelectedDatabase_Label.Location = new System.Drawing.Point(3, 0);
            this.SelectedDatabase_Label.Name = "SelectedDatabase_Label";
            this.SelectedDatabase_Label.Size = new System.Drawing.Size(73, 17);
            this.SelectedDatabase_Label.TabIndex = 3;
            this.SelectedDatabase_Label.Text = "Database: ";
            this.SelectedDatabase_Label.Click += new System.EventHandler(this.SelectedDatabase_Label_Click);
            // 
            // TableStructure_ListView
            // 
            this.TableStructure_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableStructure_ListView.BackColor = System.Drawing.Color.White;
            this.TableStructure_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.TableStructure_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TableStructure_ListView.HideSelection = false;
            this.TableStructure_ListView.Location = new System.Drawing.Point(0, 17);
            this.TableStructure_ListView.Margin = new System.Windows.Forms.Padding(0);
            this.TableStructure_ListView.MultiSelect = false;
            this.TableStructure_ListView.Name = "TableStructure_ListView";
            this.TableStructure_ListView.Size = new System.Drawing.Size(606, 119);
            this.TableStructure_ListView.TabIndex = 2;
            this.TableStructure_ListView.UseCompatibleStateImageBehavior = false;
            this.TableStructure_ListView.View = System.Windows.Forms.View.Details;
            this.TableStructure_ListView.SelectedIndexChanged += new System.EventHandler(this.TableStructure_ListView_SelectedIndexChanged);
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Column";
            // 
            // QueryContainer_SplitContainer
            // 
            this.QueryContainer_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QueryContainer_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryContainer_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.QueryContainer_SplitContainer.Name = "QueryContainer_SplitContainer";
            // 
            // QueryContainer_SplitContainer.Panel1
            // 
            this.QueryContainer_SplitContainer.Panel1.Controls.Add(this.QueryAction_TableLayoutPanel);
            this.QueryContainer_SplitContainer.Panel1.Controls.Add(this.Query_Label);
            this.QueryContainer_SplitContainer.Panel1.Controls.Add(this.Crud_TableLayoutPanel);
            this.QueryContainer_SplitContainer.Panel1.Controls.Add(this.Query_RichTextBox);
            this.QueryContainer_SplitContainer.Panel1MinSize = 100;
            // 
            // QueryContainer_SplitContainer.Panel2
            // 
            this.QueryContainer_SplitContainer.Panel2.Controls.Add(this.CopyData_Button);
            this.QueryContainer_SplitContainer.Panel2.Controls.Add(this.QueryType_Label);
            this.QueryContainer_SplitContainer.Panel2.Controls.Add(this.QueryResult_Label);
            this.QueryContainer_SplitContainer.Panel2.Controls.Add(this.QueryResult_DataGridView);
            this.QueryContainer_SplitContainer.Panel2.Controls.Add(this.query_queryLabel);
            this.QueryContainer_SplitContainer.Size = new System.Drawing.Size(929, 188);
            this.QueryContainer_SplitContainer.SplitterDistance = 329;
            this.QueryContainer_SplitContainer.SplitterWidth = 9;
            this.QueryContainer_SplitContainer.TabIndex = 0;
            // 
            // QueryAction_TableLayoutPanel
            // 
            this.QueryAction_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryAction_TableLayoutPanel.ColumnCount = 2;
            this.QueryAction_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.QueryAction_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.QueryAction_TableLayoutPanel.Controls.Add(this.SendQuery_Button, 0, 0);
            this.QueryAction_TableLayoutPanel.Controls.Add(this.AddTrackedQuery_Button, 1, 0);
            this.QueryAction_TableLayoutPanel.Location = new System.Drawing.Point(3, 147);
            this.QueryAction_TableLayoutPanel.Name = "QueryAction_TableLayoutPanel";
            this.QueryAction_TableLayoutPanel.RowCount = 1;
            this.QueryAction_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QueryAction_TableLayoutPanel.Size = new System.Drawing.Size(320, 34);
            this.QueryAction_TableLayoutPanel.TabIndex = 15;
            // 
            // SendQuery_Button
            // 
            this.SendQuery_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendQuery_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.SendQuery_Button.ForeColor = System.Drawing.Color.Black;
            this.SendQuery_Button.Location = new System.Drawing.Point(3, 3);
            this.SendQuery_Button.Name = "SendQuery_Button";
            this.SendQuery_Button.Size = new System.Drawing.Size(186, 28);
            this.SendQuery_Button.TabIndex = 15;
            this.SendQuery_Button.Text = "Send Query";
            this.SendQuery_Button.UseVisualStyleBackColor = true;
            this.SendQuery_Button.Click += new System.EventHandler(this.SendQuery_Button_Click);
            // 
            // AddTrackedQuery_Button
            // 
            this.AddTrackedQuery_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTrackedQuery_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.AddTrackedQuery_Button.ForeColor = System.Drawing.Color.Black;
            this.AddTrackedQuery_Button.Location = new System.Drawing.Point(195, 3);
            this.AddTrackedQuery_Button.Name = "AddTrackedQuery_Button";
            this.AddTrackedQuery_Button.Size = new System.Drawing.Size(122, 28);
            this.AddTrackedQuery_Button.TabIndex = 16;
            this.AddTrackedQuery_Button.Text = "Add Tracked Query";
            this.AddTrackedQuery_Button.UseVisualStyleBackColor = true;
            this.AddTrackedQuery_Button.Click += new System.EventHandler(this.AddTrackedQuery_Button_Click);
            // 
            // Query_Label
            // 
            this.Query_Label.AutoSize = true;
            this.Query_Label.BackColor = System.Drawing.Color.White;
            this.Query_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Query_Label.ForeColor = System.Drawing.Color.Black;
            this.Query_Label.Location = new System.Drawing.Point(3, 1);
            this.Query_Label.Name = "Query_Label";
            this.Query_Label.Size = new System.Drawing.Size(73, 30);
            this.Query_Label.TabIndex = 12;
            this.Query_Label.Text = "Query";
            // 
            // Crud_TableLayoutPanel
            // 
            this.Crud_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crud_TableLayoutPanel.ColumnCount = 4;
            this.Crud_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Crud_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Crud_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Crud_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Crud_TableLayoutPanel.Controls.Add(this.Update_Button, 3, 0);
            this.Crud_TableLayoutPanel.Controls.Add(this.Select_Button, 0, 0);
            this.Crud_TableLayoutPanel.Controls.Add(this.Insert_Button, 1, 0);
            this.Crud_TableLayoutPanel.Controls.Add(this.Delete_Button, 2, 0);
            this.Crud_TableLayoutPanel.Location = new System.Drawing.Point(3, 113);
            this.Crud_TableLayoutPanel.Name = "Crud_TableLayoutPanel";
            this.Crud_TableLayoutPanel.RowCount = 1;
            this.Crud_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Crud_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Crud_TableLayoutPanel.Size = new System.Drawing.Size(319, 28);
            this.Crud_TableLayoutPanel.TabIndex = 14;
            // 
            // Update_Button
            // 
            this.Update_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Update_Button.ForeColor = System.Drawing.Color.Black;
            this.Update_Button.Location = new System.Drawing.Point(240, 3);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(76, 22);
            this.Update_Button.TabIndex = 16;
            this.Update_Button.Text = "UPDATE";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Select_Button
            // 
            this.Select_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Select_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Select_Button.ForeColor = System.Drawing.Color.Black;
            this.Select_Button.Location = new System.Drawing.Point(3, 3);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(73, 22);
            this.Select_Button.TabIndex = 13;
            this.Select_Button.Text = "SELECT";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insert_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Insert_Button.ForeColor = System.Drawing.Color.Black;
            this.Insert_Button.Location = new System.Drawing.Point(82, 3);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(73, 22);
            this.Insert_Button.TabIndex = 14;
            this.Insert_Button.Text = "INSERT";
            this.Insert_Button.UseVisualStyleBackColor = true;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Delete_Button.Location = new System.Drawing.Point(161, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(73, 22);
            this.Delete_Button.TabIndex = 15;
            this.Delete_Button.Text = "DELETE";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Query_RichTextBox
            // 
            this.Query_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Query_RichTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Query_RichTextBox.Location = new System.Drawing.Point(1, 31);
            this.Query_RichTextBox.Name = "Query_RichTextBox";
            this.Query_RichTextBox.Size = new System.Drawing.Size(322, 76);
            this.Query_RichTextBox.TabIndex = 13;
            this.Query_RichTextBox.Text = "";
            // 
            // CopyData_Button
            // 
            this.CopyData_Button.ForeColor = System.Drawing.Color.Black;
            this.CopyData_Button.Location = new System.Drawing.Point(252, 5);
            this.CopyData_Button.Name = "CopyData_Button";
            this.CopyData_Button.Size = new System.Drawing.Size(127, 23);
            this.CopyData_Button.TabIndex = 19;
            this.CopyData_Button.Text = "Copy data";
            this.CopyData_Button.UseVisualStyleBackColor = true;
            this.CopyData_Button.Click += new System.EventHandler(this.CopyData_Button_Click);
            // 
            // QueryType_Label
            // 
            this.QueryType_Label.AutoSize = true;
            this.QueryType_Label.BackColor = System.Drawing.Color.White;
            this.QueryType_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.QueryType_Label.ForeColor = System.Drawing.Color.Black;
            this.QueryType_Label.Location = new System.Drawing.Point(143, 7);
            this.QueryType_Label.Name = "QueryType_Label";
            this.QueryType_Label.Size = new System.Drawing.Size(54, 21);
            this.QueryType_Label.TabIndex = 18;
            this.QueryType_Label.Text = "Type: ";
            // 
            // QueryResult_Label
            // 
            this.QueryResult_Label.AutoSize = true;
            this.QueryResult_Label.BackColor = System.Drawing.Color.White;
            this.QueryResult_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.QueryResult_Label.ForeColor = System.Drawing.Color.Black;
            this.QueryResult_Label.Location = new System.Drawing.Point(3, 1);
            this.QueryResult_Label.Name = "QueryResult_Label";
            this.QueryResult_Label.Size = new System.Drawing.Size(143, 30);
            this.QueryResult_Label.TabIndex = 11;
            this.QueryResult_Label.Text = "Query results";
            // 
            // QueryResult_DataGridView
            // 
            this.QueryResult_DataGridView.AllowUserToAddRows = false;
            this.QueryResult_DataGridView.AllowUserToDeleteRows = false;
            this.QueryResult_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QueryResult_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QueryResult_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryResult_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.QueryResult_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.QueryResult_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryResult_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QueryResult_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QueryResult_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.QueryResult_DataGridView.EnableHeadersVisualStyles = false;
            this.QueryResult_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.QueryResult_DataGridView.Location = new System.Drawing.Point(0, 31);
            this.QueryResult_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.QueryResult_DataGridView.Name = "QueryResult_DataGridView";
            this.QueryResult_DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryResult_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.QueryResult_DataGridView.RowHeadersVisible = false;
            this.QueryResult_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.QueryResult_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueryResult_DataGridView.Size = new System.Drawing.Size(587, 153);
            this.QueryResult_DataGridView.TabIndex = 10;
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
            // Database_Label
            // 
            this.Database_Label.AutoSize = true;
            this.Database_Label.BackColor = System.Drawing.Color.White;
            this.Database_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Database_Label.ForeColor = System.Drawing.Color.Black;
            this.Database_Label.Location = new System.Drawing.Point(3, 1);
            this.Database_Label.Name = "Database_Label";
            this.Database_Label.Size = new System.Drawing.Size(102, 30);
            this.Database_Label.TabIndex = 19;
            this.Database_Label.Text = "Database";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BackColor = System.Drawing.Color.White;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Name_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Label.Location = new System.Drawing.Point(113, 8);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Label.TabIndex = 20;
            this.Name_Label.Text = "Name: ";
            // 
            // QueryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Database_Label);
            this.Controls.Add(this.StructureView);
            this.Name = "QueryView";
            this.Size = new System.Drawing.Size(929, 371);
            this.StructureView.Panel1.ResumeLayout(false);
            this.StructureView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StructureView)).EndInit();
            this.StructureView.ResumeLayout(false);
            this.Structure_SplitContainer.Panel1.ResumeLayout(false);
            this.Structure_SplitContainer.Panel2.ResumeLayout(false);
            this.Structure_SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Structure_SplitContainer)).EndInit();
            this.Structure_SplitContainer.ResumeLayout(false);
            this.QueryContainer_SplitContainer.Panel1.ResumeLayout(false);
            this.QueryContainer_SplitContainer.Panel1.PerformLayout();
            this.QueryContainer_SplitContainer.Panel2.ResumeLayout(false);
            this.QueryContainer_SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryContainer_SplitContainer)).EndInit();
            this.QueryContainer_SplitContainer.ResumeLayout(false);
            this.QueryAction_TableLayoutPanel.ResumeLayout(false);
            this.Crud_TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueryResult_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer StructureView;
        private System.Windows.Forms.SplitContainer QueryContainer_SplitContainer;
        private System.Windows.Forms.DataGridView QueryResult_DataGridView;
        private System.Windows.Forms.Label query_queryLabel;
        private System.Windows.Forms.Label QueryResult_Label;
        private System.Windows.Forms.RichTextBox Query_RichTextBox;
        private System.Windows.Forms.TableLayoutPanel Crud_TableLayoutPanel;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label Query_Label;
        private System.Windows.Forms.Button SendQuery_Button;
        private System.Windows.Forms.Label QueryType_Label;
        private System.Windows.Forms.Label Database_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.SplitContainer Structure_SplitContainer;
        private System.Windows.Forms.ListView DatabaseStructure_ListView;
        private System.Windows.Forms.ColumnHeader tableNames;
        private System.Windows.Forms.ListView TableStructure_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Label SelectedDatabase_Label;
        private System.Windows.Forms.Button AddTrackedQuery_Button;
        private System.Windows.Forms.TableLayoutPanel QueryAction_TableLayoutPanel;
        private System.Windows.Forms.Button CopyData_Button;
    }
}
