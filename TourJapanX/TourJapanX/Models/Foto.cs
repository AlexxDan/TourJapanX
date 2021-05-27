using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
    public class Foto
    {
        [JsonProperty("IDFOTO")]
        public int IdFoto { get; set; }

        [JsonProperty("NICKFOTO")]
        public String NombreFoto { get; set; }
    }
}
