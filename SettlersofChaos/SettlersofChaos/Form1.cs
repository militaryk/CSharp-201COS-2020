using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SettlersofChaos
{
    public partial class FormGame : Form
    {
        private Hexagon[] hexagons = new Hexagon[3];
        private Artilltery[] redblocks = new Artilltery[50];

        public int speed = 10;
        string shellmove;
        public bool left, right;
        ArtilleryShell artilleryShell = new ArtilleryShell();
        ArtilleryTarget artilleryTarget = new ArtilleryTarget();
        public FormGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlFight, new object[] { true });
            var random = new Random();
            var RedAxis = new Random();

            for (int i = 0; i < 3; i++)
            {
                hexagons[i] = new Hexagon
                {
                    Row = i,
                    Column = i,
                    Radius = 50,
                };
            }
            for (int i = 0; i < 50; i++) {
                redblocks[i] = new Artilltery(random);
            }
            }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var size = PnlGame.Size;
            var center = new PointF(size.Width / 2f, size.Height / 2f);
            foreach (var hexagon in hexagons)
                hexagon.Draw(g, center);
        }

        private void PnlFight_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            foreach (var block in redblocks)
            {
                block.Draw(g);
            }
            artilleryShell.DrawShell(g);
            artilleryTarget.Draw(g);

        }

        public void ArtilleryTicks_Tick(object sender, EventArgs e)
        {
            foreach (var block in redblocks)
            {
                block.RedPosX -= speed;
            }
            PnlFight.Invalidate();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { left = true; }
            if (e.KeyData == Keys.Down) { right = true; }
        }

        private void TmrShellMove_Tick(object sender, EventArgs e)
        {
            if (CollidesWithRedBlock())
            {
                //reset planet[i] back to top of panel
                YouMissedLBL.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;

            }
            else
            {
                if (right) // if right arrow key pressed
                {
                    shellmove = "up";
                    artilleryShell.MoveShell(shellmove);
                }
                if (left) // if left arrow key pressed
                {
                    shellmove = "down";
                    artilleryShell.MoveShell(shellmove);
                }
            }
        }

        private bool CollidesWithRedBlock()
        {
            foreach (var block in redblocks)
            {
                if (artilleryShell.ShellRec.IntersectsWith(new Rectangle(block.Position, block.Size))){
                    return true;
                }
                
            }
            return false;
        }

        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { left = false; }
            if (e.KeyData == Keys.Down) { right = false; }
        }


        }
}

