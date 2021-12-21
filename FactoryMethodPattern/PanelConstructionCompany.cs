namespace FactoryMethod
{
    public class PanelConstructionCompany : ConstructionCompany
    {
        public PanelConstructionCompany(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}