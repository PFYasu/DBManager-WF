
namespace DBManager.Views.Engines
{
    partial class NewTrackedQueryView
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
            this.queryLabel = new System.Windows.Forms.Label();
            this.addConnection = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.validationError = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.timePeriodLabel = new System.Windows.Forms.Label();
            this.setTrackedQueryParametersLabel = new System.Windows.Forms.Label();
            this.timePeriod = new System.Windows.Forms.NumericUpDown();
            this.query = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(10, 81);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(35, 13);
            this.queryLabel.TabIndex = 5;
            this.queryLabel.Text = "Query";
            // 
            // addConnection
            // 
            this.addConnection.Location = new System.Drawing.Point(75, 178);
            this.addConnection.Name = "addConnection";
            this.addConnection.Size = new System.Drawing.Size(244, 20);
            this.addConnection.TabIndex = 6;
            this.addConnection.Text = "Save";
            this.addConnection.UseVisualStyleBackColor = true;
            this.addConnection.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(10, 178);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(59, 20);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // validationError
            // 
            this.validationError.AutoSize = true;
            this.validationError.Location = new System.Drawing.Point(8, 200);
            this.validationError.Name = "validationError";
            this.validationError.Size = new System.Drawing.Size(0, 13);
            this.validationError.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(10, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 20);
            this.name.TabIndex = 0;
            // 
            // timePeriodLabel
            // 
            this.timePeriodLabel.AutoSize = true;
            this.timePeriodLabel.Location = new System.Drawing.Point(201, 41);
            this.timePeriodLabel.Name = "timePeriodLabel";
            this.timePeriodLabel.Size = new System.Drawing.Size(118, 13);
            this.timePeriodLabel.TabIndex = 14;
            this.timePeriodLabel.Text = "Time period (in minutes)";
            // 
            // setTrackedQueryParametersLabel
            // 
            this.setTrackedQueryParametersLabel.AutoSize = true;
            this.setTrackedQueryParametersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.setTrackedQueryParametersLabel.Location = new System.Drawing.Point(3, 8);
            this.setTrackedQueryParametersLabel.Name = "setTrackedQueryParametersLabel";
            this.setTrackedQueryParametersLabel.Size = new System.Drawing.Size(251, 30);
            this.setTrackedQueryParametersLabel.TabIndex = 15;
            this.setTrackedQueryParametersLabel.Text = "Tracked query parameters";
            // 
            // timePeriod
            // 
            this.timePeriod.Location = new System.Drawing.Point(204, 57);
            this.timePeriod.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timePeriod.Name = "timePeriod";
            this.timePeriod.Size = new System.Drawing.Size(115, 20);
            this.timePeriod.TabIndex = 3;
            this.timePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(10, 97);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(309, 75);
            this.query.TabIndex = 16;
            this.query.Text = "";
            // 
            // NewTrackedQueryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 205);
            this.Controls.Add(this.query);
            this.Controls.Add(this.timePeriod);
            this.Controls.Add(this.setTrackedQueryParametersLabel);
            this.Controls.Add(this.timePeriodLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.validationError);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addConnection);
            this.Controls.Add(this.queryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTrackedQueryView";
            this.Text = "DBManager - New tracked query configuration";
            ((System.ComponentModel.ISupportInitialize)(this.timePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button addConnection;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label validationError;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label timePeriodLabel;
        private System.Windows.Forms.Label setTrackedQueryParametersLabel;
        private System.Windows.Forms.NumericUpDown timePeriod;
        private System.Windows.Forms.RichTextBox query;
    }
}