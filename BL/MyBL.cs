using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class MyBL : IBL
    {

        #region Singleton
        private static readonly MyBL instance = new MyBL();

        public static MyBL Instance
        {
            get { return instance; }
        }
        #endregion

        static IDAL MyDal;

        #region Constructor

        private MyBL() { }

        static MyBL()
        {
            // string TypeDAL = ConfigurationSettings.AppSettings.Get("TypeDS");
            string TypeDAL = "List";
          //  MyDal = FactoryDAL.getDAL(TypeDAL);
        }

        #endregion
        #region Tester
        public void addTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public void deleteTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public List<Tester> getTestersList()
        {
            throw new NotImplementedException();
        }

        public void updateTester(Tester tester, string name)
        {
            throw new NotImplementedException();
        }

        public void updateTester(Tester tester, Tester newtester)
        {
            throw new NotImplementedException();
        }

        public void updateTester(Tester tester, int cost, string minmax)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
