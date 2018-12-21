using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        #region Tester
        void AddTester();
        void AddTester(String name);
        void AddTester(String name ,int age);
        void AddTester(Tester t);
        List<Tester> getAllTesters();
        #endregion

        #region Trainee

        void addTrainee(String id,String name, int age);
        #endregion

        #region Test
        void AddTest();
        void AddTest(Test t);
        List<Test> getTests(Func<Test, bool> predicate);
        #endregion

    }
}
