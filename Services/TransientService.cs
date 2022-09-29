namespace Exemplo.Services.Injecao
{
    public class TransientService : ITransientService
    {
        private int _contador;

        public string Contador()
        {
            _contador++;
            return $"Contador {nameof(TransientService)}: {_contador}";
        }
    }
}
