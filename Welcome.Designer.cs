namespace ZoneOfCarRace
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.Welcomepicbox = new System.Windows.Forms.PictureBox();
            this.Welcometimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Welcomepicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcomepicbox
            // 
            this.Welcomepicbox.Image = ((System.Drawing.Image)(resources.GetObject("Welcomepicbox.Image")));
            this.Welcomepicbox.Location = new System.Drawing.Point(0, 0);
            this.Welcomepicbox.Name = "Welcomepicbox";
            this.Welcomepicbox.Size = new System.Drawing.Size(833, 686);
            this.Welcomepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Welcomepicbox.TabIndex = 0;
            this.Welcomepicbox.TabStop = false;
            // 
            // Welcometimer
            // 
            this.Welcometimer.Interval = 5000;
            this.Welcometimer.Tick += new System.EventHandler(this.Welcometimer_Tick);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 686);
            this.Controls.Add(this.Welcomepicbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Welcomepicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Welcomepicbox;
        private System.Windows.Forms.Timer Welcometimer;
    }
}