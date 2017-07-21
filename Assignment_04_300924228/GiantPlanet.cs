﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name: Bishnu Khanal
 * Date: July 14, 2017
 * Description: This is the GiantPlanet (sub)class
 * Version:0.1 - Created a GiantPlanet class which has public GiantPlant constructor, HasMoon and HasRings Methods
 * GitHub Link: https://github.com/BishnuKhanal1/COMP123-s2017-Lesson9B-Lab24/commits/master   
 */
namespace Assignment_04_300924228
{
    /// <summary>
    /// This is the GiantPlanet class
    /// </summary>
    public class GiantPlanet : Planet
    {
        //Private instance variables

        private string _type;

        //Public constructor
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name, diameter, mass)
        {
            this._type = type;
        }
        /// <summary>
        /// This is public HasMoons method that returns true if moonCount property is geater than 0.
        /// </summary>
        /// <param name="moonCount"></param>
        /// <returns></returns>
        public bool HasMoons(int moonCount)
        {
            return (MoonCount > 0) ? true : false;
        }
        /// <summary>
        /// This is public HasRings method that returns true if ringCount property is geater than 0.
        /// </summary>
        /// <param name="moonCount"></param>
        /// <returns></returns>
        public bool HasRings(int ringCount)
        {
            return (ringCount > 0) ? true : false;
        }
    }
}