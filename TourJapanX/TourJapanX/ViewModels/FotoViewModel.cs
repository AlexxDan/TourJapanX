using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Services;

namespace TourJapanX.ViewModels
{
   public class FotoViewModel:ViewModelBase
    {

        ServiceApi service;
        public FotoViewModel()
        {
            this.service = new ServiceApi();

        }
    }
}
