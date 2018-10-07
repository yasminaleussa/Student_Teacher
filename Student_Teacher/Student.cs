using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher
{
    class Student : Person
    {

        public void GoToClass()
        {
            Console.Write("I'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is : " + age + "years old");
        }
    }
}
