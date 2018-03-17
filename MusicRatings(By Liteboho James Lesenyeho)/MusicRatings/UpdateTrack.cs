using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRatings
{
    public partial class UpdateTrack : Form
    {
        public UpdateTrack()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Trieve the integer 'Count' and return the result
        /// </summary>
        public int Count
        {
            get;
            set;
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            EditMyMusic edit = new EditMyMusic(); // creating a class variable for the 'EditMyMusic' class//
            this.Hide(); // temporarily suspend the current form //
            edit.Show(); // open the designated form //
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

                connection.UpdateTrack(txt_Track.Text, Count, int.Parse(txtMask_Year.Text), int.Parse(cmbx_Artist.SelectedValue.ToString()));  // Updates the name of the track, the rating of the song and the year established//
            }

            catch(FormatException)
            {
                MessageBox.Show("Check whether you've entered the correct information"); // display a message-box when the exception occurs //
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Track.Clear(); // clear text inside the 'Track' textbox //
            txtMask_Year.Clear(); // clear text inside the 'Year' textbox //
            this.Count = 0; //the integer 'Count must be set to 0 if this event occurs'//
            picbx_CD1.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
        }

        private void UpdateTrack_Load(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.SelectArtist(); //*Selects the specified coloumns in the Artist table*//
            cmbx_Artist.DataSource = connection.tbl;//*All the selected fields are filtered inside the table*// 
            cmbx_Artist.DisplayMember = "Artist Name";//*The combo-box will only display the names of the artist for each field or row*//
            cmbx_Artist.ValueMember = "ID";//*The combo-box will only display the stored data referencing its ID*//

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //
            connection.GetCertainTrack(int.Parse(cmbx_Artist.SelectedValue.ToString()));//*The selected Artist must be allocated from the ID*//

            if (connection.tbl.Rows[0][1].ToString() == "0")
            {
                this.Count = 0;//the integer 'Count must be set to 0 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }

            else if (connection.tbl.Rows[0][1].ToString() == "1")
            {
                this.Count = 1;//the integer 'Count must be set to 1 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }

            else if (connection.tbl.Rows[0][1].ToString() == "2")
            {
                this.Count = 2;//the integer 'Count must be set to 2 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }

            else if (connection.tbl.Rows[0][1].ToString() == "3")
            {
                this.Count = 3;//the integer 'Count must be set to 3 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }

            else if (connection.tbl.Rows[0][1].ToString() == "4")
            {
                this.Count = 4;//the integer 'Count must be set to 4 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }
            
            else if (connection.tbl.Rows[0][1].ToString() == "5")
            {
                this.Count = 5;//the integer 'Count must be set to 5 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }

            else if (connection.tbl.Rows[0][1].ToString() == "6")
            {
                this.Count = 6;//the integer 'Count must be set to 6 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }

            else if (connection.tbl.Rows[0][1].ToString() == "7")
            {
                this.Count = 7;//the integer 'Count must be set to 7 if the condition is met'//
                picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD5.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD6.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
                picbx_CD7.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            }


            txt_Track.Text = connection.tbl.Rows[0][2].ToString(); //*The name of the track will be displayed in the text-box once the ArtistID has been identified*//
            txtMask_Year.Text = connection.tbl.Rows[0][3].ToString(); //*The Year established will be displayed in the text-box once the genreID has been identified*//
        }

        private void picbx_CD1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 1;//the integer 'Count' must be set to 1 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//

        }

        private void picbx_CD2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 2;//the integer 'Count' must be set to 2 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
        }

        private void picbx_CD3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 3;//the integer 'Count' must be set to 3 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
        }

        private void picbx_CD4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 4;//the integer 'Count' must be set to 4 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//

        }

        private void picbx_CD5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 5;//the integer 'Count' must be set to 5 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//

        }

        private void picbx_CD6_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 6;//the integer 'Count' must be set to 6 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._1CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
        }

        private void picbx_CD7_MouseClick(object sender, MouseEventArgs e)
        {
            this.Count = 7;//the integer 'Count' must be set to 7 when this event occurs//
            picbx_CD1.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD2.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD3.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD4.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD5.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD6.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//
            picbx_CD7.Image = MusicRatings.Properties.Resources._2CD; // the picturebox must display a designated image when assigning it to the propeties' resources//

        }

        
    }
}
