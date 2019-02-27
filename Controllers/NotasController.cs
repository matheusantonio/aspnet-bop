using System.Collections.Generic;
using ApiBop.Models;
using ApiBop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBop.Controllers
{
    public class NotasController : Controller
    {
        private readonly NotaService _notaService;

        public NotasController(NotaService notaService){
            _notaService = notaService;
        }

        public IActionResult Index()
        {
            List<Nota> listaNotas = _notaService.Get();
            return View(listaNotas);
        }

    }
}