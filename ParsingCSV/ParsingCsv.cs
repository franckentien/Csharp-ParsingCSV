// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParsingCsv.cs" company="Franck CAYZAC">
//   MIT
// </copyright>
// <summary>
//   The parsing csv.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ParsingCSV
{
    using System;
    using System.IO;
    
    /// <summary>
    /// The parsing csv.
    /// </summary>
    public class ParsingCsv
    {
        /// <summary>
        /// The path.
        /// </summary>
        private static readonly string Path = Directory.GetCurrentDirectory();

        private static int nbValueLine;


        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            ReadCsv("sample.csv");
            Console.ReadLine();
        }

        /// <summary>
        /// The read csv.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        private static void ReadCsv(string fileName)
        {
  
            // get file content
            string[] lines = System.IO.File.ReadAllLines(Path + "/" + fileName, System.Text.Encoding.GetEncoding("iso-8859-1"));

            Checkfile(lines);


            // display file content in console for test.
            foreach (var line in lines)
            {
                var values = line.Split(';');

                //Console.WriteLine("New line");

                foreach (var value in values)
                {
                    //Console.WriteLine("Value: ");
                    //Console.WriteLine(value);
                }
            }
        }

        /// <summary>
        /// check if all line have the same number of value
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool Checkfile(string [] lines)
        {

            var splitedLine = lines[0].Split(';');
            nbValueLine = splitedLine.Length;

            foreach (var line in lines)
            {
                var values = line.Split(';');

                foreach (var value in values)
                {
                    //TODO Check the number of value and return true or false 
                }
            }

            return false;
        }

        /// <summary>
        /// The write csv.
        /// </summary>
        private static void WriteCsv()
        {

        }
    }
}