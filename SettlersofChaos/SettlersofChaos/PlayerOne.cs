using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class PlayerOne
    {
        Point Position;
        Size Size;
        int Plr1PosX = 50;
        int Plr1PosY = 20;
        int Plr1Height = 250;
        int Plr1Width = 200;
        public void Draw(Graphics g)
        {
            Size = new Size(Plr1Width, Plr1Height);
            Position = new Point(Plr1PosX, Plr1PosY);
            g.FillRectangle(Brushes.Aqua, new Rectangle(Position, Size));
        }
    }
}
