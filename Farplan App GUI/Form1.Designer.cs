﻿namespace Farplan_App_GUI
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
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBvon = new System.Windows.Forms.TextBox();
            this.tBnach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Abfahrt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.Gray;
            this.btn_Suchen.ForeColor = System.Drawing.Color.White;
            this.btn_Suchen.Location = new System.Drawing.Point(911, 80);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(119, 78);
            this.btn_Suchen.TabIndex = 0;
            this.btn_Suchen.Text = "Anzeigen";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach:";
            // 
            // tBvon
            // 
            this.tBvon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBvon.Location = new System.Drawing.Point(98, 80);
            this.tBvon.Name = "tBvon";
            this.tBvon.Size = new System.Drawing.Size(287, 26);
            this.tBvon.TabIndex = 3;
            this.tBvon.TextChanged += new System.EventHandler(this.tBvon_TextChanged);
            this.tBvon.DoubleClick += new System.EventHandler(this.tBvon_DoubleClick);
            // 
            // tBnach
            // 
            this.tBnach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBnach.Location = new System.Drawing.Point(608, 80);
            this.tBnach.Name = "tBnach";
            this.tBnach.Size = new System.Drawing.Size(287, 26);
            this.tBnach.TabIndex = 4;
            this.tBnach.TextChanged += new System.EventHandler(this.tBnach_TextChanged);
            this.tBnach.DoubleClick += new System.EventHandler(this.tBnach_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(98, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 124);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btn_Abfahrt
            // 
            this.btn_Abfahrt.BackColor = System.Drawing.Color.Gray;
            this.btn_Abfahrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Abfahrt.ForeColor = System.Drawing.Color.White;
            this.btn_Abfahrt.Location = new System.Drawing.Point(391, 76);
            this.btn_Abfahrt.Name = "btn_Abfahrt";
            this.btn_Abfahrt.Size = new System.Drawing.Size(115, 34);
            this.btn_Abfahrt.TabIndex = 8;
            this.btn_Abfahrt.Text = "Abfahrtstafel";
            this.btn_Abfahrt.UseVisualStyleBackColor = false;
            this.btn_Abfahrt.Click += new System.EventHandler(this.btn_Abfahrt_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(456, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fahrplan";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(608, 112);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(287, 124);
            this.listBox3.TabIndex = 12;
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.Von,
            this.Nach,
            this.Abfahrtszeit,
            this.Gleis,
            this.Dauer});
            this.listView1.Location = new System.Drawing.Point(98, 323);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(905, 289);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 120;
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
            this.Abfahrtszeit.Width = 120;
            // 
            // Gleis
            // 
            this.Gleis.Text = "Gleis";
            this.Gleis.Width = 40;
            // 
            // Dauer
            // 
            this.Dauer.Text = "Dauer";
            this.Dauer.Width = 100;
            // 
            // btn_Switch
            // 
            this.btn_Switch.BackColor = System.Drawing.Color.Gray;
            this.btn_Switch.Location = new System.Drawing.Point(463, 152);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(75, 35);
            this.btn_Switch.TabIndex = 14;
            this.btn_Switch.Text = "§";
            this.btn_Switch.UseVisualStyleBackColor = false;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 638);
            this.Controls.Add(this.btn_Switch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Abfahrt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBnach);
            this.Controls.Add(this.tBvon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Suchen);
            this.MaximumSize = new System.Drawing.Size(1091, 1000);
            this.MinimumSize = new System.Drawing.Size(1091, 694);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBvon;
        private System.Windows.Forms.TextBox tBnach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Abfahrt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Nach;
        private System.Windows.Forms.ColumnHeader Abfahrtszeit;
        private System.Windows.Forms.ColumnHeader Gleis;
        private System.Windows.Forms.ColumnHeader Dauer;
        private System.Windows.Forms.Button btn_Switch;
    }
}

