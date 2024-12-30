using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema_ticket_booking
{
    public partial class BookingHistoryForm : Form
    {
        private string bookingFilepath = "cinemaBooking.csv";
        public BookingHistoryForm()
        {
            InitializeComponent();
        }

        private void BookingHistoryForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }
        private void LoadBookings()
        {
            lstBookings.Items.Clear();

            if (File.Exists(bookingFilepath))
            {
                var bookings = File.ReadAllLines(bookingFilepath).Skip(1);
                if (bookings.Any())
                {
                    foreach (var booking in bookings)
                    {
                        lstBookings.Items.Add(booking);
                    }
                }
                else
                {
                    lstBookings.Items.Add("No bookings available.");
                }
            }
            else
            {
                lstBookings.Items.Add("No bookings available. File not found.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(File.Exists(bookingFilepath))
            {
                File.Delete(bookingFilepath);
                lstBookings.Items.Clear();
                lstBookings.Items.Add("All bookings have been cleared.");
            }
            else
            {
                MessageBox.Show("No booking file exists to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
