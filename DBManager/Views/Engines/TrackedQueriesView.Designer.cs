
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
            this.trackedQueriesContainer = new System.Windows.Forms.SplitContainer();
            this.trackedQueries_removeButton = new System.Windows.Forms.Button();
            this.trackedQueries_addButton = new System.Windows.Forms.Button();
            this.trackedQueries_refreshButton = new System.Windows.Forms.Button();
            this.trackedQueries_queryPreview = new System.Windows.Forms.RichTextBox();
            this.trackedQueries_timePeriodLabel = new System.Windows.Forms.Label();
            this.trackedQueries_trackedQueriesList = new System.Windows.Forms.ListView();
            this.trackedQueryNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackedQueriesResultsContainer = new System.Windows.Forms.SplitContainer();
            this.trackedQueries_actualQueryInfoLabel = new System.Windows.Forms.Label();
            this.trackedQueries_actualQuery = new System.Windows.Forms.DataGridView();
            this.trackedQueries_previousQueryInfoLabel = new System.Windows.Forms.Label();
            this.trackedQueries_previousQuery = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesContainer)).BeginInit();
            this.trackedQueriesContainer.Panel1.SuspendLayout();
            this.trackedQueriesContainer.Panel2.SuspendLayout();
            this.trackedQueriesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesResultsContainer)).BeginInit();
            this.trackedQueriesResultsContainer.Panel1.SuspendLayout();
            this.trackedQueriesResultsContainer.Panel2.SuspendLayout();
            this.trackedQueriesResultsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueries_actualQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueries_previousQuery)).BeginInit();
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
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_removeButton);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_addButton);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_refreshButton);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_queryPreview);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_timePeriodLabel);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_trackedQueriesList);
            // 
            // trackedQueriesContainer.Panel2
            // 
            this.trackedQueriesContainer.Panel2.Controls.Add(this.trackedQueriesResultsContainer);
            this.trackedQueriesContainer.Size = new System.Drawing.Size(929, 371);
            this.trackedQueriesContainer.SplitterDistance = 310;
            this.trackedQueriesContainer.SplitterWidth = 9;
            this.trackedQueriesContainer.TabIndex = 1;
            // 
            // trackedQueries_removeButton
            // 
            this.trackedQueries_removeButton.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_removeButton.Location = new System.Drawing.Point(168, 108);
            this.trackedQueries_removeButton.Name = "trackedQueries_removeButton";
            this.trackedQueries_removeButton.Size = new System.Drawing.Size(75, 23);
            this.trackedQueries_removeButton.TabIndex = 17;
            this.trackedQueries_removeButton.Text = "Remove";
            this.trackedQueries_removeButton.UseVisualStyleBackColor = true;
            this.trackedQueries_removeButton.Click += new System.EventHandler(this.trackedQueries_removeButton_Click);
            // 
            // trackedQueries_addButton
            // 
            this.trackedQueries_addButton.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_addButton.Location = new System.Drawing.Point(87, 108);
            this.trackedQueries_addButton.Name = "trackedQueries_addButton";
            this.trackedQueries_addButton.Size = new System.Drawing.Size(75, 23);
            this.trackedQueries_addButton.TabIndex = 16;
            this.trackedQueries_addButton.Text = "Add";
            this.trackedQueries_addButton.UseVisualStyleBackColor = true;
            this.trackedQueries_addButton.Click += new System.EventHandler(this.trackedQueries_addButton_Click);
            // 
            // trackedQueries_refreshButton
            // 
            this.trackedQueries_refreshButton.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_refreshButton.Location = new System.Drawing.Point(6, 108);
            this.trackedQueries_refreshButton.Name = "trackedQueries_refreshButton";
            this.trackedQueries_refreshButton.Size = new System.Drawing.Size(75, 23);
            this.trackedQueries_refreshButton.TabIndex = 15;
            this.trackedQueries_refreshButton.Text = "Refresh";
            this.trackedQueries_refreshButton.UseVisualStyleBackColor = true;
            this.trackedQueries_refreshButton.Click += new System.EventHandler(this.trackedQueries_refreshButton_Click);
            // 
            // trackedQueries_queryPreview
            // 
            this.trackedQueries_queryPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackedQueries_queryPreview.Location = new System.Drawing.Point(6, 21);
            this.trackedQueries_queryPreview.Name = "trackedQueries_queryPreview";
            this.trackedQueries_queryPreview.ReadOnly = true;
            this.trackedQueries_queryPreview.Size = new System.Drawing.Size(297, 81);
            this.trackedQueries_queryPreview.TabIndex = 14;
            this.trackedQueries_queryPreview.Text = "";
            // 
            // trackedQueries_timePeriodLabel
            // 
            this.trackedQueries_timePeriodLabel.AutoSize = true;
            this.trackedQueries_timePeriodLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trackedQueries_timePeriodLabel.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_timePeriodLabel.Location = new System.Drawing.Point(3, 0);
            this.trackedQueries_timePeriodLabel.Name = "trackedQueries_timePeriodLabel";
            this.trackedQueries_timePeriodLabel.Size = new System.Drawing.Size(0, 17);
            this.trackedQueries_timePeriodLabel.TabIndex = 13;
            // 
            // trackedQueries_trackedQueriesList
            // 
            this.trackedQueries_trackedQueriesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackedQueries_trackedQueriesList.BackColor = System.Drawing.Color.White;
            this.trackedQueries_trackedQueriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackedQueryNames});
            this.trackedQueries_trackedQueriesList.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trackedQueries_trackedQueriesList.HideSelection = false;
            this.trackedQueries_trackedQueriesList.Location = new System.Drawing.Point(0, 137);
            this.trackedQueries_trackedQueriesList.MultiSelect = false;
            this.trackedQueries_trackedQueriesList.Name = "trackedQueries_trackedQueriesList";
            this.trackedQueries_trackedQueriesList.Size = new System.Drawing.Size(306, 230);
            this.trackedQueries_trackedQueriesList.TabIndex = 1;
            this.trackedQueries_trackedQueriesList.UseCompatibleStateImageBehavior = false;
            this.trackedQueries_trackedQueriesList.View = System.Windows.Forms.View.Details;
            this.trackedQueries_trackedQueriesList.SelectedIndexChanged += new System.EventHandler(this.trackedQueries_trackedQueriesList_SelectedIndexChanged);
            // 
            // trackedQueryNames
            // 
            this.trackedQueryNames.Text = "Tracked Queries";
            this.trackedQueryNames.Width = 120;
            // 
            // trackedQueriesResultsContainer
            // 
            this.trackedQueriesResultsContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trackedQueriesResultsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackedQueriesResultsContainer.Location = new System.Drawing.Point(0, 0);
            this.trackedQueriesResultsContainer.Name = "trackedQueriesResultsContainer";
            this.trackedQueriesResultsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // trackedQueriesResultsContainer.Panel1
            // 
            this.trackedQueriesResultsContainer.Panel1.Controls.Add(this.trackedQueries_actualQueryInfoLabel);
            this.trackedQueriesResultsContainer.Panel1.Controls.Add(this.trackedQueries_actualQuery);
            // 
            // trackedQueriesResultsContainer.Panel2
            // 
            this.trackedQueriesResultsContainer.Panel2.Controls.Add(this.trackedQueries_previousQueryInfoLabel);
            this.trackedQueriesResultsContainer.Panel2.Controls.Add(this.trackedQueries_previousQuery);
            this.trackedQueriesResultsContainer.Size = new System.Drawing.Size(610, 371);
            this.trackedQueriesResultsContainer.SplitterDistance = 203;
            this.trackedQueriesResultsContainer.SplitterWidth = 9;
            this.trackedQueriesResultsContainer.TabIndex = 1;
            // 
            // trackedQueries_actualQueryInfoLabel
            // 
            this.trackedQueries_actualQueryInfoLabel.AutoSize = true;
            this.trackedQueries_actualQueryInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trackedQueries_actualQueryInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_actualQueryInfoLabel.Location = new System.Drawing.Point(1, 0);
            this.trackedQueries_actualQueryInfoLabel.Name = "trackedQueries_actualQueryInfoLabel";
            this.trackedQueries_actualQueryInfoLabel.Size = new System.Drawing.Size(85, 17);
            this.trackedQueries_actualQueryInfoLabel.TabIndex = 12;
            this.trackedQueries_actualQueryInfoLabel.Text = "ActualQuery";
            // 
            // trackedQueries_actualQuery
            // 
            this.trackedQueries_actualQuery.AllowUserToAddRows = false;
            this.trackedQueries_actualQuery.AllowUserToDeleteRows = false;
            this.trackedQueries_actualQuery.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trackedQueries_actualQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.trackedQueries_actualQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackedQueries_actualQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.trackedQueries_actualQuery.BackgroundColor = System.Drawing.Color.White;
            this.trackedQueries_actualQuery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trackedQueries_actualQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.trackedQueries_actualQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trackedQueries_actualQuery.DefaultCellStyle = dataGridViewCellStyle3;
            this.trackedQueries_actualQuery.EnableHeadersVisualStyles = false;
            this.trackedQueries_actualQuery.GridColor = System.Drawing.Color.Silver;
            this.trackedQueries_actualQuery.Location = new System.Drawing.Point(0, 17);
            this.trackedQueries_actualQuery.Margin = new System.Windows.Forms.Padding(0);
            this.trackedQueries_actualQuery.Name = "trackedQueries_actualQuery";
            this.trackedQueries_actualQuery.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trackedQueries_actualQuery.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.trackedQueries_actualQuery.RowHeadersVisible = false;
            this.trackedQueries_actualQuery.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_actualQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trackedQueries_actualQuery.Size = new System.Drawing.Size(606, 182);
            this.trackedQueries_actualQuery.TabIndex = 11;
            // 
            // trackedQueries_previousQueryInfoLabel
            // 
            this.trackedQueries_previousQueryInfoLabel.AutoSize = true;
            this.trackedQueries_previousQueryInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trackedQueries_previousQueryInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_previousQueryInfoLabel.Location = new System.Drawing.Point(1, 0);
            this.trackedQueries_previousQueryInfoLabel.Name = "trackedQueries_previousQueryInfoLabel";
            this.trackedQueries_previousQueryInfoLabel.Size = new System.Drawing.Size(103, 17);
            this.trackedQueries_previousQueryInfoLabel.TabIndex = 13;
            this.trackedQueries_previousQueryInfoLabel.Text = "Previous Query";
            // 
            // trackedQueries_previousQuery
            // 
            this.trackedQueries_previousQuery.AllowUserToAddRows = false;
            this.trackedQueries_previousQuery.AllowUserToDeleteRows = false;
            this.trackedQueries_previousQuery.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trackedQueries_previousQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.trackedQueries_previousQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackedQueries_previousQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.trackedQueries_previousQuery.BackgroundColor = System.Drawing.Color.White;
            this.trackedQueries_previousQuery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trackedQueries_previousQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.trackedQueries_previousQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trackedQueries_previousQuery.DefaultCellStyle = dataGridViewCellStyle7;
            this.trackedQueries_previousQuery.EnableHeadersVisualStyles = false;
            this.trackedQueries_previousQuery.GridColor = System.Drawing.Color.Silver;
            this.trackedQueries_previousQuery.Location = new System.Drawing.Point(0, 18);
            this.trackedQueries_previousQuery.Margin = new System.Windows.Forms.Padding(0);
            this.trackedQueries_previousQuery.Name = "trackedQueries_previousQuery";
            this.trackedQueries_previousQuery.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trackedQueries_previousQuery.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.trackedQueries_previousQuery.RowHeadersVisible = false;
            this.trackedQueries_previousQuery.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.trackedQueries_previousQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trackedQueries_previousQuery.Size = new System.Drawing.Size(606, 117);
            this.trackedQueries_previousQuery.TabIndex = 11;
            // 
            // TrackedQueriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackedQueriesContainer);
            this.Name = "TrackedQueriesView";
            this.Size = new System.Drawing.Size(929, 371);
            this.trackedQueriesContainer.Panel1.ResumeLayout(false);
            this.trackedQueriesContainer.Panel1.PerformLayout();
            this.trackedQueriesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesContainer)).EndInit();
            this.trackedQueriesContainer.ResumeLayout(false);
            this.trackedQueriesResultsContainer.Panel1.ResumeLayout(false);
            this.trackedQueriesResultsContainer.Panel1.PerformLayout();
            this.trackedQueriesResultsContainer.Panel2.ResumeLayout(false);
            this.trackedQueriesResultsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesResultsContainer)).EndInit();
            this.trackedQueriesResultsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueries_actualQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueries_previousQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer trackedQueriesContainer;
        private System.Windows.Forms.ListView trackedQueries_trackedQueriesList;
        private System.Windows.Forms.ColumnHeader trackedQueryNames;
        private System.Windows.Forms.SplitContainer trackedQueriesResultsContainer;
        private System.Windows.Forms.DataGridView trackedQueries_actualQuery;
        private System.Windows.Forms.DataGridView trackedQueries_previousQuery;
        private System.Windows.Forms.Label trackedQueries_actualQueryInfoLabel;
        private System.Windows.Forms.Label trackedQueries_previousQueryInfoLabel;
        private System.Windows.Forms.Label trackedQueries_timePeriodLabel;
        private System.Windows.Forms.RichTextBox trackedQueries_queryPreview;
        private System.Windows.Forms.Button trackedQueries_removeButton;
        private System.Windows.Forms.Button trackedQueries_addButton;
        private System.Windows.Forms.Button trackedQueries_refreshButton;
    }
}
