using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using Xamarin.Forms;

namespace TourJapanX.ViewModels
{
    public class PruebaLoginVM: ViewModelBase
    {
        public PruebaLoginVM()
        {
            userName = "admin@gmail.com";
            password = "Sid";
        }

        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(async() =>
                {
                    if(string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                    {
                       await App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
                    }
                    else if(UserName == "admin@gmail.com")
                    {

                        await App.Current.MainPage.DisplayAlert("Algun usuario hay", "Vamoh a buscar", "OK");

                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("No eh el que queremos", "Vamoh a buscar", "OK");

                    }
                });
            }
        }

    }
}
