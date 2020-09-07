﻿using System;
using System.Drawing;

namespace SettlersofChaos
{
    class Hexagon
    {
        // Controls and renders aswell as doing the caluclations for the Game background in the main menu, was supposed to be used for the main game however later was made redundent
        // Inscribed radius
        public float Radius;
        //Axial Coordinate
        public int Column;
        public int Row;
        public const int NUM_SIDES = 6;

        public void Draw(Graphics g, PointF centerOfWindow)
        {
            var position = AxialCoords.ToScreenCoords(Row, Column, Radius);
            position.X += centerOfWindow.X;
            position.Y += centerOfWindow.Y;
            // Circumscribed radius
            float cRadius = Radius * (float)(.8 / Math.Cos(Math.PI / NUM_SIDES));
            PointF[] points = new PointF[NUM_SIDES];
            for (int i = 0; i < NUM_SIDES; i++)
            {
                double angle = i * (Math.PI * 2 / NUM_SIDES);
                float x = position.X + cRadius * (float)Math.Cos(angle);
                float y = position.Y + cRadius * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }
            g.FillPolygon(Brushes.Aqua, points);
            g.DrawPolygon(Pens.Black, points);
        }

        internal float getdistanceto(int mouseX, int mouseY)
        {
            throw new NotImplementedException();
        }
    }
}
