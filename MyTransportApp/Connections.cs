using SwissTransport.Core;
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
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string From = StartStationTextbox.Text.ToString();
            string To = EndStationTextbox.Text.ToString();
            var transport = new Transport();
            var stations = transport.GetStations(From);
            var stationsTo = transport.GetStations(To);
         
          

                if ( stations.StationList.Count.Equals(10) && stationsTo.StationList.Count.Equals(10))
                {
                    var connections = transport.GetConnections(From,To);
                    for (int i = 0; i <= connections.ConnectionList.Count - 1; i++)
                    {
                        ConnectinsTable.Rows.Add(new[]
                        {
                        connections.ConnectionList[i].From.Departure.ToString(),
                        connections.ConnectionList[i].From.Platform,
                        connections.ConnectionList[i].To.Platform,
                        connections.ConnectionList[i].Duration.Remove(0,3),
                        connections.ConnectionList[i].From.Delay.ToString()
                        });
                    }
                //Console.WriteLine(connections);
                }
                else
                {
                    MessageBox.Show("Keine Station gefunden");
                }
        }

        private void StartStationTextbox_TextChanged_1(object sender, EventArgs e)
        {
            string From = StartStationTextbox.Text.ToString();
            var transport = new Transport();
            var stations = transport.GetStations(From);

                for (int i = 0; i <= stations.StationList.Count - 1; i++)
                {
                    StartStationTextbox.Items.Add(stations.StationList[i].Name);
                }
        }

        private void EndStationTextbox_TextChanged_1(object sender, EventArgs e)
        {
            string To = EndStationTextbox.Text.ToString();
            var transport = new Transport();
            var stationsTo = transport.GetStations(To);

                for (int i = 0; i <= stationsTo.StationList.Count - 1; i++)
                {
                    EndStationTextbox.Items.Add(stationsTo.StationList[i].Name);
                }
        }
    }
}
