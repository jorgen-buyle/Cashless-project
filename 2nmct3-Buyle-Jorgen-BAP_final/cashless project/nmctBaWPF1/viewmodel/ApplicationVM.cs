﻿using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace nmctBaWPF1.viewmodel
{
    class ApplicationVM : ObservableObject
    {
        //public static TokenResponse token = null;
        public ApplicationVM()
        {
            //Pages.Add(new LoginScreenVM());
            Pages.Add(new MenuMedewerkerVM());
            Pages.Add(new MenuPaswoorderanderenVM());
            Pages.Add(new MenuProductenVM());
            pages.Add(new KassaBeheerVM());
            
            
            // Add other pages
            CurrentPage = new LoginScreenVM();           
        }
        private object currentPage;
        public object CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; OnPropertyChanged("CurrentPage"); }
        }
        private List<IPage> pages;
        public List<IPage> Pages
        {
            get
            {
                if (pages == null)
                    pages = new List<IPage>();
                return pages;
            }
        }
        public ICommand ChangePageCommand
        {
            get { return new RelayCommand<IPage>(ChangePage); }
        }

        public void ChangePage(IPage page)
        {
            CurrentPage = page;
        }
    }
}
