
namespace PracaDyplomowa
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMonitorConnect = new System.Windows.Forms.Label();
            this.labelKlawiaturaConnect = new System.Windows.Forms.Label();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.labelKlawiatura = new System.Windows.Forms.Label();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonWstecz = new System.Windows.Forms.Button();
            this.buttonAkceptuj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxProcesor = new System.Windows.Forms.PictureBox();
            this.pictureBoxRam = new System.Windows.Forms.PictureBox();
            this.pictureBoxDysk = new System.Windows.Forms.PictureBox();
            this.pictureBoxKartaGraf = new System.Windows.Forms.PictureBox();
            this.comboBoxDysk = new System.Windows.Forms.ComboBox();
            this.labelDysk = new System.Windows.Forms.Label();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.labelRAM = new System.Windows.Forms.Label();
            this.comboBoxGrafa = new System.Windows.Forms.ComboBox();
            this.labelKartaGraficzna = new System.Windows.Forms.Label();
            this.comboBoxProcesor = new System.Windows.Forms.ComboBox();
            this.labelProcesor = new System.Windows.Forms.Label();
            this.PictureBoxComputerBySide = new System.Windows.Forms.PictureBox();
            this.buttonAddProcesor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDysk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKartaGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxComputerBySide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAddProcesor);
            this.panel1.Controls.Add(this.labelMonitorConnect);
            this.panel1.Controls.Add(this.labelKlawiaturaConnect);
            this.panel1.Controls.Add(this.labelMonitor);
            this.panel1.Controls.Add(this.labelKlawiatura);
            this.panel1.Controls.Add(this.buttonWyczysc);
            this.panel1.Controls.Add(this.buttonWstecz);
            this.panel1.Controls.Add(this.buttonAkceptuj);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBoxDysk);
            this.panel1.Controls.Add(this.labelDysk);
            this.panel1.Controls.Add(this.comboBoxRAM);
            this.panel1.Controls.Add(this.labelRAM);
            this.panel1.Controls.Add(this.comboBoxGrafa);
            this.panel1.Controls.Add(this.labelKartaGraficzna);
            this.panel1.Controls.Add(this.comboBoxProcesor);
            this.panel1.Controls.Add(this.labelProcesor);
            this.panel1.Controls.Add(this.PictureBoxComputerBySide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 651);
            this.panel1.TabIndex = 0;
            // 
            // labelMonitorConnect
            // 
            this.labelMonitorConnect.AutoSize = true;
            this.labelMonitorConnect.BackColor = System.Drawing.Color.Red;
            this.labelMonitorConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMonitorConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonitorConnect.Location = new System.Drawing.Point(817, 489);
            this.labelMonitorConnect.Name = "labelMonitorConnect";
            this.labelMonitorConnect.Size = new System.Drawing.Size(85, 16);
            this.labelMonitorConnect.TabIndex = 24;
            this.labelMonitorConnect.Text = "Odłączono";
            this.labelMonitorConnect.Click += new System.EventHandler(this.labelMonitorConnect_Click);
            // 
            // labelKlawiaturaConnect
            // 
            this.labelKlawiaturaConnect.AutoSize = true;
            this.labelKlawiaturaConnect.BackColor = System.Drawing.Color.Red;
            this.labelKlawiaturaConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelKlawiaturaConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKlawiaturaConnect.Location = new System.Drawing.Point(677, 489);
            this.labelKlawiaturaConnect.Name = "labelKlawiaturaConnect";
            this.labelKlawiaturaConnect.Size = new System.Drawing.Size(85, 16);
            this.labelKlawiaturaConnect.TabIndex = 23;
            this.labelKlawiaturaConnect.Text = "Odłączono";
            this.labelKlawiaturaConnect.Click += new System.EventHandler(this.labelPoloczenieKlawiatura_Click);
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonitor.Location = new System.Drawing.Point(825, 435);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(69, 20);
            this.labelMonitor.TabIndex = 22;
            this.labelMonitor.Text = "Monitor";
            // 
            // labelKlawiatura
            // 
            this.labelKlawiatura.AutoSize = true;
            this.labelKlawiatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKlawiatura.Location = new System.Drawing.Point(676, 435);
            this.labelKlawiatura.Name = "labelKlawiatura";
            this.labelKlawiatura.Size = new System.Drawing.Size(92, 20);
            this.labelKlawiatura.TabIndex = 21;
            this.labelKlawiatura.Text = "Klawiatura";
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.BackColor = System.Drawing.Color.Transparent;
            this.buttonWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyczysc.Location = new System.Drawing.Point(730, 559);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(124, 36);
            this.buttonWyczysc.TabIndex = 20;
            this.buttonWyczysc.Text = "Wyczysc";
            this.buttonWyczysc.UseVisualStyleBackColor = false;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonWstecz
            // 
            this.buttonWstecz.BackColor = System.Drawing.Color.LightCoral;
            this.buttonWstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWstecz.Location = new System.Drawing.Point(808, 603);
            this.buttonWstecz.Name = "buttonWstecz";
            this.buttonWstecz.Size = new System.Drawing.Size(124, 36);
            this.buttonWstecz.TabIndex = 19;
            this.buttonWstecz.Text = "Wstecz";
            this.buttonWstecz.UseVisualStyleBackColor = false;
            this.buttonWstecz.Click += new System.EventHandler(this.buttonWstecz_Click);
            // 
            // buttonAkceptuj
            // 
            this.buttonAkceptuj.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAkceptuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAkceptuj.Location = new System.Drawing.Point(658, 603);
            this.buttonAkceptuj.Name = "buttonAkceptuj";
            this.buttonAkceptuj.Size = new System.Drawing.Size(124, 36);
            this.buttonAkceptuj.TabIndex = 18;
            this.buttonAkceptuj.Text = "Akceptuj";
            this.buttonAkceptuj.UseVisualStyleBackColor = false;
            this.buttonAkceptuj.Click += new System.EventHandler(this.buttonAkceptuj_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxProcesor);
            this.panel2.Controls.Add(this.pictureBoxRam);
            this.panel2.Controls.Add(this.pictureBoxDysk);
            this.panel2.Controls.Add(this.pictureBoxKartaGraf);
            this.panel2.Location = new System.Drawing.Point(36, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 544);
            this.panel2.TabIndex = 17;
            // 
            // pictureBoxProcesor
            // 
            this.pictureBoxProcesor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProcesor.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxProcesor.Name = "pictureBoxProcesor";
            this.pictureBoxProcesor.Size = new System.Drawing.Size(255, 226);
            this.pictureBoxProcesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcesor.TabIndex = 10;
            this.pictureBoxProcesor.TabStop = false;
            // 
            // pictureBoxRam
            // 
            this.pictureBoxRam.Location = new System.Drawing.Point(252, 292);
            this.pictureBoxRam.Name = "pictureBoxRam";
            this.pictureBoxRam.Size = new System.Drawing.Size(234, 214);
            this.pictureBoxRam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRam.TabIndex = 13;
            this.pictureBoxRam.TabStop = false;
            // 
            // pictureBoxDysk
            // 
            this.pictureBoxDysk.Location = new System.Drawing.Point(252, 25);
            this.pictureBoxDysk.Name = "pictureBoxDysk";
            this.pictureBoxDysk.Size = new System.Drawing.Size(234, 226);
            this.pictureBoxDysk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDysk.TabIndex = 12;
            this.pictureBoxDysk.TabStop = false;
            // 
            // pictureBoxKartaGraf
            // 
            this.pictureBoxKartaGraf.Location = new System.Drawing.Point(0, 292);
            this.pictureBoxKartaGraf.Name = "pictureBoxKartaGraf";
            this.pictureBoxKartaGraf.Size = new System.Drawing.Size(255, 214);
            this.pictureBoxKartaGraf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKartaGraf.TabIndex = 11;
            this.pictureBoxKartaGraf.TabStop = false;
            // 
            // comboBoxDysk
            // 
            this.comboBoxDysk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDysk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDysk.FormattingEnabled = true;
            this.comboBoxDysk.Location = new System.Drawing.Point(636, 372);
            this.comboBoxDysk.Name = "comboBoxDysk";
            this.comboBoxDysk.Size = new System.Drawing.Size(258, 24);
            this.comboBoxDysk.TabIndex = 8;
            this.comboBoxDysk.SelectedIndexChanged += new System.EventHandler(this.comboBoxDysk_SelectedIndexChanged);
            // 
            // labelDysk
            // 
            this.labelDysk.AutoSize = true;
            this.labelDysk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDysk.Location = new System.Drawing.Point(730, 343);
            this.labelDysk.Name = "labelDysk";
            this.labelDysk.Size = new System.Drawing.Size(115, 20);
            this.labelDysk.TabIndex = 7;
            this.labelDysk.Text = "Dysk Pamięci";
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Location = new System.Drawing.Point(633, 259);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(261, 24);
            this.comboBoxRAM.TabIndex = 6;
            this.comboBoxRAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAM_SelectedIndexChanged);
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRAM.Location = new System.Drawing.Point(764, 223);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(48, 20);
            this.labelRAM.TabIndex = 5;
            this.labelRAM.Text = "RAM";
            // 
            // comboBoxGrafa
            // 
            this.comboBoxGrafa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxGrafa.FormattingEnabled = true;
            this.comboBoxGrafa.Location = new System.Drawing.Point(633, 147);
            this.comboBoxGrafa.Name = "comboBoxGrafa";
            this.comboBoxGrafa.Size = new System.Drawing.Size(261, 24);
            this.comboBoxGrafa.TabIndex = 4;
            this.comboBoxGrafa.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrafa_SelectedIndexChanged);
            // 
            // labelKartaGraficzna
            // 
            this.labelKartaGraficzna.AutoSize = true;
            this.labelKartaGraficzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKartaGraficzna.Location = new System.Drawing.Point(726, 115);
            this.labelKartaGraficzna.Name = "labelKartaGraficzna";
            this.labelKartaGraficzna.Size = new System.Drawing.Size(131, 20);
            this.labelKartaGraficzna.TabIndex = 3;
            this.labelKartaGraficzna.Text = "Karta graficzna";
            // 
            // comboBoxProcesor
            // 
            this.comboBoxProcesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxProcesor.FormattingEnabled = true;
            this.comboBoxProcesor.Location = new System.Drawing.Point(636, 37);
            this.comboBoxProcesor.Name = "comboBoxProcesor";
            this.comboBoxProcesor.Size = new System.Drawing.Size(258, 24);
            this.comboBoxProcesor.TabIndex = 2;
            this.comboBoxProcesor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcesor_SelectedIndexChanged);
            // 
            // labelProcesor
            // 
            this.labelProcesor.AutoSize = true;
            this.labelProcesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProcesor.Location = new System.Drawing.Point(753, 9);
            this.labelProcesor.Name = "labelProcesor";
            this.labelProcesor.Size = new System.Drawing.Size(80, 20);
            this.labelProcesor.TabIndex = 1;
            this.labelProcesor.Text = "Procesor";
            // 
            // PictureBoxComputerBySide
            // 
            this.PictureBoxComputerBySide.Image = global::PracaDyplomowa.Properties.Resources.computer_by_side;
            this.PictureBoxComputerBySide.Location = new System.Drawing.Point(-27, -14);
            this.PictureBoxComputerBySide.Name = "PictureBoxComputerBySide";
            this.PictureBoxComputerBySide.Size = new System.Drawing.Size(654, 653);
            this.PictureBoxComputerBySide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxComputerBySide.TabIndex = 0;
            this.PictureBoxComputerBySide.TabStop = false;
            // 
            // buttonAddProcesor
            // 
            this.buttonAddProcesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAddProcesor.Location = new System.Drawing.Point(901, 37);
            this.buttonAddProcesor.Name = "buttonAddProcesor";
            this.buttonAddProcesor.Size = new System.Drawing.Size(34, 23);
            this.buttonAddProcesor.TabIndex = 25;
            this.buttonAddProcesor.Text = "+";
            this.buttonAddProcesor.UseVisualStyleBackColor = true;
            this.buttonAddProcesor.Click += new System.EventHandler(this.buttonAddProcesor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(901, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(901, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 24);
            this.button2.TabIndex = 27;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(901, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 24);
            this.button3.TabIndex = 28;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 651);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edytor jednostki centralnej";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDysk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKartaGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxComputerBySide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxComputerBySide;
        private System.Windows.Forms.Label labelProcesor;
        private System.Windows.Forms.ComboBox comboBoxProcesor;
        private System.Windows.Forms.ComboBox comboBoxDysk;
        private System.Windows.Forms.Label labelDysk;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.ComboBox comboBoxGrafa;
        private System.Windows.Forms.Label labelKartaGraficzna;
        private System.Windows.Forms.PictureBox pictureBoxRam;
        private System.Windows.Forms.PictureBox pictureBoxDysk;
        private System.Windows.Forms.PictureBox pictureBoxKartaGraf;
        private System.Windows.Forms.PictureBox pictureBoxProcesor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonWstecz;
        private System.Windows.Forms.Button buttonAkceptuj;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Label labelMonitorConnect;
        private System.Windows.Forms.Label labelKlawiaturaConnect;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label labelKlawiatura;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddProcesor;
    }
}