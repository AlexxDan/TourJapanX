using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
   public class Perfectura
    {
        [JsonProperty("idPerfectura")]
        public int IdPerfectura { get; set; }

        [JsonProperty("nombrePerfectura")]
        public String NombrePerfectura { get; set; }
    }
}
