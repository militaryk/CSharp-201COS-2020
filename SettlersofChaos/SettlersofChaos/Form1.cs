using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettlersofChaos
{
    public partial class Form1 : Form
    {
        private Hexagon[] hexagons = new Hexagon[3];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                hexagons[i] = new Hexagon
                {
                    Row = i,
                    Column = i,
                    Radius = 50,
                };
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
    }
}
