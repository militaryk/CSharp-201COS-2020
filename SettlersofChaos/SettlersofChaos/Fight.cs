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
        int RedPosXAxis;
        int RedBlockHeight;
        int RedBlockWidth;
        public Artilltery(Random random)
        {
            RedPosXAxis = random.Next(1, 20);
            RedPosAxis = random.Next(0, 3);
            RedBlockHeight = random.Next(100, 200);
            RedBlockWidth = random.Next(20, 100);
            RedPosY = RedPosAxis * 100;
            Size = new Size(20, 100);
            if (RedPosAxis == 0) { RedPosX = RedPosXAxis * 250 + 500; }
            if (RedPosAxis == 1) { RedPosX = RedPosXAxis * 250 + 500; }
            if (RedPosAxis == 2) { RedPosX = RedPosXAxis * 250 + 500; }
        }
        public void Draw(Graphics g)
        {
            Size = new Size(20, RedBlockHeight);
            Position = new Point(RedPosX, RedPosY);
            g.FillRectangle(Brushes.Red, new Rectangle(Position, Size));

        }
    }
}
