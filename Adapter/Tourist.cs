namespace Adapter
{
    /// <summary>
    /// Путешественник
    /// </summary>
    public class Tourist
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}