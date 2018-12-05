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
        #endregion

        #region Trainee

        void addTrainee(String id,String name, int age);
        #endregion


    }
}
