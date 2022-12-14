using Verkaufssystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Verkaufssystem.Helper
{
    public class UpdateViewCommand : ICommand
    {
        MainViewModel _viewModel;
        public event EventHandler CanExecuteChanged;

        public UpdateViewCommand(MainViewModel mvm)
        {
            _viewModel = mvm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Startseite")
                _viewModel.CurrentViewModel = new HomeViewModel();
            else if (parameter.ToString() == "Nike")
                _viewModel.CurrentViewModel = new NikeViewModel();
            else if (parameter.ToString() == "Lagerbestand")
                _viewModel.CurrentViewModel = new LagerbestandViewModel();
        }
    }
}
