using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
   public class Favorito
    {
        [JsonProperty("IdLugarFavorito")]
        public int idLugarFavorito { get; set; }

        [JsonProperty("NombreLugar")]
        public String NombreLugar { get; set; }
    }
}
