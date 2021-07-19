using System;

namespace DAY_9_AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Program ");

            while (true)
            {
                Console.WriteLine("\n Enter your choice \n 1 for Adding Contacts \n 2 for viewing Address book" +
                    " \n 3 for editing the existing contact \n 4 for deleting contact");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTheDetails obj = new AddTheDetails();
                        obj.EnterInput();
                        break;


                    case 2:
                        AddTheDetails obj1 = new AddTheDetails();
                        obj1.ViewTheDetails();
                        break;



                    case 3:
                        EditTheDetails obj2 = new EditTheDetails();
                        obj2.EditUsingName();
                        break;

                    case 4:
                        Delete obj3 = new Delete();
                        obj3.DeletetheName();
                        break;

                    default:
                        Console.WriteLine("Enter valid choice.");
                        break;


                }
            }
        }
    }
}


        
    

