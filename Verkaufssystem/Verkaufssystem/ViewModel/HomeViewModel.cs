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
        public  event  PropertyChangedEventHandler PropertyChanged;
        private string _email;
        private string _passwort;
        private string _statusMessage;
        ICommand       _saveLoginCommand;

        public HomeViewModel()
        {
            
        }

        public string StatusMessage
        {
            get { return _statusMessage; }
            set
            {
                _statusMessage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("StatusMessage"));
            }
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
        public string Passwort
        {
            get
            {
                return _passwort;
            }
            set
            {
                _passwort = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Passwort"));
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
            l.Passwort = _passwort;

            DBAccess dba = DBAccess.GetObject();

            dba.CheckLoginData(l);

            if( dba.CheckLoginData(l) )
            {
                StatusMessage = "Erfolgreich angemeldet!";

            }
            else
            {
                StatusMessage = "Anmeldung fehlgeschlagen!";
            }

        }



    }
}
