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
        private int id;
        private int age;
        private DateTime birthday;
        private bool[,] schedule = new bool[5,6];

        #region Constructor
        public Tester(string name, DateTime birthday, int id)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.id = id;
            initilazeSchedule();
        }

        private void initilazeSchedule()
        {
            for (var day = DayOfWeek.Sunday; day < DayOfWeek.Friday; day++)
                for (int hour = 0; hour < 6; hour++)
                    schedule[(int)day, hour] = false;
        }

        public Tester(string name, int age)
        {
            this.Name = name;
          //  this.Age = age;
        }

        public Tester(string name,  DateTime birthday, bool[,] schedule)
        {
            this.name = name;
            this.birthday = birthday;
            this.schedule = schedule;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public int Age {
            get { return (int)(DateTime.Now - Birthday).TotalDays/365; }
        }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public bool[,] Schedule { get => schedule; set => schedule = value; }

        public string ID {
            get { return id.ToString("000000000");    }
        }
       

        #endregion

        public bool isTesterWorkTime(DateTime dateTime)
        {
            if (dateTime.DayOfWeek > DayOfWeek.Thursday)
                return false;
            else return schedule[(int)dateTime.DayOfWeek, dateTime.Hour];
            
        }

        public object Clone()
        {
            return new Tester(Name, Birthday, id);
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
