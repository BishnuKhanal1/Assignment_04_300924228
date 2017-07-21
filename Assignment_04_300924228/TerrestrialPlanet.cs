using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name: Bishnu Khanal
 * Date: July 20, 2017
 * Description: This is the TerrestrialPlanet subclass class
 * Version:0.3 - Edited HasMoon method and Habital Method which will return true
 * GitHub Link: https://github.com/BishnuKhanal1/COMP123-s2017-Lesson9B-Lab24/commits/master   
 */
namespace Assignment_04_300924228
{
    /// <summary>
    /// This is terrestrialPlanet subclass which inherits from the Planet abstract class
    /// </summary>
    public class TerrestrialPlanet :Planet, IHasMoons, IHabitable
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
        /// <summary>
        /// This is HasMoon method which will return true of the moonCount property is greater than 0.
        /// </summary>
        /// <param name="moonCount"></param>
        /// <returns></returns>
        public bool HasMoons()
        {
            return (this.MoonCount > 0) ? true : false;
        }
        /// <summary>
        /// This is Habitable method.
        /// This returns true if the instance variable is set to true.
        /// </summary>
        /// <param name="oxygen"></param>
        /// <returns></returns>
        public bool Habitable()
        {
            return (this._oxygen == true) ? true : false;
        }
    }
}