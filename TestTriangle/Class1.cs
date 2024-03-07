using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TestTriangle
{
    [TestFixture]
    public class Class1
    {
        [Test]
   public void TriangleTestEquilateral()
       {
        
        //Arrange
        int firstSide=60;
        int secondSide = 60;
        int thirdSide = 60;

        string expected = "Equilateral triangle";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        //Assert
        Assert.AreEqual(expected,actual);

       }

        [Test]
        public void TriangleTestIsosceles1()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 30;
            int thirdSide = 40;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestIsosceles2()
        {
            //Arrange
            int firstSide = 40;
            int secondSide = 30;
            int thirdSide = 30;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestIsosceles3()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 40;
            int thirdSide = 30;

            string expected = "Isosceles triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
