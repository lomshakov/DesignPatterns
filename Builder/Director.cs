namespace Builder
{
    /// <summary>
    /// Директор (распорядитель)
    /// </summary>
    public class Director
    {
        private readonly CarBuilder _builder;
        public Director(CarBuilder builder)
        {
            _builder = builder;
        }
        public Car GetCar()
        {
            return _builder.GetCar();
        }
        public void BuildTruck()
        {
            _builder.CreateNewCar();
            _builder.BuildCar();
            _builder.FinallyBuild();
        }
    }
}