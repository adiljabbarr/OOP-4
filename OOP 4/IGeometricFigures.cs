using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP_4
{
    internal interface IGeometricFigures
    {
        void FigureArea();
        void FigurePerimeter();
    }

    class Square : IGeometricFigures
    {
        public int side { get; set; }
        public void FigureArea()
        {
            int area = side * side;
            Console.WriteLine("Kvadratin sahesi: " + area);
        }
        public void FigurePerimeter()
        {
            int perimeter = side * 4;
            Console.WriteLine("Kvadratin perimetri: " + perimeter);
        }
    }

    public class Triangle : IGeometricFigures
    {
        public double side { get; set; }
        public double height { get; set; }

        public void FigurePerimeter()
        {
            double perimeter = side * 3;
            Console.WriteLine("Ucbucagin perimetri: " + perimeter);

        }

        public void FigureArea()
        {
            double area = side * height * 0.5;
            Console.WriteLine("Ucbucagin sahesi: " + area);
        }       
    }

    class Circle : IGeometricFigures
    {


        public double radius { get; set; }
        public void FigureArea()
        {
            double area = radius * radius * Math.PI;
            Console.WriteLine("Dairenin sahesi: " + area);
        }

        public void FigurePerimeter()
        {
            double perimeter = radius * Math.PI * 2;
            Console.WriteLine("Dairenin perimetri: " + perimeter);
        }
    }
}
