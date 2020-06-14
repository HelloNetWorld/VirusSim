using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace VirusSim.Data
{
    public class DataProvider<T> : IDataProvider<T> where T : class
    {
        private readonly string _filePath;

        public DataProvider(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Загружает определённое количество объектов Т начиная с заданного индекса.
        /// Возвращает null, если начиная с заданного стартового индекса объектов не существует.
        /// </summary>
        public IList<T> LoadObjects(int startIndex, int count)
        {
            if (startIndex < 0) throw new IndexOutOfRangeException(nameof(startIndex));
            if (count < 0) throw new IndexOutOfRangeException(nameof(count));
            if (count == 0) return null;
            int currentIndex = 0;
            IList<T> objs = new List<T>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    reader.SupportMultipleContent = true;
                    reader.DateFormatString = "dd.MM.yyyy H:mm:ss";
                    reader.DateParseHandling = DateParseHandling.DateTime;

                    var serializer = new JsonSerializer();

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartObject && objs.Count < count)
                        {
                            currentIndex++;
                            T obj = serializer.Deserialize<T>(reader);

                            if (currentIndex > startIndex && objs.Count < count)
                            {
                                objs.Add(obj);
                            }
                        }

                        if (objs.Count == count)
                        {
                            break;
                        }
                    }
                }
            }

            return objs;
        }

        /// <summary>
        /// Подсчитывает общее количество объектов.
        /// </summary>
        /// <returns></returns>
        public int FetchCount()
        {
            int total = 0;
            // 
            using (StreamReader sr = new StreamReader(_filePath))
            {
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    reader.SupportMultipleContent = true;

                    var serializer = new JsonSerializer();
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            total++;
                        }
                    }
                }
            }
            return total;
        }


    }
}
