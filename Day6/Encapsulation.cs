using System;
using System.Windows.Forms;

namespace Day6
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            Day6.StudentCl.DoValidation();
            Day6.DBClass.DoCreateInDB();
        }
    }
}