namespace MyTransportApp
{
    partial class DepartureBoard
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
            this.Arrivalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStationbox
            // 
            this.StartStationbox.FormattingEnabled = true;
            this.StartStationbox.Location = new System.Drawing.Point(139, 114);
            this.StartStationbox.Name = "StartStationbox";
            this.StartStationbox.Size = new System.Drawing.Size(121, 21);
            this.StartStationbox.TabIndex = 14;
            this.StartStationbox.TextChanged += new System.EventHandler(this.StartStationbox_TextChanged);
            // 
            // ConnectinsTable
            // 
            this.ConnectinsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectinsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Arrivalstation});
            this.ConnectinsTable.Location = new System.Drawing.Point(139, 162);
            this.ConnectinsTable.Name = "ConnectinsTable";
            this.ConnectinsTable.Size = new System.Drawing.Size(253, 142);
            this.ConnectinsTable.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(304, 108);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 28);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StartStationLable
            // 
            this.StartStationLable.AutoSize = true;
            this.StartStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStationLable.Location = new System.Drawing.Point(135, 89);
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
            // Arrivalstation
            // 
            this.Arrivalstation.HeaderText = "Arrival station";
            this.Arrivalstation.Name = "Arrivalstation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Departure Board";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 70);
            this.panel1.TabIndex = 16;
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(414, 313);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(93, 30);
            this.Menu.TabIndex = 17;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartureBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 366);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartStationbox);
            this.Controls.Add(this.ConnectinsTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StartStationLable);
            this.Name = "DepartureBoard";
            this.Text = "DepartureBoard";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectinsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox StartStationbox;
        private System.Windows.Forms.DataGridView ConnectinsTable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label StartStationLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrivalstation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Menu;
    }
}