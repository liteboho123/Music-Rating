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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        // set a time limit //

        Timer show;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            show = new Timer(); // refreshens the timer //
            show.Interval = 3000; // a set limit on when the timer should cease //
            show.Start(); // the timer begins thus interval will increase //
            show.Tick += new EventHandler(show_Tick); // event handler is enabled as the timer continiously runs //

        }

        // close the splash screen and open the main application //

        void show_Tick(object sender, EventArgs e)
        {
            show.Stop(); // When timer stops, the follwing should occur //
            AddGenre on = new AddGenre(); // creating a class variable for the 'AddGenre' class//
            on.Show(); // temporarily suspend the current form //
            this.Hide(); // open the designated form //
        }
    }
}
