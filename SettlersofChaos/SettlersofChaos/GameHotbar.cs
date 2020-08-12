using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class GameHotbar
    {
        Point Position;
        Size Size;
        int MenuPosX = 0;
        int MenuPosY = 400;
        int MenuHeight = 70;
        int MenuWidth = 800;
        public void Draw(Graphics g)
        {
            Size = new Size(MenuWidth, MenuHeight);
            Position = new Point(MenuPosX, MenuPosY);
            g.FillRectangle(Brushes.Aqua, new Rectangle(Position, Size));

        }
    }
}
