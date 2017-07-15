using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name: Bishnu Khanal
 * Date: July 14, 2017
 * Description: This is the abstract Planet class
 * Version:0.3 - Added public override (ToString) method to the abstract Planet class
 * GitHub Link: https://github.com/BishnuKhanal1/COMP123-s2017-Lesson9B-Lab24/commits/master   
 */
namespace Assignment_04_300924228
{
    public abstract class Planet
    {
        //Private Instance Variables (fields)

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //Public Properties

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
           get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount; 
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        // Public Constructors
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        public override string ToString()
        {
            return string.Format("Planet Name:{0} Diameter: {1} Mass: {2}",
                this.Name, this.Diameter, this.Mass);      
        }
    }
}