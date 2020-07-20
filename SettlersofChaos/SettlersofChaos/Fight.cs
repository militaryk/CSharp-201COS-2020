using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class Fight
    {
        // Inscribed radius
        public float Radius;
        //Axial Coordinate
        public int Column;
        public int Row;
        public const int NUM_SIDES = 4;
        public void Draw(Graphics g, PointF centerOfWindow)
        {
            var position = AxialCoords.ToScreenCoords(Row, Column, Radius);
            position.X += centerOfWindow.X;
            position.Y += centerOfWindow.Y;
            // Circumscribed radius
            float cRadius = Radius * (float)(1 / Math.Cos(Math.PI / NUM_SIDES));
            PointF[] points = new PointF[NUM_SIDES];
            for (int i = 0; i < NUM_SIDES; i++)
            {
                double angle = i * (Math.PI * 2 / NUM_SIDES);
                float x = position.X + cRadius * (float)Math.Cos(angle);
                float y = position.Y + cRadius * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }
            g.FillPolygon(Brushes.Red, points);
        }
    }
}
