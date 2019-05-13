namespace DP03Builder.concretebuilder
{
    public class RoomRoofBuilder : Builder
    {
        public void BuildPart(House house)
        {
            house.Roof = "Normal Roof";
        }
    }
}
