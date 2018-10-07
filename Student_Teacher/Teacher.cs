using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher
{
    class Teacher : Person
    {
        private string _subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins... ");
        }
    }
}
