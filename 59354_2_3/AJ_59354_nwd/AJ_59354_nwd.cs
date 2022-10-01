

namespace _59354_2_3.AJ_59354_nwd
{
    // klasa odpowiadająca za obliczenie nwd
    class AJ_59354_nwd
    {
        private int AJ_59354_result;
        public int AJ_59354result { get; set; }

        public int AJ_59354_obliczNwd(int AJ_59354_a, int AJ_59354_b)
        {
            while (AJ_59354_a != AJ_59354_b)
            {
                if (AJ_59354_a > AJ_59354_b)
                    AJ_59354_a = AJ_59354_a - AJ_59354_b;
                else
                    AJ_59354_b = AJ_59354_b - AJ_59354_a;
            }
            AJ_59354_result = AJ_59354_a;
            return AJ_59354_result;
        }
    }
}
