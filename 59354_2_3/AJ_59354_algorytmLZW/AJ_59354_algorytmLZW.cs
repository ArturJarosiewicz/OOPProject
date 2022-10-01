using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59354_2_3.AJ_59354_algorytmLZW
{
    class AJ_59357_inicjujSlownik
    {
        string _AJ_59354_kodZrodlowy = "";

        public string AJ_59354_ustawKodZrodlowy
        {
            set { _AJ_59354_kodZrodlowy = value; }
        }

        public string AJ_59354_pobierzKodZrodlowy
        {
            get { return _AJ_59354_kodZrodlowy; }
        }

        //metoda towrzaca slownik za pomoca petli while
        public List<string> AJ_59354_stworzSlownik()
        {
            string AJ_59354_kod = _AJ_59354_kodZrodlowy;
            string AJ_59354_znak;
            List<string> AJ_59354_slownik = new List<string>();

            //petla dodaje znaki do kontenera AJ_59354_slownik dopóki dlugosc ciagu jest większa od 0
            while (AJ_59354_kod.Length != 0)
            {
                AJ_59354_znak = AJ_59354_kod.Substring(0, 1);

                if (!AJ_59354_slownik.Contains(AJ_59354_znak))
                    AJ_59354_slownik.Add(AJ_59354_znak);
                AJ_59354_kod = AJ_59354_kod.Remove(0, 1);
            }
            //AJ_59354_slownik.Sort();
            return AJ_59354_slownik;
        }
    }
    class AJ_59354_algorytmLZW
    {
        //stworzenie kilku zmiennych pomocniczych z numerem początkowym indexu, zmienną która bedzie przechowywać wynik
        // oraz dwoma zmiennymi potrzebnymi pracy na stringach
        int _AJ_59354_indexStartowy = 0;
        List<string> _AJ_59354_wynik = new List<string>();
        string _AJ_59354_pierwszyZnak;
        string _AJ_59354_kolejnyZnak;

        public List<string> AJ_59354_kompresja(AJ_59357_inicjujSlownik AJ_59354_objektSlownik, string AJ_59354_zrodlo)
        {
            //inicjuje slownik każdego pojedyńczego znaku w ciągu
            List<string> AJ_59354_slownik = AJ_59354_objektSlownik.AJ_59354_stworzSlownik();

            //wpierw pobieramy pierwszy znak kodu
            _AJ_59354_pierwszyZnak = AJ_59354_zrodlo.Substring(_AJ_59354_indexStartowy, 1);

            //metoda będzie wykonywana w petli while do momentu aż źródło do skompresowania będzie dłuższe od zera
            while (AJ_59354_zrodlo.Length != 0)
            {
                //sprawdzamy czy kod już się nie kończy i możemy pobrac kolejny znak, jeśli tak pobieramy do zmiennej pomocniczej
                if (AJ_59354_zrodlo.Length != 1)
                    _AJ_59354_kolejnyZnak = AJ_59354_zrodlo.Substring(_AJ_59354_indexStartowy + 1, 1);

                //sprawdzamy czy slownik zawiera już słowo składajace się z dwóch zmiennych pomocniczych, jeśli tak będziemy dodawać do niego kolejny znak
                // oraz skracamy kod źródłowy o jeden znak
                if (AJ_59354_slownik.Contains(_AJ_59354_pierwszyZnak + _AJ_59354_kolejnyZnak))
                {
                    _AJ_59354_pierwszyZnak += _AJ_59354_kolejnyZnak;
                    AJ_59354_zrodlo = AJ_59354_zrodlo.Remove(0, 1);
                }

                // jeśli słownik nie zawiera słowa aktualizujemy kod wynikowy i dodajemy słowo do słownika
                // oraz skracamy kod źródłowy o jeden znak
                else
                {
                    _AJ_59354_wynik.Add((AJ_59354_slownik.IndexOf(_AJ_59354_pierwszyZnak) + 1).ToString());
                    AJ_59354_slownik.Add(_AJ_59354_pierwszyZnak + _AJ_59354_kolejnyZnak);
                    _AJ_59354_pierwszyZnak = _AJ_59354_kolejnyZnak;
                    AJ_59354_zrodlo = AJ_59354_zrodlo.Remove(0, 1);
                }

            }

            return _AJ_59354_wynik;
        }
    }
}
