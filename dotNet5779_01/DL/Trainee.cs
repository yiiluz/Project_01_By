using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class Trainee
    {
        readonly string id;
        private string lastName;
        private string firstName;
        private string schoolName;
        private string teacherName;
        private string phoneNumber;
        private GenderEnum gender;
        private Address address = new Address();
        private DateTime dateOfBirth = new DateTime();
        private DateTime lastTest = new DateTime();
        private CarTypeEnum currCarType;
        private GearboxTypeEnum currGearType;
        private int numOfFinishedLessons;
        private int numOfTests;
        private bool isAlreadyDidTest;
        private List<CarTypeEnum> existingLicenses = new List<CarTypeEnum>();

        /// <summary>
        /// default ctor
        /// </summary>
        /// <param name="id"></param>
        public Trainee(string id)
        {
            this.id = id;
        }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SchoolName { get => schoolName; set => schoolName = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public Address Address { get => address; set => address = value; } 
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime LastTest { get => lastTest; set => lastTest = value; }
        public CarTypeEnum CurrCarType { get => currCarType; set => currCarType = value; }
        public GearboxTypeEnum CurrGearType { get => currGearType; set => currGearType = value; }
        public int NumOfFinishedLessons { get => numOfFinishedLessons; set => numOfFinishedLessons = value; }
        public int NumOfTests { get => numOfTests; set => numOfTests = value; }
        public bool IsAlreadyDidTest { get => isAlreadyDidTest; set => isAlreadyDidTest = value; }
        public List<CarTypeEnum> ExistingLicenses { get => existingLicenses; set => existingLicenses = value; }
        public string Id { get => id; }

        /// <summary>
        /// override of ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string existingLic = "";
            foreach (var item in ExistingLicenses)
                existingLic += item + ", ";
            existingLic.Remove(existingLic.Length - 2, existingLic.Length);
            string tmp = "Trainee name: " + FirstName + " " + LastName + ".\nID: " + Id + ".\nGender: " + Gender + ".\nDate Of Birth: " + DateOfBirth.ToShortDateString() +
                ".\nPhone number: " + PhoneNumber + ".\nAddress: " + Address + ".\nExisting linsences: " + existingLic +
                ".\nType of current Gearbox: " + CurrGearType + ".\nType of current Car: " + CurrCarType + ".\nSchool name: " + SchoolName +
                ".\nTeacher name: " + TeacherName + ".\nSum of pased lessons: " + numOfFinishedLessons + ".\n";
            return tmp;
        }
    }
}
