namespace kataTDD.Test
{
    using kataTDD.Contract;
    using kataTDD.Service;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzTest
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        private const string FIZZBUZZ = "FizzBuzz";

        private IFizzBuzzService _fizzBuzzService;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        public void FizzBuzzService_GetFizz_WithMultiplesOfThree_ReturnFizz()
        {
            // Arrange
            int number = 6;

            // Act
            string result = _fizzBuzzService.GetFizz(number);

            //Assert
            Assert.AreEqual(FIZZ, result);
        }

        [TestMethod]
        public void FizzBuzzService_GetFizz_WithNoMultiplesOfThree_ReturnEmptyString()
        {
            // Arrange
            int number = 2;

            // Act
            string result = _fizzBuzzService.GetFizz(number);

            //Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void FizzBuzzService_GetBuzz_WithMultiplesOfFive_ReturnBuzz()
        {
            // Arrange
            int number = 5;

            // Act
            string result = _fizzBuzzService.GetBuzz(number);

            //Assert
            Assert.AreEqual(BUZZ, result);
        }

        [TestMethod]
        public void FizzBuzzService_GetBuzz_WithNoMultiplesOfFive_ReturnEmptyString()
        {
            // Arrange
            int number = 2;

            // Act
            string result = _fizzBuzzService.GetFizz(number);

            //Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void FizzBuzzService_GetFizzBuzz_WithMultiplesOfThreeAndFive_ReturnFizzBuzz()
        {
            // Arrange
            int number = 15;

            // Act
            string result = _fizzBuzzService.GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(FIZZBUZZ, result);
        }

        [TestMethod]
        public void FizzBuzzService_GetFizzBuzz_WithNoMultiplesOfThreeAndFive_ReturnEmptyString()
        {
            // Arrange
            int number = 14;

            // Act
            string result = _fizzBuzzService.GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}
