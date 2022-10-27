using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataAccess;
using Model;

namespace Verkaufssystem.ViewModel
{
    class NikeViewModel : BaseViewModel
    {
        ICommand _saveNikeCommand;

        public NikeViewModel()
        {

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
            s.Model = "GTX run";

            DBAccess dba = DBAccess.GetObject();

            dba.SaveSchuh(s);
        }
    }
}
