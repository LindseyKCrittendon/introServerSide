using System;
using System.Collections.Generic;

namespace chapter4exercises
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Planet and Spacechips exercise
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // planetList.ForEach (planetList => Console.WriteLine(planetList));
            // Console.WriteLine(planetList);

            List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};
            

            planetList.AddRange(planetList2);
            planetList.Insert(1 , "Venus");
            planetList.Insert(2 , "Earth");
            planetList.Add("Pluto");

            planetList.ForEach(planetList => Console.WriteLine(planetList));

            Console.WriteLine("\noutput = planetList.GetRange(0, 4).ToArray()");
            string[] output = planetList.GetRange(0, 4).ToArray();

            Console.WriteLine();
            foreach( string rockyPlanet in output){
                Console.WriteLine(rockyPlanet);
            };

            planetList.Remove("Pluto");
             planetList.ForEach(planetList => Console.WriteLine(planetList));
            

            
        }
    }
}
