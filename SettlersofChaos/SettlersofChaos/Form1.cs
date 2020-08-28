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
        private Artilltery[] redblocks = new Artilltery[17];
        public int speed = 10;
        public bool BulletTargetMissed = false;
        string shellmove;
        string strlength = " Short";
        string strdifficulty = " Easy";
        string strtheme = " Blue";
        string username = "Underfined";
        string usersettings = "Default";
        public bool easy = true, medium = false, hard = false;
        int MouseX;
        public int Turn;
        int MouseY;
        public bool BulletTargetHit = false;
        public bool AiTurnFinished = true;
        bool ShootTargetDown = true;
        bool ShootGameInuse = false;
        public int PlayerOneDefense = 0;
        public int PlayerTwoDefense = 0;
        bool ArtilleryHit, ArtilleryMissed;
        public bool bulletfired = false;
        bool gamestart = false;
        public bool left, right;
        public bool PlayerOneTurn = true;
        public int Difficulty = 12;
        ArtilleryShell artilleryShell = new ArtilleryShell();
        MenuGameInfo menugameinfo = new MenuGameInfo();
        MenuPlayerInfo menuplayerinfo = new MenuPlayerInfo();
        ArtilleryTarget artilleryTarget = new ArtilleryTarget();
        TutorialImage tutorialimage = new TutorialImage();
        Bullet bullet = new Bullet();
        GameHotbar gamehotbar = new GameHotbar();
        PlayerOne plrone = new PlayerOne();
        PlayerTwo plrtwo = new PlayerTwo();
        Backsplash backsplash = new Backsplash();
        ShootTarget shoottarget = new ShootTarget();
        private Random random;

        public FormGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlBackSplash, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlFight, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlShoot, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlHome, new object[] { true });
            random = new Random();
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
            for (int i = 0; i < 17; i++)
            {
                redblocks[i] = new Artilltery(random, i);
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
                PlayerOneDefense = PlayerOneDefense - 3;
                artilleryShell.x -= 10;
                YouMissedLBL.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;
                ArtilleryHit = true;
                TmrDelay.Enabled = true;

            }
            if (CollidesWithTarget())
            {
                PlayerTwoDefense -= 6;
                artilleryShell.x -= 10;
                LblTargetHit.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;
                ArtilleryMissed = true;
                TmrDelay.Enabled = true;

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
            PnlFight.Location = new Point(0, 60);
            GameBoot();
            TmrArtilleryTicks.Enabled = true;
            TmrShellMove.Enabled = true;
            PnlFight.Visible = true;
            for (int i = 0; i < 17; i++)
            {
                redblocks[i] = new Artilltery(random, i);

            }
            artilleryTarget.TargetPosX = 5000;
            YouMissedLBL.Visible = false;
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
            Console.WriteLine("ArtilelryGame Exited");
            TurnEnd();
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
            LblGameDifficulty.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLength.Text = ("Your game length is" + strlength);
            LblGameTheme.Text = ("Your game theme is" + strtheme);
            menugameinfo.Draw(g);
            menuplayerinfo.Draw(g);
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
            TurnEnd();
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
            PnlHelp.Visible = true;
        }

        private void BtnFortify_Click(object sender, EventArgs e)
        {
            TurnStart();
            PlayerOneDefense += 1;
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            AiTurn();
        }

        private void TmrDelay_Tick(object sender, EventArgs e)
        {
            ArtilleryGameExit();
            ShootGameEnd();
            TmrDelay.Enabled = false;
            if (ArtilleryHit == true)
            {
                PlayerTwoDefense -= 6;
                ArtilleryHit = false;
            }
            if (ArtilleryMissed == true)
            {
                PlayerOneDefense -= 3;
                ArtilleryMissed = false;
            }
        }

        public void Gamestart()
        {
            LblAIAction.Text = "Player One attack to start!";
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
            TmrGame.Enabled = true;
        }

        public void TurnStart() {
            AiTurnFinished = true;
            BtnShoot.Enabled = false;
            BtnArtillery.Enabled = false;
            BtnFortify.Enabled = false;
        }

        public void AiTurn() {

            string AIResponse;
            Random rnd = new Random();
            int AIAttack = rnd.Next(1, 101);  // creates a number between 1 and 100
            int AIAttackSuccses = rnd.Next(1, 101);   // creates a number between 1 and 100
            if (easy == true)
            {
                if (AIAttack >= 61 & AIAttack <= 100)
                {
                    AiTurnFortify();
                    AIResponse = "The AI used Fortify and gained 2HP";
                    Console.WriteLine("The AI used Fortify and gained 2HP");
                    LblAIAction.Text = AIResponse;
                    AITurnEnd();
                }
                else if (AIAttack >= 30 & AIAttack <= 60)
                {
                    if (AIAttackSuccses >= 0 & AIAttackSuccses <= 66)
                    {
                        PlayerOneDefense -= 2;
                        AIResponse = "The AI successfully used Shoot and dealt 2HP";
                        Console.WriteLine("The AI successfully used Shoot and dealt 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                    else
                    {
                        PlayerTwoDefense -= 2;
                        AIResponse = "The AI failed to used Shoot and lost 2HP";
                        Console.WriteLine("The AI failed to used Shoot and lost 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                }
                else if (AIAttack >= 0 & AIAttack <= 29)
                {
                    if (AIAttackSuccses >= 0 & AIAttackSuccses <= 45)
                    {
                        PlayerOneDefense -= 6;
                        AIResponse = "The AI successfully used Artillery and dealt 6HP";
                        Console.WriteLine("The AI successfully used Artillery and dealt 6HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                    else
                    {
                        PlayerTwoDefense -= 3;
                        AIResponse = "The AI failed to used Artillery and lost 3HP";
                        Console.WriteLine("The AI failed to used Artillery and lost 3HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                }
            }
            if (medium == true) 
            {
                if (AIAttack >= 70 & AIAttack <= 100)
                {
                    AiTurnFortify();
                    AIResponse = "The AI used Fortify and gained 2HP";
                    Console.WriteLine("The AI used Fortify and gained 2HP");
                    LblAIAction.Text = AIResponse;
                    AITurnEnd();
                }
                else if (AIAttack >= 40 & AIAttack <= 70)
                {
                    if (AIAttackSuccses >= 0 & AIAttackSuccses <= 77)
                    {
                        PlayerOneDefense -= 2;
                        AIResponse = "The AI successfully used Shoot and dealt 2HP";
                        Console.WriteLine("The AI successfully used Shoot and dealt 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                    else
                    {
                        PlayerTwoDefense -= 2;
                        AIResponse = "The AI failed to used Shoot and lost 2HP";
                        Console.WriteLine("The AI failed to used Shoot and lost 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                }
                else if (AIAttack >= 0 & AIAttack <= 40)
                {
                    if (AIAttackSuccses >= 0 & AIAttackSuccses <= 55)
                    {
                        PlayerOneDefense -= 6;
                        AIResponse = "The AI successfully used Artillery and dealt 6HP";
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                    else
                    {
                        PlayerTwoDefense -= 3;
                        AIResponse = "The AI failed to used Artillery and lost 3HP";
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                }
            }
            if (hard == true) 
            {
                if (AIAttack >= 80 & AIAttack <= 100)
                {
                    AiTurnFortify();
                    AIResponse = "The AI used Fortify and gained 2HP";
                    Console.WriteLine("The AI used Fortify and gained 2HP");
                    LblAIAction.Text = AIResponse;
                    AITurnEnd();
                }
                else if (AIAttack >= 40 & AIAttack <= 80)
                {
                    if (AIAttackSuccses >= 0 & AIAttackSuccses <= 90)
                    {
                        PlayerOneDefense -= 2;
                        AIResponse = "The AI successfully used Shoot and dealt 2HP";
                        Console.WriteLine("The AI successfully used Shoot and dealt 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                    else
                    {
                        PlayerTwoDefense -= 2;
                        AIResponse = "The AI failed to used Shoot and lost 2HP";
                        Console.WriteLine("The AI failed to used Shoot and lost 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                }
                else if (AIAttack >= 0 & AIAttack <= 40)
                {
                    if (AIAttackSuccses >= 0 & AIAttackSuccses <= 70)
                    {
                        PlayerOneDefense -= 6;
                        AIResponse = "The AI successfully used Artillery and dealt 6HP";
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                    else
                    {
                        PlayerTwoDefense -= 3;
                        AIResponse = "The AI failed to used Artillery and lost 3HP";
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                    }
                }
            }
        }

        private void AiTurnFortify()
        {
            PlayerTwoDefense += 2;
            AITurnEnd();
        }

        public void TurnEnd()
        {
            Turn += 1;
            LblTurn.Text = Convert.ToString(Turn);
            Console.WriteLine("Turn Ended");
            if (AiTurnFinished == true)
            {
                AiTurnFinished = false;
                AiTurn();
            }
        }

        public void PlrOneLost()
        {
            LblPlayerLost.Visible = true;
            TmrGameEnd.Enabled = true;
        }

        private void BtnDiffEasy_Click(object sender, EventArgs e)
        {
            strdifficulty = " Easy";
            easy = true;
            medium = false;
            hard = false;
        }

        private void BtnDiffMed_Click(object sender, EventArgs e)
        {
            strdifficulty = " Medium";
            easy = false;
            medium = true;
            hard = false;
        }

        private void BtnDiffHard_Click(object sender, EventArgs e)
        {
            strdifficulty = " Hard";
            easy = false;
            medium = false;
            hard = true;
        }

        private void BtnTimeLong_Click(object sender, EventArgs e)
        {
            strlength = " Long";
            Difficulty = 36;
        }

        private void BtnTimeStandard_Click(object sender, EventArgs e)
        {
            strlength = " Standard";
            Difficulty = 24;
        }

        private void BtnTimeQuick_Click(object sender, EventArgs e)
        {
            strlength = " Quick";
            Difficulty = 12;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlBackSplash.Visible = true;
            PnlMenu.Visible = true;
            PnlSettings.Visible = true;
            BtnDiffEasy.Visible = true;
            BtnDiffHard.Visible = true;
            BtnDiffMed.Visible = true;
            BtnThemePink.Visible = true;
            BtnThemeDark.Visible = true;
            LblTitle.Visible = true;
            BtnThemeBlue.Visible = true;
            BtnTimeStandard.Visible = true;
            BtnTimeQuick.Visible = true;
            BtnTimeLong.Visible = true;
            BtnReturnMenu.Visible = true;
            BtnSettings.Visible = false;
        }

        private void BtnReturnMenu_Click(object sender, EventArgs e)
        {
            PnlBackSplash.Visible = true;
            PnlMenu.Visible = true;
            PnlSettings.Visible = false;
            BtnDiffEasy.Visible = false;
            BtnDiffHard.Visible = false;
            BtnDiffMed.Visible = false;
            BtnThemePink.Visible = false;
            BtnThemeDark.Visible = false;
            BtnThemeBlue.Visible = false;
            BtnTimeStandard.Visible = false;
            BtnTimeQuick.Visible = false;
            BtnTimeLong.Visible = false;
            BtnReturnMenu.Visible = false;
            BtnSettings.Visible = true;
        }

        private void BtnThemePink_Click(object sender, EventArgs e)
        {
            strtheme = " Pink";
            plrone.themepink = true;
            plrone.themeblue = false;
            plrone.themedark = false;
            plrtwo.themepink = true;
            plrtwo.themeblue = false;
            plrtwo.themedark = false;
            gamehotbar.themepink = true;
            gamehotbar.themeblue = false;
            gamehotbar.themedark = false;
            LblAIAction.BackColor = (Color.FromArgb(168, 32, 146));
            PnlHome.BackColor = (Color.FromArgb(219, 90, 198));

        }

        private void BtnThemeDark_Click(object sender, EventArgs e)
        {
            strtheme = " Dark";
            plrone.themedark = true;
            plrone.themepink = false;
            plrone.themeblue = false;
            plrtwo.themedark = true;
            plrtwo.themepink = false;
            plrtwo.themeblue = false;
            gamehotbar.themepink = false;
            gamehotbar.themeblue = false;
            gamehotbar.themedark = true;
            LblAIAction.BackColor = (Color.FromArgb(71, 70, 71));
            PnlHome.BackColor = (Color.FromArgb(145, 145, 145));
        }

        private void BtnThemeBlue_Click(object sender, EventArgs e)
        {
            strtheme = " Blue";
            plrone.themedark = false;
            plrone.themepink = false;
            plrone.themeblue = true;
            plrtwo.themedark = false;
            plrtwo.themepink = false;
            plrtwo.themeblue = true;
            gamehotbar.themepink = false;
            gamehotbar.themeblue = true;
            gamehotbar.themedark = false;
            LblAIAction.BackColor = (Color.FromArgb(39, 61, 227));
            PnlHome.BackColor = (Color.FromArgb(150, 182, 250));
        }

        private void BtnTutorial_Click(object sender, EventArgs e)
        {
            PnlTutorial.Visible = true;
        }

        private void PnlTutorial_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            tutorialimage.Draw(g);
        }

        private void PnlTutorial_Click(object sender, EventArgs e)
        {
            tutorialimage.TutorialLevel += 1;
            PnlTutorial.Invalidate();
            if (tutorialimage.TutorialLevel == 7)
            {
                PnlTutorial.Visible = false;
                tutorialimage.TutorialLevel = 1;
            }
        }

        private void BtnRTG_Click(object sender, EventArgs e)
        {
            PnlHelp.Visible = false;
        }

        private void TmrGame_Tick(object sender, EventArgs e)
        {
            if (PlayerOneDefense < 1)
            {
                PlrOneLost();
            }
            if (PlayerTwoDefense < 1)
            {
                PlrTwoLost();
            }
        }

        private void TmrGameEnd_Tick(object sender, EventArgs e)
        {
            TmrGameEnd.Enabled = false;
            GameEnd();
            LblPlayerLost.Visible = false;
            TmrGame.Enabled = false;

        }

        public void AITurnEnd()
        {
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            BtnShoot.Enabled = true;
            BtnArtillery.Enabled = true;
            BtnFortify.Enabled = true;
        }

        public void PlrTwoLost()
        {
            LblYouWon.Visible = true;
        }
    }
}

