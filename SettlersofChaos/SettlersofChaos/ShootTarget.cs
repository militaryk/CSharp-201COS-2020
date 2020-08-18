using System.Drawing;

namespace SettlersofChaos
{
    class ShootTarget
    {
        public Point ShootPosition;
        public Size ShootSize;
        int ShootTargetWidth = 40;
        int ShootTargetPosX = 784 - 40;
        public int ShootTargetPosY = 0;
        int ShootTargetHeight = 100;
        public void Draw(Graphics g)
        {
            ShootSize = new Size(ShootTargetWidth, ShootTargetHeight);
            ShootPosition = new Point(ShootTargetPosX, ShootTargetPosY);
            g.FillRectangle(Brushes.Red, new Rectangle(ShootPosition, ShootSize));


        }
    }
}
