﻿using System;
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





        public Command FavoritosUsuario
        {
            get
            {
                return new Command(async () =>
                {

                    Usuario user = App.ServiceLocator.SessionService.UserSession;
                    //if (user != null)
                    //{
                    //    this.Usuario = user;
                    //}
                    FavoritosViewModel viewmodel = App.ServiceLocator.FavoritosViewModel;
                    
                    
                });
            }
        }


    }
}
