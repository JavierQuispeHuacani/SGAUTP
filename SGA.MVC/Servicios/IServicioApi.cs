using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA.MVC.Models;

namespace SGA.MVC.Servicios
{
    public interface IServicioApi
    {
        Task<List<AreaViewModel>> Lista();


    }
}
