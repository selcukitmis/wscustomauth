using System;

namespace Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            var auth = new ExampleWS.CustomAuthentication();
            auth.Username = "Demo";
            auth.Password = "Pass123";

            var service = new ExampleWS.Example();
            service.CustomAuthenticationValue = auth;

            var cities = service.GetCities();
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            var addCity = service.AddCity("Bursa");
            foreach (var item in addCity)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");


            var removeCity = service.RemoveCity("Bursa");
            foreach (var item in removeCity)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
