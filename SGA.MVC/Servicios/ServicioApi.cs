using SGA.MVC.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.MVC.Servicios
{
    public class ServicioApi
    {
        private static string _usuario;
        private static string _clave;
        private static string _baseUrl;
        private static string _token;

        public ServicioApi()
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _usuario = builder.GetSection("ApiSetting:usuario").Value;
            _clave = builder.GetSection("ApiSetting:clave").Value;
            _baseUrl = builder.GetSection("ApiSetting:baseUrl").Value;
        }


        public async Task<List<AreaViewModel>> Lista()
        {
            List<AreaViewModel> lista = new List<AreaViewModel>();

            //await Autenticar();


            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            //cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            var response = await cliente.GetAsync("api/Area/Lista");

            if (response.IsSuccessStatusCode)
            {

                var json_respuesta = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResponseArea>(json_respuesta);
                lista = resultado.lista;
            }

            return lista;
        }

    }
}
