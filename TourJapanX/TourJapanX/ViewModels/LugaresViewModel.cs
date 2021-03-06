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
   public class LugaresViewModel : ViewModelBase
    {
        ServiceApi service;


        public LugaresViewModel(ServiceApi service)
        {
            this.service = service;
            Task.Run(async () =>
            {
                await LugarInfinitiScroll();
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



        public async Task LugarInfinitiScroll()
        {
            List<Lugar> data = await this.service.GetAllLugaresAsync();
            this.Lugares = new ObservableCollection<Lugar>(data);
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
