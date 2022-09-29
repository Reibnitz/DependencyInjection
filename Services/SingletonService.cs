namespace Exemplo.Services.Injecao
{
    public class SingletonService : ISingletonService
    {
        private int _contador;
        public string Contador()
        {
            _contador++;
            return $"Contador {nameof(SingletonService)}: {_contador}";
        }
    }
}
