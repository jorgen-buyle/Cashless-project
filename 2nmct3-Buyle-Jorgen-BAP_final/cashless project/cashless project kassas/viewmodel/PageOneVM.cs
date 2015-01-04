using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cashless_project_kassas.viewmodel
{
    class PageOneVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "first page"; }
        }
        private string _demo;
        private string Demo
        {
            get { return _demo; }
            set { _demo = value; OnPropertyChanged("Demo"); }
        }
    }
}
