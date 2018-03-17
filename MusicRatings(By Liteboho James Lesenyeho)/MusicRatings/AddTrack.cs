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
    public partial class AddTrack : Form
    {
        public AddTrack()
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
            txt_Track.Clear(); // clear text inside the 'Track' textbox //   
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //


                if (string.IsNullOrEmpty(txt_Track.Text)) // if the 'Tracks' textbox is left empty or no texts was inputted, execute the following //
                {
                    MessageBox.Show("Please enter the name of this track"); // A messagebox should be displayed only if the condition is met //
                }

                else
                {
                    connection.GetTrack(txt_Track.Text, 0, int.Parse(cmbx_Artist.SelectedValue.ToString())); // Adds the Artist's name entered by the user to the database //
                }
            }
            catch
            {
 
            }
        }

        private void AddTrack_Load(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection();// refreshens the 'MusicConnection' class //

            connection.SelectArtist();//*Selects the specified coloumns in the Artist table*//
            cmbx_Artist.DataSource = connection.tbl;//*All the selected fields are filtered inside the table*//
            cmbx_Artist.DisplayMember = "Artist Name";//*The combo-box will only display the names of the Artist for each field or row*//
            cmbx_Artist.ValueMember = "ID";//*The combo-box will only display the stored data referencing its ID*//
        }
    }
}
