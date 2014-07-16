using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.Interface
{
    //Inteface that defines the steps in building house product
    public interface IHouseBuilder
    {
        void BuildHouseFoundation();
        void BuildFrames();
        void BuildFloor();
        void BuildRoof();
        void BuildWalls();
        void BuildEssentials();
        void BuildFinishing();
        House GetHouse();
    }
}
