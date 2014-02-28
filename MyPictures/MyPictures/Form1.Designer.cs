namespace MyPictures
{
    partial class MyPictures
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("default");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPictures));
            this.barTitle = new System.Windows.Forms.PictureBox();
            this.button_addFolder = new System.Windows.Forms.Button();
            this.button_deleteFolder = new System.Windows.Forms.Button();
            this.list_folders = new System.Windows.Forms.TreeView();
            this.image_folders = new System.Windows.Forms.ImageList(this.components);
            this.button_albums = new System.Windows.Forms.Button();
            this.image_View = new System.Windows.Forms.ImageList(this.components);
            this.miniatureView = new System.Windows.Forms.ListView();
            this.searchPictures = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_web = new System.Windows.Forms.Button();
            this.button_slideshow = new System.Windows.Forms.Button();
            this.label_tags = new System.Windows.Forms.Label();
            this.write_tags = new System.Windows.Forms.TextBox();
            this.button_addTag = new System.Windows.Forms.Button();
            this.button_deleteTag = new System.Windows.Forms.Button();
            this.button_saveAll = new System.Windows.Forms.Button();
            this.button_removePicture = new System.Windows.Forms.Button();
            this.button_addPicture = new System.Windows.Forms.Button();
            this.button_deletePicture = new System.Windows.Forms.Button();
            this.directorySearcher = new System.DirectoryServices.DirectorySearcher();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.minimize = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.list_tags = new System.Windows.Forms.ListBox();
            this.detailsPicture = new System.Windows.Forms.ListView();
            this.Details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.containerPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.logo_barTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.containerPictures.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_barTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // barTitle
            // 
            this.barTitle.BackColor = System.Drawing.Color.DimGray;
            this.barTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.barTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.barTitle.Location = new System.Drawing.Point(0, 0);
            this.barTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.barTitle.Name = "barTitle";
            this.barTitle.Size = new System.Drawing.Size(1050, 30);
            this.barTitle.TabIndex = 0;
            this.barTitle.TabStop = false;
            this.barTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barTitle_MouseDown);
            this.barTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barTitle_MouseMove);
            this.barTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barTitle_MouseUp);
            // 
            // button_addFolder
            // 
            this.button_addFolder.BackColor = System.Drawing.Color.White;
            this.button_addFolder.Image = global::MyPictures.Properties.Resources.Folder_Add_icon2;
            this.button_addFolder.Location = new System.Drawing.Point(0, 0);
            this.button_addFolder.Margin = new System.Windows.Forms.Padding(0);
            this.button_addFolder.Name = "button_addFolder";
            this.button_addFolder.Size = new System.Drawing.Size(90, 33);
            this.button_addFolder.TabIndex = 1;
            this.button_addFolder.UseVisualStyleBackColor = false;
            this.button_addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // button_deleteFolder
            // 
            this.button_deleteFolder.BackColor = System.Drawing.Color.White;
            this.button_deleteFolder.Image = global::MyPictures.Properties.Resources.Folder_Delete_icon3;
            this.button_deleteFolder.Location = new System.Drawing.Point(90, 0);
            this.button_deleteFolder.Margin = new System.Windows.Forms.Padding(0);
            this.button_deleteFolder.Name = "button_deleteFolder";
            this.button_deleteFolder.Size = new System.Drawing.Size(90, 33);
            this.button_deleteFolder.TabIndex = 2;
            this.button_deleteFolder.UseVisualStyleBackColor = false;
            // 
            // list_folders
            // 
            this.list_folders.ImageIndex = 0;
            this.list_folders.ImageList = this.image_folders;
            this.list_folders.Location = new System.Drawing.Point(2, 56);
            this.list_folders.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.list_folders.Name = "list_folders";
            treeNode2.Name = "default";
            treeNode2.Text = "default";
            this.list_folders.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.list_folders.SelectedImageIndex = 0;
            this.list_folders.Size = new System.Drawing.Size(181, 301);
            this.list_folders.TabIndex = 3;
            // 
            // image_folders
            // 
            this.image_folders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_folders.ImageStream")));
            this.image_folders.TransparentColor = System.Drawing.Color.Transparent;
            this.image_folders.Images.SetKeyName(0, "pictureTreeIcon.png");
            this.image_folders.Images.SetKeyName(1, "folderPictureTreeIcon.png");
            // 
            // button_albums
            // 
            this.button_albums.Location = new System.Drawing.Point(0, 33);
            this.button_albums.Margin = new System.Windows.Forms.Padding(0);
            this.button_albums.Name = "button_albums";
            this.button_albums.Size = new System.Drawing.Size(184, 23);
            this.button_albums.TabIndex = 6;
            this.button_albums.Text = "Albums";
            this.button_albums.UseVisualStyleBackColor = true;
            // 
            // image_View
            // 
            this.image_View.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_View.ImageSize = new System.Drawing.Size(40, 40);
            this.image_View.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // miniatureView
            // 
            this.miniatureView.AllowDrop = true;
            this.miniatureView.LargeImageList = this.image_View;
            this.miniatureView.Location = new System.Drawing.Point(187, 36);
            this.miniatureView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.miniatureView.Name = "miniatureView";
            this.miniatureView.Size = new System.Drawing.Size(685, 401);
            this.miniatureView.SmallImageList = this.image_View;
            this.miniatureView.TabIndex = 7;
            this.miniatureView.UseCompatibleStateImageBehavior = false;
            this.miniatureView.DragDrop += new System.Windows.Forms.DragEventHandler(this.miniatureView_DragDrop);
            this.miniatureView.DragEnter += new System.Windows.Forms.DragEventHandler(this.miniatureView_DragEnter);
            // 
            // searchPictures
            // 
            this.searchPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPictures.Location = new System.Drawing.Point(3, 3);
            this.searchPictures.Name = "searchPictures";
            this.searchPictures.Size = new System.Drawing.Size(450, 26);
            this.searchPictures.TabIndex = 8;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.White;
            this.button_search.Image = global::MyPictures.Properties.Resources.magnifying_glass2;
            this.button_search.Location = new System.Drawing.Point(456, 0);
            this.button_search.Margin = new System.Windows.Forms.Padding(0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(77, 33);
            this.button_search.TabIndex = 9;
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // button_web
            // 
            this.button_web.BackColor = System.Drawing.Color.White;
            this.button_web.Image = global::MyPictures.Properties.Resources.Web_icon1;
            this.button_web.Location = new System.Drawing.Point(533, 0);
            this.button_web.Margin = new System.Windows.Forms.Padding(0);
            this.button_web.Name = "button_web";
            this.button_web.Size = new System.Drawing.Size(77, 33);
            this.button_web.TabIndex = 10;
            this.button_web.UseVisualStyleBackColor = false;
            // 
            // button_slideshow
            // 
            this.button_slideshow.BackColor = System.Drawing.Color.White;
            this.button_slideshow.Image = global::MyPictures.Properties.Resources.slideshow_icon1;
            this.button_slideshow.Location = new System.Drawing.Point(610, 0);
            this.button_slideshow.Margin = new System.Windows.Forms.Padding(0);
            this.button_slideshow.Name = "button_slideshow";
            this.button_slideshow.Size = new System.Drawing.Size(77, 33);
            this.button_slideshow.TabIndex = 11;
            this.button_slideshow.UseVisualStyleBackColor = false;
            this.button_slideshow.Click += new System.EventHandler(this.slideshow_Click);
            // 
            // label_tags
            // 
            this.label_tags.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tags.Location = new System.Drawing.Point(878, 3);
            this.label_tags.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_tags.Name = "label_tags";
            this.label_tags.Size = new System.Drawing.Size(159, 20);
            this.label_tags.TabIndex = 13;
            this.label_tags.Text = "Tags";
            this.label_tags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // write_tags
            // 
            this.write_tags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.write_tags.Location = new System.Drawing.Point(878, 335);
            this.write_tags.Name = "write_tags";
            this.write_tags.Size = new System.Drawing.Size(159, 20);
            this.write_tags.TabIndex = 14;
            this.write_tags.MouseClick += new System.Windows.Forms.MouseEventHandler(this.write_tags_MouseClick);
            // 
            // button_addTag
            // 
            this.button_addTag.BackColor = System.Drawing.Color.White;
            this.button_addTag.Image = global::MyPictures.Properties.Resources.add;
            this.button_addTag.Location = new System.Drawing.Point(0, 0);
            this.button_addTag.Margin = new System.Windows.Forms.Padding(0);
            this.button_addTag.Name = "button_addTag";
            this.button_addTag.Size = new System.Drawing.Size(78, 33);
            this.button_addTag.TabIndex = 15;
            this.button_addTag.UseVisualStyleBackColor = false;
            this.button_addTag.Click += new System.EventHandler(this.button_addTag_Click);
            // 
            // button_deleteTag
            // 
            this.button_deleteTag.BackColor = System.Drawing.Color.White;
            this.button_deleteTag.Image = global::MyPictures.Properties.Resources.edit_remove1;
            this.button_deleteTag.Location = new System.Drawing.Point(78, 0);
            this.button_deleteTag.Margin = new System.Windows.Forms.Padding(0);
            this.button_deleteTag.Name = "button_deleteTag";
            this.button_deleteTag.Size = new System.Drawing.Size(81, 33);
            this.button_deleteTag.TabIndex = 16;
            this.button_deleteTag.UseVisualStyleBackColor = false;
            this.button_deleteTag.Click += new System.EventHandler(this.button_deleteTag_Click);
            // 
            // button_saveAll
            // 
            this.button_saveAll.BackColor = System.Drawing.Color.White;
            this.button_saveAll.Image = global::MyPictures.Properties.Resources.save_icon;
            this.button_saveAll.Location = new System.Drawing.Point(3, 3);
            this.button_saveAll.Name = "button_saveAll";
            this.button_saveAll.Size = new System.Drawing.Size(50, 57);
            this.button_saveAll.TabIndex = 17;
            this.button_saveAll.UseVisualStyleBackColor = false;
            // 
            // button_removePicture
            // 
            this.button_removePicture.BackColor = System.Drawing.Color.White;
            this.button_removePicture.Image = global::MyPictures.Properties.Resources.picture_delete_icon1;
            this.button_removePicture.Location = new System.Drawing.Point(633, 3);
            this.button_removePicture.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.button_removePicture.Name = "button_removePicture";
            this.button_removePicture.Size = new System.Drawing.Size(50, 57);
            this.button_removePicture.TabIndex = 18;
            this.button_removePicture.UseVisualStyleBackColor = false;
            // 
            // button_addPicture
            // 
            this.button_addPicture.BackColor = System.Drawing.Color.White;
            this.button_addPicture.Image = global::MyPictures.Properties.Resources.picture_add_icon_png;
            this.button_addPicture.Location = new System.Drawing.Point(533, 3);
            this.button_addPicture.Margin = new System.Windows.Forms.Padding(477, 3, 0, 0);
            this.button_addPicture.Name = "button_addPicture";
            this.button_addPicture.Size = new System.Drawing.Size(50, 57);
            this.button_addPicture.TabIndex = 19;
            this.button_addPicture.UseVisualStyleBackColor = false;
            // 
            // button_deletePicture
            // 
            this.button_deletePicture.BackColor = System.Drawing.Color.White;
            this.button_deletePicture.Image = global::MyPictures.Properties.Resources.picture_remove_icon_png;
            this.button_deletePicture.Location = new System.Drawing.Point(583, 3);
            this.button_deletePicture.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.button_deletePicture.Name = "button_deletePicture";
            this.button_deletePicture.Size = new System.Drawing.Size(50, 57);
            this.button_deletePicture.TabIndex = 20;
            this.button_deletePicture.UseVisualStyleBackColor = false;
            // 
            // directorySearcher
            // 
            this.directorySearcher.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.DarkBlue;
            this.trackBar.Location = new System.Drawing.Point(184, 437);
            this.trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(688, 45);
            this.trackBar.TabIndex = 21;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.DimGray;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = global::MyPictures.Properties.Resources.minise7;
            this.minimize.Location = new System.Drawing.Point(955, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(41, 23);
            this.minimize.TabIndex = 22;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.DimGray;
            this.closeForm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeForm.Image = global::MyPictures.Properties.Resources.closeB2;
            this.closeForm.Location = new System.Drawing.Point(996, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(42, 23);
            this.closeForm.TabIndex = 23;
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // list_tags
            // 
            this.list_tags.BackColor = System.Drawing.SystemColors.InfoText;
            this.list_tags.ForeColor = System.Drawing.Color.White;
            this.list_tags.FormattingEnabled = true;
            this.list_tags.Location = new System.Drawing.Point(878, 26);
            this.list_tags.Name = "list_tags";
            this.list_tags.Size = new System.Drawing.Size(159, 303);
            this.list_tags.TabIndex = 25;
            // 
            // detailsPicture
            // 
            this.detailsPicture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Details,
            this.Value});
            this.detailsPicture.Location = new System.Drawing.Point(2, 360);
            this.detailsPicture.Margin = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.detailsPicture.Name = "detailsPicture";
            this.detailsPicture.Size = new System.Drawing.Size(182, 186);
            this.detailsPicture.TabIndex = 26;
            this.detailsPicture.UseCompatibleStateImageBehavior = false;
            this.detailsPicture.View = System.Windows.Forms.View.Details;
            // 
            // Details
            // 
            this.Details.Text = "Name";
            this.Details.Width = 83;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 94;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.searchPictures);
            this.flowLayoutPanel1.Controls.Add(this.button_search);
            this.flowLayoutPanel1.Controls.Add(this.button_web);
            this.flowLayoutPanel1.Controls.Add(this.button_slideshow);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(184, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(688, 33);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.button_addFolder);
            this.flowLayoutPanel2.Controls.Add(this.button_deleteFolder);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(183, 33);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.button_addTag);
            this.flowLayoutPanel3.Controls.Add(this.button_deleteTag);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(878, 361);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(159, 33);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // containerPictures
            // 
            this.containerPictures.BackColor = System.Drawing.Color.SlateBlue;
            this.containerPictures.BackgroundImage = global::MyPictures.Properties.Resources.plage1;
            this.containerPictures.Controls.Add(this.flowLayoutPanel2);
            this.containerPictures.Controls.Add(this.button_albums);
            this.containerPictures.Controls.Add(this.list_folders);
            this.containerPictures.Controls.Add(this.detailsPicture);
            this.containerPictures.Controls.Add(this.flowLayoutPanel1);
            this.containerPictures.Controls.Add(this.miniatureView);
            this.containerPictures.Controls.Add(this.trackBar);
            this.containerPictures.Controls.Add(this.flowLayoutPanel5);
            this.containerPictures.Controls.Add(this.label_tags);
            this.containerPictures.Controls.Add(this.list_tags);
            this.containerPictures.Controls.Add(this.write_tags);
            this.containerPictures.Controls.Add(this.flowLayoutPanel3);
            this.containerPictures.Controls.Add(this.logo_picture);
            this.containerPictures.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.containerPictures.Location = new System.Drawing.Point(0, 33);
            this.containerPictures.Margin = new System.Windows.Forms.Padding(0);
            this.containerPictures.Name = "containerPictures";
            this.containerPictures.Size = new System.Drawing.Size(1048, 563);
            this.containerPictures.TabIndex = 30;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.flowLayoutPanel5.Controls.Add(this.button_saveAll);
            this.flowLayoutPanel5.Controls.Add(this.button_addPicture);
            this.flowLayoutPanel5.Controls.Add(this.button_deletePicture);
            this.flowLayoutPanel5.Controls.Add(this.button_removePicture);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(184, 482);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(688, 60);
            this.flowLayoutPanel5.TabIndex = 31;
            // 
            // logo_picture
            // 
            this.logo_picture.BackColor = System.Drawing.Color.Transparent;
            this.logo_picture.Image = global::MyPictures.Properties.Resources.logo_mp3;
            this.logo_picture.Location = new System.Drawing.Point(878, 400);
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.Size = new System.Drawing.Size(159, 141);
            this.logo_picture.TabIndex = 32;
            this.logo_picture.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.DimGray;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(35, 4);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(87, 19);
            this.title.TabIndex = 31;
            this.title.Text = "MyPictures";
            // 
            // logo_barTitle
            // 
            this.logo_barTitle.BackColor = System.Drawing.Color.DimGray;
            this.logo_barTitle.Image = global::MyPictures.Properties.Resources.logo_icon2;
            this.logo_barTitle.Location = new System.Drawing.Point(0, 0);
            this.logo_barTitle.Name = "logo_barTitle";
            this.logo_barTitle.Size = new System.Drawing.Size(32, 30);
            this.logo_barTitle.TabIndex = 32;
            this.logo_barTitle.TabStop = false;
            // 
            // MyPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 589);
            this.ControlBox = false;
            this.Controls.Add(this.logo_barTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.containerPictures);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.barTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyPictures";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPictures";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.barTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.containerPictures.ResumeLayout(false);
            this.containerPictures.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_barTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox barTitle;
        private System.Windows.Forms.Button button_addFolder;
        private System.Windows.Forms.Button button_deleteFolder;
        private System.Windows.Forms.TreeView list_folders;
        private System.Windows.Forms.Button button_albums;
        private System.Windows.Forms.ImageList image_View;
        private System.Windows.Forms.ListView miniatureView;
        private System.Windows.Forms.TextBox searchPictures;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_web;
        private System.Windows.Forms.Button button_slideshow;
        private System.Windows.Forms.Label label_tags;
        private System.Windows.Forms.TextBox write_tags;
        private System.Windows.Forms.Button button_addTag;
        private System.Windows.Forms.Button button_deleteTag;
        private System.Windows.Forms.Button button_saveAll;
        private System.Windows.Forms.Button button_removePicture;
        private System.Windows.Forms.Button button_addPicture;
        private System.Windows.Forms.Button button_deletePicture;
        private System.DirectoryServices.DirectorySearcher directorySearcher;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.ListBox list_tags;
        private System.Windows.Forms.ListView detailsPicture;
        private System.Windows.Forms.ColumnHeader Details;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ImageList image_folders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel containerPictures;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo_barTitle;
    }
}

