using NUnit.Framework;
using TestMaximumGenerics;

namespace TestMaximumInteger
{
    public class IntegerMaxTest 
    {
        [SetUp]
        public void Setup()
        {
        }
        //TC1.1:-Test data has Max Number in the First Position
        [Test]
        public void Maximum_ValueAt_First_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            //act
            int actual = maximum.FindMaximumNumber(firstValue, secondValue, thirdValue);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //TC1.2:-Test data has Max Number in the Second Position
        [Test]
        public void Maximum_ValueAt_Second_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            //act
            int actual = maximum.FindMaximumNumber(firstValue, secondValue, thirdValue);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //TC1.3:-Test data has Max Number in the Third Position
        [Test]
        public void Maximum_ValueAt_Third_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            int firstValue = 10, secondValue = 20, thirdValue = 30;
            int expected = 30;
            //act
            int actual = maximum.FindMaximumNumber(firstValue, secondValue, thirdValue);
            //assert
            Assert.AreEqual(expected, actual);
        }//End of TC1:-TC1.1/TC1.2/TC1.3



    }
}