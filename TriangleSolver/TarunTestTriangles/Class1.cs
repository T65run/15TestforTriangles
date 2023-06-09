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
        public void Equilateral()
        {
            
            int et1 = 2;
            int et2 = 2;
            int et3 = 2;
            string exp = "The triangle is valid and is an EQUILATERAL";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]
        public void Isosceles1()
        {
            int et1 = 8;
            int et2 = 8;
            int et3 = 2;
            string exp = "The triangle is valid and is an ISOSCELES";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]
        public void Isosceles2()
        {
            int et1 = 5;
            int et2 = 5;
            int et3 = 3;
            string exp = "The triangle is valid and is an ISOSCELES";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]
        public void Isosceles3()
        {
            int et1 = 6;
            int et2 = 6;
            int et3 = 7;
            string exp = "The triangle is valid and is an ISOSCELES";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]
        public void Scalene1()
        {
            int et1 = 10;
            int et2 = 14;
            int et3 = 6;
            string exp = "The triangle is valid and is a SCALENE";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]
        public void Scalene2()
        {
            int et1 = 5;
            int et2 = 7;
            int et3 = 3;
            string exp = "The triangle is valid and is a SCALENE";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]
        public void Scalene3()
        {
            int et1 = 20;
            int et2 = 28;
            int et3 = 12;
            string exp = "The triangle is valid and is a SCALENE";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]

        public void Scalene4()
        {
            int et1 =40;
            int et2 = 56;
            int et3 = 24;
            string exp = "The triangle is valid and is a SCALENE";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]

        public void Scalene5()
        {
            int et1 = 80;
            int et2 = 112;
            int et3 = 48;
            string exp = "The triangle is valid and is a SCALENE";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]

        public void Zeroside1()
        {
            int et1 = 80;
            int et2 = 0;
            int et3 = 48;
            string exp = "At least one side of your triangle has a zero length and is thus invalid";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]

        public void Zeroside2()
        {
            int et1 = 80;
            int et2 = 112;
            int et3 = 0;
            string exp = "At least one side of your triangle has a zero length and is thus invalid";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
        [Test]

        public void Zeroside3()
        {
            int et1 = 0;
            int et2 = 112;
            int et3 = 48;
            string exp = "At least one side of your triangle has a zero length and is thus invalid";
            string real = Triangle.AnalyzeTriangle(et1, et2, et3);
            Assert.AreEqual(exp, real);
        }
    }
}
