namespace ConsoleApplication1
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }




    interface IInvader : IMappable, IMovable
    {
        bool HasScored { get; }
        int Health { get; }
        bool isActive { get; }
        bool isNeutralized { get; }


        void DecreaseHealth(int factor);

    }
}