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
    public partial class Form_Platnosc_Karta : Form
    {

        DateTime czas = DateTime.Now;
        DateTime maxtime = DateTime.Today.AddHours(18).AddMinutes(00);
        int oplata = 0;
        int showcounter = 0;
        List<Bilet> lista_biletów = new List<Bilet>();
        public Form_Platnosc_Karta()
        {
            InitializeComponent();
        }
        public void refresh_time()
        {
            label_timer_karta.Text = czas.ToString("HH:mm");
            label_oplata.Text = "Opłata wynosi : " + oplata.ToString() + " zł";
            label5.Text = " ";
        }
        private void Form_Platnosc_Karta_Load(object sender, EventArgs e)
        {
            refresh_time();
            check_timer();
        }
        public void create_object ()
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
       public void plus_klick()
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
        public void minus_klick()
        {
            if (czas.AddMinutes(-30) > DateTime.Now)
            {
                czas = czas.AddMinutes(-30);
                oplata -= 2;
                refresh_time();
            }
            else
            {
                czas = DateTime.Now;
                oplata = 0;
                refresh_time();
            }
        }
        public void accept_klick()
        {

            if (oplata == 0)
            {
                MessageBox.Show("Nie wybrano godziny zakończenia parkowania , nie można wydrukować biletu");
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

        private void button_plus_Click(object sender, EventArgs e)
        {
           
            if(showcounter<1)
            {
                plus_klick();
            }
            else
            {
                MessageBox.Show("Już wydrukowaliśmy Twój bilet ! ");
            }
            
           
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
           
            if(showcounter<1)
            {
                minus_klick();
            }
            else
            {
                MessageBox.Show("Już wydrukowaliśmy Twój bilet !");
            }
          
           
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_akceptuj_Click(object sender, EventArgs e)
        {
            if(showcounter<1)
            {
                accept_klick();
            }
            else
            {
                MessageBox.Show("Już wydrukowaliśmy Twój bilet ! ");
            }

        }
        public void check_timer()
        {
            DateTime timer = DateTime.Now;
            if (timer > DateTime.Today.AddHours(22) || timer < DateTime.Today.AddHours(8))
            {
                button_akceptuj.Enabled = false;
                button_plus.Enabled = false;
                button_minus.Enabled = false;
                textBox_numer_rej.Enabled = false;
                label6.Text = "W tych godzinach nie obowiązuje płatne parkowanie." + "\n" + "Parkomat nieczynny .";
                label6.Visible = true;
            }
        }


    }
}
