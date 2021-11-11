
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trackedQueriesContainer = new System.Windows.Forms.SplitContainer();
            this.TrackedQueriesList_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TimePeriod_Label = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.TrackedQueries_ListView = new System.Windows.Forms.ListView();
            this.TrackedQueryNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Below_Button = new System.Windows.Forms.Button();
            this.Above_Button = new System.Windows.Forms.Button();
            this.TrackedQueriesSnapshots_ListView = new System.Windows.Forms.ListView();
            this.Snapshots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackedQueriesSection_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TrackedQueriesResult_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.FirstQueryUpdateTime_Label = new System.Windows.Forms.Label();
            this.FirstQuerySnapshot_DataGridView = new System.Windows.Forms.DataGridView();
            this.SecondQueryUpdateTime_Label = new System.Windows.Forms.Label();
            this.SecondQuerySnapshot_DataGridView = new System.Windows.Forms.DataGridView();
            this.TrackedQueriesDifference_DataGridView = new System.Windows.Forms.DataGridView();
            this.QuerySummary_Label = new System.Windows.Forms.Label();
            this.TimePeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.trackedQueriesContainer.Name = "trackedQueriesContainer";
            // 
            // trackedQueriesContainer.Panel1
            // 
            this.trackedQueriesContainer.Panel1.Controls.Add(this.TrackedQueriesList_SplitContainer);
            // 
            // trackedQueriesContainer.Panel2
            // 
            this.trackedQueriesContainer.Panel2.Controls.Add(this.TrackedQueriesSection_SplitContainer);
            this.trackedQueriesContainer.Size = new System.Drawing.Size(929, 371);
            this.trackedQueriesContainer.SplitterDistance = 310;
            this.trackedQueriesContainer.SplitterWidth = 9;
            this.trackedQueriesContainer.TabIndex = 1;
            // 
            // TrackedQueriesList_SplitContainer
            // 
            this.TrackedQueriesList_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrackedQueriesList_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackedQueriesList_SplitContainer.Location = new System.Drawing.Point(0, 0);
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
            this.TrackedQueriesList_SplitContainer.Size = new System.Drawing.Size(310, 371);
            this.TrackedQueriesList_SplitContainer.SplitterDistance = 202;
            this.TrackedQueriesList_SplitContainer.SplitterWidth = 9;
            this.TrackedQueriesList_SplitContainer.TabIndex = 2;
            // 
            // TimePeriod_Label
            // 
            this.TimePeriod_Label.AutoSize = true;
            this.TimePeriod_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimePeriod_Label.ForeColor = System.Drawing.Color.Black;
            this.TimePeriod_Label.Location = new System.Drawing.Point(3, 28);
            this.TimePeriod_Label.Name = "TimePeriod_Label";
            this.TimePeriod_Label.Size = new System.Drawing.Size(176, 20);
            this.TimePeriod_Label.TabIndex = 13;
            this.TimePeriod_Label.Text = "Update every x minutes";
            // 
            // Delete_Button
            // 
            this.Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Delete_Button.Location = new System.Drawing.Point(85, 4);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.ForeColor = System.Drawing.Color.Black;
            this.Refresh_Button.Location = new System.Drawing.Point(4, 4);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 23);
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
            this.TimePeriod});
            this.TrackedQueries_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrackedQueries_ListView.HideSelection = false;
            this.TrackedQueries_ListView.Location = new System.Drawing.Point(0, 51);
            this.TrackedQueries_ListView.MultiSelect = false;
            this.TrackedQueries_ListView.Name = "TrackedQueries_ListView";
            this.TrackedQueries_ListView.Size = new System.Drawing.Size(306, 147);
            this.TrackedQueries_ListView.TabIndex = 1;
            this.TrackedQueries_ListView.UseCompatibleStateImageBehavior = false;
            this.TrackedQueries_ListView.View = System.Windows.Forms.View.Details;
            this.TrackedQueries_ListView.SelectedIndexChanged += new System.EventHandler(this.TrackedQueries_ListView_SelectedIndexChanged);
            // 
            // TrackedQueryNames
            // 
            this.TrackedQueryNames.Text = "Tracked Queries";
            this.TrackedQueryNames.Width = 120;
            // 
            // Below_Button
            // 
            this.Below_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Below_Button.ForeColor = System.Drawing.Color.Black;
            this.Below_Button.Location = new System.Drawing.Point(85, 130);
            this.Below_Button.Name = "Below_Button";
            this.Below_Button.Size = new System.Drawing.Size(71, 23);
            this.Below_Button.TabIndex = 15;
            this.Below_Button.Text = "Put below";
            this.Below_Button.UseVisualStyleBackColor = true;
            this.Below_Button.Click += new System.EventHandler(this.Below_Button_Click);
            // 
            // Above_Button
            // 
            this.Above_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Above_Button.ForeColor = System.Drawing.Color.Black;
            this.Above_Button.Location = new System.Drawing.Point(3, 130);
            this.Above_Button.Name = "Above_Button";
            this.Above_Button.Size = new System.Drawing.Size(76, 23);
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
            this.TrackedQueriesSnapshots_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrackedQueriesSnapshots_ListView.HideSelection = false;
            this.TrackedQueriesSnapshots_ListView.Location = new System.Drawing.Point(0, 0);
            this.TrackedQueriesSnapshots_ListView.MultiSelect = false;
            this.TrackedQueriesSnapshots_ListView.Name = "TrackedQueriesSnapshots_ListView";
            this.TrackedQueriesSnapshots_ListView.Size = new System.Drawing.Size(306, 124);
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
            this.TrackedQueriesSection_SplitContainer.Size = new System.Drawing.Size(610, 371);
            this.TrackedQueriesSection_SplitContainer.SplitterDistance = 294;
            this.TrackedQueriesSection_SplitContainer.SplitterWidth = 9;
            this.TrackedQueriesSection_SplitContainer.TabIndex = 1;
            // 
            // TrackedQueriesResult_SplitContainer
            // 
            this.TrackedQueriesResult_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrackedQueriesResult_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackedQueriesResult_SplitContainer.Location = new System.Drawing.Point(0, 0);
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
            this.TrackedQueriesResult_SplitContainer.Size = new System.Drawing.Size(294, 371);
            this.TrackedQueriesResult_SplitContainer.SplitterDistance = 203;
            this.TrackedQueriesResult_SplitContainer.SplitterWidth = 9;
            this.TrackedQueriesResult_SplitContainer.TabIndex = 2;
            // 
            // FirstQueryUpdateTime_Label
            // 
            this.FirstQueryUpdateTime_Label.AutoSize = true;
            this.FirstQueryUpdateTime_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstQueryUpdateTime_Label.ForeColor = System.Drawing.Color.Black;
            this.FirstQueryUpdateTime_Label.Location = new System.Drawing.Point(3, 4);
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
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstQuerySnapshot_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.FirstQuerySnapshot_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstQuerySnapshot_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.FirstQuerySnapshot_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FirstQuerySnapshot_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstQuerySnapshot_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.FirstQuerySnapshot_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstQuerySnapshot_DataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.FirstQuerySnapshot_DataGridView.EnableHeadersVisualStyles = false;
            this.FirstQuerySnapshot_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.FirstQuerySnapshot_DataGridView.Location = new System.Drawing.Point(0, 25);
            this.FirstQuerySnapshot_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.FirstQuerySnapshot_DataGridView.Name = "FirstQuerySnapshot_DataGridView";
            this.FirstQuerySnapshot_DataGridView.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstQuerySnapshot_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.FirstQuerySnapshot_DataGridView.RowHeadersVisible = false;
            this.FirstQuerySnapshot_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.FirstQuerySnapshot_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FirstQuerySnapshot_DataGridView.Size = new System.Drawing.Size(290, 174);
            this.FirstQuerySnapshot_DataGridView.TabIndex = 11;
            // 
            // SecondQueryUpdateTime_Label
            // 
            this.SecondQueryUpdateTime_Label.AutoSize = true;
            this.SecondQueryUpdateTime_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecondQueryUpdateTime_Label.ForeColor = System.Drawing.Color.Black;
            this.SecondQueryUpdateTime_Label.Location = new System.Drawing.Point(3, 4);
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
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecondQuerySnapshot_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.SecondQuerySnapshot_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondQuerySnapshot_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.SecondQuerySnapshot_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SecondQuerySnapshot_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecondQuerySnapshot_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.SecondQuerySnapshot_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecondQuerySnapshot_DataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.SecondQuerySnapshot_DataGridView.EnableHeadersVisualStyles = false;
            this.SecondQuerySnapshot_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.SecondQuerySnapshot_DataGridView.Location = new System.Drawing.Point(0, 24);
            this.SecondQuerySnapshot_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.SecondQuerySnapshot_DataGridView.Name = "SecondQuerySnapshot_DataGridView";
            this.SecondQuerySnapshot_DataGridView.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecondQuerySnapshot_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.SecondQuerySnapshot_DataGridView.RowHeadersVisible = false;
            this.SecondQuerySnapshot_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.SecondQuerySnapshot_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SecondQuerySnapshot_DataGridView.Size = new System.Drawing.Size(290, 128);
            this.SecondQuerySnapshot_DataGridView.TabIndex = 12;
            // 
            // TrackedQueriesDifference_DataGridView
            // 
            this.TrackedQueriesDifference_DataGridView.AllowUserToAddRows = false;
            this.TrackedQueriesDifference_DataGridView.AllowUserToDeleteRows = false;
            this.TrackedQueriesDifference_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrackedQueriesDifference_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.TrackedQueriesDifference_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackedQueriesDifference_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TrackedQueriesDifference_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TrackedQueriesDifference_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackedQueriesDifference_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.TrackedQueriesDifference_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrackedQueriesDifference_DataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.TrackedQueriesDifference_DataGridView.EnableHeadersVisualStyles = false;
            this.TrackedQueriesDifference_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.TrackedQueriesDifference_DataGridView.Location = new System.Drawing.Point(2, 25);
            this.TrackedQueriesDifference_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.TrackedQueriesDifference_DataGridView.Name = "TrackedQueriesDifference_DataGridView";
            this.TrackedQueriesDifference_DataGridView.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackedQueriesDifference_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.TrackedQueriesDifference_DataGridView.RowHeadersVisible = false;
            this.TrackedQueriesDifference_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.TrackedQueriesDifference_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrackedQueriesDifference_DataGridView.Size = new System.Drawing.Size(303, 344);
            this.TrackedQueriesDifference_DataGridView.TabIndex = 12;
            // 
            // QuerySummary_Label
            // 
            this.QuerySummary_Label.AutoSize = true;
            this.QuerySummary_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuerySummary_Label.ForeColor = System.Drawing.Color.Black;
            this.QuerySummary_Label.Location = new System.Drawing.Point(3, 4);
            this.QuerySummary_Label.Name = "QuerySummary_Label";
            this.QuerySummary_Label.Size = new System.Drawing.Size(81, 20);
            this.QuerySummary_Label.TabIndex = 13;
            this.QuerySummary_Label.Text = "Summary:";
            // 
            // TimePeriod
            // 
            this.TimePeriod.Text = "TimePeriod";
            this.TimePeriod.Width = 120;
            // 
            // TrackedQueriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackedQueriesContainer);
            this.Name = "TrackedQueriesView";
            this.Size = new System.Drawing.Size(929, 371);
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
    }
}
