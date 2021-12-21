namespace Builder
{
    /// <summary>
    /// Автомобиль
    /// </summary>
    public class Car
    {
        private bool _carIsReady;

        public Car()
        {
            _carIsReady = false;
        }
            
        public string Frame { get; set; }
            
        public string Engine { get; set; }
            
        public string Wheels { get; set; }
            
        public string Saloon { get; set; }
            
        public string Electric { get; set; }
            
        public bool isReady => _carIsReady;

        public void SetState(bool state)
        {
            _carIsReady = state;
        }
    }
}