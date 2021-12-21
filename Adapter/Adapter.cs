namespace Adapter
{
    /// <summary>
    /// Адаптер от Camel к ITransport
    /// </summary>
    class CamelToTransportAdapter : ITransport
    {
        Camel _camel;
        public CamelToTransportAdapter(Camel camel)
        {
            _camel = camel;
        }
 
        public void Drive()
        {
            _camel.Move();
        }
    }
}