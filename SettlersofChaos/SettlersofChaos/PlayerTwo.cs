using System.Drawing;

namespace SettlersofChaos
{
    class PlayerTwo
    {
        Point Position;
        Size Size;
        int Plr2PosX = 550;
        int Plr2PosY = 40;
        int Plr2Height = 250;
        int Plr2Width = 200;
        public void Draw(Graphics g)
        {
            Size = new Size(Plr2Width, Plr2Height);
            Position = new Point(Plr2PosX, Plr2PosY);
            var Brush = new SolidBrush(Color.FromArgb(62, 100, 138));
            g.FillRectangle(Brush, new Rectangle(Position, Size));
        }
    }
}
