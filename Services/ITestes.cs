namespace DependencyInjection.Services
{
    public interface ITestes
    {
        void TestScoped();
        void TestSingleton();
        void TestTransient();
    }
}