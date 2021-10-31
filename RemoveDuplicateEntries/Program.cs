using System;

namespace RemoveDuplicateEntries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the test case below");
           var TestValue = Console.ReadLine();
            string output = RemoveDuplicateChar(TestValue);

            Console.WriteLine(output);
        }

        static string RemoveDuplicateChar(string Key)
        {
            // The goal here is to remove duplicate chars using string concatination

            // Store all letters encountered in this string 
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in Key.ToLower())
            {
                // Check if Character is in table
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;

                }
            }
            return result;
        }
    }
}
