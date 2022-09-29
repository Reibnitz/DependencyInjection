using Exemplo.Services.Injecao;

namespace DependencyInjection.Services
{
    public class Testes : ITestes
    {
        private ITransientService _transientService;
        private ISingletonService _singletonService;
        private IScopedService _scopedService;

        public Testes(ITransientService transientService,
            ISingletonService singletonService,
            IScopedService scopedService)
        {
            _transientService = transientService;
            _singletonService = singletonService;
            _scopedService = scopedService;
        }
        public void TestScoped()
        {
            Console.WriteLine(_scopedService.Contador());
        }

        public void TestTransient()
        {
            Console.WriteLine(_transientService.Contador());
        }

        public void TestSingleton()
        {
            Console.WriteLine(_singletonService.Contador());
        }
    }
}
