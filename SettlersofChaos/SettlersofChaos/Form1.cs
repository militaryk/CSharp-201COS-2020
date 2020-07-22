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
        private Artilltery[] redblocks = new Artilltery[10];
        public int speed = 10;
        ArtilleryShell artilleryShell = new ArtilleryShell();
        public FormGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
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
            for (int i = 0; i < 10; i++) {
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
        }

        public void ArtilleryTicks_Tick(object sender, EventArgs e)
        {
            foreach (var block in redblocks)
            {
                block.RedPosX -= speed;
            }
            PnlFight.Invalidate();
        }
    }
}
