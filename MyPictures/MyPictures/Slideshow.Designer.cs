namespace MyPictures
{
    partial class Slideshow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slideshow));
            this.container_slideshow = new System.Windows.Forms.FlowLayoutPanel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_quickprevious = new System.Windows.Forms.Button();
            this.slideshow_picture = new System.Windows.Forms.PictureBox();
            this.button_play = new System.Windows.Forms.Button();
            this.speedText = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_quicknext = new System.Windows.Forms.Button();
            this.listTextSlideshow = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.container_slideshow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // container_slideshow
            // 
            this.container_slideshow.Controls.Add(this.button_previous);
            this.container_slideshow.Controls.Add(this.button_quickprevious);
            this.container_slideshow.Controls.Add(this.slideshow_picture);
            this.container_slideshow.Controls.Add(this.button_play);
            this.container_slideshow.Controls.Add(this.speedText);
            this.container_slideshow.Controls.Add(this.button_next);
            this.container_slideshow.Controls.Add(this.button_quicknext);
            this.container_slideshow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.container_slideshow.Location = new System.Drawing.Point(36, 22);
            this.container_slideshow.Name = "container_slideshow";
            this.container_slideshow.Size = new System.Drawing.Size(876, 599);
            this.container_slideshow.TabIndex = 6;
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.FlatAppearance.BorderSize = 0;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Image = global::MyPictures.Properties.Resources.flecheb;
            this.button_previous.Location = new System.Drawing.Point(3, 3);
            this.button_previous.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(114, 516);
            this.button_previous.TabIndex = 0;
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_quickprevious
            // 
            this.button_quickprevious.BackColor = System.Drawing.Color.Black;
            this.button_quickprevious.FlatAppearance.BorderSize = 0;
            this.button_quickprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quickprevious.Image = global::MyPictures.Properties.Resources.previous;
            this.button_quickprevious.Location = new System.Drawing.Point(20, 525);
            this.button_quickprevious.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button_quickprevious.Name = "button_quickprevious";
            this.button_quickprevious.Size = new System.Drawing.Size(75, 42);
            this.button_quickprevious.TabIndex = 1;
            this.button_quickprevious.UseVisualStyleBackColor = false;
            this.button_quickprevious.Click += new System.EventHandler(this.button_quickprevious_Click);
            // 
            // slideshow_picture
            // 
            this.slideshow_picture.Location = new System.Drawing.Point(117, 3);
            this.slideshow_picture.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.slideshow_picture.Name = "slideshow_picture";
            this.slideshow_picture.Size = new System.Drawing.Size(627, 516);
            this.slideshow_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.slideshow_picture.TabIndex = 2;
            this.slideshow_picture.TabStop = false;
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Black;
            this.button_play.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_play.FlatAppearance.BorderSize = 0;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Image = global::MyPictures.Properties.Resources.PlayPlay;
            this.button_play.Location = new System.Drawing.Point(397, 525);
            this.button_play.Margin = new System.Windows.Forms.Padding(280, 3, 3, 3);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 42);
            this.button_play.TabIndex = 5;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedText.ForeColor = System.Drawing.Color.White;
            this.speedText.Location = new System.Drawing.Point(419, 570);
            this.speedText.Margin = new System.Windows.Forms.Padding(302, 0, 3, 0);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(29, 17);
            this.speedText.TabIndex = 7;
            this.speedText.Text = " 0x";
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Black;
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_next.FlatAppearance.BorderSize = 0;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Image = global::MyPictures.Properties.Resources.flechew1;
            this.button_next.Location = new System.Drawing.Point(744, 3);
            this.button_next.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(114, 516);
            this.button_next.TabIndex = 4;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_quicknext
            // 
            this.button_quicknext.BackColor = System.Drawing.Color.Black;
            this.button_quicknext.FlatAppearance.BorderSize = 0;
            this.button_quicknext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quicknext.Image = global::MyPictures.Properties.Resources.next;
            this.button_quicknext.Location = new System.Drawing.Point(764, 525);
            this.button_quicknext.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.button_quicknext.Name = "button_quicknext";
            this.button_quicknext.Size = new System.Drawing.Size(75, 42);
            this.button_quicknext.TabIndex = 6;
            this.button_quicknext.UseVisualStyleBackColor = false;
            this.button_quicknext.Click += new System.EventHandler(this.button_quicknext_Click);
            // 
            // listTextSlideshow
            // 
            this.listTextSlideshow.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listTextSlideshow.ImageStream")));
            this.listTextSlideshow.TransparentColor = System.Drawing.Color.Transparent;
            this.listTextSlideshow.Images.SetKeyName(0, "Chrysanthemum.jpg");
            this.listTextSlideshow.Images.SetKeyName(1, "Desert.jpg");
            this.listTextSlideshow.Images.SetKeyName(2, "Hydrangeas.jpg");
            this.listTextSlideshow.Images.SetKeyName(3, "Jellyfish.jpg");
            this.listTextSlideshow.Images.SetKeyName(4, "Koala.jpg");
            this.listTextSlideshow.Images.SetKeyName(5, "Lighthouse.jpg");
            this.listTextSlideshow.Images.SetKeyName(6, "Tulips.jpg");
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(977, 633);
            this.Controls.Add(this.container_slideshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Slideshow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slideshow";
            this.container_slideshow.ResumeLayout(false);
            this.container_slideshow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container_slideshow;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_quickprevious;
        private System.Windows.Forms.PictureBox slideshow_picture;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_quicknext;
        private System.Windows.Forms.ImageList listTextSlideshow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label speedText;
    }
}