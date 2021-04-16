using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;

namespace MyTransportApp
{
    public partial class DepartureBoard : Form
    {
        public DepartureBoard()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string From = StartStationbox.Text.ToString();
                var transport = new Transport();
                var stations = transport.GetStations(From);
                var Id = transport.GetStations(From).StationList[0].Id.ToString();
                ConnectinsTable.Rows.Clear();
                if (stations.StationList.Count >= 1)
                {
                    var StationBoard = transport.GetStationBoard(From, Id);
                    //Console.WriteLine(connections);
                    for (int i = 0; i <= StationBoard.Entries.Count - 1; i++)
                    {


                        ConnectinsTable.Rows.Add(new[]
                        {
                          StationBoard.Entries[i].Stop.Departure.ToString(),
                          StationBoard.Entries[i].To,

                     });
                    }

                }
                else
                {
                    MessageBox.Show("Keine Station gefunden");
                }
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

        private void StartStationbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string From = StartStationbox.Text.ToString();
                var transport = new Transport();
                var stations = transport.GetStations(From);
                //StartStationbox.Items.Clear();

                for (int i = 0; i <= stations.StationList.Count - 1; i++)
                {
                    StartStationbox.Items.Add(stations.StationList[i].Name);
                }
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

        private void button1_Click(object sender, EventArgs e)
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
    }


   
    
}
