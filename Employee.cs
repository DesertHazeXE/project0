using System;
using System.Collections.Generic;
using System.Text;

namespace project0
{
    class Employee
    {
        private static int Count = 1000;
        public string No { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }

        public Employee(string fullname, string position, double salary, string departmentname)
        {
            FullName = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;

            string Nameing = departmentname.ToUpper();
            {
                return $"{FullName} {Position} {Salary} {DepartmentName} {No}";



            }
        }

    }
}
