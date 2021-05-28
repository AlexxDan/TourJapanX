using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
    public class UsusarioLugar
    {
        [JsonProperty("idUsuario")]
        public int IdUser { get; set; }

        [JsonProperty("idLugar")]
        public int IdLugar { get; set; }

        [JsonProperty("comentario")]
        public String Comentario { get; set; }

        [JsonProperty("puntuacion")]
        public int Puntuacion { get; set; }
    }
}
