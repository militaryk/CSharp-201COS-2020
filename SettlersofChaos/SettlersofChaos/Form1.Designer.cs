namespace SettlersofChaos
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlBackSplash = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlHome = new System.Windows.Forms.Panel();
            this.PnlHelp = new System.Windows.Forms.Panel();
            this.BtnRTG = new System.Windows.Forms.Button();
            this.LblHelp = new System.Windows.Forms.Label();
            this.BtnHowtoplay = new System.Windows.Forms.Button();
            this.BtnDefense = new System.Windows.Forms.Button();
            this.BtnAttacking = new System.Windows.Forms.Button();
            this.LblTurnName = new System.Windows.Forms.Label();
            this.LblTurn = new System.Windows.Forms.Label();
            this.LblAIAction = new System.Windows.Forms.Label();
            this.PnlShoot = new System.Windows.Forms.Panel();
            this.LblShootTargetMissed = new System.Windows.Forms.Label();
            this.LblShootTargetHit = new System.Windows.Forms.Label();
            this.LblPlayerTwo = new System.Windows.Forms.Label();
            this.LblPlayerOne = new System.Windows.Forms.Label();
            this.BtnShoot = new System.Windows.Forms.Button();
            this.BtnArtillery = new System.Windows.Forms.Button();
            this.PnlFight = new System.Windows.Forms.Panel();
            this.YouMissedLBL = new System.Windows.Forms.Label();
            this.LblTargetHit = new System.Windows.Forms.Label();
            this.BtnFortify = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblYouWon = new System.Windows.Forms.Label();
            this.PnlTutorial = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.BtnReturnMenu = new System.Windows.Forms.Button();
            this.BtnThemeDark = new System.Windows.Forms.Button();
            this.BtnThemePink = new System.Windows.Forms.Button();
            this.BtnThemeBlue = new System.Windows.Forms.Button();
            this.BtnTimeLong = new System.Windows.Forms.Button();
            this.BtnTimeStandard = new System.Windows.Forms.Button();
            this.LblSettings = new System.Windows.Forms.Label();
            this.BtnTimeQuick = new System.Windows.Forms.Button();
            this.BtnDiffHard = new System.Windows.Forms.Button();
            this.BtnDiffMed = new System.Windows.Forms.Button();
            this.BtnDiffEasy = new System.Windows.Forms.Button();
            this.LblPlayerLost = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnTutorial = new System.Windows.Forms.Button();
            this.LblPlayerDetails = new System.Windows.Forms.Label();
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.LblPlayerIntro = new System.Windows.Forms.Label();
            this.LblGameTheme = new System.Windows.Forms.Label();
            this.LblGameLength = new System.Windows.Forms.Label();
            this.LblGameDifficulty = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TmrArtilleryTicks = new System.Windows.Forms.Timer(this.components);
            this.TmrShellMove = new System.Windows.Forms.Timer(this.components);
            this.TmrShoot = new System.Windows.Forms.Timer(this.components);
            this.TmrDelay = new System.Windows.Forms.Timer(this.components);
            this.TmrGame = new System.Windows.Forms.Timer(this.components);
            this.TmrGameEnd = new System.Windows.Forms.Timer(this.components);
            this.PnlBackSplash.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlHome.SuspendLayout();
            this.PnlHelp.SuspendLayout();
            this.PnlShoot.SuspendLayout();
            this.PnlFight.SuspendLayout();
            this.PnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBackSplash
            // 
            this.PnlBackSplash.Controls.Add(this.PnlMenu);
            this.PnlBackSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBackSplash.Location = new System.Drawing.Point(0, 0);
            this.PnlBackSplash.Name = "PnlBackSplash";
            this.PnlBackSplash.Size = new System.Drawing.Size(784, 461);
            this.PnlBackSplash.TabIndex = 0;
            this.PnlBackSplash.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlBackSplash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseDown);
            // 
            // PnlMenu
            // 
            this.PnlMenu.AutoSize = true;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PnlMenu.Controls.Add(this.PnlHome);
            this.PnlMenu.Controls.Add(this.PnlTutorial);
            this.PnlMenu.Controls.Add(this.BtnSettings);
            this.PnlMenu.Controls.Add(this.PnlSettings);
            this.PnlMenu.Controls.Add(this.LblTitle);
            this.PnlMenu.Controls.Add(this.BtnTutorial);
            this.PnlMenu.Controls.Add(this.LblPlayerDetails);
            this.PnlMenu.Controls.Add(this.LblPlayerName);
            this.PnlMenu.Controls.Add(this.LblPlayerIntro);
            this.PnlMenu.Controls.Add(this.LblGameTheme);
            this.PnlMenu.Controls.Add(this.LblGameLength);
            this.PnlMenu.Controls.Add(this.LblGameDifficulty);
            this.PnlMenu.Controls.Add(this.BtnStart);
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(803, 503);
            this.PnlMenu.TabIndex = 3;
            this.PnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // PnlHome
            // 
            this.PnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(188)))));
            this.PnlHome.Controls.Add(this.PnlHelp);
            this.PnlHome.Controls.Add(this.LblTurnName);
            this.PnlHome.Controls.Add(this.LblTurn);
            this.PnlHome.Controls.Add(this.LblAIAction);
            this.PnlHome.Controls.Add(this.PnlShoot);
            this.PnlHome.Controls.Add(this.LblPlayerTwo);
            this.PnlHome.Controls.Add(this.LblPlayerOne);
            this.PnlHome.Controls.Add(this.BtnShoot);
            this.PnlHome.Controls.Add(this.BtnArtillery);
            this.PnlHome.Controls.Add(this.PnlFight);
            this.PnlHome.Controls.Add(this.BtnFortify);
            this.PnlHome.Controls.Add(this.BtnHelp);
            this.PnlHome.Controls.Add(this.BtnExit);
            this.PnlHome.Controls.Add(this.LblYouWon);
            this.PnlHome.Location = new System.Drawing.Point(0, 0);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(800, 500);
            this.PnlHome.TabIndex = 4;
            this.PnlHome.Visible = false;
            this.PnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHome_Paint);
            // 
            // PnlHelp
            // 
            this.PnlHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlHelp.Controls.Add(this.BtnRTG);
            this.PnlHelp.Controls.Add(this.LblHelp);
            this.PnlHelp.Controls.Add(this.BtnHowtoplay);
            this.PnlHelp.Controls.Add(this.BtnDefense);
            this.PnlHelp.Controls.Add(this.BtnAttacking);
            this.PnlHelp.Location = new System.Drawing.Point(0, 0);
            this.PnlHelp.Name = "PnlHelp";
            this.PnlHelp.Size = new System.Drawing.Size(784, 461);
            this.PnlHelp.TabIndex = 13;
            this.PnlHelp.Visible = false;
            // 
            // BtnRTG
            // 
            this.BtnRTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRTG.Location = new System.Drawing.Point(41, 391);
            this.BtnRTG.Name = "BtnRTG";
            this.BtnRTG.Size = new System.Drawing.Size(702, 54);
            this.BtnRTG.TabIndex = 4;
            this.BtnRTG.Text = "Return to Game";
            this.BtnRTG.UseVisualStyleBackColor = true;
            this.BtnRTG.Click += new System.EventHandler(this.BtnRTG_Click);
            // 
            // LblHelp
            // 
            this.LblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblHelp.Location = new System.Drawing.Point(40, 9);
            this.LblHelp.Name = "LblHelp";
            this.LblHelp.Size = new System.Drawing.Size(702, 115);
            this.LblHelp.TabIndex = 3;
            this.LblHelp.Text = "Help";
            this.LblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHowtoplay
            // 
            this.BtnHowtoplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHowtoplay.Location = new System.Drawing.Point(41, 127);
            this.BtnHowtoplay.Name = "BtnHowtoplay";
            this.BtnHowtoplay.Size = new System.Drawing.Size(702, 54);
            this.BtnHowtoplay.TabIndex = 2;
            this.BtnHowtoplay.Text = "How to play";
            this.BtnHowtoplay.UseVisualStyleBackColor = true;
            // 
            // BtnDefense
            // 
            this.BtnDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefense.Location = new System.Drawing.Point(41, 278);
            this.BtnDefense.Name = "BtnDefense";
            this.BtnDefense.Size = new System.Drawing.Size(702, 54);
            this.BtnDefense.TabIndex = 1;
            this.BtnDefense.Text = "Defense";
            this.BtnDefense.UseVisualStyleBackColor = true;
            // 
            // BtnAttacking
            // 
            this.BtnAttacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttacking.Location = new System.Drawing.Point(40, 205);
            this.BtnAttacking.Name = "BtnAttacking";
            this.BtnAttacking.Size = new System.Drawing.Size(702, 54);
            this.BtnAttacking.TabIndex = 0;
            this.BtnAttacking.Text = "Attacking";
            this.BtnAttacking.UseVisualStyleBackColor = true;
            // 
            // LblTurnName
            // 
            this.LblTurnName.BackColor = System.Drawing.Color.White;
            this.LblTurnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurnName.Location = new System.Drawing.Point(342, 403);
            this.LblTurnName.Name = "LblTurnName";
            this.LblTurnName.Size = new System.Drawing.Size(100, 21);
            this.LblTurnName.TabIndex = 11;
            this.LblTurnName.Text = "Turn";
            this.LblTurnName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblTurn
            // 
            this.LblTurn.BackColor = System.Drawing.Color.White;
            this.LblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurn.Location = new System.Drawing.Point(342, 424);
            this.LblTurn.Name = "LblTurn";
            this.LblTurn.Size = new System.Drawing.Size(100, 35);
            this.LblTurn.TabIndex = 10;
            this.LblTurn.Text = "0";
            this.LblTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblAIAction
            // 
            this.LblAIAction.BackColor = System.Drawing.Color.MidnightBlue;
            this.LblAIAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAIAction.ForeColor = System.Drawing.Color.White;
            this.LblAIAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAIAction.Location = new System.Drawing.Point(0, 0);
            this.LblAIAction.Name = "LblAIAction";
            this.LblAIAction.Size = new System.Drawing.Size(784, 27);
            this.LblAIAction.TabIndex = 2;
            this.LblAIAction.Text = "Player Two Attacks";
            this.LblAIAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlShoot
            // 
            this.PnlShoot.BackColor = System.Drawing.Color.Gray;
            this.PnlShoot.Controls.Add(this.LblShootTargetMissed);
            this.PnlShoot.Controls.Add(this.LblShootTargetHit);
            this.PnlShoot.ForeColor = System.Drawing.Color.Black;
            this.PnlShoot.Location = new System.Drawing.Point(0, 0);
            this.PnlShoot.Name = "PnlShoot";
            this.PnlShoot.Size = new System.Drawing.Size(784, 400);
            this.PnlShoot.TabIndex = 7;
            this.PnlShoot.Visible = false;
            this.PnlShoot.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlShoot_Paint);
            // 
            // LblShootTargetMissed
            // 
            this.LblShootTargetMissed.AutoSize = true;
            this.LblShootTargetMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShootTargetMissed.ForeColor = System.Drawing.Color.Firebrick;
            this.LblShootTargetMissed.Location = new System.Drawing.Point(93, 163);
            this.LblShootTargetMissed.Name = "LblShootTargetMissed";
            this.LblShootTargetMissed.Size = new System.Drawing.Size(571, 108);
            this.LblShootTargetMissed.TabIndex = 1;
            this.LblShootTargetMissed.Text = "You Missed!";
            this.LblShootTargetMissed.Visible = false;
            // 
            // LblShootTargetHit
            // 
            this.LblShootTargetHit.AutoSize = true;
            this.LblShootTargetHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShootTargetHit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblShootTargetHit.Location = new System.Drawing.Point(135, 150);
            this.LblShootTargetHit.Name = "LblShootTargetHit";
            this.LblShootTargetHit.Size = new System.Drawing.Size(529, 108);
            this.LblShootTargetHit.TabIndex = 0;
            this.LblShootTargetHit.Text = "Good Shot!";
            this.LblShootTargetHit.Visible = false;
            // 
            // LblPlayerTwo
            // 
            this.LblPlayerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPlayerTwo.BackColor = System.Drawing.Color.White;
            this.LblPlayerTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerTwo.Location = new System.Drawing.Point(570, 200);
            this.LblPlayerTwo.Name = "LblPlayerTwo";
            this.LblPlayerTwo.Size = new System.Drawing.Size(160, 50);
            this.LblPlayerTwo.TabIndex = 6;
            this.LblPlayerTwo.Text = "label2";
            this.LblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPlayerOne
            // 
            this.LblPlayerOne.BackColor = System.Drawing.Color.White;
            this.LblPlayerOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerOne.Location = new System.Drawing.Point(70, 200);
            this.LblPlayerOne.Name = "LblPlayerOne";
            this.LblPlayerOne.Size = new System.Drawing.Size(160, 50);
            this.LblPlayerOne.TabIndex = 5;
            this.LblPlayerOne.Text = "label1";
            this.LblPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnShoot
            // 
            this.BtnShoot.BackColor = System.Drawing.Color.White;
            this.BtnShoot.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.BtnShoot.ForeColor = System.Drawing.Color.Black;
            this.BtnShoot.Location = new System.Drawing.Point(319, 103);
            this.BtnShoot.Name = "BtnShoot";
            this.BtnShoot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShoot.Size = new System.Drawing.Size(163, 41);
            this.BtnShoot.TabIndex = 4;
            this.BtnShoot.Text = "Shoot";
            this.BtnShoot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnShoot.UseVisualStyleBackColor = false;
            this.BtnShoot.Click += new System.EventHandler(this.BtnShoot_Click);
            // 
            // BtnArtillery
            // 
            this.BtnArtillery.BackColor = System.Drawing.Color.White;
            this.BtnArtillery.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.BtnArtillery.ForeColor = System.Drawing.Color.Black;
            this.BtnArtillery.Location = new System.Drawing.Point(319, 170);
            this.BtnArtillery.Name = "BtnArtillery";
            this.BtnArtillery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnArtillery.Size = new System.Drawing.Size(163, 41);
            this.BtnArtillery.TabIndex = 3;
            this.BtnArtillery.Text = "Artillery";
            this.BtnArtillery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnArtillery.UseVisualStyleBackColor = false;
            this.BtnArtillery.Click += new System.EventHandler(this.BtnArtillery_Click);
            // 
            // PnlFight
            // 
            this.PnlFight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PnlFight.Controls.Add(this.YouMissedLBL);
            this.PnlFight.Controls.Add(this.LblTargetHit);
            this.PnlFight.Location = new System.Drawing.Point(60, 457);
            this.PnlFight.Name = "PnlFight";
            this.PnlFight.Size = new System.Drawing.Size(800, 300);
            this.PnlFight.TabIndex = 0;
            this.PnlFight.Visible = false;
            this.PnlFight.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFight_Paint);
            // 
            // YouMissedLBL
            // 
            this.YouMissedLBL.BackColor = System.Drawing.Color.Transparent;
            this.YouMissedLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.YouMissedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.YouMissedLBL.ForeColor = System.Drawing.Color.Red;
            this.YouMissedLBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YouMissedLBL.Location = new System.Drawing.Point(-357, 176);
            this.YouMissedLBL.Name = "YouMissedLBL";
            this.YouMissedLBL.Size = new System.Drawing.Size(800, 300);
            this.YouMissedLBL.TabIndex = 0;
            this.YouMissedLBL.Text = "You Missed";
            this.YouMissedLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YouMissedLBL.Visible = false;
            // 
            // LblTargetHit
            // 
            this.LblTargetHit.BackColor = System.Drawing.Color.Transparent;
            this.LblTargetHit.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTargetHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.LblTargetHit.ForeColor = System.Drawing.Color.Aqua;
            this.LblTargetHit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblTargetHit.Location = new System.Drawing.Point(-27, -33);
            this.LblTargetHit.Name = "LblTargetHit";
            this.LblTargetHit.Size = new System.Drawing.Size(800, 300);
            this.LblTargetHit.TabIndex = 1;
            this.LblTargetHit.Text = "Target Hit";
            this.LblTargetHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTargetHit.Visible = false;
            // 
            // BtnFortify
            // 
            this.BtnFortify.BackColor = System.Drawing.Color.White;
            this.BtnFortify.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.BtnFortify.ForeColor = System.Drawing.Color.Black;
            this.BtnFortify.Location = new System.Drawing.Point(319, 230);
            this.BtnFortify.Name = "BtnFortify";
            this.BtnFortify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFortify.Size = new System.Drawing.Size(163, 41);
            this.BtnFortify.TabIndex = 2;
            this.BtnFortify.Text = "Fortify";
            this.BtnFortify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFortify.UseVisualStyleBackColor = false;
            this.BtnFortify.Click += new System.EventHandler(this.BtnFortify_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.White;
            this.BtnHelp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.Black;
            this.BtnHelp.Location = new System.Drawing.Point(573, 409);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnHelp.Size = new System.Drawing.Size(199, 42);
            this.BtnHelp.TabIndex = 1;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(12, 409);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.Size = new System.Drawing.Size(163, 41);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Forfeit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblYouWon
            // 
            this.LblYouWon.AutoSize = true;
            this.LblYouWon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblYouWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYouWon.ForeColor = System.Drawing.Color.Lime;
            this.LblYouWon.Location = new System.Drawing.Point(146, 150);
            this.LblYouWon.Name = "LblYouWon";
            this.LblYouWon.Size = new System.Drawing.Size(467, 110);
            this.LblYouWon.TabIndex = 12;
            this.LblYouWon.Text = "You Won!";
            this.LblYouWon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblYouWon.Visible = false;
            // 
            // PnlTutorial
            // 
            this.PnlTutorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlTutorial.Location = new System.Drawing.Point(0, 0);
            this.PnlTutorial.Name = "PnlTutorial";
            this.PnlTutorial.Size = new System.Drawing.Size(784, 461);
            this.PnlTutorial.TabIndex = 2;
            this.PnlTutorial.Visible = false;
            this.PnlTutorial.Click += new System.EventHandler(this.PnlTutorial_Click);
            this.PnlTutorial.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTutorial_Paint);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.White;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.Black;
            this.BtnSettings.Location = new System.Drawing.Point(206, 313);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(384, 90);
            this.BtnSettings.TabIndex = 2;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // PnlSettings
            // 
            this.PnlSettings.BackColor = System.Drawing.Color.Transparent;
            this.PnlSettings.Controls.Add(this.BtnReturnMenu);
            this.PnlSettings.Controls.Add(this.BtnThemeDark);
            this.PnlSettings.Controls.Add(this.BtnThemePink);
            this.PnlSettings.Controls.Add(this.BtnThemeBlue);
            this.PnlSettings.Controls.Add(this.BtnTimeLong);
            this.PnlSettings.Controls.Add(this.BtnTimeStandard);
            this.PnlSettings.Controls.Add(this.LblSettings);
            this.PnlSettings.Controls.Add(this.BtnTimeQuick);
            this.PnlSettings.Controls.Add(this.BtnDiffHard);
            this.PnlSettings.Controls.Add(this.BtnDiffMed);
            this.PnlSettings.Controls.Add(this.BtnDiffEasy);
            this.PnlSettings.Controls.Add(this.LblPlayerLost);
            this.PnlSettings.Location = new System.Drawing.Point(0, 0);
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(784, 461);
            this.PnlSettings.TabIndex = 99;
            this.PnlSettings.Visible = false;
            // 
            // BtnReturnMenu
            // 
            this.BtnReturnMenu.Location = new System.Drawing.Point(100, 400);
            this.BtnReturnMenu.Name = "BtnReturnMenu";
            this.BtnReturnMenu.Size = new System.Drawing.Size(586, 45);
            this.BtnReturnMenu.TabIndex = 10;
            this.BtnReturnMenu.TabStop = false;
            this.BtnReturnMenu.Text = "Back";
            this.BtnReturnMenu.UseVisualStyleBackColor = true;
            this.BtnReturnMenu.Visible = false;
            this.BtnReturnMenu.Click += new System.EventHandler(this.BtnReturnMenu_Click);
            // 
            // BtnThemeDark
            // 
            this.BtnThemeDark.BackColor = System.Drawing.Color.Black;
            this.BtnThemeDark.ForeColor = System.Drawing.Color.White;
            this.BtnThemeDark.Location = new System.Drawing.Point(585, 343);
            this.BtnThemeDark.Name = "BtnThemeDark";
            this.BtnThemeDark.Size = new System.Drawing.Size(145, 34);
            this.BtnThemeDark.TabIndex = 9;
            this.BtnThemeDark.TabStop = false;
            this.BtnThemeDark.Text = "Dark";
            this.BtnThemeDark.UseVisualStyleBackColor = false;
            this.BtnThemeDark.Visible = false;
            this.BtnThemeDark.Click += new System.EventHandler(this.BtnThemeDark_Click);
            // 
            // BtnThemePink
            // 
            this.BtnThemePink.BackColor = System.Drawing.Color.Pink;
            this.BtnThemePink.Location = new System.Drawing.Point(586, 303);
            this.BtnThemePink.Name = "BtnThemePink";
            this.BtnThemePink.Size = new System.Drawing.Size(145, 34);
            this.BtnThemePink.TabIndex = 8;
            this.BtnThemePink.TabStop = false;
            this.BtnThemePink.Text = "Pink";
            this.BtnThemePink.UseVisualStyleBackColor = false;
            this.BtnThemePink.Visible = false;
            this.BtnThemePink.Click += new System.EventHandler(this.BtnThemePink_Click);
            // 
            // BtnThemeBlue
            // 
            this.BtnThemeBlue.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnThemeBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnThemeBlue.Location = new System.Drawing.Point(585, 263);
            this.BtnThemeBlue.Name = "BtnThemeBlue";
            this.BtnThemeBlue.Size = new System.Drawing.Size(145, 34);
            this.BtnThemeBlue.TabIndex = 7;
            this.BtnThemeBlue.TabStop = false;
            this.BtnThemeBlue.Text = "Blue";
            this.BtnThemeBlue.UseVisualStyleBackColor = false;
            this.BtnThemeBlue.Visible = false;
            this.BtnThemeBlue.Click += new System.EventHandler(this.BtnThemeBlue_Click);
            // 
            // BtnTimeLong
            // 
            this.BtnTimeLong.Location = new System.Drawing.Point(219, 343);
            this.BtnTimeLong.Name = "BtnTimeLong";
            this.BtnTimeLong.Size = new System.Drawing.Size(145, 34);
            this.BtnTimeLong.TabIndex = 6;
            this.BtnTimeLong.TabStop = false;
            this.BtnTimeLong.Text = "Long";
            this.BtnTimeLong.UseVisualStyleBackColor = true;
            this.BtnTimeLong.Visible = false;
            this.BtnTimeLong.Click += new System.EventHandler(this.BtnTimeLong_Click);
            // 
            // BtnTimeStandard
            // 
            this.BtnTimeStandard.Location = new System.Drawing.Point(219, 303);
            this.BtnTimeStandard.Name = "BtnTimeStandard";
            this.BtnTimeStandard.Size = new System.Drawing.Size(145, 34);
            this.BtnTimeStandard.TabIndex = 5;
            this.BtnTimeStandard.TabStop = false;
            this.BtnTimeStandard.Text = "Standard";
            this.BtnTimeStandard.UseVisualStyleBackColor = true;
            this.BtnTimeStandard.Visible = false;
            this.BtnTimeStandard.Click += new System.EventHandler(this.BtnTimeStandard_Click);
            // 
            // LblSettings
            // 
            this.LblSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSettings.Font = new System.Drawing.Font("Rockwell", 50F);
            this.LblSettings.Location = new System.Drawing.Point(133, 60);
            this.LblSettings.Name = "LblSettings";
            this.LblSettings.Size = new System.Drawing.Size(531, 82);
            this.LblSettings.TabIndex = 4;
            this.LblSettings.Text = "Settings";
            this.LblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnTimeQuick
            // 
            this.BtnTimeQuick.Location = new System.Drawing.Point(218, 263);
            this.BtnTimeQuick.Name = "BtnTimeQuick";
            this.BtnTimeQuick.Size = new System.Drawing.Size(145, 34);
            this.BtnTimeQuick.TabIndex = 4;
            this.BtnTimeQuick.TabStop = false;
            this.BtnTimeQuick.Text = "Quick";
            this.BtnTimeQuick.UseVisualStyleBackColor = true;
            this.BtnTimeQuick.Visible = false;
            this.BtnTimeQuick.Click += new System.EventHandler(this.BtnTimeQuick_Click);
            // 
            // BtnDiffHard
            // 
            this.BtnDiffHard.Location = new System.Drawing.Point(30, 343);
            this.BtnDiffHard.Name = "BtnDiffHard";
            this.BtnDiffHard.Size = new System.Drawing.Size(145, 34);
            this.BtnDiffHard.TabIndex = 3;
            this.BtnDiffHard.TabStop = false;
            this.BtnDiffHard.Text = "Hard";
            this.BtnDiffHard.UseVisualStyleBackColor = true;
            this.BtnDiffHard.Visible = false;
            this.BtnDiffHard.Click += new System.EventHandler(this.BtnDiffHard_Click);
            // 
            // BtnDiffMed
            // 
            this.BtnDiffMed.Location = new System.Drawing.Point(30, 303);
            this.BtnDiffMed.Name = "BtnDiffMed";
            this.BtnDiffMed.Size = new System.Drawing.Size(145, 34);
            this.BtnDiffMed.TabIndex = 1;
            this.BtnDiffMed.TabStop = false;
            this.BtnDiffMed.Text = "Medium";
            this.BtnDiffMed.UseVisualStyleBackColor = true;
            this.BtnDiffMed.Visible = false;
            this.BtnDiffMed.Click += new System.EventHandler(this.BtnDiffMed_Click);
            // 
            // BtnDiffEasy
            // 
            this.BtnDiffEasy.Location = new System.Drawing.Point(29, 263);
            this.BtnDiffEasy.Name = "BtnDiffEasy";
            this.BtnDiffEasy.Size = new System.Drawing.Size(145, 34);
            this.BtnDiffEasy.TabIndex = 0;
            this.BtnDiffEasy.TabStop = false;
            this.BtnDiffEasy.Text = "Easy";
            this.BtnDiffEasy.UseVisualStyleBackColor = true;
            this.BtnDiffEasy.Visible = false;
            this.BtnDiffEasy.Click += new System.EventHandler(this.BtnDiffEasy_Click);
            // 
            // LblPlayerLost
            // 
            this.LblPlayerLost.AutoSize = true;
            this.LblPlayerLost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPlayerLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerLost.ForeColor = System.Drawing.Color.Red;
            this.LblPlayerLost.Location = new System.Drawing.Point(153, 150);
            this.LblPlayerLost.Name = "LblPlayerLost";
            this.LblPlayerLost.Size = new System.Drawing.Size(451, 110);
            this.LblPlayerLost.TabIndex = 2;
            this.LblPlayerLost.Text = "You Lost!";
            this.LblPlayerLost.Visible = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Rockwell", 50F);
            this.LblTitle.Location = new System.Drawing.Point(133, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(531, 75);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "SettlersOfChaos";
            // 
            // BtnTutorial
            // 
            this.BtnTutorial.BackColor = System.Drawing.Color.White;
            this.BtnTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTutorial.ForeColor = System.Drawing.Color.Black;
            this.BtnTutorial.Location = new System.Drawing.Point(206, 217);
            this.BtnTutorial.Name = "BtnTutorial";
            this.BtnTutorial.Size = new System.Drawing.Size(384, 90);
            this.BtnTutorial.TabIndex = 1;
            this.BtnTutorial.Text = "Tutorial";
            this.BtnTutorial.UseVisualStyleBackColor = false;
            this.BtnTutorial.Click += new System.EventHandler(this.BtnTutorial_Click);
            // 
            // LblPlayerDetails
            // 
            this.LblPlayerDetails.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerDetails.Location = new System.Drawing.Point(600, 307);
            this.LblPlayerDetails.Name = "LblPlayerDetails";
            this.LblPlayerDetails.Size = new System.Drawing.Size(175, 91);
            this.LblPlayerDetails.TabIndex = 12;
            this.LblPlayerDetails.Text = "label1";
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerName.Location = new System.Drawing.Point(600, 216);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(175, 91);
            this.LblPlayerName.TabIndex = 11;
            this.LblPlayerName.Text = "label1";
            // 
            // LblPlayerIntro
            // 
            this.LblPlayerIntro.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayerIntro.Location = new System.Drawing.Point(600, 125);
            this.LblPlayerIntro.Name = "LblPlayerIntro";
            this.LblPlayerIntro.Size = new System.Drawing.Size(175, 91);
            this.LblPlayerIntro.TabIndex = 10;
            this.LblPlayerIntro.Text = "label1";
            // 
            // LblGameTheme
            // 
            this.LblGameTheme.BackColor = System.Drawing.Color.Transparent;
            this.LblGameTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblGameTheme.Location = new System.Drawing.Point(20, 307);
            this.LblGameTheme.Name = "LblGameTheme";
            this.LblGameTheme.Size = new System.Drawing.Size(175, 91);
            this.LblGameTheme.TabIndex = 7;
            this.LblGameTheme.Text = "label1";
            // 
            // LblGameLength
            // 
            this.LblGameLength.BackColor = System.Drawing.Color.Transparent;
            this.LblGameLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblGameLength.Location = new System.Drawing.Point(20, 216);
            this.LblGameLength.Name = "LblGameLength";
            this.LblGameLength.Size = new System.Drawing.Size(175, 91);
            this.LblGameLength.TabIndex = 6;
            this.LblGameLength.Text = "label1";
            // 
            // LblGameDifficulty
            // 
            this.LblGameDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.LblGameDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameDifficulty.Location = new System.Drawing.Point(20, 125);
            this.LblGameDifficulty.Name = "LblGameDifficulty";
            this.LblGameDifficulty.Size = new System.Drawing.Size(175, 91);
            this.LblGameDifficulty.TabIndex = 5;
            this.LblGameDifficulty.Text = "Your game difficulty is";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.White;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.Location = new System.Drawing.Point(206, 121);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(384, 90);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // TmrArtilleryTicks
            // 
            this.TmrArtilleryTicks.Interval = 33;
            this.TmrArtilleryTicks.Tick += new System.EventHandler(this.ArtilleryTicks_Tick);
            // 
            // TmrShellMove
            // 
            this.TmrShellMove.Interval = 25;
            this.TmrShellMove.Tick += new System.EventHandler(this.TmrShellMove_Tick);
            // 
            // TmrShoot
            // 
            this.TmrShoot.Interval = 33;
            this.TmrShoot.Tick += new System.EventHandler(this.TmrShoot_Tick);
            // 
            // TmrDelay
            // 
            this.TmrDelay.Interval = 2000;
            this.TmrDelay.Tick += new System.EventHandler(this.TmrDelay_Tick);
            // 
            // TmrGame
            // 
            this.TmrGame.Tick += new System.EventHandler(this.TmrGame_Tick);
            // 
            // TmrGameEnd
            // 
            this.TmrGameEnd.Interval = 3000;
            this.TmrGameEnd.Tick += new System.EventHandler(this.TmrGameEnd_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PnlBackSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.Text = "SettlersOfChaos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            this.PnlBackSplash.ResumeLayout(false);
            this.PnlBackSplash.PerformLayout();
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.PnlHome.ResumeLayout(false);
            this.PnlHome.PerformLayout();
            this.PnlHelp.ResumeLayout(false);
            this.PnlShoot.ResumeLayout(false);
            this.PnlShoot.PerformLayout();
            this.PnlFight.ResumeLayout(false);
            this.PnlSettings.ResumeLayout(false);
            this.PnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBackSplash;
        private System.Windows.Forms.Panel PnlFight;
        private System.Windows.Forms.Timer TmrArtilleryTicks;
        private System.Windows.Forms.Timer TmrShellMove;
        private System.Windows.Forms.Label YouMissedLBL;
        private System.Windows.Forms.Label LblTargetHit;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnTutorial;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Panel PnlHome;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnFortify;
        private System.Windows.Forms.Button BtnShoot;
        private System.Windows.Forms.Button BtnArtillery;
        private System.Windows.Forms.Label LblPlayerTwo;
        private System.Windows.Forms.Label LblPlayerOne;
        private System.Windows.Forms.Panel PnlShoot;
        private System.Windows.Forms.Timer TmrShoot;
        private System.Windows.Forms.Label LblShootTargetHit;
        private System.Windows.Forms.Label LblShootTargetMissed;
        private System.Windows.Forms.Timer TmrDelay;
        private System.Windows.Forms.Label LblAIAction;
        private System.Windows.Forms.Label LblTurn;
        private System.Windows.Forms.Label LblTurnName;
        private System.Windows.Forms.Label LblPlayerLost;
        private System.Windows.Forms.Timer TmrGame;
        private System.Windows.Forms.Timer TmrGameEnd;
        private System.Windows.Forms.Label LblYouWon;
        private System.Windows.Forms.Panel PnlSettings;
        private System.Windows.Forms.Button BtnTimeLong;
        private System.Windows.Forms.Button BtnTimeStandard;
        private System.Windows.Forms.Button BtnTimeQuick;
        private System.Windows.Forms.Button BtnDiffHard;
        private System.Windows.Forms.Button BtnDiffMed;
        private System.Windows.Forms.Button BtnDiffEasy;
        private System.Windows.Forms.Button BtnThemeDark;
        private System.Windows.Forms.Button BtnThemePink;
        private System.Windows.Forms.Button BtnThemeBlue;
        private System.Windows.Forms.Button BtnReturnMenu;
        private System.Windows.Forms.Panel PnlTutorial;
        private System.Windows.Forms.Label LblSettings;
        private System.Windows.Forms.Panel PnlHelp;
        private System.Windows.Forms.Label LblHelp;
        private System.Windows.Forms.Button BtnHowtoplay;
        private System.Windows.Forms.Button BtnDefense;
        private System.Windows.Forms.Button BtnAttacking;
        private System.Windows.Forms.Button BtnRTG;
        private System.Windows.Forms.Label LblGameDifficulty;
        private System.Windows.Forms.Label LblPlayerIntro;
        private System.Windows.Forms.Label LblGameTheme;
        private System.Windows.Forms.Label LblGameLength;
        private System.Windows.Forms.Label LblPlayerDetails;
        private System.Windows.Forms.Label LblPlayerName;
    }
}

