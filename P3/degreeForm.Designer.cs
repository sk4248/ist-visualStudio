namespace P3
{
    partial class degreeForm
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
            this.minor_title = new System.Windows.Forms.Label();
            this.minor_desc = new System.Windows.Forms.Label();
            this.minor_courses = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.TextBox();
            this.courses_box = new System.Windows.Forms.TextBox();
            this.minorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minor_title
            // 
            this.minor_title.AutoSize = true;
            this.minor_title.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_title.Location = new System.Drawing.Point(353, 26);
            this.minor_title.Name = "minor_title";
            this.minor_title.Size = new System.Drawing.Size(59, 21);
            this.minor_title.TabIndex = 0;
            this.minor_title.Text = "Name";
            // 
            // minor_desc
            // 
            this.minor_desc.AutoSize = true;
            this.minor_desc.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_desc.Location = new System.Drawing.Point(49, 117);
            this.minor_desc.Name = "minor_desc";
            this.minor_desc.Size = new System.Drawing.Size(96, 17);
            this.minor_desc.TabIndex = 1;
            this.minor_desc.Text = "Description";
            // 
            // minor_courses
            // 
            this.minor_courses.AutoSize = true;
            this.minor_courses.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_courses.Location = new System.Drawing.Point(49, 364);
            this.minor_courses.Name = "minor_courses";
            this.minor_courses.Size = new System.Drawing.Size(86, 24);
            this.minor_courses.TabIndex = 2;
            this.minor_courses.Text = "Courses";
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(207, 62);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(576, 159);
            this.description_box.TabIndex = 3;
            // 
            // courses_box
            // 
            this.courses_box.Location = new System.Drawing.Point(237, 315);
            this.courses_box.Multiline = true;
            this.courses_box.Name = "courses_box";
            this.courses_box.Size = new System.Drawing.Size(379, 124);
            this.courses_box.TabIndex = 4;
            // 
            // minorLabel
            // 
            this.minorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minorLabel.Location = new System.Drawing.Point(141, 473);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(408, 133);
            this.minorLabel.TabIndex = 5;
            this.minorLabel.Text = "label1";
            // 
            // degreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(854, 615);
            this.Controls.Add(this.minorLabel);
            this.Controls.Add(this.courses_box);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.minor_courses);
            this.Controls.Add(this.minor_desc);
            this.Controls.Add(this.minor_title);
            this.Name = "degreeForm";
            this.Text = "degreeForm";
            this.Load += new System.EventHandler(this.degreeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minor_title;
        private System.Windows.Forms.Label minor_desc;
        private System.Windows.Forms.Label minor_courses;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.TextBox courses_box;
        private System.Windows.Forms.Label minorLabel;
    }
}