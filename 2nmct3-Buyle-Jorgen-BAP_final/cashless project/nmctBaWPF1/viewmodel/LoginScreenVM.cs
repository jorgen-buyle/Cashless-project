using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace nmctBaWPF1.viewmodel
{
    class LoginScreenVM : ObservableObject, IPage
    {
        public string Name
        {
            get { return "Login"; }
        }
        private string _username;
        private string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged("Username"); }
        }
        private string _password;
        private string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged("Password"); }
        }
        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login); }
        }
        private void Login()
        {
           ApplicationVM appvm = App.Current.MainWindow.DataContext as ApplicationVM;
           // ApplicationVM.token = GetToken();

            //if (!ApplicationVM.token.IsError)
            //{
           appvm.ChangePage(new MenuVM());
            //}
            //else
            //{
            //    Error = "Gebruikersnaam of paswoord kloppen niet";
            //}
        }

        /*private TokenResponse GetToken()
        {
            OAuth2Client client = new OAuth2Client(new Uri("http://localhost:31929/token"));
            return client.RequestResourceOwnerPasswordAsync(Username, Password).Result;
        }*/
        
        
    }
}
