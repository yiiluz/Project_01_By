using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BL;
namespace PLConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IBL bl = Factory.GetBLObj();
            int e;
           e= Console.Read()
            while (e != 16)
            {
                switch (e)
                {
                    
                    case 1:
                        Console.WriteLine("Enter tester ID\n");
                        string id = Console.ReadLine();
                        if (id.Length == 9 && id.All(char.IsDigit))
                        {
                            Tester tester = new Tester(id);
                            Console.WriteLine("Enret");
                        }
                       

                        break; 
                    default:
                        break;
                }
            }
        }
    }
}
