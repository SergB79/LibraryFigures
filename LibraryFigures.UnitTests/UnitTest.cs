using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFigures.UnitTests
{
    public class UnitTest
    {
		[TestClass]
		public class TriangleTests
		{
			[TestMethod]
			public void isRightTriangle_NotRightTriangle()
			{
				//Arrange
				Triangle triangle = new Triangle("Треугольник", 2, 3, 4);

				//Act
				bool result = triangle.IsRightTriangle();

				//Assert
				Assert.IsFalse(result);
			}
			
			[TestMethod]
			public void isRightTriangle_YesRightTriangle()
			{
				//Arrange
				Triangle triangle = new Triangle("Треугольник", 3, 4, 5);

				//Act
				bool result = triangle.IsRightTriangle();

				//Assert
				Assert.IsTrue(result);
			}


			[TestMethod]
			public void SquareTriagle_YesReturn12()
			{
				//Arrange
				Figure triangle = new Triangle("Треугольник", 5, 5, 8);
				double expected = 12;

				//Act
				double result = triangle.Square();

				//Assert
				Assert.AreEqual(expected, result);
			}
			
			[TestMethod]
			public void SquareTriagle_NoReturn13()
			{
				//Arrange
				Figure triangle = new Triangle("Треугольник", 5, 5, 8);
				double expected = 13;

				//Act
				double result = triangle.Square();

				//Assert
				Assert.AreNotEqual(expected, result);
			}
		}

		[TestClass]
		public class CircleRadius
		{
			[TestMethod]
			public void Square_5_Return78_5()
			{
				//Arrange
				var circle = new Circle("Круг", 10);
				double expected = 314.16;

				//Act
				var result = circle.Square();

				//Assert
				Assert.AreEqual(expected, result);
			}
		}

	}
}
