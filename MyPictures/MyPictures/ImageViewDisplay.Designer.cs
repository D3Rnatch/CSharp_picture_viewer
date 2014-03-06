namespace MyPictures
{
    partial class ImageViewDisplay
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.button_saveInfo = new System.Windows.Forms.Button();
            this.edit_place = new System.Windows.Forms.TextBox();
            this.label_place = new System.Windows.Forms.Label();
            this.edit_comments = new System.Windows.Forms.TextBox();
            this.label_comments = new System.Windows.Forms.Label();
            this.edit_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(1, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(676, 489);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.button_saveInfo);
            this.panelInfo.Controls.Add(this.edit_place);
            this.panelInfo.Controls.Add(this.label_place);
            this.panelInfo.Controls.Add(this.edit_comments);
            this.panelInfo.Controls.Add(this.label_comments);
            this.panelInfo.Controls.Add(this.edit_title);
            this.panelInfo.Controls.Add(this.label_title);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfo.Location = new System.Drawing.Point(683, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(228, 489);
            this.panelInfo.TabIndex = 1;
            // 
            // button_saveInfo
            // 
            this.button_saveInfo.Location = new System.Drawing.Point(73, 306);
            this.button_saveInfo.Name = "button_saveInfo";
            this.button_saveInfo.Size = new System.Drawing.Size(75, 23);
            this.button_saveInfo.TabIndex = 6;
            this.button_saveInfo.Text = "save";
            this.button_saveInfo.UseVisualStyleBackColor = true;
            this.button_saveInfo.Click += new System.EventHandler(this.button_saveInfo_Click);
            // 
            // edit_place
            // 
            this.edit_place.Location = new System.Drawing.Point(17, 249);
            this.edit_place.Name = "edit_place";
            this.edit_place.Size = new System.Drawing.Size(199, 20);
            this.edit_place.TabIndex = 5;
            // 
            // label_place
            // 
            this.label_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_place.Location = new System.Drawing.Point(13, 226);
            this.label_place.Name = "label_place";
            this.label_place.Size = new System.Drawing.Size(203, 20);
            this.label_place.TabIndex = 4;
            this.label_place.Text = "Place";
            // 
            // edit_comments
            // 
            this.edit_comments.Location = new System.Drawing.Point(17, 127);
            this.edit_comments.Multiline = true;
            this.edit_comments.Name = "edit_comments";
            this.edit_comments.Size = new System.Drawing.Size(199, 74);
            this.edit_comments.TabIndex = 3;
            // 
            // label_comments
            // 
            this.label_comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comments.Location = new System.Drawing.Point(13, 104);
            this.label_comments.Name = "label_comments";
            this.label_comments.Size = new System.Drawing.Size(203, 20);
            this.label_comments.TabIndex = 2;
            this.label_comments.Text = "Comments";
            // 
            // edit_title
            // 
            this.edit_title.Location = new System.Drawing.Point(17, 64);
            this.edit_title.Name = "edit_title";
            this.edit_title.Size = new System.Drawing.Size(199, 20);
            this.edit_title.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(13, 41);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(203, 20);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Title";
            // 
            // ImageViewDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 489);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.picture);
            this.Name = "ImageViewDisplay";
            this.Text = "ImageViewDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox edit_place;
        private System.Windows.Forms.Label label_place;
        private System.Windows.Forms.TextBox edit_comments;
        private System.Windows.Forms.Label label_comments;
        private System.Windows.Forms.TextBox edit_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_saveInfo;
    }
}