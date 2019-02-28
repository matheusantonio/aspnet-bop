using System.Collections.Generic;
using ApiBop.Models;
using ApiBop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBop.Controllers
{
    public class NotasController : Controller
    {
        private readonly NotaService _notaService;
        private readonly ApiBop.Models.PostgresNotasContext _postgresContext;

        public NotasController(NotaService notaService,
                              ApiBop.Models.PostgresNotasContext postgresContext){
            _notaService = notaService;
            _postgresContext = postgresContext;
        }

        public IActionResult Index()
        {
            List<Nota> listaNotas = _notaService.Get();
            return View(listaNotas);
        }

        public IActionResult Postgres()
        {
            return View(_postgresContext.tb_notas);
        }

    }
}