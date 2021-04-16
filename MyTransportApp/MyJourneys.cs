using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            try
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
            catch (WebException)
            {
                MessageBox.Show("Please Connect to the Interent !");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong !");
            }
        }

        

        private void MenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                Menu c = new Menu();
                this.Hide();
                c.Closed += (s, args) => this.Close();
                c.Show();
            }
            catch (WebException)
            {
                MessageBox.Show("Please Connect to the Interent !");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong !");
            }
        }
       

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                
                string path = @"C:\Users\apisa\source\repos\Projekt_M318\Project.txt";
                string Journey = string.Join(Environment.NewLine, listBox1.Items.Cast<string>());

                File.WriteAllText(path, Journey);
                


            }
            catch (WebException)
            {
                MessageBox.Show("Please Connect to the Interent !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong !");
            }
            

            /* Hier hab eich probier die Zeile aus der Text Datei zu löschen dies hat aber nicht ganz fuktioniert*/
        }

        private void MailButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Your Journeys are saved in the file: Project.txt and you can attach that file to the mail.");
            }
            catch (WebException)
            {
                MessageBox.Show("Please Connect to the Interent !");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong !");
            }
        }
    }
}
