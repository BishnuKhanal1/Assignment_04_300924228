using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name: Bishnu Khanal
 * Date: July 20, 2017
 * Description: This is the TerrestrialPlanet subclass class
 * Version:0.1 - Created  the TerrestrialPlanet subclass class
 * GitHub Link: https://github.com/BishnuKhanal1/COMP123-s2017-Lesson9B-Lab24/commits/master   
 */
namespace Assignment_04_300924228
{
    /// <summary>
    /// This is terrestrialPlanet subclass which inherits from the Planet abstract class
    /// </summary>
    public class TerrestrialPlanet :Planet
    {
        //Private instance variables

        private bool _oxygen;

        //Public Properties
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //Public Methods
    }
}