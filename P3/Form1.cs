using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestUtil;

namespace P3
{
    public partial class Form1 : Form
    {
        //keep all of my objects globally
        About about;
        Resources resources;
        People people;
        Employment employment;
        Minors minors;
        Degrees degrees;
        Research research;


        //my restful interface
        REST rj = new REST("http://ist.rit.edu/api");
        REST googleRj = new REST("http://google.com/coolAPI");
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //go get about....
            string jsonAbout = rj.getJSON("/about/");
          
            //have to turn the string jsonAbout into an object
            //About object...
            about = JToken.Parse(jsonAbout).ToObject<About>();
            Console.WriteLine(about);
            aboutDescription.Text = about.description;
            quote.Text = about.quote;
            Author.Text = about.quoteAuthor;
            

            //get Resources
            string jsonResources = rj.getJSON("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resources>();
            Console.WriteLine(resources);

            // get degrees
            string jsonDegree = rj.getJSON("/degrees/");
            // Console.WriteLine(jsonDegree);
            degrees = JToken.Parse(jsonDegree).ToObject<Degrees>();

            //get Minors
            string jsonMinor = rj.getJSON("/minors/");
            minors = JToken.Parse(jsonMinor).ToObject<Minors>();

            //Research
            string jsonResearch = rj.getJSON("/research/");
            research = JToken.Parse(jsonResearch).ToObject<Research>();




            //throw the link into the linkLabel
            linkLabel1.Text = resources.coopEnrollment.RITJobZoneGuidelink;
            linkLabel2.Text = resources.studentAmbassadors.applicationFormLink;

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*  //hard coded to one linkLabel
            linkLabel1.LinkVisited = true;
            //go to the page in IE
            System.Diagnostics.Process.Start(linkLabel1.Text);
            */


            LinkLabel me = sender as LinkLabel;
            me.LinkVisited = true;
            Process.Start(me.Text);

        }

      

        private void ug_click(object sender, EventArgs e)
        {
  
            degreeForm expandDegree = new degreeForm();
            Label d = (Label)sender;
            if (d.Name == "webLabel")
            {
                expandDegree.minorTitle = degrees.undergraduate[0].title;
                expandDegree.minorCourses = degrees.undergraduate[0].concentrations;
                expandDegree.minorDescription = degrees.undergraduate[0].description;
            }
            else if (d.Name == "humanLabel")
            {
                expandDegree.minorTitle = degrees.undergraduate[1].title;
                expandDegree.minorCourses = degrees.undergraduate[1].concentrations;
                expandDegree.minorDescription = degrees.undergraduate[1].description;
            }
            else
            {
                expandDegree.minorTitle = degrees.undergraduate[2].title;
                expandDegree.minorCourses = degrees.undergraduate[2].concentrations;
                expandDegree.minorDescription = degrees.undergraduate[2].description;
            }
            expandDegree.Show();

        }


        private void grad_click(object sender, EventArgs e)
        {
            degreeForm expandDegree = new degreeForm();
            Label d = (Label)sender;
            if (d.Name == "infoLabel")
            {
                expandDegree.minorTitle = degrees.graduate[0].title;
                expandDegree.minorCourses = degrees.graduate[0].concentrations;
                expandDegree.minorDescription = degrees.graduate[0].description;
            }
            else if (d.Name == "computerLabel")
            {
                expandDegree.minorTitle = degrees.graduate[1].title;
                expandDegree.minorCourses = degrees.graduate[1].concentrations;
                expandDegree.minorDescription = degrees.graduate[1].description;
            }
            else
            {
                expandDegree.minorTitle = degrees.graduate[2].title;
                expandDegree.minorCourses = degrees.graduate[2].concentrations;
                expandDegree.minorDescription = degrees.graduate[2].description;
            }
            expandDegree.Show();
        }

        private void employ_click(object sender, EventArgs e)
        {
            //load the data
            string jsonEmploy = rj.getJSON("/employment/");
            //turn into object
            employment = JToken.Parse(jsonEmploy).ToObject<Employment>();

            //prepare the listView
            //set up how I want it to look...
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Width = 700;
            listView1.Height = 400;
            //assing the headers
            listView1.Columns.Add("Employers", 200);
            listView1.Columns.Add("Degree", 200);
            listView1.Columns.Add("City", 200);
            listView1.Columns.Add("Term", 100);

            //dump in data
            ListViewItem items;
            for (int i = 0; i < employment.coopTable.coopInformation.Count; i++)
            {
                items = new ListViewItem(new string[] {
                    employment.coopTable.coopInformation[i].employer,
                    employment.coopTable.coopInformation[i].degree,
                    employment.coopTable.coopInformation[i].city,
                    employment.coopTable.coopInformation[i].term
                });
                listView1.Items.Add(items);
            }

            //load the data
            string jsonEmploys = rj.getJSON("/employment/");
            //turn into object
            employment = JToken.Parse(jsonEmploys).ToObject<Employment>();

            //prepare the listView
            //set up how I want it to look...
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            listView2.Width = 700;
            listView2.Height = 400;
            //assing the headers
            listView2.Columns.Add("Degree", 200);
            listView2.Columns.Add("Employer", 200);
            listView2.Columns.Add("Location", 200);
            listView2.Columns.Add("Title", 100);
            listView2.Columns.Add("StartDate", 100);

            //dump in data
            ListViewItem ite;
            for (int i = 0; i < employment.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                ite = new ListViewItem(new String[] {
                    employment.employmentTable.professionalEmploymentInformation[i].degree,
                    employment.employmentTable.professionalEmploymentInformation[i].employer,
                    employment.employmentTable.professionalEmploymentInformation[i].city,
                    employment.employmentTable.professionalEmploymentInformation[i].title,
                    employment.employmentTable.professionalEmploymentInformation[i].startDate

                });
                listView2.Items.Add(ite);
            }
        }

        private void minor_click(object sender, EventArgs e)
        {
            degreeForm expandMinors = new degreeForm();
            Label k = (Label)sender;
            if (k.Name == "dataLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[0].title;
                expandMinors.minorCourses = minors.UgMinors[0].courses;
                expandMinors.minorNote = minors.UgMinors[0].note;
                expandMinors.minorDescription = minors.UgMinors[0].description;
            }
            else if (k.Name == "geoLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[1].title;
                expandMinors.minorCourses = minors.UgMinors[1].courses;
                expandMinors.minorNote = minors.UgMinors[1].note;
                expandMinors.minorDescription = minors.UgMinors[1].description;
            }
            else if (k.Name == "designLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[3].title;
                expandMinors.minorCourses = minors.UgMinors[3].courses;
                expandMinors.minorNote = minors.UgMinors[3].note;
                expandMinors.minorDescription = minors.UgMinors[3].description;
            }
            else if (k.Name == "devLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[4].title;
                expandMinors.minorCourses = minors.UgMinors[4].courses;
                expandMinors.minorNote = minors.UgMinors[4].note;
                expandMinors.minorDescription = minors.UgMinors[4].description;
            }
            else if (k.Name == "sysLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[5].title;
                expandMinors.minorCourses = minors.UgMinors[5].courses;
                expandMinors.minorNote = minors.UgMinors[5].note;
                expandMinors.minorDescription = minors.UgMinors[5].description;
            }
            else if (k.Name == "wddLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[6].title;
                expandMinors.minorCourses = minors.UgMinors[6].courses;
                expandMinors.minorNote = minors.UgMinors[6].note;
                expandMinors.minorDescription = minors.UgMinors[6].description;
            }
            else if (k.Name == "webdevLabel")
            {
                expandMinors.minorTitle = minors.UgMinors[7].title;
                expandMinors.minorCourses = minors.UgMinors[7].courses;
                expandMinors.minorNote = minors.UgMinors[7].note;
                expandMinors.minorDescription = minors.UgMinors[7].description;
            }
            
            expandMinors.Show();


        }

        private void research_click(object sender, EventArgs e)
        {
            researchForm express = new researchForm();
            Label pk = (Label)sender;


            if (pk.Name == "Analytics")
            {
                express.researchDomain = research.byInterestArea[4].areaName;
                express.researchCitations = research.byInterestArea[4].citations;
            }
            else if (pk.Name == "DataBase")
            {
                express.researchDomain = research.byInterestArea[3].areaName;
                express.researchCitations = research.byInterestArea[3].citations;
            }
            else if (pk.Name == "Education")
            {
                express.researchDomain = research.byInterestArea[1].areaName;
                express.researchCitations = research.byInterestArea[1].citations;
            }
            else if (pk.Name == "Geo")
            {
                express.researchDomain = research.byInterestArea[2].areaName;
                express.researchCitations = research.byInterestArea[2].citations;
            }
            else if (pk.Name == "HCI")
            {
                express.researchDomain = research.byInterestArea[0].areaName;
                express.researchCitations = research.byInterestArea[0].citations;
            }
            else if (pk.Name == "Health")
            {
                express.researchDomain = research.byInterestArea[8].areaName;
                express.researchCitations = research.byInterestArea[8].citations;
            }
            else if (pk.Name == "Mobile")
            {
                express.researchDomain = research.byInterestArea[7].areaName;
                express.researchCitations = research.byInterestArea[7].citations;
            }
            else if (pk.Name == "Networking")
            {
                express.researchDomain = research.byInterestArea[6].areaName;
                express.researchCitations = research.byInterestArea[6].citations;
            }
            else if (pk.Name == "Programming")
            {
                express.researchDomain = research.byInterestArea[9].areaName;
                express.researchCitations = research.byInterestArea[9].citations;
            }
            else if (pk.Name == "System")
            {
                express.researchDomain = research.byInterestArea[10].areaName;
                express.researchCitations = research.byInterestArea[10].citations;
            }
            else if (pk.Name == "Mobile")
            {
                express.researchDomain = research.byInterestArea[4].areaName;
                express.researchCitations = research.byInterestArea[4].citations;
            }
            else if (pk.Name == "Ubiquitous")
            {
                express.researchDomain = research.byInterestArea[11].areaName;
                express.researchCitations = research.byInterestArea[11].citations;
            }
            else if (pk.Name == "Web")
            {
                express.researchDomain = research.byInterestArea[5].areaName;
                express.researchCitations = research.byInterestArea[5].citations;
            }

            express.Show();

        }




        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void people_Click(object sender, EventArgs e)
        {
            string jsonPeople = rj.getJSON("/people/");
            //turn into object
            people = JToken.Parse(jsonPeople).ToObject<People>();
            faculty_1.Text = people.faculty[0].name;
            faculty_2.Text = people.faculty[1].name;
            faculty_3.Text = people.faculty[2].name;
            faculty_4.Text = people.faculty[3].name;
            faculty_5.Text = people.faculty[4].name;
            faculty_6.Text = people.faculty[5].name;
            faculty_7.Text = people.faculty[6].name;
            faculty_8.Text = people.faculty[7].name;
            faculty_9.Text = people.faculty[8].name;
            faculty_10.Text = people.faculty[9].name;
            faculty_11.Text = people.faculty[10].name;
            faculty_12.Text = people.faculty[11].name;
            faculty_13.Text = people.faculty[12].name;
            faculty_14.Text = people.faculty[13].name;
            faculty_15.Text = people.faculty[14].name;
            faculty_16.Text = people.faculty[15].name;
            faculty_17.Text = people.faculty[16].name;
            faculty_18.Text = people.faculty[17].name;
            faculty_19.Text = people.faculty[18].name;
            faculty_20.Text = people.faculty[19].name;
            faculty_21.Text = people.faculty[20].name;
            faculty_22.Text = people.faculty[21].name;
            faculty_23.Text = people.faculty[22].name;
            faculty_24.Text = people.faculty[23].name;
            faculty_25.Text = people.faculty[24].name;
            faculty_26.Text = people.faculty[25].name;
            faculty_27.Text = people.faculty[26].name;
            faculty_28.Text = people.faculty[27].name;
            faculty_29.Text = people.faculty[28].name;
            faculty_30.Text = people.faculty[29].name;
            faculty_31.Text = people.faculty[30].name;
            faculty_32.Text = people.faculty[31].name;
            faculty_33.Text = people.faculty[32].name;
            faculty_34.Text = people.faculty[33].name;
        }

        private void faculty_pop(object sender, EventArgs e)
        {
           facultyForm detail = new facultyForm();
            Label mb = (Label)sender;

            if(mb.Name == "faculty_1")
            {
                detail.facultyEmail = people.faculty[0].email;
                detail.facultyPicture = people.faculty[0].imagePath;
                detail.facultyName = people.faculty[0].name;
                detail.facultyPhone = people.faculty[0].phone;
                detail.facultyTitle = people.faculty[0].title;
            }
            else if (mb.Name == "faculty_2")
            {
                detail.facultyEmail = people.faculty[1].email;
                detail.facultyPicture = people.faculty[1].imagePath;
                detail.facultyName = people.faculty[1].name;
                detail.facultyPhone = people.faculty[1].phone;
                detail.facultyTitle = people.faculty[1].title;
            }
            else if (mb.Name == "faculty_3")
            {
                detail.facultyEmail = people.faculty[2].email;
                detail.facultyPicture = people.faculty[2].imagePath;
                detail.facultyName = people.faculty[2].name;
                detail.facultyPhone = people.faculty[2].phone;
                detail.facultyTitle = people.faculty[2].title;
            }
            else if (mb.Name == "faculty_4")
            {
                detail.facultyEmail = people.faculty[3].email;
                detail.facultyPicture = people.faculty[3].imagePath;
                detail.facultyName = people.faculty[3].name;
                detail.facultyPhone = people.faculty[3].phone;
                detail.facultyTitle = people.faculty[3].title;
            }
            else if (mb.Name == "faculty_5")
            {
                detail.facultyEmail = people.faculty[4].email;
                detail.facultyPicture = people.faculty[4].imagePath;
                detail.facultyName = people.faculty[4].name;
                detail.facultyPhone = people.faculty[4].phone;
                detail.facultyTitle = people.faculty[4].title;
            }
            else if (mb.Name == "faculty_6")
            {
                detail.facultyEmail = people.faculty[5].email;
                detail.facultyPicture = people.faculty[5].imagePath;
                detail.facultyName = people.faculty[5].name;
                detail.facultyPhone = people.faculty[5].phone;
                detail.facultyTitle = people.faculty[5].title;
            }
            else if (mb.Name == "faculty_7")
            {
                detail.facultyEmail = people.faculty[6].email;
                detail.facultyPicture = people.faculty[6].imagePath;
                detail.facultyName = people.faculty[6].name;
                detail.facultyPhone = people.faculty[6].phone;
                detail.facultyTitle = people.faculty[6].title;
            }
            else if (mb.Name == "faculty_8")
            {
                detail.facultyEmail = people.faculty[7].email;
                detail.facultyPicture = people.faculty[7].imagePath;
                detail.facultyName = people.faculty[7].name;
                detail.facultyPhone = people.faculty[7].phone;
                detail.facultyTitle = people.faculty[7].title;
            }
            else if (mb.Name == "faculty_9")
            {
                detail.facultyEmail = people.faculty[8].email;
                detail.facultyPicture = people.faculty[8].imagePath;
                detail.facultyName = people.faculty[8].name;
                detail.facultyPhone = people.faculty[8].phone;
                detail.facultyTitle = people.faculty[8].title;
            }
            else if (mb.Name == "faculty_10")
            {
                detail.facultyEmail = people.faculty[9].email;
                detail.facultyPicture = people.faculty[9].imagePath;
                detail.facultyName = people.faculty[9].name;
                detail.facultyPhone = people.faculty[9].phone;
                detail.facultyTitle = people.faculty[9].title;
            }
            else if (mb.Name == "faculty_11")
            {
                detail.facultyEmail = people.faculty[10].email;
                detail.facultyPicture = people.faculty[10].imagePath;
                detail.facultyName = people.faculty[10].name;
                detail.facultyPhone = people.faculty[10].phone;
                detail.facultyTitle = people.faculty[10].title;
            }
            else if (mb.Name == "faculty_12")
            {
                detail.facultyEmail = people.faculty[11].email;
                detail.facultyPicture = people.faculty[11].imagePath;
                detail.facultyName = people.faculty[11].name;
                detail.facultyPhone = people.faculty[11].phone;
                detail.facultyTitle = people.faculty[11].title;
            }
            else if (mb.Name == "faculty_13")
            {
                detail.facultyEmail = people.faculty[12].email;
                detail.facultyPicture = people.faculty[12].imagePath;
                detail.facultyName = people.faculty[12].name;
                detail.facultyPhone = people.faculty[12].phone;
                detail.facultyTitle = people.faculty[12].title;
            }
            else if (mb.Name == "faculty_14")
            {
                detail.facultyEmail = people.faculty[13].email;
                detail.facultyPicture = people.faculty[13].imagePath;
                detail.facultyName = people.faculty[13].name;
                detail.facultyPhone = people.faculty[13].phone;
                detail.facultyTitle = people.faculty[13].title;
            }
            else if (mb.Name == "faculty_15")
            {
                detail.facultyEmail = people.faculty[14].email;
                detail.facultyPicture = people.faculty[14].imagePath;
                detail.facultyName = people.faculty[14].name;
                detail.facultyPhone = people.faculty[14].phone;
                detail.facultyTitle = people.faculty[14].title;
            }
            else if (mb.Name == "faculty_16")
            {
                detail.facultyEmail = people.faculty[15].email;
                detail.facultyPicture = people.faculty[15].imagePath;
                detail.facultyName = people.faculty[15].name;
                detail.facultyPhone = people.faculty[15].phone;
                detail.facultyTitle = people.faculty[15].title;
            }
            else if (mb.Name == "faculty_17")
            {
                detail.facultyEmail = people.faculty[16].email;
                detail.facultyPicture = people.faculty[16].imagePath;
                detail.facultyName = people.faculty[16].name;
                detail.facultyPhone = people.faculty[16].phone;
                detail.facultyTitle = people.faculty[16].title;
            }
            else if (mb.Name == "faculty_18")
            {
                detail.facultyEmail = people.faculty[17].email;
                detail.facultyPicture = people.faculty[17].imagePath;
                detail.facultyName = people.faculty[17].name;
                detail.facultyPhone = people.faculty[17].phone;
                detail.facultyTitle = people.faculty[17].title;
            }
            else if (mb.Name == "faculty_19")
            {
                detail.facultyEmail = people.faculty[18].email;
                detail.facultyPicture = people.faculty[18].imagePath;
                detail.facultyName = people.faculty[18].name;
                detail.facultyPhone = people.faculty[18].phone;
                detail.facultyTitle = people.faculty[18].title;
            }
            else if (mb.Name == "faculty_20")
            {
                detail.facultyEmail = people.faculty[19].email;
                detail.facultyPicture = people.faculty[19].imagePath;
                detail.facultyName = people.faculty[19].name;
                detail.facultyPhone = people.faculty[19].phone;
                detail.facultyTitle = people.faculty[19].title;
            }
            else if (mb.Name == "faculty_21")
            {
                detail.facultyEmail = people.faculty[20].email;
                detail.facultyPicture = people.faculty[20].imagePath;
                detail.facultyName = people.faculty[20].name;
                detail.facultyPhone = people.faculty[20].phone;
                detail.facultyTitle = people.faculty[20].title;
            }
            else if (mb.Name == "faculty_22")
            {
                detail.facultyEmail = people.faculty[21].email;
                detail.facultyPicture = people.faculty[21].imagePath;
                detail.facultyName = people.faculty[21].name;
                detail.facultyPhone = people.faculty[21].phone;
                detail.facultyTitle = people.faculty[21].title;
            }
            else if (mb.Name == "faculty_23")
            {
                detail.facultyEmail = people.faculty[22].email;
                detail.facultyPicture = people.faculty[22].imagePath;
                detail.facultyName = people.faculty[22].name;
                detail.facultyPhone = people.faculty[22].phone;
                detail.facultyTitle = people.faculty[22].title;
            }
            else if (mb.Name == "faculty_24")
            {
                detail.facultyEmail = people.faculty[23].email;
                detail.facultyPicture = people.faculty[23].imagePath;
                detail.facultyName = people.faculty[23].name;
                detail.facultyPhone = people.faculty[23].phone;
                detail.facultyTitle = people.faculty[23].title;
            }
            else if (mb.Name == "faculty_25")
            {
                detail.facultyEmail = people.faculty[24].email;
                detail.facultyPicture = people.faculty[24].imagePath;
                detail.facultyName = people.faculty[24].name;
                detail.facultyPhone = people.faculty[24].phone;
                detail.facultyTitle = people.faculty[24].title;
            }
            else if (mb.Name == "faculty_26")
            {
                detail.facultyEmail = people.faculty[25].email;
                detail.facultyPicture = people.faculty[25].imagePath;
                detail.facultyName = people.faculty[25].name;
                detail.facultyPhone = people.faculty[25].phone;
                detail.facultyTitle = people.faculty[25].title;
            }
            else if (mb.Name == "faculty_27")
            {
                detail.facultyEmail = people.faculty[26].email;
                detail.facultyPicture = people.faculty[26].imagePath;
                detail.facultyName = people.faculty[26].name;
                detail.facultyPhone = people.faculty[26].phone;
                detail.facultyTitle = people.faculty[26].title;
            }
            else if (mb.Name == "faculty_28")
            {
                detail.facultyEmail = people.faculty[27].email;
                detail.facultyPicture = people.faculty[27].imagePath;
                detail.facultyName = people.faculty[27].name;
                detail.facultyPhone = people.faculty[27].phone;
                detail.facultyTitle = people.faculty[27].title;
            }
            else if (mb.Name == "faculty_29")
            {
                detail.facultyEmail = people.faculty[28].email;
                detail.facultyPicture = people.faculty[28].imagePath;
                detail.facultyName = people.faculty[28].name;
                detail.facultyPhone = people.faculty[28].phone;
                detail.facultyTitle = people.faculty[28].title;
            }
            else if (mb.Name == "faculty_30")
            {
                detail.facultyEmail = people.faculty[29].email;
                detail.facultyPicture = people.faculty[29].imagePath;
                detail.facultyName = people.faculty[29].name;
                detail.facultyPhone = people.faculty[29].phone;
                detail.facultyTitle = people.faculty[29].title;
            }
            else if (mb.Name == "faculty_31")
            {
                detail.facultyEmail = people.faculty[30].email;
                detail.facultyPicture = people.faculty[30].imagePath;
                detail.facultyName = people.faculty[30].name;
                detail.facultyPhone = people.faculty[30].phone;
                detail.facultyTitle = people.faculty[30].title;
            }
            else if (mb.Name == "faculty_32")
            {
                detail.facultyEmail = people.faculty[31].email;
                detail.facultyPicture = people.faculty[31].imagePath;
                detail.facultyName = people.faculty[31].name;
                detail.facultyPhone = people.faculty[31].phone;
                detail.facultyTitle = people.faculty[31].title;
            }
            else if (mb.Name == "faculty_33")
            {
                detail.facultyEmail = people.faculty[32].email;
                detail.facultyPicture = people.faculty[32].imagePath;
                detail.facultyName = people.faculty[32].name;
                detail.facultyPhone = people.faculty[32].phone;
                detail.facultyTitle = people.faculty[32].title;
            }
            else
            {
                detail.facultyEmail = people.faculty[33].email;
                detail.facultyPicture = people.faculty[33].imagePath;
                detail.facultyName = people.faculty[33].name;
                detail.facultyPhone = people.faculty[33].phone;
                detail.facultyTitle = people.faculty[33].title;
            }
            ;
            
            
            detail.Show();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void abroad_click(object sender, EventArgs e)
        {

        }

        private void ambassador_click(object sender, EventArgs e)
        {

        }

        private void forms_click(object sender, EventArgs e)
        {

        }

        private void tutor_click(object sender, EventArgs e)
        {

        }

        private void coop_click(object sender, EventArgs e)
        {

        }

        private void advising_click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
