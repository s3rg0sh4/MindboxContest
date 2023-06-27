using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FigureCalculator.Figures;

namespace FigureCalculator.Tests.Figures
{
	public class TriangleTests
	{
		[Fact]
		public void TriangleWithInvalidSides1()
		{
			Exception exception = Assert.Throws<Exception>(() => new Triangle(-4, 4, 5));
			Assert.Equal("Треугольник не существует", exception.Message);
		}

		[Fact]
		public void TriangleWithInvalidSides2()
		{
			Exception exception = Assert.Throws<Exception>(() => new Triangle(4, 4, 10));
			Assert.Equal("Треугольник не существует", exception.Message);
		}

		[Fact]
		public void Area()
		{
			Triangle triangle = new(3, 4, 5);
			Assert.Equal(6, triangle.Area());
		}

		[Fact]
		public void IsRightWithAnyValues1()
		{
			var triangle = new Triangle(3, 4, 5);
			Assert.True(triangle.IsRight());
		}

		[Fact]
		public void IsRightWithAnyValues2()
		{
			var triangle = new Triangle(3, 4, 6);
			Assert.False(triangle.IsRight());
		}
	}
}
