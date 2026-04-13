using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ClassesBasics
{
    internal class Triangle
    {
        #region Atributos e Propriedades

        private double _sideA;
        private double _sideB;
        private double _sideC;
        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new
                    ArgumentException("The side must be a positive number");
                }
                else
                {
                    _sideA = value;
                }
            }
        }
        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new
                    ArgumentException("The side must be a positive number");
                }
                else
                {
                    _sideB = value;
                }
            }
        }
        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (value <= 0)
                {
                    throw new
                    ArgumentException("The side must be a positive number");
                }
                else
                {
                    _sideC = value;
                }
            }
        }
        #endregion


        /// <summary>
        /// Calculates the area of a triangle using the lengths of its three sides.
        /// </summary>
        /// <remarks>This method uses Heron's formula to compute the area</remarks>
        /// <returns>The area of the triangle</returns>
        public double Area()
        {
            double p = (SideA + SideB + SideC)/2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Calculates the perimeter of the triangle by summing the lengths of its sides.
        /// </summary>
        /// <returns>The total length of all sides of the triangle.</returns>
        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
