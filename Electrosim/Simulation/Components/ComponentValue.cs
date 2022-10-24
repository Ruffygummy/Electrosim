namespace Electrosim.Simulation.Components
{
    public struct ComponentValue
    {
        public float Value { get; set; }
        public short Factor { get; set; }

        public override string ToString()
        {
            return Value + "*" + Factor;
        }
    }
}