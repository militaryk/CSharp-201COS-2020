using System;
using System.Drawing;

namespace SettlersofChaos
{
    static class AxialCoords
    {
        //Generates the hexagons using a Hexaganal coordiante system used in the background of the menu
        public static PointF ToScreenCoords(int row, int column, float radius)
        {
            double h = 1.6 * radius;
            double w = 1.6 / Math.Sin(Math.PI / 3) * radius;
            double x = column * w * 0.75;
            double y = row * h - h / 2 * column;
            return new PointF((float)x, (float)y);
        }
    }
}
