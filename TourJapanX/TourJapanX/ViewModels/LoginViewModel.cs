using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Helper;
using TourJapanX.Models;
using TourJapanX.Services;
using TourJapanX.Views;
using Xamarin.Forms;

namespace TourJapanX.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private ServiceApi ServiceApi;

        public LoginViewModel(ServiceApi serviceApi)
        {
            this.ServiceApi = serviceApi;
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
                return new Command(async () =>
                {
                    if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                    {
                        await App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
                    }
                    else
                    {

                        //await App.Current.MainPage.DisplayAlert("Algun usuario hay", "Vamoh a buscar", "OK");
                        Usuario user =
                        await this.ServiceApi.Login(userName, password);
                        if (user == null)
                        {
                            await App.Current.MainPage.DisplayAlert("Error", "El email o contraseña introducidos son incorrectos", "OK");

                        }
                        else
                        {
                            bool passwordEqual = CypherService.DescifrarContenido(password, user.Salt, user.Password);
                            if (passwordEqual)
                            {
                                SessionService usersession =
                                App.ServiceLocator.SessionService;
                                usersession.UserSession = user;
                               PerfilView view = new PerfilView();

                                // password = 1234
                                UsuarioViewModel viewmodel =
                                App.ServiceLocator.UsuarioViewModel;

                                view.BindingContext = viewmodel;

                                viewmodel.Usuario = user;

                                await Application.Current.MainPage.Navigation.PushModalAsync(view);
                            }
                        }

                    }

                });
            }
        }
    }
}
