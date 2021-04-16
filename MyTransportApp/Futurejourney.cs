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
using SwissTransport.Core;

namespace MyTransportApp
{
    public partial class Futurejourney : Form
    {
        public Futurejourney()
        {
            InitializeComponent();
        }

        private void Fururejourney_Load(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            timePortionDateTimePicker.Format = DateTimePickerFormat.Time;
            timePortionDateTimePicker.ShowUpDown = true;
            timePortionDateTimePicker.CustomFormat = "hh:mm";
        }

        private void EndStationLable_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string From = StartStationTextbox.Text.ToString();
            string To = EndStationTextbox.Text.ToString();
            var transport = new Transport();
            var stations = transport.GetStations(From);
            var stationsTo = transport.GetStations(To);
            string departure = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string time = timePortionDateTimePicker.Text.ToString();
            ConnectinsTable.Rows.Clear();


            if (stations.StationList.Count >= 1 && stationsTo.StationList.Count >= 1)
            {
                var connections = transport.GetConnections2(From, To, departure, time);
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

        private void StartStationTextbox_TextChanged(object sender, EventArgs e)
        {
            string From = StartStationTextbox.Text.ToString();
            var transport = new Transport();
            var stations = transport.GetStations(From);

            for (int i = 0; i <= stations.StationList.Count - 1; i++)
            {
                StartStationTextbox.Items.Add(stations.StationList[i].Name);
            }
        }

        private void EndStationTextbox_TextChanged(object sender, EventArgs e)
        {
            string To = EndStationTextbox.Text.ToString();
            var transport = new Transport();
            var stationsTo = transport.GetStations(To);

            for (int i = 0; i <= stationsTo.StationList.Count - 1; i++)
            {

                EndStationTextbox.Items.Add(stationsTo.StationList[i].Name);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConnectinsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { /*
            t =Time
            DS = Departure Station
            DP = Departure Platform
            AS = Ariiaval Station
            AP = Arrival Platform
            D = Duration
          */
            
            Myjourneys j = new Myjourneys();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ConnectinsTable.Rows[e.RowIndex];
                string t = row.Cells["Time"].Value.ToString();
                string DS = StartStationTextbox.Text.ToString();
                string DP = row.Cells["Train"].Value.ToString();
                string AS = EndStationTextbox.Text.ToString();
                string AP = row.Cells["Platform"].Value.ToString();
                string D = row.Cells["Duration"].Value.ToString();
                string path = @"C:\Users\apisa\source\repos\Projekt_M318\Project.txt";
                string Journey = "Time: " + t + "," + "Departure Station: " + DS + ","+"Departure Platform:" + DP + ","+"Arrival station: " + AS + "," + "Arrival Platform: " + AP + "," + "Duration:  " + D;
                using (StreamWriter tw = File.AppendText(path))
                {
                    
                   
                        
                        
                            tw.Write(Journey);

                        
                        tw.WriteLine();
                    
                }
            }
         
            this.Hide();
            j.Closed += (s, args) => this.Close();
            j.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu c = new Menu();
            this.Hide();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }
    }
    }
