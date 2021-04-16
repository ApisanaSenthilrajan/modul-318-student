namespace MyTransportApp
{
    partial class Menu
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
            this.searchConnections = new System.Windows.Forms.Button();
            this.DepartureBoard = new System.Windows.Forms.Button();
            this.StationLocation = new System.Windows.Forms.Button();
            this.FutureConnections = new System.Windows.Forms.Button();
            this.MyJouneys = new System.Windows.Forms.Button();
            this.SendInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchConnections
            // 
            this.searchConnections.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchConnections.Location = new System.Drawing.Point(135, 153);
            this.searchConnections.Margin = new System.Windows.Forms.Padding(4);
            this.searchConnections.Name = "searchConnections";
            this.searchConnections.Size = new System.Drawing.Size(363, 62);
            this.searchConnections.TabIndex = 1;
            this.searchConnections.Text = "Search Connections";
            this.searchConnections.UseVisualStyleBackColor = true;
            this.searchConnections.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartureBoard
            // 
            this.DepartureBoard.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureBoard.Location = new System.Drawing.Point(689, 153);
            this.DepartureBoard.Margin = new System.Windows.Forms.Padding(4);
            this.DepartureBoard.Name = "DepartureBoard";
            this.DepartureBoard.Size = new System.Drawing.Size(363, 62);
            this.DepartureBoard.TabIndex = 2;
            this.DepartureBoard.Text = "DepartureBoard";
            this.DepartureBoard.UseVisualStyleBackColor = true;
            this.DepartureBoard.Click += new System.EventHandler(this.DepartureBoard_Click);
            // 
            // StationLocation
            // 
            this.StationLocation.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationLocation.Location = new System.Drawing.Point(135, 283);
            this.StationLocation.Margin = new System.Windows.Forms.Padding(4);
            this.StationLocation.Name = "StationLocation";
            this.StationLocation.Size = new System.Drawing.Size(363, 62);
            this.StationLocation.TabIndex = 3;
            this.StationLocation.Text = "Station Location";
            this.StationLocation.UseVisualStyleBackColor = true;
            this.StationLocation.Click += new System.EventHandler(this.StationLocation_Click);
            // 
            // FutureConnections
            // 
            this.FutureConnections.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FutureConnections.Location = new System.Drawing.Point(689, 283);
            this.FutureConnections.Margin = new System.Windows.Forms.Padding(4);
            this.FutureConnections.Name = "FutureConnections";
            this.FutureConnections.Size = new System.Drawing.Size(363, 62);
            this.FutureConnections.TabIndex = 4;
            this.FutureConnections.Text = "Future Connections";
            this.FutureConnections.UseVisualStyleBackColor = true;
            this.FutureConnections.Click += new System.EventHandler(this.FutureConnections_Click);
            // 
            // MyJouneys
            // 
            this.MyJouneys.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyJouneys.Location = new System.Drawing.Point(135, 423);
            this.MyJouneys.Margin = new System.Windows.Forms.Padding(4);
            this.MyJouneys.Name = "MyJouneys";
            this.MyJouneys.Size = new System.Drawing.Size(363, 62);
            this.MyJouneys.TabIndex = 5;
            this.MyJouneys.Text = "My Journeys";
            this.MyJouneys.UseVisualStyleBackColor = true;
            this.MyJouneys.Click += new System.EventHandler(this.MyJouneys_Click);
            // 
            // SendInformation
            // 
            this.SendInformation.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendInformation.Location = new System.Drawing.Point(689, 423);
            this.SendInformation.Margin = new System.Windows.Forms.Padding(4);
            this.SendInformation.Name = "SendInformation";
            this.SendInformation.Size = new System.Drawing.Size(363, 62);
            this.SendInformation.TabIndex = 6;
            this.SendInformation.Text = "Send Information";
            this.SendInformation.UseVisualStyleBackColor = true;
            this.SendInformation.Click += new System.EventHandler(this.SendInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 77);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mobility Connector";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 100);
            this.panel1.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendInformation);
            this.Controls.Add(this.MyJouneys);
            this.Controls.Add(this.FutureConnections);
            this.Controls.Add(this.StationLocation);
            this.Controls.Add(this.DepartureBoard);
            this.Controls.Add(this.searchConnections);
            this.Font = new System.Drawing.Font("Bodoni MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchConnections;
        private System.Windows.Forms.Button DepartureBoard;
        private System.Windows.Forms.Button StationLocation;
        private System.Windows.Forms.Button FutureConnections;
        private System.Windows.Forms.Button MyJouneys;
        private System.Windows.Forms.Button SendInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}