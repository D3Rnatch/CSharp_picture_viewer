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
    public partial class ImageViewDisplay : Form
    {
        public Picture pic;
        public TextBox editPlace;
        public TextBox editComments;
        public TextBox editName;
        public Button buttonSave;
        public PictureBox pb;
        
        public ImageViewDisplay(Picture pict)
        {
            InitializeComponent();
            editPlace = edit_place;
            editComments = edit_comments;
            editName = edit_title;
            pb = picture;
            buttonSave = button_saveInfo;
            this.pic = pict;
            resizeForm();
            fillInformation();
            this.FormClosing += new FormClosingEventHandler(ImageViewDisplay_FormClosing);
            this.Show();
        }

        private void ImageViewDisplay_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void fillInformation()
        {
            edit_comments.Lines = pic.comments.ToArray();
            edit_place.Text = pic.place;
            edit_title.Text = pic.name;
        }

        public void resizeForm()
        {
            float coeffproportion = (float)Image.FromFile(pic.fname).Size.Width / (float)Image.FromFile(pic.fname).Size.Height;
            float newH = Screen.PrimaryScreen.Bounds.Height - 100;
            float newW =newH*coeffproportion;
            
            picture.Size = new Size((int)newW, (int)newH);
            this.Size = new Size(picture.Size.Width + panelInfo.Size.Width, picture.Size.Height+40);
            Bitmap img = new Bitmap(Image.FromFile(pic.fname),picture.Size);
            picture.Image = img;
        }

        private void button_saveInfo_Click(object sender, EventArgs e)
        {
           
        }


        



    }
}
