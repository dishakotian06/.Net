namespace Interface_Custom_service.Service
{
    public class MyService : IMyService
    {
        public string Getmessage(string name)
        {
            return $"Hello {name}, Welcome to ASP.NET ";
        }
    }
}
