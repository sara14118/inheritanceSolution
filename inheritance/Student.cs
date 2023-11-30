using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Student : Human
    {

        string Qualification;
        bool Intern;
        int  TotalGrade ;
        int StudyingHours;



        public Student(int Id, string Name, int age, bool HasJob, bool IsMarried, string Qualification , bool Intern , int TotalGrade, int StudyingHours  ) : base (Id,  Name, age, HasJob, IsMarried)
        
        { 


            this.Qualification = Qualification;
            this.Intern = Intern;
            this.TotalGrade = TotalGrade;
            this.StudyingHours = StudyingHours;
        
        
        }

        


        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student Qualification : {Qualification}, is Intern : {false},the total grade : {TotalGrade}, studyingHours : {StudyingHours}");
        }


       
        
        }


        



    }

