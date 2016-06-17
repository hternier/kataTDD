namespace kataTDD.Service
{
    using kataTDD.Contract;

    /// <summary>
    /// The <see cref="FizzBuzzService"/> service implementation
    /// </summary>
    public class FizzBuzzService : IFizzBuzzService
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        
        /// <inheritDoc/>
        public string GetFizz(int number)
        {
            var result = number % 3;
            return result == 0 ? FIZZ : string.Empty;
        }

        /// <inheritDoc/>
        public string GetBuzz(int number)
        {
            var result = number % 5;
            return result == 0 ? BUZZ : string.Empty;
        }

        /// <inheritDoc/>
        public string GetFizzBuzz(int number)
        {
            return GetFizz(number) + GetBuzz(number);
        }
    }
}
