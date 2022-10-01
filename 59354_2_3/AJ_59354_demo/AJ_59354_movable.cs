using System;
using System.Drawing;


namespace _59354_2_3.AJ_59354_demo
{
    public class AJ_59354_movable
    {
        public int AJ_59354_value { get; set; }
        public PointF AJ_59354_point { get; set; }
        public Pen AJ_59354_pen { get; set; }
        public Font AJ_59354_font { get; set; }
        public PointF AJ_59354_destination { get; set; }
        public SizeF AJ_59354_textOffset { get; set; }
        public int AJ_59354_size { get; set; }
        public float AJ_59354_velocity { get; set; }
        public bool AJ_59354_reachedDestination => Math.Abs(AJ_59354_destination.X - AJ_59354_point.X) < 0.01f;

        public void AJ_59354_draw(Graphics AJ_59354_graphics)
        {
            AJ_59354_graphics.DrawString(AJ_59354_value.ToString(), AJ_59354_font, AJ_59354_pen.Brush, AJ_59354_point + AJ_59354_textOffset);
            AJ_59354_graphics.DrawEllipse(AJ_59354_pen, new Rectangle() { Location = new Point((int)AJ_59354_point.X, (int)AJ_59354_point.Y), Size = new Size(AJ_59354_size, AJ_59354_size) });
        }

        public void AJ_59354_update(int AJ_59354_milliseconds)
        {
            float AJ_59354_offset = AJ_59354_milliseconds * AJ_59354_velocity;

            if (AJ_59354_point.X < AJ_59354_destination.X)
            {
                AJ_59354_point += new SizeF(Math.Min(AJ_59354_destination.X - AJ_59354_point.X, AJ_59354_offset), 0);
            }
            else if (AJ_59354_point.X > AJ_59354_destination.X)
            {
                AJ_59354_point -= new SizeF(Math.Min(AJ_59354_point.X - AJ_59354_destination.X, AJ_59354_offset), 0);
            }
        }
    }
}
