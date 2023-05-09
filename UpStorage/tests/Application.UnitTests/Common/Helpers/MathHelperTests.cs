using Application.Common.Helpers;

namespace Application.UnitTests.Common.Helpers
{
    public class MathHelperTests
    {
        [Fact]

        public void IsEven_Returns_True()
        {
            //Arrange
            var mathHelper = new MathHelper();

            int evenNumber = 6;
            int secondEvenNumber = 82;

            //Act
            var result = mathHelper.IsEven(evenNumber);

            var secondResult = mathHelper.IsEven(secondEvenNumber);

            //Assert
            Assert.True(result);
            Assert.True(secondResult);
            Assert.NotNull(result);
        }

        [Fact]

        public void IsEven_Returns_False()
        {
            //Arrange
            var mathHelper = new MathHelper();

            int oddNumber = 1;
            int secondOddNumber = 11;

            //Act
            var result = mathHelper.IsEven(oddNumber);

            var secondResult = mathHelper.IsEven(secondOddNumber);

            //Assert
            Assert.False(result);
            Assert.False(secondResult);
            Assert.NotNull(result);
        }

        [Fact]

        public void Add_Returns_True()
        {
            //Arrange
            var mathHelper = new MathHelper();

            int firstNumber = 13;
            int secondOddNumber = 18;

            //Act
            var result = mathHelper.Add(firstNumber,secondOddNumber);


            //Assert
            Assert.Equal(31,result);

            Assert.NotEqual(5,result);

            
        }
    }
}
