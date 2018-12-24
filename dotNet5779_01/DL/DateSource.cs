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
        protected static DateSource date = null;
        internal static List<Test> tests;
        internal static List<Tester> testers;
        internal static List<Trainee> trainees;    
        internal class ConfigurationParameter
        {
            public bool Readable;
            public bool Writable;
            public object Value;
        }
        public static DateSource GetDateObject()
        {
            if (date == null)
            {

                date = new DateSource();
            }
            return date;
        }

        internal static Dictionary<String, ConfigurationParameter> Configuration = new Dictionary<string, ConfigurationParameter>();          
        internal static Dictionary<String, bool[,]> Schedules;
         static DateSource()
        {
            tests = new List<Test>();
            testers = new List<Tester>();
            trainees = new List<Trainee>();
            Configuration.Add("Tester minimum age", new ConfigurationParameter() { Readable = true, Writable = false, Value = 40 });
            Configuration.Add("Trainee minimum age", new ConfigurationParameter() { Readable = true, Writable = false, Value = 18 });
            Configuration.Add("Minimum distance between test to test", new ConfigurationParameter() { Readable = true, Writable = false, Value = 7 });
            Configuration.Add("Minimum lessons", new ConfigurationParameter() { Readable = true, Writable = false, Value = 20 });
            Configuration.Add("Tester maximum age", new ConfigurationParameter() { Readable = true, Writable = false, Value = 67 });     
        }
    }
   
}
