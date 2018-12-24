using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
namespace DL
{
    internal class DateSource
    {        
        internal static List<Test> tests = new List<Test>();
        internal static List<Tester> testers = new List<Tester>();
        internal static List<Trainee> trainees = new List<Trainee>();    
        internal class ConfigurationParameter
        {
            public bool Readable;
            public bool Writable;
            public object Value;
        }
        internal static Dictionary<String, ConfigurationParameter> Configuration;
        internal static Dictionary<String, bool[,]> Schedules;

    }
}
