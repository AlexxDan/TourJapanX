using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourJapanX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPrueba : ContentPage
    {
        PruebaLoginVM loginVM;
        public LoginPrueba()
        {
            InitializeComponent();
            loginVM = new PruebaLoginVM();
            BindingContext = loginVM;
        }
    }
}