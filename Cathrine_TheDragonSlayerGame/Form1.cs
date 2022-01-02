using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Cathrine_TheDragonSlayerGame
{
    public partial class Form1 : Form
    {
        const int MAX_USER_LIVES = 5;
       
        int userScore = 0;
        int userLives = MAX_USER_LIVES;
        Random generator = new Random();

        List<PictureBox> listOfBird = new List<PictureBox>();
        List<PictureBox> listOfDragon = new List<PictureBox>();

        string resourcesPath = Application.StartupPath + "//Resources//";
        WindowsMediaPlayer loopSound = new WindowsMediaPlayer();
        WindowsMediaPlayer normalSound = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loopSound.URL = resourcesPath + "\\Music.mp3";
            loopSound.settings.setMode("loop", true);

            labelLives.Text = userLives.ToString();
            labelScore.Text = userScore.ToString();
        }

        private void timerBirdGenerator_Tick(object sender, EventArgs e)
        {
            /*Spesifikasi:
             * X -> Left = 70
             * Y -> Top = random (0, 120, 240, 360)
             * Speed -> Tag = random (5, -10)
             * image
             * backcolor = transparent
             * width = 70
             * height = 100
             */ 

            if (listOfBird.Count < 5)
            {
                //create picturebox bird
                PictureBox pictureBoxBird = new PictureBox();

                //width & height
                pictureBoxBird.Width = 70;
                pictureBoxBird.Height = 100;

                //image & backcolor
                pictureBoxBird.Image = Properties.Resources.BirdFlyingRight;
                pictureBoxBird.BackColor = Color.Transparent;

                //x & y
                pictureBoxBird.Left = -70;

                int positionY = generator.Next(0, 4) * 120;
                pictureBoxBird.Top = positionY;

                //speed -> tag
                int speed = generator.Next(5, 11);
                pictureBoxBird.Tag = speed;

                //Add to List
                listOfBird.Add(pictureBoxBird);

                //Add to Form
                this.Controls.Add(pictureBoxBird);
            }
            else
            {
                timerBirdGenerator.Enabled = false;
            }
        }

        private void timerDragonGenerator_Tick(object sender, EventArgs e)
        {
            /* Spesifikasi
             * width = 160
             * height = 120
             * speed -> Tag = random (10-15)
             * x -> Left = -160
             * y -> Top = random(0, 120, 240, 360)
             */

            if (listOfDragon.Count < 5)
            {
                //create picturebox dragon
                PictureBox pictureBoxDragon = new PictureBox();

                //set width & height
                pictureBoxDragon.Width = 160;
                pictureBoxDragon.Height = 120;

                //set image & backcolor
                pictureBoxDragon.Image = Properties.Resources.DragonFlyingRight;
                pictureBoxDragon.BackColor = Color.Transparent;

                //set left & top
                pictureBoxDragon.Left = -160;

                int positionY = generator.Next(0, 4) * 120;
                pictureBoxDragon.Top = positionY;

                //set speed -> tag
                int speed = generator.Next(10, 16);
                pictureBoxDragon.Tag = speed;

                //Add to list
                listOfDragon.Add(pictureBoxDragon);

                //Add to Form
                this.Controls.Add(pictureBoxDragon);

                pictureBoxDragon.Click += new System.EventHandler(pictureBoxDragon_Click);
            }
            else
            {
                timerDragonGenerator.Enabled = false;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listOfDragon.Count; i++)
            {
                listOfDragon[i].Left += (int)listOfDragon[i].Tag;

                if (listOfDragon[i].Left > this.ClientSize.Width)
                {
                    listOfDragon[i].Dispose();
                    listOfDragon.RemoveAt(i);

                    timerDragonGenerator.Enabled = true;
                }
                else
                {
                    listOfDragon[i].Refresh();
                }
            }

            for (int i = 0; i < listOfBird.Count; i++)
            {
                listOfBird[i].Left += (int)listOfBird[i].Tag;

                if (listOfBird[i].Left > this.ClientSize.Width)
                {
                    listOfBird[i].Dispose();
                    listOfBird.RemoveAt(i);

                    timerBirdGenerator.Enabled = true;
                }
                else
                {
                    listOfBird[i].Refresh();
                }
            }

            bool collision = false;
            bool onTheScreen = true;

            for (int i = 0; i < listOfDragon.Count; i++)
            {
                for (int j = 0; j < listOfBird.Count; j++)
                {
                    if (listOfDragon[i].Bounds.IntersectsWith(listOfBird[j].Bounds))
                    {
                        if (listOfBird[j].Left < 0)
                        {
                            onTheScreen = false;
                        }

                        listOfBird[j].Dispose();
                        listOfBird.RemoveAt(j);
                        collision = true;

                        break;
                    }
                }
                if (collision)
                {
                    break;
                }
            }

            if (collision && onTheScreen)
            {
                normalSound.URL = resourcesPath + "BirdDie.wav";

                userLives--;
                labelLives.Text = userLives.ToString();

                if (userLives <= 0)
                {
                    timerBirdGenerator.Enabled = false;
                    timerDragonGenerator.Enabled = false;
                    timerGame.Enabled = false;

                    DialogResult userAnswer = MessageBox.Show("You lose, Do you want to play again?", "End Game", MessageBoxButtons.YesNo);

                    if (userAnswer == DialogResult.Yes)
                    {
                        for (int i = 0; i < listOfBird.Count; i++)
                        {
                            listOfBird[i].Dispose();
                        }
                        listOfBird.Clear();

                        for (int i = 0; i < listOfDragon.Count; i++)
                        {
                            listOfDragon[i].Dispose();
                        }
                        listOfDragon.Clear();

                        userScore = 0;
                        userLives = MAX_USER_LIVES;
                        labelScore.Text = userScore.ToString();
                        labelLives.Text = userLives.ToString();

                        timerBirdGenerator.Enabled = true;
                        timerDragonGenerator.Enabled = true;
                        timerGame.Enabled = true;
                    }

                    else
                    {
                        Close();
                    }
                }
            }
        }

        private void pictureBoxDragon_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcesPath + "DragonGotHit.wav";

            for (int i = 0; i < listOfDragon.Count; i++)
            {

                if (listOfDragon[i] == (PictureBox)sender)
                {
                    int dragonSpeed = (int)listOfDragon[i].Tag;
                    dragonSpeed -= 4;

                    if (dragonSpeed > 0)
                    {
                        listOfDragon[i].Tag = dragonSpeed;
                    }
                    else
                    {
                        //We can find the picturebox
                        //delete the picturebox and remove it from the list
                        listOfDragon[i].Dispose();
                        listOfDragon.RemoveAt(i);

                        //Increase the user score
                        userScore += 10;
                        labelScore.Text = userScore.ToString();

                        timerDragonGenerator.Enabled = true;
                    }

                    //Exit the loop (no need to continue because we already found the picturebox)
                    break;
                }

            }
        }
        private void FormDS_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcesPath + "Shoot.wav";
        }
    }
}
