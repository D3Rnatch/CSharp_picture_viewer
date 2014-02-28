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
        private int timerInit;

        public Slideshow()
        {
            this.WindowState = FormWindowState.Maximized;
            changePicture = 0;
            timerInit = 0;
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

        private void button_play_Click(object sender, EventArgs e)
        {

            if (timer.Enabled == true)
                timer.Enabled = false;
            else
            {
                timer.Enabled = true;
                //on donne un pas
                timerInit =100;
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (changePicture < listTextSlideshow.Images.Count)
            {
                slideshow_picture.Image = listTextSlideshow.Images[changePicture];
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
            if (timer.Enabled==true&&timer.Interval > timerInit)
            {
                this.SuspendLayout();
                timer.Interval= timer.Interval-timerInit;
                updateSpeedText(false);
                this.ResumeLayout();
            }
          
        }

        private void button_quickprevious_Click(object sender, EventArgs e)
        {
            if (timer.Enabled ==true && timer.Interval < timerInit * 10)
            {
                this.SuspendLayout();
                timer.Interval += timerInit;
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
                slideshow_picture.Image = listTextSlideshow.Images[changePicture];
                this.ResumeLayout();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false&&changePicture<listTextSlideshow.Images.Count-1)
            {
                this.SuspendLayout();
                changePicture++;
                slideshow_picture.Image = listTextSlideshow.Images[changePicture];
                this.ResumeLayout();
            }
        }
   
      
    }
}
