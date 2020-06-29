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
        private Hexagon hexagon;

        public Form1()
        {
            InitializeComponent();

            hexagon = new Hexagon
            {
                Position = new PointF(200, 200),
                Radius = 100,
            };
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            hexagon.Draw(g);
        }
    }
}
