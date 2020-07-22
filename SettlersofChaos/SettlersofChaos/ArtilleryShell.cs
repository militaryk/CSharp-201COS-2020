using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class ArtilleryShell
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image artilleryshell;//variable for the planet's image
        public int rotationAngle;
        Point centre;
        public Rectangle ShellRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public ArtilleryShell()
        {
            x = 10;
            y = 10;
            width = 40;
            height = 40;
            rotationAngle = 0;
            artilleryshell = Properties.Resources.shell;
            ShellRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void DrawShell(Graphics g)
        {

            g.DrawImage(artilleryshell, ShellRec);
            centre = new Point(ShellRec.X + width / 2, ShellRec.Y + width / 2);

        }
        public void MoveShell(string move)
        {
            ShellRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (ShellRec.Location.X > 450)
                {

                    x = 450;
                    ShellRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    ShellRec.Location = new Point(x, y);
                }

            }
            if (move == "left")
            {
                if (ShellRec.Location.X < 10)
                {

                    x = 10;
                    ShellRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    ShellRec.Location = new Point(x, y);
                }

            }


        }
    }
}
