using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_managment_system;
using Cinema_ticket_booking;

namespace ticket_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 12) 
            {
                pictureBox1.Image = imageList1.Images[count];
                count ++;
            }
            else
            {
                count = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            hotel_managment_system.Form1 hms = new hotel_managment_system.Form1();
            hms.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cinema_ticket_booking.Form1 ctb = new Cinema_ticket_booking.Form1();
            ctb.Show();
        }
    }
}
