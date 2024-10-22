using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchingWordsFile.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void FindWordInFile_WordFound_True()
        {
            FileManager fileManager = new FileManager();
            bool actual = fileManager.FindWordInFile("search_file.txt", "ОАИП");
            Assert.IsTrue(actual);
        }
    }
}