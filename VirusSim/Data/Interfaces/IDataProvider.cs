using System.Collections.Generic;

namespace VirusSim.Data
{
    public interface IDataProvider<T> where T : class
    {
        int FetchCount();
        IList<T> LoadObjects(int startIndex, int count);
    }
}