using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Services;
using Xamarin.Forms;
using TourJapanX.Views;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace TourJapanX.ViewModels
{
    public class UsuarioViewModel : ViewModelBase
    {
        ServiceApi ServiceApi;

        public UsuarioViewModel(ServiceApi serviceApi)
        {
            this.ServiceApi = serviceApi;
           
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



        //public string Email { get; set; }
        //public string Password { get; set; }

        ////public

        //public Command Login
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
               
        //            await Application.Current.MainPage.DisplayAlert("Alert"
        //                , "Doctor almacenado", "OK");
        //        //Usuario user = await this.Service.Login(this.Email, this.Password);
        //        //if (user == null)
        //        //{
        //        //    await Application.Current.MainPage.DisplayAlert(
        //        //        "Error",
        //        //        "La contraseña o email son incorrectos",
        //        //        "OK");
        //        //    return;
        //        //}
        //        //else
        //        //{
        //        //    await Application.Current.MainPage.DisplayAlert(
        //        //        "Correcto",
        //        //        "Existe el usuario",
        //        //        "OK");
        //            //}
        //        });
        //    }
        //}


    }
}
