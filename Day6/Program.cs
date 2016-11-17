using System;
using System.Windows.Forms;

namespace Day6
{
    internal class Student
    {
        private int id;
        private string name;
        private string address;

        // Accessor (Get process)
        public string GetStudentData()
        {
            string value = string.Format("ID : {0}, Name : {1}, Address : {2}", id, name, address);
            return value;
        }

        // Mutator (Set Process)
        public void SetStudentData(int sID, string sName, string sAddress)
        {
            if (sID <= 0)
            {
                throw new Exception("ID should be a positive value and greater than zero.");
            }
            else
            {
                id = sID;
            }

            if (string.IsNullOrEmpty(sName))
            {
                throw new Exception("Name cannot be null or empty.");
            }
            else
            {
                name = sName;
            }

            address = sAddress;
        }
    }

    internal class Employee
    {
        private int id;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string name;

        private string address;
    }

    public static class DBClass
    {
        public static void DoCreateInDB()
        {
        }
    }

    public static class StudentCl
    {
        public static void DoValidation()
        {
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Student studentOne = new Student();
            //studentOne.SetStudentData(12, "Raj", "India");
            //Console.WriteLine(studentOne.GetStudentData());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmStudent());
        }
    }
}