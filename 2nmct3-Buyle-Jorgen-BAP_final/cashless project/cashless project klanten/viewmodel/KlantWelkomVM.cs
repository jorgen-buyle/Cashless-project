using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace cashless_project_klanten.viewmodel
{
    class KlantWelkomVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "Aanmelden en of registreren"; }
        }
        private string _demo;
        private string Demo
        {
            get { return _demo; }
            set { _demo = value; OnPropertyChanged("Demo"); }
        }
        public ICommand NextPageCommand
        {
            get { return new RelayCommand(nextPage); }
        }
        public void nextPage()
        { 
            ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
            appvm.ChangePage(new AskToReadVM());
        }
    }
}
