namespace Client
{
    partial class Client_Form
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.dgvBorHistory = new System.Windows.Forms.DataGridView();
            this.dgvBorrowedTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(144, 34);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(241, 34);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNameBook);
            this.groupBox1.Controls.Add(this.dgvBorHistory);
            this.groupBox1.Controls.Add(this.dgvBorrowedTable);
            this.groupBox1.Controls.Add(this.btnReturnBook);
            this.groupBox1.Controls.Add(this.btnBorrow);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 483);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BorrowBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List Of Library";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Borrowed books Table";
            // 
            // tbNameBook
            // 
            this.tbNameBook.Location = new System.Drawing.Point(21, 37);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(100, 20);
            this.tbNameBook.TabIndex = 2;
            // 
            // dgvBorHistory
            // 
            this.dgvBorHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorHistory.Location = new System.Drawing.Point(6, 315);
            this.dgvBorHistory.Name = "dgvBorHistory";
            this.dgvBorHistory.Size = new System.Drawing.Size(401, 149);
            this.dgvBorHistory.TabIndex = 9;
            // 
            // dgvBorrowedTable
            // 
            this.dgvBorrowedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedTable.Location = new System.Drawing.Point(6, 105);
            this.dgvBorrowedTable.Name = "dgvBorrowedTable";
            this.dgvBorrowedTable.Size = new System.Drawing.Size(401, 145);
            this.dgvBorrowedTable.TabIndex = 7;
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 516);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client_Form";
            this.Text = "ClientForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.DataGridView dgvBorHistory;
        private System.Windows.Forms.DataGridView dgvBorrowedTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

