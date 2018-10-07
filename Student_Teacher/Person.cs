using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher
{
    class Person
    {
        protected int Age;
        public void SetAge(int n)
        {
             Age = n;
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
