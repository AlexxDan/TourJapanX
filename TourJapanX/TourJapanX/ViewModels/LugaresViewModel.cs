using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Repository;

namespace TourJapanX.ViewModels
{
    public class LugaresViewModel:ViewModelBase
    {
        RepositoriesTourJapan repo;

        public LugaresViewModel()
        {
            this.repo = new RepositoriesTourJapan();
            /*List<Pelicula> pelis = this.repo.GetPelicuals();
            this.Peliculas = new ObservableCollection<Pelicula>(pelis);*/
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
    }
}
