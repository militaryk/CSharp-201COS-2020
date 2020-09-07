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
        //Define used variables
        public int x, y, width, height;
        public Image tutorialimage;
        Point centre;
        public Rectangle TutorialRec;
        public int TutorialLevel = 1;

        public TutorialImage()
        {
            x = 0;
            y = 0;
            width = 784;
            height = 461;

            TutorialRec = new Rectangle(x, y, width, height);
        }
        //methods to control what image is rendered into the back of the Tutorial
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
