using BuilderDesignPattern.Interface;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Builder
{
    public class CountryHomeBuilders : IHouseBuilder
    {
        House HouseData = new House();
        public CountryHomeBuilders()
        {
            HouseData.Model = "Country Home";
        }
        public void BuildHouseFoundation()
        {
            HouseData.FoundationType = "Poured Concrete";
        }

        public void BuildFrames()
        {
            HouseData.Frames = "Wood";
        }
        public void BuildFloor()
        {
            HouseData.FloorType = "Wood";
        }
        public void BuildRoof()
        {
            HouseData.RoofType = "Wood Shingles";
        }

        public void BuildWalls()
        {
            HouseData.WallType = "Wood";
        }

        public void BuildEssentials()
        {
            HouseData.Essentials.Add("2 Bedrooms");
            HouseData.Essentials.Add("1 Bathroom");
            HouseData.Essentials.Add("1 Comfort Room");
            HouseData.Essentials.Add("Living Room");
            HouseData.Essentials.Add("Kitchen");
        }

        public void BuildFinishing()
        {
            HouseData.Finishings.Add("Natural Roof Painting");
            HouseData.Finishings.Add("Wood Interior Paint");
        }
        public House GetHouse()
        {
            return HouseData;
        }
    }
}
