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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnTutorial = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TmrArtilleryTicks = new System.Windows.Forms.Timer(this.components);
            this.TmrShellMove = new System.Windows.Forms.Timer(this.components);
            this.PnlShoot = new System.Windows.Forms.Panel();
            this.TmrShoot = new System.Windows.Forms.Timer(this.components);
            this.PnlBackSplash.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlHome.SuspendLayout();
            this.PnlFight.SuspendLayout();
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
            this.PnlMenu.Controls.Add(this.LblTitle);
            this.PnlMenu.Controls.Add(this.BtnSettings);
            this.PnlMenu.Controls.Add(this.BtnTutorial);
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
            this.PnlHome.Controls.Add(this.PnlShoot);
            this.PnlHome.Controls.Add(this.LblPlayerTwo);
            this.PnlHome.Controls.Add(this.LblPlayerOne);
            this.PnlHome.Controls.Add(this.BtnShoot);
            this.PnlHome.Controls.Add(this.BtnArtillery);
            this.PnlHome.Controls.Add(this.PnlFight);
            this.PnlHome.Controls.Add(this.BtnFortify);
            this.PnlHome.Controls.Add(this.BtnHelp);
            this.PnlHome.Controls.Add(this.BtnExit);
            this.PnlHome.Location = new System.Drawing.Point(0, 0);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(800, 500);
            this.PnlHome.TabIndex = 4;
            this.PnlHome.Visible = false;
            this.PnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHome_Paint);
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
            this.PnlFight.Location = new System.Drawing.Point(30, 457);
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
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Rockwell", 50F);
            this.LblTitle.Location = new System.Drawing.Point(133, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(531, 75);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "SettlersOfChaos";
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
            // PnlShoot
            // 
            this.PnlShoot.BackColor = System.Drawing.Color.Gray;
            this.PnlShoot.ForeColor = System.Drawing.Color.Black;
            this.PnlShoot.Location = new System.Drawing.Point(0, 0);
            this.PnlShoot.Name = "PnlShoot";
            this.PnlShoot.Size = new System.Drawing.Size(784, 400);
            this.PnlShoot.TabIndex = 7;
            this.PnlShoot.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlShoot_Paint);
            // 
            // TmrShoot
            // 
            this.TmrShoot.Enabled = true;
            this.TmrShoot.Interval = 33;
            this.TmrShoot.Tick += new System.EventHandler(this.TmrShoot_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.PnlBackSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Text = "SettlersOfChaos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            this.PnlBackSplash.ResumeLayout(false);
            this.PnlBackSplash.PerformLayout();
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.PnlHome.ResumeLayout(false);
            this.PnlFight.ResumeLayout(false);
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
    }
}

