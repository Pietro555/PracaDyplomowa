using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDyplomowa
{
    public partial class Form2 : Form
    {
        List<Component> procesory = new List<Component>();
        List<Component> kartyGraficzne = new List<Component>();
        List<Component> dyski = new List<Component>();
        List<Component> ramy = new List<Component>();
        private Component p = null;
        private Component g = null;
        private Component r = null;
        private Component d = null;
        private int pPostition;
        private int gPostition;
        private int rPostition;
        private int dPostition;

        private Form1 fm1 = null;

        public bool klawiaturaConnect = false;
        public bool MonitorConnect = false;

        public Form2(Form1 f)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(GradientBackground);

            fm1 = f;

            Component intelCore = new Component("Intel core", "Specyfikacje intel cora", "Intel", Properties.Resources.intelcore);
            Component amdRyzen = new Component("AMD ryzen", "Specyfikacje AMD ryzena", "AMD", Properties.Resources.amdRyzen);
            procesory.Add(intelCore);
            procesory.Add(amdRyzen);

            foreach(Component c in procesory)
            {
                comboBoxProcesor.Items.Add(c.ToString());
            }

            Component geforceRTX = new Component("RTX", "Specyfikacje RTXa", "Nvidia", Properties.Resources.rtx);
            Component AmdRadeon = new Component("AMD radeon", "Specyfikacje radeona", "AMD", Properties.Resources.radeon);
            kartyGraficzne.Add(geforceRTX);
            kartyGraficzne.Add(AmdRadeon);

            foreach (Component c in kartyGraficzne)
            {
                comboBoxGrafa.Items.Add(c.ToString());
            }

            Component hdd = new Component("HDD", "Specyfikacje HDD", "Toshiba", Properties.Resources.hdd);
            Component ssd = new Component("SSD", "Specyfikacje SSD", "Western Digital", Properties.Resources.ssd);
            dyski.Add(hdd);
            dyski.Add(ssd);

            foreach (Component c in dyski)
            {
                comboBoxDysk.Items.Add(c.ToString());
            }

            Component furyBeast = new Component("RAM Fury Beast", "Specyfikacje fury beast", "Kingston", Properties.Resources.ramfury);
            Component vengance = new Component("RAM Vengeance", "Specyfikacje vengena", "Corsair", Properties.Resources.vegence);
            ramy.Add(furyBeast);
            ramy.Add(vengance);
            
            foreach(Component c in ramy)
            {
                comboBoxRAM.Items.Add(c.ToString());
            }

            this.Invalidate();
        }

        //background gradient
        private void GradientBackground(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle gradientRect = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRect,  Color.FromArgb(130, 250, 150), Color.FromArgb(110, 110, 110), 1f);


            g.FillRectangle(b, gradientRect);
        }

        //accept button
        private void buttonAkceptuj_Click(object sender, EventArgs e)
        {
            //Send compontents form Form2 to Form1, and set position of compontent in combobox in Form2
                pPostition = comboBoxProcesor.SelectedIndex;
            if(pPostition != -1)
                p = procesory.ElementAt(pPostition);
                            
                gPostition = comboBoxGrafa.SelectedIndex;
                if (gPostition != -1)
                g = kartyGraficzne.ElementAt(gPostition);

                rPostition = comboBoxRAM.SelectedIndex;
                if (rPostition != -1)
                r = ramy.ElementAt(rPostition);

                dPostition = comboBoxDysk.SelectedIndex;
            if (dPostition != -1)
                d = dyski.ElementAt(dPostition);

            fm1.LoadFromForm2(p, g, r, d);

            //Send monitor status and keyboard status from Form2 to Form1
            fm1.turnMonitorAndKeyboard(MonitorConnect,klawiaturaConnect);
            fm1.KabelChange(MonitorConnect);
            this.Close();
        }

        //back button
        private void buttonWstecz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //change image in combobox for Procesor
        private void comboBoxProcesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProcesor.SelectedIndex != -1)
            {
                int index = comboBoxProcesor.SelectedIndex;
                pictureBoxProcesor.Image = procesory.ElementAt(index).zdjecie;
            }
            else
                pictureBoxProcesor.Image = null;

        }

        //change image in combobox for Karta Graficzna
        private void comboBoxGrafa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGrafa.SelectedIndex != -1)
            {
                int index = comboBoxGrafa.SelectedIndex;
                pictureBoxKartaGraf.Image = kartyGraficzne.ElementAt(index).zdjecie;
            }
            else
                pictureBoxKartaGraf.Image = null;
        }

        //change image in combobox for Ram
        private void comboBoxRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRAM.SelectedIndex != -1)
            {
                int index = comboBoxRAM.SelectedIndex;
                pictureBoxRam.Image = ramy.ElementAt(index).zdjecie;
            }
            else
                pictureBoxRam.Image = null;

        }

        //change image in combobox for Dysk pamieci
        private void comboBoxDysk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDysk.SelectedIndex != -1)
            {
                int index = comboBoxDysk.SelectedIndex;
                pictureBoxDysk.Image = dyski.ElementAt(index).zdjecie;
            }
            else
                pictureBoxDysk.Image = null;
        }

        //button clear
        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            comboBoxProcesor.SelectedIndex = -1;
            comboBoxGrafa.SelectedIndex = -1;
            comboBoxRAM.SelectedIndex = -1;
            comboBoxDysk.SelectedIndex = -1;
        }

        //load keyboard status from Form2
        private void labelPoloczenieKlawiatura_Click(object sender, EventArgs e)
        {
            if(klawiaturaConnect == false)
            {
                labelKlawiaturaConnect.Text = "Podłączono";
                labelKlawiaturaConnect.BackColor = Color.Green;
                klawiaturaConnect = true;
            }
            else
            {
                labelKlawiaturaConnect.Text = "Odłączono";
                labelKlawiaturaConnect.BackColor = Color.Red;
                klawiaturaConnect = false;
            }
        }

        //load monitor status from Form2
        private void labelMonitorConnect_Click(object sender, EventArgs e)
        {
            if (MonitorConnect == false)
            {
                labelMonitorConnect.Text = "Podłączono";
                labelMonitorConnect.BackColor = Color.Green;
                MonitorConnect = true;
            }
            else
            {
                labelMonitorConnect.Text = "Odłączono";
                labelMonitorConnect.BackColor = Color.Red;
                MonitorConnect = false;
            }
        }

        //load on start components and monitor status and keyboard status
        private void Form2_Load(object sender, EventArgs e)
        {
            if (fm1.procesor != null)
                comboBoxProcesor.SelectedIndex = comboBoxProcesor.FindStringExact(fm1.procesor.nazwa);


            if (fm1.kartaGraficzna != null)
                comboBoxGrafa.SelectedIndex = comboBoxGrafa.FindStringExact(fm1.kartaGraficzna.nazwa);


            if (fm1.dysk != null)
                comboBoxDysk.SelectedIndex = comboBoxDysk.FindStringExact(fm1.dysk.nazwa);


            if (fm1.ram != null)
                comboBoxRAM.SelectedIndex = comboBoxRAM.FindStringExact(fm1.ram.nazwa);

            klawiaturaConnect = fm1.IsKlawiatura;
            if (klawiaturaConnect)
            {
                labelKlawiaturaConnect.Text = "Podłączono";
                labelKlawiaturaConnect.BackColor = Color.Green;
                klawiaturaConnect = true;
            }

            MonitorConnect = fm1.IsMonitor;
            if(MonitorConnect)
            {
                labelMonitorConnect.Text = "Podłączono";
                labelMonitorConnect.BackColor = Color.Green;
                MonitorConnect = true;
            }
        }

        private void buttonAddProcesor_Click(object sender, EventArgs e)
        {
            Form3Procesor form3 = new Form3Procesor(this);
            form3.ShowDialog();
        }
    }
}
