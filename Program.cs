
using System;
using System.Data;
using ContactsBusinessLayer;

namespace ContactsConsolApp
{
    internal class Program
    {
        static void testFindContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName + " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");
            }
        }

        static void testAddNewContact()


        {
            clsContact Contact1 = new clsContact();
            Contact1.FirstName = "Ahmed";
            Contact1.LastName = "Saeed";
            Contact1.Email = "Ahemd@gamil.com";
            Contact1.Phone = "04958545";
            Contact1.Address = "Main Street";
            Contact1.DateOfBirth = new DateTime(2004, 11, 3, 10, 30, 0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";

            if (Contact1.Save())
            {

                Console.WriteLine("Contact Added Successfully with id=" + Contact1.ID);
            }

        }

        //static void testUpdateContact(int ID)

        //{
        //    clsContact Contact1 = clsContact.Find(ID);

        //    if (Contact1 != null)
        //    {
        //        //update whatever info you want
        //        Contact1.FirstName = "Fadi2";
        //        Contact1.LastName = "Maher2";
        //        Contact1.Email = "A2@a.com";
        //        Contact1.Phone = "2222";
        //        Contact1.Address = "222";
        //        Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
        //        Contact1.CountryID = 1;
        //        Contact1.ImagePath = "";

        //        if (Contact1.Save())
        //        {

        //            Console.WriteLine("Contact updated Successfully ");
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("Not found!");
        //    }
        //}

        static void testUpdateContact(int ID)
        {
            clsContact Contact1 = clsContact.Find(ID);
            if (Contact1 != null)
            {
                Contact1.FirstName = "Ahmed";
                Contact1.LastName = "Ali";
                Contact1.Email = "A2@a.com";
                Contact1.Phone = "222845";
                Contact1.Address = "60 St";
                Contact1.DateOfBirth = new DateTime(1995, 11, 6, 10, 30, 0);
                Contact1.CountryID = 1;
                Contact1.ImagePath = "";

                if (Contact1.Save())
                {
                    Console.WriteLine("Contact Updated Successfully :)");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }


        }

        static void testDeleteContact(int ID)
        {
            if (clsContact.IsContactExits(ID))
            {

                if (clsContact.DeleteContacts(ID))
                    Console.WriteLine("Contact Deleted Successflly :)");
                else
                    Console.WriteLine("Faild to Deleted Conatact :(");
            }
            else
                Console.WriteLine("The Contact with ID = " + ID+ " is not found");

            

        }

        //static void ListContacts()
        //{

        //    DataTable dataTable = clsContact.GetAllContacts();

        //    Console.WriteLine("Contacts Data:");

        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        Console.WriteLine($"{row["ContactID"]},  {row["FirstName"]} {row["LastName"]}");
        //    }

        //}

        static void ListContacts()
        {
            DataTable DT = clsContact.GetAllContacts();
            Console.WriteLine("Contacts Date: ");
            foreach (DataRow row in DT.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}, {row["FirstName"]}, {row["LastName"]} ");
            }
        }


        static void testIsContactExist(int Id)
        {
            if (clsContact.IsContactExits(Id))
                Console.WriteLine("Yes, Contact is there");
            else 
                Console.WriteLine("No, Contact is not there");
        }


        static void Main(string[] args)
        {

            testFindContact(1);
            testAddNewContact();
            testUpdateContact(1);
            ListContacts();
            testDeleteContact(100);

            testIsContactExist(4);
            testIsContactExist(100);

           

            Console.ReadKey();

        }
    }
}
