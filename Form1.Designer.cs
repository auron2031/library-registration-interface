namespace FinalExam
{
    partial class Form1
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
            this.cbxCustomerName = new System.Windows.Forms.ComboBox();
            this.cbxBookTitle = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCustomerName
            // 
            this.cbxCustomerName.FormattingEnabled = true;
            this.cbxCustomerName.Location = new System.Drawing.Point(30, 38);
            this.cbxCustomerName.Name = "cbxCustomerName";
            this.cbxCustomerName.Size = new System.Drawing.Size(166, 21);
            this.cbxCustomerName.TabIndex = 0;
            // 
            // cbxBookTitle
            // 
            this.cbxBookTitle.FormattingEnabled = true;
            this.cbxBookTitle.Location = new System.Drawing.Point(30, 97);
            this.cbxBookTitle.Name = "cbxBookTitle";
            this.cbxBookTitle.Size = new System.Drawing.Size(166, 21);
            this.cbxBookTitle.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(251, 27);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(131, 66);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(251, 127);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(131, 71);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(251, 232);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 85);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register Book";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(27, 163);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.Location = new System.Drawing.Point(39, 233);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(144, 84);
            this.btnCancelReg.TabIndex = 7;
            this.btnCancelReg.Text = "Cancel Register";
            this.btnCancelReg.UseVisualStyleBackColor = true;
            this.btnCancelReg.Click += new System.EventHandler(this.btnCancelReg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 341);
            this.Controls.Add(this.btnCancelReg);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cbxBookTitle);
            this.Controls.Add(this.cbxCustomerName);
            this.Name = "Form1";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCustomerName;
        private System.Windows.Forms.ComboBox cbxBookTitle;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCancelReg;
    }
}

