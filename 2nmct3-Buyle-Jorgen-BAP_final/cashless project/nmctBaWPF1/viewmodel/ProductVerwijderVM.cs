using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmctBaWPF1.viewmodel
{
    class ProductVerwijderVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "Product verwijderen"; }
        }
        private string _demo;
        private string Demo
        {
            get { return _demo; }
            set { _demo = value; OnPropertyChanged("Demo"); }
        }

    }
}
