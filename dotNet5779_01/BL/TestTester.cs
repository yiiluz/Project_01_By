using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class TestTester
    {
        private int testId;
        private ExternalTrainee exTrainee;
        private DateTime dateOfTest = new DateTime();
        private int hourOfTest;
        private CarTypeEnum carType;
        private Address startTestAddress = new Address();
        private bool distanceKeeping;
        private bool reverseParking;
        private bool mirrorsCheck;
        private bool signals;
        private bool correctSpeed;
        private bool isPassed;
        private string testerNotes;

        public int TestId { get => testId; set => testId = value; }
        public ExternalTrainee ExTrainee { get => exTrainee; set => exTrainee = value; }
        public DateTime DateOfTest { get => dateOfTest; set => dateOfTest = value; }
        public int HourOfTest { get => hourOfTest; set => hourOfTest = value; }
        public CarTypeEnum CarType { get => carType; set => carType = value; }
        public Address StartTestAddress { get => startTestAddress; set => startTestAddress = value; }
        public bool DistanceKeeping { get => distanceKeeping; set => distanceKeeping = value; }
        public bool ReverseParking { get => reverseParking; set => reverseParking = value; }
        public bool MirrorsCheck { get => mirrorsCheck; set => mirrorsCheck = value; }
        public bool Signals { get => signals; set => signals = value; }
        public bool CorrectSpeed { get => correctSpeed; set => correctSpeed = value; }
        public bool IsPassed { get => isPassed; set => isPassed = value; }
        public string TesterNotes { get => testerNotes; set => testerNotes = value; }
    }
}
