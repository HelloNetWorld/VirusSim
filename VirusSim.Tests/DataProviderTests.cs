using Shared;
using VirusSim.Data;
using VirusSim.Models;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace VirusSim.Tests
{
    [TestFixture]
    public class DataProviderTests
    {
        private DataProvider<Person> _personProvider;
        private DataProvider<Contact> _contactProvider;
        [SetUp]
        public void SetUp()
        {
            // Arrange
            _personProvider = new DataProvider<Person>(Constants.LOCAL_DATA_DIRECTORY + Constants.BIG_DATA_PERSONS_PATH );
            _contactProvider = new DataProvider<Contact>(Constants.LOCAL_DATA_DIRECTORY + Constants.BIG_DATA_CONTACTS_PATH);
        }

        [Test]
        public void IsDataProvider_ReturnEqualPerson()
        {
            int count = 10;
            // Act
            var result = _personProvider.LoadObjects( 9, count );

            // Assert
            Assert.IsNotNull( result );
            Assert.AreEqual( result.Count, count );

            // Act
            var person = result.ToArray()[0];

            // Assert
            Assert.AreEqual(person.Id, 42489);
            Assert.AreEqual(person.Name, "Пономарёв Илларион" );
            Assert.AreEqual(person.Age, 80 );
        }

        [Test]
        public void IsDataProvider_ReturnPersons()
        {
            int count = 100;
            // Act
            var result = _personProvider.LoadObjects( 100, count );

            // Assert
            Assert.IsNotNull( result );
            Assert.AreEqual( result.Count(), count );
        }

        [Test]
        public void CanDataProvider_CountPersons()
        {
            // Act
            var result = _contactProvider.FetchCount();

            // Assert
            Assert.Greater( result, 0 );
            TestContext.Out.WriteLine( $"Количество объектов = {result}" );
        }

        [Test]
        public void IsDataProvider_ReturnEqualContact()
        {
            int count = 10;
            // Act
            var result = _contactProvider.LoadObjects(9, count);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, count);

            // Act
            var contact = result.ToArray()[0];


            Contact fakeContact = new Contact()
            {
                From = new DateTime(2020, 02, 07, 11, 42, 53),
                To = new DateTime(2020, 02, 07, 12, 00, 37),
                Member1_ID = 2641567,
                Member2_ID = 963374
            };

            TestContext.Out.WriteLine($"{contact.From}");
            TestContext.Out.WriteLine($"{contact.To}");
            TestContext.Out.WriteLine($"{contact.Member1_ID}");
            TestContext.Out.WriteLine($"{contact.Member2_ID}");

            // Assert
            Assert.AreEqual(contact.From,       fakeContact.From);
            Assert.AreEqual(contact.To,         fakeContact.To);
            Assert.AreEqual(contact.Member1_ID, fakeContact.Member1_ID);
            Assert.AreEqual(contact.Member2_ID, fakeContact.Member2_ID);
        }

        [Test]
        public void IsDataProvider_ReturnContact()
        {
            int count = 100;
            // Act
            var result = _contactProvider.LoadObjects(100, count);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count(), count);
        }

        [Test]
        public void CanDataProvider_CountContact()
        {
            // Act
            var result = _contactProvider.FetchCount();

            // Assert
            Assert.Greater(result, 0);
            TestContext.Out.WriteLine($"Количество объектов = {result}");
        }

    }
}
