using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Classes
{
    public class Room
    {
        private double _length;
        private double _width;
        private double _height;

        public Room(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        // CHALLENGE:
        // Create 3 properties (with getters only):

        // SquareFootage

        // This is a METHOD
        public double GetSquareFootage()
        {
            return _length * _width;
        }
        // This is a PROPERTY
        public double SquareFootage
        {
            get { return _length * _width; }
        }




        // WallSurfaceArea (all four walls)
        public double WallSurfaceArea
        {
            get { return (2 * _width * _height + 2 * _length * _height); }
        }

        // Volume
        public double Volume
        {
            get { return _length * _width * _height; }
        }
    }
}
