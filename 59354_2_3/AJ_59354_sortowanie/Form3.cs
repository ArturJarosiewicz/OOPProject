using System;
using System.Windows.Forms;

namespace _59354_2_3.AJ_59354_sortowanie
{
    public partial class AJ_59354_bubbleForm : Form
    {
        // tworzymy obiekt klasy AJ_59354_bubbleSort na którym bedziemy pracować
        static AJ_59354_bubbleSort AJ_59354_newSort = new AJ_59354_bubbleSort();
        public AJ_59354_bubbleForm()
        {
            InitializeComponent();
        }

        // funkcja generująca losowe liczby do posortowania
        private int[] AJ_59354_generateNumbers()
        {
            Random AJ_59354_rnd = new Random();
            int AJ_59354_lengthString = (int)AJ_59354_bubbleNumericUpDown.Value;
            int[] AJ_59354_numbers = new int[AJ_59354_lengthString];

            for (int i = 0; i < AJ_59354_lengthString; i++)
                AJ_59354_numbers[i] = AJ_59354_rnd.Next(101);

            return AJ_59354_numbers;
        }


        // obsługa przycisku "Generuj i sortuj" - generuje i wyświetla nowy ciąg liczb
        // następnie za pomocą obiektu AJ_59354_newSort sortuje podane liczby i wyświetla je
        private void AJ_59354_genAndSortClick(object sender, EventArgs e)
        {

            int[] AJ_59354_numbers = AJ_59354_generateNumbers();

            if ((int)AJ_59354_bubbleNumericUpDown.Value == 0)
                MessageBox.Show("Ustaw ilość liczb w ciągu");

                for (int AJ_59354_i = 0; AJ_59354_i < AJ_59354_numbers.Length; AJ_59354_i++)
                {
                    if (AJ_59354_i == AJ_59354_numbers.Length - 1)
                        AJ_59354_bubbleTextBox1.Text += AJ_59354_numbers[AJ_59354_i].ToString();
                    else
                        AJ_59354_bubbleTextBox1.Text += AJ_59354_numbers[AJ_59354_i].ToString() + ", ";
                }

                AJ_59354_newSort.AJ_59354_sort(ref AJ_59354_numbers);
                for (int AJ_59354_i = 0; AJ_59354_i < AJ_59354_numbers.Length; AJ_59354_i++)
                {
                    if (AJ_59354_i == AJ_59354_numbers.Length - 1)
                        AJ_59354_bubbleTextBox2.Text += AJ_59354_numbers[AJ_59354_i].ToString();
                    else
                        AJ_59354_bubbleTextBox2.Text += AJ_59354_numbers[AJ_59354_i].ToString() + ", ";
                }

            
        }

        // obsługa przycisku "reset" która czyści pola teksowte
        private void AJ_59354_reset(object sender, EventArgs e)
        {
            AJ_59354_bubbleTextBox1.Text = "";
            AJ_59354_bubbleTextBox2.Text = "";
        }
    }
    
   

}

