using System;

namespace BE
{
    public class Test : ICloneable,IComparable
    {
        private int id = Configuration.CurrentTestID;

        private DateTime testDate;

        #region Constuctor
        public Test(DateTime dt)
        {
            Configuration.CurrentTestID++;
            this.testDate = dt;
        }

        private Test(DateTime dt, int id)
        {
            this.testDate = dt;
            this.id = id;
        }
        #endregion

        public string ID
        {
            get { return id.ToString("00000000"); }
        }

        public DateTime TestDate { get => testDate; }

        public object Clone()
        {
            return new Test(testDate,id);
        }

        public int CompareTo(object obj)
        {
            return testDate.CompareTo((obj as Test).testDate );
        }

        public override string ToString()
        {
            return ID + " " + testDate.ToShortDateString();
        }
    }
}