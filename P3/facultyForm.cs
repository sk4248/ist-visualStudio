using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class facultyForm : Form
    {
        public facultyForm()
        {
            InitializeComponent();
        }

        public string facultyPicture;
        public string facultyName;
        public string facultyTitle;
        public string facultyPhone;
        public string facultyEmail;

        private void facultyForm_Load(object sender, EventArgs e)
        {
            faculty_pic.ImageLocation = facultyPicture;
            faculty_Name.Text = facultyName;
            faculty_title.Text = facultyTitle;
            faculty_phone.Text = facultyPhone;
            faculty_email.Text = facultyEmail;
        }

    }
}
