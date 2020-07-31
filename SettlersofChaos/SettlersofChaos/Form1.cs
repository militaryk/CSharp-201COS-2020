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
using System.Reflection.Emit;

namespace SettlersofChaos
{
    public partial class FormGame : Form
    {
        private List<Hexagon> hexagons = new List<Hexagon>();
        private Artilltery[] redblocks = new Artilltery[20];
        public int speed = 10;
        string shellmove;
        int MouseX;
        int MouseY;
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


            for (int i = -2; i <= 2; i++)
            {
                for (int j = -3; j <= 3; j++)
                {
                    if (j - i <= 2 && i - j <= 2)
                    {
                        var hexagon = new Hexagon
                        {
                            Row = i,
                            Column = j,
                            Radius = 50,
                        };
                        hexagons.Add(hexagon);
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
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
            artilleryTarget.TargetPosX -= speed;
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
            if (CollidesWithTarget())
            {
                LblTargetHit.Visible = true;
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
                if (artilleryShell.ShellRec.IntersectsWith(new Rectangle(block.Position, block.Size)))
                {
                    return true;
                }

            }
            return false;
        }

        private bool CollidesWithTarget()
        {
            if (artilleryShell.ShellRec.IntersectsWith(new Rectangle(artilleryTarget.TargetPosition, artilleryTarget.TargetSize)))
            {
                return true;
            }
            return false;
        }

        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { left = false; }
            if (e.KeyData == Keys.Down) { right = false; ArtilleryGameTriggered(); }
        }

        public void ArtilleryGameTriggered()
        {
            TmrArtilleryTicks.Enabled = true;
            TmrShellMove.Enabled = true;
            PnlFight.Visible = true;
        }

        private void PnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = Cursor.Position.X;
            MouseY = Cursor.Position.Y;
            label1.Text = MouseX.ToString();
            label2.Text = MouseY.ToString();

        }

        public void GameBoot()
        {
            LblTargetHit.Location = new Point(0, 0);
            YouMissedLBL.Location = new Point(0, 0);
        }

        public void HexagonSelect() {
            float[] distances = new float[hexagons.Count];
            int i;
            foreach (var hexagon in hexagons)
            {
                distances[i] = hexagon.getdistanceto(MouseX, MouseY);
            }
        }



    }
}

