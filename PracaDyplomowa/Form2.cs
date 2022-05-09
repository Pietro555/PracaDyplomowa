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

        private Form1 fm1 = null;

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
            if (comboBoxProcesor.SelectedIndex != -1)
                p = procesory.ElementAt(comboBoxProcesor.SelectedIndex);

            if (comboBoxGrafa.SelectedIndex != -1)
                g = kartyGraficzne.ElementAt(comboBoxGrafa.SelectedIndex);

            if (comboBoxRAM.SelectedIndex != -1)
                r = ramy.ElementAt(comboBoxRAM.SelectedIndex);

            if (comboBoxDysk.SelectedIndex != -1)
                d = dyski.ElementAt(comboBoxDysk.SelectedIndex);

            fm1.LoadFromForm2(p, g, r, d);            
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
    }
}
