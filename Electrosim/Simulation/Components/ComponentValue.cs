namespace Electrosim.Simulation.Components
{
    public class ComponentValue
    {
        public ComponentValue(int value, short factor)
        {
            Value = value;
            Factor = factor;
        }

        public int Value { get; set; }
        public short Factor { get; set; }

        public override string ToString()
        {
            return Value + "*" + Factor;
        }
    }
}