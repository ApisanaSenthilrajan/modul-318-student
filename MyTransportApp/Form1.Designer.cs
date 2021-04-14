namespace MyTransportApp
{
    partial class Form1
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
            this.StartStationTextbox = new System.Windows.Forms.TextBox();
            this.EndStationTextbox = new System.Windows.Forms.TextBox();
            this.StartStationLable = new System.Windows.Forms.Label();
            this.EndStationLable = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StartStationTextbox
            // 
            this.StartStationTextbox.Location = new System.Drawing.Point(38, 55);
            this.StartStationTextbox.Name = "StartStationTextbox";
            this.StartStationTextbox.Size = new System.Drawing.Size(178, 20);
            this.StartStationTextbox.TabIndex = 0;
            this.StartStationTextbox.TextChanged += new System.EventHandler(this.StartStationTextbox_TextChanged);
            this.StartStationTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartStationTextbox_KeyPress);
            // 
            // EndStationTextbox
            // 
            this.EndStationTextbox.Location = new System.Drawing.Point(249, 55);
            this.EndStationTextbox.Name = "EndStationTextbox";
            this.EndStationTextbox.Size = new System.Drawing.Size(178, 20);
            this.EndStationTextbox.TabIndex = 1;
            this.EndStationTextbox.TextChanged += new System.EventHandler(this.EndStationTextbox_TextChanged);
            // 
            // StartStationLable
            // 
            this.StartStationLable.AutoSize = true;
            this.StartStationLable.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStationLable.Location = new System.Drawing.Point(44, 28);
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
            this.EndStationLable.Location = new System.Drawing.Point(255, 28);
            this.EndStationLable.Name = "EndStationLable";
            this.EndStationLable.Size = new System.Drawing.Size(32, 24);
            this.EndStationLable.TabIndex = 3;
            this.EndStationLable.Text = "To:";
            this.EndStationLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(472, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 31);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 43);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(249, 72);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 43);
            this.listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EndStationLable);
            this.Controls.Add(this.StartStationLable);
            this.Controls.Add(this.EndStationTextbox);
            this.Controls.Add(this.StartStationTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartStationTextbox;
        private System.Windows.Forms.TextBox EndStationTextbox;
        private System.Windows.Forms.Label StartStationLable;
        private System.Windows.Forms.Label EndStationLable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

