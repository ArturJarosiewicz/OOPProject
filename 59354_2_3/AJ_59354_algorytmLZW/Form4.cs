using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _59354_2_3.AJ_59354_algorytmLZW
{
    public partial class AJ_59354_lzwForm : Form
    {

        // zadeklarowanie zmiennych statycznych/obiektów potrzebnych do wykonania kompresji
        // czyli nowego słownika i obiektu klasy odpowiadającej za kompresje
        static AJ_59357_inicjujSlownik AJ_59354_slownik = new AJ_59357_inicjujSlownik();       
        static AJ_59354_algorytmLZW AJ_59354_nowaKompresja = new AJ_59354_algorytmLZW();

        public AJ_59354_lzwForm()
        {
            InitializeComponent();
        }

        // funkcja generująca i zwracająca losowy ciąg znaków który będzie później poddany kompresji
        private String AJ_59354_generujKod()
        {
            Random AJ_59354_rnd = new Random();
            String AJ_59354_kod = "";
            for (int i = 0; i < 30; i++)
            {
                AJ_59354_kod += (char)AJ_59354_rnd.Next(65, 91);
            }

            return AJ_59354_kod;
        }

        // obsługa przycisków w w komponencie z algorytmem
        // AJ_59354_button1Click - generowanie losowego kodu do kompresji
        // AJ_59354_button2Click - kompresja stworzonego kodu i wświetlenie w polu textBox2
        // przycisk reset czyszczacy pola tekstowe
        private void AJ_59354_button2Click(object sender, EventArgs e)
        {
            // zabezpieczenie przed próbą kompresji kodu bez uprzedniego wygenerowania kodu
            try
            {
                List<String> AJ_59354_wynikKompresji = AJ_59354_nowaKompresja.AJ_59354_kompresja(AJ_59354_slownik, AJ_59354_lzwTextBox1.Text);
                String AJ_59354_wynik = "";
                foreach (string AJ_59354_strings in AJ_59354_wynikKompresji)
                    AJ_59354_wynik += AJ_59354_strings;

                AJ_59354_lzwTextBox2.Text = AJ_59354_wynik;
            }
            catch (Exception AJ_59354_ex)
            {
                MessageBox.Show("Wpierw wygeneruj kod!\n" + AJ_59354_ex.Message);
            }
        }

        private void AJ_59354_button1Click(object sender, EventArgs e)
        {
            AJ_59354_slownik.AJ_59354_ustawKodZrodlowy = AJ_59354_generujKod();
            AJ_59354_lzwTextBox1.Text = AJ_59354_slownik.AJ_59354_pobierzKodZrodlowy;
        }

        private void AJ_59354_reset(object sender, EventArgs e)
        {
            AJ_59354_lzwTextBox1.Text = "";
            AJ_59354_lzwTextBox2.Text = "";
        }
    }
}
