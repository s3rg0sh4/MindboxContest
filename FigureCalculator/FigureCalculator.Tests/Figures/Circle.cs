using FigureCalculator.Figures;

namespace FigureCalculator.Tests.Figures
{
	public class CircleTests
    {
        [Fact]
		public void CircleWithInvalidRadius()
		{
            Exception exception = Assert.Throws<Exception>(() => new Circle(-3));
            Assert.Equal("Круг не существует, радиус меньше нуля", exception.Message);
		}

        [Fact]
        public void Area()
        {
            Circle circle = new(3);
            Assert.Equal(3 * 3 * Math.PI, circle.Area());
        }

	}
}