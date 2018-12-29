using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Factory
    {
        private static IDAL dlWithLists = DLObject.GetDLObject();

        public static IDAL GetDLObj (string type)
        {
            if (type == "lists")
                return dlWithLists;
            throw new NotImplementedException("there is no such type of dl");
        }
    }
}
