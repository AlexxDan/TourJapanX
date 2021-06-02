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
   public class LugarViewModel : ViewModelBase
    {
        ServiceApi service;

        public LugarViewModel()
        {
            this.service = new ServiceApi();
            Task.Run(async () =>
            {
                await LoadLugarAsync();
            });
        }

        private async Task LoadLugarAsync()
        {
            Lugar lugar = await this.service.GetLugarAsync(1);
            this.Lugar = lugar;
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

        public Command ShowLugar
        {
            get
            {
                return new Command(async () =>
                {
                    await LoadLugarAsync();
                });
            }
        }

        public Command MostrarFavoritos
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Alert"
   , "Doctor almacenado", "OK");

                });
            }
        }
    }
}
