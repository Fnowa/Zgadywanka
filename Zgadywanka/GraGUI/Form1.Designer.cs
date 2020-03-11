namespace GraGUI
{
    partial class FormZaDuzo
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosiwanie = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.groupBoxOdpowiedz = new System.Windows.Forms.GroupBox();
            this.buttonPotwierdz = new System.Windows.Forms.Button();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.textBoxOdpowiedz = new System.Windows.Forms.TextBox();
            this.buttonHistoriaGry = new System.Windows.Forms.Button();
            this.labelKomunikat = new System.Windows.Forms.Label();
            this.labelDobrze = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.groupBoxLosiwanie.SuspendLayout();
            this.groupBoxOdpowiedz.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(100, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosiwanie
            // 
            this.groupBoxLosiwanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosiwanie.Controls.Add(this.textBoxDo);
            this.groupBoxLosiwanie.Controls.Add(this.textBoxOd);
            this.groupBoxLosiwanie.Controls.Add(this.label2);
            this.groupBoxLosiwanie.Controls.Add(this.label1);
            this.groupBoxLosiwanie.Location = new System.Drawing.Point(12, 56);
            this.groupBoxLosiwanie.Name = "groupBoxLosiwanie";
            this.groupBoxLosiwanie.Size = new System.Drawing.Size(453, 100);
            this.groupBoxLosiwanie.TabIndex = 1;
            this.groupBoxLosiwanie.TabStop = false;
            this.groupBoxLosiwanie.Text = "Losowanie";
            this.groupBoxLosiwanie.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zakres od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(101, 24);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            this.textBoxOd.TextChanged += new System.EventHandler(this.textBoxOd_TextChanged);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(101, 53);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(338, 46);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(350, 12);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(100, 23);
            this.buttonPrzerwij.TabIndex = 2;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Visible = false;
            // 
            // groupBoxOdpowiedz
            // 
            this.groupBoxOdpowiedz.Controls.Add(this.labelWynik);
            this.groupBoxOdpowiedz.Controls.Add(this.labelDobrze);
            this.groupBoxOdpowiedz.Controls.Add(this.textBoxOdpowiedz);
            this.groupBoxOdpowiedz.Controls.Add(this.labelOdpowiedz);
            this.groupBoxOdpowiedz.Controls.Add(this.buttonPotwierdz);
            this.groupBoxOdpowiedz.Location = new System.Drawing.Point(13, 202);
            this.groupBoxOdpowiedz.Name = "groupBoxOdpowiedz";
            this.groupBoxOdpowiedz.Size = new System.Drawing.Size(452, 100);
            this.groupBoxOdpowiedz.TabIndex = 3;
            this.groupBoxOdpowiedz.TabStop = false;
            this.groupBoxOdpowiedz.Text = "Odpowiedz";
            this.groupBoxOdpowiedz.Visible = false;
            // 
            // buttonPotwierdz
            // 
            this.buttonPotwierdz.Location = new System.Drawing.Point(337, 36);
            this.buttonPotwierdz.Name = "buttonPotwierdz";
            this.buttonPotwierdz.Size = new System.Drawing.Size(75, 23);
            this.buttonPotwierdz.TabIndex = 0;
            this.buttonPotwierdz.Text = "Potwierdź";
            this.buttonPotwierdz.UseVisualStyleBackColor = true;
            this.buttonPotwierdz.Click += new System.EventHandler(this.buttonPotwierdz_Click);
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(11, 41);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(91, 13);
            this.labelOdpowiedz.TabIndex = 1;
            this.labelOdpowiedz.Text = "Podaj odpowiedź:";
            // 
            // textBoxOdpowiedz
            // 
            this.textBoxOdpowiedz.Location = new System.Drawing.Point(100, 38);
            this.textBoxOdpowiedz.Name = "textBoxOdpowiedz";
            this.textBoxOdpowiedz.Size = new System.Drawing.Size(100, 20);
            this.textBoxOdpowiedz.TabIndex = 2;
            // 
            // buttonHistoriaGry
            // 
            this.buttonHistoriaGry.Location = new System.Drawing.Point(12, 581);
            this.buttonHistoriaGry.Name = "buttonHistoriaGry";
            this.buttonHistoriaGry.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoriaGry.TabIndex = 4;
            this.buttonHistoriaGry.Text = "Histora Gry";
            this.buttonHistoriaGry.UseVisualStyleBackColor = true;
            this.buttonHistoriaGry.Visible = false;
            // 
            // labelKomunikat
            // 
            this.labelKomunikat.AutoSize = true;
            this.labelKomunikat.Location = new System.Drawing.Point(113, 183);
            this.labelKomunikat.Name = "labelKomunikat";
            this.labelKomunikat.Size = new System.Drawing.Size(0, 13);
            this.labelKomunikat.TabIndex = 5;
            // 
            // labelDobrze
            // 
            this.labelDobrze.AutoSize = true;
            this.labelDobrze.Location = new System.Drawing.Point(100, 65);
            this.labelDobrze.Name = "labelDobrze";
            this.labelDobrze.Size = new System.Drawing.Size(0, 13);
            this.labelDobrze.TabIndex = 3;
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(237, 41);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 13);
            this.labelWynik.TabIndex = 4;
            // 
            // FormZaDuzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 656);
            this.Controls.Add(this.labelKomunikat);
            this.Controls.Add(this.buttonHistoriaGry);
            this.Controls.Add(this.groupBoxOdpowiedz);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.groupBoxLosiwanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "FormZaDuzo";
            this.Text = "Za dużo, za mało";
            this.groupBoxLosiwanie.ResumeLayout(false);
            this.groupBoxLosiwanie.PerformLayout();
            this.groupBoxOdpowiedz.ResumeLayout(false);
            this.groupBoxOdpowiedz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosiwanie;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.GroupBox groupBoxOdpowiedz;
        private System.Windows.Forms.TextBox textBoxOdpowiedz;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Button buttonPotwierdz;
        private System.Windows.Forms.Button buttonHistoriaGry;
        private System.Windows.Forms.Label labelKomunikat;
        private System.Windows.Forms.Label labelDobrze;
        private System.Windows.Forms.Label labelWynik;
    }
}

