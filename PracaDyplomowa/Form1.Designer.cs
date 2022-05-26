
namespace PracaDyplomowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelComputer = new System.Windows.Forms.Panel();
            this.PowerLamp = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.PictureBox();
            this.Computer = new System.Windows.Forms.PictureBox();
            this.PanelMonitor = new System.Windows.Forms.Panel();
            this.pictureBoxKabel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressIntro = new System.Windows.Forms.ProgressBar();
            this.PictureboxIntro = new System.Windows.Forms.PictureBox();
            this.MinusSize = new System.Windows.Forms.Button();
            this.PlusSize = new System.Windows.Forms.Button();
            this.Terminal = new System.Windows.Forms.TextBox();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.LabelCommandLane = new System.Windows.Forms.Label();
            this.Monitor = new System.Windows.Forms.PictureBox();
            this.PanelComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).BeginInit();
            this.PanelMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxIntro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelComputer
            // 
            this.PanelComputer.BackColor = System.Drawing.Color.Transparent;
            this.PanelComputer.Controls.Add(this.PowerLamp);
            this.PanelComputer.Controls.Add(this.StartButton);
            this.PanelComputer.Controls.Add(this.EditButton);
            this.PanelComputer.Controls.Add(this.Computer);
            this.PanelComputer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelComputer.Location = new System.Drawing.Point(0, 0);
            this.PanelComputer.Name = "PanelComputer";
            this.PanelComputer.Size = new System.Drawing.Size(289, 647);
            this.PanelComputer.TabIndex = 0;
            // 
            // PowerLamp
            // 
            this.PowerLamp.BackColor = System.Drawing.Color.Maroon;
            this.PowerLamp.Location = new System.Drawing.Point(129, 170);
            this.PowerLamp.Name = "PowerLamp";
            this.PowerLamp.Size = new System.Drawing.Size(33, 27);
            this.PowerLamp.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Black;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(69, 282);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(144, 43);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "START";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(102, 399);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(82, 39);
            this.EditButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditButton.TabIndex = 1;
            this.EditButton.TabStop = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Computer
            // 
            this.Computer.BackColor = System.Drawing.Color.Transparent;
            this.Computer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Computer.Image = global::PracaDyplomowa.Properties.Resources.Desktop_Computer;
            this.Computer.Location = new System.Drawing.Point(0, 0);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(289, 647);
            this.Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Computer.TabIndex = 0;
            this.Computer.TabStop = false;
            // 
            // PanelMonitor
            // 
            this.PanelMonitor.BackColor = System.Drawing.Color.Transparent;
            this.PanelMonitor.Controls.Add(this.pictureBoxKabel);
            this.PanelMonitor.Controls.Add(this.label1);
            this.PanelMonitor.Controls.Add(this.ProgressIntro);
            this.PanelMonitor.Controls.Add(this.PictureboxIntro);
            this.PanelMonitor.Controls.Add(this.MinusSize);
            this.PanelMonitor.Controls.Add(this.PlusSize);
            this.PanelMonitor.Controls.Add(this.Terminal);
            this.PanelMonitor.Controls.Add(this.CommandLine);
            this.PanelMonitor.Controls.Add(this.LabelCommandLane);
            this.PanelMonitor.Controls.Add(this.Monitor);
            this.PanelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMonitor.Location = new System.Drawing.Point(289, 0);
            this.PanelMonitor.Name = "PanelMonitor";
            this.PanelMonitor.Size = new System.Drawing.Size(651, 647);
            this.PanelMonitor.TabIndex = 1;
            // 
            // pictureBoxKabel
            // 
            this.pictureBoxKabel.Image = global::PracaDyplomowa.Properties.Resources.kabel;
            this.pictureBoxKabel.Location = new System.Drawing.Point(0, 511);
            this.pictureBoxKabel.Name = "pictureBoxKabel";
            this.pictureBoxKabel.Size = new System.Drawing.Size(156, 149);
            this.pictureBoxKabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKabel.TabIndex = 8;
            this.pictureBoxKabel.TabStop = false;
            this.pictureBoxKabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(287, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // ProgressIntro
            // 
            this.ProgressIntro.Location = new System.Drawing.Point(252, 355);
            this.ProgressIntro.Name = "ProgressIntro";
            this.ProgressIntro.Size = new System.Drawing.Size(143, 23);
            this.ProgressIntro.Step = 20;
            this.ProgressIntro.TabIndex = 6;
            this.ProgressIntro.Visible = false;
            // 
            // PictureboxIntro
            // 
            this.PictureboxIntro.Image = global::PracaDyplomowa.Properties.Resources.TestOS;
            this.PictureboxIntro.Location = new System.Drawing.Point(9, 12);
            this.PictureboxIntro.Name = "PictureboxIntro";
            this.PictureboxIntro.Size = new System.Drawing.Size(634, 413);
            this.PictureboxIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureboxIntro.TabIndex = 5;
            this.PictureboxIntro.TabStop = false;
            this.PictureboxIntro.Visible = false;
            // 
            // MinusSize
            // 
            this.MinusSize.Enabled = false;
            this.MinusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinusSize.Location = new System.Drawing.Point(261, 449);
            this.MinusSize.Name = "MinusSize";
            this.MinusSize.Size = new System.Drawing.Size(46, 40);
            this.MinusSize.TabIndex = 4;
            this.MinusSize.Text = "-";
            this.MinusSize.UseVisualStyleBackColor = true;
            this.MinusSize.Click += new System.EventHandler(this.MinusSize_Click);
            // 
            // PlusSize
            // 
            this.PlusSize.Enabled = false;
            this.PlusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlusSize.Location = new System.Drawing.Point(349, 449);
            this.PlusSize.Name = "PlusSize";
            this.PlusSize.Size = new System.Drawing.Size(46, 40);
            this.PlusSize.TabIndex = 3;
            this.PlusSize.Text = "+";
            this.PlusSize.UseVisualStyleBackColor = true;
            this.PlusSize.Click += new System.EventHandler(this.PlusSize_Click);
            // 
            // Terminal
            // 
            this.Terminal.BackColor = System.Drawing.Color.Black;
            this.Terminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Terminal.Cursor = System.Windows.Forms.Cursors.Default;
            this.Terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Terminal.ForeColor = System.Drawing.Color.White;
            this.Terminal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Terminal.Location = new System.Drawing.Point(19, 12);
            this.Terminal.Multiline = true;
            this.Terminal.Name = "Terminal";
            this.Terminal.ReadOnly = true;
            this.Terminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Terminal.Size = new System.Drawing.Size(624, 381);
            this.Terminal.TabIndex = 2;
            this.Terminal.Visible = false;
            // 
            // CommandLine
            // 
            this.CommandLine.BackColor = System.Drawing.Color.Black;
            this.CommandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommandLine.ForeColor = System.Drawing.Color.White;
            this.CommandLine.HideSelection = false;
            this.CommandLine.Location = new System.Drawing.Point(39, 399);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(604, 26);
            this.CommandLine.TabIndex = 1;
            this.CommandLine.Visible = false;
            this.CommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLine_KeyDown);
            // 
            // LabelCommandLane
            // 
            this.LabelCommandLane.AutoSize = true;
            this.LabelCommandLane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCommandLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCommandLane.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCommandLane.Location = new System.Drawing.Point(15, 399);
            this.LabelCommandLane.Name = "LabelCommandLane";
            this.LabelCommandLane.Size = new System.Drawing.Size(21, 24);
            this.LabelCommandLane.TabIndex = 1;
            this.LabelCommandLane.Text = ">";
            this.LabelCommandLane.Visible = false;
            // 
            // Monitor
            // 
            this.Monitor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monitor.Image = global::PracaDyplomowa.Properties.Resources.Monitor;
            this.Monitor.Location = new System.Drawing.Point(0, 0);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(651, 647);
            this.Monitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Monitor.TabIndex = 0;
            this.Monitor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 647);
            this.Controls.Add(this.PanelMonitor);
            this.Controls.Add(this.PanelComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja-Symulator Komputera PC";
            this.PanelComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).EndInit();
            this.PanelMonitor.ResumeLayout(false);
            this.PanelMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxIntro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelComputer;
        private System.Windows.Forms.PictureBox Computer;
        private System.Windows.Forms.Panel PanelMonitor;
        private System.Windows.Forms.PictureBox Monitor;
        private System.Windows.Forms.PictureBox EditButton;
        private System.Windows.Forms.TextBox CommandLine;
        private System.Windows.Forms.Label LabelCommandLane;
        private System.Windows.Forms.TextBox Terminal;
        private System.Windows.Forms.Label StartButton;
        private System.Windows.Forms.Button MinusSize;
        private System.Windows.Forms.Button PlusSize;
        private System.Windows.Forms.PictureBox PictureboxIntro;
        private System.Windows.Forms.Panel PowerLamp;
        private System.Windows.Forms.ProgressBar ProgressIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxKabel;
    }
}

