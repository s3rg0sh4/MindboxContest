using FigureCalculator;

namespace FigureCalculator.Tests
{
	public class CalculatorTests
	{
		[Fact]
		public void Area_Triangle()
		{
			var area = Calculator.Area(3, 4, 5);
			Assert.Equal(6, area);
		}
		[Fact]
		public void Area_Circle()
		{
			var area = Calculator.Area(3);
			Assert.Equal(3 * 3 * Math.PI, area);
		}
	}
}
