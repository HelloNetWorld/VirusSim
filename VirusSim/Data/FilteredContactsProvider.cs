using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using VirusSim.Models;

namespace VirusSim.Data
{
    public class FilteredContactsProvider : IFilteredContactsProvider
    {
        private readonly string _filePath;

        public FilteredContactsProvider(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Возвращает все контакты которые длились выше указанного минутах.
        /// </summary>
        /// <param name="contactTimeInMinutes"> Время длительности контакта в минутах</param>
        /// <returns></returns>
        public IEnumerable<Contact> SelectMoreThen(int contactTimeInMinutes)
        {
            if (contactTimeInMinutes < 0) throw new IndexOutOfRangeException(nameof(contactTimeInMinutes));

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
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            var obj = serializer.Deserialize<Contact>(reader);
                            if ((obj.To - obj.From).TotalMinutes >= contactTimeInMinutes)
                            {
                                yield return obj;
                            }
                        }
                    }
                }
            }
        }
    }
}
