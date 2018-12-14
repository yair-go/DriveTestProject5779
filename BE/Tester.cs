using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester : ICloneable
    {
        private string name;
        private int age;
        private DateTime birthday;

        public Tester(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public Tester(string name, int age)
        {
            this.Name = name;
          //  this.Age = age;
        }

       
        public string Name { get => name; set => name = value; }
        public int Age {
            get { return (int)(DateTime.Now - Birthday).TotalDays/365; }
        }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public object Clone()
        {
            return new Tester(Name, Birthday);
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
