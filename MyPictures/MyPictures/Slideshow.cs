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
            this.TopLevel = true;
            this.Show();
            InitializeComponent();
            putImageOnPictureBox();
            autoCenterFlowPanel();
            slideshow_picture.BackColor = Color.FromArgb(70,10,10,10);
            button_previous.BackColor = Color.FromArgb(70, 20, 20, 20);
            button_next.BackColor = Color.FromArgb(70, 20, 20, 20);
           
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                    button_next.PerformClick();
                    return true; 
                case Keys.Left:
                    button_previous.PerformClick();
                    return true;
                case Keys.Escape :
                    this.Close();
                    return true;
                case Keys.Oemplus :
                    button_quicknext.PerformClick();
                    return true;
                case Keys.OemMinus :
                    button_quickprevious.PerformClick();
                    return true;
                default:
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void autoCenterFlowPanel()
        {
            container_slideshow.Location = new Point((this.Width - container_slideshow.Width )/ 2,60);
            control_slideshow.Location = new Point((this.Width - control_slideshow.Width) / 2, control_slideshow.Location.Y+60);
        }

        private void putImageOnPictureBox()
        {
            resizeControls();
            img = new Bitmap(Image.FromFile(contents[changePicture].fname), slideshow_picture.Size);
            slideshow_picture.Image = img;
        }

        private void resizeControls()
        {
            float coeffproportion = (float)Image.FromFile(contents[changePicture].fname).Size.Width / (float)Image.FromFile(contents[changePicture].fname).Size.Height;
            float newH = Screen.PrimaryScreen.Bounds.Height - 200;
            float newW = newH * coeffproportion;

            slideshow_picture.Size = new Size((int)newW, (int)newH);
            button_previous.Size = new Size(button_previous.Width, slideshow_picture.Height);
            button_next.Size = new Size(button_previous.Width, slideshow_picture.Height);

            container_slideshow.Size = new Size(2 * button_previous.Width + slideshow_picture.Width, slideshow_picture.Height);

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
            
            if (changePicture < contents.Count-1)
            {
                changePicture++;
                putImageOnPictureBox();
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
