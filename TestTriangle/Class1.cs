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


        [Test]
        public void TriangleTestScalene1()
        {
            //Arrange
            int firstSide = 60;
            int secondSide = 70;
            int thirdSide = 80;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestScalene2()
        {
            //Arrange
            int firstSide = 50;
            int secondSide = 60;
            int thirdSide = 70;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestScalene3()
        {
            //Arrange
            int firstSide = 80;
            int secondSide = 90;
            int thirdSide = 100;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestScalene4()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 40;
            int thirdSide = 50;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestScalene5()
        {
            //Arrange
            int firstSide = 45;
            int secondSide = 55;
            int thirdSide = 65;

            string expected = "Scalene triangle";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TriangleTestZeroLengthSide1()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 60;
            int thirdSide = 70;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestZeroLengthSide2()
        {
            // Arrange
            int firstSide = 50;
            int secondSide = 0;
            int thirdSide = 70;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestZeroLengthSide3()
        {
            // Arrange
            int firstSide = 50;
            int secondSide = 60;
            int thirdSide = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestInvalidResponse1()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 20;
            int thirdSide = 40; 

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestInvalidResponse2()
        {
            // Arrange
            int firstSide = 100;
            int secondSide = 20; 
            int thirdSide = 50;

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTestInvalidResponse3()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 30; 

            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }

}
