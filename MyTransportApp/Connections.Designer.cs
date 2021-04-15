namespace MyTransportApp
{
    partial class Connections
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartStationLable = new System.Windows.Forms.Label();
            this.EndStationLable = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ConnectinsTable = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStationTextbox = new System.Windows.Forms.ComboBox();
            this.EndStationTextbox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStationLable
            // 
            this.StartStationLable.AutoSize = true;
            this.StartStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStationLable.Location = new System.Drawing.Point(31, 106);
            this.StartStationLable.Name = "StartStationLable";
            this.StartStationLable.Size = new System.Drawing.Size(48, 22);
            this.StartStationLable.TabIndex = 2;
            this.StartStationLable.Text = "From:";
            this.StartStationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndStationLable
            // 
            this.EndStationLable.AutoSize = true;
            this.EndStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndStationLable.Location = new System.Drawing.Point(187, 104);
            this.EndStationLable.Name = "EndStationLable";
            this.EndStationLable.Size = new System.Drawing.Size(32, 24);
            this.EndStationLable.TabIndex = 3;
            this.EndStationLable.Text = "To:";
            this.EndStationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(464, 124);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 31);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.ConnectinsTable.Location = new System.Drawing.Point(35, 189);
            this.ConnectinsTable.Name = "ConnectinsTable";
            this.ConnectinsTable.Size = new System.Drawing.Size(551, 157);
            this.ConnectinsTable.TabIndex = 7;
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
            // StartStationTextbox
            // 
            this.StartStationTextbox.FormattingEnabled = true;
            this.StartStationTextbox.Location = new System.Drawing.Point(35, 131);
            this.StartStationTextbox.Name = "StartStationTextbox";
            this.StartStationTextbox.Size = new System.Drawing.Size(121, 21);
            this.StartStationTextbox.TabIndex = 8;
            this.StartStationTextbox.TextChanged += new System.EventHandler(this.StartStationTextbox_TextChanged_1);
            // 
            // EndStationTextbox
            // 
            this.EndStationTextbox.FormattingEnabled = true;
            this.EndStationTextbox.Location = new System.Drawing.Point(191, 131);
            this.EndStationTextbox.Name = "EndStationTextbox";
            this.EndStationTextbox.Size = new System.Drawing.Size(121, 21);
            this.EndStationTextbox.TabIndex = 9;
            this.EndStationTextbox.TextChanged += new System.EventHandler(this.EndStationTextbox_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 71);
            this.panel1.TabIndex = 10;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndStationTextbox);
            this.Controls.Add(this.StartStationTextbox);
            this.Controls.Add(this.ConnectinsTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EndStationLable);
            this.Controls.Add(this.StartStationLable);
            this.Name = "Connections";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StartStationLable;
        private System.Windows.Forms.Label EndStationLable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ConnectinsTable;
        private System.Windows.Forms.ComboBox StartStationTextbox;
        private System.Windows.Forms.ComboBox EndStationTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

