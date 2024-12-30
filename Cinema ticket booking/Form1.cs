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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_1Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void btnVeiw_Click_2(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBookTickets_Click(object sender, EventArgs e)
        {
            MovieSelectionForm movieSelectionForm = new MovieSelectionForm();
            movieSelectionForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BookingHistoryForm bookingHistoryForm = new BookingHistoryForm();
            bookingHistoryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvailableMoviesForm availableMoviesForm = new AvailableMoviesForm();
            availableMoviesForm.Show();
            this.Hide();
        }
    }
}
