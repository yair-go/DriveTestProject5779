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
            Random random = new Random(DateTime.Now.Millisecond);
            string[] idArray = new string[] {"aaa","bbb","ccc","ddd","eee","fff","ggg","hhh","iii","jjj","kkk" };
            foreach (string name in idArray)
            {
                int year = random.Next(1948, 1978);
                int id  = random.Next(10000000, 90000000);
                id = id * 10 + CalcValiditionDigit(id);
                testers.Add(new Tester(name, new DateTime(year,12,12),id));
                tests.Add(new Test(DateTime.Now.AddDays(random.Next(100,1000))));
            }

           
            foreach (var item in Enumerable.Range(13, 1000000))
            {
                tests.Add(new Test(DateTime.Now.AddDays(random.Next(1, 1000))));
            }
        }

        private static int CalcValiditionDigit(int id)
        {
            string strID = id.ToString();
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, };
            int count = 0;

            strID = strID.PadLeft(8, '0');

            for (int i = 0; i < 8; i++)
            {
                int num = Int32.Parse(strID.Substring(i, 1)) * id_12_digits[i];

                if (num > 9)
                    num = (num / 10) + (num % 10);

                count += num;
            }
            return 10 - (count%10);
        }
        static bool CheckIDNo(String strID)
        {
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2,1 };
            int count = 0;

            if (strID == null)
                return false;

            strID = strID.PadLeft(9, '0');

            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(strID.Substring(i, 1)) * id_12_digits[i];

                if (num > 9)
                    num = (num / 10) + (num % 10);

                count += num;
            }

            return (count % 10 == 0);
        }
    }
}
