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
        //Declare all of the variables used by the program
        private List<Hexagon> hexagons = new List<Hexagon>();
        private Artilltery[] redblocks = new Artilltery[17];
        public int speed = 10;
        public bool BulletTargetMissed = false;
        string shellmove;
        int Fortifyin = 0;
        string strlength = " Short";
        string strdifficulty = " Easy";
        bool GameEnded = false;
        string strtheme = " Blue";
        string username = "PlayerOne";
        string usersettings = "Default";
        public bool easy = true, medium = false, hard = false;
        int MouseX;
        public int Turn;
        int Fortifies = 1;
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
            //Declare Doublebuffering for all Highmovment pannels
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlBackSplash, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlFight, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlShoot, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlHome, new object[] { true });
            random = new Random();
            var RedAxis = new Random();
            ThemeBlue();
            // Declare all columns, radius and row variables for the hexagonal backsplash
            var shapeback = new Backsplash
            {
                BackRow = 1,
                BackColumn = 1,
                BackRadius = 50,
            };
            // Generate hexagons that are in the ranges specified for the backsplash
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

            // Rangomly generate the Artillery redblocks position
            for (int i = 0; i < 17; i++)
            {
                redblocks[i] = new Artilltery(random, i);
            }
        }
        //Paint Panel Game
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
        //Paint Panel Fight
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
        //Controls movement of RedBlocks for the Artillery Game inside of the main game
        public void ArtilleryTicks_Tick(object sender, EventArgs e)
        {
            foreach (var block in redblocks)
            {
                block.RedPosX -= speed;
            }
            artilleryTarget.TargetPosX -= speed;
            PnlFight.Invalidate();
        }
        //Keydown detection event for the Up, Down and Space keys
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { left = true; }
            if (e.KeyData == Keys.Down) { right = true; }
            if (e.KeyData == Keys.Space) { if (ShootGameInuse == true) { bulletfired = true; } }
        }
        //Timer that has full control over the Artillery Shell.
        private void TmrShellMove_Tick(object sender, EventArgs e)
        {
            //If the Artillery shell collides with the Redblock do this
            if (CollidesWithRedBlock())
            {
                Console.WriteLine("Shell collided with Redblock and dealt 3 damage to Player One");
                PlayerOneDefense -= 3;
                artilleryShell.x -= 10;
                YouMissedLBL.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;
                ArtilleryHit = false;
                ArtilleryMissed = true;
                TmrDelay.Enabled = true;
                Console.WriteLine(PlayerTwoDefense);

            }
            //If the Artillery shell collides with the intended target do this
            if (CollidesWithTarget())
            {
                Console.WriteLine("Shell collided Target and dealt 6 damage to Player Two");
                PlayerTwoDefense -= 6;
                artilleryShell.x -= 10;
                LblTargetHit.Visible = true;
                TmrArtilleryTicks.Enabled = false;
                TmrShellMove.Enabled = false;
                ArtilleryMissed = false;
                ArtilleryHit = true;
                TmrDelay.Enabled = true;
                Console.WriteLine(PlayerTwoDefense);

            }
            //Controls if the shell is moving up or down
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
        //Detection for the redblock and Artillery Shell
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
        //Detection for the Artillery Target
        private bool CollidesWithTarget()
        {
            if (artilleryShell.ShellRec.IntersectsWith(new Rectangle(artilleryTarget.TargetPosition, artilleryTarget.TargetSize)))
            {
                return true;
            }
            return false;
        }
        //Detects if a key has been released only aplicable for UP and Down keys
        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { left = false; }
            if (e.KeyData == Keys.Down) { right = false; }
        }
        //Method for when the Artillery game is Triggered
        public void ArtilleryGameTriggered()
        {
            LblFortify.Visible = false;
            PnlFight.Location = new Point(0, 60);
            GameBoot();
            TmrArtilleryTicks.Enabled = true;
            TmrShellMove.Enabled = true;
            LblPlayerOneName.Visible = false;
            LblPlayerTwoName.Visible = false;
            PnlFight.Visible = true;
            PBPlayerOne.Visible = false;
            PBPlayerTwo.Visible = false;
            for (int i = 0; i < 17; i++)
            {
                redblocks[i] = new Artilltery(random, i);

            }
            artilleryTarget.TargetPosX = 5000;
            YouMissedLBL.Visible = false;
        }
        //Method for when the player exits the Artillery Game
        public void ArtilleryGameExit()
        {
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            LblPlayerOneName.Visible = true;
            LblFortify.Visible = true;
            LblPlayerTwoName.Visible = true;
            LblPlayerOne.Visible = true;
            LblPlayerTwo.Visible = true;
            BtnExit.Visible = true;
            PnlFight.Visible = false;
            PBPlayerOne.Visible = true;
            PBPlayerTwo.Visible = true;
            BtnArtillery.Visible = true;
            BtnShoot.Visible = true;
            BtnFortify.Visible = true;
            Console.WriteLine("ArtilelryGame Exited");
            TurnEnd();
        }
        //Sets the locations of key labels when the Game is booted
        public void GameBoot()
        {
            LblTargetHit.Location = new Point(-3, 20);
            YouMissedLBL.Location = new Point(-3, 20);
        }
        //Paint method for Panel Menu, Also sets the label text and draws the info boxes
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
        //BtnStart if clicked it will start the game and update the labels for the player defenses to match the difficulty set
        private void button1_Click(object sender, EventArgs e)
        {

            Gamestart();
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            LblPlayerOneName.Text = username;
            BtnExit.Visible = true;
            //Username entry
            if (username == "")
            {
                LblPlayerOneName.Text = "PlayerOne";
            }
        }
        //Paint event for the Panel Home
        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            gamehotbar.Draw(g);
            plrone.Draw(g);
            plrtwo.Draw(g);
        }

        //BTnArtillery event, sets certain Pnls, Btns and Labels to on and off depending if they are needed or not
        private void BtnArtillery_Click(object sender, EventArgs e)
        {
            artilleryShell.ShellRec.X = 10;
            BtnExit.Visible = false;
            TurnStart();
            ArtilleryGameTriggered();
            PnlFight.Visible = true;
            BtnFortify.Visible = false;
            BtnShoot.Visible = false;
            BtnArtillery.Visible = false;
            BtnExit.Visible = false;
            LblPlayerOne.Visible = false;
            LblPlayerTwo.Visible = false;
            LblTargetHit.Visible = false;
        }
        //BtnExit for if the player needs o exit the game calls the GameEnd Method;
        private void BtnExit_Click(object sender, EventArgs e)
        {
            GameEnd();
        }
        //For when the player ends the game or the game it ends it will call this method to show and hide what properties are needed
        public void GameEnd()
        {
            gamestart = false;
            BtnSettings.Visible = true;
            BtnStart.Visible = true;
            PnlHome.Visible = false;
            BtnTutorial.Visible = true;
            LblTitle.Visible = true;
        }
        //If BtnShoot is clicked it will run multiple methods and control certain properties
        private void BtnShoot_Click(object sender, EventArgs e)
        {
            TurnStart();
            ShootGameStart();
            PBPlayerTwo.Visible = false;
            PBPlayerOne.Visible = false;
            ShootGameInuse = true;
            BtnExit.Visible = false;
        }
        //Paint event for the Panel Shoot
        private void PnlShoot_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            shoottarget.Draw(g);
            bullet.DrawBullet(g);
        }
        //Timer event controls the Shoot target aswell as the bullet firing for the Shoot minigame
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
            //Detection for the Shootgame intersection
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
        //Shoot Game start method controls the Panel and Timer activation
        public void ShootGameStart() {
            PnlShoot.Visible = true;
            TmrShoot.Enabled = true;

        }
        //Sets the labels and what properties need to be reenabled for the game to continue
        public void ShootGameEnd() {
            PnlShoot.Visible = false;
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            PBPlayerTwo.Visible = true;
            PBPlayerOne.Visible = true;
            LblPlayerOneName.Visible = true;
            LblPlayerTwoName.Visible = true;
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
        //Runs this method for if the player succsesfully hits the target
        public void ShootTargetHit()
        {
            LblTargetHit.Visible = true;
            BulletTargetHit = true;
            TmrShoot.Enabled = false;
            PlayerTwoDefense -= 2;
            TmrDelay.Enabled = true;
        }
        //If the player misses the target it will do what actions are necersary such as Dealing the damage to the player
        public void ShootTargetMissed() {
            TmrShoot.Enabled = false;
            BulletTargetMissed = true;
            LblShootTargetMissed.Visible = true;
            PlayerOneDefense -= 2;
            TmrDelay.Enabled = true;
        }

        //BtnFortify event for when the player wishes to fortify and gain helth and skip their turn
        private void BtnFortify_Click(object sender, EventArgs e)
        {
            BtnFortify.Enabled = false;
            TurnStart();
            PlayerOneDefense += 2;
            Turn += 1;
            Fortifyin = 3;
            Fortifies -= 1;
            LblTurn.Text = Convert.ToString(Turn);
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            AiTurn();
        }
        //Timer that controls the delay after either the ArtilleryGame or Shootgame and ended
        private void TmrDelay_Tick(object sender, EventArgs e)
        {
            ArtilleryGameExit();
            ShootGameEnd();
            TmrDelay.Enabled = false;
            if (ArtilleryHit == true)
            {
                ArtilleryHit = false;
            }
            if (ArtilleryMissed == true)
            {
                ArtilleryMissed = false;
            }
        }

        //If the player starts the game their needs to be certain elements renabled and disabled
        public void Gamestart()
        {
            LblFortify.Visible = true;
            BtnFortify.Enabled = true;
            LblAIAction.Text = "Player One attack to start!";
            gamestart = true;
            LblPlayerLost.Visible = false;
            Turn = 0;
            GameEnded = false;
            BtnSettings.Visible = false;
            BtnExit.Enabled = true;
            BtnStart.Visible = false;
            Fortifies = 1;
            Fortifyin = 3;
            LblFortify.Text = "You have " + Fortifies + " fortifies avalible and " + Fortifyin + " turns till your next";
            BtnTutorial.Visible = false;
            LblTitle.Visible = false;
            PnlBackSplash.Invalidate();
            PnlHome.Visible = true;
            LblPlayerLost.Enabled = true;
            LblPlayerOne.Enabled = true;
            LblPlayerTwo.Enabled = true;
            BtnArtillery.Enabled = true;
            BtnShoot.Enabled = true;
            PBPlayerOne.Enabled = true;
            PBPlayerTwo.Enabled = true;
            PlayerOneDefense = Difficulty;
            PlayerTwoDefense = Difficulty;
            TmrGame.Enabled = true;
        }

        //When the player starts their turn, their is multiple turns in each game
        public void TurnStart() {
            AiTurnFinished = true;
            BtnShoot.Enabled = false;
            BtnArtillery.Enabled = false;
            BtnFortify.Enabled = false;
        }

        //The major method that runs at the end of each players turn that controls the AI players response, It takes a randomly generated set of numbers and comes up with its response. It has a chance of failure or succeding just like the player to ensure their is fairness in the game. Each difficulty of AI has a even Higher chance of completing succsesfully the more difficult attakcs. This mehtod also controls one of the two victory checks and checks for if the player has the ablility to fortify or not.
        public void AiTurn() {
            Console.WriteLine(Fortifyin);
            Console.WriteLine(Fortifies);
            if (Fortifyin > 0)
            {
                BtnFortify.Enabled = false; 
                Fortifyin -= 1;
            }
            if (Fortifyin <= 0)
            {
                Fortifies += 1;
                Fortifyin = 3;
            }
            if (Fortifies >= 1)
            {
                BtnFortify.Enabled = true;
            }
            if (Fortifyin > 0) {
                if (Fortifies == 0)
                {
                    LblFortify.Text = "You have " + Fortifyin + " turns till your next fortify";
                }
            }
            if (Fortifyin > 0 && Fortifies > 0)
            {
                LblFortify.Text = "You have " + Fortifies + " fortifies avalible and " + Fortifyin + " turns till your next";
            }
            if (PlayerOneDefense < 1)
            {
                Console.WriteLine("PlayerOneLost");
                Console.WriteLine(PlayerOneDefense);
                PlrOneLost();
                BtnFortify.Visible = false;
                BtnArtillery.Visible = false;
                BtnExit.Visible = false;
                BtnShoot.Visible = false;
                PBPlayerOne.Visible = false;
                PBPlayerTwo.Visible = false;
                PlayerOneDefense = Difficulty;
            }
            if (PlayerTwoDefense < 1)
            {
                Console.WriteLine("PlayerTwoLost");
                PlrTwoLost();
                LblYouWon.Visible = true;
                BtnFortify.Visible = false;
                BtnArtillery.Visible = false;
                BtnExit.Visible = false;
                BtnShoot.Visible = false;
                PBPlayerOne.Visible = false;
                PBPlayerTwo.Visible = false;
                Console.WriteLine(PlayerTwoDefense);
            }
            string AIResponse;
            Random rnd = new Random();
            int AIAttack = rnd.Next(1, 101);  // creates a number between 1 and 100
            int AIAttackSuccses = rnd.Next(1, 101);   // creates a number between 1 and 100
            if (GameEnded == false)
            {
                if (easy == true)
                {
                    if (AIAttack >= 61 & AIAttack <= 100)
                    {
                        PlayerTwoDefense += 2;
                        AIResponse = "The AI used Fortify and gained 2HP" + "   (" + "Turn:" + Turn + ")";
                        Console.WriteLine("The AI used Fortify and gained 2HP");
                        LblAIAction.Text = AIResponse;
                        AITurnEnd();
                        Console.WriteLine(PlayerTwoDefense + "(Fortify)");
                    }
                    else if (AIAttack >= 30 & AIAttack <= 60)
                    {
                        if (AIAttackSuccses >= 0 & AIAttackSuccses <= 66)
                        {
                            AIResponse = "The AI successfully used Shoot and dealt 2HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI successfully used Shoot and dealt 2HP");
                            Console.WriteLine(PlayerTwoDefense + "(Shoot Suc)");
                            LblAIAction.Text = AIResponse;
                            PlayerOneDefense -= 2;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                        else
                        {
                            AIResponse = "The AI failed to used Shoot and lost 2HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI failed to used Shoot and lost 2HP");
                            Console.WriteLine(PlayerTwoDefense + "(Shoot Fail)");
                            LblAIAction.Text = AIResponse;
                            PlayerTwoDefense -= 2;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                    }
                    else if (AIAttack >= 0 & AIAttack <= 29)
                    {
                        if (AIAttackSuccses >= 0 & AIAttackSuccses <= 45)
                        {
                            AIResponse = "The AI successfully used Artillery and dealt 6HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI successfully used Artillery and dealt 6HP");
                            Console.WriteLine(PlayerTwoDefense + "(Artillery Suc)");
                            LblAIAction.Text = AIResponse;
                            PlayerOneDefense -= 3;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                        else
                        {
                            AIResponse = "The AI failed to used Artillery and lost 3HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI failed to used Artillery and lost 3HP");
                            Console.WriteLine(PlayerTwoDefense + "(Artillery Fail)");
                            LblAIAction.Text = AIResponse;
                            PlayerTwoDefense -= 3;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                    }
                }
                if (medium == true)
                {
                    if (AIAttack >= 70 & AIAttack <= 100)
                    {
                        PlayerTwoDefense += 2;
                        AIResponse = "The AI used Fortify and gained 2HP" + "   (" + "Turn:" + Turn + ")";
                        Console.WriteLine("The AI used Fortify and gained 2HP");
                        LblAIAction.Text = AIResponse;
                        Console.WriteLine(PlayerTwoDefense);
                        AITurnEnd();
                    }
                    else if (AIAttack >= 40 & AIAttack <= 70)
                    {
                        if (AIAttackSuccses >= 0 & AIAttackSuccses <= 77)
                        {
                            PlayerOneDefense -= 2;
                            AIResponse = "The AI successfully used Shoot and dealt 2HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI successfully used Shoot and dealt 2HP");
                            Console.WriteLine(PlayerTwoDefense);
                            LblAIAction.Text = AIResponse;
                            AITurnEnd();
                        }
                        else
                        {
                            PlayerTwoDefense -= 2;
                            AIResponse = "The AI failed to used Shoot and lost 2HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI failed to used Shoot and lost 2HP");
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                    }
                    else if (AIAttack >= 0 & AIAttack <= 40)
                    {
                        if (AIAttackSuccses >= 0 & AIAttackSuccses <= 55)
                        {
                            PlayerOneDefense -= 3;
                            AIResponse = "The AI successfully used Artillery and dealt 6HP" + " (" + "Turn:" + Turn + ")";
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                        else
                        {
                            PlayerTwoDefense -= 3;
                            AIResponse = "The AI failed to used Artillery and lost 3HP" + " (" + "Turn:" + Turn + ")";
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                    }
                }
                if (hard == true)
                {
                    if (AIAttack >= 80 & AIAttack <= 100)
                    {
                        PlayerTwoDefense += 2;
                        AIResponse = "The AI used Fortify and gained 2HP" + "   (" + "Turn:" + Turn + ")";
                        Console.WriteLine("The AI used Fortify and gained 2HP");
                        LblAIAction.Text = AIResponse;
                        Console.WriteLine(PlayerTwoDefense);
                        AITurnEnd();
                    }
                    else if (AIAttack >= 40 & AIAttack <= 80)
                    {
                        if (AIAttackSuccses >= 0 & AIAttackSuccses <= 90)
                        {
                            PlayerOneDefense -= 2;
                            AIResponse = "The AI successfully used Shoot and dealt 2HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI successfully used Shoot and dealt 2HP");
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                        else
                        {
                            PlayerTwoDefense -= 2;
                            AIResponse = "The AI failed to used Shoot and lost 2HP" + " (" + "Turn:" + Turn + ")";
                            Console.WriteLine("The AI failed to used Shoot and lost 2HP");
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                    }
                    else if (AIAttack >= 0 & AIAttack <= 40)
                    {
                        if (AIAttackSuccses >= 0 & AIAttackSuccses <= 70)
                        {
                            PlayerOneDefense -= 3;
                            AIResponse = "The AI successfully used Artillery and dealt 6HP" + " (" + "Turn:" + Turn + ")";
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                        else
                        {
                            PlayerTwoDefense -= 3;
                            AIResponse = "The AI failed to used Artillery and lost 3HP" + " (" + "Turn:" + Turn + ")";
                            LblAIAction.Text = AIResponse;
                            Console.WriteLine(PlayerTwoDefense);
                            AITurnEnd();
                        }
                    }
                }
            }
        }
        //Method to run at the End of the players turn that triggers the AI response
        public void TurnEnd()
        {
            Turn += 1;
            LblTurn.Text = Convert.ToString(Turn);
            Console.WriteLine("Turn Ended");
            if (AiTurnFinished == true)
            {
                AiTurnFinished = false;
                Turn -= 1;
                AiTurn();
            }
        }
        //Method to run if the player one loses the game
        public void PlrOneLost()
        {
            LblFortify.Visible = false;
            LblPlayerLost.Visible = true;
            LblYouWon.Visible = false;
            TmrGameEnd.Enabled = true;
            LblYouWon.Visible = false;
            LblPlayerLost.Visible = true;
            LblPlayerOne.Visible = false;
            LblPlayerTwo.Visible = false;
            BtnArtillery.Visible = false;
            BtnFortify.Visible = false;
            BtnShoot.Visible = false;
            PBPlayerOne.Visible = false;
            PBPlayerTwo.Visible = false;
            LblPlayerLost.Enabled = false;
            LblPlayerOne.Enabled = false;
            LblPlayerTwo.Enabled = false;
            BtnArtillery.Enabled = false;
            BtnFortify.Enabled = false;
            BtnShoot.Enabled = false;
            PBPlayerOne.Enabled = false;
            PBPlayerTwo.Enabled = false;
            BtnExit.Enabled = false;
            BtnExit.Visible = false;
            GameEnded = true;
        }

        //Button for if the player selects the Easy difficulty setting
        private void BtnDiffEasy_Click(object sender, EventArgs e)
        {
            strdifficulty = " Easy";
            easy = true;
            medium = false;
            hard = false;
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Button for if the player selects the Medium difficulty setting
        private void BtnDiffMed_Click(object sender, EventArgs e)
        {
            strdifficulty = " Medium";
            easy = false;
            medium = true;
            hard = false;
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Button for if the player selects the Hard difficulty setting
        private void BtnDiffHard_Click(object sender, EventArgs e)
        {
            strdifficulty = " Hard";
            easy = false;
            medium = false;
            hard = true;
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Button for if the player selects the Long length of time, long being the amount of defense each player has significantly increasing the games length
        private void BtnTimeLong_Click(object sender, EventArgs e)
        {
            strlength = " Long";
            Difficulty = 36;
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Button for if the player selects the standard length of time, standard being the amount of defense each player has significantly increasing the games length
        private void BtnTimeStandard_Click(object sender, EventArgs e)
        {
            strlength = " Standard";
            Difficulty = 24;
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Button for if the player selects the quick length of time, quick being the amount of defense each player has significantly increasing the games length
        private void BtnTimeQuick_Click(object sender, EventArgs e)
        {
            strlength = " Quick";
            Difficulty = 12;
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Button to take the player to the settings menu
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlBackSplash.Visible = true;
            LblGameDifficulty.Visible = true;
            LblGameLength.Visible = true;
            LblGameTheme.Visible = true;
            menuplayerinfo.settingsvissible = true;
            menugameinfo.settingsvissible = true;
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
            TbUsername.Visible = false;
        }
        //Button to return the player from the settings menu
        private void BtnReturnMenu_Click(object sender, EventArgs e)
        {
            PnlBackSplash.Visible = true;
            PnlMenu.Visible = true;
            menuplayerinfo.settingsvissible = false;
            menugameinfo.settingsvissible = false;
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
            TbUsername.Visible = true;
        }
        //Button to change the theme colour to a pinky theme
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
            menugameinfo.themepink = true;
            menugameinfo.themeblue = false;
            menugameinfo.themedark = false;
            menuplayerinfo.themepink = true;
            menuplayerinfo.themeblue = false;
            menuplayerinfo.themedark = false;
            LblAIAction.BackColor = (Color.FromArgb(168, 32, 146));
            PnlHome.BackColor = (Color.FromArgb(219, 90, 198));
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
            PnlSettings.Invalidate();

        }
        //Button to change the theme to a colour of Dark grey ish
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
            menugameinfo.themepink = true;
            menugameinfo.themeblue = false;
            menugameinfo.themedark = true;
            menuplayerinfo.themepink = false;
            menuplayerinfo.themeblue = false;
            menuplayerinfo.themedark = true;
            LblAIAction.BackColor = (Color.FromArgb(71, 70, 71));
            PnlHome.BackColor = (Color.FromArgb(145, 145, 145));
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
            PnlSettings.Invalidate();
        }
        //Button to change the theme to a blueish colour for the whole game
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
            menugameinfo.themepink = false;
            menugameinfo.themeblue = true;
            menugameinfo.themedark = false;
            menuplayerinfo.themepink = false;
            menuplayerinfo.themeblue = true;
            menuplayerinfo.themedark = false;
            LblAIAction.BackColor = (Color.FromArgb(39, 61, 227));
            PnlHome.BackColor = (Color.FromArgb(150, 182, 250));
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
            PnlSettings.Invalidate();
        }
        //Starts the Tutorial for the player to click through
        private void BtnTutorial_Click(object sender, EventArgs e)
        {
            PnlTutorial.Visible = true;
        }
        //Paints the Panel tutorial images
        private void PnlTutorial_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            tutorialimage.Draw(g);
        }
        //The event that controls the player moving through the Tutorial
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
        //Changes the username string when the player edits the Text box
        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            username = TbUsername.Text;
            LblPlayerName.Text = username;
        }
        //Paints the PnlSettings chaging the Labels to what they need to be
        private void PnlSettings_Paint(object sender, PaintEventArgs e)
        {
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
        }
        //Debug to console log the PlayerTwo's defense for debuging purposes
        private void LblPlayerTwo_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(PlayerTwoDefense);
        }
        //Timer that runs throughout the whole game and controls wether the game is completed and who has won. One of two events that do this
        private void TmrGame_Tick(object sender, EventArgs e)
        {
            if (PlayerOneDefense < 1)
            {
                Console.WriteLine("PlayerOneLost");
                Console.WriteLine(PlayerOneDefense);
                PlrOneLost();
                PlayerOneDefense = Difficulty;
                BtnFortify.Visible = false;
                BtnArtillery.Visible = false;
                BtnExit.Visible = false;
                BtnShoot.Visible = false;
                PBPlayerOne.Visible = false;
                PBPlayerTwo.Visible = false;
                BtnFortify.Enabled = false;
                BtnExit.Enabled = false;
            }
            if (PlayerTwoDefense < 1)
            {
                Console.WriteLine("PlayerTwoLost");
                PlrTwoLost();
                LblYouWon.Visible = true;
                Console.WriteLine(PlayerTwoDefense);
                BtnFortify.Visible = false;
                BtnArtillery.Visible = false;
                BtnExit.Visible = false;
                BtnShoot.Visible = false;
                PBPlayerOne.Visible = false;
                PBPlayerTwo.Visible = false;
            }
        }
        //Timer that controls the delay at the end of game for the purpose of showing the victory or defeat purpose
        private void TmrGameEnd_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Game Ended");
            TmrGameEnd.Enabled = false;
            GameEnd();
            LblPlayerLost.Visible = false;
            TmrGame.Enabled = false;
            LblYouWon.Visible = false;
            LblPlayerLost.Visible = true;
            LblPlayerOne.Visible = true;
            LblPlayerTwo.Visible = true;
            BtnArtillery.Visible = true;
            BtnFortify.Visible = true;
            BtnShoot.Visible = true;
            PBPlayerOne.Visible = true;
            PBPlayerTwo.Visible = true;
        }
        //Method to run when the AI finishes their turn and renables buttons for the player to continue
        public void AITurnEnd()
        {
            LblPlayerOne.Text = Convert.ToString(PlayerOneDefense);
            LblPlayerTwo.Text = Convert.ToString(PlayerTwoDefense);
            BtnShoot.Enabled = true;
            BtnArtillery.Enabled = true;
        }

        //method for if PlrTwo loses. If PlrTwo loses then the main player or the Human wins the game
        public void PlrTwoLost()
        {
            LblFortify.Visible = false;
            TmrGameEnd.Enabled = true;
            LblYouWon.Visible = true;
            LblPlayerLost.Visible = false;
            LblPlayerOne.Visible = false;
            LblPlayerTwo.Visible = false;
            BtnArtillery.Visible = false;
            BtnFortify.Visible = false;
            BtnShoot.Visible = false;
            PBPlayerOne.Visible = false;
            PBPlayerTwo.Visible = false;
            PlayerTwoDefense = Difficulty;
            LblPlayerLost.Visible = false;
            LblPlayerOne.Visible = false;
            LblPlayerTwo.Visible = false;
            BtnArtillery.Visible = false;
            BtnFortify.Visible = false;
            BtnShoot.Visible = false;
            PBPlayerOne.Visible = false;
            PBPlayerTwo.Visible = false;
            LblPlayerLost.Enabled = false;
            LblPlayerOne.Enabled = false;
            LblPlayerTwo.Enabled = false;
            BtnArtillery.Enabled = false;
            BtnFortify.Enabled = false;
            BtnShoot.Enabled = false;
            PBPlayerOne.Enabled = false;
            PBPlayerTwo.Enabled = false;
            BtnExit.Enabled = false;
            BtnExit.Visible = false;
            GameEnded = true;
        }
        //Theme for the background of the game as defualt
        private void ThemeBlue()
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
            menugameinfo.themepink = false;
            menugameinfo.themeblue = true;
            menugameinfo.themedark = false;
            menuplayerinfo.themepink = false;
            menuplayerinfo.themeblue = true;
            menuplayerinfo.themedark = false;
            LblAIAction.BackColor = (Color.FromArgb(39, 61, 227));
            PnlHome.BackColor = (Color.FromArgb(150, 182, 250));
            LblGameDiffSettings.Text = ("Your game difficulty is" + strdifficulty);
            LblGameLengthSettings.Text = ("Your game length is" + strlength);
            LblGameThemeSettings.Text = ("Your game theme is" + strtheme);
            PnlSettings.Invalidate();
        }
    }
}
