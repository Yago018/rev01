using Microsoft.AspNetCore.Mvc;
using rev01.Models;
using rev01.Repositories;

namespace rev01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidatosController : ControllerBase
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatosController(ICandidatoRepository alunoRepository)
        {
            _candidatoRepository = alunoRepository;
        }
        #region 
        [HttpGet]
        [Route("ListarCandidato")]
        public IActionResult ListarCandidato()
        {
            return Ok(_candidatoRepository.ObterTodos());
        }

        #endregion
        [HttpPost]
        public IActionResult Cadastrar(Candidato candidato)
        {
            var resultado = _candidatoRepository;
        } 

        
    }
}

