using System.Drawing;

namespace SettlersofChaos
{
    class MenuGameInfo
    {
        Point Position;
        Size Size;
        public bool themeblue = true, themepink = false, themedark = false;
        int MenuRecX = 20;
        public bool settingsvissible = false;
        int MenuRecY = 125;
        int MenuRecHeight = 275;
        int MenuRecWidth = 170;
        public void Draw(Graphics g)
        {

                if (themeblue == true)
                {
                    Size = new Size(MenuRecWidth, MenuRecHeight);
                    Position = new Point(MenuRecX, MenuRecY);
                    var Brush = new SolidBrush(Color.FromArgb(52, 146, 235));
                    g.FillRectangle(Brush, new Rectangle(Position, Size));
                }
                if (themepink == true)
                {
                    Size = new Size(MenuRecWidth, MenuRecHeight);
                    Position = new Point(MenuRecX, MenuRecY);
                    var Brush = new SolidBrush(Color.FromArgb(217, 52, 235));
                    g.FillRectangle(Brush, new Rectangle(Position, Size));
                }
                if (themedark == true)
                {
                    Size = new Size(MenuRecWidth, MenuRecHeight);
                    Position = new Point(MenuRecX, MenuRecY);
                    var Brush = new SolidBrush(Color.FromArgb(204, 204, 204));
                    g.FillRectangle(Brush, new Rectangle(Position, Size));
                }
        }
    }
}
