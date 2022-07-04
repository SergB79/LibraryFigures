
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
