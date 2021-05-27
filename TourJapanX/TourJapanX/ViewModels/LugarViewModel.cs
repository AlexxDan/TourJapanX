using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TourJapanX.Base;
using TourJapanX.Models;
using TourJapanX.Repository;

namespace TourJapanX.ViewModels
{
   public class LugarViewModel : ViewModelBase
    {
        RepositoriesTourJapan repo;

        public LugarViewModel()
        {
            this.repo = new RepositoriesTourJapan();

        }
    }
}
