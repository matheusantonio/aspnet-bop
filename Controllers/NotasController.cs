using System.Collections.Generic;
using ApiBop.Models;
using ApiBop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly NotaService _notaService;

        public NotasController(NotaService notaService){
            _notaService = notaService;
        }

        [HttpGet]
        public ActionResult<List<Nota>> Get(){
            return _notaService.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetNota")]
        public ActionResult<Nota> Get(string id){
            var nota = _notaService.Get(id);

            if(nota == null){
                return NotFound();
            }

            return nota;
        }

        
    }
}