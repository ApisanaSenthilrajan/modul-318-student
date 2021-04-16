using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Myjourneys : Form
    {
        public Myjourneys()
        {
            InitializeComponent();
        }
        
        private void Location_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\apisa\source\repos\Projekt_M318\Project.txt");
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                counter++;
            }

            file.Close();
        }

        

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Menu c = new Menu();
            this.Hide();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }

        private void MailButton_Click(object sender, EventArgs e, object service)
        {
           
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //int counter = 0;
            //string line;
            //System.IO.StreamReader file =
            //new System.IO.StreamReader(@"C:\Users\apisa\source\repos\Projekt_M318\Project.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //  if(string.Compare(listBox1.SelectedItems.ToString(), line) == 0)
            //    {
            //        List<string> lines = File.ReadAllLines(@"C:\Users\apisa\source\repos\Projekt_M318\Project.txt").ToList();
            //        lines.RemoveAt(line);
            //        line.Remove()
            //    }
            //    counter++;
            //}

            //file.Close();
            /* Hier hab eich probier die Zeile aus der Text Datei zu löschen dies hat aber nicgt ganz fuktioniert*/
        }
    }
}
