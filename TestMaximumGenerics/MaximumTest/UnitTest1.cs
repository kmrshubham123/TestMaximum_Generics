using NUnit.Framework;
using TestMaximumGenerics;

namespace MaximumTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //TC1.1:-The test data has Max Number in the first Position
        [Test]
        public void Maximum_ValueAt_First_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            //act
            int actual = maximum.FindMaximumNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        //TC1.2:-The test data has Max Number in the Second Position
        [Test]
        public void Maximum_ValueAt_Second_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            //act
            int actual = maximum.FindMaximumNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        //TC1.3:-The test data has Max Number in the Third Position
        [Test]
        public void Maximum_ValueAt_Third_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            int firstValue = 20, secondValue = 20, thirdValue = 30;
            int expected = 30;
            //act
            int actual = maximum.FindMaximumNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }//End of TC1:-TC1.1/TC1.2/TC1.3
    }
}