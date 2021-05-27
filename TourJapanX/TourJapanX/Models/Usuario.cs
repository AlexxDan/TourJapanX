using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
   public class Usuario
    {
        [JsonProperty("IDUSER")]
        public int IdUser { get; set; }

        [JsonProperty("NickUser")]
        public String NickUser { get; set; }

        [JsonProperty("Email")]
        public String Email { get; set; }

        [JsonProperty("Foto")]
        public String Foto { get; set; }

        [JsonProperty("Password")]
        public String Password { get; set; }

        [JsonProperty("Salt")]
        public String Salt { get; set; }

        [JsonProperty("IdRolUsuario")]
        public int IdRolUsuario { get; set; }

        [JsonProperty("Favoritos")]
        public List<Favorito> Favoritos { get; set; }
    }
}
