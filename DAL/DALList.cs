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
        #region Singleton
        private static readonly DALList instance = new DALList();
        public static DALList Instance
        {
            get { return instance; }
        }

        private DALList() { }
        #endregion

        #region Tester
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

        public void AddTester(Tester t)
        {
            DataSource.testers.Add(t);
        }
        public List<Tester> getAllTesters()
        {
            return DataSource.testers;
        }
        #endregion

        public void addTrainee(string id, string name, int age)
        {
            Trainee t = new Trainee(id, name, age);
        }

       
    }
}
