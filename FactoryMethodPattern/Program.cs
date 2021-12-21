using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructionCompany company = new PanelConstructionCompany("ООО КирпичСтрой");
            House panelHouse = company.Create();

            company = new WoodConstructionCompany("Частный застройщик");
            House woodHouse = company.Create();

            Console.ReadLine();
        }
    }
}