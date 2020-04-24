namespace Farplan_App_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_MeinStandort = new System.Windows.Forms.Button();
            this.btn_Maps = new System.Windows.Forms.Button();
            this.btn_Switch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Abfahrt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tBnach = new System.Windows.Forms.TextBox();
            this.tBvon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Location = new System.Drawing.Point(0, 1);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(932, 548);
            this.Menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_MeinStandort);
            this.tabPage1.Controls.Add(this.btn_Maps);
            this.tabPage1.Controls.Add(this.btn_Switch);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.listBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_Abfahrt);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tBnach);
            this.tabPage1.Controls.Add(this.tBvon);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Suchen);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(924, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_MeinStandort
            // 
            this.btn_MeinStandort.BackColor = System.Drawing.Color.Gray;
            this.btn_MeinStandort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MeinStandort.ForeColor = System.Drawing.Color.White;
            this.btn_MeinStandort.Location = new System.Drawing.Point(801, 134);
            this.btn_MeinStandort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MeinStandort.Name = "btn_MeinStandort";
            this.btn_MeinStandort.Size = new System.Drawing.Size(106, 27);
            this.btn_MeinStandort.TabIndex = 30;
            this.btn_MeinStandort.Text = "Mein Standort";
            this.btn_MeinStandort.UseVisualStyleBackColor = false;
            this.btn_MeinStandort.Click += new System.EventHandler(this.btn_MeinStandort_Click);
            // 
            // btn_Maps
            // 
            this.btn_Maps.BackColor = System.Drawing.Color.Gray;
            this.btn_Maps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maps.ForeColor = System.Drawing.Color.White;
            this.btn_Maps.Location = new System.Drawing.Point(340, 58);
            this.btn_Maps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Maps.Name = "btn_Maps";
            this.btn_Maps.Size = new System.Drawing.Size(102, 27);
            this.btn_Maps.TabIndex = 22;
            this.btn_Maps.Text = "Haltestelle";
            this.btn_Maps.UseVisualStyleBackColor = false;
            this.btn_Maps.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Switch
            // 
            this.btn_Switch.BackColor = System.Drawing.Color.Gray;
            this.btn_Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Switch.ForeColor = System.Drawing.Color.White;
            this.btn_Switch.Location = new System.Drawing.Point(403, 121);
            this.btn_Switch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(67, 28);
            this.btn_Switch.TabIndex = 24;
            this.btn_Switch.Text = "<-->";
            this.btn_Switch.UseVisualStyleBackColor = false;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click_1);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.Von,
            this.Nach,
            this.Abfahrtszeit});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 252);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(772, 250);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 80;
            // 
            // Von
            // 
            this.Von.Text = "Von";
            this.Von.Width = 120;
            // 
            // Nach
            // 
            this.Nach.Text = "Nach";
            this.Nach.Width = 120;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.Text = "Abfahrtszeit";
            this.Abfahrtszeit.Width = 80;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.White;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(532, 83);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(256, 100);
            this.listBox3.TabIndex = 28;
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            this.listBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBnach_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(396, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fahrplan";
            // 
            // btn_Abfahrt
            // 
            this.btn_Abfahrt.BackColor = System.Drawing.Color.Gray;
            this.btn_Abfahrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Abfahrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Abfahrt.ForeColor = System.Drawing.Color.White;
            this.btn_Abfahrt.Location = new System.Drawing.Point(340, 89);
            this.btn_Abfahrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Abfahrt.Name = "btn_Abfahrt";
            this.btn_Abfahrt.Size = new System.Drawing.Size(102, 27);
            this.btn_Abfahrt.TabIndex = 21;
            this.btn_Abfahrt.Text = "Abfahrtstafel";
            this.btn_Abfahrt.UseVisualStyleBackColor = false;
            this.btn_Abfahrt.Click += new System.EventHandler(this.btn_Abfahrt_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(78, 83);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 100);
            this.listBox1.TabIndex = 25;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBvon_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 194);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 8, 10, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datum:";
            // 
            // tBnach
            // 
            this.tBnach.BackColor = System.Drawing.Color.White;
            this.tBnach.Location = new System.Drawing.Point(532, 58);
            this.tBnach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBnach.Name = "tBnach";
            this.tBnach.Size = new System.Drawing.Size(256, 22);
            this.tBnach.TabIndex = 18;
            this.tBnach.TextChanged += new System.EventHandler(this.tBnach_TextChanged);
            this.tBnach.DoubleClick += new System.EventHandler(this.tBnach_DoubleClick);
            this.tBnach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBnach_KeyDown);
            // 
            // tBvon
            // 
            this.tBvon.BackColor = System.Drawing.Color.White;
            this.tBvon.Location = new System.Drawing.Point(78, 58);
            this.tBvon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBvon.Name = "tBvon";
            this.tBvon.Size = new System.Drawing.Size(256, 22);
            this.tBvon.TabIndex = 16;
            this.tBvon.TextChanged += new System.EventHandler(this.tBvon_TextChanged);
            this.tBvon.DoubleClick += new System.EventHandler(this.tBvon_DoubleClick);
            this.tBvon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBvon_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Von:";
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.Gray;
            this.btn_Suchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suchen.ForeColor = System.Drawing.Color.White;
            this.btn_Suchen.Location = new System.Drawing.Point(801, 58);
            this.btn_Suchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(106, 62);
            this.btn_Suchen.TabIndex = 20;
            this.btn_Suchen.Text = "Anzeigen";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(924, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Standort";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 5);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(917, 514);
            this.webBrowser1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 553);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(958, 600);
            this.MinimumSize = new System.Drawing.Size(958, 600);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Maps;
        private System.Windows.Forms.Button btn_Switch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Nach;
        private System.Windows.Forms.ColumnHeader Abfahrtszeit;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Abfahrt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBnach;
        private System.Windows.Forms.TextBox tBvon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_MeinStandort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

