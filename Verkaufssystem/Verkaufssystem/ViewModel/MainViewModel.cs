using Verkaufssystem.Helper;
using Verkaufssystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Verkaufssystem.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        BaseViewModel _currentViewModel = new HomeViewModel();

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

        public ICommand UpdateViewCommand { get; set; }


        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentViewModel"));
            }
        }
    }
}
