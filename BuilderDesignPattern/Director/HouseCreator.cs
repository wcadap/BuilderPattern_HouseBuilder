using BuilderDesignPattern.Interface;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Director
{
    public class HouseCreator
    {
        IHouseBuilder HouseBuilder;
        public HouseCreator(IHouseBuilder _HouseBuilder)
        {
            HouseBuilder = _HouseBuilder;
        }
        public void CreateHouse()
        {
            HouseBuilder.BuildHouseFoundation();
            HouseBuilder.BuildFrames();
            HouseBuilder.BuildFloor();
            HouseBuilder.BuildRoof();
            HouseBuilder.BuildWalls();
            HouseBuilder.BuildEssentials();
            HouseBuilder.BuildFinishing();
        }
        public House GetHouse()
        {
           return HouseBuilder.GetHouse();
        }
    }
}
