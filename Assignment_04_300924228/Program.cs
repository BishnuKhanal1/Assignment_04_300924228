using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: Bishnu Khanal
 * Date: July 14, 2017
 * Description: This is the Program class
 * Version:0.3 - Implemented WaitForAnyKey() method in the driver class
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
            GiantPlanet giantPlanet = new GiantPlanet("Uranus", 50724, 8.681025, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlannet = new TerrestrialPlanet("Earth", 50724, 8.681025, true);
            Console.WriteLine(terrestrialPlannet.ToString());

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
