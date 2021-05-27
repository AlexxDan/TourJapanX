using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Repository;

namespace TourJapanX.ViewModels
{
   public class UsuarioViewModel:ViewModelBase
    {
        RepositoriesTourJapan repo;

        public UsuarioViewModel()
        {
            this.repo = new RepositoriesTourJapan();
            
        }
    }
}
