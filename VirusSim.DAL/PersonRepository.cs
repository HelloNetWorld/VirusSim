using Shared;
using System;
using System.Collections.Generic;
using VirusSim.Data;
using VirusSim.Models;

namespace VirusSim.DAL
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly DataProvider<Person> _dataLoader;

        public PersonRepository()
        {
            _dataLoader = new DataProvider<Person>(Constants.BIG_DATA_PERSONS_PATH);
        }

        public IEnumerable<Person> Entities => null;
        public IEnumerable<Person> EntitiesReadOnly => throw new NotImplementedException();
        public void Delete( Person entity )
        {
            throw new NotImplementedException();
        }

        public Person GetById( object id )
        {
            throw new NotImplementedException();
        }

        public void Insert( Person entity )
        {
            throw new NotImplementedException();
        }

        public void Update( Person entity )
        {
            throw new NotImplementedException();
        }
    }
}
