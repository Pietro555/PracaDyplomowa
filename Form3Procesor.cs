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
    public partial class Form3Procesor : Form
    {
        public Form3Procesor(Form2 f2)
        {
            InitializeComponent();
        }

        //set parameter on Form3 load
        private void Form3Procesor_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Wybierz zdjęcie komponentu";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
        }

        //open openFileDialog window
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            } 
        }

    }
}
