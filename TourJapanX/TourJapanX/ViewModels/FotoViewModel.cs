using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Repository;

namespace TourJapanX.ViewModels
{
   public class FotoViewModel:ViewModelBase
    {
        RepositoriesTourJapan repo;

        public FotoViewModel()
        {
            this.repo = new RepositoriesTourJapan();

        }
    }
}
