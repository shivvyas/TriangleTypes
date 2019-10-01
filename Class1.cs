using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methodologies_Assign2;
using NUnit.Framework;


namespace TriangleTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Analyze_InputV1_9_InputV2_5_InputV3_5()
        {
            //Arrange
            int v1 = 9;
            int v2 = 5;
            int v3 = 5;
            string str1 = "It is an isosceles triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }
        [Test]
        public void Analyze_InputV1_20_InputV2_4_InputV3_20()
        {
            //Arrange
            int v1 = 20;
            int v2 = 4;
            int v3 = 20;
            string str1 = "It is an isosceles triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }

        [Test]
        public void Analyze_InputV1_2_InputV2_3_InputV3_4()
        {
            //Arrange
            int v1 = 2;
            int v2 = 3;
            int v3 = 4;
            string str1 = "It is an scalene triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }

        [Test]
        public void Analyze_InputV1_12_InputV2_16_InputV3_5()
        {
            //Arrange
            int v1 = 12;
            int v2 = 16;
            int v3 = 5;
            string str1 = "It is an scalene triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }
        [Test]
        public void Analyze_InputV1_10_InputV2_10_InputV3_10()
        {
            //Arrange
            int v1 = 10;
            int v2 = 10;
            int v3 = 10;
            string str1 = "It is an equilateral triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }
        [Test]
        public void Analyze_InputV1_50_InputV2_50_InputV3_50()
        {
            //Arrange
            int v1 = 50;
            int v2 = 50;
            int v3 = 50;
            string str1 = "It is an equilateral triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }
        [Test]
        public void Analyze_InputV1_5_InputV2_20_InputV3_50()
        {
            //Arrange
            int v1 = 5;
            int v2 = 20;
            int v3 = 50;
            string str1 = "The values can not form a triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }
        [Test]
        public void Analyze_InputV1_1_InputV2_10_InputV3_40()
        {
            //Arrange
            int v1 = 1;
            int v2 = 10;
            int v3 = 40;
            string str1 = "The values can not form a triangle!!";

            //Act
            string res = TriangleSolver.Analyze(v1, v2, v3);
            //Assert 
            Assert.AreEqual(str1, res);
        }
    }
}
