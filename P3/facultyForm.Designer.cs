namespace P3
{
    partial class facultyForm
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
            this.faculty_pic = new System.Windows.Forms.PictureBox();
            this.faculty_Name = new System.Windows.Forms.Label();
            this.faculty_phone = new System.Windows.Forms.Label();
            this.faculty_email = new System.Windows.Forms.Label();
            this.faculty_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.faculty_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // faculty_pic
            // 
            this.faculty_pic.Location = new System.Drawing.Point(82, 53);
            this.faculty_pic.Name = "faculty_pic";
            this.faculty_pic.Size = new System.Drawing.Size(167, 191);
            this.faculty_pic.TabIndex = 0;
            this.faculty_pic.TabStop = false;
            // 
            // faculty_Name
            // 
            this.faculty_Name.BackColor = System.Drawing.Color.Silver;
            this.faculty_Name.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_Name.ForeColor = System.Drawing.Color.Maroon;
            this.faculty_Name.Location = new System.Drawing.Point(79, 269);
            this.faculty_Name.Name = "faculty_Name";
            this.faculty_Name.Size = new System.Drawing.Size(183, 47);
            this.faculty_Name.TabIndex = 1;
            this.faculty_Name.Text = "label1";
            this.faculty_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faculty_phone
            // 
            this.faculty_phone.AutoSize = true;
            this.faculty_phone.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_phone.Location = new System.Drawing.Point(416, 81);
            this.faculty_phone.Name = "faculty_phone";
            this.faculty_phone.Size = new System.Drawing.Size(70, 20);
            this.faculty_phone.TabIndex = 2;
            this.faculty_phone.Text = "PHONE:";
            // 
            // faculty_email
            // 
            this.faculty_email.AutoSize = true;
            this.faculty_email.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_email.Location = new System.Drawing.Point(416, 134);
            this.faculty_email.Name = "faculty_email";
            this.faculty_email.Size = new System.Drawing.Size(64, 20);
            this.faculty_email.TabIndex = 3;
            this.faculty_email.Text = "EMAIL:";
            // 
            // faculty_title
            // 
            this.faculty_title.BackColor = System.Drawing.Color.DimGray;
            this.faculty_title.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_title.ForeColor = System.Drawing.Color.LightCoral;
            this.faculty_title.Location = new System.Drawing.Point(79, 336);
            this.faculty_title.Name = "faculty_title";
            this.faculty_title.Size = new System.Drawing.Size(183, 43);
            this.faculty_title.TabIndex = 4;
            this.faculty_title.Text = "label4";
            this.faculty_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // facultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(710, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faculty_title);
            this.Controls.Add(this.faculty_email);
            this.Controls.Add(this.faculty_phone);
            this.Controls.Add(this.faculty_Name);
            this.Controls.Add(this.faculty_pic);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "facultyForm";
            this.Text = "facultyForm";
            this.Load += new System.EventHandler(this.facultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faculty_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox faculty_pic;
        private System.Windows.Forms.Label faculty_Name;
        private System.Windows.Forms.Label faculty_phone;
        private System.Windows.Forms.Label faculty_email;
        private System.Windows.Forms.Label faculty_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}