using _59354_2_3.AJ_59354_algorytmLZW;
using _59354_2_3.AJ_59354_sortowanie;
using _59354_2_3.AJ_59354_nwd;
using _59354_2_3.AJ_59354_demo;
using System.Windows.Forms;

namespace _59354_2_3
{
    public partial class AJ_59354_form1 : Form
    {
        public AJ_59354_form1()
        {
            InitializeComponent();
        }

        //wyświetlenie okna z algorytmem kompresji poprzez stworzenie odpowiedniego obiektu winform i pokazanie go przez metodę show()
        private void AJ_59354_MenuItem2_Click(object sender, System.EventArgs e)
        {
            AJ_59354_lzwForm AJ_59354_LZW = new AJ_59354_lzwForm();
            AJ_59354_LZW.Show();
        }

        //wyświetlenie okna z algorytmem sortowania poprzez stworzenie odpowiedniego obiektu winform i pokazanie go przez metodę show()
        private void AJ_59354_sortItemClick(object sender, System.EventArgs e)
        {
            AJ_59354_bubbleForm AJ_59354_bubble = new AJ_59354_bubbleForm();
            AJ_59354_bubble.Show();
        }

        private void AJ_59354_clickItem3(object sender, System.EventArgs e)
        {
            AJ_59354_nwdForm AJ_59354_newNwdForm = new AJ_59354_nwdForm();
            AJ_59354_newNwdForm.Show();
        }

        private void AJ_59354_demoClick(object sender, System.EventArgs e)
        {
            AJ_59354_formDemo AJ_59354_newDemo = new AJ_59354_formDemo();
            AJ_59354_newDemo.Show();
        }
    }
}
