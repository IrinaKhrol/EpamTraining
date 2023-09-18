namespace InterfacesAndAbstractClasses
{
    internal interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        double GetFlyTime(Coordinate coordinate);
    }
}
