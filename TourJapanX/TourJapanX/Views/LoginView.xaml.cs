using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Helper;
using TourJapanX.Models;
using TourJapanX.Services;
using TourJapanX.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourJapanX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        private ServiceApi Service;
        public LoginView()
        {
            InitializeComponent();
            this.Service = new ServiceApi();
            this.btnLogin.Clicked += BtnLogin_Clicked;
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text) || string.IsNullOrEmpty(Password.Text))
            {
                await App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            }
            else
            {
                string username = UserName.Text;
                string pass = Password.Text;
                //await App.Current.MainPage.DisplayAlert("Algun usuario hay", "Vamoh a buscar", "OK");
                Usuario user = await this.Service.Login(username, pass);
                if (user == null)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "El email o contraseña introducidos son incorrectos", "OK");

                }
                else
                {
                    bool passwordEqual = CypherService.DescifrarContenido(pass, user.Salt, user.Password);
                    if (passwordEqual)
                    {
                        SessionService usersession =
                        App.ServiceLocator.SessionService;
                        usersession.UserSession = user;
                        MessagingCenter.Send(App.ServiceLocator.UsuarioViewModel, "RELOAD");
                       
                        // password = 1234
                        //UsuarioViewModel viewmodel = App.ServiceLocator.UsuarioViewModel;
                        //viewmodel.Usuario = user;
                        //PerfilView view = new PerfilView();
                        //view.BindingContext = viewmodel;
                        //                       Application.Current.MainPage.BindingContext = viewmodel;

                        await Navigation.PopModalAsync();
                       //await Navigation.PushAsync(view);
                    }
                }

            }
        }
    }
}