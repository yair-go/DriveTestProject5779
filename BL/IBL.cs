using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    interface IBL
    {
        #region Tester
        void addTester(Tester tester);
        void deleteTester(Tester tester);
        void updateTester(Tester tester, string name);
        void updateTester(Tester tester, Tester newtester);
        void updateTester(Tester tester, int cost, string minmax);
        List<Tester> getTestersList();
        #endregion
    }
}
