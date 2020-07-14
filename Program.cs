using System;
using System.Collections.Generic;

namespace chapter4exercises
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Planet and Spacechips exercise
            // List<string> planetList = new List<string>(){"Mercury", "Mars"};
            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");
            // // planetList.ForEach (planetList => Console.WriteLine(planetList));
            // // Console.WriteLine(planetList);

            // List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};
            

            // planetList.AddRange(planetList2);
            // planetList.Insert(1 , "Venus");
            // planetList.Insert(2 , "Earth");
            // planetList.Add("Pluto");

            // planetList.ForEach(planetList => Console.WriteLine(planetList));

            // Console.WriteLine("\noutput = planetList.GetRange(0, 4).ToArray()");
            // string[] output = planetList.GetRange(0, 4).ToArray();

            // Console.WriteLine();
            // foreach( string rockyPlanet in output){
            //     Console.WriteLine(rockyPlanet);
            // };

            // planetList.Remove("Pluto");
            //  planetList.ForEach(planetList => Console.WriteLine(planetList));
            

            //Random Numbers exercise

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

                numbers.ForEach(number => Console.WriteLine(number));

for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
   if(numbers.Contains(i)){
   Console.WriteLine($"numbers list contains {i}");
   }else{
       Console.WriteLine($"numbers list does not contain {i}");
   };
   
};
            
        }
    }
}
