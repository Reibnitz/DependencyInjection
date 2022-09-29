using DependencyInjection.Services;
using Exemplo.Services.Injecao;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InjecaoDependenciaController : ControllerBase
    {
        private ITransientService _transientService;
        private ISingletonService _singletonService;
        private IScopedService _scopedService;
        private ITestes _testes;

        public InjecaoDependenciaController(
            ITransientService transientService,
            ISingletonService singletonService,
            IScopedService scopedService,
            ITestes testes)
        {
            _transientService = transientService;
            _singletonService = singletonService;
            _scopedService = scopedService;
            _testes = testes;
        }

        [HttpGet("transient")]
        public IActionResult Transient()
        {
            Console.WriteLine(_transientService.Contador());
            _testes.TestTransient();

            return Ok(_transientService.Contador());
        }


        [HttpGet("scoped")]
        public IActionResult Scoped()
        {
            Console.WriteLine(_scopedService.Contador());
            _testes.TestScoped();

            return Ok(_scopedService.Contador());
        }

        [HttpGet("singleton")]
        public IActionResult Singleton()
        {
            Console.WriteLine(_singletonService.Contador());
            _testes.TestSingleton();

            return Ok(_singletonService.Contador());
        }
    }
}
