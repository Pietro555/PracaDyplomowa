
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelProcesor = new System.Windows.Forms.Label();
            this.PictureBoxComputerBySide = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelKartaGraficzna = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelRAM = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.labelDysk = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxComputerBySide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.labelDysk);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.labelRAM);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.labelKartaGraficzna);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelProcesor);
            this.panel1.Controls.Add(this.PictureBoxComputerBySide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 651);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(707, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelProcesor
            // 
            this.labelProcesor.AutoSize = true;
            this.labelProcesor.Location = new System.Drawing.Point(765, 9);
            this.labelProcesor.Name = "labelProcesor";
            this.labelProcesor.Size = new System.Drawing.Size(49, 13);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(707, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // labelKartaGraficzna
            // 
            this.labelKartaGraficzna.AutoSize = true;
            this.labelKartaGraficzna.Location = new System.Drawing.Point(743, 77);
            this.labelKartaGraficzna.Name = "labelKartaGraficzna";
            this.labelKartaGraficzna.Size = new System.Drawing.Size(78, 13);
            this.labelKartaGraficzna.TabIndex = 3;
            this.labelKartaGraficzna.Text = "Karta graficzna";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(707, 151);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(765, 135);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(31, 13);
            this.labelRAM.TabIndex = 5;
            this.labelRAM.Text = "RAM";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(707, 208);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // labelDysk
            // 
            this.labelDysk.AutoSize = true;
            this.labelDysk.Location = new System.Drawing.Point(743, 192);
            this.labelDysk.Name = "labelDysk";
            this.labelDysk.Size = new System.Drawing.Size(71, 13);
            this.labelDysk.TabIndex = 7;
            this.labelDysk.Text = "Dysk Pamięci";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxComputerBySide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxComputerBySide;
        private System.Windows.Forms.Label labelProcesor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label labelDysk;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelKartaGraficzna;
    }
}