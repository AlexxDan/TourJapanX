using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
    public class Foto
    {
        [JsonProperty("idFoto")]
        public int IdFoto { get; set; }

        [JsonProperty("nombreFoto")]
        public String NombreFoto { get; set; }

        [JsonProperty("idLugarFoto")]
        public int idLugar { get; set; }
    }
}
