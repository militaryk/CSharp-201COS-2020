using System.Drawing;

namespace SettlersofChaos
{
    class PlayerOne
    {
        Point Position;
        Size Size;
        public bool themeblue = true, themepink = false, themedark = false;
        int Plr1PosX = 50;
        int Plr1PosY = 40;
        int Plr1Height = 250;
        int Plr1Width = 200;
        public void Draw(Graphics g)
        {
            if (themeblue == true)
            {
                Size = new Size(Plr1Width, Plr1Height);
                Position = new Point(Plr1PosX, Plr1PosY);
                var Brush = new SolidBrush(Color.FromArgb(62, 100, 138));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
            if (themepink == true)
            {
                Size = new Size(Plr1Width, Plr1Height);
                Position = new Point(Plr1PosX, Plr1PosY);
                var Brush = new SolidBrush(Color.FromArgb(138, 62, 82));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
            if (themedark == true)
            {
                Size = new Size(Plr1Width, Plr1Height);
                Position = new Point(Plr1PosX, Plr1PosY);
                var Brush = new SolidBrush(Color.FromArgb(107, 107, 107));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
        }
    }
}
