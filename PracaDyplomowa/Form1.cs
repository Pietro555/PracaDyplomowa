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

        public Component procesor;
        public Component kartaGraficzna;
        public Component ram;
        public Component dysk;

        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(GradientBackground);
            Terminal.AppendText("> ");

            //---------------------------------------------------------------------------------------
            //Add commands here

            commandList.Add(new Command("help", 
                                        "Wyswietla wszystkie zaimplementowane komendy",
                                        "Wyswietla liste wszystkich dostępnych funkcji konsolowych w TestOS\r\n" +
                                        "\r\nPrzykład:\r\n help"));

            commandList.Add(new Command("man", 
                                        "Wyswietl instrukcje o funkcji",
                                        "Wyswietl instrukcje dołączoną do funkcji\r\n" +
                                        "\r\nPrzykład:\r\n man <nazwa_funkcji>"));

            commandList.Add(new Command("comp", 
                                        "Wyswietla informacje o komponęcie lub komponętach komputera",
                                        "Wyswietla informacje o procesorze, karcie graficznej, RAM-ie i  dysku pamięci" +
                                        "z możliwością wyświetlenia informacji o konkretnym komponęcie komputera\r\n" +
                                        "\r\nPrzykład:\r\n comp\r\n comp <-p || -g || -r || -d>\r\n" +
                                        "\r\nLegenda:\r\n p - informacje o procesorze\r\n g - informacje o karcie graficznej\r\n" +
                                        " r - informacje o kościach RAM\r\n d - informacje o dysku pamięci"));

            //---------------------------------------------------------------------------------------


            this.Invalidate();
        }

        //Gradient for From1 Background
        private void GradientBackground(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle gradientRect = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRect, Color.FromArgb(115, 191, 132), Color.FromArgb(45, 125, 65), 1f);
            

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


                if (CommandLine.Text.Contains("help"))
                {
                    foreach (Command c in commandList)
                    {
                        Terminal.AppendText(c.GetCommandName() + " - " + c.GetCommandDescription() + "\r\n");

                    }
                }
                else if (CommandLine.Text.Contains("man"))
                {
                    foreach (Command c in commandList)
                    {
                        if (CommandLine.Text.Equals("man " + c.GetCommandName()))
                        {
                            Terminal.AppendText(c.GetCommandName() + " - " + c.GetAdvancedDescription() + "\r\n");
                            break;
                        }

                    }
                }
                else if (CommandLine.Text.Contains("comp"))
                {
                    bool UsedP = false, UsedG = false, UsedR = false, UsedD = false;
                    string text = "";

                    if(CommandLine.Text.Equals("comp") && procesor != null && kartaGraficzna != null &&
                                                               ram != null &&           dysk != null    )
                    {
                        text += procesor.GetInfo() + "\r\n";
                        text += kartaGraficzna.GetInfo() + "\r\n";
                        text += ram.GetInfo() + "\r\n";
                        text += dysk.GetInfo() + "\r\n";
                    }

                    if(CommandLine.Text.Contains("-p") && UsedP == false && procesor != null)
                    {
                        UsedP = true;
                        text += procesor.GetInfo() + "\r\n";
                    }

                    if (CommandLine.Text.Contains("-g") && UsedG == false && kartaGraficzna != null)
                    {
                        UsedG = true;
                        text += kartaGraficzna.GetInfo() + "\r\n";
                    }

                    if (CommandLine.Text.Contains("-r") && UsedR == false && ram != null)
                    {
                        UsedR = true;
                        text += ram.GetInfo() + "\r\n";
                    }

                    if (CommandLine.Text.Contains("-d") && UsedD == false && dysk != null)
                    {
                        UsedD = true;
                        text += dysk.GetInfo() + "\r\n";
                    }

                    Terminal.AppendText(text);
                }

                Terminal.AppendText("> ");
                CommandLine.Clear();
            }
        }

    }

}
