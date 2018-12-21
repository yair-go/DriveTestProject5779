using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<Tester> testers;
        public static List<Trainee> trainees;
        public static List<Test> tests;

        static DataSource()
        {
            testers = new List<Tester>();
            trainees = new List<Trainee>();
            tests = new List<Test>();
            CreateDemoEntites();
        }

        private static void CreateDemoEntites()
        {
            string[] idArray = new string[] {"aaa","bbb","ccc","ddd","eee" };
            foreach (string name in idArray)
            {
                testers.Add(new Tester(name, new DateTime(1960,12,12)));
                tests.Add(new Test(DateTime.Now.AddDays(7)));
            }
            
        }

    }
}
