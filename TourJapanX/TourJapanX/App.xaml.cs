using System;
using TourJapanX.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourJapanX
{
    public partial class App : Application
    {
        private static ServiceIoC _ServiceLocator;
        public static ServiceIoC ServiceLocator
        {
            get
            {
                return _ServiceLocator = _ServiceLocator
                    ?? new ServiceIoC();
            }
        }
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new Views.MainTourJapan());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
