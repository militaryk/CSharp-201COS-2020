namespace DodgeDemo
{
    partial class FrmDodge
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
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.Label();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlGame.Location = new System.Drawing.Point(1, 33);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(503, 415);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet Dodge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.CausesValidation = false;
            this.txtName.Location = new System.Drawing.Point(509, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(510, 117);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lives";
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.Location = new System.Drawing.Point(510, 166);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(13, 13);
            this.txtLives.TabIndex = 2;
            this.txtLives.Text = "5";
            this.txtLives.UseWaitCursor = true;
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(800, 24);
            this.MnuStrip.TabIndex = 7;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(43, 20);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(43, 20);
            this.MnuStop.Text = "Stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // FrmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.MnuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmDodge";
            this.Text = "Dodge";
            this.Load += new System.EventHandler(this.FrmDodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyUp);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
    }
}

