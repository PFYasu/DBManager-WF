
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trackedQueriesContainer = new System.Windows.Forms.SplitContainer();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.TrackedQuery_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.trackedQueries_timePeriodLabel = new System.Windows.Forms.Label();
            this.TrackedQueries_ListView = new System.Windows.Forms.ListView();
            this.trackedQueryNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackedQueriesResultsContainer = new System.Windows.Forms.SplitContainer();
            this.ActualQuery_Label = new System.Windows.Forms.Label();
            this.ActualQuery_DataGridView = new System.Windows.Forms.DataGridView();
            this.PreviousQuery_Label = new System.Windows.Forms.Label();
            this.PreviousQuery_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesContainer)).BeginInit();
            this.trackedQueriesContainer.Panel1.SuspendLayout();
            this.trackedQueriesContainer.Panel2.SuspendLayout();
            this.trackedQueriesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedQueriesResultsContainer)).BeginInit();
            this.trackedQueriesResultsContainer.Panel1.SuspendLayout();
            this.trackedQueriesResultsContainer.Panel2.SuspendLayout();
            this.trackedQueriesResultsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualQuery_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousQuery_DataGridView)).BeginInit();
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
            this.trackedQueriesContainer.Panel1.Controls.Add(this.Remove_Button);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.Refresh_Button);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.TrackedQuery_RichTextBox);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.trackedQueries_timePeriodLabel);
            this.trackedQueriesContainer.Panel1.Controls.Add(this.TrackedQueries_ListView);
            // 
            // trackedQueriesContainer.Panel2
            // 
            this.trackedQueriesContainer.Panel2.Controls.Add(this.trackedQueriesResultsContainer);
            this.trackedQueriesContainer.Size = new System.Drawing.Size(929, 371);
            this.trackedQueriesContainer.SplitterDistance = 310;
            this.trackedQueriesContainer.SplitterWidth = 9;
            this.trackedQueriesContainer.TabIndex = 1;
            // 
            // Remove_Button
            // 
            this.Remove_Button.ForeColor = System.Drawing.Color.Black;
            this.Remove_Button.Location = new System.Drawing.Point(87, 108);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 17;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.ForeColor = System.Drawing.Color.Black;
            this.Refresh_Button.Location = new System.Drawing.Point(6, 108);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Button.TabIndex = 15;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // TrackedQuery_RichTextBox
            // 
            this.TrackedQuery_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackedQuery_RichTextBox.Location = new System.Drawing.Point(6, 21);
            this.TrackedQuery_RichTextBox.Name = "TrackedQuery_RichTextBox";
            this.TrackedQuery_RichTextBox.ReadOnly = true;
            this.TrackedQuery_RichTextBox.Size = new System.Drawing.Size(297, 81);
            this.TrackedQuery_RichTextBox.TabIndex = 14;
            this.TrackedQuery_RichTextBox.Text = "";
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
            // TrackedQueries_ListView
            // 
            this.TrackedQueries_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackedQueries_ListView.BackColor = System.Drawing.Color.White;
            this.TrackedQueries_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackedQueryNames});
            this.TrackedQueries_ListView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrackedQueries_ListView.HideSelection = false;
            this.TrackedQueries_ListView.Location = new System.Drawing.Point(0, 137);
            this.TrackedQueries_ListView.MultiSelect = false;
            this.TrackedQueries_ListView.Name = "TrackedQueries_ListView";
            this.TrackedQueries_ListView.Size = new System.Drawing.Size(306, 230);
            this.TrackedQueries_ListView.TabIndex = 1;
            this.TrackedQueries_ListView.UseCompatibleStateImageBehavior = false;
            this.TrackedQueries_ListView.View = System.Windows.Forms.View.Details;
            this.TrackedQueries_ListView.SelectedIndexChanged += new System.EventHandler(this.TrackedQueries_ListView_SelectedIndexChanged);
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
            this.trackedQueriesResultsContainer.Panel1.Controls.Add(this.ActualQuery_Label);
            this.trackedQueriesResultsContainer.Panel1.Controls.Add(this.ActualQuery_DataGridView);
            // 
            // trackedQueriesResultsContainer.Panel2
            // 
            this.trackedQueriesResultsContainer.Panel2.Controls.Add(this.PreviousQuery_Label);
            this.trackedQueriesResultsContainer.Panel2.Controls.Add(this.PreviousQuery_DataGridView);
            this.trackedQueriesResultsContainer.Size = new System.Drawing.Size(610, 371);
            this.trackedQueriesResultsContainer.SplitterDistance = 203;
            this.trackedQueriesResultsContainer.SplitterWidth = 9;
            this.trackedQueriesResultsContainer.TabIndex = 1;
            // 
            // ActualQuery_Label
            // 
            this.ActualQuery_Label.AutoSize = true;
            this.ActualQuery_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActualQuery_Label.ForeColor = System.Drawing.Color.Black;
            this.ActualQuery_Label.Location = new System.Drawing.Point(1, 0);
            this.ActualQuery_Label.Name = "ActualQuery_Label";
            this.ActualQuery_Label.Size = new System.Drawing.Size(85, 17);
            this.ActualQuery_Label.TabIndex = 12;
            this.ActualQuery_Label.Text = "ActualQuery";
            // 
            // ActualQuery_DataGridView
            // 
            this.ActualQuery_DataGridView.AllowUserToAddRows = false;
            this.ActualQuery_DataGridView.AllowUserToDeleteRows = false;
            this.ActualQuery_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActualQuery_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.ActualQuery_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActualQuery_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ActualQuery_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ActualQuery_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActualQuery_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.ActualQuery_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActualQuery_DataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.ActualQuery_DataGridView.EnableHeadersVisualStyles = false;
            this.ActualQuery_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.ActualQuery_DataGridView.Location = new System.Drawing.Point(0, 17);
            this.ActualQuery_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.ActualQuery_DataGridView.Name = "ActualQuery_DataGridView";
            this.ActualQuery_DataGridView.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActualQuery_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.ActualQuery_DataGridView.RowHeadersVisible = false;
            this.ActualQuery_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ActualQuery_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActualQuery_DataGridView.Size = new System.Drawing.Size(606, 182);
            this.ActualQuery_DataGridView.TabIndex = 11;
            // 
            // PreviousQuery_Label
            // 
            this.PreviousQuery_Label.AutoSize = true;
            this.PreviousQuery_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreviousQuery_Label.ForeColor = System.Drawing.Color.Black;
            this.PreviousQuery_Label.Location = new System.Drawing.Point(1, 0);
            this.PreviousQuery_Label.Name = "PreviousQuery_Label";
            this.PreviousQuery_Label.Size = new System.Drawing.Size(103, 17);
            this.PreviousQuery_Label.TabIndex = 13;
            this.PreviousQuery_Label.Text = "Previous Query";
            // 
            // PreviousQuery_DataGridView
            // 
            this.PreviousQuery_DataGridView.AllowUserToAddRows = false;
            this.PreviousQuery_DataGridView.AllowUserToDeleteRows = false;
            this.PreviousQuery_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PreviousQuery_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.PreviousQuery_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousQuery_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PreviousQuery_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PreviousQuery_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PreviousQuery_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.PreviousQuery_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PreviousQuery_DataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.PreviousQuery_DataGridView.EnableHeadersVisualStyles = false;
            this.PreviousQuery_DataGridView.GridColor = System.Drawing.Color.Silver;
            this.PreviousQuery_DataGridView.Location = new System.Drawing.Point(0, 18);
            this.PreviousQuery_DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousQuery_DataGridView.Name = "PreviousQuery_DataGridView";
            this.PreviousQuery_DataGridView.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PreviousQuery_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.PreviousQuery_DataGridView.RowHeadersVisible = false;
            this.PreviousQuery_DataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.PreviousQuery_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PreviousQuery_DataGridView.Size = new System.Drawing.Size(606, 132);
            this.PreviousQuery_DataGridView.TabIndex = 11;
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
            ((System.ComponentModel.ISupportInitialize)(this.ActualQuery_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousQuery_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer trackedQueriesContainer;
        private System.Windows.Forms.ListView TrackedQueries_ListView;
        private System.Windows.Forms.ColumnHeader trackedQueryNames;
        private System.Windows.Forms.SplitContainer trackedQueriesResultsContainer;
        private System.Windows.Forms.DataGridView ActualQuery_DataGridView;
        private System.Windows.Forms.DataGridView PreviousQuery_DataGridView;
        private System.Windows.Forms.Label ActualQuery_Label;
        private System.Windows.Forms.Label PreviousQuery_Label;
        private System.Windows.Forms.Label trackedQueries_timePeriodLabel;
        private System.Windows.Forms.RichTextBox TrackedQuery_RichTextBox;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Refresh_Button;
    }
}
