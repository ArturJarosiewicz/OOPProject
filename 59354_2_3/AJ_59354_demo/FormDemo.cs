using System;
using System.Drawing;
using System.Windows.Forms;

namespace _59354_2_3.AJ_59354_demo

{
    public partial class AJ_59354_formDemo : Form
    {
        // utworzenie kilku obiektów wykorzystywanych do działania dema
        // tablicy obiektów AJ_59354_movable w której będą się znajdować nasze kółka z liczbami
        // timera dzieki któremu obiekty będą się poruszać
        private AJ_59354_movable[] AJ_59354_movables = new AJ_59354_movable[8];

        private Timer AJ_59354_timer = new();

        private (int, int)? AJ_59354_swapping;

        private int AJ_59354_i = 0;

        public AJ_59354_formDemo()
        {
            InitializeComponent();

            Width = 600;
            Height = 200;

            // deklaracja i inicjalizacja narzędzi do rysowania obiektów
            Brush AJ_59354_brush = new SolidBrush(Color.Black);
            Pen AJ_59354_pen = new(AJ_59354_brush);
            Font AJ_59354_font = new(FontFamily.GenericSansSerif, 20, FontStyle.Regular);

            // zmienna pomocnicza typu Random do generowania losowych liczb
            Random AJ_59354_random = new();
           
            // dodanie, zainicjalizowanie nowych obiektów movable do zadeklarowanej wczesniej tablicy za pomoca petli for
            for (int AJ_59354_i = 0; AJ_59354_i < AJ_59354_movables.Length; AJ_59354_i++)
            {
                PointF AJ_59354_point = new((AJ_59354_i + 1) * 60, 60);

                AJ_59354_movables[AJ_59354_i] = new AJ_59354_movable()
                { 
                    AJ_59354_font = AJ_59354_font,
                    AJ_59354_pen = AJ_59354_pen,
                    AJ_59354_value = AJ_59354_random.Next(100),
                    AJ_59354_point = AJ_59354_point,
                    AJ_59354_size = 50,
                    AJ_59354_textOffset = new SizeF(6, 10),
                    AJ_59354_destination = AJ_59354_point,
                    AJ_59354_velocity = 0.05f
                };
            }
            // ustawienie interwału timera i jego uruchomienie
            AJ_59354_timer.Interval = 20;
            AJ_59354_timer.Tick += AJ_59354_onTick;
            AJ_59354_timer.Start();
        }

        private void AJ_59354_onTick(object sender, EventArgs e)
        {
            Invalidate();
        }

        // funkcja wykonująca jedną iteracje algorytmu sortowania tablicy obiektów movable
        private void AJ_59354_sortOnce()
        {
            for (; AJ_59354_i + 1 < AJ_59354_movables.Length; AJ_59354_i++)
            {
                if (AJ_59354_movables[AJ_59354_i].AJ_59354_value > AJ_59354_movables[AJ_59354_i + 1].AJ_59354_value)
                {
                    AJ_59354_swapping = (AJ_59354_i, AJ_59354_i + 1);

                    AJ_59354_movable AJ_59354_movable = AJ_59354_movables[AJ_59354_i];
                    AJ_59354_movables[AJ_59354_i] = AJ_59354_movables[AJ_59354_i + 1];
                    AJ_59354_movables[AJ_59354_i + 1] = AJ_59354_movable;

                    PointF AJ_59354_tempDestination = AJ_59354_movables[AJ_59354_i].AJ_59354_destination;
                    AJ_59354_movables[AJ_59354_i].AJ_59354_destination = AJ_59354_movables[AJ_59354_i + 1].AJ_59354_destination;
                    AJ_59354_movables[AJ_59354_i + 1].AJ_59354_destination = AJ_59354_tempDestination;

                    return;
                }
            }
            AJ_59354_i = 0;
        }

        // funkcja ktora rysuje obiekty na ekranie i aktualizuje ich pozycje
        private void AJ_59354_formDemo_Paint(object sender, PaintEventArgs e)
        {
            if (AJ_59354_swapping == null)
            {
                AJ_59354_sortOnce();
            }
            else
            {
                foreach (AJ_59354_movable AJ_59354_rect in AJ_59354_movables)
                {
                    AJ_59354_rect.AJ_59354_update(AJ_59354_timer.Interval);
                }

                if (AJ_59354_movables[AJ_59354_swapping.Value.Item1].AJ_59354_reachedDestination && AJ_59354_movables[AJ_59354_swapping.Value.Item2].AJ_59354_reachedDestination)
                {
                    AJ_59354_swapping = null;
                }
            }

            foreach (AJ_59354_movable AJ_59354_movable in AJ_59354_movables)
            {
                AJ_59354_movable.AJ_59354_draw(e.Graphics);
            }
        }
    }
}
