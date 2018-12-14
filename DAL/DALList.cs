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
        static DALList() { }
        //private static void CreateDemoEntites()
        //{
        //    int[] idArray = new int[] { 1, 2, 3, 4, 5 };
        //    foreach (int i in idArray)
        //    {
        //        AddTester(new Tester(i.ToString(), 20));
        //        //  bl.addChild(new Child(i.ToString(), 20));
        //    }

        //}
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
            return DataSource.testers.Clone().ToList();
        }
        #endregion

        public void addTrainee(string id, string name, int age)
        {
            Trainee t = new Trainee(id, name, age);
        }

       
    }
}
