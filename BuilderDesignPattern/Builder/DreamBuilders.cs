using BuilderDesignPattern.Interface;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builder
{
    public class DreamBuilders : IHouseBuilder
    {
        House HouseData = new House();
        public DreamBuilders()
        {
            HouseData.Model = "Alexandria";
        }
        public void BuildHouseFoundation()
        {
            HouseData.FoundationType = "Poured Concrete";
        }

        public void BuildFrames()
        {
            HouseData.Frames = "Concrete";
        }
        public void BuildFloor()
        {
            HouseData.FloorType = "Concrete";
        }
        public void BuildRoof()
        {
            HouseData.RoofType = "Mansard Roof";
        }

        public void BuildWalls()
        {
            HouseData.WallType = "Bricks";
        }

        public void BuildEssentials()
        {
            HouseData.Essentials.Add("3 Bedrooms");
            HouseData.Essentials.Add("1 Bathroom");
            HouseData.Essentials.Add("1 Comfort Room");
            HouseData.Essentials.Add("Living Room");
            HouseData.Essentials.Add("Kitchen");
        }

        public void BuildFinishing()
        {
            HouseData.Finishings.Add("Maroon Roof Painting");
            HouseData.Finishings.Add("Sky blue Interior Paint");
        }
        public House GetHouse()
        {
            return HouseData;
        }
    }
}
