using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_ticket_booking
{
    public partial class AvailableMoviesForm : Form
    {
        public AvailableMoviesForm()
        {
            InitializeComponent();
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
        private void AvailableMoviesForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }
        private void LoadMovies()
        {
            lstMovies.Items.Clear();
            string[] movies = {
                "Avengers: Endgame - 10:00 AM, 1:00 PM, 4:00 PM",
                "Inception - 11:00 AM, 2:00 PM, 5:00 PM",
                "The Dark Knight - 12:00 PM, 3:00 PM, 6:00 PM",
                "Interstellar - 1:00 PM, 4:00 PM, 7:00 PM",
                "Spider-Man: No Way Home - 2:00 PM, 5:00 PM, 8:00 PM"
            };

            foreach (var movie in movies)
            {
                lstMovies.Items.Add(movie);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMovies();
            MessageBox.Show("Movie list refreshed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
