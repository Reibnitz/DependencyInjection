namespace Exemplo.Services.Injecao
{
    public class ScopedService : IScopedService
    {
        private int _contador;

        public string Contador()
        {
            _contador++;
            return $"Contador {nameof(ScopedService)}: {_contador}";
        }
    }
}
