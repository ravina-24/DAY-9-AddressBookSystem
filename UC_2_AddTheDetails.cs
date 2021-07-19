using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_9_AddressBookSystem
{
     public class AddTheDetails
    {
        public static List<Details> AddressBook = new List<Details>();

        public void EnterInput()
        {
            Details contacts = new Details();

            Console.Write("Enter the First Name : ");
            contacts.FirstName = Console.ReadLine();


            Console.Write("Enter the last Name  : ");
            contacts.LastName = Console.ReadLine();

            Console.Write("Enter the address  :");
            contacts.LastName = Console.ReadLine();

            Console.Write("Enter the City  :");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter the state  : ");
            contacts.State = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter Zip Code  : ");
                string code = Console.ReadLine();

                if (code.Length == 6)
                {
                    contacts.Zip = code;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid 6 digit Zip Code.");
                }
            }

            while (true)
            {
                Console.Write("Enter Your Phone Number: ");
                string number = Console.ReadLine();

                if (number.Length == 10)
                {
                    contacts.PhoneNumber = number;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid 10 digit Phone Number.");
                }
            }

            while (true)
            {
                Console.Write("Enter Your Email Address: ");
                string mail = Console.ReadLine();

                if (mail.Contains("@"))
                {
                    contacts.Email = mail;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Email Address.");
                }
            }

            AddressBook.Add(contacts);

            Console.WriteLine("..................");

        }



        public void ViewTheDetails()
        {
            if (AddressBook.Count > 0)
            {
                foreach ( var item in AddressBook)
                {
                    PrintTheDetails(item);
                }
            }
            else
            {
                Console.WriteLine("Address book is empty! ");

            }
        }

        public void PrintTheDetails(Details item)
        {
            Console.WriteLine("First Name :   " + item.FirstName);
            Console.WriteLine("Last Name :    " + item.LastName);
            Console.WriteLine("Address :      " + item.Address);
            Console.WriteLine("City    :      " + item.City);
            Console.WriteLine("State   :      " + item.State);
            Console.WriteLine("Zip     :      " + item.Zip);
            Console.WriteLine("Phone Number  : " + item.PhoneNumber);
            Console.WriteLine("email  :       " + item.Email);


        }


    }
}
