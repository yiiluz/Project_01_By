using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
namespace PLConsole
{
    class AddPerson
    {
        private Person AddP()
        {
            Console.WriteLine("Enter tester ID\n");
            string id = Console.ReadLine();
            Person person;
            if (id.Length == 9 && id.All(char.IsDigit))
            {
                person = new Person(id);
                Console.WriteLine("Enrer first name\n");
                string name = Console.ReadLine();
                if (name.All(char.IsLetter)) { person.FirstName = name; }
                else { throw new FormatException("ERROR! Invalid first name"); }
                Console.WriteLine("Enter lest name\n");
                name = Console.ReadLine();
                if (name.All(char.IsLetter)) { person.LastName = name; }
                else { throw new FormatException("ERROR! Invalid lest name"); }
                Console.WriteLine("Enter phone number\n");
                string number = Console.ReadLine();
                if (number.Length == 10 && number.All(char.IsDigit)) { person.PhoneNumber = number; }
                else { throw new FormatException("ERROR! Invalid phone number"); }
                Console.WriteLine("Enter Gender:\nMale enter 1\n Fmale enter 2\n");
                int gender = Console.Read();
                if (gender == 1) { person.Gender = GenderEnum.Male; }
                else if (gender == 2) { person.Gender = GenderEnum.Female; }
                else { throw new FormatException("Are you not closed on your sexual identity?"); }
                Console.WriteLine("Enter address:\n");
                Console.WriteLine("enter city:\n");
                string City = Console.ReadLine();
                Console.WriteLine("enter street:\n");
                string Street = Console.ReadLine();
                Console.WriteLine("enter building Number:\n");
                string building = Console.ReadLine();
                int building2;
                if (City.All(char.IsLetter) && Street.All(char.IsLetter) && int.TryParse(building, out building2)) { person.Address = new Address(City, Street, building2); }
                else { throw new FormatException("ERROR! invalid address"); }
                Console.WriteLine("Enter Date of Birth:\n");
                DateTime dateOfBirth;
                string dateOfBirth2 = Console.ReadLine();
                if(DateTime.TryParse(dateOfBirth2, out dateOfBirth)) { person.DateOfBirth = dateOfBirth; }
                else { throw new FormatException("ERROR! Invalid birth date"); }
            }
            else { throw new FormatException("ERROR! Invalid ID"); }
            return person;
        }
        public AddTester()
        {
            Person person = new Person(AddP());
            Tester tester = new Tester(person.Id);
            tester.FirstName = person.FirstName;
            tester.LastName = person.LastName;
            tester.Gender = person.Gender;
            tester.Address = person.Address;
            tester.DateOfBirth = person.DateOfBirth;

            return
        }
    }
}
