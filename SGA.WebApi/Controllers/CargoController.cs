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
    public class CargoController : ControllerBase
    {
        private ICargoService cargoService;

        public CargoController(ICargoService cargoService) {
            this.cargoService = cargoService;
        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult ListaCargo() {

            CargoViewModel cargoViewModel = (CargoViewModel)cargoService.List();
            var listado = cargoViewModel.Cargos.ToList();
            try
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = listado });
            }
            catch (Exception ex) {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = listado });
            }
        }

        [HttpPost]
        [Route("Obtener")]
        public IActionResult ObtenerCargo([FromBody] CargoViewModels obj)
        {

            CargoViewModel oCargo = cargoService.GetById(obj.Cargo.Codigo_Cargo);
            if (oCargo.Cargo == null)
            {
                return BadRequest("Area no encontrada");
            }


            try
            {
                oCargo.Cargo = cargoService.GetById(obj.Cargo.Codigo_Cargo).Cargo;
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = oCargo.Cargo });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, Response = oCargo.Cargo });
            }
        }

        [HttpPost]
        [Route("Nuevo")]
        public IActionResult Nuevo([FromBody] CargoViewModels obj)
        {
            try
            {
                cargoService.Insert(obj);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] CargoViewModels obj)
        {

            //AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (obj.Cargo.Codigo_Cargo == 0)
            {
                return BadRequest("Area no encontrada");
            }

            try
            {
                //oArea.Area.Nombre_Area = obj.Area.Nombre_Area is null ? oArea.Area.Nombre_Area : obj.Area.Nombre_Area;
                cargoService.Update(obj);

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult Eliminar([FromBody] CargoViewModels obj)
        {
            //AreaViewModel oArea = areaService.GetById(obj.Area.Codigo_Area);
            if (obj.Cargo.Codigo_Cargo == 0)
            {
                return BadRequest("Area no encontrada");
            }
            try
            {

                cargoService.Delete(obj);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }

        }

    }
}
