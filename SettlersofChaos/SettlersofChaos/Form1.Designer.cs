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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFight = new System.Windows.Forms.Panel();
            this.LblTargetHit = new System.Windows.Forms.Label();
            this.YouMissedLBL = new System.Windows.Forms.Label();
            this.TmrArtilleryTicks = new System.Windows.Forms.Timer(this.components);
            this.TmrShellMove = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnTutorial = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlBackSplash.SuspendLayout();
            this.PnlFight.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBackSplash
            // 
            this.PnlBackSplash.Controls.Add(this.PnlMenu);
            this.PnlBackSplash.Controls.Add(this.label2);
            this.PnlBackSplash.Controls.Add(this.label1);
            this.PnlBackSplash.Controls.Add(this.PnlFight);
            this.PnlBackSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBackSplash.Location = new System.Drawing.Point(0, 0);
            this.PnlBackSplash.Name = "PnlBackSplash";
            this.PnlBackSplash.Size = new System.Drawing.Size(800, 450);
            this.PnlBackSplash.TabIndex = 0;
            this.PnlBackSplash.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlBackSplash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // PnlFight
            // 
            this.PnlFight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PnlFight.Controls.Add(this.LblTargetHit);
            this.PnlFight.Controls.Add(this.YouMissedLBL);
            this.PnlFight.Location = new System.Drawing.Point(0, 70);
            this.PnlFight.Name = "PnlFight";
            this.PnlFight.Size = new System.Drawing.Size(800, 300);
            this.PnlFight.TabIndex = 0;
            this.PnlFight.Visible = false;
            this.PnlFight.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFight_Paint);
            // 
            // LblTargetHit
            // 
            this.LblTargetHit.BackColor = System.Drawing.Color.Transparent;
            this.LblTargetHit.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTargetHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.LblTargetHit.ForeColor = System.Drawing.Color.Aqua;
            this.LblTargetHit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblTargetHit.Location = new System.Drawing.Point(0, 0);
            this.LblTargetHit.Name = "LblTargetHit";
            this.LblTargetHit.Size = new System.Drawing.Size(800, 300);
            this.LblTargetHit.TabIndex = 1;
            this.LblTargetHit.Text = "Target Hit";
            this.LblTargetHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTargetHit.Visible = false;
            // 
            // YouMissedLBL
            // 
            this.YouMissedLBL.BackColor = System.Drawing.Color.Transparent;
            this.YouMissedLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.YouMissedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.YouMissedLBL.ForeColor = System.Drawing.Color.Red;
            this.YouMissedLBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YouMissedLBL.Location = new System.Drawing.Point(0, 0);
            this.YouMissedLBL.Name = "YouMissedLBL";
            this.YouMissedLBL.Size = new System.Drawing.Size(800, 300);
            this.YouMissedLBL.TabIndex = 0;
            this.YouMissedLBL.Text = "You Missed";
            this.YouMissedLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YouMissedLBL.Visible = false;
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
            // PnlMenu
            // 
            this.PnlMenu.AutoSize = true;
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PnlMenu.Controls.Add(this.LblTitle);
            this.PnlMenu.Controls.Add(this.BtnSettings);
            this.PnlMenu.Controls.Add(this.BtnTutorial);
            this.PnlMenu.Controls.Add(this.BtnStart);
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(800, 450);
            this.PnlMenu.TabIndex = 3;
            this.PnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PnlBackSplash);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.Text = "SettlersOfChaos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            this.PnlBackSplash.ResumeLayout(false);
            this.PnlBackSplash.PerformLayout();
            this.PnlFight.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBackSplash;
        private System.Windows.Forms.Panel PnlFight;
        private System.Windows.Forms.Timer TmrArtilleryTicks;
        private System.Windows.Forms.Timer TmrShellMove;
        private System.Windows.Forms.Label YouMissedLBL;
        private System.Windows.Forms.Label LblTargetHit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnTutorial;
        private System.Windows.Forms.Button BtnStart;
    }
}

