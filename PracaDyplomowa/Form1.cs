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
    public partial class Form1 : Form
    {

        private ArrayList commandList = new ArrayList();
        private Boolean IsStarted = false;
        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(GradientBackground);
            Terminal.AppendText("> ");
            commandList.Add(new Command("help", "Wyswietla wszystkie zaimplementowane komendy w TestOS"));

            this.Invalidate();

        }

        //Gradient for From1 Background
        private void GradientBackground(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle gradientRect = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRect, Color.FromArgb(0, 214, 136), Color.FromArgb( 0, 83, 224), 1f);
            

            g.FillRectangle(b, gradientRect);
        }

        //Open edit window
        private void EditButton_Click(object sender, EventArgs e)
        {
            if(IsStarted == false)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        //make font bigger in terminal
        private void PlusSize_Click(object sender, EventArgs e)
        {
            float currentSize = Terminal.Font.Size;
            if(currentSize < 24.0)
            {
                currentSize += 2.0F;
                Terminal.Font = new Font(Terminal.Font.Name, currentSize, Terminal.Font.Style);
            }
        }


        //make font smaller in terminal
        private void MinusSize_Click(object sender, EventArgs e)
        {
            
            float currentSize = Terminal.Font.Size;

            if(currentSize > 10)
            {
                currentSize -= 2.0F;

                Terminal.Font = new Font(Terminal.Font.Name, currentSize, Terminal.Font.Style);
            }
        }

        //start computer
        private async void StartButton_Click(object sender, EventArgs e)
        {
            if(IsStarted == false)
            {
                IsStarted = true;
                StartButton.Enabled = false;
                PictureboxIntro.Visible = true;
                ProgressIntro.Visible = true;
                PowerLamp.BackColor = Color.Gold;
                ProgressIntro.BringToFront();
            
            int i = 0;
            while(i < 5)
            {
                await PutTaskDelay(500);
                ProgressIntro.PerformStep();
                i++;
            }

            await PutTaskDelay(700);

                //COMPUTER ON
                PowerLamp.BackColor = Color.Lime;
                PictureboxIntro.Visible = false;
                ProgressIntro.Visible = false;
                ProgressIntro.Value = 0;
                MinusSize.Enabled = true;
                PlusSize.Enabled = true;
                Terminal.Visible = true;
                CommandLine.Visible = true;
                LabelCommandLane.Visible = true;
                StartButton.Enabled = true;
            }
            else
            {
                StartButton.Enabled = false;
                Terminal.Visible = false;
                CommandLine.Visible = false;
                PowerLamp.BackColor = Color.Maroon;
                MinusSize.Enabled = false;
                PlusSize.Enabled = false;
                LabelCommandLane.Visible = false;
                IsStarted = false;
                StartButton.Enabled = true;
            }

        }

        //function for waiting
        async Task PutTaskDelay(int n)
        {
            await Task.Delay(n);
        }

        //console and commands
        private void CommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && CommandLine.TextLength != 0)
            {

                e.SuppressKeyPress = true;
                Terminal.AppendText(CommandLine.Text + "\r\n");


                if (CommandLine.Text.Equals("help"))
                {
                    foreach (Command c in commandList)
                    {
                        Terminal.AppendText(c.GetCommandName() + " - " + c.GetCommandDescription() + "\r\n");

                    }
                }
                Terminal.AppendText("> ");
                CommandLine.Clear();
            }
        }

    }



    public class Command
    {
        private readonly string commandName, commandDescription;

        public Command(string commandName, string commandDescription)
        {
            this.commandName = commandName;
            this.commandDescription = commandDescription;
        }

        public string GetCommandName()
        {
            return this.commandName;
        }

        public string GetCommandDescription()
        {
            return this.commandDescription;
        }
    }

    public class Komputer
    {

    }

}
