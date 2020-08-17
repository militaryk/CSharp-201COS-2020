﻿using System.Drawing;

namespace SettlersofChaos
{
    class ShootTarget
    {
        Point Position;
        Size Size;
        int ShootTargetWidth = 40;
        int ShootTargetPosX = 784 - 40;
        public int ShootTargetPosY = 0;
        int ShootTargetHeight = 100;
        public void Draw(Graphics g)
        {
            Size = new Size(ShootTargetWidth, ShootTargetHeight);
            Position = new Point(ShootTargetPosX, ShootTargetPosY);
            g.FillRectangle(Brushes.Red, new Rectangle(Position, Size));


        }
    }
}