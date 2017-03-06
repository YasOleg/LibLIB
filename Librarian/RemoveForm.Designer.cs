namespace Librarian
{
    partial class RemoveForm
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
            this.tbIDbook = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbAuthore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnREmove = new System.Windows.Forms.Button();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIDbook
            // 
            this.tbIDbook.Location = new System.Drawing.Point(185, 67);
            this.tbIDbook.Name = "tbIDbook";
            this.tbIDbook.Size = new System.Drawing.Size(47, 20);
            this.tbIDbook.TabIndex = 0;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(185, 94);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(100, 20);
            this.tbBookName.TabIndex = 1;
            // 
            // tbAuthore
            // 
            this.tbAuthore.Location = new System.Drawing.Point(185, 120);
            this.tbAuthore.Name = "tbAuthore";
            this.tbAuthore.Size = new System.Drawing.Size(100, 20);
            this.tbAuthore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Books Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Authore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remove Book";
            // 
            // btnREmove
            // 
            this.btnREmove.Location = new System.Drawing.Point(175, 202);
            this.btnREmove.Name = "btnREmove";
            this.btnREmove.Size = new System.Drawing.Size(75, 23);
            this.btnREmove.TabIndex = 7;
            this.btnREmove.Text = "Remove";
            this.btnREmove.UseVisualStyleBackColor = true;
            this.btnREmove.Click += new System.EventHandler(this.btnREmove_Click);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(83, 148);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(84, 13);
            this.lbAdmin.TabIndex = 8;
            this.lbAdmin.Text = "Admin password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(185, 147);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 237);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.btnREmove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAuthore);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.tbIDbook);
            this.Name = "RemoveForm";
            this.Text = "RemoveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDbook;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbAuthore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnREmove;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.TextBox tbPassword;
    }
}