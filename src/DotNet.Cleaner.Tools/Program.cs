using System;
using System.Collections.Generic;
using System.IO;

namespace DotNet.Cleaner.Tools
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cleaning...");

            try
            {
                DirSearch(".");
                foreach (var d in DeletionList)
                    Directory.Delete(d, true);

                Console.WriteLine("Clean successful");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error while performing clean operation");
                Console.WriteLine(ex.Message);
            }
        }

        private static List<String> DeletionList { get; set; } = new List<string>();
        private static void DirSearch(string dir)
        {
            foreach (var dirName in Directory.GetDirectories(dir))
            {
                if (dirName.EndsWith("bin") || dirName.EndsWith("obj"))
                    DeletionList.Add(dirName);
                DirSearch(dirName);
            }            
        }
    }
}
