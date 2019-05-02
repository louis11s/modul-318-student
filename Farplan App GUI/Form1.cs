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

        public Form1()
        {
            InitializeComponent();
        }







        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            verbindung(listView1);
        }


        private void btn_Switch_Click(object sender, EventArgs e)
        {
            tBvon.Text = tBnach.Text;
            tBnach.Text = tBvon.Text;
        }

        private void tBnach_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox3.Items.Clear();
            Transport t = new Transport();
            Stations myStations = t.GetStations(tBvon.Text);
            foreach (Station station in myStations.StationList)
            {
                listBox3.Items.Add(station.Name);
            }
        }

        private void tBvon_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Transport t = new Transport();
            Stations myStations = t.GetStations(tBvon.Text);
            foreach (Station station in myStations.StationList)
            {
                listBox1.Items.Add(station.Name);
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
            Transport t = new Transport();
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
        private void verbindung(ListView ListViewName)
        {
            Connections Verbindungen = t.GetConnections(tBvon.Text, tBnach.Text);

            foreach (Connection verbindung in Verbindungen.ConnectionList)
            {
                ListViewName.Items.Add(verbindung.From.Station.Name);
                ListViewName.Items.Add(verbindung.To.Station.Name);
                ListViewName.Items.Add(verbindung.Duration);
                ListViewName.Items.Add(verbindung.To.Departure);
            }
        }
    }
}
