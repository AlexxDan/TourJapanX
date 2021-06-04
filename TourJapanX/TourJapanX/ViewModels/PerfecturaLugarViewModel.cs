using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Services;
using TourJapanX.Views;
using Xamarin.Forms;

namespace TourJapanX.ViewModels
{
    public class PerfecturaLugarViewModel : ViewModelBase
    {
        ServiceApi service;


        public PerfecturaLugarViewModel(ServiceApi service)
        {
            this.service = service;
            Task.Run(async () =>
            {
                await LoadPerfecturaAsync();
            });
        }

        private ObservableCollection<Lugar> _Lugares;

        public ObservableCollection<Lugar> Lugares
        {
            get { return this._Lugares; }
            set
            {
                this._Lugares = value;
                OnPropertyChanged("Lugares");
            }
        }

        private ObservableCollection<Perfectura> _Perfecturas;

        public ObservableCollection<Perfectura> Perfecturas
        {
            get { return this._Perfecturas; }
            set
            {
                this._Perfecturas = value;
                OnPropertyChanged("Perfecturas");
            }
        }

        private async Task LoadPerfecturaAsync()
        {
            List<Perfectura> data = await this.service.GetAllPerfecturasAsync();
            this.Perfecturas = new ObservableCollection<Perfectura>(data);
        }

        private async Task LugaresByPerfectura(int idperfectura)
        {
            List<Lugar> data = await this.service.GetLugaresByPerefecturaAsync(idperfectura);
            this.Lugares = new ObservableCollection<Lugar>(data);
        }

        public Command LugarByPefectura
        {
            get
            {
                return new Command(async (perfectua) =>
                {
                    Perfectura perf = perfectua as Perfectura;
                    await this.LugaresByPerfectura(perf.IdPerfectura);
                });
            }
        }

        public Command LugarDetails
        {
            get
            {
                return new Command(async (lugar) =>
                {
                    LugarFotoViewModel viewmodel = App.ServiceLocator.LugarFotoViewModel;
                    Lugar lugarbuscar = lugar as Lugar;

                    viewmodel.Lugar = lugarbuscar;

                    List<Foto> data = await this.service.GetFotoByLugarAsync(lugarbuscar.IdLugar);
                    viewmodel.Fotos = new ObservableCollection<Foto>(data);

                    LugarView view = new LugarView();
                    view.BindingContext = viewmodel;
                    await Application.Current.MainPage.Navigation.PushModalAsync(view);
                });
            }

        }

    }
}
