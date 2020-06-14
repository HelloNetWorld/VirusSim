using System.Collections.Generic;
using VirusSim.Models;

namespace VirusSim.Data
{
    public interface IFilteredContactsProvider
    {
        IEnumerable<Contact> SelectMoreThen(int contactTime);
    }
}