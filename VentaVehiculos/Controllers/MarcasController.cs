using Microsoft.AspNetCore.Mvc;
using VentaVehiculos.Data;



namespace VentaVehiculos.Controllers
{
    public class MarcasController : Controller
    {

        private readonly VentaVehiculosDbContext _context;

        // VentaVehiculosDbContext administra la inyeccion de depencias a la BD
        public MarcasController(VentaVehiculosDbContext context) {_context = context; }

    }
}


