namespace Facade
{
    class DataProcessFacade
    {
        readonly DataFilter _dataFilter;
        readonly Sender _sender;
        readonly DataReceiver _dataReceiver;
        public DataProcessFacade(DataFilter dataFilter, Sender sender, DataReceiver dataReceiver)
        {
            _dataFilter = dataFilter;
            _sender = sender;
            _dataReceiver = dataReceiver;
        }
        public void Start()
        {
            _dataFilter.CreateFilter();
            _dataFilter.Filter();
            _sender.Send();
            _dataReceiver.Receive();
        }
        public void Stop()
        {
            _dataReceiver.Finish();
        }
    }
}