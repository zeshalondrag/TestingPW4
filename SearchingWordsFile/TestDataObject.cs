using System.Collections.Generic;

namespace SearchingWordsFile
{
    public class TestDataObject
    {
        public List<string> GetWords()
        {
            List<string> list = new List<string>
            {
                "Программирование",
                "Машинное",
                "Обучение",
                "ОАИП",
                "Алгоритмы",
            };

            return list;
        }
    }
}