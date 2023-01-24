
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StructureView = new System.Windows.Forms.SplitContainer();
            this.Structure_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.DatabaseStructure_ListView = new System.Windows.Forms.ListView();
            this.tableNames = new System.Windows.Forms.ColumnHeader();
            this.SelectedDatabase_Label = new System.Windows.Forms.Label();
            this.TableStructure_ListView = new System.Windows.Forms.ListView();
            this.columnHeader = new System.Windows.Forms.ColumnHeader();
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
            this.ClearQuery_Button = new System.Windows.Forms.Button();
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
            this.StructureView.Location = new System.Drawing.Point(0, 39);
            this.StructureView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.StructureView.Size = new System.Drawing.Size(1084, 389);
            this.StructureView.SplitterDistance = 161;
            this.StructureView.SplitterWidth = 10;
            this.StructureView.TabIndex = 0;
            // 
            // Structure_SplitContainer
            // 
            this.Structure_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Structure_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Structure_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.Structure_SplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.Structure_SplitContainer.Size = new System.Drawing.Size(1084, 161);
            this.Structure_SplitContainer.SplitterDistance = 361;
            this.Structure_SplitContainer.SplitterWidth = 10;
            this.Structure_SplitContainer.TabIndex = 0;
            // 
            // DatabaseStructure_ListView
            // 
            this.DatabaseStructure_ListView.BackColor = System.Drawing.Color.White;
            this.DatabaseStructure_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableNames});
            this.DatabaseStructure_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseStructure_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DatabaseStructure_ListView.Location = new System.Drawing.Point(0, 0);
            this.DatabaseStructure_ListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DatabaseStructure_ListView.MultiSelect = false;
            this.DatabaseStructure_ListView.Name = "DatabaseStructure_ListView";
            this.DatabaseStructure_ListView.Size = new System.Drawing.Size(357, 157);
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
            this.SelectedDatabase_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedDatabase_Label.ForeColor = System.Drawing.Color.Black;
            this.SelectedDatabase_Label.Location = new System.Drawing.Point(4, 0);
            this.SelectedDatabase_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.TableStructure_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableStructure_ListView.Location = new System.Drawing.Point(0, 20);
            this.TableStructure_ListView.Margin = new System.Windows.Forms.Padding(0);
            this.TableStructure_ListView.MultiSelect = false;
            this.TableStructure_ListView.Name = "TableStructure_ListView";
            this.TableStructure_ListView.Size = new System.Drawing.Size(699, 137);
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
            this.QueryContainer_SplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QueryContainer_SplitContainer.Name = "QueryContainer_SplitContainer";
            // 
            // QueryContainer_SplitContainer.Panel1
            // 
            this.QueryContainer_SplitContainer.Panel1.Controls.Add(this.ClearQuery_Button);
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
            this.QueryContainer_SplitContainer.Size = new System.Drawing.Size(1084, 218);
            this.QueryContainer_SplitContainer.SplitterDistance = 383;
            this.QueryContainer_SplitContainer.SplitterWidth = 10;
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
            this.QueryAction_TableLayoutPanel.Location = new System.Drawing.Point(4, 171);
            this.QueryAction_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QueryAction_TableLayoutPanel.Name = "QueryAction_TableLayoutPanel";
            this.QueryAction_TableLayoutPanel.RowCount = 1;
            this.QueryAction_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QueryAction_TableLayoutPanel.Size = new System.Drawing.Size(373, 39);
            this.QueryAction_TableLayoutPanel.TabIndex = 15;
            // 
            // SendQuery_Button
            // 
            this.SendQuery_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendQuery_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendQuery_Button.ForeColor = System.Drawing.Color.Black;
            this.SendQuery_Button.Location = new System.Drawing.Point(4, 3);
            this.SendQuery_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendQuery_Button.Name = "SendQuery_Button";
            this.SendQuery_Button.Size = new System.Drawing.Size(215, 33);
            this.SendQuery_Button.TabIndex = 15;
            this.SendQuery_Button.Text = "Send Query";
            this.SendQuery_Button.UseVisualStyleBackColor = true;
            this.SendQuery_Button.Click += new System.EventHandler(this.SendQuery_Button_Click);
            // 
            // AddTrackedQuery_Button
            // 
            this.AddTrackedQuery_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTrackedQuery_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTrackedQuery_Button.ForeColor = System.Drawing.Color.Black;
            this.AddTrackedQuery_Button.Location = new System.Drawing.Point(227, 3);
            this.AddTrackedQuery_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTrackedQuery_Button.Name = "AddTrackedQuery_Button";
            this.AddTrackedQuery_Button.Size = new System.Drawing.Size(142, 33);
            this.AddTrackedQuery_Button.TabIndex = 16;
            this.AddTrackedQuery_Button.Text = "Add Tracked Query";
            this.AddTrackedQuery_Button.UseVisualStyleBackColor = true;
            this.AddTrackedQuery_Button.Click += new System.EventHandler(this.AddTrackedQuery_Button_Click);
            // 
            // Query_Label
            // 
            this.Query_Label.AutoSize = true;
            this.Query_Label.BackColor = System.Drawing.Color.White;
            this.Query_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Query_Label.ForeColor = System.Drawing.Color.Black;
            this.Query_Label.Location = new System.Drawing.Point(4, 1);
            this.Query_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.Crud_TableLayoutPanel.Location = new System.Drawing.Point(4, 132);
            this.Crud_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Crud_TableLayoutPanel.Name = "Crud_TableLayoutPanel";
            this.Crud_TableLayoutPanel.RowCount = 1;
            this.Crud_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Crud_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Crud_TableLayoutPanel.Size = new System.Drawing.Size(373, 32);
            this.Crud_TableLayoutPanel.TabIndex = 14;
            // 
            // Update_Button
            // 
            this.Update_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_Button.ForeColor = System.Drawing.Color.Black;
            this.Update_Button.Location = new System.Drawing.Point(283, 3);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(86, 26);
            this.Update_Button.TabIndex = 16;
            this.Update_Button.Text = "UPDATE";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Select_Button
            // 
            this.Select_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Select_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Select_Button.ForeColor = System.Drawing.Color.Black;
            this.Select_Button.Location = new System.Drawing.Point(4, 3);
            this.Select_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(85, 26);
            this.Select_Button.TabIndex = 13;
            this.Select_Button.Text = "SELECT";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insert_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Insert_Button.ForeColor = System.Drawing.Color.Black;
            this.Insert_Button.Location = new System.Drawing.Point(97, 3);
            this.Insert_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(85, 26);
            this.Insert_Button.TabIndex = 14;
            this.Insert_Button.Text = "INSERT";
            this.Insert_Button.UseVisualStyleBackColor = true;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Delete_Button.Location = new System.Drawing.Point(190, 3);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(85, 26);
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
            this.Query_RichTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Query_RichTextBox.Location = new System.Drawing.Point(1, 36);
            this.Query_RichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Query_RichTextBox.Name = "Query_RichTextBox";
            this.Query_RichTextBox.Size = new System.Drawing.Size(376, 88);
            this.Query_RichTextBox.TabIndex = 13;
            this.Query_RichTextBox.Text = "";
            // 
            // CopyData_Button
            // 
            this.CopyData_Button.ForeColor = System.Drawing.Color.Black;
            this.CopyData_Button.Location = new System.Drawing.Point(535, 6);
            this.CopyData_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CopyData_Button.Name = "CopyData_Button";
            this.CopyData_Button.Size = new System.Drawing.Size(148, 27);
            this.CopyData_Button.TabIndex = 19;
            this.CopyData_Button.Text = "Copy data";
            this.CopyData_Button.UseVisualStyleBackColor = true;
            this.CopyData_Button.Click += new System.EventHandler(this.CopyData_Button_Click);
            // 
            // QueryType_Label
            // 
            this.QueryType_Label.AutoSize = true;
            this.QueryType_Label.BackColor = System.Drawing.Color.White;
            this.QueryType_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QueryType_Label.ForeColor = System.Drawing.Color.Black;
            this.QueryType_Label.Location = new System.Drawing.Point(167, 8);
            this.QueryType_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QueryType_Label.Name = "QueryType_Label";
            this.QueryType_Label.Size = new System.Drawing.Size(54, 21);
            this.QueryType_Label.TabIndex = 18;
            this.QueryType_Label.Text = "Type: ";
            // 
            // QueryResult_Label
            // 
            this.QueryResult_Label.AutoSize = true;
            this.QueryResult_Label.BackColor = System.Drawing.Color.White;
            this.QueryResult_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QueryResult_Label.ForeColor = System.Drawing.Color.Black;
            this.QueryResult_Label.Location = new System.Drawing.Point(4, 1);
            this.QueryResult_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QueryResult_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.QueryResult_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryResult_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.QueryResult_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.QueryResult_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryResult_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.QueryResult_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QueryResult_DataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.QueryResult_DataGridView.EnableHeadersVisualStyles = false;
            this.QueryResult_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.QueryResult_DataGridView.Location = new System.Drawing.Point(0, 36);
            this.QueryResult_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.QueryResult_DataGridView.Name = "QueryResult_DataGridView";
            this.QueryResult_DataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QueryResult_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.QueryResult_DataGridView.RowHeadersVisible = false;
            this.QueryResult_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.QueryResult_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueryResult_DataGridView.Size = new System.Drawing.Size(677, 178);
            this.QueryResult_DataGridView.TabIndex = 10;
            // 
            // query_queryLabel
            // 
            this.query_queryLabel.AutoSize = true;
            this.query_queryLabel.BackColor = System.Drawing.Color.White;
            this.query_queryLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.query_queryLabel.ForeColor = System.Drawing.Color.Black;
            this.query_queryLabel.Location = new System.Drawing.Point(-174, 1);
            this.query_queryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.query_queryLabel.Name = "query_queryLabel";
            this.query_queryLabel.Size = new System.Drawing.Size(155, 30);
            this.query_queryLabel.TabIndex = 9;
            this.query_queryLabel.Text = "Query results: ";
            // 
            // Database_Label
            // 
            this.Database_Label.AutoSize = true;
            this.Database_Label.BackColor = System.Drawing.Color.White;
            this.Database_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Database_Label.ForeColor = System.Drawing.Color.Black;
            this.Database_Label.Location = new System.Drawing.Point(4, 1);
            this.Database_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Database_Label.Name = "Database_Label";
            this.Database_Label.Size = new System.Drawing.Size(102, 30);
            this.Database_Label.TabIndex = 19;
            this.Database_Label.Text = "Database";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BackColor = System.Drawing.Color.White;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.ForeColor = System.Drawing.Color.Black;
            this.Name_Label.Location = new System.Drawing.Point(132, 9);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(64, 21);
            this.Name_Label.TabIndex = 20;
            this.Name_Label.Text = "Name: ";
            // 
            // ClearQuery_Button
            // 
            this.ClearQuery_Button.ForeColor = System.Drawing.Color.Black;
            this.ClearQuery_Button.Location = new System.Drawing.Point(85, 4);
            this.ClearQuery_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearQuery_Button.Name = "ClearQuery_Button";
            this.ClearQuery_Button.Size = new System.Drawing.Size(57, 27);
            this.ClearQuery_Button.TabIndex = 20;
            this.ClearQuery_Button.Text = "Clear";
            this.ClearQuery_Button.UseVisualStyleBackColor = true;
            this.ClearQuery_Button.Click += new System.EventHandler(this.ClearQuery_Button_Click);
            // 
            // QueryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Database_Label);
            this.Controls.Add(this.StructureView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QueryView";
            this.Size = new System.Drawing.Size(1084, 428);
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
        private System.Windows.Forms.Button ClearQuery_Button;
    }
}
