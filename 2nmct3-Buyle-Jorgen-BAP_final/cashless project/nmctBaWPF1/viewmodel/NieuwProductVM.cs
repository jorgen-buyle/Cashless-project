using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmctBaWPF1.viewmodel
{
    class NieuwProductVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "nieuw product"; }
        }
        private string _demo;
        private string Demo
        {
            get { return _demo; }
            set { _demo = value; OnPropertyChanged("Demo"); }
        }

    }
}
