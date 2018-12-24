﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public interface IBL
    {
        void AddTester(Tester T);
        void RemoveTester(Tester T);
        void UpdateTesterDetails(Tester T);
        void AddTrainee(Trainee T);
        void RemoveTrainee(Trainee T);
        void RemoveTest(Test t);
        void UpdateTraineeDetails(Trainee T);
        void AddTest(Test t);
        void UpdateTest(Test t);
        List<Tester> GetTestersList();
        List<Trainee> GetTraineeList();
        List<Test> GetTestsList();
        Dictionary<String, Object> getConfig();
        void setConfig(String parm, Object value);
    }
}