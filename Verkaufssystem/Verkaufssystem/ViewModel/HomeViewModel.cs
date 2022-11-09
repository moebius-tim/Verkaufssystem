using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Model;
using DataAccess;

namespace Verkaufssystem.ViewModel
{
    class HomeViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public  event   PropertyChangedEventHandler PropertyChanged;
        private string  _email;
        ICommand        _saveLoginCommand;

        public HomeViewModel()
        {

        }

        public string Benutzername 
        { 
            get
            {
                return _email;
            }
            set 
            {
                _email = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public ICommand SaveLoginCommand
        {
            get
            {
                if (_saveLoginCommand == null)
                    return _saveLoginCommand = new Helper.RelayCommand(c => SaveLogin());
                else
                    return _saveLoginCommand;
            }
        }

        public void SaveLogin()
        {
            Login l = new Login();
            l.Email = _email;

            DBAccess dba = DBAccess.GetObject();

            dba.CheckLoginData(l);
        }

    }
}
