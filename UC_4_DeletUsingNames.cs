using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_9_AddressBookSystem
{
   public class Delete
    {

        public void DeletetheName()
        {
            if (AddTheDetails.AddressBook.Count > 0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var item in AddTheDetails.AddressBook)
                {
                    if (deleteName.ToLower() == item.FirstName.ToLower())
                    {
                        AddTheDetails.AddressBook.Remove(item);
                        Console.WriteLine(deleteName + "'s Contact is successfully deleted.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}

   
