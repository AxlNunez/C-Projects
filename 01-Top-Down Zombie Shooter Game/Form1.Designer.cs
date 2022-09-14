namespace Shooter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ammoCount = new System.Windows.Forms.Label();
            this.killCount = new System.Windows.Forms.Label();
            this.healthCount = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoCount
            // 
            this.ammoCount.AutoSize = true;
            this.ammoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ammoCount.ForeColor = System.Drawing.Color.White;
            this.ammoCount.Location = new System.Drawing.Point(24, 12);
            this.ammoCount.Name = "ammoCount";
            this.ammoCount.Size = new System.Drawing.Size(93, 24);
            this.ammoCount.TabIndex = 0;
            this.ammoCount.Text = "Ammo: 0";
            this.ammoCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // killCount
            // 
            this.killCount.AutoSize = true;
            this.killCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.killCount.ForeColor = System.Drawing.Color.White;
            this.killCount.Location = new System.Drawing.Point(433, 12);
            this.killCount.Name = "killCount";
            this.killCount.Size = new System.Drawing.Size(71, 24);
            this.killCount.TabIndex = 1;
            this.killCount.Text = "Kills: 0";
            // 
            // healthCount
            // 
            this.healthCount.AutoSize = true;
            this.healthCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healthCount.ForeColor = System.Drawing.Color.White;
            this.healthCount.Location = new System.Drawing.Point(678, 12);
            this.healthCount.Name = "healthCount";
            this.healthCount.Size = new System.Drawing.Size(76, 24);
            this.healthCount.TabIndex = 2;
            this.healthCount.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(760, 12);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(152, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // player
            // 
            this.player.Image = global::Shooter.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(433, 39);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.healthCount);
            this.Controls.Add(this.killCount);
            this.Controls.Add(this.ammoCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zombie Shooter Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ammoCount;
        private Label killCount;
        private Label healthCount;
        private ProgressBar healthBar;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}