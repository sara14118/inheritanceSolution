using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Employee
    {
        string Role;
        string Department;
        int WorkingHours;
        int Wage;




        public  Employee(string Role , string Department , int WorkingHours , int Wage)
        {
            this.Role = Role;
            this.Department = Department;
            this.WorkingHours = WorkingHours;
            this.Wage = Wage;
            

        }

        public void CalculateF(int WorkingHours, int Wage )
        {
            int total = WorkingHours*Wage;
            double totalSalary = total * 0.3;

            
        }


        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee role : {Role}, E.department : {Department}, WorkingHours : {WorkingHours}, Wage : {Wage}");
        }




    }







}
