using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHateThisHomeworkItTookMeMonths
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }

        public Person(string _Name, string _Surname, short _Age)
        {
            Name = _Name;
            Surname = _Surname;
            Age = _Age;
        }

        public Person()
        {
            Name = "";
            Surname = "";
            Age = 0;
        }
    }
}
