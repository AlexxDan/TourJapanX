using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Services;

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
    }
}
