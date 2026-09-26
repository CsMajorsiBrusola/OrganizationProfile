using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public long StudentNumber(string studNum)
        {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListofProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < ListofProgram.Length; i++)
            {
                cbPrograms.Items.Add(ListofProgram[i].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, StudentInformationClass studentInformationClass)
        {
            int StudentNo = Convert.ToInt32(txtStudentNo.Text);
            int ContactNo = Convert.ToInt32(txtContactNo.Text);
            int Age = Convert.ToInt32(txtAge.Text);
            
            string Program = cbPrograms.Text;
            string Gender = cbGender.Text;
            string Birthday = DPBirthday.Text;
            string Fname = txtFirstName.Text;
            string Lname = txtLastName.Text;

            studentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            studentInformationClass.SetStudentNo = StudentNo;
            studentInformationClass.SetProgram = Program;
            studentInformationClass.SetGender = Gender;
            studentInformationClass.SetContactNo = ContactNo;
            studentInformationClass.SetAge = Age;
            studentInformationClass.SetBirthday = Birthday;

            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }
    }
}
