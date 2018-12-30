using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DL;
namespace BL
{
    class BLImplementation : IBL
    {
        private IDAL instance = null;
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
        Dictionary<string, Object> keyValuesBL = instance.getConfig();
        public IEnumerable<Tester> AvailableTeacher(DateTime time, int hour)
        {
            var AvailableTesters = from item in instance.GetTestersList()
                                   orderby item.LastName, item.FirstName
                                   where item.IsTesterAvailiableOnDate(time, hour) == true
                                   select new Tester(iten);
            return AvailableTesters;
        }
        public IEnumerable<Test> GetTestsPartialListByPredicate(Func<DO.Test, bool> func)
        {
            var StandOnTheCondition = from item in instance.GetTestsList()
                                      orderby item.TestId
                                      where func(item) == true
                                      select new Test(item);
            return StandOnTheCondition;
        }
        public int NumberOfTestsTested(Trainee t)
        {
            return t.NumOfTests;
        }
        public bool IsHaveLicense(Trainee T, CarTypeEnum car)
        {

            return T.ExistingLicenses.Exists(x => x == car);
        }
        public IEnumerable<Test> TheTestsWillBeDoneToday_Month(DateTime t, bool Byday)
        {
            if (Byday == true)
            {
                var toDay = from item in instance.GetTestsList()
                            orderby item.TestId
                            where item.DateOfTest.DayOfYear == t.DayOfYear
                            select item;
                return toDay;
            }
            var ThisMonth = from item in GetTestsList()
                            orderby item.TestId
                            where item.DateOfTest.Month == t.Month
                            select item;
            return ThisMonth;
        }
        public IEnumerable<IGrouping<CarTypeEnum, Tester>> GetTestersBySpecialization(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var TestersGroupsWithOrder = from item in GetTestersList()
                                             orderby item.LastName, item.FirstName
                                             group item by item.TypeCarToTest
                                             into g
                                             orderby g.Key
                                             select g;
                return TestersGroupsWithOrder;
            }
            var TestersGroupsWithoutOrder = from item in GetTestersList()
                                            group item by item.TypeCarToTest;
            return TestersGroupsWithoutOrder;
        }
        public IEnumerable<IGrouping<string, Trainee>> GetStudentGroupsBySchool(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var StudentGroupsByAttributeWithOrder = from item in GetTraineeList()
                                                        orderby item.LastName, item.FirstName
                                                        group item by item.SchoolName
                                                        into g
                                                        orderby g.Key
                                                        select g; 
                return StudentGroupsByAttributeWithOrder;
            }
            var StudentGroupsByAttributeWithOutOrder = from item in GetTraineeList()
                                                       group item by item.SchoolName;
            return StudentGroupsByAttributeWithOutOrder;
        }
        public IEnumerable<IGrouping<string, Trainee>> GetStudentGroupsByTeacher(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var StudentGroupsByTeacherWithOrder = from item in GetTraineeList()
                                                      orderby item.LastName, item.FirstName
                                                      group item by item.SchoolName
                                                      into g
                                                      orderby g.Key
                                                      select g;
                return StudentGroupsByTeacherWithOrder;
            }
            var StudentGroupsByTeacherWithOutOrder = from item in GetTraineeList()
                                                     group item by item.SchoolName;
            return StudentGroupsByTeacherWithOutOrder;
        }
        public IEnumerable<IGrouping<int, Trainee>> GetStudentsGroupedaccordingByNumOfTests(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var StudentsGroupedaccordingByNumOfTestsWithOrder = from item in GetTraineeList()
                                                                    orderby item.LastName, item.FirstName
                                                                    group item by item.NumOfTests
                                                                    into g
                                                                    orderby g.Key
                                                                    select g;
                return StudentsGroupedaccordingByNumOfTestsWithOrder;
            }
            var StudentsGroupedaccordingByNumOfTestsWithOutrder = from item in GetTraineeList()
                                                                  group item by item.NumOfTests;
            return StudentsGroupedaccordingByNumOfTestsWithOutrder;
        }
        public IEquatable<IGrouping<int, Tester>> GetTestersGroupedAccordingToYearsOfExperience()
        {
            var TestersGroupedAccordingToYearsOfExperience = from item in GetTestersList()
                                                             orderby item.LastName, item.FirstName
                                                             group item by item.Seniority
                                                             into g
                                                             orderby g.Key
                                                             select g;
            return TestersGroupedAccordingToYearsOfExperience;
        }
    }
}
