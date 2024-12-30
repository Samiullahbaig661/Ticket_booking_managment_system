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

namespace hotel_managment_system
{
    public partial class BookingForm : Form
    {

        public BookingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            string[] trainOptions = { "pakistan express", "hazara", "shalimar" ,"allama iqbal"}; 
            string[] sourceCities = { "Karachi", "Hyderabad", "sukhar", "Multan", "Lahore" };
            string[] destinationCities = { "Hyderabad", "Panoaqil", "Gujraat", "jehlum", "Islamabad" };
            string[] type = { "Economy", "AC", "AC Sleeper" };
            string[] catagor = { "Adult", "Senior", "Child" };
            foreach (var item in catagor)
            {
                cbCategory.Items.Add(item);
            }
            foreach (var typ in type)
            {
                cbSeatType.Items.Add(typ);
            }
            foreach (string train in trainOptions)
            {
                cbTrain.Items.Add(train);
            }
            foreach (string city in sourceCities)
            {
                cbSource.Items.Add(city);
            }
            foreach (string city in destinationCities)
            {
                cbDestination.Items.Add(city);
            }
      

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbSeatType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cnic_Click(object sender, EventArgs e)
        {

        }

        private void Names_Click(object sender, EventArgs e)
        {

        }
        private List<string> bookings = new List<string>();
        int ticketPrice = 0;

        private void btnConf_booking_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string cnic = txtCNIC.Text.Trim();
            string trainName = cbTrain.Text.Trim();
            string source = cbSource.Text.Trim();
            string destination = cbDestination.Text.Trim();
            string seatType = cbSeatType.Text.Trim();
            string passingerCatagory = cbCategory.Text.Trim();
            string category = cbCategory.SelectedItem.ToString();
            string seat1Type = cbSeatType.SelectedItem.ToString();
            string sourceCity = cbSource.SelectedItem.ToString();
            string destinationCity = cbDestination.SelectedItem.ToString();
            DateTime journeyDate = dtpJourneyDate.Value;

    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(cnic) ||
        string.IsNullOrWhiteSpace(trainName) || string.IsNullOrWhiteSpace(source) ||
        string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(seatType) ||
        string.IsNullOrWhiteSpace(passingerCatagory))
    {
        MessageBox.Show("Please fill all fields.", "Input Error");
        return;
    }

    if (!int.TryParse(tXTSEAT.Text.Trim(), out int seatsToBook) || seatsToBook <= 0)
    {
        MessageBox.Show("Please enter a valid number of seats.", "Input Error");
        return;
    }
            // Variables to store the selected values


            // Base ticket price (default)
         
            // Price adjustment based on source and destination cities
            if (sourceCity == "Karachi" && destinationCity == "Hyderabad")
                ticketPrice = 500;
            else if (sourceCity == "Karachi" && destinationCity == "Panoaqil")
                ticketPrice = 800;
            else if (sourceCity == "Hyderabad" && destinationCity == "Gujraat")
                ticketPrice = 1500;
            else if (sourceCity == "Multan" && destinationCity == "Islamabad")
                ticketPrice = 2000;
            else if (sourceCity == "Lahore" && destinationCity == "Islamabad")
                ticketPrice = 1800;
            else if (sourceCity == "sukhar" && destinationCity == "Islamabad")
                ticketPrice = 1800;

            else
                ticketPrice = 1000; 

            if (category == "Adult")
            {
                if (seat1Type == "AC")
                    ticketPrice += 1000 * seatsToBook; 
                else if (seat1Type == "AC Sleeper")
                    ticketPrice += 1500 * seatsToBook;
                else if (seat1Type == "Economy")
                    ticketPrice += 500 * seatsToBook;
            }
            else if (category == "Senior")
            {
                if (seat1Type == "AC")
                    ticketPrice += 800 * seatsToBook;
                else if (seat1Type == "AC Sleeper")
                    ticketPrice += 1200 * seatsToBook;
                else if (seat1Type == "Economy")
                    ticketPrice += 400 * seatsToBook;
            }
            else if (category == "Child")
            {
                if (seat1Type == "AC")
                    ticketPrice += 500* seatsToBook;
                else if (seat1Type == "AC Sleeper")
                    ticketPrice += 800 * seatsToBook;
                else if (seat1Type == "Economy")
                    ticketPrice += 200 * seatsToBook;
            }

        
            MessageBox.Show("The ticket price is: " + ticketPrice + " PKR");



            lblPrice.Text = $"Total Price: {ticketPrice:C}"; 
            string bookingDetails = "**************************\n" +
    "          Railway Ticket\n" +
    "**************************\n" +
    $"Passenger Name: {name}\n" +
    $"CNIC: {cnic}\n" +
    $"Train Name: {trainName}\n" +
    $"Source: {source}\n" +
    $"Destination: {destination}\n" +
    $"Journey Date: {journeyDate.ToShortDateString()}\n" +
    $"Seat Type: {seatType}\n" +
    $"Category: {passingerCatagory}\n" +
    $"Seats Booked: {seatsToBook}\n" +
    $"Total Price: {ticketPrice:C}\n" +
    "**************************";
            bookings.Add(bookingDetails);

            MessageBox.Show("Ticket generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string filePath = "BookingDetails.csv"; 
            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath,true))  
            {
                if (!fileExists)  
                {
                    writer.WriteLine("Name,CNIC,Catagory,Train Name,Source,Destination,Journey Date,Seat Type,Seats Booked");
                }
                writer.WriteLine($"{name} , {cnic} , {passingerCatagory},{trainName},{source},{destination},{journeyDate.ToShortDateString()},{seatType},{seatsToBook}");
            }
            MessageBox.Show("Booking confirmed and saved to CSV file!");

            UpdateBookingGrid(txtname.Text, txtCNIC.Text, passingerCatagory,  trainName,source,destination, journeyDate, seatType, seatsToBook);
        }
        private void UpdateBookingGrid(string txtname,string txtCNIC,string passingerCatagory, string source ,string destination,  string trainName, DateTime journeyDate, string seatType, int seatsToBook)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell {Value = txtname });
            row.Cells.Add(new DataGridViewTextBoxCell{ Value = txtCNIC });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = passingerCatagory });
            row.Cells.Add(new DataGridViewTextBoxCell{Value = trainName });
            row.Cells.Add(new DataGridViewTextBoxCell{ Value = source });
            row.Cells.Add(new DataGridViewTextBoxCell {Value = destination });
            row.Cells.Add(new DataGridViewTextBoxCell{ Value = journeyDate.ToShortDateString() });
            row.Cells.Add(new DataGridViewTextBoxCell{Value = seatType });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = seatsToBook });

            dgBookingDetails.Rows.Add(row);

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtCNIC.Clear();
            tXTSEAT.Clear();
            cbTrain.SelectedIndex = -1;
            cbSeatType.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            cbSource.SelectedIndex = -1;
            cbDestination.SelectedIndex = -1;
            dtpJourneyDate.Value = DateTime.Now;
            foreach (DataGridViewRow row in dgBookingDetails.Rows)
            {
                row.Visible = true;
            }
            MessageBox.Show("Form has been reset!");
        }

        private void dgBookingDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgBookingDetails.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the selected booking?",
                                                      "Confirm Cancellation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string filePath = "BookingDetails.csv";
                    int cnicColumnIndex = 1; 

                    List<string> cnicsToDelete = new List<string>();

                  
                    foreach (DataGridViewRow row in dgBookingDetails.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            string cnicToDelete = row.Cells[cnicColumnIndex]?.Value?.ToString();

                            if (!string.IsNullOrEmpty(cnicToDelete))
                            {
                                cnicsToDelete.Add(cnicToDelete);
                                dgBookingDetails.Rows.Remove(row); 
                            }
                        }
                    }

                  
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


     


        private void label6_Click(object sender, EventArgs e)
        {

        }
       
            private void btnVeiw_Click(object sender, EventArgs e)
        {
        
            
        }

        private void tXTSEAT_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse( tXTSEAT.Text.Trim(), out int seatsToBook) && seatsToBook > 0)
            {
               
                lblPrice.Text = $"Total Price: {ticketPrice:C}";  
            }
            else
            {
                lblPrice.Text = "Total Price: 0";
            }
        }

        private void btnVeiw_Click_1(object sender, EventArgs e)
        {
            if (bookings.Count > 0)
            {
                string allBookings = string.Join("\n\n", bookings);

                Form viewBookingForm = new Form();
                viewBookingForm.Text = "View Bookings";
                viewBookingForm.Size = new Size(400, 300);

                RichTextBox rtbBookingDetails = new RichTextBox();
                rtbBookingDetails.Dock = DockStyle.Fill;
                rtbBookingDetails.Text = allBookings;
                rtbBookingDetails.ReadOnly = true;

                viewBookingForm.Controls.Add(rtbBookingDetails);

                viewBookingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No bookings to display.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
