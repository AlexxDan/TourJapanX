using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
    public class Lugar
    {
        [JsonProperty("idLugar")]
        public int IdLugar { get; set; }

        [JsonProperty("nombreLugar")]
        public String NombreLugar { get; set; }

        [JsonProperty("tipoLugar")]
        public String TipoLugar { get; set; }

        [JsonProperty("descripcion")]
        public String Descripcion { get; set; }

        [JsonProperty("coordenasX")]
        public String CoordenasX { get; set; }

        [JsonProperty("coordenasY")]
        public String CoordenasY { get; set; }

        [JsonProperty("idPerfecturaLugar")]
        public int IdPerfecturaLugar { get; set; }

    }
}
