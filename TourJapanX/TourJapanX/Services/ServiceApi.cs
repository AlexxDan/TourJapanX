using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TourJapanX.Models;

namespace TourJapanX.Services
{
    public class ServiceApi
    {
        private Uri url;
        private MediaTypeWithQualityHeaderValue Header;

        public ServiceApi()
        {
            this.url = new Uri("https://apitourjapanazure2.azurewebsites.net/");
            this.Header = new MediaTypeWithQualityHeaderValue("application/json");
        }


        #region CallAPI
        private async Task<T> CallAPi<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.url;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);

                HttpResponseMessage repsonse = await client.GetAsync(request);

                if (repsonse.IsSuccessStatusCode)
                {
                    //T data = await repsonse.Content.ReadAsAsync<T>();
                    //return data;

                    var data = await repsonse.Content.ReadAsStringAsync();
                    T dataformater = JsonConvert.DeserializeObject<T>(data);
                    return dataformater;

                }
                else
                {
                    return default(T);
                }
            }
        }
        #endregion

        #region Perfectura
        public async Task<List<Perfectura>> GetAllPerfecturasAsync()
        {
            String request = "api/Perfectura";
            List<Perfectura> perfecturas = await this.CallAPi<List<Perfectura>>(request);
            return perfecturas;
        }

        public async Task<Perfectura> GetPerfecturaAsync(int idperfectura)
        {
            String request = "​api​/Perfectura​/" + idperfectura;
            Perfectura perfectura = await this.CallAPi<Perfectura>(request);
            return perfectura;
        }

        public async Task<Perfectura> GetPerfecturaByNameAsync(string name)
        {
            String request = "api/Perfectura/GetPerfecturaByName/" + name;
            Perfectura perfectura = await this.CallAPi<Perfectura>(request);
            return perfectura;
        }

        #endregion

        #region Foto

        public async Task<List<Foto>> GetFotoByLugarAsync(int idlugar)
        {
            String request = "api/Fotos/GetFotoLugar/" + idlugar;
            List<Foto> fotos = await this.CallAPi<List<Foto>>(request);
            return fotos;
        }

        public async Task<List<Foto>> GetFirstFotosAsync(List<int> idlugares)
        {
            List<Foto> fotos = new List<Foto>();

            foreach (int id in idlugares)
            {
                String request = "api/Fotos/GetFotoFirst/" + id;
                Foto foto = await this.CallAPi<Foto>(request);
                fotos.Add(foto);
            }

            return fotos;
        }

        #endregion

        #region Lugar
        public async Task<Lugar> GetLugarAsync(int idlugar)
        {
            String request = "api/Lugar/" + idlugar;
            Lugar lugar = await this.CallAPi<Lugar>(request);
            return lugar;
        }

        public async Task<List<Lugar>> GetLugaresByPerefecturaAsync(int perfectura)
        {
            String request = "api/Lugar/GetLugarbyPerfectura/" + perfectura;
            List<Lugar> lugares = await this.CallAPi<List<Lugar>>(request);
            return lugares;
        }

        public async Task<List<Lugar>> PaginaLugarAsync(int paginar)
        {
            String request = "api/Lugar/PaginacionLugar/" + paginar;
            List<Lugar> lugar = await this.CallAPi<List<Lugar>>(request);
            return lugar;
        }

        public async Task<int> GetNumeroLugarAsync()
        {
            String request = "api/Lugar/GetNumeroLugar";
            int numero = await this.CallAPi<int>(request);
            return numero;
        }
        public async Task<Usuario> UsuarioLoginAsync(string email)
        {


            using (HttpClient client = new HttpClient())
            {
                String request = "api/Usuario/BuscarUsuarioLogin/" + email;
                client.BaseAddress = this.url;
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response =
                await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    String datas = await response.Content.ReadAsStringAsync();
                    Usuario userprueba = JsonConvert.DeserializeObject<Usuario>(datas);

                    return userprueba;
                }
                else
                {
                    return null;
                }

            }
        }
        public async Task<List<Lugar>> GetLugaresUserAsync(List<int> idlugares)
        {
            List<Lugar> lugares = new List<Lugar>();
            foreach (int id in idlugares)
            {
                lugares.Add(await this.GetLugarAsync(id));
            }
            return lugares;
        }
        #endregion

        #region UsuarioLugar
        public async Task<List<UsuarioLugar>> LugaresGuardadosAsync(int idusuario)
        {
            String request = "api/LugarUsuario/LugaresUsuario/" + idusuario;
            List<UsuarioLugar> usuarioLugars = await this.CallAPi<List<UsuarioLugar>>(request);
            return usuarioLugars;
        }

        public async Task<bool> LugarRegistradoAsync(int idusuario, int idlugar)
        {
            String request = "api/LugarUsuario/LugarRegistrado/" + idusuario + "/" + idlugar;
            bool exist = await this.CallAPi<bool>(request);
            return exist;
        }

        public async Task GuardarLugarUsuarioAsync(int idusuario, int lugar)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/LugarUsuario/" + idusuario + "/" + lugar;
                client.BaseAddress = this.url;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);

                UsuarioLugar usuarioLugar = new UsuarioLugar();
                usuarioLugar.IdUser = idusuario;
                usuarioLugar.IdLugar = lugar;

                String json = JsonConvert.SerializeObject(usuarioLugar);

                StringContent contet = new StringContent(json, Encoding.UTF8, "application/json");

                await client.PostAsync(request, contet);

            }
        }

        public async Task EliminarLugarUsuarioAsync(int idusuario, int lugar)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "api/LugarUsuario/" + idusuario + "/" + lugar;
                client.BaseAddress = this.url;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);

                await client.DeleteAsync(request);

            }
        }

        #endregion

        #region
        public async Task<Usuario> Login(string email, string password)
        {
            String request = "api/Usuario/BuscarUsuarioLogin/" + email;
            Usuario user = await this.CallAPi<Usuario>(request);
            
            //if(user == null)
            //{

            //}
            
            return user;
        }
        #endregion



    }
}
