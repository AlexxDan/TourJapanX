using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Services;

namespace TourJapanX.ViewModels
{
   public class UsuarioViewModel:ViewModelBase
    {
        ServiceApi service;

        public UsuarioViewModel()
        {
            this.service = new ServiceApi();

        }
    }
}
