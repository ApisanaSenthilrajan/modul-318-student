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
            try
            {
                dateTimePicker.CustomFormat = "yyyy-MM-dd";
                timePortionDateTimePicker.Format = DateTimePickerFormat.Time;
                timePortionDateTimePicker.ShowUpDown = true;
                timePortionDateTimePicker.CustomFormat = "hh:mm";
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (WebException)
            {
                MessageBox.Show("Please Connect to the Interent !");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong !\n Please check if you have filled in all boxes.");
            }
        }

        private void StartStationTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string From = StartStationTextbox.Text.ToString();
                var transport = new Transport();
                var stations = transport.GetStations(From);

                for (int i = 0; i <= stations.StationList.Count - 1; i++)
                {
                    StartStationTextbox.Items.Add(stations.StationList[i].Name);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Something went wrong!\n please check if you have given a text");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong !");
            }

        }

        private void EndStationTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string To = EndStationTextbox.Text.ToString();
                var transport = new Transport();
                var stationsTo = transport.GetStations(To);

                for (int i = 0; i <= stationsTo.StationList.Count - 1; i++)
                {

                    EndStationTextbox.Items.Add(stationsTo.StationList[i].Name);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Please Connect to the Interent !");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!\n please check if you have given a text");
            }
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
            try
            {
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
                    string Journey = "Time: " + t + "," + "Departure Station: " + DS + "," + "Departure Platform:" + DP + "," + "Arrival station: " + AS + "," + "Arrival Platform: " + AP + "," + "Duration:  " + D;
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
                MessageBox.Show("Something went wrong!");
            }
        }

        private void MailButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feauture will be implemented very soon.\n please try again later!");
        }
    }
    }
