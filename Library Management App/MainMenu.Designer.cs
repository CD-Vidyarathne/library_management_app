namespace Library_Management_App
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_main_reg_user = new System.Windows.Forms.Button();
            this.btn_main_reg_book = new System.Windows.Forms.Button();
            this.btn_main_loan = new System.Windows.Forms.Button();
            this.btn_main_return = new System.Windows.Forms.Button();
            this.btn_main_get_inquiry = new System.Windows.Forms.Button();
            this.btn_main_make_reservation = new System.Windows.Forms.Button();
            this.btn_main_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_main_get_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_main_reg_user
            // 
            this.btn_main_reg_user.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_main_reg_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_reg_user.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_reg_user.Location = new System.Drawing.Point(24, 113);
            this.btn_main_reg_user.Name = "btn_main_reg_user";
            this.btn_main_reg_user.Size = new System.Drawing.Size(218, 63);
            this.btn_main_reg_user.TabIndex = 28;
            this.btn_main_reg_user.Text = "Register User";
            this.btn_main_reg_user.UseVisualStyleBackColor = false;
            this.btn_main_reg_user.Click += new System.EventHandler(this.btn_main_reg_user_Click);
            // 
            // btn_main_reg_book
            // 
            this.btn_main_reg_book.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_main_reg_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_reg_book.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_reg_book.Location = new System.Drawing.Point(356, 113);
            this.btn_main_reg_book.Name = "btn_main_reg_book";
            this.btn_main_reg_book.Size = new System.Drawing.Size(218, 63);
            this.btn_main_reg_book.TabIndex = 29;
            this.btn_main_reg_book.Text = "Register Book";
            this.btn_main_reg_book.UseVisualStyleBackColor = false;
            this.btn_main_reg_book.Click += new System.EventHandler(this.btn_main_reg_book_Click);
            // 
            // btn_main_loan
            // 
            this.btn_main_loan.BackColor = System.Drawing.Color.Gold;
            this.btn_main_loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_loan.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_loan.Location = new System.Drawing.Point(24, 196);
            this.btn_main_loan.Name = "btn_main_loan";
            this.btn_main_loan.Size = new System.Drawing.Size(218, 63);
            this.btn_main_loan.TabIndex = 30;
            this.btn_main_loan.Text = "Loan a Book";
            this.btn_main_loan.UseVisualStyleBackColor = false;
            this.btn_main_loan.Click += new System.EventHandler(this.btn_main_loan_Click);
            // 
            // btn_main_return
            // 
            this.btn_main_return.BackColor = System.Drawing.Color.Gold;
            this.btn_main_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_return.Location = new System.Drawing.Point(356, 199);
            this.btn_main_return.Name = "btn_main_return";
            this.btn_main_return.Size = new System.Drawing.Size(218, 63);
            this.btn_main_return.TabIndex = 31;
            this.btn_main_return.Text = "Return a Book";
            this.btn_main_return.UseVisualStyleBackColor = false;
            this.btn_main_return.Click += new System.EventHandler(this.btn_main_return_Click);
            // 
            // btn_main_get_inquiry
            // 
            this.btn_main_get_inquiry.BackColor = System.Drawing.Color.Thistle;
            this.btn_main_get_inquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_get_inquiry.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_get_inquiry.Location = new System.Drawing.Point(24, 281);
            this.btn_main_get_inquiry.Name = "btn_main_get_inquiry";
            this.btn_main_get_inquiry.Size = new System.Drawing.Size(218, 63);
            this.btn_main_get_inquiry.TabIndex = 32;
            this.btn_main_get_inquiry.Text = "Get Inquiry";
            this.btn_main_get_inquiry.UseVisualStyleBackColor = false;
            this.btn_main_get_inquiry.Click += new System.EventHandler(this.btn_main_get_inquiry_Click);
            // 
            // btn_main_make_reservation
            // 
            this.btn_main_make_reservation.BackColor = System.Drawing.Color.Thistle;
            this.btn_main_make_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_make_reservation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_make_reservation.Location = new System.Drawing.Point(356, 279);
            this.btn_main_make_reservation.Name = "btn_main_make_reservation";
            this.btn_main_make_reservation.Size = new System.Drawing.Size(218, 63);
            this.btn_main_make_reservation.TabIndex = 33;
            this.btn_main_make_reservation.Text = "Make Reservation";
            this.btn_main_make_reservation.UseVisualStyleBackColor = false;
            this.btn_main_make_reservation.Click += new System.EventHandler(this.btn_main_make_reservation_Click);
            // 
            // btn_main_exit
            // 
            this.btn_main_exit.BackColor = System.Drawing.Color.Brown;
            this.btn_main_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_exit.Location = new System.Drawing.Point(356, 375);
            this.btn_main_exit.Name = "btn_main_exit";
            this.btn_main_exit.Size = new System.Drawing.Size(218, 63);
            this.btn_main_exit.TabIndex = 34;
            this.btn_main_exit.Text = "Exit";
            this.btn_main_exit.UseVisualStyleBackColor = false;
            this.btn_main_exit.Click += new System.EventHandler(this.btn_main_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Library Management App v2.0";
            // 
            // btn_main_get_details
            // 
            this.btn_main_get_details.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_main_get_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main_get_details.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_get_details.Location = new System.Drawing.Point(24, 375);
            this.btn_main_get_details.Name = "btn_main_get_details";
            this.btn_main_get_details.Size = new System.Drawing.Size(218, 63);
            this.btn_main_get_details.TabIndex = 36;
            this.btn_main_get_details.Text = "Get Details";
            this.btn_main_get_details.UseVisualStyleBackColor = false;
            this.btn_main_get_details.Click += new System.EventHandler(this.btn_main_get_details_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.btn_main_get_details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_main_exit);
            this.Controls.Add(this.btn_main_make_reservation);
            this.Controls.Add(this.btn_main_get_inquiry);
            this.Controls.Add(this.btn_main_return);
            this.Controls.Add(this.btn_main_loan);
            this.Controls.Add(this.btn_main_reg_book);
            this.Controls.Add(this.btn_main_reg_user);
            this.Name = "MainMenu";
            this.Text = "Library Mangement App v2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_main_reg_user;
        private System.Windows.Forms.Button btn_main_reg_book;
        private System.Windows.Forms.Button btn_main_loan;
        private System.Windows.Forms.Button btn_main_return;
        private System.Windows.Forms.Button btn_main_get_inquiry;
        private System.Windows.Forms.Button btn_main_make_reservation;
        private System.Windows.Forms.Button btn_main_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_main_get_details;
    }
}