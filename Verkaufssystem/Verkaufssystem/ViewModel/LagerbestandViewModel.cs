using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using CommandHelper;
using DataAccess;
using Model;

namespace Verkaufssystem.ViewModel
{
    class LagerbestandViewModel : BaseViewModel, INotifyPropertyChanged
    {
        ICommand _getStoredShoes;
        DBAccess _dba;
        private ObservableCollection<Lagerbestand> _allShoes;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GetStoredShoesCommand
        {
            get
            {
                if (_getStoredShoes == null)
                {
                    _getStoredShoes = new RelayCommand(c => GetStoredShoes());
                }
                return _getStoredShoes;
            }
            set
            {
            }
        }

        public ObservableCollection<Lagerbestand> AllShoes
        {
            get { return _allShoes; }
            set
            {
                _allShoes = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("AllShoes"));
            }
        }

        private void GetStoredShoes()
        {
            _dba = DBAccess.GetObject();

            List<Lagerbestand> allSh = _dba.GetStoredShoes();

            AllShoes = new ObservableCollection<Lagerbestand>(allSh);
        }
    }
}