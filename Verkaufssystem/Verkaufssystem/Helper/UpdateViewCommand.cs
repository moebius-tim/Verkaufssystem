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
            if (parameter.ToString() == "Home")
                _viewModel.CurrentViewModel = new HomeViewModel();
            else if (parameter.ToString() == "List")
                _viewModel.CurrentViewModel = new ListViewModel();
        }
    }
}
