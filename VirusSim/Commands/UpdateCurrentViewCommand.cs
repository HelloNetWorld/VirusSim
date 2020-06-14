using System;
using System.Windows.Input;
using VirusSim.State;
using VirusSim.ViewModels;

namespace VirusSim.Commands
{
    public class UpdateCurrentViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator _navigator;

        public UpdateCurrentViewCommand( INavigator navigator )
        {
            _navigator = navigator;
        }

        public bool CanExecute( object parameter )
        {
            return true;
        }

        public void Execute( object parameter )
        {
            if (parameter is ViewType viewType)
            {
                switch (viewType)
                {
                    case ( ViewType.OverView ):
                        _navigator.CurrentViewModel = ViewModelLocator.OverViewViewModel;
                        break;
                    case ( ViewType.ContactFilter ):
                        _navigator.CurrentViewModel = ViewModelLocator.ContactFilterViewModel;
                        break;
                    case ( ViewType.Age ):
                        _navigator.CurrentViewModel = ViewModelLocator.AgeViewModel;
                        break;
                }
            }
        }
    }
}
