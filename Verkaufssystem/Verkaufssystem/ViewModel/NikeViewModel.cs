using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataAccess;
using Model;
using CommandHelper;
using System.ComponentModel;

namespace Verkaufssystem.ViewModel
{
    class NikeViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ICommand       _saveNikeCommand;
        ICommand       _clearCommand;
        private string _schuhName;
        private string _beschreibung;
        private double _preis;
        private string _farbe;
        private string _statusMessage;
        private int    _fidMarke;


        public NikeViewModel()
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

        public string Schuhname
        {
            get { return _schuhName; }
            set { _schuhName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Schuhname"));
            }
        }


        public string Beschreibung
        {
            get { return _beschreibung; }
            set
            {
                _beschreibung = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Beschreibung"));
            }
        }

        public int FidMarke
        {
            get { return _fidMarke; }
            set
            {
                _fidMarke = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FidMarke"));
            }
        }

        public double Preis
        {
            get { return _preis; }
            set
            {
                _preis = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Preis"));
            }
        }

        public string Farbe
        {
            get { return _farbe; }
            set
            {
                _farbe = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Farbe"));
            }
        }

        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null)
                {
                    _clearCommand = new RelayCommand(c => ClearAllFields());
                }
                return _clearCommand;
            }
            set { }
        }

        private void ClearAllFields()
        {
            Schuhname = string.Empty;
            Beschreibung = string.Empty;
            Preis = 0;
            FidMarke = 0;
            Farbe = string.Empty;
        }


        public ICommand SaveNikeCommand
        {
            get
            {
                if (_saveNikeCommand == null)
                    return _saveNikeCommand = new Helper.RelayCommand(c => SaveNike());
                else
                    return _saveNikeCommand;
            }
        }

        public void SaveNike()
        {
            Schuh s = new Schuh();
            s.Name = Schuhname;
            s.Beschreibung = Beschreibung;
            s.Preis = Preis;
            s.Farbe = Farbe;
            s.FidMarke = 1; // FK 1 = Nike in DB

            DBAccess dba = DBAccess.GetObject();

            if (dba.SaveSchuh(s))
            {
                StatusMessage = Schuhname + " erfolgreich gespeichert.";
                ClearAllFields();
            }
            else
            {
                StatusMessage = Schuhname + " konnte nicht gespeichert werden.";
            }
        }
    }
}
