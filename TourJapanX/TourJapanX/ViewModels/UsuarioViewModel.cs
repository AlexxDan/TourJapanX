
using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Services;
using TourJapanX.Views;
using Xamarin.Forms;

namespace TourJapanX.ViewModels
{
    public class UsuarioViewModel:ViewModelBase
    {
        ServiceApi service;
        public UsuarioViewModel(ServiceApi service)
        {
            this.service = service;
            this.CargarUsuario();
        }

        private Usuario _Usuario;

        public Usuario Usuario
        {
            get { return this._Usuario; }
            set
            {
                this._Usuario = value;
                OnPropertyChanged("Usuario");
            }
        }
        public void CargarUsuario()
        {
            this.Usuario = App.ServiceLocator.SessionService.UserSession;
        }

        public Command FavoritosUsuario
        {
            get
            {
                return new Command(async() =>
                {
                    //await Application.Current.MainPage.DisplayAlert("Alert", "Activado", "OK");


                    FavoritosViewModel viewModel = App.ServiceLocator.FavoritosViewModel;

                    FavoritosView view = new FavoritosView();
                      view.BindingContext = viewModel;

                      await Application.Current.MainPage.Navigation.PushModalAsync(view);
                });
            }
        }
    }
}
