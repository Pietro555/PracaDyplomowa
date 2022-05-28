using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDyplomowa
{
    public partial class Form3 : Form
    {
        private Form2 fm2 = null;
        private int typ = 0;
        public Form3(Form2 f,int t)
        {
            //1-procesor 2-karta graficzna 3-ram 4-dysk pamieci
            InitializeComponent();

            fm2 = f;
            typ = t;
        }

        //Load setting for openFileDialog1 on Foem3 Load
        private void Form3_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Wybierz zdjęcie komponentu";
            openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
        }

        //load image button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        //accept button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch(typ)
                {
                    case(1):
                        {
                            fm2.addNewProcesor(new Component(textBox1.Text, textBox2.Text, textBox3.Text, Image.FromFile(textBox4.Text)));
                            break;
                        }
                    case (2):
                        {
                            fm2.addNewKartaGraficzna(new Component(textBox1.Text, textBox2.Text, textBox3.Text, Image.FromFile(textBox4.Text)));
                            break;
                        }
                    case (3):
                        {
                            fm2.addNewRam(new Component(textBox1.Text, textBox2.Text, textBox3.Text, Image.FromFile(textBox4.Text)));
                            break;
                        }
                    case (4):
                        {
                            fm2.addNewDysk(new Component(textBox1.Text, textBox2.Text, textBox3.Text, Image.FromFile(textBox4.Text)));
                            break;
                        }
                }  
            }
            catch (Exception error)
            {
                switch (typ)
                {
                    case (1):
                        {
                            fm2.addNewProcesor(new Component(textBox1.Text, textBox2.Text, textBox3.Text));
                            break;
                        }
                    case (2):
                        {
                            fm2.addNewKartaGraficzna(new Component(textBox1.Text, textBox2.Text, textBox3.Text));
                            break;
                        }
                    case (3):
                        {
                            fm2.addNewRam(new Component(textBox1.Text, textBox2.Text, textBox3.Text));
                            break;
                        }
                    case (4):
                        {
                            fm2.addNewDysk(new Component(textBox1.Text, textBox2.Text, textBox3.Text));
                            break;
                        }
                }
            }

            this.Close();
        }

        //back button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //change image when text in textbox change
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(textBox4.Text);

            }
            catch (Exception error)
            {
                pictureBox1.Image = null;
                Console.WriteLine(error);
            }
        }

    }
}
