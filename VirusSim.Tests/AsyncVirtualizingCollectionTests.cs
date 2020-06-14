using System.Threading;
using NUnit.Framework;
using Shared;
using VirusSim.Data;
using VirusSim.Models;

namespace VirusSim.Tests
{
    public class AsyncVirtualizingCollectionTests
    {
        private AsyncVirtualizingCollection<Person> _virtPersons;
        private DataProvider<Person> _dataLoader;
        private int _calcDelay;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _dataLoader = new DataProvider<Person>(Constants.LOCAL_DATA_DIRECTORY + Constants.BIG_DATA_PERSONS_PATH);
            _virtPersons = new AsyncVirtualizingCollection<Person>(_dataLoader);
            _calcDelay = 500;
        }

        [Test]
        public void AsyncVirtualizingCollection_Count()
        {
            // Act
            var result = _virtPersons.Count;

            // Ожидаем вычисление.
            Thread.Sleep(_calcDelay);

            result = _virtPersons.Count;
            TestContext.Out.WriteLine($"Количество объектов = {result}");

            // Assert
            Assert.AreEqual(1024, result);

        }

        [Test]
        public void AsyncVirtualizingCollection_Indexer()
        {
            var person = _virtPersons[9];

            // Ожидаем вычисление.
            Thread.Sleep(_calcDelay);

            person = _virtPersons[9];

            // Assert
            Assert.AreEqual(person.Id, 42489);
            Assert.AreEqual(person.Name, "Пономарёв Илларион");
            Assert.AreEqual(person.Age, 80);

            // Output
            TestContext.Out.WriteLine($"Id = {person.Id}");
            TestContext.Out.WriteLine($"Name = {person.Name}");
            TestContext.Out.WriteLine($"Age = {person.Age}");

        }

        [Test]
        public void AsyncVirtualizingCollection_FirstElement()
        {
            var person = _virtPersons[0];

            // Ожидаем вычисление.
            Thread.Sleep(_calcDelay);

            person = _virtPersons[0];

            var firstPerson = new Person()
            {
                Id = 5942,
                Name = "Григорьев Гордий",
                Age = 29
            };

            // Assert
            Assert.AreEqual(person.Id, firstPerson.Id);
            Assert.AreEqual(person.Name, firstPerson.Name);
            Assert.AreEqual(person.Age, firstPerson.Age);

            // Output
            TestContext.Out.WriteLine($"Id = {person.Id}");
            TestContext.Out.WriteLine($"Name = {person.Name}");
            TestContext.Out.WriteLine($"Age = {person.Age}");

        }

        [Test]
        public void AsyncVirtualizingCollection_LastElement()
        {

            // Запуск вычисления Count в парал. потоке.
            var count = _virtPersons.Count;
            // Ожидаем вычисление.
            Thread.Sleep(_calcDelay);
            // Получаем значение Count
            count = _virtPersons.Count;

            // Запуск вычисления Count в парал. потоке.
            var person = _virtPersons[ count - 1];
            // Ожидаем вычисление.
            Thread.Sleep(_calcDelay);
            // Получаем объект.
            person = _virtPersons[count - 1];

            var lastPerson = new Person()
            {
                Id = 5176851,
                Name = "Талалихина Светлана",
                Age = 61
            };

            // Assert
            Assert.AreEqual(person.Id, lastPerson.Id);
            Assert.AreEqual(person.Name, lastPerson.Name);
            Assert.AreEqual(person.Age, lastPerson.Age);

            // Output
            TestContext.Out.WriteLine($"Id = {person.Id}");
            TestContext.Out.WriteLine($"Name = {person.Name}");
            TestContext.Out.WriteLine($"Age = {person.Age}");

        }
    }
}
