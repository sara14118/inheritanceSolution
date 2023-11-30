using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Human
    {
        int Id;
        string Name;
        bool HasJob;
        int age;
        bool IsMarried;



        // create constructer 
        public  Human(int Id , string Name ,int age  ,bool HasJob  , bool IsMarried)
        {
            this.Id = Id;
            this.Name = Name;
            this.HasJob = HasJob;
            this.age = age;
            this.IsMarried = IsMarried;

        }






    }
}
