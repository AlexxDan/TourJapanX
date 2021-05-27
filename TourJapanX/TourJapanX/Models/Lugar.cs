using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
    public class Lugar
    {
        [JsonProperty("IDLUGAR")]
        public int IdLugar { get; set; }

        [JsonProperty("NOMBRE")]
        public String NombreLugar { get; set; }

        [JsonProperty("TIPO")]
        public String TipoLugar { get; set; }

        [JsonProperty("DESCRIPCION")]
        public String Descripcion { get; set; }

        [JsonProperty("COORDENADASX")]
        public String CoordenasX { get; set; }

        [JsonProperty("COORDENADASY")]
        public String CoordenasY { get; set; }

        [JsonProperty("IDPERFECTURA")]
        public int IdPerfecturaLugar { get; set; }

        [JsonProperty("Fotos")]
        public List<Foto> Fotos { get; set; }
    }
}
