namespace FactoryMethod
{
    /// <summary>
    /// Класс строительной компании
    /// </summary>
    public abstract class ConstructionCompany
    {
        public string Name { get; set; }

        public ConstructionCompany(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Фабричный метод постройки дома
        /// </summary>
        public abstract House Create();
    }
}