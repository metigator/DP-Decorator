namespace DP_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream order = new StrawberryIceCream();
            order = new Sprinkles(order);
            order = new ChocolateChips(order);
            order = new FruiteMix(order);
            Console.WriteLine(order);

            Console.ReadKey();
        }
    }

    // Component 
    public abstract class IceCream
    {
        public abstract string Description { get; }
        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"{Description} ({CalculateCost().ToString("C")})";
        }
    }

    // Concrete Componenet
    public class BasicIceCream : IceCream
    {
        public override string Description => "Ice Cream";
        public override decimal CalculateCost() => 3.5m;
    }

    public class StrawberryIceCream : IceCream
    {
        public override string Description => "Strawberry Ice Cream";
        public override decimal CalculateCost() => 5.5m;
    }
    // Decorator

    public abstract class IceCreamDecorator : IceCream
    {
        protected IceCream _iceCream;

        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override string Description => _iceCream.Description;
        public override decimal CalculateCost() => _iceCream.CalculateCost();
    }

    // Concrete Decorator

    public class Sprinkles : IceCreamDecorator
    {
        public Sprinkles(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base.CalculateCost() + .25m;
    }

    public class ChocolateChips : IceCreamDecorator
    {
        public ChocolateChips(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base.CalculateCost() + .45m;
    }

    public class FruiteMix : IceCreamDecorator
    {
        public FruiteMix(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Fruite Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .75m;
    }
}