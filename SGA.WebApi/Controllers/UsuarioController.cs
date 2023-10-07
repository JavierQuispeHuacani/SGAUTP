using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA.App.Interfaces;
using SGA.App.ViewModels;
using Microsoft.Extensions.Logging;

namespace SGA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
      
        private readonly ILogger<UsuarioController> _logger;
        private IUsuarioService usuarioService;


        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioService usuarioService)
        {
            _logger = logger;
            this.usuarioService = usuarioService;
        }
        
        [HttpGet]
        [Route("Lista")]
        public IActionResult ListaUsuario()
        {

            UsuarioViewModel usuarioViewModel = (UsuarioViewModel)usuarioService.List();
            var listado = usuarioViewModel.Usuarios.ToList();
            try
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = listado });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = listado });
            }
        }

        [HttpPost]
        [Route("Obtener")]
        public IActionResult ObtenerCargo([FromBody] UsuarioViewModels obj)
        {

            UsuarioViewModel oUsuario = usuarioService.GetById(obj.Usuario.Cod_Usuario);
            if (oUsuario.Usuario == null)
            {
                return BadRequest("Area no encontrada");
            }


            try
            {
                oUsuario.Usuario = usuarioService.GetById(obj.Usuario.Cod_Usuario).Usuario;
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = oUsuario.Usuario });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = oUsuario.Usuario });
            }
        }

        [HttpPost]
        [Route("Nuevo")]
        public IActionResult Nuevo([FromBody] UsuarioViewModels obj)
        {
            try
            {
                usuarioService.Insert(obj);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] UsuarioViewModels obj)
        {

            //AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (obj.Usuario.Cod_Usuario == 0)
            {
                return BadRequest("Area no encontrada");
            }

            try
            {
                //oArea.Area.Nombre_Area = obj.Area.Nombre_Area is null ? oArea.Area.Nombre_Area : obj.Area.Nombre_Area;
                usuarioService.Update(obj);

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] UsuarioViewModels obj)
        {
            //AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (obj.Usuario.Cod_Usuario == 0)
            {
                return BadRequest("Area no encontrada");
            }
            try
            {

                usuarioService.Delete(obj);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }

        }



    }
}
