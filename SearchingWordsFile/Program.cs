using System;

namespace SearchingWordsFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "search_file.txt";
            string wordTofile = "ОАИП";

            FileManager manager = new FileManager();

            if (manager.FindWordInFile(fileName, wordTofile))
            {
                Console.WriteLine("Слово \"{0}\" найдено в файле {1}!", wordTofile, fileName);
            }
            else
            {
                Console.WriteLine("Слово \"{0}\" не найдено в файле {1}.", wordTofile, fileName);
            }
            Console.ReadKey();
        }
    }
}