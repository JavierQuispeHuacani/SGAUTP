using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SGA.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Index()
        //{
        //    //using (var client = new HttpClient())
        //    //{
        //    //    client.BaseAddress = new Uri("https://localhost:44398/");
        //    //    client.DefaultRequestHeaders.Accept.Clear();
        //    //    // Agrega el header Accept: application/json para recibir la data como json  
        //    //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    //    //"https://localhost:44398/api/Area/Lista"
        //    //    // Hace la llamada a http://url-base-del-api/api/products/<id>
        //    //    var response = await client.GetAsync("api/Area/Lista");

        //    //    // Si el servicio responde correctamente
        //    //    if (response.IsSuccessStatusCode)
        //    //    {
        //    //        // Lee el response y lo deserializa como un Product
        //    //        return await response.Content.ReadAsAsync<Product>();
        //    //    }
        //    //    // Sino devuelve null
        //    //    return Task.FromResult<Product>(null);
        //    //}
        //}
    }
}
