using AutomapperTp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperTp.Controllers
{
    public class ArticuloController : Controller
    {
        private readonly IarticuloService _service;

        public ArticuloController(IarticuloService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var articulo = _service.GetArticulo();
            return View(articulo);
        }
    }
}
