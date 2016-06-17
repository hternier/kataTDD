namespace kataTDD.Contract
{
    /// <summary>
    /// The <see cref="IFizzBuzzService"/> interface
    /// </summary>
    public interface IFizzBuzzService
    {
        /// <summary>
        /// Get Fizz if number is an multiple of three
        /// </summary>
        /// <param name="number">The number to test</param>
        /// <returns>Fizz or empty</returns>
        string GetFizz(int number);

        /// <summary>
        /// Get Fizz if number is an multiple of five
        /// </summary>
        /// <param name="number">The number to test</param>
        /// <returns>Buzz or empty</returns>
        string GetBuzz(int number);

        /// <summary>
        /// Get FizzBuzz if number is an multiple of three and five
        /// </summary>
        /// <param name="number">The number to test</param>
        /// <returns>FizzBuzz or empty</returns>
        string GetFizzBuzz(int number);
    }
}
