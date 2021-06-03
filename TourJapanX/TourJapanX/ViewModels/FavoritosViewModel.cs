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
    public class FavoritosViewModel: ViewModelBase
    {
        private ServiceApi ServiceApi;
        public List<Lugar> lugares;

        public FavoritosViewModel(ServiceApi serviceApi)
        {
            
            this.ServiceApi = serviceApi;
            lugares = new List<Lugar>();

            Task.Run(async () =>
            {
                await this.CargarUsuarioLugar();
                foreach (var userLugar in this.UsuarioLugar)
                {
                    Lugar lugar = await this.ServiceApi.GetLugarAsync(userLugar.IdLugar);
                    this.lugares.Add(lugar);

                }
                //List<int> idlugaresista = (IEnumerable<List<UsuarioLugar>>)this.UsuarioLugar.Select(z => z.IdLugar).ToList();
                this.Lugares = new ObservableCollection<Lugar>(lugares);
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

        private ObservableCollection<UsuarioLugar> _UsuarioLugar;
        public ObservableCollection<UsuarioLugar> UsuarioLugar
        {
            get { return this._UsuarioLugar; }
            set
            {
                this._UsuarioLugar = value;
                OnPropertyChanged("UsuarioLugar");
            }
        }

        private async Task CargarUsuarioLugar()
        {
            List<UsuarioLugar> lista =
                await this.ServiceApi.LugaresGuardadosAsync(3);
            this.UsuarioLugar =
                new ObservableCollection<UsuarioLugar>(lista);
        }

        public Command EliminarFavorito
        {
            get
            {
                return new Command(async (usuariolugar) =>
                {
                    UsuarioLugar userlugar = usuariolugar as UsuarioLugar;
                    //await this.ServiceApi.EliminarLugarUsuarioAsync(); Traer el usuario
                    await Application.Current.MainPage.DisplayAlert("Alert", "UsuarioLugar eliminado", "OK");
                });
            }
        }
    }
}
