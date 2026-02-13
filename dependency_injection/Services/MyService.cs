namespace Dependency_injection.Services
{
    public class MyService : IMyService 
    {
        public string GetMessage()
        {
            return "Hello from MyService Using Dependency Injection ";
        }
    }
}
