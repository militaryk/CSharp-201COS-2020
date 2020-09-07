using System.Drawing;

namespace SettlersofChaos
{
    class Bullet
    {
        //Draws and selects the iamge for the Bullet used in ShootGame
        // declare fields to use in the class

        public int bulletx, y, width, height;
        public Image bullet;
        public Point bulletcentre;
        public Rectangle BulletRec;

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
