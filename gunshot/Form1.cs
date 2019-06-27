using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunshot
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;
        int h = 0;

        GenreateFire obj = new GenreateFire();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            x = 1;
        }

        private void btnreplay_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnfire.Enabled = true;
            pictureBox1.ImageLocation = @"C:\Users\brarj\OneDrive\Desktop\gunshot\gunnn.png";
            pictureBox2.ImageLocation = @"C:\Users\brarj\OneDrive\Desktop\gunshot\reload.jpg";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnfire_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                {
                    SoundPlayer splayer = new SoundPlayer(@"C:\Users\brarj\OneDrive\Desktop\gunshot\gunn.wav");
                    splayer.Play();
                }
                y++;
                pictureBox1.ImageLocation = @"C:\Users\brarj\OneDrive\Desktop\gunshot\gunnshot.png";
                z = obj.fire();
                if (y == z && cunt < 2)
                

                {
                    cunt++;
                    
                    
                    MessageBox.Show("you win");

                }
               if (h == 1)
                {
                    
                    MessageBox.Show("you loose");
                }
                else
                {
                    h = 1;
                    MessageBox.Show("you win");
                }
            }
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\brarj\OneDrive\Desktop\gunshot\reload gun.wav");
                splayer.Play();
            }

            if (x > 0)
            {

                pictureBox2.ImageLocation = @"C:\Users\brarj\OneDrive\Desktop\gunshot\reload.jpg";
            }
            else
            {
                MessageBox.Show("Please Click on Load Bullet First");
            }

        }
    }
}