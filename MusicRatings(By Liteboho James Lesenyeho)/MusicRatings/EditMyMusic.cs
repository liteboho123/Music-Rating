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
    public partial class EditMyMusic : Form
    {
        MusicConnection connect; // referencing data from the 'MusicConnection' class //
       

        public EditMyMusic()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            AddGenre r = new AddGenre(); // creating a class variable for the 'AddGenre' class//
            this.Hide(); // temporarily suspend the current form //
            r.Show(); // open the designated form //
        }     

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            connect = new MusicConnection(); // refreshens the 'MusicConnection' class //
            connect.GetMusic(); //*Selects all specified columns in the Genre, Artist and Track table*//      

            try
            {
                for (int i = 0; i < DGV_MusicView.Rows.Count; i++)//when the 'for' loop method is executed, it should count the numbers of rows stored inside the DataGridView //
                {
                    DataGridViewRow delrow = DGV_MusicView.Rows[i];// the newly created 'DataGridViewRow' is equivalent to the numbers of rows stored inside the DataGridView // 
                    if (delrow.Selected == true) //if a row from the DataGridView is selected, do the following //
                    {
                        DGV_MusicView.Rows.RemoveAt(i);//the selected row will be removed from the DataDridView// 
                        connect.DeleteMusicRow(i);//the selected row will also be removed from the database//
                        MessageBox.Show("The selected record has been deleted");// A messagebox should be displayed only if the condition is met //
                    }                   
                }
            }
            catch
            { 

            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            connect = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connect.GetMusic();//*Selects all specified columns in the Genre, Artist and Track table*//
            DGV_MusicView.DataSource = connect.tbl;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
        }

        private void btn_SearchArt_Click(object sender, EventArgs e)
        {
            connect = new MusicConnection(); // refreshens the 'MusicConnection' class //
            try
            {
                connect.SearchArtist(txt_SearchArt.Text);//Searches the name of the artist entered in the 'SearchArt' textbox//
                DGV_MusicView.DataSource = connect.tbl;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
                txt_SearchArt.Clear();// clear text inside the 'SearchArt' textbox //
            }
            catch (Exception ft)
            {
                MessageBox.Show(ft.Message); // display a message-box when the exception occurs //
            }
        }

        private void btn_SearchRate_Click(object sender, EventArgs e)
        {
            connect = new MusicConnection(); // refreshens the 'MusicConnection' class //
            try
            {
                connect.SearchRating(int.Parse(txt_SearchRate.Text));//Searches the rate of the music entered in the 'SearchRate' textbox//
                DGV_MusicView.DataSource = connect.tbl;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
                txt_SearchRate.Clear();// clear text inside the 'SearchRate' textbox //
            }
            catch(Exception)
            {
                MessageBox.Show("Please specify a number between 0 to 7"); // display a message-box when the exception occurs //
            }
        }

        private void btn_SearchSong_Click(object sender, EventArgs e)
        {
            connect = new MusicConnection(); // refreshens the 'MusicConnection' class //
            try
            {
                connect.SearchSong(txt_SearchSong.Text);//Searches the name of the track entered in the 'SearchSong' textbox//
                DGV_MusicView.DataSource = connect.tbl;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
                txt_SearchSong.Clear();// clear text inside the 'SearchSong' textbox //
            }
            catch(Exception ft)
            {
                MessageBox.Show(ft.Message); // display a message-box when the exception occurs //
            }
        }

        private void btn_SearchYear_Click(object sender, EventArgs e)
        {
            connect = new MusicConnection(); // refreshens the 'MusicConnection' class //
            try
            {
                connect.SearchYear(int.Parse(txt_SearchYear.Text));//Searches the Year the track was established in the 'SearchYear' textbox//
                DGV_MusicView.DataSource = connect.tbl;//*All the selected fields are filtered inside the table and stored inside the grid-view*//
                txt_SearchYear.Clear();// clear text inside the 'SearchYear' textbox //
            }
            catch(Exception)
            {
                MessageBox.Show("Please specify the year of release"); // display a message-box when the exception occurs //
            }
        }

        private void lblLink_Genre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateGenre genre = new UpdateGenre(); // creating a class variable for the 'UpdateGenre' class//
            this.Hide(); // temporarily suspend the current form //
            genre.Show(); // open the designated form //
        }

        private void lblLink_Artist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateArtist artist = new UpdateArtist(); // creating a class variable for the 'UpdateArtist' class//
            this.Hide(); // temporarily suspend the current form //
            artist.Show();// open the designated form //
        }

        private void lblLink_Track_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateTrack track = new UpdateTrack(); // creating a class variable for the 'UpdateTrack' class//
            this.Hide(); // temporarily suspend the current form //
            track.Show();// open the designated form //
        }
    }
}
