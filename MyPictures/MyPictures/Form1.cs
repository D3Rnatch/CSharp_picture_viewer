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
        private int count = 0;
        private List<Picture> lp;
        private Picture currentPicture;
        private List<Picture> listp;
        private ListView oldList;
        private ImageList oldImages;

        public MyPictures()
        {
            InitializeComponent();
            this.TopLevel = true;
            trackBar.Maximum = 255;
            trackBar.Minimum = 40;
            lp = new List<Picture>();
            listp = new List<Picture>();
            Picture pic = new Picture();
            Picture pic2 = new Picture();
            Picture pic3 = new Picture();
            Picture pic4 = new Picture();
            oldList = new ListView();
            oldImages = new ImageList();
            pic.fname = "C:/Users/Public/Pictures/Sample Pictures/Chrysanthemum.jpg";
            pic2.fname = "C:/Users/Public/Pictures/Sample Pictures/Desert.jpg";
            pic3.fname = "C:/Users/Public/Pictures/Sample Pictures/Hydrangeas.jpg";
            pic4.fname = "C:/Users/Public/Pictures/Sample Pictures/Jellyfish.jpg";
            lp.Add(pic);
            lp.Add(pic2);
            lp.Add(pic3);
            lp.Add(pic4);
            move = 0;
            maxValX = 0;
            maxValY = 0;
        }

        //Enregistre les images du drag&drop
        private void dragdrop_saveImageInFolder(string folderFname)
        {
            foreach (Picture imageFolder in listp)
            {
                Image.FromFile(imageFolder.fname).Save(folderFname);
               
            }
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
           Slideshow slideshowForm = new Slideshow(lp);
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
            Picture pic = new Picture();
            List<string> tags = new List<string>();
            tags.Add("chine");
            tags.Add("noir");

            miniatureView.Focus();

            foreach (string file in files)
            {
                miniatureView.BeginUpdate();
                image_View.Images.Add(Image.FromFile(file));
                miniatureView.Items.Add(new ListViewItem(getNameOfImageDrop(file),findLastIndexOfListView()+1));
                pic.fname = file;
                pic.name = getNameOfImageDrop(file);
                pic.tags = tags;
                listp.Add(pic);
                miniatureView.EndUpdate();
            }
        }

        //obtenir le nom de l'image deposee
        private string getNameOfImageDrop(string file)
        {
            string[] separator = new string[1];
            string[] sselem;
            separator[0] = "\\";

            sselem=file.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            separator[0] = ".";
            sselem=sselem[sselem.GetLength(0) - 1].Split(separator,StringSplitOptions.RemoveEmptyEntries);

            return sselem[0];
        }

        //trouve le dernier index d'une liste
        private int findLastIndexOfListView()
        {
            int index= -1;
            int length = miniatureView.Items.Count;
         
               if(length!=0)
               index=miniatureView.Items[length-1].ImageIndex;
           
           return index;
        }

        private bool addTag(Album ab,string addtag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (ab.tags.Contains(tag) == false)
                {
                    ab.tags.Add(addtag);
                    return true;
                }
            }
            return false;
        }

        private bool addTag(Picture pic,string addtag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (pic.tags.Contains(tag) == false)
                {
                    pic.tags.Add(addtag);
                    return true;
                }
            }
            return false;
        }

        private bool removeTag(Album ab,string removetag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (ab.tags.Contains(tag) == true)
                {
                    ab.tags.Remove(removetag);
                    return true;
                }
            }
            return false;
        }

        private bool removeTag(Picture pic,string removetag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (pic.tags.Contains(tag) == true)
                {
                    pic.tags.Remove(removetag);
                    return true;
                }
            }
            return false;
        }

        private void button_addTag_Click(object sender, EventArgs e)
        {
            string chaine=write_tags.Text.Trim();

            if (currentPicture!=null&&list_tags.Items.Contains(chaine) == false && chaine != "")
            {
                list_tags.Items.Add(chaine);
                addTag(currentPicture, chaine);
            }
                
        }

        private void button_deleteTag_Click(object sender, EventArgs e)
        {
            string chaine=write_tags.Text.Trim();

            if (list_tags.SelectedItems.Count == 0 && chaine != "")
            {
                list_tags.Items.Remove(chaine);
                removeTag(currentPicture, chaine);
            }
            while (list_tags.SelectedItems.Count > 0)
            {
                removeTag(currentPicture, (string)list_tags.SelectedItems[0]);
                list_tags.Items.Remove(list_tags.SelectedItems[0]);
            }

        }

        //on deselectionne les items selectionnees lors de l'appuye sur la textBox
        private void write_tags_MouseClick(object sender, MouseEventArgs e)
        {
            list_tags.ClearSelected();
        }

        //on change d'image a chaque scroll de la trackbar
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            image_View.ImageSize = new Size(trackBar.Value, trackBar.Value);

            foreach (Picture currentImage in listp)
            {
                image_View.Images.Add(Image.FromFile(currentImage.fname));
            }

        }

        private void searchPictures_TextChanged(object sender, EventArgs e)
        {
            miniatureView.AllowDrop = false;
            if (searchPictures.Text == "")
            {
                foreach(ListViewItem item in oldList.Items)
                    miniatureView.Items.Add((ListViewItem)item.Clone());

                foreach (Picture pic in listp)
                {
                    image_View.Images.Add(Image.FromFile(pic.fname));
                }
                oldList.Items.Clear();
                count = 0;
                miniatureView.AllowDrop = true; ;
            }

            else
            {
                miniatureView.Items.Clear(); //on nettoye la list
                image_View.Images.Clear();
                foreach (Picture pic in listp)
                {
                    if (pic.name == searchPictures.Text)
                    {
                        image_View.Images.Add(Image.FromFile(pic.fname));
                        miniatureView.Items.Add(new ListViewItem(pic.name, findLastIndexOfListView() + 1));
                    }
                }
            }

        }

        private void searchPictures_Click(object sender, EventArgs e)
        {
            if (count==0&&searchPictures.Text == "")
            {
                count++;
                foreach (ListViewItem item in miniatureView.Items)
                {
                    oldList.Items.Add((ListViewItem)item.Clone());
                }
            }

        }

        private void miniatureView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on recupere l'image selectionnee
            currentPicture=getPictureSelected();
            if (currentPicture != null)
            {
                setInformationAboutPicture();
            }           
            
        }

        private Picture getPictureSelected()
        {
            int index = -1;
            Picture pic=null;

            //on recupere l'index de l'image selectionnee
            for (int i = 0; i < miniatureView.SelectedItems.Count; i++)
                index=miniatureView.SelectedItems[i].ImageIndex;

            list_tags.Items.Clear(); //on nettoye la list des tags
            resetInformationAboutPicture(); // on nettoye la list des properties
            //si une image a ete selectionnee
            if (index != -1)
            {
                pic = listp[index]; //on trouve l'image dans la list par rapport a l'index
                foreach (string tag in pic.tags)
                    list_tags.Items.Add(tag); //on reaffiche les tags correspondants a l'image
            }
            
            return pic;
        }

        private void setInformationAboutPicture()
        {
            string[] datas=getAllData();

            for(int i=0;i<detailsPicture.Items.Count;i++)
            detailsPicture.Items[i].SubItems[1] = new ListViewItem.ListViewSubItem(detailsPicture.Items[i],datas[i]);
        }

        //on recupere toutes les donnees servant a l'affichage des properties
        private string[] getAllData()
        {
            string[] datas = new string[detailsPicture.Items.Count];
            datas[0]=currentPicture.name;
            datas[1]=getInformationCompact(currentPicture.comments);
            datas[2]=getCreationDate(System.IO.File.GetCreationTime(currentPicture.fname));
            datas[3]=getDimensionPicture(Image.FromFile(currentPicture.fname).PhysicalDimension);
            datas[4]=Image.FromFile(currentPicture.fname).Width.ToString();
            datas[5]=Image.FromFile(currentPicture.fname).Height.ToString();
            datas[6]=Image.FromFile(currentPicture.fname).PixelFormat.ToString();
            datas[7]=System.IO.Path.GetExtension(currentPicture.fname);
            datas[8]=currentPicture.fname;
            datas[9]=(new System.IO.FileInfo(currentPicture.fname)).Length/1024+" kB";

            return datas;
        }

        private void resetInformationAboutPicture()
        {
            for (int i = 0; i < detailsPicture.Items.Count; i++)
            {
                detailsPicture.Items[i].SubItems[1] = new ListViewItem.ListViewSubItem(detailsPicture.Items[i], "");
            }
        }

        public string getCreationDate(DateTime fnameDate)
        {
            return fnameDate.ToShortDateString() +" "+ fnameDate.ToShortTimeString();
        }

        public string getInformationCompact(List<string> infos)
        {
            string cinfo="";
            if (infos != null)
            {
                foreach (string info in infos)
                {
                    if (cinfo != "")
                        cinfo = info + "," + cinfo;
                    else
                        cinfo = info;
                }
            }
            return cinfo;
        }
        public string getFormat(System.Drawing.Imaging.ImageFormat format)
        {
            return format.GetType().ToString();
        }
        public string getDimensionPicture(SizeF dim)
        {
            return dim.Width + "x" + dim.Height;
        }
        public string getSizePicture(Size size)
        {
            return size.Width * size.Height+"";
        }

       

    }

}
