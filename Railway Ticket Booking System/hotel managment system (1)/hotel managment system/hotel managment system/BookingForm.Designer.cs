namespace hotel_managment_system
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtseats = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTrain = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.dtpJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.cbSeatType = new System.Windows.Forms.ComboBox();
            this.tXTSEAT = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.btnConf_booking = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.seatToBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cbdeatinatiom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbsourcee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookingDetails = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnVeiw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOOKING TICKETS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Train";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(267, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source Station";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(267, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destination Station\t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(267, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Journey Date\t";
            // 
            // txtseats
            // 
            this.txtseats.AutoSize = true;
            this.txtseats.BackColor = System.Drawing.Color.DimGray;
            this.txtseats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtseats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseats.ForeColor = System.Drawing.Color.White;
            this.txtseats.Location = new System.Drawing.Point(267, 379);
            this.txtseats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtseats.Name = "txtseats";
            this.txtseats.Size = new System.Drawing.Size(165, 24);
            this.txtseats.TabIndex = 6;
            this.txtseats.Text = "\tNumber of Seats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(267, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "\tSeat Type";
            // 
            // cbTrain
            // 
            this.cbTrain.BackColor = System.Drawing.Color.White;
            this.cbTrain.FormattingEnabled = true;
            this.cbTrain.Location = new System.Drawing.Point(511, 193);
            this.cbTrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(160, 24);
            this.cbTrain.TabIndex = 8;
            this.cbTrain.SelectedIndexChanged += new System.EventHandler(this.cbTrain_SelectedIndexChanged);
            // 
            // cbDestination
            // 
            this.cbDestination.BackColor = System.Drawing.Color.White;
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(511, 270);
            this.cbDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(160, 24);
            this.cbDestination.TabIndex = 9;
            this.cbDestination.SelectedIndexChanged += new System.EventHandler(this.cbDestination_SelectedIndexChanged);
            // 
            // cbSource
            // 
            this.cbSource.BackColor = System.Drawing.Color.White;
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(511, 233);
            this.cbSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(160, 24);
            this.cbSource.TabIndex = 10;
            this.cbSource.SelectedIndexChanged += new System.EventHandler(this.cbSource_SelectedIndexChanged);
            // 
            // dtpJourneyDate
            // 
            this.dtpJourneyDate.Location = new System.Drawing.Point(509, 304);
            this.dtpJourneyDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpJourneyDate.Name = "dtpJourneyDate";
            this.dtpJourneyDate.Size = new System.Drawing.Size(161, 22);
            this.dtpJourneyDate.TabIndex = 11;
            // 
            // cbSeatType
            // 
            this.cbSeatType.BackColor = System.Drawing.Color.White;
            this.cbSeatType.FormattingEnabled = true;
            this.cbSeatType.Location = new System.Drawing.Point(511, 341);
            this.cbSeatType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSeatType.Name = "cbSeatType";
            this.cbSeatType.Size = new System.Drawing.Size(160, 24);
            this.cbSeatType.TabIndex = 12;
            this.cbSeatType.SelectedIndexChanged += new System.EventHandler(this.cbSeatType_SelectedIndexChanged);
            // 
            // tXTSEAT
            // 
            this.tXTSEAT.BackColor = System.Drawing.Color.White;
            this.tXTSEAT.Location = new System.Drawing.Point(511, 379);
            this.tXTSEAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tXTSEAT.Name = "tXTSEAT";
            this.tXTSEAT.Size = new System.Drawing.Size(159, 22);
            this.tXTSEAT.TabIndex = 13;
            this.tXTSEAT.TextChanged += new System.EventHandler(this.tXTSEAT_TextChanged);
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.BackColor = System.Drawing.Color.DimGray;
            this.Names.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Names.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Names.ForeColor = System.Drawing.Color.White;
            this.Names.Location = new System.Drawing.Point(267, 75);
            this.Names.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(69, 26);
            this.Names.TabIndex = 17;
            this.Names.Text = "Name";
            this.Names.Click += new System.EventHandler(this.Names_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(511, 74);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(159, 22);
            this.txtname.TabIndex = 18;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // cnic
            // 
            this.cnic.AutoSize = true;
            this.cnic.BackColor = System.Drawing.Color.DimGray;
            this.cnic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cnic.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic.ForeColor = System.Drawing.Color.White;
            this.cnic.Location = new System.Drawing.Point(267, 107);
            this.cnic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(60, 26);
            this.cnic.TabIndex = 19;
            this.cnic.Text = "CNIC";
            this.cnic.Click += new System.EventHandler(this.cnic_Click);
            // 
            // txtCNIC
            // 
            this.txtCNIC.BackColor = System.Drawing.Color.White;
            this.txtCNIC.Location = new System.Drawing.Point(511, 106);
            this.txtCNIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(159, 22);
            this.txtCNIC.TabIndex = 20;
            this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
            // 
            // btnConf_booking
            // 
            this.btnConf_booking.BackColor = System.Drawing.Color.DimGray;
            this.btnConf_booking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConf_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf_booking.ForeColor = System.Drawing.Color.White;
            this.btnConf_booking.Location = new System.Drawing.Point(511, 439);
            this.btnConf_booking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConf_booking.Name = "btnConf_booking";
            this.btnConf_booking.Size = new System.Drawing.Size(181, 44);
            this.btnConf_booking.TabIndex = 21;
            this.btnConf_booking.Text = "Confirm Booking";
            this.btnConf_booking.UseVisualStyleBackColor = false;
            this.btnConf_booking.Click += new System.EventHandler(this.btnConf_booking_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.DimGray;
            this.lblCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(267, 148);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(201, 26);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "Passenger Category";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(511, 149);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 24);
            this.cbCategory.TabIndex = 24;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DimGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(256, 439);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 44);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(953, 727);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(239, 57);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // seatToBook
            // 
            this.seatToBook.HeaderText = "Seat To Book";
            this.seatToBook.MinimumWidth = 6;
            this.seatToBook.Name = "seatToBook";
            this.seatToBook.Width = 125;
            // 
            // typeSeat
            // 
            this.typeSeat.HeaderText = "Seat Type";
            this.typeSeat.MinimumWidth = 6;
            this.typeSeat.Name = "typeSeat";
            this.typeSeat.Width = 125;
            // 
            // journayDate
            // 
            this.journayDate.HeaderText = "Journey Date";
            this.journayDate.MinimumWidth = 6;
            this.journayDate.Name = "journayDate";
            this.journayDate.Width = 125;
            // 
            // Cbdeatinatiom
            // 
            this.Cbdeatinatiom.HeaderText = "Destination";
            this.Cbdeatinatiom.MinimumWidth = 6;
            this.Cbdeatinatiom.Name = "Cbdeatinatiom";
            this.Cbdeatinatiom.Width = 125;
            // 
            // cbsourcee
            // 
            this.cbsourcee.HeaderText = "Source";
            this.cbsourcee.MinimumWidth = 6;
            this.cbsourcee.Name = "cbsourcee";
            this.cbsourcee.Width = 125;
            // 
            // trainName
            // 
            this.trainName.HeaderText = "Train Name";
            this.trainName.MinimumWidth = 6;
            this.trainName.Name = "trainName";
            this.trainName.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // txtcni
            // 
            this.txtcni.HeaderText = "CNIC";
            this.txtcni.MinimumWidth = 6;
            this.txtcni.Name = "txtcni";
            this.txtcni.Width = 125;
            // 
            // txttName
            // 
            this.txttName.HeaderText = "Name";
            this.txttName.MinimumWidth = 6;
            this.txttName.Name = "txttName";
            this.txttName.Width = 125;
            // 
            // dgBookingDetails
            // 
            this.dgBookingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookingDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txttName,
            this.txtcni,
            this.Category,
            this.trainName,
            this.cbsourcee,
            this.Cbdeatinatiom,
            this.journayDate,
            this.typeSeat,
            this.seatToBook});
            this.dgBookingDetails.Location = new System.Drawing.Point(57, 508);
            this.dgBookingDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgBookingDetails.Name = "dgBookingDetails";
            this.dgBookingDetails.RowHeadersWidth = 51;
            this.dgBookingDetails.Size = new System.Drawing.Size(1135, 198);
            this.dgBookingDetails.TabIndex = 22;
            this.dgBookingDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookingDetails_CellContentClick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(436, 417);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 27;
            // 
            // btnVeiw
            // 
            this.btnVeiw.BackColor = System.Drawing.Color.DimGray;
            this.btnVeiw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeiw.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiw.ForeColor = System.Drawing.Color.White;
            this.btnVeiw.Location = new System.Drawing.Point(784, 439);
            this.btnVeiw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVeiw.Name = "btnVeiw";
            this.btnVeiw.Size = new System.Drawing.Size(192, 44);
            this.btnVeiw.TabIndex = 32;
            this.btnVeiw.Text = "View Booking";
            this.btnVeiw.UseVisualStyleBackColor = false;
            this.btnVeiw.Click += new System.EventHandler(this.btnVeiw_Click_1);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1295, 866);
            this.Controls.Add(this.btnVeiw);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dgBookingDetails);
            this.Controls.Add(this.btnConf_booking);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.tXTSEAT);
            this.Controls.Add(this.cbSeatType);
            this.Controls.Add(this.dtpJourneyDate);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.cbTrain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtseats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1313, 913);
            this.MinimumSize = new System.Drawing.Size(1313, 883);
            this.Name = "BookingForm";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtseats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTrain;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.DateTimePicker dtpJourneyDate;
        private System.Windows.Forms.ComboBox cbSeatType;
        private System.Windows.Forms.TextBox tXTSEAT;
        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label cnic;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Button btnConf_booking;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatToBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn journayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cbdeatinatiom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbsourcee;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcni;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttName;
        private System.Windows.Forms.DataGridView dgBookingDetails;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnVeiw;
    }
}