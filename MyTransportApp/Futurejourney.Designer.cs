namespace MyTransportApp
{
    partial class Futurejourney
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EndStationTextbox = new System.Windows.Forms.ComboBox();
            this.StartStationTextbox = new System.Windows.Forms.ComboBox();
            this.ConnectinsTable = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EndStationLable = new System.Windows.Forms.Label();
            this.StartStationLable = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(603, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 71);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Connections";
            // 
            // EndStationTextbox
            // 
            this.EndStationTextbox.FormattingEnabled = true;
            this.EndStationTextbox.Location = new System.Drawing.Point(172, 155);
            this.EndStationTextbox.Name = "EndStationTextbox";
            this.EndStationTextbox.Size = new System.Drawing.Size(121, 21);
            this.EndStationTextbox.TabIndex = 17;
            this.EndStationTextbox.TextChanged += new System.EventHandler(this.EndStationTextbox_TextChanged);
            // 
            // StartStationTextbox
            // 
            this.StartStationTextbox.FormattingEnabled = true;
            this.StartStationTextbox.Location = new System.Drawing.Point(25, 155);
            this.StartStationTextbox.Name = "StartStationTextbox";
            this.StartStationTextbox.Size = new System.Drawing.Size(121, 21);
            this.StartStationTextbox.TabIndex = 16;
            this.StartStationTextbox.TextChanged += new System.EventHandler(this.StartStationTextbox_TextChanged);
            // 
            // ConnectinsTable
            // 
            this.ConnectinsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectinsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Train,
            this.Platform,
            this.Duration,
            this.Delay});
            this.ConnectinsTable.Location = new System.Drawing.Point(73, 207);
            this.ConnectinsTable.Name = "ConnectinsTable";
            this.ConnectinsTable.Size = new System.Drawing.Size(551, 157);
            this.ConnectinsTable.TabIndex = 15;
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
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(560, 145);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 31);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EndStationLable
            // 
            this.EndStationLable.AutoSize = true;
            this.EndStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndStationLable.Location = new System.Drawing.Point(168, 126);
            this.EndStationLable.Name = "EndStationLable";
            this.EndStationLable.Size = new System.Drawing.Size(32, 24);
            this.EndStationLable.TabIndex = 13;
            this.EndStationLable.Text = "To:";
            this.EndStationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EndStationLable.Click += new System.EventHandler(this.EndStationLable_Click);
            // 
            // StartStationLable
            // 
            this.StartStationLable.AutoSize = true;
            this.StartStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStationLable.Location = new System.Drawing.Point(30, 128);
            this.StartStationLable.Name = "StartStationLable";
            this.StartStationLable.Size = new System.Drawing.Size(48, 22);
            this.StartStationLable.TabIndex = 12;
            this.StartStationLable.Text = "From:";
            this.StartStationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(315, 152);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker.TabIndex = 20;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timePortionDateTimePicker
            // 
            this.timePortionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePortionDateTimePicker.Location = new System.Drawing.Point(464, 155);
            this.timePortionDateTimePicker.Name = "timePortionDateTimePicker";
            this.timePortionDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.timePortionDateTimePicker.TabIndex = 22;
            // 
            // Futurejourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.timePortionDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndStationTextbox);
            this.Controls.Add(this.StartStationTextbox);
            this.Controls.Add(this.ConnectinsTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EndStationLable);
            this.Controls.Add(this.StartStationLable);
            this.Name = "Futurejourney";
            this.Text = "Futurejourney";
            this.Load += new System.EventHandler(this.Fururejourney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EndStationTextbox;
        private System.Windows.Forms.ComboBox StartStationTextbox;
        private System.Windows.Forms.DataGridView ConnectinsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label EndStationLable;
        private System.Windows.Forms.Label StartStationLable;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timePortionDateTimePicker;
    }
}