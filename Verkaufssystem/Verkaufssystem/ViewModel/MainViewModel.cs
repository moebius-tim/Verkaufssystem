using Verkaufssystem.Helper;
using Verkaufssystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataAccess;

namespace Verkaufssystem.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        BaseViewModel _currentViewModel = new HomeViewModel();

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentViewModel"));
            }
        }


        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }



        public ICommand UpdateViewCommand { get; set; }





        // DB Connection
        //DBAcess dba = DBAcess.GetObject();
        //dba.connectionStringDB ("qwertzasdf");


    }
}
