using System.Drawing;

namespace SettlersofChaos
{
    //Class to draw and render the artillery target rectangle that the player is trying to colide with
    class ArtilleryTarget
    {
        public Point TargetPosition;
        public Size TargetSize;
        public int TargetPosX;
        int TargetPosY;
        int TargretBlockHeight;
        int TargetBlockWidth;
        public ArtilleryTarget()
        {
            TargetPosX = 5000;
            TargetPosY = 0;
            TargretBlockHeight = 300;
            TargetBlockWidth = 1000;
        }
        public void Draw(Graphics g)
        {
            TargetSize = new Size(TargetBlockWidth, TargretBlockHeight);
            TargetPosition = new Point(TargetPosX, TargetPosY);
            g.FillRectangle(Brushes.Blue, new Rectangle(TargetPosition, TargetSize));

        }
    }
}
