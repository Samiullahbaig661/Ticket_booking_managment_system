namespace userforms
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.Loginlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loginlbl
            // 
            this.Loginlbl.AutoSize = true;
            this.Loginlbl.BackColor = System.Drawing.Color.Transparent;
            this.Loginlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlbl.ForeColor = System.Drawing.Color.White;
            this.Loginlbl.Location = new System.Drawing.Point(48, 246);
            this.Loginlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(145, 50);
            this.Loginlbl.TabIndex = 15;
            this.Loginlbl.Text = "Already have \r\nan account?";
            this.Loginlbl.Click += new System.EventHandler(this.Loginlbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.Black;
            this.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.Location = new System.Drawing.Point(223, 230);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(4);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(165, 53);
            this.signupbtn.TabIndex = 13;
            this.signupbtn.Text = "SIGN UP";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 35);
            this.label3.TabIndex = 29;
            this.label3.Text = "SIGN UP";
            // 
            // PassTBox
            // 
            this.PassTBox.BackColor = System.Drawing.Color.White;
            this.PassTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTBox.ForeColor = System.Drawing.Color.Black;
            this.PassTBox.Location = new System.Drawing.Point(235, 164);
            this.PassTBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.Size = new System.Drawing.Size(191, 30);
            this.PassTBox.TabIndex = 11;
            // 
            // UserTBox
            // 
            this.UserTBox.BackColor = System.Drawing.Color.White;
            this.UserTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTBox.ForeColor = System.Drawing.Color.Black;
            this.UserTBox.Location = new System.Drawing.Point(235, 109);
            this.UserTBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.Size = new System.Drawing.Size(191, 30);
            this.UserTBox.TabIndex = 10;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.White;
            this.passwordlbl.Location = new System.Drawing.Point(97, 164);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(106, 25);
            this.passwordlbl.TabIndex = 26;
            this.passwordlbl.Text = "Password";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.Transparent;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.White;
            this.userlbl.Location = new System.Drawing.Point(97, 109);
            this.userlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(110, 25);
            this.userlbl.TabIndex = 25;
            this.userlbl.Text = "Username";
            // 
            // SignupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(613, 359);
            this.Controls.Add(this.Loginlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.userlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 410);
            this.MinimumSize = new System.Drawing.Size(635, 400);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loginlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTBox;
        private System.Windows.Forms.TextBox UserTBox;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label userlbl;
    }
}

