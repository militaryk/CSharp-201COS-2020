using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class PlayerTwo
    {
        Point Position;
        Size Size;
        int Plr2PosX = 550;
        int Plr2PosY = 20;
        int Plr2Height = 250;
        int Plr2Width = 200;
        public void Draw(Graphics g)
        {
            Size = new Size(Plr2Width, Plr2Height);
            Position = new Point(Plr2PosX, Plr2PosY);
            g.FillRectangle(Brushes.Aqua, new Rectangle(Position, Size));
        }
    }
}
