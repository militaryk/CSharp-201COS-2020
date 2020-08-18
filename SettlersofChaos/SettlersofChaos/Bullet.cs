using System.Drawing;

namespace SettlersofChaos
{
    class Bullet
    {
        // declare fields to use in the class

        public int bulletx, y, width, height;//variables for the rectangle
        public Image bullet;//variable for the planet's image
        public Point bulletcentre;
        public Rectangle BulletRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Bullet()
        {
            bulletx = 100;
            y = 200;
            width = 60;
            height = 20;
            bullet = Properties.Resources.shootbullet;
            BulletRec = new Rectangle(bulletx, y, width, height);
        }
        //methods
        public void DrawBullet(Graphics g)
        {

            g.DrawImage(bullet, BulletRec);
            bulletcentre = new Point(BulletRec.X + width / 2, BulletRec.Y + width / 2);

        }
    }
}
