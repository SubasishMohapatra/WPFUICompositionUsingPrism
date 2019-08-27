using Prism.Regions;
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

namespace EnglishModule.Views
{
    /// <summary>
    /// Interaction logic for EnglishContentView.xaml
    /// </summary>
    public partial class EnglishContentView : UserControl, INavigateAsync
    {
        public EnglishContentView()
        {
            InitializeComponent();
        }

        public void RequestNavigate(Uri target, Action<NavigationResult> navigationCallback)
        {
            //throw new NotImplementedException();
        }

        public void RequestNavigate(Uri target, Action<NavigationResult> navigationCallback, NavigationParameters navigationParameters)
        {
            //throw new NotImplementedException();
        }
    }
}
