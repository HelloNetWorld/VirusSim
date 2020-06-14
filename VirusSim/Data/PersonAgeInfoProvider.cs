using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VirusSim.Models;

namespace VirusSim.Data
{
    public class PersonAgeInfoProvider : IPersonAgeInfoProvider
    {
        private readonly string _filePath;

        public PersonAgeInfoProvider(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<PersonAgeInfo> Filter()
        {
            var personAgeInfoList = new List<PersonAgeInfo>();

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
                            Person obj = serializer.Deserialize<Person>(reader);

                            var givenName = obj.Name.Split(null)[1];

                            if (personAgeInfoList.Any((p) => p.Name == givenName))
                            {
                                foreach (var item in personAgeInfoList)
                                {
                                    if (item.Name == givenName)
                                    {
                                        item.Count++;
                                        item.Total += obj.Age;
                                    }
                                }
                            }
                            else
                            {
                                personAgeInfoList.Add(new PersonAgeInfo()
                                {
                                    Name = givenName,
                                    Count = 1,
                                    Total = obj.Age
                                });
                            }
                        }
                    }
                }
            }

            return personAgeInfoList;
        }
    }
}
