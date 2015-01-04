using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cashless_project_klanten.viewmodel
{
    class AskToReadVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "Scan id"; }
        }
        

    }
}
