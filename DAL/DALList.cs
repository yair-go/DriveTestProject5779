using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class DALList : IDAL
    {
        public void AddTester()
        {
            throw new NotImplementedException();
        }

        public void AddTester(string name)
        {
            throw new NotImplementedException();
        }

        public void AddTester(string name, int age)
        {
            Tester t = new Tester(name, age);
            DataSource.testers.Add(t);
        }

        public void addTrainee(string id, string name, int age)
        {
            Trainee t = new Trainee(id, name, age);
        }
       
    }
}
