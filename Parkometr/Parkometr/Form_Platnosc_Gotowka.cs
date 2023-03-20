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
    public partial class Form_Platnosc_Gotowka : Form
    {
        DateTime czas = DateTime.Now;
        DateTime maxtime = DateTime.Today.AddHours(18).AddMinutes(00);
        int oplata = 0;
        int showcounter = 0;
       
        List<Bilet> lista_biletów = new List<Bilet>();
        public Form_Platnosc_Gotowka()
        {
            InitializeComponent();
        }

        private void Form_Platnosc_Gotowka_Load(object sender, EventArgs e)
        {
            refresh_time();
            check_timer();
        }
        public void refresh_time()
        {
            label_timer_gotowka.Text = czas.ToString("HH:mm");
            label_oplata.Text = "Opłata wynosi : " + oplata.ToString() + " zł";
            label5.Text = " ";
        }
        public void create_object()
        {
            Bilet bilet = new Bilet();
            bilet.cena = oplata;
            bilet.godzina_rozpoczęcia = DateTime.Now.ToString("HH:mm");
            bilet.godzina_zakończenia = czas.ToString("HH:mm");
            bilet.numer_rejestracyjny = textBox_numer_rej.Text;
            bilet.data_zakupu = DateTime.Today.ToString("dd:MM:yyyy");
            lista_biletów.Add(bilet);
        }
        public void info_o_bilecie()
        {
            label5.Text = "Oto Twój bilet : " + "\n"
                    + "Numer rejestracyjny : " + lista_biletów[0].numer_rejestracyjny + "\n"
                    + "Data zakupu : " + lista_biletów[0].data_zakupu + "\n"
                    + "Godzina rozpoczęcia parkowania :" + lista_biletów[0].godzina_rozpoczęcia + "\n"
                    + "Godzina zakończenia parkowania :" + lista_biletów[0].godzina_zakończenia + "\n"
                    + "Cena : " + lista_biletów[0].cena.ToString() + " zł";
            showcounter += 1;
        }
        


        private void button_anuluj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void komunikat()
        {
            MessageBox.Show("Już wydrukowaliśmy Twój bilet !");
        }
        public void akcept_klik()
        {
            if (oplata == 0)
            {
                MessageBox.Show("Nie wybrano godziny zakończenia parkowania , nie można wyświetlić biletu");
            }

            else if (textBox_numer_rej.Text != "")
            {
                create_object();
                info_o_bilecie();

            }
            else
            {
                MessageBox.Show("Numer rejestracyjny nie może być pusty", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void pieczl_klik()
        {
            if (czas.AddMinutes(75) < maxtime)
            {
                czas = czas.AddMinutes(75);
                oplata += 5;
                refresh_time();
            }
            else if (czas == DateTime.Today.AddHours(18).AddMinutes(00))
            {
                oplata += 0;
                refresh_time();
            }
            else
            {
                czas = DateTime.Today.AddHours(18).AddMinutes(00);
                oplata += 3;
                refresh_time();

            }
        }
        public void dwazl_klik()
        {
            if (czas.AddMinutes(30) < maxtime)
            {
                czas = czas.AddMinutes(30);
                oplata += 2;
                refresh_time();
            }
            else if (czas == DateTime.Today.AddHours(18).AddMinutes(00))
            {
                oplata += 0;
                refresh_time();
            }
            else
            {
                czas = DateTime.Today.AddHours(18).AddMinutes(00);
                oplata += 1;
                refresh_time();

            }
        }
        public void zlotowka_klik()
        {
            if (czas.AddMinutes(15) < maxtime)
            {
                czas = czas.AddMinutes(15);
                oplata += 1;
                refresh_time();
            }
            else if (czas == DateTime.Today.AddHours(18).AddMinutes(00))
            {
                oplata += 0;
                refresh_time();
            }
            else
            {
                czas = DateTime.Today.AddHours(18).AddMinutes(00);
                oplata += 1;
                refresh_time();

            }
        }
        private void button_akceptuj_Click(object sender, EventArgs e)
        {
            if (showcounter < 1)
            {
                akcept_klik();
            }
            else
            {
                komunikat();
            }

        }

        private void button_5zl_Click(object sender, EventArgs e)
        {
            if (showcounter < 1)
            {
                pieczl_klik();
            }
            else
            {
                komunikat();
            }

        }

        private void button_2zl_Click(object sender, EventArgs e)
        {
            if (showcounter < 1)
            {
                dwazl_klik();
            }
            else
            {
                komunikat();
            }

        }

        private void button_1zl_Click(object sender, EventArgs e)
        {
            if (showcounter < 1)
            {
                zlotowka_klik();
            }
            else
            {
                komunikat();
            }

        }
        public void check_timer()
        {
            DateTime timer = DateTime.Now;
            if (timer > DateTime.Today.AddHours(22) || timer < DateTime.Today.AddHours(8))
            {
                button_akceptuj.Enabled = false;
                button_2zl.Enabled = false;
                button_1zl.Enabled = false;
                button_5zl.Enabled = false;
                textBox_numer_rej.Enabled = false;
                label6.Text = "W tych godzinach nie obowiązuje płatne parkowanie."+"\n" +"Parkomat nieczynny .";
                label6.Visible = true;
            }
        }
    }
}
