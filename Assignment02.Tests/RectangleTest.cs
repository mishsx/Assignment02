using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    class RectangleTest
    {

        //Test Case #1
        [Test]
        public void GetLength_15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(15, 20, 25);

            //Act
            int result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(result, 15);
        }

        //Test Case #2
        [Test]
        public void GetLength_Neg1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(-1, 20, 25);

            //Act
            int result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #3
        [Test]
        public void GetLength_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(0, 20, 25);

            //Act
            int result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #4
        [Test]
        public void SetLength_15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetLength(15);

            //Assert
            Assert.AreEqual(result, 15);
        }

        //Test Case #5
        [Test]
        public void SetLength_Neg1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetLength(-1);

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #6
        [Test]
        public void SetLength_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetLength(0);

            //Assert
            Assert.AreEqual(result, 0);
        }


        //Test Case #7
        [Test]
        public void GetWidth_15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(20, 15, 25);

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(result, 15);
        }


        //Test Case #8
        [Test]
        public void GetWidth_Neg1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(20, -1, 25);

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #9
        [Test]
        public void GetWidth_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(20, 0, 25);

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #10
        [Test]
        public void SetWidth_15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetWidth(15);

            //Assert
            Assert.AreEqual(result, 15);
        }

        //Test Case #11
        [Test]
        public void SetWidth_Neg1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetWidth(-1);

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #12
        [Test]
        public void SetWidth_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetWidth(0);

            //Assert
            Assert.AreEqual(result, 0);
        }


        //Test Case #13
        [Test]
        public void GetHeight_15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(20, 25, 15);

            //Act
            int result = rectangle.GetHeight();

            //Assert
            Assert.AreEqual(result, 15);
        }


        //Test Case #14
        [Test]
        public void GetHeight_Neg1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(20, 15, -1);

            //Act
            int result = rectangle.GetHeight();

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #15
        [Test]
        public void GetHeight_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(20, 25, 0);

            //Act
            int result = rectangle.GetHeight();

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #16
        [Test]
        public void SetHeight_15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetHeight(15);

            //Assert
            Assert.AreEqual(result, 15);
        }

        //Test Case #17
        [Test]
        public void SetHeight_Neg1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetHeight(-1);

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #18
        [Test]
        public void SetHeight_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.SetHeight(0);

            //Assert
            Assert.AreEqual(result, 0);
        }

        //Test Case #19
        [Test]
        public void GetVolume_input_6_6_6()
        {
            //Arangement
            Rectangle rectangle = new Rectangle(6, 6, 6);

            //Act
            int result = rectangle.GetVolume();

            //Assert
            Assert.AreEqual(result, 216);
        }


        //Test Case #20
        [Test]
        public void GetVolume_input_0_6_12()
        {
            //Arangement
            Rectangle rectangle = new Rectangle(0, 6, 12);

            //Act
            int result = rectangle.GetVolume();
            //Assert
            Assert.AreEqual(result, 0);
        }


        //Test Case #21
        [Test]
        public void Get_Volume_input_Neg1_6_12()
        {
            //Arangement
            Rectangle rectangle = new Rectangle(-1, 6, 12);

            //Act
            int result = rectangle.GetVolume();

            //Assert
            Assert.AreEqual(result, 0);
        }

    }
}
