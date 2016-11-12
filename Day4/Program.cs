﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Concept

            Company comOne = new Company();
            comOne.CompanyName();

            Employees empOne = new Employees();
            empOne.CompanyName();
            empOne.EmployeeName();

            Company comTwo = new Employees();
            comTwo.CompanyName();

            #endregion

            #region Method Overloading and Operator Overloading

            Salary salOne = new Salary();
            salOne.SetEmployeeSalary("April", 77.77);
            Salary salTwo = new Salary();
            salTwo.SetEmployeeSalary("May", 88.88);
            // Overloading + Operator 
            Salary empTotal = salOne + salTwo;
            Console.WriteLine(empTotal.GetEmployeeSalary());

            #endregion

            #region Method Overriding

            Company cOne = new Company();
            cOne.Write();
            Employees eOne = new Employees();
            eOne.Write();
            Company cTwo = new Employees();
            cTwo.Write();
            ((Company)eOne).Write();

            #endregion

            #region Method Hiding

            Company coOne = new Company();
            coOne.WriteLine();
            Employees emOne = new Employees();
            emOne.WriteLine();
            Company coTwo = new Employees();
            coTwo.WriteLine();
            ((Company)emOne).WriteLine();


            #endregion
        }
    }
}
