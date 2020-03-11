using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class FormZaDuzo : Form
    {
        private Gra g;
        public FormZaDuzo()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosiwanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPrzerwij.Visible = true;
            groupBoxLosiwanie.Enabled = true;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxOd.Text);
            int b = int.Parse(textBoxDo.Text);

            g = new Gra(a, b);
            labelKomunikat.Text = $"Wylosowano liczbę od {a} do {b}";
            groupBoxLosiwanie.Enabled = false;
            groupBoxOdpowiedz.Visible = true;
        }

        private void buttonPotwierdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxOdpowiedz.Text);
            var odp = g.Odpowiedz(propozycja);
            switch(odp)
            {
                case ODP.ZaMalo:
                    labelWynik.ForeColor = Color.Red;
                    labelWynik.Text = "Za mało";
                    break;

                case ODP.ZaDuzo:
                    labelWynik.ForeColor = Color.Red;
                    labelWynik.Text = "Za dużo";
                    break;

                case ODP.Trafiono:
                    labelWynik.ForeColor = Color.Green;
                    labelWynik.Text = "Trafiono";
                    groupBoxOdpowiedz.Enabled = false;
                    buttonNowaGra.Enabled = true;
                    break;
            }
        }

        private void textBoxOd_TextChanged(object sender, EventArgs e)
        {
            int wynik = 0;
            if (int.TryParse(textBoxOd.Text, out wynik))
            {
                textBoxOd.BackColor = Color.LightGreen;
                buttonWylosuj.Enabled = true;
            }
            else
            {
                buttonWylosuj.Enabled = false;
                textBoxOd.BackColor = Color.LightPink;
            }
        }
    }
}
