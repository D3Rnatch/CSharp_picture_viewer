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
    public partial class MyPictures : Form
    {
        private int move;
        private int maxValX;
        private int maxValY;

        public MyPictures()
        {
            InitializeComponent();
            move = 0;
            maxValX = 0;
            maxValY = 0;
        }

        private void barTitle_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            maxValX = e.X;
            maxValY = e.Y;

        }

        private void barTitle_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void barTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - maxValX, MousePosition.Y - maxValY);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous sur de vouloir partir?\nLes traitements non sauvegardés seront perdus", "Warning",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void slideshow_Click(object sender, EventArgs e)
        {
            Slideshow slideshowForm = new Slideshow();
            slideshowForm.Show();

        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            AddFolder newFolder = new AddFolder();
            newFolder.Show();
        }

      


    }
}
