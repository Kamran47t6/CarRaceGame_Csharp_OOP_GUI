using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoneOfCarRace.GL;

namespace ZoneOfCarRace
{                         
    public partial class Form1 : Form
    {
 
        private System.Media.SoundPlayer BackgroundPlayer;
        int trackSpeed;                    
        int traficSpeed;         
        int myCarSpeed = 12;              
        int myscore;      
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goLeft, goRight;

        private CarDirection carDirection;
        private GameStartEnd gameStartEnd;
        private CarCollision carCollision;
        public Form1()
        {

            InitializeComponent();
            ResetGame();

            BackgroundPlayer = new System.Media.SoundPlayer(Properties.Resource1.backgroundmusic);
            carCollision = new CarCollision();
           
            carDirection =new CarDirection(player,roadPath1,roadPath2,autoCar1,autoCar2,carPosition, ModifyAutoCars,carCollision.CheckCollision);
            gameStartEnd = new GameStartEnd(BackgroundPlayer,gameTimer, explosion, award, ResetGame, player, btnStart);

            this.SizeChanged += Form1_SizeChanged;
            gameStartEnd.StartGame();
            this.KeyDown += keyisdown;
            this.KeyUp += keyisup;
            this.KeyPreview = true;
                
           
        }
        private void Form1_SizeChanged(object sender,EventArgs e)
        {
            int roadWidth = roadPath1.Width;
            carDirection.UpdateRoadWidth(roadWidth);
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            int roadWidth = roadPath1.Width;
            carDirection.KeyIsDown(e.KeyCode, myCarSpeed,roadWidth);

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            
            carDirection.KeyIsUp(e.KeyCode);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + myscore;
            myscore++;


            if (goLeft == true && player.Left > 10)
            {
                player.Left = player.Left - myCarSpeed;
            }
            if (goRight == true && player.Left < 415)
            {
                player.Left = player.Left + myCarSpeed;
            }

            roadPath1.Top += trackSpeed;
            roadPath2.Top += trackSpeed;

            if (roadPath2.Top > 519)
            {
                roadPath2.Top = -519;
            }
            if (roadPath1.Top > 519)
            {
                roadPath1.Top = -519;
            }

            autoCar1.Top += traficSpeed;
            autoCar2.Top += traficSpeed;


            if (autoCar1.Top > 530)
            {
                ModifyAutoCars(autoCar1);
            }

            if (autoCar2.Top > 530)
            {
                ModifyAutoCars(autoCar2);
            }

            if (player.Bounds.IntersectsWith(autoCar1.Bounds) || player.Bounds.IntersectsWith(autoCar2.Bounds))
            {
                gameStartEnd.GameOver();
            }

            if (myscore > 40 && myscore < 500)
            {
                award.Image = Properties.Resource1.bronze;
            }


            if (myscore > 500 && myscore < 2000)
            {
                award.Image = Properties.Resource1.silver;
                trackSpeed = 20;
                traficSpeed = 22;
            }

            if (myscore > 2000)
            {
                award.Image = Properties.Resource1.gold;
                traficSpeed = 27;
                trackSpeed = 25;
            }


        }

        private void ModifyAutoCars(PictureBox tempCar)          
        {
            carDirection.ModifyAutoCar(tempCar, rand);

           
        }
       
      

        private void ResetGame()
        {

            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            myscore = 0;
            award.Image = Properties.Resource1.bronze;
            
            trackSpeed = 12;
            traficSpeed = 15;

            autoCar1.Top = carPosition.Next(200, 500) *-1;
            autoCar1.Left = carPosition.Next(5, 200);

            autoCar2.Top = carPosition.Next(200, 500) * -1;
            autoCar2.Left = carPosition.Next(245, 422);

            gameTimer.Start();



        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

       private void GameOver()
        {
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundPlayer.PlayLooping();
            gameStartEnd.StartGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameStartEnd.StartGame();
        }

        private void roadPath2_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resource1.hit);
            playCrash.Play();
            
        }
    }
}
