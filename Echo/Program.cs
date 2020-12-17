using Newtonsoft.Json;
using System;


namespace DBHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = "";
            customer1.Name = "George";
            customer1.Phone = "555-555-5555";
            customer1.PostalCode = "77777";
            customer1.Region = "North America";
            customer1.Country = "United States of America";
            customer1.Title = "Mr.";
            customer1.Address = "1430 W. Abbey Lane";
            customer1.City = "Battle Mountain, Nevada";
            customer1.CompanyName = "Regal Hills Construction";

            Customer customer2 = new Customer();
            customer2.ID = "";
            customer2.Name = "Sarah";
            customer2.Phone = "555-551-5555";
            customer2.PostalCode = "45825";
            customer2.Region = "North America";
            customer2.Country = "Canada";
            customer2.Title = "Ms.";
            customer2.Address = "140 W. King Ct.";
            customer2.City = "Montreal";
            customer2.CompanyName = "XCode Cyber Security";

            Customer customer3 = new Customer();
            customer3.ID = "";
            customer3.Name = "Reginold";
            customer3.Phone = "555-155-5555";
            customer3.PostalCode = "78985";
            customer3.Region = "South America";
            customer3.Country = "Brazil";
            customer3.Title = "Ms.";
            customer3.Address = "540 Road Burguer DF";
            customer3.City = "Brasilia";
            customer3.CompanyName = "Ben and Jerries";

            Customer customer4 = new Customer();
            customer4.ID = "2";
            customer4.Name = "Karris";
            customer4.Phone = "555-559-5555";
            customer4.PostalCode = "888996";
            customer4.Region = "Europe";
            customer4.Country = "Germany";
            customer4.Title = "Ms.";
            customer4.Address = "11 glockenspiel road";
            customer4.City = "Hamburg";
            customer4.CompanyName = "XCode Cyber Security";

            JsonDatabase jsonDB = new JsonDatabase("Customers", @"..\\..\\..\\Data\\Customer.json");
            jsonDB.add(customer1);
            jsonDB.add(customer2);
            jsonDB.add(customer3);
            jsonDB.add(customer4); // should replace customer 2 with the new information
            jsonDB.debug<Customer>();
            //Customer deserialized = JsonConvert.DeserializeObject<Customer>(output);
            //Console.WriteLine(deserialized.ID);

        }
    }
}