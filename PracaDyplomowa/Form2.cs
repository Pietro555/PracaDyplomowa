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

        public Form2()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(GradientBackground);


            Component intelCore = new Component("Intel core", "Specyfikacje intel cora", "Intel",
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\intelcore.png"));
            Component amdRyzen = new Component("AMD ryzen", "Specyfikacje AMD ryzena", "AMD", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\amdRyzen.png"));
            procesory.Add(intelCore);
            procesory.Add(amdRyzen);

            foreach(Component c in procesory)
            {
                comboBoxProcesor.Items.Add(c.ToString());
            }

            Component geforceRTX = new Component("RTX", "Specyfikacje RTXa", "Nvidia", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\rtx.png"));
            Component AmdRadeon = new Component("AMD radeon", "Specyfikacje radeona", "AMD", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\radeon.png"));
            kartyGraficzne.Add(geforceRTX);
            kartyGraficzne.Add(AmdRadeon);

            foreach (Component c in kartyGraficzne)
            {
                comboBoxGrafa.Items.Add(c.ToString());
            }

            Component hdd = new Component("HDD", "Specyfikacje HDD", "Toshiba", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\hdd.png"));
            Component ssd = new Component("SSD", "Specyfikacje SSD", "Western Digital", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\ssd.png"));
            dyski.Add(hdd);
            dyski.Add(ssd);

            foreach (Component c in dyski)
            {
                comboBoxDysk.Items.Add(c.ToString());
            }

            Component furyBeast = new Component("RAM Fury Beast", "Specyfikacje fury beast", "Kingston", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\ramfury.png"));
            Component vengance = new Component("RAM Vengeance", "Specyfikacje vengena", "Corsair", 
                Image.FromFile(@"D:\Visual Projects\PracaDyplomowa\PracaDyplomowa\Properties\Images\vegence.png"));
            ramy.Add(furyBeast);
            ramy.Add(vengance);

            foreach(Component c in ramy)
            {
                comboBoxRAM.Items.Add(c.ToString());
            }



            this.Invalidate();
        }

        private void GradientBackground(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle gradientRect = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRect, Color.FromArgb(30, 250, 50), Color.FromArgb(130, 250, 150), 1f);


            g.FillRectangle(b, gradientRect);
        }

        private void buttonDodajProcek_Click(object sender, EventArgs e)
        {
            int index = comboBoxProcesor.SelectedIndex;
            pictureBoxProcesor.Image = procesory.ElementAt(index).zdjecie;
        }

        private void buttonDodajKarteGraf_Click(object sender, EventArgs e)
        {
            int index = comboBoxGrafa.SelectedIndex;
            pictureBoxKartaGraf.Image = kartyGraficzne.ElementAt(index).zdjecie;
        }

        private void buttonDodajRam_Click(object sender, EventArgs e)
        {
            int index = comboBoxRAM.SelectedIndex;
            pictureBoxRam.Image = ramy.ElementAt(index).zdjecie;
        }

        private void buttonDodajDysk_Click(object sender, EventArgs e)
        {
            int index = comboBoxDysk.SelectedIndex;
            pictureBoxDysk.Image = dyski.ElementAt(index).zdjecie;
        }
    }
}
