
namespace _59354_2_3.AJ_59354_sortowanie
{
    // klasa mająca za zadanie tylko sortować przekazane liczby
    class AJ_59354_bubbleSort
    {
        // sunkcja sortująca
        public void AJ_59354_sort(ref int[] AJ_59354_numbers)
        {
            //zmienna pomocnicza
            int AJ_59354_tmp;
            for (int AJ_59354_i = 0; AJ_59354_i < AJ_59354_numbers.Length; AJ_59354_i++)
            {
                for (int AJ_59354_j = 0; AJ_59354_j < AJ_59354_numbers.Length - 1; AJ_59354_j++)
                {
                    if (AJ_59354_numbers[AJ_59354_j] > AJ_59354_numbers[AJ_59354_j + 1])
                    {
                        AJ_59354_tmp = AJ_59354_numbers[AJ_59354_j];
                        AJ_59354_numbers[AJ_59354_j] = AJ_59354_numbers[AJ_59354_j + 1];
                        AJ_59354_numbers[AJ_59354_j + 1] = AJ_59354_tmp;
                    }
                }
            }
        }
    }
}
