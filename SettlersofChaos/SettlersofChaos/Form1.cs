using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SettlersofChaos
{
    public partial class FormGame : Form
    {
        private List<Hexagon> hexagons = new List<Hexagon>();
        private Artilltery[] redblocks = new Artilltery[20];
        public int speed = 10;
        public bool BulletTargetMissed = false;
        string shellmove;
        int MouseX;
        int MouseY;
        public bool BulletTargetHit = false;
        bool ShootTargetDown = true;
        bool ShootGameInuse = false;
        public int PlayerOneDefense = 0;
        public int PlayerTwoDefense = 0;
        public bool bulletfired = false;
        bool gamestart = false;
        public bool left, right;
        public bool PlayerOneTurn = true;
        public int Difficulty = 12;
        ArtilleryShell artilleryShell = new ArtilleryShell();
        ArtilleryTarget artilleryTarget = new ArtilleryTarget();
        Bullet bullet = new Bullet();
        GameHotbar gamehotbar = new GameHotbar();
        PlayerOne plrone = new PlayerOne();
        PlayerTwo plrtwo = new PlayerTwo();
        Backsplash backsplash = new Backsplash();
        ShootTarget shoottarget = new ShootTarget();
        AiTurn aiturn = new AiTurn();
        public FormGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlBackSplash, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlFight, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlShoot, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlHome, new object[] { true });
            var random = new Random();
            var RedAxis = new Random();
            var shapeback = new Backsplash
            {
                BackRow = 1,
                BackColumn = 1,
                BackRadius = 50,
            };

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
            var size = PnlBackSplash.Size;
            var center = new PointF(size.Width / 2f, size.Height / 2f);
            if (gamestart == false)
            {
                foreach (var hexagon in hexagons)
                    hexagon.Draw(g, center);
            }
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
            if (e.KeyData == Keys.Space) { if (ShootGameInuse == true) { bulletfired = true; } }
        }

        private void TmrShellMove_Tick(object sender, EventArgs e)
        {
            if (CollidesWithRedBlock())
            {
                //reset planet[i] back to top of panel
                YouMissedLBL.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;
                System.Threading.Thread.Sleep(2300);
                ArtilleryGameExit();

            }
            if (CollidesWithTarget())
            {
                LblTargetHit.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;
                PlayerTwoDefense = PlayerTwoDefense - 5;
                System.Threading.Thread.Sleep(2300);
                ArtilleryGameExit();

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
            if (e.KeyData == Keys.Down) { right = false; }
        }

        public void ArtilleryGameTriggered()
        {
            PnlFight.Location = new Point(-3, 20);
            GameBoot();
            TmrArtilleryTicks.Enabled = true;
            TmrShellMove.Enabled = true;
            PnlFight.Visible = true;
            PlayerOneDefense = PlayerOneDefense - 3;
        }

        public void ArtilleryGameExit()
        {
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            LblPlayerOne.Visible = true;
            LblPlayerTwo.Visible = true;
            BtnHelp.Visible = true;
            BtnExit.Visible = true;
            PnlFight.Visible = false;
            BtnArtillery.Visible = true;
            BtnShoot.Visible = true;
            BtnFortify.Visible = true;
        }

        private void PnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = Cursor.Position.X;
            MouseY = Cursor.Position.Y;
        }

        public void GameBoot()
        {
            LblTargetHit.Location = new Point(-3, 20);
            YouMissedLBL.Location = new Point(-3, 20);
        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var size = PnlMenu.Size;
            var center = new PointF(size.Width / 2f, size.Height / 2f);
        }

        public void HexagonSelect()
        {
            float[] distances = new float[hexagons.Count];
            foreach (var hexagon in hexagons)
            {
                //distances[i] = hexagon.getdistanceto(MouseX, MouseY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gamestart();
        }

        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            gamehotbar.Draw(g);
            plrone.Draw(g);
            plrtwo.Draw(g);
        }

        private void BtnArtillery_Click(object sender, EventArgs e)
        {
            BtnExit.Visible = false;
            BtnHelp.Visible = false;
            TurnStart();
            ArtilleryGameTriggered();
            PnlFight.Visible = true;
            BtnFortify.Visible = false;
            BtnHelp.Visible = false;
            BtnShoot.Visible = false;
            BtnArtillery.Visible = false;
            BtnExit.Visible = false;
            LblPlayerOne.Visible = false;
            LblPlayerTwo.Visible = false;
            LblTargetHit.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            GameEnd();
        }

        public void GameEnd()
        {
            gamestart = false;
            BtnSettings.Visible = true;
            BtnStart.Visible = true;
            PnlHome.Visible = false;
            BtnTutorial.Visible = true;
            LblTitle.Visible = true;

        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            TurnStart();
            ShootGameStart();
            ShootGameInuse = true;
            BtnExit.Visible = false;
            BtnHelp.Visible = false;
        }

        private void PnlShoot_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            shoottarget.Draw(g);
            bullet.DrawBullet(g);
        }

        private void TmrShoot_Tick(object sender, EventArgs e)
        {
            DebugY.Text = Convert.ToString(shoottarget.ShootTargetPosY);
            if (shoottarget.ShootTargetPosY > 300)
            {
                ShootTargetDown = false;
                shoottarget.ShootTargetPosY -= 100;
            }
            if (shoottarget.ShootTargetPosY < 1)
            {
                ShootTargetDown = true;
                shoottarget.ShootTargetPosY += 20;
            }
            if (ShootTargetDown == true)
            {
                shoottarget.ShootTargetPosY += 20;
            }
            if (ShootTargetDown == false)
            {
                shoottarget.ShootTargetPosY -= 20;
            }
            if (bulletfired == true)
            {
                bullet.bulletx += 50;
                bullet.BulletRec.Location = new Point(bullet.bulletx, bullet.y);
            }
            if (bulletfired == true)
            {
                if (bullet.BulletRec.IntersectsWith(new Rectangle(shoottarget.ShootPosition, shoottarget.ShootSize)))
                {
                    LblShootTargetHit.Visible = true;
                    ShootTargetHit();
                }
                if (bullet.bulletx > 1000) {
                    LblShootTargetMissed.Visible = true;
                    ShootTargetMissed();
                }
            }
            PnlShoot.Invalidate();
        }

     /*   public void bulletfiredcheck()
        {
            task.run(() =>
            {
                if (bulletfired == true)
                {
                    system.threading.thread.sleep(3000);
                    if (bulletfired == true)
                    {
                        if (bullettargethit == false)
                        {
                            if (bullettargetmissed == false)
                            {
                                invoke((action)(() =>
                                {
                                    lblshoottargetmissed.visible = true;
                                    shoottargetmissed();
                                }));
                            }
                        }
                    }
                }
            });
        } */

        public void ShootGameStart() {
            PnlShoot.Visible = true;
            TmrShoot.Enabled = true;

        }

        public void ShootGameEnd() {
            PnlShoot.Visible = false;
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            ShootGameInuse = false;
            bulletfired = false;
            BulletTargetHit = false;
            BulletTargetMissed = false;
            LblShootTargetMissed.Visible = false;
            LblShootTargetHit.Visible = false;
            bullet.bulletx = 100;
            bullet.BulletRec.Location = new Point(bullet.bulletx, bullet.y);
        }
        public void ShootTargetHit()
        {
            LblTargetHit.Visible = true;
            BulletTargetHit = true;
            TmrShoot.Enabled = false;
            PlayerTwoDefense -= 2;
            TmrDelay.Enabled = true;
        }

        public void ShootTargetMissed() {
            TmrShoot.Enabled = false;
            BulletTargetMissed = true;
            LblShootTargetMissed.Visible = true;
            PlayerOneDefense -= 2;
            TmrDelay.Enabled = true;
        }
        private void BtnHelp_Click(object sender, EventArgs e)
        {

        }

        private void BtnFortify_Click(object sender, EventArgs e)
        {
            TurnStart();
            PlayerOneDefense += 1;
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
        }

        private void TmrDelay_Tick(object sender, EventArgs e)
        {
            ShootGameEnd();
            TmrDelay.Enabled = false;
        }

        public void Gamestart()
        {
            gamestart = true;
            BtnSettings.Visible = false;
            BtnStart.Visible = false;
            BtnTutorial.Visible = false;
            LblTitle.Visible = false;
            PnlBackSplash.Invalidate();
            PnlHome.Visible = true;
            PlayerOneDefense = Difficulty;
            PlayerTwoDefense = Difficulty;
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
        }

        public void TurnStart() {
            BtnShoot.Enabled = false;
            BtnArtillery.Enabled = false;
            BtnFortify.Enabled = false;
        }

        public void AiTurn() {
            if (aiturn.easy == true)
            {
                if (aiturn.AIAttack > 60 & aiturn.AIAttack < 100)
                {
                    AIFortify();
                }
                if (aiturn.AIAttack > 30 & aiturn.AIAttack < 60)
                {
                    AIArtillery();
                }
                if (aiturn.AIAttack > 0 & aiturn.AIAttack < 30)
                {
                    AIShoot();
                }
            }
            if (aiturn.medium == true) 
            {
            }
            if (aiturn.hard == true) 
            {
                
            }
        }

        public void AIFortify() {
            PlayerTwoDefense = +1;
        }
        public void AIArtillery()
        {

        }

        public void AIShoot()
        {

        }
    }
}

