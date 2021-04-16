using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            bool checkconnection = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (checkconnection == false)
            {
                MessageBox.Show("Please Check your Internet Connection");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Connections c = new Connections();
                this.Hide();
                c.Closed += (s, args) => this.Close();
                c.Show();
           
            
           
        }

      

        private void DepartureBoard_Click(object sender, EventArgs e)
        {
            
                DepartureBoard c = new DepartureBoard();
                this.Hide();
                c.Closed += (s, args) => this.Close();
                c.Show();
            
        }

        private void StationLocation_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Sorry!\nThis page will be implemented very soon.\nTry again Later");
            
        }

        private void MyJouneys_Click(object sender, EventArgs e)
        {
            
                Myjourneys c = new Myjourneys();
                this.Hide();
                c.Closed += (s, args) => this.Close();
                c.Show();
            
        }

        private void FutureConnections_Click(object sender, EventArgs e)
        {
            
                Futurejourney c = new Futurejourney();
                this.Hide();
                c.Closed += (s, args) => this.Close();
                c.Show();
                
        }

        private void SendInformation_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Sorry!\nThis page will be implemented very soon.\nTry again Later");
            
        }
    }
}
