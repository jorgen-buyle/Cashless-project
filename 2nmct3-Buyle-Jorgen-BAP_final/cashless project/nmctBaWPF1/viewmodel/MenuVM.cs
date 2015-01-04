using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace nmctBaWPF1.viewmodel
{
    class MenuVM : ObservableObject, IPage
    {
        public string Name 
        {
            get { return "Menu"; }
        }

        public ICommand LoguitCommand
        {
            get { return new RelayCommand(Loguit); }
        }
        private void Loguit()
        {
           ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
           appvm.ChangePage(new LoginScreenVM());
        }
        public ICommand ProductenCommand
        {
            get { return new RelayCommand(producten); }
        }
        private void producten()
        {
            ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
            appvm.ChangePage(new MenuProductenVM());
        }
        public ICommand MedewerkerCommand
        {
            get { return new RelayCommand(medewerker); }
        }
        private void medewerker()
        {
            ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
            appvm.ChangePage(new MenuMedewerkerVM());
        }
        public ICommand KassaCommand
        {
            get { return new RelayCommand(kassa); }
        }
        private void kassa()
        {
            ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
            appvm.ChangePage(new KassaBeheerVM());
        }
        /*public ICommand KlantenCommand
        {
            get { return new RelayCommand(klanten); }
        }
        private void klanten()
        {
            ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
            appvm.ChangePage(new klantenbeheerVM());
        }*/
        public ICommand WijzigPasCommand
        {
            get { return new RelayCommand(passwoord); }
        }
        private void passwoord()
        {
            ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
            appvm.ChangePage(new MenuPaswoorderanderenVM());
        }
        
    }
 }

