using nmctBaWPF1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nmctBaWPF1.view
{
    /// <summary>
    /// Interaction logic for MenuMedewerker.xaml
    /// </summary>
    public partial class MenuMedewerker : UserControl
    {
        public MenuMedewerker()
        {
            MedewerkerInfo M = new MedewerkerInfo();
            InitializeComponent();
        }
    }
}
