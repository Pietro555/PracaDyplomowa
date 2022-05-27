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

        private static ArrayList commandList = new ArrayList();
        private static Boolean IsStarted = false;
        public bool IsKlawiatura = false;
        public bool IsMonitor = false;

        public Component procesor = null;
        public Component kartaGraficzna = null;
        public Component ram = null;
        public Component dysk = null;

        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(GradientBackground);

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

            commandList.Add(new Command("cl",
                                        "Czysci konsole",
                                        "Czysci konsole do stanu początkowego czyli samego '>'"));

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
                Form2 form2 = new Form2(this);
                form2.ShowDialog();
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
            if(IsStarted == false && CheckComputer())
            {
                IsStarted = true;
                StartButton.Enabled = false;
                
                if (IsMonitor)
                {
                    PictureboxIntro.Visible = true;
                    ProgressIntro.Visible = true;
                    ProgressIntro.BringToFront();
                }
                
                PowerLamp.BackColor = Color.Gold;
                Terminal.Text = "> ";
                CheckComputer();
                int n=1000;
                if(dysk.nazwa != null)
                {
                    if (dysk.nazwa.Equals("SSD"))
                        n = 400;
                    else
                        n = 800;
                }


            int i = 0;
            while(i < 5)
            {
                await PutTaskDelay(n);
                ProgressIntro.PerformStep();
                i++;
            }

            await PutTaskDelay(700);

                //COMPUTER ON
                PowerLamp.BackColor = Color.Lime;

                if (IsMonitor)
                {
                    PictureboxIntro.Visible = false;
                    ProgressIntro.Visible = false;
                    ProgressIntro.Value = 0;
                    Terminal.Visible = true;
                    CommandLine.Visible = true;
                    LabelCommandLane.Visible = true;
                }

                MinusSize.Enabled = true;
                PlusSize.Enabled = true;
                StartButton.Enabled = true;

                if (IsKlawiatura == false)
                    CommandLine.Enabled = false;
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


                if (CommandLine.Text.StartsWith("help"))
                {
                    foreach (Command c in commandList)
                    {
                        Terminal.AppendText(c.GetCommandName() + " - " + c.GetCommandDescription() + "\r\n");

                    }
                }
                else if (CommandLine.Text.StartsWith("man"))
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
                else if (CommandLine.Text.StartsWith("comp"))
                {
                    bool UsedP = false, UsedG = false, UsedR = false, UsedD = false;
                    string text = "";

                    if(CommandLine.Text.Equals("comp"))
                    {
                        if (procesor != null)
                            text += procesor.GetInfo() + "\r\n";
                        else
                            text += "ERROR\r\n";

                        if(kartaGraficzna != null)
                            text += kartaGraficzna.GetInfo() + "\r\n";
                        else
                            text += "ERROR\r\n";

                        if (ram != null)
                            text += ram.GetInfo() + "\r\n";
                        else
                            text += "ERROR\r\n";

                        if (dysk != null)
                            text += dysk.GetInfo() + "\r\n";
                        else
                            text += "ERROR\r\n";
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
                else if (CommandLine.Text.Equals("cl"))
                {
                    Terminal.Text = "";
                }

                Terminal.AppendText("> ");
                CommandLine.Clear();
            }
        }

        //function to load compontents from Form2
        public void LoadFromForm2(Component pprocek, Component ggrafa, Component rram,Component ddysk)
        {
            procesor = pprocek;
            kartaGraficzna = ggrafa;
            ram = rram;
            dysk = ddysk;
        }

        //function to check if everything is connected
        public bool CheckComputer()
        {
            bool goodOrNot=true;
            if (procesor == null)
                    goodOrNot = false;

            if (kartaGraficzna == null)
                    goodOrNot = false;

            if (dysk == null)
                    goodOrNot = false;

            if (ram == null)
                    goodOrNot = false;

            return goodOrNot;
        }

        //function to set monitor status and keyboard status
        public void turnMonitorAndKeyboard(bool mon, bool keyb)
        {
            IsMonitor = mon;
            IsKlawiatura = keyb;
        }

        //change visibility of monitor's cable
        public void KabelChange(bool kab)
        {
            pictureBoxKabel.Visible = kab;
        }
    }

}
