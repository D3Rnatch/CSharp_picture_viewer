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
        private ImageList original;

        public MyPictures()
        {
            InitializeComponent();
            original = image_View;
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
          // Slideshow slideshowForm = new Slideshow(ab.content);
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            AddFolder newFolder = new AddFolder();
            newFolder.Show();
        }

        private void miniatureView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void miniatureView_DragDrop(object sender, DragEventArgs e)
        {
            string[] files=(string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                miniatureView.BeginUpdate();
                image_View.Images.Add(Image.FromFile(file));
                miniatureView.Items.Add(new ListViewItem("oo", 0));
                miniatureView.EndUpdate();
            }    

        }

        private void button_addTag_Click(object sender, EventArgs e)
        {
            string chaine=write_tags.Text.Trim();
            
            if (list_tags.Items.Contains(chaine)==false&&chaine != "")
                list_tags.Items.Add(chaine);
                
        }

        private void button_deleteTag_Click(object sender, EventArgs e)
        {
            string chaine=write_tags.Text.Trim();

            if (list_tags.SelectedItems.Count==0&&chaine != "")
                list_tags.Items.Remove(chaine);

            while(list_tags.SelectedItems.Count>0)
            list_tags.Items.Remove(list_tags.SelectedItems[0]);
  

        }

        private void write_tags_MouseClick(object sender, MouseEventArgs e)
        {
            list_tags.ClearSelected();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {

            switch (trackBar.Value)
            {
                case 0 :
                    image_View.ImageSize = new Size(40, 40);
                    image_View.Images.Add(original.Images[0]);
                    break;
                case 1 :
                    image_View.ImageSize = new Size(50, 50);
                    image_View.Images.Add(original.Images[1]);
                    break;
            }
        }

    }
}
