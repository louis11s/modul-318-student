﻿using SwissTransport;
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
        //Vorschläge in der listbox
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
                    MessageBox.Show("Station nicht gefunden");                   
                }
            }

        }
        //Listbox zu Textbox
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tBvon.Text = listBox1.SelectedItems[0].ToString();
                listBox1.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
        }

        private void tBnach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                Stations myStations = t.GetStations(tBnach.Text);
                foreach (Station station in myStations.StationList)
                {
                    listBox3.Items.Add(station.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Station nicht gefunden");
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tBnach.Text = listBox3.SelectedItems[0].ToString();
                listBox3.Items.Clear();
            }
            catch 
            {
                MessageBox.Show("Fehler");
            }
        }
        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verbindung(listView1);
        }
        private void verbindung(ListView ListViewName)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Abfahrt_Click(object sender, EventArgs e)
        {
            showStationBoard();
        }
        private void btn_Switch_Click_1(object sender, EventArgs e)
        {
            string Wechseln = tBvon.Text;
            tBvon.Text = tBnach.Text;
            tBnach.Text = Wechseln;
            listBox3.Items.Clear();
            listBox1.Items.Clear();


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
            



            StationBoardRoot stationBoard = t.GetStationBoard(name, id);
            foreach (StationBoard stationboard in stationBoard.Entries)
            {

                ListViewItem item1 = new ListViewItem();
                item1.SubItems.Add(tBvon.Text);
                item1.SubItems.Add(stationboard.To);
                item1.SubItems.Add(stationboard.Entries.Departure.ToShortTimeString());
                listView1.Items.Add(item1);

            }
            } 
            catch 
               {
                MessageBox.Show("Station nicht gefunden");
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
                    listBox3.Items.Clear();
                    listBox1.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Drücken sie einen Button", ex.Message);
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
        //Um Google Maps aufzurufen
        private void ChangeTab(TabPage TabPageName)
        {
            Menu.SelectTab(TabPageName);
        }
        private void createGoogleMaps(string stationName)
        {
            Station stations = t.GetStations(stationName).StationList.First();

            string xcoordinate = stations.Coordinate.XCoordinate.ToString();
            string ycoordinate = stations.Coordinate.YCoordinate.ToString();
            webBrowser1.Url = new System.Uri("https://www.google.com/maps?q=" + xcoordinate.Replace(",", ".") + "," + ycoordinate.Replace(",", "."), System.UriKind.Absolute);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeTab(tabPage2);
                createGoogleMaps(tBvon.Text);
            }
            catch
            {
                ChangeTab(tabPage1);
                MessageBox.Show("Geben Sie bitte eine gültige Station ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_MeinStandort_Click(object sender, EventArgs e)
        {
            ChangeTab(tabPage2);
            webBrowser1.Url = new System.Uri("https://www.google.com/maps?q=", System.UriKind.Absolute);
        }
    }
}
