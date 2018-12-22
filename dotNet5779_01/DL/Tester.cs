using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class Tester
    {
        private readonly string id;
        private string lastName;
        private string firstName;
        private string phoneNumber;
        private DateTime dateOfBirth = new DateTime();
        private GenderEnum gender;
        private Address address;
        private double seniority;
        private double maxDistance;
        private int maxTestsPerWeek;
        private CarTypeEnum typeCarToTest;
        private bool[,] availableWorkTime = new bool[5, 6];

        /// <summary>
        /// default ctor
        /// </summary>
        /// <param name="id"></param>
        public Tester(string id)
        {
            this.id = id;
        }
        public string Id => id;

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public Address Address { get => address; set => address = value; }
        public double Seniority { get => seniority; set => seniority = value; }
        public double MaxDistance { get => maxDistance; set => maxDistance = value; }
        public int MaxTestsPerWeek { get => maxTestsPerWeek; set => maxTestsPerWeek = value; }
        public CarTypeEnum TypeCarToTest { get => typeCarToTest; set => typeCarToTest = value; }
        public bool[,] AvailableWorkTime { get => availableWorkTime; set => availableWorkTime = value; }

        /// <summary>
        /// overide ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tmp = "Tester name: " + FirstName + " " + LastName + ".\nID: " + Id + ".\nGender: " + Gender + ".\nDate Of Birth: " + DateOfBirth.ToShortDateString() +
                ".\nPhone number: " + PhoneNumber + ".\nAddress: " + Address + ".\nSeniority: " + Seniority + ".\nType of car: " + TypeCarToTest +
                ".\nMax tests per week: " + MaxTestsPerWeek + ".\nMax distance for test: " + MaxDistance + ".\n";
            return tmp;
        }
    }
}
