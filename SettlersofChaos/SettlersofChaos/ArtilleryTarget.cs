using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class ArtilleryTarget
    {
        public Point Position;
        public Size Size;
        int TargetPosX;
        int TargetPosY;
        int TargretBlockHeight;
        int TargetBlockWidth;
        public ArtilleryTarget()
        {
            TargetPosX = 0;
            TargetPosY = 200;
            TargretBlockHeight = 300;
            TargetBlockWidth = 50;
        }
        public void Draw(Graphics g)
        {
            Size = new Size(TargetBlockWidth, TargretBlockHeight);
            Position = new Point(TargetPosX, TargetPosY);
            g.FillRectangle(Brushes.Blue, new Rectangle(Position, Size));

        }
    }
}
