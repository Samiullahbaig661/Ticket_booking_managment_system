using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_ticket_booking
{
    public partial class MovieSelectionForm : Form
    {
        public MovieSelectionForm()
        {
            InitializeComponent();
        }

        private List<string> bookings = new List<string>();
        private int ticketprice = 0;
        private void MovieSelectionForm_Load(object sender, EventArgs e)
        {
            string[] movies = { "Avengers: Endgame", "Inception", "The Dark Knight", "Interstellar", "Spider-Man: No Way Home" };
            string[] showtimes = { "10:00 AM", "1:00 PM", "4:00 PM", "7:00 PM", "10:00 PM" };
            string[] seatTypes = { "Regular", "Premium", "VIP" };
            string[] categories = { "Adult", "Child", "Senior" };

            cbMovie.Items.AddRange(movies);
            cbShowtime.Items.AddRange(showtimes);
            cbSeatType.Items.AddRange(seatTypes);
            cbCategory.Items.AddRange(categories);
        }
        //private void btnConfirmBooking_Click(object sender, EventArgs e)
        //{     
        //}
        
        private void SaveBookingToFile(string Name, string CNIC, string Movie, string showtime, string seatType, string category, int seats)
        {
            string filepath = "cinemaBookings.csv";
            bool fileExists = File.Exists(filepath);

            using (StreamWriter Writer = new StreamWriter(filepath))
            {
                if (!fileExists)
                {
                    Writer.WriteLine("Name,CNIC,Movie,Showtime,SeatType,Category,Seats");

                }
                Writer.WriteLine($"{Name},{CNIC},{Movie},{showtime},{seatType},{category},{seats}");
            }
        }
        //private void btnReset_Click(object sender, EventArgs e)
        //{          
        //}
        //private void btnViewBooking_Click(object sender, EventArgs e)
        //{            
        //}
        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //}

        private void btnConfirmBooking_Click_1(object sender, EventArgs e)
        {
            string customerName = txtName.Text.Trim();
            string customerCNIC = txtCNIC.Text.Trim();
            string selectedMovie = cbMovie.SelectedItem?.ToString();
            string selectedShowtime = cbShowtime.SelectedItem?.ToString();
            string selectedSeatType = cbSeatType.SelectedItem?.ToString();
            string selectedCategory = cbCategory.SelectedItem?.ToString();
            int seatsToBook;

            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerCNIC) ||
                string.IsNullOrWhiteSpace(selectedMovie) || string.IsNullOrWhiteSpace(selectedShowtime) ||
                string.IsNullOrWhiteSpace(selectedSeatType) || string.IsNullOrWhiteSpace(selectedCategory) ||
                !int.TryParse(txtSeats.Text.Trim(), out seatsToBook) || seatsToBook <= 0)
            {
                MessageBox.Show("Please fill all fields correctly.", "Input Error");
                return;
            }

            ticketprice = 0;
            if (selectedCategory == "Adult")
            {
                switch (selectedSeatType)
                {
                    case "Regular":
                        ticketprice = 500 * seatsToBook;
                        break;
                    case "Premium":
                        ticketprice = 800 * seatsToBook;
                        break;
                    case "VIP":
                        ticketprice = 1200 * seatsToBook;
                        break;
                }
            }
            else if (selectedCategory == "Child")
            {
                switch (selectedSeatType)
                {
                    case "Regular":
                        ticketprice = 300 * seatsToBook;
                        break;
                    case "Premium":
                        ticketprice = 500 * seatsToBook;
                        break;
                    case "VIP":
                        ticketprice = 800 * seatsToBook;
                        break;
                }
            }
            else if (selectedCategory == "Senior")
            {
                switch (selectedSeatType)
                {
                    case "Regular":
                        ticketprice = 400 * seatsToBook;
                        break;
                    case "Premium":
                        ticketprice = 600 * seatsToBook;
                        break;
                    case "VIP":
                        ticketprice = 1000 * seatsToBook;
                        break;
                }
            }
            lblPrice.Text = $"Total Price: Rs.{ticketprice}";

            string bookingDetails = $"**************************\n" +
                                    $"        Cinema Ticket\n" +
                                    $"**************************\n" +
                                    $"Customer Name: {customerName}\n" +
                                    $"CNIC: {customerCNIC}\n" +
                                    $"Movie: {selectedMovie}\n" +
                                    $"Showtime: {selectedShowtime}\n" +
                                    $"Seat Type: {selectedSeatType}\n" +
                                    $"Category: {selectedCategory}\n" +
                                    $"Seats Booked: {seatsToBook}\n" +
                                    $"Total Price: Rs.{ticketprice}\n" +
                                    $"**************************";

            bookings.Add(bookingDetails);

            MessageBox.Show("Booking confirmed!\n\n" + bookingDetails, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveBookingToFile(customerName, customerCNIC, selectedMovie, selectedShowtime, selectedSeatType, selectedCategory, seatsToBook);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cancellation feature is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCNIC.Clear();
            txtSeats.Clear();
            cbMovie.SelectedIndex = -1;
            cbShowtime.SelectedIndex = -1;
            cbSeatType.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            lblPrice.Text = "Total Price: 0";
            MessageBox.Show("Form has been reset!", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnViewBooking_Click_1(object sender, EventArgs e)
        {
            if (bookings.Count > 0)
            {
                string allBookings = string.Join("\n\n", bookings);
                MessageBox.Show(allBookings, "View Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No bookings available.", "View Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
    
}
