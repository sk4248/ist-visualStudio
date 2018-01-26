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
    public partial class degreeForm : Form
    {
        public degreeForm()
        {
            InitializeComponent();
        }
        public string minorTitle;
        public string minorDescription;
        public string minorNote;
        public List<string> minorCourses;

        private void degreeForm_Load(object sender, EventArgs e)
        {
            minor_title.Text = minorTitle;
            description_box.Text = minorDescription;
            minorLabel.Text = minorNote;
            foreach (string s in minorCourses)
            {
                courses_box.AppendText(s);
                courses_box.AppendText("\n");
            }
        }
    }
}
