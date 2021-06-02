using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Services;
using Xamarin.Forms;

namespace TourJapanX.ViewModels
{
    public class LugaresViewModel : ViewModelBase
    {
        ServiceApi service;

        public LugaresViewModel()
        {
            this.service = new ServiceApi();

        }

        private ObservableCollection<Lugar> _Lugar;

        public ObservableCollection<Lugar> Lugar
        {
            get { return this._Lugar; }
            set
            {
                this._Lugar = value;
                OnPropertyChanged("Lugar");
            }
        }

      

    }
}
