using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Exam
{

    public partial class Form1 : Form
    {
      

        bool isgameover = false;
        int score;
        int gravity = 5;
        int birdspeed = 20;
        int pipespeed = 5;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            gametimer.Start();
        }

        private void gametimeevent(object sender, EventArgs e)
        {
            Birdy.Top += gravity;

            pipebot.Left -= pipespeed;
            pipeup.Left -= pipespeed;

            txtbox.Text = score.ToString();

            if(pipebot.Left < -150)
            {
                pipebot.Left = this.ClientSize.Width + random.Next(0,950); //for now
                score++;
            }
            if(pipeup.Left < -180)
            {
                pipeup.Left = this.ClientSize.Width + random.Next(0, 950); ; // for now
                score++;
            }

            if (Birdy.Bounds.IntersectsWith(pipeup.Bounds) || Birdy.Bounds.IntersectsWith(pipebot.Bounds) || Birdy.Bounds.IntersectsWith(ground.Bounds))
            {
               if(score > 0)
                {
                    score--;
                }
                else
                {
                    gameover();
                }

                if(score > 10)
                {
                    pipespeed += 10;
                }

            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {

                gravity = -8;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 8;
            }

            if(e.KeyCode == Keys.Enter && isgameover == true)
            {
                resetgame();
                isgameover = false;
            }

        }

        private void resetgame()
        {
            gametimer.Start();
            pipespeed = 5;
            int formWidth = this.ClientSize.Width; 
            pipeup.Left = formWidth + random.Next(0, 950); 
            pipebot.Left = formWidth + random.Next(0, 950);
            score = 0;
         }

        private void gameover()
        {
           isgameover = true;
            gametimer.Stop();
            txtbox.Text = "Game Over!" + Environment.NewLine +
                            "Your score: " + score.ToString() + Environment.NewLine +
                            "Press Enter to try again";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
