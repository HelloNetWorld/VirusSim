using System;
using System.Collections.Generic;
using VirusSim.Models;

namespace VirusSim.DAL
{
    public class ContactReposity : IRepository<Contact>
    {
        public IEnumerable<Contact> Entities => throw new NotImplementedException();

        public IEnumerable<Contact> EntitiesReadOnly => throw new NotImplementedException();

        public void Delete( Contact entity )
        {
            throw new NotImplementedException();
        }

        public Contact GetById( object id )
        {
            throw new NotImplementedException();
        }

        public void Insert( Contact entity )
        {
            throw new NotImplementedException();
        }

        public void Update( Contact entity )
        {
            throw new NotImplementedException();
        }
    }
}
