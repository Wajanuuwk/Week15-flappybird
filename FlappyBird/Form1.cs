using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


        }

        private void timer1_tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            PipeTop.Left -= pipeSpeed;
            PipeBottom.Left -= pipeSpeed;
            scoreLabel.Text = $"score: {score}";

            if (PipeTop.Left < -100)
            {
                PipeTop.Left = 500;
                
            }

            if(PipeBottom.Left < -100)
            {
                PipeBottom.Left = 600;
                
            }
            if (bird.Top < -25)
            {
                gameOver();
            }

            if (bird.Bounds.IntersectsWith(PipeTop.Bounds) || bird.Bounds.IntersectsWith(PipeBottom.Bounds) || bird.Bounds.IntersectsWith(grounds.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = $"Game Over!";
            button1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
