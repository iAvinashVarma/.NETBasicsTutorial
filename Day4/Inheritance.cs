using System;

namespace Day4
{
    #region Inheritance Concept

    internal class Company
    {
        internal void CompanyName()
        {
            Console.WriteLine("Tata");
        }

        #region Method Overriding

        internal virtual void Write()
        {
            Console.WriteLine("Company Class (Base Class).");
        }

        #endregion Method Overriding

        #region Method Hiding or Shadowing

        internal virtual void WriteLine()
        {
            Console.WriteLine("Company Class (Base Class) - Hide Process.");
        }

        #endregion Method Hiding or Shadowing
    }

    internal class Employees : Company
    {
        private string employeeName;
        private int employeeId;

        internal void EmployeeName()
        {
            Console.WriteLine("Ratan Tata");
        }

        #region Method Overloading

        internal void SetEmployeeInfo(string firstName)
        {
            employeeName = firstName;
        }

        internal void SetEmployeeInfo(string firstName, string lastName)
        {
            employeeName = firstName + " " + lastName;
        }

        internal void SetEmployeeInfo(string firstName, int id)
        {
            employeeName = "Employee : " + firstName + "'s Id is " + id;
        }

        internal void SetEmployeeInfo(int id)
        {
            employeeId = id;
        }

        internal string GetEmployeeData()
        {
            string data = string.Empty;
            if (!string.IsNullOrEmpty(employeeName))
                data += employeeName;
            if (employeeId > 0)
                data += employeeId.ToString();
            return data;
        }

        #endregion Method Overloading

        #region Method Overriding

        internal override void Write()
        {
            Console.WriteLine("Employees Class (Derived Class).");
        }

        #endregion Method Overriding

        #region Method Hiding or Shadowing

        internal new void WriteLine()
        {
            Console.WriteLine("Company Class (Child Class) - Hide Process.");
        }

        #endregion Method Hiding or Shadowing
    }

    #endregion Inheritance Concept
}