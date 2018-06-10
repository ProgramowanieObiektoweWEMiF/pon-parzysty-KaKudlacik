namespace GameS
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.GreenWin = new System.Windows.Forms.Label();
            this.BlueWin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Black;
            this.gameover.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameover.Location = new System.Drawing.Point(117, 198);
            this.gameover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(352, 64);
            this.gameover.TabIndex = 2;
            this.gameover.Text = "GAME OVER";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.ForeColor = System.Drawing.Color.Chartreuse;
            this.result1.Location = new System.Drawing.Point(67, 35);
            this.result1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(64, 38);
            this.result1.TabIndex = 3;
            this.result1.Text = "  u8 ";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2.ForeColor = System.Drawing.Color.Cyan;
            this.result2.Location = new System.Drawing.Point(480, 31);
            this.result2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(85, 38);
            this.result2.TabIndex = 4;
            this.result2.Text = "label1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(242, 35);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(70, 31);
            this.time.TabIndex = 5;
            this.time.Text = "label1";
            // 
            // GreenWin
            // 
            this.GreenWin.AutoSize = true;
            this.GreenWin.BackColor = System.Drawing.Color.Black;
            this.GreenWin.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GreenWin.Location = new System.Drawing.Point(207, 262);
            this.GreenWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreenWin.Name = "GreenWin";
            this.GreenWin.Size = new System.Drawing.Size(150, 38);
            this.GreenWin.TabIndex = 6;
            this.GreenWin.Text = "Green Win!";
            // 
            // BlueWin
            // 
            this.BlueWin.AutoSize = true;
            this.BlueWin.BackColor = System.Drawing.Color.Black;
            this.BlueWin.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlueWin.Location = new System.Drawing.Point(213, 300);
            this.BlueWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueWin.Name = "BlueWin";
            this.BlueWin.Size = new System.Drawing.Size(133, 38);
            this.BlueWin.TabIndex = 7;
            this.BlueWin.Text = "Blue Win!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem});
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(578, 549);
            this.Controls.Add(this.BlueWin);
            this.Controls.Add(this.GreenWin);
            this.Controls.Add(this.time);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wunsz 2.0";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gameover;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label GreenWin;
        private System.Windows.Forms.Label BlueWin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    }
}

