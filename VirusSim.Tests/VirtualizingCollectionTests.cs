using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusSim.Models;
using VirusSim.Data;
using Shared;

namespace VirusSim.Tests
{
    public class VirtualizingCollectionTests
    {
        private VirtualizingCollection<Person> _virtPersons;
        private DataProvider<Person> _dataLoader;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _dataLoader = new DataProvider<Person>(Constants.LOCAL_DATA_DIRECTORY + Constants.BIG_DATA_PERSONS_PATH );
            _virtPersons = new VirtualizingCollection<Person>( _dataLoader );
        }

        [Test]
        public void VirtualizingCollection_Count()
        {
            // Act
            var result = _virtPersons.Count;
            TestContext.Out.WriteLine( $"Количество объектов = {result}" );

            // Assert
            Assert.AreEqual( result, 1024 );
        }

        [Test]
        public void VirtualizingCollection_Indexer()
        {
            var person = _virtPersons[9];
            // Assert
            Assert.AreEqual( person.Id, 42489 );
            Assert.AreEqual( person.Name, "Пономарёв Илларион" );
            Assert.AreEqual( person.Age, 80 );
            // Output
            TestContext.Out.WriteLine( $"Id = {person.Id}" );
            TestContext.Out.WriteLine( $"Name = {person.Name}" );
            TestContext.Out.WriteLine( $"Age = {person.Age}" );
        }

        [Test]
        public void VirtualizingCollection_FirstElement()
        {
            var person = _virtPersons[0];

            var firstPerson = new Person()
            {
                Id = 5942,
                Name = "Григорьев Гордий",
                Age = 29
            };
            // Assert
            Assert.AreEqual( person.Id, firstPerson.Id );
            Assert.AreEqual( person.Name, firstPerson.Name );
            Assert.AreEqual( person.Age, firstPerson.Age );
            // Output
            TestContext.Out.WriteLine( $"Id = {person.Id}" );
            TestContext.Out.WriteLine( $"Name = {person.Name}" );
            TestContext.Out.WriteLine( $"Age = {person.Age}" );
        }

        [Test]
        public void VirtualizingCollection_LastElement()
        {
            var person = _virtPersons[_virtPersons.Count - 1];
            var lastPerson = new Person()
            {
                Id = 5176851,
                Name = "Талалихина Светлана",
                Age = 61
            };

            // Assert
            Assert.AreEqual( person.Id, lastPerson.Id );
            Assert.AreEqual( person.Name, lastPerson.Name );
            Assert.AreEqual( person.Age, lastPerson.Age );

            // Output
            TestContext.Out.WriteLine( $"Id = {person.Id}" );
            TestContext.Out.WriteLine( $"Name = {person.Name}" );
            TestContext.Out.WriteLine( $"Age = {person.Age}" );
        }
    }
}
