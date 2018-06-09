using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;

namespace CRUDInternetshop
{
   static class Bogus
    {

        internal static void Generate(string user)
        {
           /* var faker = new Faker("ru");

            var generator = new Faker<UserCreateModel>()
                .StrictMode(true)
                .RuleFor(x => x.FirstName , f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Surname, f => f.Name.Suffix())
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.Phone, f => f.Person.Phone)
                .RuleFor(x => x.Password, f => f.Internet.Password());

            var testUser = generator.Generate();

            Console.WriteLine(testUser.FirstName); 
            Console.WriteLine(testUser.LastName);  
            Console.WriteLine(testUser.Surname);
            Console.WriteLine(testUser.Email);
            Console.WriteLine(testUser.Phone);
            Console.WriteLine(testUser.Password);
            */
           
        }







    }
}
