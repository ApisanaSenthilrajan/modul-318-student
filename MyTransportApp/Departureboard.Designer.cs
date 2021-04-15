namespace MyTransportApp
{
    partial class Form1
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
            this.StartStationbox = new System.Windows.Forms.ComboBox();
            this.ConnectinsTable = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StartStationLable = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrivalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStationbox
            // 
            this.StartStationbox.FormattingEnabled = true;
            this.StartStationbox.Location = new System.Drawing.Point(24, 58);
            this.StartStationbox.Name = "StartStationbox";
            this.StartStationbox.Size = new System.Drawing.Size(121, 21);
            this.StartStationbox.TabIndex = 14;
            // 
            // ConnectinsTable
            // 
            this.ConnectinsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectinsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Train,
            this.Arrivalstation,
            this.Platform,
            this.Duration,
            this.Delay});
            this.ConnectinsTable.Location = new System.Drawing.Point(24, 142);
            this.ConnectinsTable.Name = "ConnectinsTable";
            this.ConnectinsTable.Size = new System.Drawing.Size(553, 157);
            this.ConnectinsTable.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(210, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 31);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StartStationLable
            // 
            this.StartStationLable.AutoSize = true;
            this.StartStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStationLable.Location = new System.Drawing.Point(24, 28);
            this.StartStationLable.Name = "StartStationLable";
            this.StartStationLable.Size = new System.Drawing.Size(48, 22);
            this.StartStationLable.TabIndex = 10;
            this.StartStationLable.Text = "From:";
            this.StartStationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Time
            // 
            this.Time.HeaderText = "Departure Date & Time";
            this.Time.MinimumWidth = 40;
            this.Time.Name = "Time";
            this.Time.Width = 110;
            // 
            // Train
            // 
            this.Train.HeaderText = "Departure Platform";
            this.Train.Name = "Train";
            // 
            // Arrivalstation
            // 
            this.Arrivalstation.HeaderText = "Arrival station";
            this.Arrivalstation.Name = "Arrivalstation";
            // 
            // Platform
            // 
            this.Platform.HeaderText = " Arrival Platform";
            this.Platform.Name = "Platform";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Delay
            // 
            this.Delay.HeaderText = "Delay";
            this.Delay.Name = "Delay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 433);
            this.Controls.Add(this.StartStationbox);
            this.Controls.Add(this.ConnectinsTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StartStationLable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox StartStationbox;
        private System.Windows.Forms.DataGridView ConnectinsTable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label StartStationLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrivalstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
    }
}