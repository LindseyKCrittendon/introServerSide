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

            planetList.ForEach(planetList => Console.WriteLine(planetList));
        }
    }
}
