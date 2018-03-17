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
    public partial class UpdateGenre : Form
    {
        public UpdateGenre()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.UpdateGenre(txt_Genre.Text, int.Parse(cmbx_Artist.SelectedValue.ToString()));//*The artist's name will be displayed in the text-box once the genreID has been identified*//
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Genre.Clear(); // clear text inside the 'Genre' textbox //
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            EditMyMusic edit = new EditMyMusic(); // creating a class variable for the 'EditMyMusic' class//
            this.Hide(); // temporarily suspend the current form //
            edit.Show(); // open the designated form //
        }

        private void UpdateGenre_Load(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.SelectArtist();//*Selects the specified columns in the Artist table*//
            cmbx_Artist.DataSource = connection.tbl;//*All the selected fields are filtered inside the table*// 
            cmbx_Artist.DisplayMember = "Artist Name";//*The combo-box will only display the names of the Artist for each field or row*//
            cmbx_Artist.ValueMember = "ID";//*The combo-box will only display the stored data referencing its ID*//
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

            connection.GetCertainGenre(int.Parse(cmbx_Artist.SelectedValue.ToString()));//*The selected Artist must be allocated from the ID*//
            txt_Genre.Text = connection.tbl.Rows[0][1].ToString();//*The genre will be displayed in the text-box once the genreID has been identified*//
        }
    }
}
