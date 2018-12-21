using System;

namespace BE
{
    public class Test : ICloneable
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

        public object Clone()
        {
            return new Test(testDate,id);
        }

        public override string ToString()
        {
            return ID + " " + testDate.ToShortDateString();
        }
    }
}