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
            tBvon.Focus();
            tBvon.Select();
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
                item.SubItems.Add(verbindung.From.Platform);
                item.Text = Abfahrtszeit.Date.ToString("ddd.dd.MM");
                item.SubItems.Add(verbindung.Duration);
                listView1.Items.AddRange(new ListViewItem[] { item });
            }
        }

        private void btn_Abfahrt_Click(object sender, EventArgs e)
        {
          
        }
        //Die Funktion mit dem Austauschen der Stationen funktioniert nicht//
        private void btn_Switch_Click_1(object sender, EventArgs e)
        {
            listBox3.Items.Add(tBnach.Text);
            listBox1.Items.Add(tBvon.Text);           
            tBnach.Text = listBox1.Items[0].ToString();
            tBvon.Text = listBox3.Items[0].ToString();            
            listBox1.Items.Clear();
            listBox3.Items.Clear();

        }

        private void tBvon_DoubleClick(object sender, EventArgs e)
        {
            tBvon.Text = String.Empty;
        }

        private void tBnach_DoubleClick(object sender, EventArgs e)
        {
            tBnach.Text = String.Empty;
        }
    }
}
