using System;
using System.Drawing;

namespace SettlersofChaos
{
    class Backsplash
    {
        //Backsplash for the main menu generation and drawing
        // Inscribed radius
        public float BackRadius;
        //Axial Coordinate
        public int BackColumn;
        public int BackRow;
        public const int NUM_SIDES = 100;

        public void Draw(Graphics g, PointF centerOfWindow)
        {
            var shapeposition = AxialCoords.ToScreenCoords(BackRow, BackColumn, BackRadius);
            shapeposition.X += centerOfWindow.X;
            shapeposition.Y += centerOfWindow.Y;
            // Circumscribed radius
            float cRadius = BackRadius * (float)(.8 / Math.Cos(Math.PI / NUM_SIDES));
            PointF[] points = new PointF[NUM_SIDES];
            for (int i = 0; i < NUM_SIDES; i++)
            {
                double angle = i * (Math.PI * 2 / NUM_SIDES);
                float x = shapeposition.X + cRadius * (float)Math.Cos(angle);
                float y = shapeposition.Y + cRadius * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }
            g.FillPolygon(Brushes.Aqua, points);
            g.DrawPolygon(Pens.Black, points);
        }

        internal float getdistanceto(int mouseX, int mouseY)
        {
            throw new NotImplementedException();
        }
    }
}
