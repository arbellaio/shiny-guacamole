using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.ViewModels.Home;
using Demo.Views.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : BasePage
    {
        public HomeViewModel ViewModel => BindingContext as HomeViewModel;
        public HomePage()
        {
            InitializeComponent();
        }
    }
}