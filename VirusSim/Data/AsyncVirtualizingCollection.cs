using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirusSim.Data
{
    public class AsyncVirtualizingCollection<T> : VirtualizingCollection<T>, INotifyPropertyChanged, INotifyCollectionChanged
        where T : class
    {
        private volatile bool _isLoading;

        public AsyncVirtualizingCollection(IDataProvider<T> data) : base(data)
        {
        }

        #region INotifyCollectionChanged implementation
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) =>
            CollectionChanged?.Invoke(this, e);

        private void FireCollectionReset() =>
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        #endregion

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) =>
            PropertyChanged?.Invoke(this, e);

        private void FirePropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        #endregion

        protected async override void LoadCount()
        {
            Count = 0;
            IsLoading = true;
            Count = await Task.Factory.StartNew(() => FetchCount());
            IsLoading = false;
            FireCollectionReset();
        }

        protected async override void LoadPage(int index)
        {
            IsLoading = true;
            await Task.Factory.StartNew(() =>
            {
                var page = FetchPage(index);
                PopulatePage(index, page);
            });
            IsLoading = false;
            FireCollectionReset();
        }


        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                if (value != _isLoading)
                {
                    _isLoading = value;
                    FirePropertyChanged("IsLoading");
                }
            }
        }
    }
}
