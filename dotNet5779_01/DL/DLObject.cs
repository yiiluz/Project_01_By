using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
namespace DL
{
    class DLObject : IDAL
    {
        protected static DLObject instance = null;
        public static DLObject GetDLObject()
        {
            if (instance == null)
            {

                instance = new DLObject();
            }
            return instance;
        }

        void IDAL.AddTest(Test t)
        {
            if (DateSource.tests.Find(x => x.TestId == t.TestId) != null)
            {
                throw new DuplicateWaitObjectException("ERROR! The test already exists in the system ");
            }
            else if (DateSource.testers.Find(x => x.Id == t.TesterId) == null)
            {
                throw new KeyNotFoundException("ERROR! The tester does not exist in the system ");
            }
            else if (DateSource.trainees.Find(x => x.Id == t.TraineeId) == null)
            {
                throw new KeyNotFoundException("ERROR! The trainee does not exist in the system ");
            }
            else
            {
                DateSource.tests.Add(t);
            }
        }
        
        void IDAL.AddTester(Tester t)
        {
            if (DateSource.testers.Find(x => x.Id == t.Id) != null)
            {
                throw new DuplicateWaitObjectException("This tester is already registered in the system");
            }
            else
            {
                DateSource.testers.Add(t);
            }
        }

        void IDAL.AddTrainee(Trainee t)
        {
            if (DateSource.trainees.Find(x => x.Id == t.Id) != null)
            {
                throw new DuplicateWaitObjectException("This trainee is already registered in the system");
            }
            else
            {
                DateSource.trainees.Add(t);
            }
        }

        List<Tester> IDAL.GetTestersList()
        {
            List<Tester> testers2 = new List<Tester>(DateSource.testers);
            return testers2;

        }

        List<Test> IDAL.GetTestsList()
        {
            List<Test> tests2 = new List<Test>(DateSource.tests);
            return tests2;
        }

        List<Trainee> IDAL.GetTraineeList()
        {
            List<Trainee> trainees2 = new List<Trainee>(DateSource.trainees);
            return trainees2;
        }

        void IDAL.RemoveTester(Tester T)
        {
            if (DateSource.testers.Find(x => x.Id == T.Id) != null)
            {
                DateSource.testers.Remove(DateSource.testers.Find(x => x.Id == T.Id));
            }
            else
            {
                throw new KeyNotFoundException("This tester does not exist in the system");
            }
        }

        void IDAL.RemoveTrainee(Trainee T)
        {
            if (DateSource.trainees.Find(x => x.Id == T.Id) != null)
            {
                DateSource.trainees.Remove(DateSource.trainees.Find(x => x.Id == T.Id));
            }
            else
            {
                throw new KeyNotFoundException("This trainee does not exist in the system");
            }
        }

        void IDAL.UpdateTest(Test t)
        {
            int index = DateSource.tests.FindIndex(x => x.TestId == t.TestId);
            if (index > -1)
            {
                DateSource.tests[index] = t;
            }
            else
            {
                throw new KeyNotFoundException("This test does not exist in the system");
            }
        }

        void IDAL.UpdateTesterDetails(Tester T)
        {
            int index = DateSource.testers.FindIndex(x => x.Id == T.Id);
            if (index > -1)
            {
                DateSource.testers[index] = T;
            }
            else
            {
                throw new KeyNotFoundException("This tester does not exist in the system");
            }
        }

        void IDAL.UpdateTraineeDetails(Trainee T)
        {
            int index = DateSource.trainees.FindIndex(x => x.Id == T.Id);
            if (index > -1)
            {
                DateSource.trainees[index] = T;
            }
            else 
            {
                throw new KeyNotFoundException("this trainee does not exist in the system");
            }
        }
        void IDAL.RemoveTest(Test t)
        {
            if (DateSource.tests.Find(x => x.TestId == t.TestId) != null && DateSource.testers.Find(x => x.Id == t.TesterId) != null && DateSource.trainees.Find(x => x.Id == t.TraineeId) != null)
            {
                DateSource.tests.Remove(DateSource.tests.Find(x => x.TestId == t.TestId));
            }
            else
            {
                throw new KeyNotFoundException("This test does not exist in the system");
            }
        }
        Dictionary<string, Object> IDAL.getConfig()
        {

        }
        void IDAL.setConfig(string parm, Object value)
        {

        }
    }
}
