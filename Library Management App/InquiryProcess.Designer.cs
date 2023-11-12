namespace Library_Management_App
{
    partial class InquiryProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_book_class = new System.Windows.Forms.TextBox();
            this.txt_book_identifier = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_get_inquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Get a Inquiry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Classification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book Identifier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = ": ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = ": ";
            // 
            // txt_book_class
            // 
            this.txt_book_class.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book_class.Location = new System.Drawing.Point(213, 117);
            this.txt_book_class.MaxLength = 1;
            this.txt_book_class.Name = "txt_book_class";
            this.txt_book_class.Size = new System.Drawing.Size(160, 26);
            this.txt_book_class.TabIndex = 13;
            // 
            // txt_book_identifier
            // 
            this.txt_book_identifier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book_identifier.Location = new System.Drawing.Point(213, 169);
            this.txt_book_identifier.MaxLength = 4;
            this.txt_book_identifier.Name = "txt_book_identifier";
            this.txt_book_identifier.Size = new System.Drawing.Size(160, 26);
            this.txt_book_identifier.TabIndex = 14;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(34, 356);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(218, 63);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(31, 256);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(15, 19);
            this.lbl_result.TabIndex = 30;
            this.lbl_result.Text = "*";
            // 
            // btn_get_inquiry
            // 
            this.btn_get_inquiry.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_get_inquiry.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_inquiry.Location = new System.Drawing.Point(345, 356);
            this.btn_get_inquiry.Name = "btn_get_inquiry";
            this.btn_get_inquiry.Size = new System.Drawing.Size(218, 63);
            this.btn_get_inquiry.TabIndex = 31;
            this.btn_get_inquiry.Text = "Get Inquiry";
            this.btn_get_inquiry.UseVisualStyleBackColor = false;
            this.btn_get_inquiry.Click += new System.EventHandler(this.btn_get_inquiry_Click);
            // 
            // InquiryProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.btn_get_inquiry);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_book_identifier);
            this.Controls.Add(this.txt_book_class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InquiryProcess";
            this.Text = "InquiryProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_book_class;
        private System.Windows.Forms.TextBox txt_book_identifier;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_get_inquiry;
    }
}