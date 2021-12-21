namespace FactoryMethod
{
    /// <summary>
    /// Компания строит деревянные дома
    /// </summary>
    public class WoodConstructionCompany : ConstructionCompany
    {
        public WoodConstructionCompany(string name) : base(name)
        {
        }

        /// <summary>
        /// Фабричный метод постройки дома
        /// </summary>
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}