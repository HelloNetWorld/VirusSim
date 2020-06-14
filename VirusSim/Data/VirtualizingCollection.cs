using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusSim.Data
{
    public class VirtualizingCollection<T> : IList<T>, IList where T : class
    {
        private volatile int _count = -1;
        private readonly IDataProvider<T> _dataProvider;
        private readonly Dictionary<int, IList<T>> _pages = new Dictionary<int, IList<T>>();
        private readonly Dictionary<int, DateTime> _pageTouchTimes = new Dictionary<int, DateTime>();

        public VirtualizingCollection( IDataProvider<T> dataProvider )
        {
            _dataProvider = dataProvider;
        }

        #region Ilist
        public virtual int Count
        {
            // Реализация Lazy loading.
            get
            {
                if (_count == -1)
                {
                    LoadCount();
                }
                return _count;
            }
            protected set => _count = value;
        }

        public T this[int index]
        {
            get
            {
                // определяется какая страница и смещение внутри страницы
                int pageIndex = index / PageSize;
                int pageOffset = index % PageSize;

                // запрашивается главную страницу
                RequestPage( pageIndex );

                // если обратились более чем к 50% тогда запрашивается следующая страница
                if (pageOffset > PageSize / 2 && pageIndex < Count / PageSize)
                    RequestPage( pageIndex + 1 );

                // если обратились менее чем к 50% тогда заправшивается предшествующая страница
                if (pageOffset < PageSize / 2 && pageIndex > 0)
                    RequestPage( pageIndex - 1 );

                // удаляется устаревшая страница
                CleanUpPages();

                // защитная проверка в случае асинхронной загрузки
                if (_pages[pageIndex] == null)
                    return default( T );

                // возвращается запрошенный элемент
                return _pages[pageIndex][pageOffset];
            }
            set { throw new NotSupportedException(); }
        }

        object IList.this[int index]
        {
            get { return this[index]; }
            set { throw new NotSupportedException(); }
        }

        #region IEnumerator<T>, IEnumerator

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Add

        public void Add(T item)
        {
            throw new NotSupportedException();
        }

        int IList.Add(object value)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region Contains

        bool IList.Contains(object value)
        {
            return Contains((T)value);
        }

        public bool Contains(T item)
        {
            return false;
        }

        #endregion

        #region Clear

        public void Clear()
        {
            throw new NotSupportedException();
        }

        #endregion

        #region IndexOf

        int IList.IndexOf(object value)
        {
            return IndexOf((T)value);
        }

        public int IndexOf(T item)
        {
            return -1;
        }

        #endregion

        #region Insert
        public void Insert(int index, T item)
        {
            throw new NotSupportedException();
        }

        void IList.Insert(int index, object value)
        {
            Insert(index, (T)value);
        }

        #endregion

        #region Remove
        public void RemoveAt(int index)
        {
            throw new NotSupportedException();
        }

        void IList.Remove(object value)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        /// <returns>
        /// true if <paramref name="item"/> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false. This method also returns false if <paramref name="item"/> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">
        /// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
        /// </exception>
        public bool Remove(T item)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region CopyTo
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region Misc
        public object SyncRoot
        {
            get { return this; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        #endregion
        #endregion

        /// <summary>
        /// Количество элементов на странице.
        /// </summary>
        public int PageSize { get; set; } = 100;

        /// <summary>
        /// Время (в мс) через которое страница будет удалена из памяти.
        /// </summary>
        public int PageTimeout { get; set; } = 10000;

        protected virtual void LoadCount() =>
            Count = FetchCount();

        protected int FetchCount() =>
            _dataProvider.FetchCount();


        protected virtual void RequestPage( int pageIndex )
        {
            if (!_pages.ContainsKey( pageIndex ))
            {
                _pages.Add( pageIndex, null );
                _pageTouchTimes.Add( pageIndex, DateTime.Now );
                LoadPage( pageIndex );
            }
            else
            {
                _pageTouchTimes[pageIndex] = DateTime.Now;
            }
        }

        protected virtual void PopulatePage( int pageIndex, IList<T> page )
        {
            if (_pages.ContainsKey( pageIndex ))
                _pages[pageIndex] = page;
        }

        public void CleanUpPages()
        {
            var keys = new List<int>( _pageTouchTimes.Keys );
            foreach (var key in keys)
            {
                // page 0 is a special case, since the WPF ItemsControl
                // accesses the first item frequently
                if (key != 0 && ( DateTime.Now - _pageTouchTimes[key] ).TotalMilliseconds > PageTimeout)
                {
                    _pages.Remove( key );
                    _pageTouchTimes.Remove( key );
                }
            }
        }

        protected virtual void LoadPage( int pageIndex ) =>
            PopulatePage( pageIndex, FetchPage( pageIndex ) );

        protected IList<T> FetchPage( int pageIndex ) =>
            _dataProvider.LoadObjects( pageIndex * PageSize, PageSize );
    }
}
