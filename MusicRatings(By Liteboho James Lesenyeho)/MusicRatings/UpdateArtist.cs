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
    public partial class UpdateArtist : Form
    {
        public UpdateArtist()
        {
            InitializeComponent();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            EditMyMusic edit = new EditMyMusic(); // creating a class variable for the 'EditMyMusic' class//
            this.Hide(); // temporarily suspend the current form //
            edit.Show(); // open the designated form //
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Artist.Clear(); // clear text inside the 'Artist' textbox //
        }

        private void UpdateArtist_Load(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.SelectTrack(); //*Selects the specified coloumns in the Track table*//
            cmbx_Track.DataSource = connection.tbl;//*All the selected fields are filtered inside the table*// 
            cmbx_Track.DisplayMember = "Track";//*The combo-box will only display the names of the genre for each field or row*//
            cmbx_Track.ValueMember = "ID";//*The combo-box will only display the stored data referencing its ID*//
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.GetCertainArtist(int.Parse(cmbx_Track.SelectedValue.ToString()));//*The selected genre must be allocated from the ID*//
            txt_Artist.Text = connection.tbl.Rows[0][1].ToString();//*The artist's name will be displayed in the text-box once the genreID has been identified*//
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.UpdateArtist(txt_Artist.Text, int.Parse(cmbx_Track.SelectedValue.ToString())); // Updates the Artist's name entered by the user to the database //
        }
    }
}
