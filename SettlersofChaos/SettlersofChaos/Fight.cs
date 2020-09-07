using System;
using System.Drawing;

namespace SettlersofChaos
{
    class Artilltery
    {
        //Controls the generation of the Redblocks for the ArtilleryGame
        public Point Position;
        public Size Size;
        public int RedPosX;
        int RedPosY;
        int RedPosAxis;
        int RedPosXAxis;
        int RedBlockHeight;
        int RedBlockWidth;
        public Artilltery(Random random, int x)
        {
            RedPosXAxis = x + 1;
            RedPosAxis = random.Next(0, 3);
            RedBlockHeight = random.Next(100, 250);
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
