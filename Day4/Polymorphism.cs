using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    #region Polymorphism Concept

    class Salary : Employees
    {
        private string month;
        private double salary;

        #region Operator Overloading

        internal void SetEmployeeSalary(string mon, double sal)
        {
            month = mon;
            salary = sal;
        }

        internal string GetEmployeeSalary()
        {
            return month + " " + salary.ToString();
        }

        public static Salary operator +(Salary eOne, Salary eTwo)
        {
            Salary empNew = new Salary();
            empNew.salary = eOne.salary + eTwo.salary;
            empNew.month = eOne.month + " " + eTwo.month;
            return empNew;
        }

        #endregion
    }

    #endregion
}
