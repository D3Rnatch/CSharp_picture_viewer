using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPictures
{
    public partial class Slideshow : Form
    {
        private int changePicture;
        private int timerStep;
        private List<Picture> contents;
        Bitmap img; //nouvelle image cree pr adapter les dimensions

        public Slideshow(List<Picture> content)
        {
            this.WindowState = FormWindowState.Maximized;
            this.contents = content;
            changePicture = 0;
            timerStep = 100;
            this.Show();
            InitializeComponent();
            autoCenterFlowPanel();
            slideshow_picture.BackColor = Color.FromArgb(70,10,10,10);
            button_previous.BackColor = Color.FromArgb(70, 20, 20, 20);
            button_next.BackColor = Color.FromArgb(70, 20, 20, 20);
        }

        private void autoCenterFlowPanel()
        {
            container_slideshow.Location = new Point((this.Width - container_slideshow.Width )/ 2, (this.Height - container_slideshow.Height )/ 2);
        }

        private void putImageOnPictureBox()
        {
            img = new Bitmap(Image.FromFile(contents[changePicture].fname), slideshow_picture.Size);
            slideshow_picture.Image = img;
        }

        private void button_play_Click(object sender, EventArgs e)
        {

            if (timer.Enabled == true)
            { 
                timer.Enabled = false;
                button_play.Image = Properties.Resources.PlayPlay;
            }
            else
            {
                timer.Enabled = true;
                //on donne un pas
                button_play.Image = Properties.Resources.pause;
               
                
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (changePicture < contents.Count)
            {
                putImageOnPictureBox();
                changePicture++;
            }
            else
                changePicture = 0;
        }

        //rajoute un signe moins quand on depasse la valeur du timer initial
        private void updateSpeedText(Boolean previous)
        {
            int number = 0;

            number= int.Parse(speedText.Text.Replace('x',' '));

            if(previous)
                speedText.Text = (number-1)+ "x";
            else
                speedText.Text =(number+1) + "x";
        }

        private void button_quicknext_Click(object sender, EventArgs e)
        {
            if (timer.Enabled==true&&timer.Interval > timerStep)
            {
                this.SuspendLayout();
                timer.Interval= timer.Interval-timerStep;
                updateSpeedText(false);
                this.ResumeLayout();
            }
          
        }

        private void button_quickprevious_Click(object sender, EventArgs e)
        {
            if (timer.Enabled ==true && timer.Interval < timerStep * 10)
            {
                this.SuspendLayout();
                timer.Interval += timerStep;
                updateSpeedText(true);
                this.ResumeLayout();
            }

        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false&&changePicture>0)
            {
                this.SuspendLayout();
                changePicture--;
                putImageOnPictureBox();
                this.ResumeLayout();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false&&changePicture<contents.Count-1)
            {
                this.SuspendLayout();
                changePicture++;
                putImageOnPictureBox();
                this.ResumeLayout();
            }
        }
     
    }
}
