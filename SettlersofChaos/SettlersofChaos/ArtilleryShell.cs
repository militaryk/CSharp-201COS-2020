using System.Drawing;

namespace SettlersofChaos
{
    class ArtilleryShell
    {
        // declare fields to use in the class

        public int x, y, width, height;
        public Image artilleryshell;
        Point centre;
        public Rectangle ShellRec;
        public ArtilleryShell()
        {
            x = 10;
            y = 10;
            width = 60;
            height = 20;
            artilleryshell = Properties.Resources.bullet;
            ShellRec = new Rectangle(x, y, width, height);
        }
        //methods to draw the artillery shell
        public void DrawShell(Graphics g)
        {

            g.DrawImage(artilleryshell, ShellRec);
            centre = new Point(ShellRec.X + width / 2, ShellRec.Y + width / 2);

        }
        //Controls the Artillery shells movement throughout the Artillery Game
        public void MoveShell(string move)
        {
            
            ShellRec.Location = new Point(x, y);
            if (ShellRec.Location.Y < 20)
            {

                y = 20;
                ShellRec.Location = new Point(x, y);
            }
            if (ShellRec.Location.Y > 260)
            {
                y = 260;
                ShellRec.Location = new Point(x, y);
            }
            if (ShellRec.Location.X < 10)
            {
                x = 10;
                ShellRec.Location = new Point(x, y);
            }

            if (move == "up")
            {
                if (ShellRec.Location.Y > 275)
                {

                    y = 275;
                    ShellRec.Location = new Point(x, y);
                }
                else
                {
                    y += 20;
                    ShellRec.Location = new Point(x, y);
                }

            }
            if (move == "down")
            {
                if (ShellRec.Location.Y < 5)
                {

                    y = 5;
                    ShellRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 20;
                    ShellRec.Location = new Point(x, y);
                }

            }


        }
    }
}
