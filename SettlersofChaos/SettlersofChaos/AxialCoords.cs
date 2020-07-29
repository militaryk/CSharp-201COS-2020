using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    static class AxialCoords
    {
        public static PointF ToScreenCoords(int row, int column, float radius) {
            double h = 1.6 * radius;
            double w = 1.6 / Math.Sin(Math.PI / 3) * radius;
            double x = column * w * 0.75;
            double y = row * h - h/2 * column;
            return new PointF((float)x, (float)y);
        }
    }
}
