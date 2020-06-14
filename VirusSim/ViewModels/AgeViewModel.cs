using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Shared;
using VirusSim.BaseClasses;
using VirusSim.Data;
using VirusSim.Extensions;
using VirusSim.Models;

namespace VirusSim.ViewModels
{
    public class AgeViewModel : ViewModelBase
    {
        private ObservableCollection<PersonAgeInfo> _ages;
        private readonly IPersonAgeInfoProvider _personAgeInfoProvider;

        public AgeViewModel(IPersonAgeInfoProvider personAgeInfoProvider)
        {
            _personAgeInfoProvider = personAgeInfoProvider;
        }

        public ObservableCollection<PersonAgeInfo> Ages
        {
            get
            {
                return _ages;
            }
            set
            {
                _ages = value;
                OnPropertyChanged(nameof(Ages));
            }
        }

        public ICommand Calculate =>
            new RelayCommand(obj => 
            {
                Task.Factory.StartNew(() => 
                    Ages = _personAgeInfoProvider.Filter().ToObservableCollection()
                    ); 
            },
            obj => true); // Захардкодил.
    }
}
