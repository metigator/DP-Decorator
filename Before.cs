namespace DP_WithoutDecorator
{
    public class IceCream
    {
        public virtual string Description => "Ice cream";
        public virtual decimal CalculateCost() => 3.5m;

        public override string ToString()
        {
            return $"{Description} ({CalculateCost().ToString("C")})";
        }
    }

    public class IceCreamWithSprinkles : IceCream
    {
        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base.CalculateCost() + .25m;
    }
    public class IceCreamWithChocolateChips : IceCream
    {
        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base.CalculateCost() + .45m;
    }

    public class IceCreamWithFruitMix : IceCream
    {
        public override string Description => $"{base.Description} + Fruit Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .60m;
    }
}