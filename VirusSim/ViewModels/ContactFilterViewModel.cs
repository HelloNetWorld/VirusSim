using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Windows.Input;
using VirusSim.BaseClasses;
using VirusSim.Data;
using VirusSim.Extensions;
using VirusSim.Models;

namespace VirusSim.ViewModels
{
    public class ContactFilterViewModel : ViewModelBase
    {
        private readonly IFilteredContactsProvider _filteredContactsProvider;
        private string _contactDuration;
        private int _contactDurationParsed;
        private ObservableCollection<Contact> _contacts;

        public ContactFilterViewModel(IFilteredContactsProvider filteredContactsProvider)
        {
            _filteredContactsProvider = filteredContactsProvider;
        }

        public string ContactDuration
        {
            get
            {
                return _contactDuration;
            }
            set
            {
                _contactDuration = value;
                OnPropertyChanged(nameof(ContactDuration));
            }
        }

        public ICommand CountContacts => new RelayCommand(obj =>
            {
                if (int.TryParse(_contactDuration, out _contactDurationParsed))
                {
                    if (_contactDurationParsed > 0)
                    {
                        Contacts = _filteredContactsProvider.SelectMoreThen(_contactDurationParsed)
                            .ToObservableCollection();
                    };
                }
            });

        public ObservableCollection<Contact> Contacts
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
