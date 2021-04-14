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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (stations.StationList.Count < 1 || stationsTo.StationList.Count < 1)
            {
                MessageBox.Show("Keine Station gefunden");
            }
            // string From = StartStationTextbox.Text.ToString();
            // string To = EndStationTextbox.Text;
            // var transport = new Transport();
            // var stations = transport.GetStations(From);
            //// Console.WriteLine(stations);
            // for (int i = 0; i <= 9; i++) {
            //     listBox1.Items.Add(stations.StationList[i].Name);
            // }



        }


        private void StartStationTextbox_TextChanged(object sender, EventArgs e)
        {
            string From = StartStationTextbox.Text.ToString();
            string To = EndStationTextbox.Text.ToString();
            var transport = new Transport();
            var stations = transport.GetStations(From);
            
           
            //for (int i = 0; i <= stations.StationList.Count - 1; i++)
            //{
            //    listBox1.Items.Add(stations.StationList[i].Name);
            //}

        }

    

       

        private void StartStationTextbox_TextChanged_1(object sender, EventArgs e)
        {
            string From = StartStationTextbox.Text.ToString();
            var transport = new Transport();
            var stations = transport.GetStations(From);


            // Console.WriteLine(stations);
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



            for (int i = 0; i <= 9; i++)
            {
                EndStationTextbox.Items.Add(stationsTo.StationList[i].Name);
            }
        }
    }
}
