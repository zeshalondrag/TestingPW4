using System;
using System.Collections.Generic;
using System.IO;

namespace SearchingWordsFile
{
    public class FileDataObject
    {
        public List<string> GetWords()
        {
            string path = "C:\\Users\\yaney\\source\\repos\\SearchingWordsFile\\search_file.txt";

            List<string> words = new List<string>();

            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                words.AddRange(content.Split(new[] { ' ', '\n', '\r', '\t', ',', '.', ';', ':' }, StringSplitOptions.RemoveEmptyEntries));
            }
            else
            {
                throw new FileNotFoundException($"Файл {path} не найден.");
            }
            return words;
        }
    }
}