using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 26, 2017
 * Description: started the project
 * Version: used the GiantPlanet and TerrestrialPlanet Class in the main driver
 */


namespace Assignment4_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
			GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 1.898 * Math.Pow(10,27) , 69911 *2, "Gas");
			Console.WriteLine(giantPlanet.ToString());

			TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 5.972 * Math.Pow(10, 24), 12742,true);

			Console.WriteLine(terrestrialPlanet.ToString());

			WaitForAnyKey();

			
			void WaitForAnyKey()
			{
				Console.WriteLine("Press Any Key To Continue");
				Console.ReadLine();
			}


		}
    }
}
