using System;
using System.IO;

namespace DotnetCleanApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cleaning...");

            try
            {
                if (Directory.Exists("./bin"))
                    Directory.Delete("./bin", true);

                if (Directory.Exists("./obj"))
                    Directory.Delete("./obj", true);

                Console.WriteLine("Clean successful");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error while performing clean operation");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
