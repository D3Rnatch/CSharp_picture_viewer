using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
        private Album currentAlbum;
        private ImageViewDisplay dis;

        public MyPictures()
        {
            InitializeComponent();
            this.TopLevel = true;
            trackBar.Maximum = 255;
            trackBar.Minimum = 40;
            lp = new List<Picture>();
            currentAlbum = new Album();
            currentAlbum.content = new List<Picture>();
            listp = currentAlbum.content;
            currentAlbum = new Album();
            currentAlbum.tags.AddRange(new string[] { "ab", "top", "zop" });
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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            List<string> tags = new List<string>();
            tags.Add("chine");
            tags.Add("noir");

            miniatureView.Focus();
            if (files != null)
            {
                foreach (string file in files)
                {
                    if (checkedFile(file))
                    {
                        Picture pic = new Picture();
                        miniatureView.BeginUpdate();
                        image_View.Images.Add(Image.FromFile(file));
                        miniatureView.Items.Add(new ListViewItem(getNameOfImage(file, "\\") + getCopyNumber(getNameOfImage(file, "\\")), findLastIndexOfListView() + 1));
                        oldList.Items.Add(new ListViewItem(getNameOfImage(file, "\\") + getCopyNumber(getNameOfImage(file, "\\")), findLastIndexOfListView()));
                        pic.fname = file;
                        pic.name = getNameOfImage(file, "\\") + getCopyNumber(getNameOfImage(file, "\\"));
                        pic.tags = tags;
                        listp.Add(pic);
                        miniatureView.EndUpdate();
                    }
                    else
                        MessageBox.Show("l'application ne gère pas  l'extension " + System.IO.Path.GetExtension(file));
                }
            }
        }

        private string getCopyNumber(string name)
        {
            string copy = "";
            int count=0;
            //code a completer
            foreach(Picture pic in listp)
            {
                if (pic.name == name||pic.name == name+"("+count+")")
                {
                    count++;
                }
            }

            if (count > 0)
            {
                copy = "(" + count + ")";
            }

            return copy;
        }

        //controle si le fichier est une image
        private bool checkedFile(string file)
        {
            ImageCodecInfo[] codecInfo = ImageCodecInfo.GetImageEncoders();
            string codecObtain = "";

            foreach (ImageCodecInfo codec in codecInfo)
            {

                codecObtain = codec.CodecName.Replace("Built-in", " ");
                codecObtain = codecObtain.Replace("Codec", " ").Trim().ToLower();

                if (System.IO.Path.GetExtension(file).Contains(codecObtain) || System.IO.Path.GetExtension(file).Contains("jpg"))
                {
                    return true;
                }
            }
            return false;
        }
        //obtenir le nom de l'image deposee
        private string getNameOfImage(string file,string s)
        {
            string[] sselem;
            sselem=getsselemFile(file,s);
            sselem=sselem[sselem.GetLength(0)-1].Split(new string[]{"."},StringSplitOptions.RemoveEmptyEntries);
            return sselem[sselem.Length-2];
        }

        private string getPathOfImage(string file,string s)
        {
            string[] sselem;
            string path="";
            
            sselem =getsselemFile(file,s);

            for(int i=0;i<sselem.GetLength(0)-1;i++)
                path=path+sselem[i]+"/";

            return path;
        }

        //obtenir les sous element du chemin du fichier c-a-dire chaque dossier 
        private string[] getsselemFile(string file,string s)
        {
            string[] separator = new string[1];
            string[] sselem;
            separator[0] = s;
            
            sselem = file.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            //retourne les dossiers et le fichier
            return sselem;
        }

        //trouve le dernier index d'une listeView
        private int findLastIndexOfListView()
        {
            int index = -1;
            int length = miniatureView.Items.Count;

            if (length != 0)
                index = miniatureView.Items[length - 1].Index;

            return index;
        }

        private bool addTag(Album ab, string addtag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (ab!=null&&ab.tags.Contains(tag) == false)
                {
                    ab.tags.Add(addtag);
                    return true;
                }
            }
            return false;
        }

        private bool addTag(Picture pic, string addtag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (pic!=null&&pic.tags.Contains(tag) == false)
                {
                    pic.tags.Add(addtag);
                    return true;
                }
            }
            return false;
        }

        private bool removeTag(Album ab, string removetag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (ab!=null&&ab.tags.Contains(tag) == true)
                {
                    ab.tags.Remove(removetag);
                    return true;
                }
            }
            return false;
        }

        private bool removeTag(Picture pic, string removetag)
        {
            foreach (string tag in list_tags.Items)
            {
                if (pic!=null&&pic.tags.Contains(tag) == true)
                {
                    pic.tags.Remove(removetag);
                    return true;
                }
            }
            return false;
        }

        private void button_addTag_Click(object sender, EventArgs e)
        {
            string chaine = write_tags.Text.Trim();

            if ((currentPicture != null||currentAlbum!=null) && list_tags.Items.Contains(chaine) == false && chaine != "")
            {
                list_tags.Items.Add(chaine);
                 
                if(list_folders.SelectedNode!=null&&list_folders.SelectedNode.IsSelected==true)
                    addTag(currentAlbum, chaine);
                else
                   addTag(currentPicture, chaine);
            }

        }

        private void button_deleteTag_Click(object sender, EventArgs e)
        {
            string chaine = write_tags.Text.Trim();

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
                miniatureView.Items.Clear();

                foreach (ListViewItem item in oldList.Items)
                    miniatureView.Items.Add((ListViewItem)item.Clone());
                
                count = 0;                        //on permet a nouveau le click
                miniatureView.AllowDrop = true;   //on permet le drag&drop
            }

            else
            {
                miniatureView.Items.Clear(); //on nettoye la list
               
                foreach (Picture pic in listp)
                {
                    foreach (string tag in pic.tags)
                    {
                         if(tag.StartsWith(searchPictures.Text))
                        {
                            miniatureView.Items.Add(new ListViewItem(pic.name, findIndexPicture(listp,pic)));
                        }
                    }
                    if (pic.name.StartsWith(searchPictures.Text))
                    {
                        miniatureView.Items.Add(new ListViewItem(pic.name, findIndexPicture(listp,pic)));
                    }
                }
            }

        }

        //trouve l'index de l'image par le chemin dans une list<Picture> 
        private int findIndexPicture(List<Picture> list,Picture p)
        {
            return list.FindIndex(x => x.fname == p.fname && x.name==p.name);
        }

        private void searchPictures_Click(object sender, EventArgs e)
        {
            
            if (count == 0 && searchPictures.Text == "")
            {
                count++;
                oldList.Items.Clear();
                foreach (ListViewItem item in miniatureView.Items)
                {
                    oldList.Items.Add((ListViewItem)item.Clone());
                }
            }

        }

        private void miniatureView_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcurrentPicture();
        }

        private Object getObjectSelected()
        {
            int index = -1;
            Object pic = null;

            //on recupere l'index de l'image selectionnee
            for (int i = 0; i < miniatureView.SelectedItems.Count; i++)
                index = miniatureView.SelectedItems[i].ImageIndex;
            write_tags.Text = index + "";
            list_tags.Items.Clear(); //on nettoye la list des tags
            resetInformationAboutObject(); // on nettoye la list des properties
            //si une image a ete selectionnee
            if (index != -1)
            {
                pic = listp[index]; //on trouve l'image dans la list par rapport a l'index

                Picture p = (Picture)pic;

                foreach (string tag in p.tags)
                    list_tags.Items.Add(tag); //on reaffiche les tags correspondants a l'image
            }

            return pic;
        }

        //met a jour les informations sur la photo dans la listView Details
        private void updateInformationAboutPicture()
        {
            string[] datas = getAllDataPicture();

            for (int i = 0; i < detailsPicture.Items.Count; i++)
                detailsPicture.Items[i].SubItems[1] = new ListViewItem.ListViewSubItem(detailsPicture.Items[i], datas[i]);
        }

        //on recupere toutes les donnees servant a l'affichage des properties
        private string[] getAllDataPicture()
        {
            string[] datas = new string[detailsPicture.Items.Count];
            datas[0] = currentPicture.name;
            datas[1] = getInformationCompact(currentPicture.comments);
            datas[2] = getCreationDate(System.IO.File.GetCreationTime(currentPicture.fname));
            datas[3] = getDimensionPicture(Image.FromFile(currentPicture.fname).PhysicalDimension);
            datas[4] = Image.FromFile(currentPicture.fname).Width.ToString();
            datas[5] = Image.FromFile(currentPicture.fname).Height.ToString();
            datas[6] = Image.FromFile(currentPicture.fname).PixelFormat.ToString();
            datas[7] = System.IO.Path.GetExtension(currentPicture.fname);
            datas[8] = currentPicture.fname;
            datas[9] = (new System.IO.FileInfo(currentPicture.fname)).Length / 1024 + " kB";
            datas[10] = currentPicture.place;

            return datas;
        }

        private string[] getAllDataAlbum()
        {
            string[] datas = new string[detailsPicture.Items.Count];
            datas[0] = currentAlbum.name;
            datas[1] = currentAlbum.place;
            datas[2] = getCreationDate(System.IO.File.GetCreationTime(currentAlbum.fname));
            datas[7] = System.IO.Path.GetExtension(currentAlbum.fname);
            datas[8] = currentAlbum.fname;
            datas[9] = (new System.IO.FileInfo(currentAlbum.fname)).Length / 1024 + " kB";
            datas[10] = currentAlbum.place;
            return datas;
        }

        private void resetInformationAboutObject()
        {
            for (int i = 0; i < detailsPicture.Items.Count; i++)
            {
                detailsPicture.Items[i].SubItems[1] = new ListViewItem.ListViewSubItem(detailsPicture.Items[i], "");
            }
        }

        public string getCreationDate(DateTime fnameDate)
        {
            return fnameDate.ToShortDateString() + " " + fnameDate.ToShortTimeString();
        }

        public string getInformationCompact(List<string> infos)
        {
            string cinfo = "";
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

        private void list_folders_DragDrop(object sender, DragEventArgs e)
        {

           Bitmap files = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
           TreeNode node = getNode(e.X,e.Y);

           if(node!=null)
           {

           }
           
           //int indexFolder = list_folders.GetNodeAt(e.X, e.Y).Index;
           // write_tags.Text = indexFolder+"";
           /* Album album;

            foreach (Album ab in abList)
            {
                if (nameFolder == ab.name)
                    album = ab;
            }

            foreach (string file in files)
            {
                Picture pic = new Picture();
                pic.fname = file;
                pic.name = getNameOfImageDrop(file);
                album.content.Add(pic);
            }*/
        }

        private void updateInformationMiniatureView()
        {
            int index = findIndexPicture(listp,currentPicture);
            int indextest = miniatureView.SelectedItems[0].Index;
           
                miniatureView.Items[indextest].Text = currentPicture.name;
                oldList.Items[index].Text = currentPicture.name;
            
        }

        private void saveModif(object sender, EventArgs e)
        {
            int index=updateListPicture(dis.editName.Text,dis.editPlace.Text,dis.editComments.Lines.ToList());
            updateCurrentPicture(index);
            updateInformationAboutPicture();
            updateInformationMiniatureView();
            dis.Close();
        }

        //mettre a jour l'image courante
        private void updateCurrentPicture(int index)
        {
            currentPicture = listp[index];
        }
        //mettre a jour la list d'image
        private int updateListPicture(string name,string place,List<string> comments)
        {
            int index = findIndexPicture(listp,currentPicture);
            listp[index].name = name;
            listp[index].place = place;
            listp[index].comments = comments;
            return index;
        }
        
        private void miniatureView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewItem item = miniatureView.HitTest(e.X, e.Y).Item;
            
            if (item != null)
            {
                if (dis != null)
                {
                   //si la fenetre a dja ete ouvert on met a jour les informations
                    dis.pic = currentPicture;
                    dis.resizeForm();
                    dis.editName.Text = currentPicture.name;
                    dis.editPlace.Text = currentPicture.place;
                    dis.editComments.Lines = currentPicture.comments.ToArray();
                    dis.Show();
                }
                else
                {
                    dis = new ImageViewDisplay(currentPicture);
                    dis.Show();
                    dis.buttonSave.Click += new System.EventHandler(saveModif);
                }

            }

        }

        private void list_folders_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void list_folders_Click(object sender, EventArgs e)
        {
            MouseEventArgs even = (MouseEventArgs)e;
            list_tags.Items.Clear();
            list_folders.Focus();
            miniatureView.HideSelection = true;

            if (even!= null)
            {
                TreeNode item = list_folders.HitTest(even.X, even.Y).Node;
                int index = item.Index;
                //... a completer code pr obtenir l'album select 
               
                foreach (string tag in currentAlbum.tags)
                    list_tags.Items.Add(tag);
            }
        }


        private void miniatureView_Click(object sender, EventArgs e)
        {
            setcurrentPicture();
        }

        void setcurrentPicture()
        {
            list_folders.SelectedNode = null;
            Picture pic = (Picture)getObjectSelected();

            //on recupere l'image selectionnee
            if (pic != null)
            {
                currentPicture = pic;
                updateInformationAboutPicture();
            }
            else
                currentPicture = null;
        }

        private void list_folders_DragOver(object sender, DragEventArgs e)
        {

            TreeNode node = getNode(e.X,e.Y);

            if (node != null)
            {
               //on selectionne le noeud
               list_folders.SelectedNode = node;
               list_folders.Select();
            }
            
        }

        private TreeNode getNode(int x,int y)
        {
            Point pt = new Point(x, y);
            pt = list_folders.PointToClient(pt);
            //on recupere le node sur lequel on veut faire le deposer
            TreeNode node = list_folders.GetNodeAt(pt);

            return node;
        }

        private void miniatureView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (miniatureView.SelectedItems.Count > 0) miniatureView.DoDragDrop(image_View.Images[miniatureView.SelectedItems[0].ImageIndex], DragDropEffects.Copy);

        }

    }

}
