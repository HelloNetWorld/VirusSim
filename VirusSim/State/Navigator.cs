using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using VirusSim.Commands;
using VirusSim.ViewModels;

namespace VirusSim.State
{
    public class Navigator : INavigator, INotifyPropertyChanged
    {
        private ViewModelBase _currentViewModel = Ioc.Resolve<DefaultViewModel>();
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public void OnPropertyChanged( [CallerMemberName]string prop = "" )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( prop ) );
        }

        public ICommand UpdateCurrentViewModel => new UpdateCurrentViewCommand(this);

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
