using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDyplomowa
{
    public partial class Form2 : Form
    {

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
                p = fm1.procesory.ElementAt(pPostition);
                            
                gPostition = comboBoxGrafa.SelectedIndex;
                if (gPostition != -1)
                g = fm1.kartyGraficzne.ElementAt(gPostition);

                rPostition = comboBoxRAM.SelectedIndex;
                if (rPostition != -1)
                r = fm1.ramy.ElementAt(rPostition);

                dPostition = comboBoxDysk.SelectedIndex;
            if (dPostition != -1)
                d = fm1.dyski.ElementAt(dPostition);

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
                pictureBoxProcesor.Image = fm1.procesory.ElementAt(index).zdjecie;
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
                pictureBoxKartaGraf.Image = fm1.kartyGraficzne.ElementAt(index).zdjecie;
            }
            else
                pictureBoxKartaGraf.Image = null;
        }

        //change image in combobox for Ram
        private void comboBoxRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRAM.SelectedIndex != -1)
            {
                pictureBoxRam1.Image = Properties.Resources.ram;
                pictureBoxRam2.Image = Properties.Resources.ram;
            }
            else
            {
                pictureBoxRam1.Image = null;
                pictureBoxRam2.Image = null;
            }

        }

        //change image in combobox for Dysk pamieci
        private void comboBoxDysk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDysk.SelectedIndex != -1)
            {
                int index = comboBoxDysk.SelectedIndex;
                pictureBoxDysk.Image = fm1.dyski.ElementAt(index).zdjecie;
            }
            else
                pictureBoxDysk.Image = null;
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

        //load components, monitor status and keyboard status
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Component c in fm1.procesory)
            {
                comboBoxProcesor.Items.Add(c.ToString());
            }

            foreach (Component c in fm1.kartyGraficzne)
            {
                comboBoxGrafa.Items.Add(c.ToString());
            }


            foreach (Component c in fm1.dyski)
            {
                comboBoxDysk.Items.Add(c.ToString());
            }

            foreach (Component c in fm1.ramy)
            {
                comboBoxRAM.Items.Add(c.ToString());
            }

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

        //open form3 to add procesor
        private void buttonAddProcesor_Click(object sender, EventArgs e)
        {
            Form3 form3p = new Form3(this,1);
            form3p.ShowDialog();
        }

        //open form3 to add kartaGraficzna
        private void buttonAddKartaGraficzna_Click(object sender, EventArgs e)
        {
            Form3 form3g = new Form3(this,2);
            form3g.ShowDialog();
        }

        //open form3 to add Ram
        private void buttonAddRam_Click(object sender, EventArgs e)
        {
            Form3 form3r = new Form3(this,3);
            form3r.ShowDialog();
        }

        //open form3 to add hard drive
        private void buttonAddDysk_Click(object sender, EventArgs e)
        {
            Form3 form3d = new Form3(this, 4);
            form3d.ShowDialog();
        }

        private void pictureBoxDysk_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("To jest dysk",pictureBoxDysk);
        }

        //delete procesor
        private void buttonDeleteProcesor_Click(object sender, EventArgs e)
        {
            comboBoxProcesor.SelectedIndex = -1;
        }

        //delete graphic card
        private void buttonDeleteKartaGraficzna_Click(object sender, EventArgs e)
        {
            comboBoxGrafa.SelectedIndex = -1;
        }

        //delete ram
        private void buttonDeleteRam_Click(object sender, EventArgs e)
        {
            comboBoxRAM.SelectedIndex = -1;
        }

        //delete hard drive
        private void buttonDeleteDysk_Click(object sender, EventArgs e)
        {
            comboBoxDysk.SelectedIndex = -1;
        }

        //Function for Form3 to add new cpu
        public void addNewProcesor(Component c)
        {
            fm1.procesory.Add(c);
            comboBoxProcesor.Items.Add(c.ToString());
        }

        //Function for Form3 to add new gpu
        public void addNewKartaGraficzna(Component c)
        {
            fm1.kartyGraficzne.Add(c);
            comboBoxGrafa.Items.Add(c.ToString());
        }

        //Function for Form3 to add new ram
        public void addNewRam(Component c)
        {
            fm1.ramy.Add(c);
            comboBoxRAM.Items.Add(c.ToString());
        }

        //Function for Form3 to add new hard drive
        public void addNewDysk(Component c)
        {
            fm1.dyski.Add(c);
            comboBoxDysk.Items.Add(c.ToString());
        }

        //saveing configuration
        private void buttonZapiszDoPliku_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = "", location = folderBrowserDialog1.SelectedPath; ;

                if (comboBoxProcesor.SelectedIndex != -1 && fm1.procesory.ElementAt(comboBoxProcesor.SelectedIndex) != null)
                    text += fm1.procesory.ElementAt(comboBoxProcesor.SelectedIndex).GetInfo();
                else
                    text += "Empty";

                text += "\n";

                if (comboBoxGrafa.SelectedIndex != -1 && fm1.kartyGraficzne.ElementAt(comboBoxGrafa.SelectedIndex) != null)
                    text += fm1.kartyGraficzne.ElementAt(comboBoxGrafa.SelectedIndex).GetInfo();
                else
                    text += "Empty";

                text += "\n";

                if (comboBoxRAM.SelectedIndex != -1 && fm1.ramy.ElementAt(comboBoxRAM.SelectedIndex) != null)
                    text += fm1.ramy.ElementAt(comboBoxRAM.SelectedIndex).GetInfo();
                else
                    text += "Empty";

                text += "\n";

                if (comboBoxDysk.SelectedIndex != -1 && fm1.dyski.ElementAt(comboBoxDysk.SelectedIndex) != null)
                    text += fm1.dyski.ElementAt(comboBoxDysk.SelectedIndex).GetInfo();
                else
                    text += "Empty";

                File.WriteAllText(location + "\\dane.txt", text);

                if (comboBoxProcesor.SelectedIndex != -1 && fm1.procesory.ElementAt(comboBoxProcesor.SelectedIndex).zdjecie != null)
                {
                    File.Delete(location + "\\procesor.png");
                    fm1.procesory.ElementAt(comboBoxProcesor.SelectedIndex).zdjecie.Save(location + "\\procesor.png");
                }
                else
                {
                    try
                    {
                        File.Delete(location + "\\procesor.png");
                    }
                    catch(FileNotFoundException)
                    { }
                    
                }
                    

                if (comboBoxGrafa.SelectedIndex != -1 && fm1.kartyGraficzne.ElementAt(comboBoxGrafa.SelectedIndex).zdjecie != null)
                {
                    File.Delete(location + "\\karta_graficzna.png");
                    fm1.kartyGraficzne.ElementAt(comboBoxGrafa.SelectedIndex).zdjecie.Save(location + "\\karta_graficzna.png");
                }
                else
                {
                    try
                    {
                        File.Delete(location + "\\karta_graficzna.png");
                    }
                    catch (FileNotFoundException)
                    { }

                }

                if (comboBoxRAM.SelectedIndex != -1 && fm1.ramy.ElementAt(comboBoxRAM.SelectedIndex).zdjecie != null)
                {
                    File.Delete(location + "\\ram.png");
                    fm1.ramy.ElementAt(comboBoxRAM.SelectedIndex).zdjecie.Save(location + "\\ram.png");
                }
                else
                {
                    try
                    {
                        File.Delete(location + "\\ram.png");
                    }
                    catch (FileNotFoundException)
                    { }

                }

                if (comboBoxDysk.SelectedIndex != -1 && fm1.dyski.ElementAt(comboBoxDysk.SelectedIndex).zdjecie != null)
                {
                    File.Delete(location + "\\dysk.png");
                    fm1.dyski.ElementAt(comboBoxDysk.SelectedIndex).zdjecie.Save(location + "\\dysk.png");
                }
                else
                {
                    try
                    {
                        File.Delete(location + "\\dysk.png");
                    }
                    catch (FileNotFoundException)
                    { }

                }
            }
        }

        //load configuraiton from folder
        private void buttonWczytajZPliku_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string l = folderBrowserDialog1.SelectedPath;
                string[] linie = File.ReadAllLines(l+ "//dane.txt");
                string[] dane;

                //procesor
                dane = linie[0].Split(';');
                if (dane.Length != 1)
                {
                    if (!(comboBoxProcesor.Items.Contains(dane[0])))
                    {
                        try
                        {
                            fm1.procesory.Add(new Component(dane[0], dane[1], dane[2], Image.FromFile(l + "//procesor.png")));
                        }
                        catch (FileNotFoundException)
                        {
                            fm1.procesory.Add(new Component(dane[0], dane[1], dane[2]));
                        }
                    }
                    comboBoxProcesor.SelectedIndex = comboBoxProcesor.FindStringExact(dane[0]);
                }


                //karta graficzna
                dane = linie[1].Split(';');
                if (dane.Length != 1)
                {
                    if (!(comboBoxGrafa.Items.Contains(dane[0])))
                    {
                        try
                        {
                            fm1.kartyGraficzne.Add(new Component(dane[0], dane[1], dane[2], Image.FromFile(l + "//karta_graficzna.png")));
                        }
                        catch (FileNotFoundException)
                        {
                            fm1.kartyGraficzne.Add(new Component(dane[0], dane[1], dane[2]));
                        }
                    }
                    comboBoxGrafa.SelectedIndex = comboBoxGrafa.FindStringExact(dane[0]);
                }

                //ram
                dane = linie[2].Split(';');
                if (dane.Length != 1)
                {
                    if (!(comboBoxRAM.Items.Contains(dane[0])))
                    {
                        try
                        {
                            fm1.ramy.Add(new Component(dane[0], dane[1], dane[2], Image.FromFile(l + "//ram.png")));
                        }
                        catch (FileNotFoundException)
                        {
                            fm1.ramy.Add(new Component(dane[0], dane[1], dane[2]));
                        }
                    }
                    comboBoxRAM.SelectedIndex = comboBoxRAM.FindStringExact(dane[0]);
                }

                //dysk
                dane = linie[3].Split(';');
                if (dane.Length > 1)
                {
                    if (!(comboBoxDysk.Items.Contains(dane[0])))
                    {
                        try
                        {
                            fm1.dyski.Add(new Component(dane[0], dane[1], dane[2], Image.FromFile(l + "//dysk.png")));
                        }
                        catch (FileNotFoundException)
                        {
                            fm1.dyski.Add(new Component(dane[0], dane[1], dane[2]));
                        }
                    }
                    comboBoxDysk.SelectedIndex = comboBoxDysk.FindStringExact(dane[0]);
                }
            }
        }
    }
}
