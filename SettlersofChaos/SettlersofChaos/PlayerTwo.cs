﻿using System.Drawing;

namespace SettlersofChaos
{
    class PlayerTwo
    {
        //Draws the rectangle for the PLayerOne to display as a background piece
        Point Position;
        Size Size;
        int Plr2PosX = 550;
        public bool themeblue = true, themepink = false, themedark = false;
        int Plr2PosY = 40;
        int Plr2Height = 300;
        int Plr2Width = 200;
        public void Draw(Graphics g)
        {
            if (themeblue == true)
            {
                Size = new Size(Plr2Width, Plr2Height);
                Position = new Point(Plr2PosX, Plr2PosY);
                var Brush = new SolidBrush(Color.FromArgb(62, 100, 138));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
            if (themepink == true)
            {
                Size = new Size(Plr2Width, Plr2Height);
                Position = new Point(Plr2PosX, Plr2PosY);
                var Brush = new SolidBrush(Color.FromArgb(138, 62, 82));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
            if (themedark == true)
            {
                Size = new Size(Plr2Width, Plr2Height);
                Position = new Point(Plr2PosX, Plr2PosY);
                var Brush = new SolidBrush(Color.FromArgb(107, 107, 107));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
        }
    }
}
