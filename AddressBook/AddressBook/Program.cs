using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Addressd Book Program ");
            Console.WriteLine("Welcome to Address Book Progam \n");
            CreateAddressBook createAddressBook = new CreateAddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }
    }
}
