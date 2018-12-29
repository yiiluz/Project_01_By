using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DL;
namespace BL
{
    class BLImplementation :IBL
    {

        private static IDAL instance = null; 
        public BLImplementation()
        {
            try
            {
                instance = Factory.GetDLObj("lists");
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }
        Dictionary<string,Object> keyValuesBL = instance.getConfig();
        
    }
