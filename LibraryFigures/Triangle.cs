using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigures
{
    public class Triangle:Figure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
        private double Semiperimeter { get; set; }
        public Triangle(string typeFigure, double sideA, double sideB, double sideC):base(typeFigure)
        {
            if (IsDegeneracy(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
                Semiperimeter = (sideA + sideB + sideC) / 2;
            }
        }
        public override double Square()
        {
            return Math.Sqrt(Semiperimeter * (Semiperimeter - SideA) * (Semiperimeter - SideB) * (Semiperimeter - SideC));
        }
        public bool IsDegeneracy(double a, double b, double c)//проверка на отрицатеьные стороны и вырожденность треугольника
        {            
            if (a < 0 || b < 0 || c < 0)
            {
                throw new TriangleException("Одна из сторон отрицательная");
            }
            if (((a + b) < c) || ((a + c) < b) || ((b + c) < a))
            {
                throw new TriangleException("Такой треугольник не существует");
            }

            return true;
        }
        public bool IsRightTriangle()//проверка на прямоугольность
        {
            if ((Math.Sqrt((SideB * SideB) + (SideC * SideC)) == Math.Sqrt(SideA * SideA)) ||
               ((Math.Sqrt((SideA * SideA) + (SideC * SideC)) == Math.Sqrt(SideB * SideB))) ||
               (Math.Sqrt((SideB * SideB) + (SideA * SideA)) == Math.Sqrt(SideC * SideC))) return true;
            return false;
        }
    }
}
