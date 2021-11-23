
namespace DBManager.Views
{
    partial class ConnectorSelectorView
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SelectConnection_Label = new System.Windows.Forms.Label();
            this.AvailableConnectionTypes_ListView = new System.Windows.Forms.ListView();
            this.EngineTypes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfigureConnection_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(10, 172);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(81, 20);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectConnection_Label
            // 
            this.SelectConnection_Label.AutoSize = true;
            this.SelectConnection_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.SelectConnection_Label.Location = new System.Drawing.Point(10, 8);
            this.SelectConnection_Label.Name = "SelectConnection_Label";
            this.SelectConnection_Label.Size = new System.Drawing.Size(177, 30);
            this.SelectConnection_Label.TabIndex = 2;
            this.SelectConnection_Label.Text = "Select connection";
            // 
            // AvailableConnectionTypes_ListView
            // 
            this.AvailableConnectionTypes_ListView.BackColor = System.Drawing.Color.White;
            this.AvailableConnectionTypes_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EngineTypes});
            this.AvailableConnectionTypes_ListView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AvailableConnectionTypes_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.AvailableConnectionTypes_ListView.HideSelection = false;
            this.AvailableConnectionTypes_ListView.Location = new System.Drawing.Point(10, 41);
            this.AvailableConnectionTypes_ListView.MultiSelect = false;
            this.AvailableConnectionTypes_ListView.Name = "AvailableConnectionTypes_ListView";
            this.AvailableConnectionTypes_ListView.Size = new System.Drawing.Size(260, 125);
            this.AvailableConnectionTypes_ListView.TabIndex = 4;
            this.AvailableConnectionTypes_ListView.UseCompatibleStateImageBehavior = false;
            this.AvailableConnectionTypes_ListView.View = System.Windows.Forms.View.Details;
            this.AvailableConnectionTypes_ListView.SelectedIndexChanged += new System.EventHandler(this.AvailableConnectionTypes_ListView_SelectedIndexChanged);
            // 
            // EngineTypes
            // 
            this.EngineTypes.Text = "";
            // 
            // ConfigureConnection_Button
            // 
            this.ConfigureConnection_Button.Location = new System.Drawing.Point(97, 172);
            this.ConfigureConnection_Button.Name = "ConfigureConnection_Button";
            this.ConfigureConnection_Button.Size = new System.Drawing.Size(173, 20);
            this.ConfigureConnection_Button.TabIndex = 5;
            this.ConfigureConnection_Button.Text = "Configure connection";
            this.ConfigureConnection_Button.UseVisualStyleBackColor = true;
            this.ConfigureConnection_Button.Click += new System.EventHandler(this.ConfigureConnection_Button_Click);
            // 
            // ConnectorSelectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 198);
            this.Controls.Add(this.ConfigureConnection_Button);
            this.Controls.Add(this.AvailableConnectionTypes_ListView);
            this.Controls.Add(this.SelectConnection_Label);
            this.Controls.Add(this.Cancel_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectorSelectorView";
            this.Text = "DBManager - select connection type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label SelectConnection_Label;
        private System.Windows.Forms.ListView AvailableConnectionTypes_ListView;
        private System.Windows.Forms.ColumnHeader EngineTypes;
        private System.Windows.Forms.Button ConfigureConnection_Button;
    }
}