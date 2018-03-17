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
    public partial class AddGenre : Form
    {
        MusicConnection connection; // referencing data from the 'MusicConnection' class //      
       

        public AddGenre()
        {
            InitializeComponent();
        }           


        private void btn_Clear_Click(object sender, EventArgs e)
        {            
            txt_Genre.Clear(); // clear text inside the 'Genre' textbox //            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            connection = new MusicConnection(); // refreshens the 'MusicConnection' class //              

            try
            {
                if (string.IsNullOrWhiteSpace(txt_Genre.Text)) // if the 'Genre' textbox is left empty or no texts was inputted, execute the following //
                {
                    MessageBox.Show("Please enter the genre of this music"); // A messagebox should be displayed only if the condition is met //
                }

                else
                {
                    connection.GetGenre(txt_Genre.Text); // Adds the Genre entered by the user to the database //
                }
            }
            catch
            {
 
            }
           
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            AddArtist artist = new AddArtist(); // creating a class variable for the 'AddArtist' class//
            this.Hide(); // temporarily suspend the current form //
            artist.Show(); // open the designated form //
        }
    }
}
