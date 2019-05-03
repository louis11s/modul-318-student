using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farplan_App_GUI
{
    public partial class Form1 : Form
    {
        Transport t = new Transport();
        Stations myStations;

        public Form1()
        {
            InitializeComponent();
            tBvon.Focus();
            tBvon.Select();
        }

        private void tBnach_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox3.Items.Clear();
            Stations myStations = t.GetStations(tBvon.Text);
            foreach (Station station in myStations.StationList)
            {
                listBox3.Items.Add(station.Name);
            }
        }

        private void tBvon_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            myStations = t.GetStations(tBvon.Text);
            foreach (Station station in myStations.StationList)
            {
                try
                {
                    listBox1.Items.Add(station.Name);
                }
                catch
                {
                    tBvon.Clear();
                    tBnach.Clear();
                    listBox1.Items.Clear();
                    listBox3.Items.Clear();
                    MessageBox.Show("Fehler bitte erneut versuchen");                   
                }
            }

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            tBvon.Text = listBox1.SelectedItems[0].ToString();
            listBox1.Items.Clear();
        }

        private void tBnach_TextChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Stations myStations = t.GetStations(tBnach.Text);
            foreach (Station station in myStations.StationList)
            {
                listBox3.Items.Add(station.Name);
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            tBnach.Text = listBox3.SelectedItems[0].ToString();
            listBox3.Items.Clear();
        }
        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verbindung(listView1);
        }
        private void verbindung(ListView ListViewName)
        {
            Connections Verbindungen = t.GetConnections(tBvon.Text, tBnach.Text);

            foreach (Connection verbindung in Verbindungen.ConnectionList)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(verbindung.From.Station.Name);
                item.SubItems.Add(verbindung.To.Station.Name);
                DateTime Abfahrtszeit = Convert.ToDateTime(verbindung.From.Departure);
                item.SubItems.Add(Abfahrtszeit.TimeOfDay.ToString());
                item.Text = Abfahrtszeit.Date.ToString("ddd.dd.MM");
                listView1.Items.AddRange(new ListViewItem[] { item });
            }
        }

        private void btn_Abfahrt_Click(object sender, EventArgs e)
        {
            showStationBoard();
        }
        //Die Funktion mit dem Austauschen der Stationen funktioniert nicht//
        private void btn_Switch_Click_1(object sender, EventArgs e)
        {
            listBox3.Items.Add(tBnach.Text);
            listBox1.Items.Add(tBvon.Text);           
            tBnach.Text = listBox1.Items[0].ToString();
            tBvon.Text = listBox3.Items[0].ToString();            


        }

        private void tBvon_DoubleClick(object sender, EventArgs e)
        {
            tBvon.Text = String.Empty;
        }

        private void tBnach_DoubleClick(object sender, EventArgs e)
        {
            tBnach.Text = String.Empty;
        }

        private void showStationBoard()
        {
            listView1.Items.Clear();

            string name = tBvon.Text;
            string id = "";
            try
            {
                foreach (Station s in myStations.StationList)
                {
                    if (s.Name == name)
                    {
                        id = s.Id;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fehler bitte erneut versuchen");
                tBvon.Clear();
                tBnach.Clear();
            }

            StationBoardRoot stationBoard = t.GetStationBoard(name, id);
            foreach(StationBoard stationboard in stationBoard.Entries)
            {
                try
                {
                    ListViewItem item1 = new ListViewItem();
                    item1.SubItems.Add(tBvon.Text);
                    item1.SubItems.Add(stationboard.To);
                    item1.SubItems.Add(stationboard.Entries.Departure.ToShortTimeString());
                    listView1.Items.Add(item1);
                }
                catch
                {
                    MessageBox.Show("Fehler bitte erneut versuchen");
                }
            }
        }
        private void autoFill(KeyEventArgs e, TextBox textBoxName, ListBox listBoxName)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    listBoxName.SelectedIndex--;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    listBoxName.SelectedIndex++;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    textBoxName.Text = listBoxName.SelectedItems[0].ToString();
                }
            }
            catch
            {

            }
        }

        private void tBvon_KeyDown(object sender, KeyEventArgs e)
        {
            autoFill(e, tBvon, listBox1);
        }

        private void tBnach_KeyDown(object sender, KeyEventArgs e)
        {
            autoFill(e, tBnach, listBox3);
        }

        private void createGoogleMaps(string stationName)
        {
            Station stations = t.GetStations(stationName).StationList.First();

            string xcoordinate = stations.Coordinate.XCoordinate.ToString();
            string ycoordinate = stations.Coordinate.YCoordinate.ToString();
            webBrowser1.Url = new System.Uri("https://www.google.com/maps?q=" + xcoordinate.Replace(",",".") + "," + ycoordinate.Replace(",","."), System.UriKind.Absolute);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            createGoogleMaps(tBvon.Text);
        }
    }
}
