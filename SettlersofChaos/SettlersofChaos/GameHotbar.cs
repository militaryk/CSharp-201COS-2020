using System.Drawing;

namespace SettlersofChaos
{
    class GameHotbar
    {
        //Generates the rectangle for the hotbar of the main game class
        Point Position;
        Size Size;
        public bool themeblue = true, themepink = false, themedark = false;
        int MenuPosX = 0;
        int MenuPosY = 400;
        int MenuHeight = 70;
        int MenuWidth = 800;
        public void Draw(Graphics g)
        {
            if (themeblue == true)
            {
                Size = new Size(MenuWidth, MenuHeight);
                Position = new Point(MenuPosX, MenuPosY);
                var Brush = new SolidBrush(Color.FromArgb(51, 76, 106));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
            if (themepink == true)
            {
                Size = new Size(MenuWidth, MenuHeight);
                Position = new Point(MenuPosX, MenuPosY);
                var Brush = new SolidBrush(Color.FromArgb(106, 51, 101));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }
            if (themedark == true)
            {
                Size = new Size(MenuWidth, MenuHeight);
                Position = new Point(MenuPosX, MenuPosY);
                var Brush = new SolidBrush(Color.FromArgb(71, 70, 71));
                g.FillRectangle(Brush, new Rectangle(Position, Size));
            }

        }
    }
}
