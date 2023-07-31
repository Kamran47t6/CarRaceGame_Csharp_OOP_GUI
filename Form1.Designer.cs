namespace ZoneOfCarRace
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoCar2 = new System.Windows.Forms.PictureBox();
            this.autoCar1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadPath2 = new System.Windows.Forms.PictureBox();
            this.roadPath1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPath2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPath1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.autoCar2);
            this.panel1.Controls.Add(this.autoCar1);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadPath2);
            this.panel1.Controls.Add(this.roadPath1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 798);
            this.panel1.TabIndex = 0;
            // 
            // autoCar2
            // 
            this.autoCar2.Image = ((System.Drawing.Image)(resources.GetObject("autoCar2.Image")));
            this.autoCar2.Location = new System.Drawing.Point(633, 95);
            this.autoCar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoCar2.Name = "autoCar2";
            this.autoCar2.Size = new System.Drawing.Size(50, 100);
            this.autoCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.autoCar2.TabIndex = 5;
            this.autoCar2.TabStop = false;
            this.autoCar2.Tag = "carRight";
            // 
            // autoCar1
            // 
            this.autoCar1.Image = ((System.Drawing.Image)(resources.GetObject("autoCar1.Image")));
            this.autoCar1.Location = new System.Drawing.Point(114, 95);
            this.autoCar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoCar1.Name = "autoCar1";
            this.autoCar1.Size = new System.Drawing.Size(50, 100);
            this.autoCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.autoCar1.TabIndex = 5;
            this.autoCar1.TabStop = false;
            this.autoCar1.Tag = "carLeft";
            // 
            // award
            // 
            this.award.Image = ((System.Drawing.Image)(resources.GetObject("award.Image")));
            this.award.Location = new System.Drawing.Point(174, 318);
            this.award.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = ((System.Drawing.Image)(resources.GetObject("explosion.Image")));
            this.explosion.Location = new System.Drawing.Point(114, 577);
            this.explosion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(322, 618);
            this.player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // roadPath2
            // 
            this.roadPath2.Location = new System.Drawing.Point(0, 0);
            this.roadPath2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roadPath2.Name = "roadPath2";
            this.roadPath2.Size = new System.Drawing.Size(712, 798);
            this.roadPath2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadPath2.TabIndex = 4;
            this.roadPath2.TabStop = false;
            this.roadPath2.Click += new System.EventHandler(this.roadPath2_Click);
            // 
            // roadPath1
            // 
            this.roadPath1.Location = new System.Drawing.Point(0, -798);
            this.roadPath1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roadPath1.Name = "roadPath1";
            this.roadPath1.Size = new System.Drawing.Size(712, 798);
            this.roadPath1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadPath1.TabIndex = 0;
            this.roadPath1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(280, 908);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 63);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Restart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(18, 822);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(712, 57);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 975);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 212);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press Left and Right to move the car. \r\n\r\nDon\'t hit any other cars in the game an" +
    "d survive as long as you can";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ZoneOfCarRace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPath2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPath1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadPath2;
        private System.Windows.Forms.PictureBox roadPath1;
        private System.Windows.Forms.PictureBox autoCar2;
        private System.Windows.Forms.PictureBox autoCar1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}

