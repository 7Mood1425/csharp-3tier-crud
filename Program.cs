
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
                Console.WriteLine("The Contact with ID = " + ID + " is not found");



        }
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

        //_________________________________________________________

        static void testFind(int ID)

        {
            clsCountry Country1 = clsCountry.Find(ID);

            if (Country1 != null)
            {
                Console.WriteLine("Country ID: " + Country1.CountryID);
                Console.WriteLine("Country Name: " + Country1.CountryName);

            }
            else
            {
                Console.WriteLine("Country [" + ID + "] Not found!");
            }
        }
        static void testFind(string CountryName)

        {
            clsCountry Country1 = clsCountry.Find(CountryName);

            if (Country1 != null)
            {
                Console.WriteLine("Country ID: " + Country1.CountryID);
                Console.WriteLine("Country Name: " + Country1.CountryName);

            }
            else
            {
                Console.WriteLine(" [" + CountryName + "] Not found!");
            }
        }

        static void testAddNewCountry()


        {
            clsCountry country1 = new clsCountry();


            country1.CountryName= "Kindom Saudi Arabia";
            country1.Code = "KSA";
            country1.PhoneCode = "+966";

            if (country1.SaveCountry())
            {

                Console.WriteLine("Country Added Successfully with id=" + country1.CountryID);
            }

        }

        static void testUpdateCountry(int ID,string CountryName)
        {
            clsCountry Country1 = clsCountry.Find(ID);
          
            

            if (Country1 != null)
            {

                 Country1.CountryName = "Kingdom Saudi Arabia";
                 Country1.Code = "KSA";
                 Country1.PhoneCode = "+966";


                if (Country1.SaveCountry())
                {
                    Console.WriteLine("Country Name Updated Successfully :)");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        static void testDeleteCountry(int ID)
        {
            if (clsCountry.isCountryExist(ID))
            {

                if (clsCountry.DeleteCountry(ID))
                    Console.WriteLine("Country: Deleted Successflly :)");
                else
                    Console.WriteLine("Faild to Deleted Country :(");
            }
            else
                Console.WriteLine("The Country with ID = " + ID + " is not found");

        }

        static void ListCountries()
        {
            DataTable DT = clsCountry.GetAllCountries();
            Console.WriteLine("Countries List: ");
            foreach (DataRow row in DT.Rows)
            {
                Console.WriteLine($"ID: {row["CountryID"]},  Name: {row["CountryName"]}," +
                    $" Code: {row["Code"]}, PhoneCode: {row["PhoneCode"]}");
            }
        }

        static void isCountryExists(int Id)
        {
            if(clsCountry.isCountryExist(Id))
                Console.WriteLine("Yes, Country is there");
            else
                Console.WriteLine("No, Country is not there");
        }

        static void Main(string[] args)
        {

            //testFindContact(1);
            //testAddNewContact();
            //testUpdateContact(1);
            //ListContacts();
            //testDeleteContact(100);

            //testIsContactExist(4);
            //testIsContactExist(100);

            //testFind(12);
            //testFind("Canada");
            //testAddNewCountry();
            //testUpdateCountry(13, "Kindom Saudi Arabia");
            //testDeleteCountry(12);
            //ListCountries();
            //isCountryExists(1);

            Console.ReadKey();

        }
    }
}
