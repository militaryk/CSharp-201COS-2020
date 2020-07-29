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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.PnlFight = new System.Windows.Forms.Panel();
            this.LblTargetHit = new System.Windows.Forms.Label();
            this.YouMissedLBL = new System.Windows.Forms.Label();
            this.TmrArtilleryTicks = new System.Windows.Forms.Timer(this.components);
            this.TmrShellMove = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            this.PnlFight.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.Controls.Add(this.PnlFight);
            this.PnlGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGame.Location = new System.Drawing.Point(0, 0);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(800, 450);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
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
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.Name = "FormGame";
            this.Text = "SettlersOfChaos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlFight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Panel PnlFight;
        private System.Windows.Forms.Timer TmrArtilleryTicks;
        private System.Windows.Forms.Timer TmrShellMove;
        private System.Windows.Forms.Label YouMissedLBL;
        private System.Windows.Forms.Label LblTargetHit;
    }
}

