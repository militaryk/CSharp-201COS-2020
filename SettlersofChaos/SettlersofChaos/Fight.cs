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
        public Point Position;
        public Size Size;
        public int RedPosY;
        Random RedPosRamdom = new Random();
        int RedPosX;
        public Fight()
        {
            RedPosX= RedPosRamdom.Next(1, 100);
            Position = new Point(RedPosX, RedPosY);
            Size = new Size(100, 100);
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, new Rectangle(Position, Size));

        }
    }
}
