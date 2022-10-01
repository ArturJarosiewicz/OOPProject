
using System;
using System.Windows.Forms;

namespace _59354_2_3.AJ_59354_nwd
{
    public partial class AJ_59354_nwdForm : Form
    {
        // tworzymy obiekt klasy nwd dzięki któremu obliczymy nwd
        AJ_59354_nwd AJ_59354_newNwd = new AJ_59354_nwd();
        public AJ_59354_nwdForm()
        {
            InitializeComponent();
        }

        //funkcja wyswietlająca w polu tekstowym obliczony nwd, zabezpieczona instrukcją try-catch w przypadku błędych danych
        // wejsciowych np. liter
        public void AJ_59354_displaylNWD()
        {
            try
            {
                int AJ_59354_a = int.Parse(AJ_59354_nwdTextBox1.Text);
                int AJ_59354_b = int.Parse(AJ_59354_nwdTextBox2.Text);

                AJ_59354_nwdTextBox3.Text = AJ_59354_newNwd.AJ_59354_obliczNwd(AJ_59354_a, AJ_59354_b).ToString();
            }
            catch(FormatException exception)
            {
                MessageBox.Show("Błędny format wprowadzonych danych");
            }
               
        }

        // obsługa Przycisku do obliczania nwd - wywołuje funkcje która oblicza i wyświetla obliczenia
        private void AJ_59354_nwdBtn1_Click(object sender, EventArgs e)
        {
            AJ_59354_displaylNWD();
        }
    }


}
