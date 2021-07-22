using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_9_AddressBookSystem
{
   public class AddMultiplePerson
    {
        
       
            //creating the list 
        private static List<Details> contacts = new List<Details>();
        
        public static void EnterInput()
        {
            Console.Write("Enter the number of contacts ");
            int NumofContact = Convert.ToInt32(Console.ReadLine());

            while (NumofContact >0)
            {
                Details details = new Details();


                Console.Write("Enter First Name: ");
                details.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                details.LastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                details.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                details.City = Console.ReadLine();

                Console.Write("Enter State: ");
                details.State = Console.ReadLine();
                while (true)
                {
                    Console.Write("Enter Zip Code of your area: ");
                    string code = Console.ReadLine();

                    if (code.Length == 6)
                    {
                        details.Zip = code;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                    }
                }

                //verification for phone number 
                while (true)
                {
                    Console.Write("Enter Phone Number: ");
                    string Phonenumber = Console.ReadLine();
                    if (Phonenumber.Length == 10)
                    {
                        details.PhoneNumber = Phonenumber;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                    }
                }
                //verification for Email 
                while (true)
                {
                    Console.Write("Enter Email-id: ");
                    string Email = Console.ReadLine();
                    if (Email.Contains("@"))
                    {
                        details.Email = Email;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                    }
                }
                contacts.Add(details);
                Console.WriteLine("...............Contacts Added succesfully...............");


                NumofContact--;
            }
        }
        //method for view Contacts
        public static void ViewTheDetails()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("***************Your Contact List Has********************");
                foreach (var item in contacts)
                {
                    PrintTheDetails(item);
                    Console.WriteLine("**************************");
                }

            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }
        public static void PrintTheDetails(Details item)
        {
            Console.WriteLine($"First Name : {item.FirstName}");
            Console.WriteLine($"Last Name : {item.LastName}");
            Console.WriteLine($"Address : {item.Address}");
            Console.WriteLine($"City : {item.City}");
            Console.WriteLine($"State : {item.State}");
            Console.WriteLine($"Zip Code: {item.Zip}");
            Console.WriteLine($"Phone Number: {item.PhoneNumber}");
            Console.WriteLine($"Email: {item.Email}");

        }
        //method for editing details
        public static void EditUsingName()
        {
            int f;//flag variable
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a Name you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var item in contacts)
                {
                    if (editName.ToLower() == item.FirstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.Zipcode\n7.Phone Number\n8.Email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    item.FirstName = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    item.LastName = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    item.Address = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    item.City = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    item.State = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 6:
                                    while (true)
                                    {
                                        Console.Write("Enter Zip Code of your area: ");
                                        string code = Console.ReadLine();

                                        if (code.Length == 6)
                                        {
                                            item.Zip = code;
                                            Console.WriteLine("***************MODIFIED****************");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter a valid 6 digit Zip Code.");
                                        }
                                    }
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 7:
                                    //validation for phone number
                                    while (true)
                                    {
                                        Console.Write("Enter new Phone Number: ");
                                        string PhoneNumber = Console.ReadLine();
                                        if (PhoneNumber.Length == 10)
                                        {
                                            item.PhoneNumber = PhoneNumber;
                                            Console.WriteLine("***************MODIFIED****************");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                                        }
                                    }
                                    break;
                                case 8:
                                    //validation for Email id
                                    while (true)
                                    {
                                        Console.Write("Enter new Email-id: ");
                                        string Email = Console.ReadLine();
                                        if (Email.Contains("@"))
                                        {
                                            item.Email = Email;
                                            Console.WriteLine("***************MODIFIED****************");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                                        }
                                    }
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("Exited");
                                    f = 1;
                                    break;

                            }
                            if (f == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }

        //method for deleting conatcts
        public static void DeleteTheName()
        {
            int f = 0;
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a Name you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var item in contacts)
                {
                    if (deleteName.ToLower() == item.FirstName.ToLower())
                    {
                        //removing from list
                        Console.WriteLine("***************DELETED****************");
                        Console.WriteLine($"You have deleted {item.FirstName} contact");
                        contacts.Remove(item);
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                {
                    Console.WriteLine("The name you have entered not in the Address book");
                }

            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
    }
}
    
