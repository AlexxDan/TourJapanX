using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Models;

namespace TourJapanX.Services
{
    public class SessionService
    {
        public Usuario UserSession { get; set; }

        public SessionService()
        {
            this.UserSession = new Usuario();
        }
    }
}
