using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parkometr
{
    public partial class Form_Rodzaj_Platnosci : Form
    {
        public Form_Rodzaj_Platnosci()
        {
            InitializeComponent();
        }

        private void button_platnosc_karta_Click(object sender, EventArgs e)
        {
            Form_Platnosc_Karta form_Platnosc_Karta = new Form_Platnosc_Karta();
            form_Platnosc_Karta.Show();
            this.Hide();

        }

        private void button_platnosc_gotówką_Click(object sender, EventArgs e)
        {
            Form_Platnosc_Gotowka form_Platnosc_Gotowka = new Form_Platnosc_Gotowka();
            form_Platnosc_Gotowka.Show();
            this.Hide();
        }
    }
}
