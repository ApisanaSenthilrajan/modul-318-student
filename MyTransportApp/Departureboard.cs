using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //string From = StartStationbox.Text.ToString();
            //var transport = new Transport();
            //var stations = transport.GetStations(From);



            //if (stations.StationList.Count.Equals(10))
            //{
            //    var connections = transport.GetConnections(From);
            //    for (int i = 0; i <= connections.ConnectionList.Count - 1; i++)
            //    {
            //        ConnectinsTable.Rows.Add(new[]
            //        {
            //            connections.ConnectionList[i].From.Departure.ToString(),
            //            connections.ConnectionList[i].From.Platform,
            //            connections.ConnectionList[i].To.Platform,
            //            connections.ConnectionList[i].Duration.Remove(0,3),
            //            connections.ConnectionList[i].From.Delay.ToString()
            //            });
            //    }
            //    //Console.WriteLine(connections);
            //}
            //else
            //{
            //    MessageBox.Show("Keine Station gefunden");
            //}
        }
    }


   
    
}
