using System.Collections.Generic;
using VirusSim.Models;

namespace VirusSim.Data
{
    public interface IPersonAgeInfoProvider
    {
        IEnumerable<PersonAgeInfo> Filter();
    }
}