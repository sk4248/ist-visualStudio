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
    public partial class researchForm : Form
    {
        public researchForm()
        {
            InitializeComponent();
        }

        public string researchTitle;
        public string researchDomain;
        public List<string> researchCitations;

        private void researchForm_Load(object sender, EventArgs e)
        {
            
            label_research_title.Text = researchDomain;

            foreach (string s in researchCitations)
            {
                label_citations.AppendText("--> ");
                label_citations.AppendText(s);
                label_citations.AppendText("\n");
                label_citations.AppendText("\n");

            }
        }

      
    }
}
