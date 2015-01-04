using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmctBaWPF1.viewmodel
{
    class MedewerkerWijzigenVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "Medewerkers wijzigen"; }
        }
        private string _demo;
        private string Demo
        {
            get { return _demo; }
            set { _demo = value; OnPropertyChanged("Demo"); }
        }
    
    }
}
