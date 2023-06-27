using FigureCalculator.Figures;

namespace FigureCalculator
{
	public static class Calculator
	{
		public static double Area(params double[] sides)
		{
			switch (sides.Length)
			{
				case 1:
					return new Circle(sides[0]).Area();
				case 3:
					return new Triangle(sides[0], sides[1], sides[2]).Area();
				default:
					throw new Exception("Некорректные значения");
			}
		}
	}
}
