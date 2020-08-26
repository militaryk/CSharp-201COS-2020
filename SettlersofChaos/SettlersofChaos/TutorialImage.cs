using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SettlersofChaos
{
    class TutorialImage
    {
        public int x, y, width, height;//variables for the rectangle
        public Image tutorialimage;//variable for the planet's image
        Point centre;
        public Rectangle TutorialRec;//variable for a rectangle to place our image in
        public int TutorialLevel = 1;

        //Create a constructor (initialises the values of the fields)
        public TutorialImage()
        {
            x = 0;
            y = 0;
            width = 784;
            height = 461;

            TutorialRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void Draw(Graphics g)
        {
            if (TutorialLevel == 1)
            {
                tutorialimage = Properties.Resources.TutorialChapterOne;
            }
            if (TutorialLevel == 2)
            {
                tutorialimage = Properties.Resources.TutorialChapterTwo;
            }
            if (TutorialLevel == 3)
            {
                tutorialimage = Properties.Resources.TutorialChapterThree;
            }
            if (TutorialLevel == 4)
            {
                tutorialimage = Properties.Resources.TutorialChapterFour;
            }
            if (TutorialLevel == 5)
            {
                tutorialimage = Properties.Resources.TutorialChapterFive;
            }
            if (TutorialLevel == 6)
            {
                tutorialimage = Properties.Resources.TutorialChapterSix;
            }
            g.DrawImage(tutorialimage, TutorialRec);
            centre = new Point(TutorialRec.X + width / 2, TutorialRec.Y + width / 2);

        }
    }
}
