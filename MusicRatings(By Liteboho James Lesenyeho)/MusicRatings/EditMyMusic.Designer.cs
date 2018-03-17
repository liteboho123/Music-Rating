namespace MusicRatings
{
    partial class EditMyMusic
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
            this.DGV_MusicView = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SearchArt = new System.Windows.Forms.Button();
            this.txt_SearchArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SearchRate = new System.Windows.Forms.Button();
            this.txt_SearchRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SearchSong = new System.Windows.Forms.Button();
            this.txt_SearchSong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_SearchYear = new System.Windows.Forms.Button();
            this.txt_SearchYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLink_Genre = new System.Windows.Forms.LinkLabel();
            this.lblLink_Artist = new System.Windows.Forms.LinkLabel();
            this.lblLink_Track = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MusicView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_MusicView
            // 
            this.DGV_MusicView.BackgroundColor = System.Drawing.Color.Cyan;
            this.DGV_MusicView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MusicView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_MusicView.Location = new System.Drawing.Point(12, 78);
            this.DGV_MusicView.Name = "DGV_MusicView";
            this.DGV_MusicView.Size = new System.Drawing.Size(451, 348);
            this.DGV_MusicView.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(481, 503);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(562, 503);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.btn_SearchArt);
            this.groupBox1.Controls.Add(this.txt_SearchArt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(466, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search artist";
            // 
            // btn_SearchArt
            // 
            this.btn_SearchArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchArt.Location = new System.Drawing.Point(126, 37);
            this.btn_SearchArt.Name = "btn_SearchArt";
            this.btn_SearchArt.Size = new System.Drawing.Size(75, 19);
            this.btn_SearchArt.TabIndex = 2;
            this.btn_SearchArt.Text = "Search";
            this.btn_SearchArt.UseVisualStyleBackColor = true;
            this.btn_SearchArt.Click += new System.EventHandler(this.btn_SearchArt_Click);
            // 
            // txt_SearchArt
            // 
            this.txt_SearchArt.Location = new System.Drawing.Point(3, 37);
            this.txt_SearchArt.Name = "txt_SearchArt";
            this.txt_SearchArt.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchArt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the name of the artist";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btn_SearchRate);
            this.groupBox2.Controls.Add(this.txt_SearchRate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(466, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search rating";
            // 
            // btn_SearchRate
            // 
            this.btn_SearchRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchRate.Location = new System.Drawing.Point(126, 49);
            this.btn_SearchRate.Name = "btn_SearchRate";
            this.btn_SearchRate.Size = new System.Drawing.Size(75, 19);
            this.btn_SearchRate.TabIndex = 3;
            this.btn_SearchRate.Text = "Search";
            this.btn_SearchRate.UseVisualStyleBackColor = true;
            this.btn_SearchRate.Click += new System.EventHandler(this.btn_SearchRate_Click);
            // 
            // txt_SearchRate
            // 
            this.txt_SearchRate.Location = new System.Drawing.Point(3, 49);
            this.txt_SearchRate.Name = "txt_SearchRate";
            this.txt_SearchRate.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchRate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please state the rating of your music";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btn_SearchSong);
            this.groupBox3.Controls.Add(this.txt_SearchSong);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(466, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search song";
            // 
            // btn_SearchSong
            // 
            this.btn_SearchSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchSong.Location = new System.Drawing.Point(126, 55);
            this.btn_SearchSong.Name = "btn_SearchSong";
            this.btn_SearchSong.Size = new System.Drawing.Size(75, 19);
            this.btn_SearchSong.TabIndex = 4;
            this.btn_SearchSong.Text = "Search";
            this.btn_SearchSong.UseVisualStyleBackColor = true;
            this.btn_SearchSong.Click += new System.EventHandler(this.btn_SearchSong_Click);
            // 
            // txt_SearchSong
            // 
            this.txt_SearchSong.Location = new System.Drawing.Point(6, 54);
            this.txt_SearchSong.Name = "txt_SearchSong";
            this.txt_SearchSong.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchSong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please enter the name of the song";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.btn_SearchYear);
            this.groupBox4.Controls.Add(this.txt_SearchYear);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(466, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 119);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search year";
            // 
            // btn_SearchYear
            // 
            this.btn_SearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchYear.Location = new System.Drawing.Point(126, 47);
            this.btn_SearchYear.Name = "btn_SearchYear";
            this.btn_SearchYear.Size = new System.Drawing.Size(75, 19);
            this.btn_SearchYear.TabIndex = 5;
            this.btn_SearchYear.Text = "Search";
            this.btn_SearchYear.UseVisualStyleBackColor = true;
            this.btn_SearchYear.Click += new System.EventHandler(this.btn_SearchYear_Click);
            // 
            // txt_SearchYear
            // 
            this.txt_SearchYear.Location = new System.Drawing.Point(6, 46);
            this.txt_SearchYear.Name = "txt_SearchYear";
            this.txt_SearchYear.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchYear.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Please state the year the song was realeased";
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(401, 503);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 6;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "My Music Profile";
            // 
            // lblLink_Genre
            // 
            this.lblLink_Genre.AutoSize = true;
            this.lblLink_Genre.Location = new System.Drawing.Point(9, 453);
            this.lblLink_Genre.Name = "lblLink_Genre";
            this.lblLink_Genre.Size = new System.Drawing.Size(78, 13);
            this.lblLink_Genre.TabIndex = 9;
            this.lblLink_Genre.TabStop = true;
            this.lblLink_Genre.Text = "Update genre?";
            this.lblLink_Genre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_Genre_LinkClicked);
            // 
            // lblLink_Artist
            // 
            this.lblLink_Artist.AutoSize = true;
            this.lblLink_Artist.Location = new System.Drawing.Point(9, 478);
            this.lblLink_Artist.Name = "lblLink_Artist";
            this.lblLink_Artist.Size = new System.Drawing.Size(73, 13);
            this.lblLink_Artist.TabIndex = 10;
            this.lblLink_Artist.TabStop = true;
            this.lblLink_Artist.Text = "Update artist?";
            this.lblLink_Artist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_Artist_LinkClicked);
            // 
            // lblLink_Track
            // 
            this.lblLink_Track.AutoSize = true;
            this.lblLink_Track.Location = new System.Drawing.Point(9, 503);
            this.lblLink_Track.Name = "lblLink_Track";
            this.lblLink_Track.Size = new System.Drawing.Size(75, 13);
            this.lblLink_Track.TabIndex = 11;
            this.lblLink_Track.TabStop = true;
            this.lblLink_Track.Text = "Update track?";
            this.lblLink_Track.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_Track_LinkClicked);
            // 
            // EditMyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(715, 538);
            this.Controls.Add(this.lblLink_Track);
            this.Controls.Add(this.lblLink_Artist);
            this.Controls.Add(this.lblLink_Genre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.DGV_MusicView);
            this.Name = "EditMyMusic";
            this.Text = "EditMyMusic";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MusicView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_MusicView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SearchArt;
        private System.Windows.Forms.TextBox txt_SearchRate;
        private System.Windows.Forms.TextBox txt_SearchSong;
        private System.Windows.Forms.TextBox txt_SearchYear;
        private System.Windows.Forms.Button btn_SearchArt;
        private System.Windows.Forms.Button btn_SearchRate;
        private System.Windows.Forms.Button btn_SearchSong;
        private System.Windows.Forms.Button btn_SearchYear;
        private System.Windows.Forms.LinkLabel lblLink_Genre;
        private System.Windows.Forms.LinkLabel lblLink_Artist;
        private System.Windows.Forms.LinkLabel lblLink_Track;
    }
}