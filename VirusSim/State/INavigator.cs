using System.Windows.Input;
using VirusSim.ViewModels;

namespace VirusSim.State
{
    public enum ViewType
    {
        OverView,
        ContactFilter,
        Age
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModel { get; }
    }
}