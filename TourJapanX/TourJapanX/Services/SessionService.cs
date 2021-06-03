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
        //    this.UserSession = new Usuario()
        //    {
        //        IdUser = 1,
        //    NickUser = "Pruebassssss",
        //    Email = "prueba@gmail.comsssss",
        //        Foto = "https://bucket-tourjapan-ans.s3.amazonaws.com/user/default.png",
        //    Password = "�(d\u001bB����j�Ũ\u0004߃��F\rN�\u0019\u00030Z8\u0004s�%S",
        //    Salt = "xÉe^\u0019¢çy<!:|ïõ8Æõræ Ë3?O Á Ií»£SÐ\u0005Û\u0006=¤\u000eRÆ´\u0002HP",
        //};
          
        }
    }
}
