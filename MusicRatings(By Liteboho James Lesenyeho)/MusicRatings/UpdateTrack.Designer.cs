namespace MusicRatings
{
    partial class UpdateTrack
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_Artist = new System.Windows.Forms.ComboBox();
            this.txt_Track = new System.Windows.Forms.TextBox();
            this.txtMask_Year = new System.Windows.Forms.MaskedTextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.picbx_CD7 = new System.Windows.Forms.PictureBox();
            this.picbx_CD6 = new System.Windows.Forms.PictureBox();
            this.picbx_CD5 = new System.Windows.Forms.PictureBox();
            this.picbx_CD4 = new System.Windows.Forms.PictureBox();
            this.picbx_CD3 = new System.Windows.Forms.PictureBox();
            this.picbx_CD2 = new System.Windows.Forms.PictureBox();
            this.picbx_CD1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Track";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name a track you would like to update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate this track";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State the year of release";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select an artist ";
            // 
            // cmbx_Artist
            // 
            this.cmbx_Artist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Artist.FormattingEnabled = true;
            this.cmbx_Artist.Location = new System.Drawing.Point(368, 289);
            this.cmbx_Artist.Name = "cmbx_Artist";
            this.cmbx_Artist.Size = new System.Drawing.Size(337, 21);
            this.cmbx_Artist.TabIndex = 5;
            // 
            // txt_Track
            // 
            this.txt_Track.Location = new System.Drawing.Point(368, 92);
            this.txt_Track.Name = "txt_Track";
            this.txt_Track.Size = new System.Drawing.Size(337, 20);
            this.txt_Track.TabIndex = 8;
            // 
            // txtMask_Year
            // 
            this.txtMask_Year.Location = new System.Drawing.Point(368, 223);
            this.txtMask_Year.Mask = "0000";
            this.txtMask_Year.Name = "txtMask_Year";
            this.txtMask_Year.Size = new System.Drawing.Size(43, 20);
            this.txtMask_Year.TabIndex = 9;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(178, 474);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(97, 474);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 23);
            this.btn_Details.TabIndex = 11;
            this.btn_Details.Text = "Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(16, 474);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(259, 474);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 20;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // picbx_CD7
            // 
            this.picbx_CD7.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD7.Location = new System.Drawing.Point(662, 161);
            this.picbx_CD7.Name = "picbx_CD7";
            this.picbx_CD7.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD7.TabIndex = 19;
            this.picbx_CD7.TabStop = false;
            this.picbx_CD7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD7_MouseClick);
            // 
            // picbx_CD6
            // 
            this.picbx_CD6.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD6.Location = new System.Drawing.Point(613, 161);
            this.picbx_CD6.Name = "picbx_CD6";
            this.picbx_CD6.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD6.TabIndex = 18;
            this.picbx_CD6.TabStop = false;
            this.picbx_CD6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD6_MouseClick);
            // 
            // picbx_CD5
            // 
            this.picbx_CD5.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD5.Location = new System.Drawing.Point(564, 161);
            this.picbx_CD5.Name = "picbx_CD5";
            this.picbx_CD5.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD5.TabIndex = 17;
            this.picbx_CD5.TabStop = false;
            this.picbx_CD5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD5_MouseClick);
            // 
            // picbx_CD4
            // 
            this.picbx_CD4.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD4.Location = new System.Drawing.Point(515, 161);
            this.picbx_CD4.Name = "picbx_CD4";
            this.picbx_CD4.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD4.TabIndex = 16;
            this.picbx_CD4.TabStop = false;
            this.picbx_CD4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD4_MouseClick);
            // 
            // picbx_CD3
            // 
            this.picbx_CD3.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD3.Location = new System.Drawing.Point(466, 161);
            this.picbx_CD3.Name = "picbx_CD3";
            this.picbx_CD3.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD3.TabIndex = 15;
            this.picbx_CD3.TabStop = false;
            this.picbx_CD3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD3_MouseClick);
            // 
            // picbx_CD2
            // 
            this.picbx_CD2.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD2.Location = new System.Drawing.Point(417, 161);
            this.picbx_CD2.Name = "picbx_CD2";
            this.picbx_CD2.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD2.TabIndex = 14;
            this.picbx_CD2.TabStop = false;
            this.picbx_CD2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD2_MouseClick);
            // 
            // picbx_CD1
            // 
            this.picbx_CD1.Image = global::MusicRatings.Properties.Resources._1CD;
            this.picbx_CD1.Location = new System.Drawing.Point(368, 161);
            this.picbx_CD1.Name = "picbx_CD1";
            this.picbx_CD1.Size = new System.Drawing.Size(43, 20);
            this.picbx_CD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_CD1.TabIndex = 13;
            this.picbx_CD1.TabStop = false;
            this.picbx_CD1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbx_CD1_MouseClick);
            // 
            // UpdateTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(743, 544);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.picbx_CD7);
            this.Controls.Add(this.picbx_CD6);
            this.Controls.Add(this.picbx_CD5);
            this.Controls.Add(this.picbx_CD4);
            this.Controls.Add(this.picbx_CD3);
            this.Controls.Add(this.picbx_CD2);
            this.Controls.Add(this.picbx_CD1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtMask_Year);
            this.Controls.Add(this.txt_Track);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbx_Artist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTrack";
            this.Text = "UpdateTrack";
            this.Load += new System.EventHandler(this.UpdateTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_CD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_Artist;
        private System.Windows.Forms.TextBox txt_Track;
        private System.Windows.Forms.MaskedTextBox txtMask_Year;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.PictureBox picbx_CD1;
        private System.Windows.Forms.PictureBox picbx_CD2;
        private System.Windows.Forms.PictureBox picbx_CD3;
        private System.Windows.Forms.PictureBox picbx_CD4;
        private System.Windows.Forms.PictureBox picbx_CD5;
        private System.Windows.Forms.PictureBox picbx_CD6;
        private System.Windows.Forms.PictureBox picbx_CD7;
        private System.Windows.Forms.Button btn_View;
    }
}