using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace nmctBaWPF1.viewmodel
{
    class KassaBeheerVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "Kassa beheer"; }
        }
        private string _demo;
        private string Demo
        {
            get { return _demo; }
            set { _demo = value; OnPropertyChanged("Demo"); }
        }

    }
}
