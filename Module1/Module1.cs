using System;

namespace Module1
{
    class Module1
    {
        static void Main(string[] args)
        {
            string firstName = "Todd";
            string lastName = "Smith";
            //DateTime birthDate = new DateTime(1966, 3, 10);
            DateTime birthDate = DateTime.Parse("3/10/1966");
            string addr1 = "123 Main St.";
            string addr2 = "Suite 214";
            string city = "Encinitas";
            string state = "CA";
            int zipCode = 92024;
            string country = "USA";
            TimeSpan myAge = DateTime.Now.Subtract(birthDate);
            Console.WriteLine(firstName+" "+lastName);
            Console.WriteLine(birthDate.ToShortDateString());
            Console.WriteLine(addr1);
            Console.WriteLine(addr2);
            Console.WriteLine(city+", "+state+" "+zipCode.ToString()+" "+country);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
