using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigures
{
    public abstract class Figure
    {
		public string TypeFigure { get; set; }

		public Figure(string typeFigure)
		{
			TypeFigure = typeFigure;
		}

		public abstract double Square();

		public override string ToString()
		{
			return $"Тип фигуры: {TypeFigure}";
		}
	}
}
