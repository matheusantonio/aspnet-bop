using System.Collections.Generic;
using ApiBop.Models;
using ApiBop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : Controller
    {
        private readonly NotaService _notaService;

        public NotasController(NotaService notaService){
            _notaService = notaService;
        }

        public IActionResult Index()
        {
            return View(_notaService.Get());
        }

    }
}