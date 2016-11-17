using System;

namespace Day4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Inheritance Concept

            Company comOne = new Company();
            comOne.CompanyName();

            Employees empOne = new Employees();
            empOne.CompanyName();
            empOne.EmployeeName();

            Company comTwo = new Employees();
            comTwo.CompanyName();

            #endregion Inheritance Concept

            #region Method Overloading and Operator Overloading

            Salary salOne = new Salary();
            salOne.SetEmployeeSalary("April", 77.77);
            Salary salTwo = new Salary();
            salTwo.SetEmployeeSalary("May", 88.88);
            // Overloading + Operator
            Salary empTotal = salOne + salTwo;
            Console.WriteLine(empTotal.GetEmployeeSalary());

            #endregion Method Overloading and Operator Overloading

            #region Method Overriding

            Company cOne = new Company();
            cOne.Write();
            Employees eOne = new Employees();
            eOne.Write();
            Company cTwo = new Employees();
            cTwo.Write();
            ((Company)eOne).Write();

            #endregion Method Overriding

            #region Method Hiding

            Company coOne = new Company();
            coOne.WriteLine();
            Employees emOne = new Employees();
            emOne.WriteLine();
            Company coTwo = new Employees();
            coTwo.WriteLine();
            ((Company)emOne).WriteLine();

            #endregion Method Hiding
        }
    }
}