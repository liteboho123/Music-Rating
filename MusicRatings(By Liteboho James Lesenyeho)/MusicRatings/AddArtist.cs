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
    public partial class AddArtist : Form
    {
        public AddArtist()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            AddTrack track = new AddTrack();  // creating a class variable for the 'AddTrack' class//
            this.Hide(); // temporarily suspend the current form //
            track.Show();// open the designated form //
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Artist.Clear(); // clear text inside the 'Artist' textbox //   
        }


        private void AddArtist_Load(object sender, EventArgs e)
        {
            MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //  

            connection.SelectGenre(); //*Selects the specified coloumns in the genre table*//
            cmbx_Genre.DataSource = connection.tbl; //*All the selected fields are filtered inside the table*// 
            cmbx_Genre.DisplayMember = "Genre";//*The combo-box will only display the names of the genre for each field or row*//
            cmbx_Genre.ValueMember = "ID";//*The combo-box will only display the stored data referencing its ID*//
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                MusicConnection connection = new MusicConnection(); // refreshens the 'MusicConnection' class //

                if (string.IsNullOrEmpty(txt_Artist.Text)) // if the 'Artist' textbox is left empty or text wasn't inputted, execute the following //
                {
                    MessageBox.Show("Please enter the artist's name of this music"); // A messagebox should be displayed only if the condition is met //
                }

                else
                {
                    connection.GetArtist(txt_Artist.Text, int.Parse(cmbx_Genre.SelectedValue.ToString())); // Adds the Artist's name entered by the user to the database //
                }
            }
            catch
            {

            }
        }

       
    }
}
