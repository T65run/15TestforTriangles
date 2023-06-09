using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TarunTestTriangles
{
    public class Class1
    {
        [Test]
        public void EquilateralTri_Input2and2and2_OutputForEqualTriangle()
        {
            //Arrange
            int EquSide1 = 2;
            int EquSide2 = 2;
            int EquSide3 = 2;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(EquSide1, EquSide2, EquSide3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsoscelesTri_Input8and8and2_OutputForIsoTriangle()
        {
            //Arrange
            int EquSide1 = 8;
            int EquSide2 = 8;
            int EquSide3 = 2;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(EquSide1, EquSide2, EquSide3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
