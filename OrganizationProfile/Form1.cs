using System.Net;
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
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial + ".";
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

            string[] Gender = new string[]
            {
                    "Male",
                    "Female",
                    "Prefer not to say"
            };

            for (int i = 0; i < Gender.Length; i++)
            {
                cbGender.Items.Add(Gender[i].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                StudentInformationClass.SetStudentNo = Convert.ToInt32(txtStudentNo.Text);
                StudentInformationClass.SetAge = Convert.ToInt32(txtAge.Text);

                StudentInformationClass.SetContactNo = txtContactNo.Text;
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetBirthday = DPBirthday.Text;
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);

                if (string.IsNullOrWhiteSpace(cbPrograms.Text) || string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    throw new ArgumentNullException("Please select both Program and Gender.");
                }

                frmConfirmation frm = new frmConfirmation();

                using (frm = new frmConfirmation())
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ClearFormFields();
                    }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format Error: {ex.Message}", "Invalid Input Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Missing Field: {ex.ParamName ?? ex.Message}", "Null Argument", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Value Limit Exceeded: {ex.Message}", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show($"Out of Range: {ex.Message}", "Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

            }
        }

        public class StudentInformationClass {
            public static long SetStudentNo = 0;
            public static int SetAge = 0;

            public static string SetContactNo = string.Empty;
            public static string SetProgram = string.Empty;
            public static string SetGender = string.Empty;
            public static string SetBirthday = string.Empty;
            public static string SetFullName = string.Empty;

            public static string getFullName() => SetFullName;
            public static string getProgram() => SetProgram;
            public static string getContactNo() => SetContactNo;
            public static long getAge() => SetAge;
            public static long getStudentNo() => SetStudentNo;
        }

        private void ClearFormFields()
        {
            txtStudentNo.Clear(); 
            txtContactNo.Clear(); 
            txtAge.Clear(); 
            txtFirstName.Clear(); 
            txtLastName.Clear(); 
            txtMiddleInitial.Clear(); 
            cbPrograms.SelectedIndex = -1; 
            cbGender.SelectedIndex = -1; 
            DPBirthday.Value = DateTime.Now;
        }
    }
}
