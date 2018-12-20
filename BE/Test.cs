using System;

namespace BE
{
    public class Test
    {
        private int id = Configuration.CurrentTestID;

        public string ID
        {
            get { return id.ToString("00000000"); }
        }

    }
}