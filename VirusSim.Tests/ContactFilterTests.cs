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
    public class ContactFilterTests
    {
        private FilteredContactsProvider _contactFilter;
        [SetUp]
        public void SetUp()
        {
            // Arrange
            _contactFilter = new FilteredContactsProvider(Constants.LOCAL_DATA_DIRECTORY + Constants.BIG_DATA_CONTACTS_PATH);
        }

        [Test]
        public void ContactFilter_Filter()
        {
            // Act
            var result = _contactFilter.SelectMoreThen(10);
            var count = 0;

            foreach (var item in result)
            {
                count++;
            }

            TestContext.Out.WriteLine($"{count}");

            // Assert
            Assert.Greater(count, 10000);
        }
    }
}
