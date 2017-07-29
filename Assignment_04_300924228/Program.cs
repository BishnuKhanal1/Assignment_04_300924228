using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: Bishnu Khanal
 * Date: July 14, 2017
 * Description: This is the Program class. This class implements the GiantPlanet class and TerrestrialPlanet class
 * Version:0.5 - Finally revised the driver class for submission
 * GitHub Link: https://github.com/BishnuKhanal1/COMP123-s2017-Lesson9B-Lab24/commits/master   
 */
namespace Assignment_04_300924228
{
    class Program
    {
        /// <summary>
        /// This is the program class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            GiantPlanet giantPlanet = new GiantPlanet("Uranus", 50724, 8.681025, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            giantPlanet.RingCount = 13;
            giantPlanet.MoonCount = 27;

            //this checks the number moon of the selected giant planet if they are greater than 0.

            if (giantPlanet.HasMoons())
            {
                Console.WriteLine(giantPlanet.Name + " has "+giantPlanet.MoonCount+" moon(s)");
            }
            else
            {
                Console.WriteLine(giantPlanet.Name + " has no moon(s)");
            }
            if (giantPlanet.HasRings())
            {
                Console.WriteLine(giantPlanet.Name + " has " + giantPlanet.RingCount + " ring(s)");
            }
            else
            {
                Console.WriteLine(giantPlanet.Name + " has no ring(s)");
            }

            Console.WriteLine("================================================");

            TerrestrialPlanet terrestrialPlannet = new TerrestrialPlanet("Earth", 50724, 8.681025, true);
            terrestrialPlannet.MoonCount = 1;
            Console.WriteLine(terrestrialPlannet.ToString());

             //this checks if the Habitable planet has oxygen or not
            if (terrestrialPlannet.Habitable())
            {
                Console.WriteLine(terrestrialPlannet.Name+" is a habitable planet");
            }
            else
            {
                Console.WriteLine(terrestrialPlannet.Name+" is not a habitable planet");
            }

            if (terrestrialPlannet.HasMoons())
            {
                Console.WriteLine(terrestrialPlannet.Name + " has " + terrestrialPlannet.MoonCount + " moon(s)");
            }
            else
            {
                Console.WriteLine(terrestrialPlannet.Name + " has no moon(s)");
            }

            Console.WriteLine("================================================");

            //Invoke WaitForAnyKey() method
            WaitForAnyKey();
        }
        /// <summary>
        /// This is WaitForAnyKey method which does not retur anything
        /// Prompts the message in console to enter any key to exit
        /// </summary>
        public static void WaitForAnyKey()
        {
            string message;
            message = "Please enter any key to exit";
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
