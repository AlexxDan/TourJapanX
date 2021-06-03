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
            //this.UserSession = new Usuario();
            this.UserSession = new Usuario()
            {
                IdUser=1,
                NickUser= "Prueba",
                Email= "prueba@gmail.com",
                Foto= "https://bucket-tourjapan-ans.s3.amazonaws.com/user/default.png"
            };
          
        }
    }
}
