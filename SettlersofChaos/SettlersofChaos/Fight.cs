using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class Artilltery
    {
        public Point Position;
        public Size Size;
        public int RedPosX;
        int RedPosY;
        int RedPosAxis;
        public Artilltery(Random random)
        {
            RedPosX = random.Next(1, 5000);
            RedPosAxis = random.Next(0, 3);
            RedPosY = RedPosAxis * 100;
            Size = new Size(50, 100);
        }
        public void Draw(Graphics g)
        {
            Position = new Point(RedPosX, RedPosY);
            g.FillRectangle(Brushes.Red, new Rectangle(Position, Size));

        }
    }
}
