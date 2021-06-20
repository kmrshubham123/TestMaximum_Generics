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
         //TC2.1:-The test data has Max Number in the first Position
        [Test]
        public void MaximumFloat_ValueAt_First_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            double firstValue = 30.5, secondValue = 20.5, thirdValue = 10.5;
            double expected = 30.5;
            //act
            double actual = maximum.FindMaximumFloatNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        //TC2.2:-The test data has Max Number in the Second Position
        [Test]
        public void MaximumFloat_ValueAt_Second_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            double firstValue = 20.5, secondValue = 30.5, thirdValue = 10.5;
            double expected = 30.5;
            //act
            double actual = maximum.FindMaximumFloatNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        //TC2.3:-The test data has Max Number in the Third Position
        [Test]
        public void MaximumFloat_ValueAt_Third_Parameter_Return_Maximum_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            double firstValue = 10.5, secondValue = 20.5, thirdValue = 30.5;
            double expected = 30.5;
            //act
            double actual = maximum.FindMaximumFloatNumber(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }//End of TC2:-TC2.1/TC2.2/TC2.3
         //TC3.1:-The test data has Longest Word in the first Position
        [Test]
        public void LongestString_ValueAt_First_Parameter_Return_Highest_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            string firstString = "Pomegranate", secondString = "Apple", thirdString = "Banana";
            string expected = "Pomegranate";
            //act
            string actual = maximum.FindLongestString(firstString, secondString, thirdString);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        //TC3.2:-The test data has Longest Word in the Second Position
        [Test]
        public void LongestString_ValueAt_Second_Parameter_Return_Highest_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            string firstString = "Apple", secondString = "Pomegranate", thirdString = "Banana";
            string expected = "Pomegranate";
            //act
            string actual = maximum.FindLongestString(firstString, secondString, thirdString);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }
        //TC3.3:-The test data has Longest Word in the Third Position
        [Test]
        public void LongestString_ValueAt_Third_Parameter_Return_Highest_Value()
        {
            MaximumNumber maximum = new MaximumNumber();
            //Arrange
            string firstString = "Apple", secondString = "Banana", thirdString = "Pomegranate";
            string expected = "Pomegranate";
            //act
            string actual = maximum.FindLongestString(firstString, secondString, thirdString);
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.Pass();
        }//End of TC3:-TC3.1/TC3.2/TC3.3

        //Refactor 1:- 3 to one Generic Method
        [Test]
        public void MaximumInt_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            int firstValue = 30, secondValue= 20, thirdValue = 10;
            int expected = 30;
            //Act
            int result = MaximumNumber.MaxValue<int>(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumFloat_ValueAt_SecondParameter_Return_Highest_value()
        {
            //Arrange
            float firstValue = 19.99f, secondValue = 20.5f, thirdValue = 10.98f;
            float expected = 20.5f;
            //Act
            float result = MaximumNumber.MaxValue<float>(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
        [Test]
        public void MaximumString_ValueAt_ThirdParameter_Return_Highest_value()
        {
            //Arrange
            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Pomegranate";
            string expected = "Pomegranate";
            //Act
            string result = MaximumNumber.MaxValue<string>(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
        //Refactor 2:- create Generic Class and new test case to use the Generic Class
        [Test]
        public void MaxInt_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            //Act
            int result = GenericMaximum<int>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
        [Test]
        public void MaxFloat_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            float firstValue = 30.50f, secondValue = 20.99f, thirdValue = 10.68f;
            float expected = 30.50f;
            //Act
            float result = GenericMaximum<float>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
        [Test]
        public void MaxString_ValueAt_FirstParameter_Return_Highest_value()
        {
            //Arrange
            string firstValue = "Pomegranate", secondValue = "Apple", thirdValue = "Banana";
            string expected = "Pomegranate";
            //Act
            string result = GenericMaximum<string>.MaxValue(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }



    }
}