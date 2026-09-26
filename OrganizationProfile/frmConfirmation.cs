using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        StudentInformationClass studentInfo = new StudentInformationClass();

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = studentInfo.SetStudentNo.ToString();
            lblName.Text = studentInfo.SetFullName.ToString();
            lblProgram.Text = studentInfo.SetProgram.ToString();
            lblBirthday.Text = studentInfo.SetBirthday.ToString();
            lblGender.Text = studentInfo.SetGender.ToString();
            lblContactNo.Text = studentInfo.SetContactNo.ToString();
            lblAge.Text = studentInfo.SetAge.ToString();
        }
    }
}
