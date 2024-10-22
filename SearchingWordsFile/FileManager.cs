using System;
using System.Collections.Generic;

namespace SearchingWordsFile
{
    public class FileManager
    {
        public bool FindWordInFile(string fileName, string wordTofile)
        {
            //FileDataObject DataObject = new FileDataObject();
            TestDataObject DataObject = new TestDataObject();

            List<string> words = DataObject.GetWords();

            foreach (var word in words)
            {
                if (word.Equals(wordTofile, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}