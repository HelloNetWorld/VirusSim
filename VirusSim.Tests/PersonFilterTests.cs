using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shared;
using VirusSim.Data;

namespace VirusSim.Tests
{
    public class PersonFilterTests
    {
        private PersonAgeInfoProvider _personFilter;
        [SetUp]
        public void SetUp()
        {
            // Arrange
            _personFilter = new PersonAgeInfoProvider(Constants.LOCAL_DATA_DIRECTORY + Constants.BIG_DATA_PERSONS_PATH);
        }

        [Test]
        public void PersonFilter_Filter()
        {
            // Act
            var result = _personFilter.Filter();
            var count = 0;

            TestContext.Out.WriteLine($"   Name   |    Count    |    Total    |    Average   ");
            
            foreach (var item in result)
            {
                TestContext.Out.WriteLine($"{item.Name} | {item.Count} | {item.Total} | {item.Average}");
                count += item.Count;
            }

            // Assert
            Assert.AreEqual(count, 1024);
        }
    }
}
