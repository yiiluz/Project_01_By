using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Person
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

        public Person(string id)
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
        public string Id { get => id; }
    }
}
