using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
   public class Perfectura
    {
        [JsonProperty("IDPERFECTURA")]
        public int IdPerfectura { get; set; }

        [JsonProperty("NOMBREPERFECTURA")]
        public int NombrePerfectura { get; set; }
    }
}
