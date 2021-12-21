namespace Proxy
{
    public class Client
    {
        public void Execute(ISubject subject)
        {
            // ...
            
            subject.Request();
            
            // ...
        }
    }
}