
namespace DBManager.Views.Engines
{
    partial class TrackedQueriesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trackedQueriesContainer = new System.Windows.Forms.SplitContainer();
            this.TrackedQueriesList_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TimePeriod_Label = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.TrackedQueries_ListView = new System.Windows.Forms.ListView();
            this.TrackedQueryNames = new System.Windows.Forms.ColumnHeader();
            this.TimePeriod = new System.Windows.Forms.ColumnHeader();
            this.SnapshotsCount = new System.Windows.Forms.ColumnHeader();
            this.Below_Button = new System.Windows.Forms.Button();
            this.Above_Button = new System.Windows.Forms.Button();
            this.TrackedQueriesSnapshots_ListView = new System.Windows.Forms.ListView();
            this.Snapshots = new System.Windows.Forms.ColumnHeader();
            this.TrackedQueriesSection_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TrackedQueriesResult_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.FirstQueryUpdateTime_Label = new System.Windows.Forms.Label();
            this.FirstQuerySnapshot_DataGridView = new System.Windows.Forms.DataGridView();
            this.SecondQueryUpdateTime_Label = new System.Windows.Forms.Label();
            this.SecondQuerySnapshot_DataGridView = new System.Windows.Forms.DataGridView();
            this.QuerySummary_Label = new System.Windows.Forms.Label();
            this.TrackedQueriesDifference_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesContainer)).BeginInit();
            this.trackedQueriesContainer.Panel1.SuspendLayout();
            this.trackedQueriesContainer.Panel2.SuspendLayout();
            this.trackedQueriesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesList_SplitContainer)).BeginInit();
            this.TrackedQueriesList_SplitContainer.Panel1.SuspendLayout();
            this.TrackedQueriesList_SplitContainer.Panel2.SuspendLayout();
            this.TrackedQueriesList_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesSection_SplitContainer)).BeginInit();
            this.TrackedQueriesSection_SplitContainer.Panel1.SuspendLayout();
            this.TrackedQueriesSection_SplitContainer.Panel2.SuspendLayout();
            this.TrackedQueriesSection_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesResult_SplitContainer)).BeginInit();
            this.TrackedQueriesResult_SplitContainer.Panel1.SuspendLayout();
            this.TrackedQueriesResult_SplitContainer.Panel2.SuspendLayout();
            this.TrackedQueriesResult_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstQuerySnapshot_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondQuerySnapshot_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesDifference_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trackedQueriesContainer
            // 
            this.trackedQueriesContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trackedQueriesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackedQueriesContainer.Location = new System.Drawing.Point(0, 0);
            this.trackedQueriesContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackedQueriesContainer.Name = "trackedQueriesContainer";
            // 
            // trackedQueriesContainer.Panel1
            // 
            this.trackedQueriesContainer.Panel1.Controls.Add(this.TrackedQueriesList_SplitContainer);
            // 
            // trackedQueriesContainer.Panel2
            // 
            this.trackedQueriesContainer.Panel2.Controls.Add(this.TrackedQueriesSection_SplitContainer);
            this.trackedQueriesContainer.Size = new System.Drawing.Size(1084, 428);
            this.trackedQueriesContainer.SplitterDistance = 361;
            this.trackedQueriesContainer.SplitterWidth = 10;
            this.trackedQueriesContainer.TabIndex = 1;
            // 
            // TrackedQueriesList_SplitContainer
            // 
            this.TrackedQueriesList_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrackedQueriesList_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackedQueriesList_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.TrackedQueriesList_SplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueriesList_SplitContainer.Name = "TrackedQueriesList_SplitContainer";
            this.TrackedQueriesList_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TrackedQueriesList_SplitContainer.Panel1
            // 
            this.TrackedQueriesList_SplitContainer.Panel1.Controls.Add(this.TimePeriod_Label);
            this.TrackedQueriesList_SplitContainer.Panel1.Controls.Add(this.Delete_Button);
            this.TrackedQueriesList_SplitContainer.Panel1.Controls.Add(this.Refresh_Button);
            this.TrackedQueriesList_SplitContainer.Panel1.Controls.Add(this.TrackedQueries_ListView);
            // 
            // TrackedQueriesList_SplitContainer.Panel2
            // 
            this.TrackedQueriesList_SplitContainer.Panel2.Controls.Add(this.Below_Button);
            this.TrackedQueriesList_SplitContainer.Panel2.Controls.Add(this.Above_Button);
            this.TrackedQueriesList_SplitContainer.Panel2.Controls.Add(this.TrackedQueriesSnapshots_ListView);
            this.TrackedQueriesList_SplitContainer.Size = new System.Drawing.Size(361, 428);
            this.TrackedQueriesList_SplitContainer.SplitterDistance = 233;
            this.TrackedQueriesList_SplitContainer.SplitterWidth = 10;
            this.TrackedQueriesList_SplitContainer.TabIndex = 2;
            // 
            // TimePeriod_Label
            // 
            this.TimePeriod_Label.AutoSize = true;
            this.TimePeriod_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimePeriod_Label.ForeColor = System.Drawing.Color.Black;
            this.TimePeriod_Label.Location = new System.Drawing.Point(4, 32);
            this.TimePeriod_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimePeriod_Label.Name = "TimePeriod_Label";
            this.TimePeriod_Label.Size = new System.Drawing.Size(176, 20);
            this.TimePeriod_Label.TabIndex = 13;
            this.TimePeriod_Label.Text = "Update every x minutes";
            // 
            // Delete_Button
            // 
            this.Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Delete_Button.Location = new System.Drawing.Point(99, 5);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(88, 27);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.ForeColor = System.Drawing.Color.Black;
            this.Refresh_Button.Location = new System.Drawing.Point(5, 5);
            this.Refresh_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(88, 27);
            this.Refresh_Button.TabIndex = 2;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // TrackedQueries_ListView
            // 
            this.TrackedQueries_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackedQueries_ListView.BackColor = System.Drawing.Color.White;
            this.TrackedQueries_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackedQueryNames,
            this.TimePeriod,
            this.SnapshotsCount});
            this.TrackedQueries_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrackedQueries_ListView.Location = new System.Drawing.Point(0, 59);
            this.TrackedQueries_ListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueries_ListView.MultiSelect = false;
            this.TrackedQueries_ListView.Name = "TrackedQueries_ListView";
            this.TrackedQueries_ListView.Size = new System.Drawing.Size(361, 170);
            this.TrackedQueries_ListView.TabIndex = 1;
            this.TrackedQueries_ListView.UseCompatibleStateImageBehavior = false;
            this.TrackedQueries_ListView.View = System.Windows.Forms.View.Details;
            this.TrackedQueries_ListView.SelectedIndexChanged += new System.EventHandler(this.TrackedQueries_ListView_SelectedIndexChanged);
            // 
            // TrackedQueryNames
            // 
            this.TrackedQueryNames.Text = "Tracked queries";
            this.TrackedQueryNames.Width = 120;
            // 
            // TimePeriod
            // 
            this.TimePeriod.Text = "Time period";
            this.TimePeriod.Width = 89;
            // 
            // SnapshotsCount
            // 
            this.SnapshotsCount.Text = "Snapshots count";
            this.SnapshotsCount.Width = 92;
            // 
            // Below_Button
            // 
            this.Below_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Below_Button.ForeColor = System.Drawing.Color.Black;
            this.Below_Button.Location = new System.Drawing.Point(99, 139);
            this.Below_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Below_Button.Name = "Below_Button";
            this.Below_Button.Size = new System.Drawing.Size(83, 27);
            this.Below_Button.TabIndex = 15;
            this.Below_Button.Text = "Put below";
            this.Below_Button.UseVisualStyleBackColor = true;
            this.Below_Button.Click += new System.EventHandler(this.Below_Button_Click);
            // 
            // Above_Button
            // 
            this.Above_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Above_Button.ForeColor = System.Drawing.Color.Black;
            this.Above_Button.Location = new System.Drawing.Point(4, 139);
            this.Above_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Above_Button.Name = "Above_Button";
            this.Above_Button.Size = new System.Drawing.Size(89, 27);
            this.Above_Button.TabIndex = 14;
            this.Above_Button.Text = "Put above";
            this.Above_Button.UseVisualStyleBackColor = true;
            this.Above_Button.Click += new System.EventHandler(this.Above_Button_Click);
            // 
            // TrackedQueriesSnapshots_ListView
            // 
            this.TrackedQueriesSnapshots_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackedQueriesSnapshots_ListView.BackColor = System.Drawing.Color.White;
            this.TrackedQueriesSnapshots_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Snapshots});
            this.TrackedQueriesSnapshots_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrackedQueriesSnapshots_ListView.Location = new System.Drawing.Point(0, 0);
            this.TrackedQueriesSnapshots_ListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueriesSnapshots_ListView.MultiSelect = false;
            this.TrackedQueriesSnapshots_ListView.Name = "TrackedQueriesSnapshots_ListView";
            this.TrackedQueriesSnapshots_ListView.Size = new System.Drawing.Size(359, 132);
            this.TrackedQueriesSnapshots_ListView.TabIndex = 2;
            this.TrackedQueriesSnapshots_ListView.UseCompatibleStateImageBehavior = false;
            this.TrackedQueriesSnapshots_ListView.View = System.Windows.Forms.View.Details;
            this.TrackedQueriesSnapshots_ListView.SelectedIndexChanged += new System.EventHandler(this.TrackedQueriesSnapshots_ListView_SelectedIndexChanged);
            // 
            // Snapshots
            // 
            this.Snapshots.Text = "Snapshots";
            this.Snapshots.Width = 120;
            // 
            // TrackedQueriesSection_SplitContainer
            // 
            this.TrackedQueriesSection_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrackedQueriesSection_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackedQueriesSection_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.TrackedQueriesSection_SplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueriesSection_SplitContainer.Name = "TrackedQueriesSection_SplitContainer";
            // 
            // TrackedQueriesSection_SplitContainer.Panel1
            // 
            this.TrackedQueriesSection_SplitContainer.Panel1.Controls.Add(this.TrackedQueriesResult_SplitContainer);
            // 
            // TrackedQueriesSection_SplitContainer.Panel2
            // 
            this.TrackedQueriesSection_SplitContainer.Panel2.Controls.Add(this.QuerySummary_Label);
            this.TrackedQueriesSection_SplitContainer.Panel2.Controls.Add(this.TrackedQueriesDifference_DataGridView);
            this.TrackedQueriesSection_SplitContainer.Size = new System.Drawing.Size(713, 428);
            this.TrackedQueriesSection_SplitContainer.SplitterDistance = 343;
            this.TrackedQueriesSection_SplitContainer.SplitterWidth = 10;
            this.TrackedQueriesSection_SplitContainer.TabIndex = 1;
            // 
            // TrackedQueriesResult_SplitContainer
            // 
            this.TrackedQueriesResult_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrackedQueriesResult_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackedQueriesResult_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.TrackedQueriesResult_SplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackedQueriesResult_SplitContainer.Name = "TrackedQueriesResult_SplitContainer";
            this.TrackedQueriesResult_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TrackedQueriesResult_SplitContainer.Panel1
            // 
            this.TrackedQueriesResult_SplitContainer.Panel1.Controls.Add(this.FirstQueryUpdateTime_Label);
            this.TrackedQueriesResult_SplitContainer.Panel1.Controls.Add(this.FirstQuerySnapshot_DataGridView);
            // 
            // TrackedQueriesResult_SplitContainer.Panel2
            // 
            this.TrackedQueriesResult_SplitContainer.Panel2.Controls.Add(this.SecondQueryUpdateTime_Label);
            this.TrackedQueriesResult_SplitContainer.Panel2.Controls.Add(this.SecondQuerySnapshot_DataGridView);
            this.TrackedQueriesResult_SplitContainer.Size = new System.Drawing.Size(343, 428);
            this.TrackedQueriesResult_SplitContainer.SplitterDistance = 234;
            this.TrackedQueriesResult_SplitContainer.SplitterWidth = 10;
            this.TrackedQueriesResult_SplitContainer.TabIndex = 2;
            // 
            // FirstQueryUpdateTime_Label
            // 
            this.FirstQueryUpdateTime_Label.AutoSize = true;
            this.FirstQueryUpdateTime_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstQueryUpdateTime_Label.ForeColor = System.Drawing.Color.Black;
            this.FirstQueryUpdateTime_Label.Location = new System.Drawing.Point(4, 5);
            this.FirstQueryUpdateTime_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstQueryUpdateTime_Label.Name = "FirstQueryUpdateTime_Label";
            this.FirstQueryUpdateTime_Label.Size = new System.Drawing.Size(77, 20);
            this.FirstQueryUpdateTime_Label.TabIndex = 12;
            this.FirstQueryUpdateTime_Label.Text = "Updated: ";
            // 
            // FirstQuerySnapshot_DataGridView
            // 
            this.FirstQuerySnapshot_DataGridView.AllowUserToAddRows = false;
            this.FirstQuerySnapshot_DataGridView.AllowUserToDeleteRows = false;
            this.FirstQuerySnapshot_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstQuerySnapshot_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FirstQuerySnapshot_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstQuerySnapshot_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.FirstQuerySnapshot_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FirstQuerySnapshot_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstQuerySnapshot_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FirstQuerySnapshot_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstQuerySnapshot_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FirstQuerySnapshot_DataGridView.EnableHeadersVisualStyles = false;
            this.FirstQuerySnapshot_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.FirstQuerySnapshot_DataGridView.Location = new System.Drawing.Point(0, 29);
            this.FirstQuerySnapshot_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.FirstQuerySnapshot_DataGridView.Name = "FirstQuerySnapshot_DataGridView";
            this.FirstQuerySnapshot_DataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstQuerySnapshot_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FirstQuerySnapshot_DataGridView.RowHeadersVisible = false;
            this.FirstQuerySnapshot_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.FirstQuerySnapshot_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FirstQuerySnapshot_DataGridView.Size = new System.Drawing.Size(341, 201);
            this.FirstQuerySnapshot_DataGridView.TabIndex = 11;
            // 
            // SecondQueryUpdateTime_Label
            // 
            this.SecondQueryUpdateTime_Label.AutoSize = true;
            this.SecondQueryUpdateTime_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondQueryUpdateTime_Label.ForeColor = System.Drawing.Color.Black;
            this.SecondQueryUpdateTime_Label.Location = new System.Drawing.Point(4, 5);
            this.SecondQueryUpdateTime_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondQueryUpdateTime_Label.Name = "SecondQueryUpdateTime_Label";
            this.SecondQueryUpdateTime_Label.Size = new System.Drawing.Size(77, 20);
            this.SecondQueryUpdateTime_Label.TabIndex = 13;
            this.SecondQueryUpdateTime_Label.Text = "Updated: ";
            // 
            // SecondQuerySnapshot_DataGridView
            // 
            this.SecondQuerySnapshot_DataGridView.AllowUserToAddRows = false;
            this.SecondQuerySnapshot_DataGridView.AllowUserToDeleteRows = false;
            this.SecondQuerySnapshot_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecondQuerySnapshot_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SecondQuerySnapshot_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondQuerySnapshot_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.SecondQuerySnapshot_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SecondQuerySnapshot_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecondQuerySnapshot_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SecondQuerySnapshot_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecondQuerySnapshot_DataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.SecondQuerySnapshot_DataGridView.EnableHeadersVisualStyles = false;
            this.SecondQuerySnapshot_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.SecondQuerySnapshot_DataGridView.Location = new System.Drawing.Point(0, 28);
            this.SecondQuerySnapshot_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.SecondQuerySnapshot_DataGridView.Name = "SecondQuerySnapshot_DataGridView";
            this.SecondQuerySnapshot_DataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecondQuerySnapshot_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SecondQuerySnapshot_DataGridView.RowHeadersVisible = false;
            this.SecondQuerySnapshot_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SecondQuerySnapshot_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SecondQuerySnapshot_DataGridView.Size = new System.Drawing.Size(341, 137);
            this.SecondQuerySnapshot_DataGridView.TabIndex = 12;
            // 
            // QuerySummary_Label
            // 
            this.QuerySummary_Label.AutoSize = true;
            this.QuerySummary_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuerySummary_Label.ForeColor = System.Drawing.Color.Black;
            this.QuerySummary_Label.Location = new System.Drawing.Point(4, 5);
            this.QuerySummary_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuerySummary_Label.Name = "QuerySummary_Label";
            this.QuerySummary_Label.Size = new System.Drawing.Size(81, 20);
            this.QuerySummary_Label.TabIndex = 13;
            this.QuerySummary_Label.Text = "Summary:";
            // 
            // TrackedQueriesDifference_DataGridView
            // 
            this.TrackedQueriesDifference_DataGridView.AllowUserToAddRows = false;
            this.TrackedQueriesDifference_DataGridView.AllowUserToDeleteRows = false;
            this.TrackedQueriesDifference_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrackedQueriesDifference_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.TrackedQueriesDifference_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackedQueriesDifference_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TrackedQueriesDifference_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TrackedQueriesDifference_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackedQueriesDifference_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.TrackedQueriesDifference_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrackedQueriesDifference_DataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.TrackedQueriesDifference_DataGridView.EnableHeadersVisualStyles = false;
            this.TrackedQueriesDifference_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.TrackedQueriesDifference_DataGridView.Location = new System.Drawing.Point(2, 29);
            this.TrackedQueriesDifference_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.TrackedQueriesDifference_DataGridView.Name = "TrackedQueriesDifference_DataGridView";
            this.TrackedQueriesDifference_DataGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackedQueriesDifference_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TrackedQueriesDifference_DataGridView.RowHeadersVisible = false;
            this.TrackedQueriesDifference_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.TrackedQueriesDifference_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrackedQueriesDifference_DataGridView.Size = new System.Drawing.Size(356, 397);
            this.TrackedQueriesDifference_DataGridView.TabIndex = 12;
            // 
            // TrackedQueriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackedQueriesContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TrackedQueriesView";
            this.Size = new System.Drawing.Size(1084, 428);
            this.trackedQueriesContainer.Panel1.ResumeLayout(false);
            this.trackedQueriesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesContainer)).EndInit();
            this.trackedQueriesContainer.ResumeLayout(false);
            this.TrackedQueriesList_SplitContainer.Panel1.ResumeLayout(false);
            this.TrackedQueriesList_SplitContainer.Panel1.PerformLayout();
            this.TrackedQueriesList_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesList_SplitContainer)).EndInit();
            this.TrackedQueriesList_SplitContainer.ResumeLayout(false);
            this.TrackedQueriesSection_SplitContainer.Panel1.ResumeLayout(false);
            this.TrackedQueriesSection_SplitContainer.Panel2.ResumeLayout(false);
            this.TrackedQueriesSection_SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesSection_SplitContainer)).EndInit();
            this.TrackedQueriesSection_SplitContainer.ResumeLayout(false);
            this.TrackedQueriesResult_SplitContainer.Panel1.ResumeLayout(false);
            this.TrackedQueriesResult_SplitContainer.Panel1.PerformLayout();
            this.TrackedQueriesResult_SplitContainer.Panel2.ResumeLayout(false);
            this.TrackedQueriesResult_SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesResult_SplitContainer)).EndInit();
            this.TrackedQueriesResult_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstQuerySnapshot_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondQuerySnapshot_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedQueriesDifference_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer trackedQueriesContainer;
        private System.Windows.Forms.ListView TrackedQueries_ListView;
        private System.Windows.Forms.ColumnHeader TrackedQueryNames;
        private System.Windows.Forms.SplitContainer TrackedQueriesSection_SplitContainer;
        private System.Windows.Forms.SplitContainer TrackedQueriesList_SplitContainer;
        private System.Windows.Forms.ListView TrackedQueriesSnapshots_ListView;
        private System.Windows.Forms.ColumnHeader Snapshots;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Below_Button;
        private System.Windows.Forms.Button Above_Button;
        private System.Windows.Forms.Label TimePeriod_Label;
        private System.Windows.Forms.SplitContainer TrackedQueriesResult_SplitContainer;
        private System.Windows.Forms.Label FirstQueryUpdateTime_Label;
        private System.Windows.Forms.DataGridView FirstQuerySnapshot_DataGridView;
        private System.Windows.Forms.Label SecondQueryUpdateTime_Label;
        private System.Windows.Forms.DataGridView SecondQuerySnapshot_DataGridView;
        private System.Windows.Forms.DataGridView TrackedQueriesDifference_DataGridView;
        private System.Windows.Forms.Label QuerySummary_Label;
        private System.Windows.Forms.ColumnHeader TimePeriod;
        private System.Windows.Forms.ColumnHeader SnapshotsCount;
    }
}
