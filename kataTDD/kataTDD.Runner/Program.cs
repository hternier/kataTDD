namespace kataTDD
{
    using System;

    using kataTDD.Contract;
    using kataTDD.Service;
    
    /// <summary>
    /// The FizzBuzz program
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main FizzBuzz method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();

            for(int i = 1; i < 101; i++)
            {
                Console.WriteLine("Test number: {0}", i);
                Console.WriteLine(fizzBuzzService.GetFizzBuzz(i));
            }

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
