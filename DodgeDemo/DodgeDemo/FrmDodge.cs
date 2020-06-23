using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeDemo
{
    public partial class FrmDodge : Form
    {
        Graphics g; //declare a graphics object called g
        Planet[] planet = new Planet[7];

        public FrmDodge()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                planet[i] = new Planet();
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            }


        }
    }
}
