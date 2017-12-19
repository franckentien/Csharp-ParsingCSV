namespace ParsingCSV
{
    using System;
    using System.IO;

    /// <summary>
    /// The parsing csv.
    /// </summary>
    public class ParsingCsv
    {
        public static void Main(string[] args)
        {
            ReadCsv();
        }

        private static void ReadCsv()
        {
            string path = Directory.GetCurrentDirectory();

            Console.WriteLine(path);
            Console.ReadLine();
            /*string[] lines = System.IO.File.ReadAllLines();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }*/
        }

        private static void WriteCsv()
        {

        }
    }
}