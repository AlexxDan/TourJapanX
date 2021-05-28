using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TourJapanX.Models
{
   public class Usuario
    {
        [JsonProperty("idUser")]
        public int IdUser { get; set; }

        [JsonProperty("nickUser")]
        public String NickUser { get; set; }

        [JsonProperty("email")]
        public String Email { get; set; }

        [JsonProperty("foto")]
        public String Foto { get; set; }

        [JsonProperty("password")]
        public String Password { get; set; }

        [JsonProperty("salt")]
        public String Salt { get; set; }

        [JsonProperty("idRolUsuario")]
        public int IdRolUsuario { get; set; }

       
    }
}
