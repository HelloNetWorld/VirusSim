using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Shared;
using VirusSim.Data;
using VirusSim.Models;

namespace VirusSim.ViewModels
{
    public class OverViewViewModel : ViewModelBase
    {
        private AsyncVirtualizingCollection<Person> _persons;
        private AsyncVirtualizingCollection<Contact> _contacts;
        private readonly IDataProvider<Person> _personProvider;
        private readonly IDataProvider<Contact> _contactProvider;

        public OverViewViewModel(IDataProvider<Person> personProvider, IDataProvider<Contact> contactProvider)
        {
            _personProvider = personProvider;
            _contactProvider = contactProvider;

            Persons = new AsyncVirtualizingCollection<Person>(_personProvider);
            Contacts = new AsyncVirtualizingCollection<Contact>(_contactProvider);
        }

        public AsyncVirtualizingCollection<Person> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                OnPropertyChanged(nameof(Persons));
            }
        }

        public AsyncVirtualizingCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contacts));
            }
        }
    }
}
