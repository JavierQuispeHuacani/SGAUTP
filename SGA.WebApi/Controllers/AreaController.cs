using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA.App.Interfaces;
using SGA.App.ViewModels;

namespace SGA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {

        private IAreaService areaService;

        public AreaController(IAreaService areaService)
        {
            this.areaService = areaService;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult ListaArea()
        {

            AreaViewModel areaViewModel = (AreaViewModel)areaService.List();
            var listado = areaViewModel.Areas.ToList();
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
        public IActionResult ObtenerArea([FromBody] AreaViewModels obj)
        {

            AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (oArea.Area == null)
            {
                return BadRequest("Area no encontrada");
            }


            try
            {
                oArea.Area = areaService.GetById(obj.Area.Codigo_Area).Area;
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = oArea.Area });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = oArea.Area });
            }
        }

        [HttpPost]
        [Route("Nuevo")]
        public IActionResult Nuevo([FromBody] AreaViewModels obj)
        {
            try
            {
                areaService.Insert(obj);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message});
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] AreaViewModels obj)
        {

            //AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (obj.Area.Codigo_Area == 0)
            {
                return BadRequest("Area no encontrada");
            }

            try
            {
                //oArea.Area.Nombre_Area = obj.Area.Nombre_Area is null ? oArea.Area.Nombre_Area : obj.Area.Nombre_Area;
                areaService.Update(obj);

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] AreaViewModels obj)
        {
            //AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (obj.Area.Codigo_Area == 0)
            {
                return BadRequest("Area no encontrada");
            }
            try
            {
               
                areaService.Delete(obj);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }

        }

    }
}
