﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Services;
using Xamarin.Forms;

namespace TourJapanX.ViewModels
{
   public class LugarFotoViewModel : ViewModelBase
    {

        ServiceApi service;
        public LugarFotoViewModel(ServiceApi service)
        {
            this.service = service;
        }

        private Lugar _Lugar;

        public Lugar Lugar
        {
            get { return this._Lugar; }
            set
            {
                this._Lugar = value;
                OnPropertyChanged("Lugar");
            }
        }

        private ObservableCollection<Foto> _Fotos;

        public ObservableCollection<Foto> Fotos
        {
            get { return this._Fotos; }
            set
            {
                this._Fotos = value;
                OnPropertyChanged("Fotos");
            }
        }

        private String _Link;

        public String Link
        {
            get { return this._Link; }
            set
            {
                this._Link = value;
                OnPropertyChanged("Link");
            }
        }

        private String FormaterName(string nombre)
        {
            String formater = nombre.Replace(" ", "+");
            return formater;
        }

        public Command GuargarFavorito
        {
            get
            {
                return new Command(async() =>
                {
                    await Application.Current.MainPage.DisplayAlert("Alert", "FUncioana button", "OK");
                });
            }
        }

        public Command MostrarFavoritos
        {
            get
            {
                return new Command(async () =>
                {
                    Usuario user = App.ServiceLocator.SessionService.UserSession;
                   
                    await Application.Current.MainPage.DisplayAlert("Alert"
   , "Doctor almacenado", "OK");

                });
            }
        }

        public Command TapCommand
        {
            get
            {
                return new Command((nombre) =>
                {
                    String lugarname = FormaterName(this.Lugar.NombreLugar);
                    String link = "https://www.google.com/maps/search/" + lugarname;
                    Device.OpenUri(new Uri(link));
                });
            }
        }
    }
}
