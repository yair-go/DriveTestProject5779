using System;

namespace DAL
{
    public class FactoryDAL
    {
        public static IDAL getDAL(string typeDAL)
        {
            switch (typeDAL)
            {
                case "List": return DALList.Instance;
              //  case "XML": return DAL_XML.Instance;
                default: return null;
            }
        }
    }
}