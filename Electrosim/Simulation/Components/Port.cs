namespace Electrosim.Simulation.Components
{
    internal abstract class Port : BaseComponent
    {
        public int ID { get; set; }
        public ComponentValue Voltage { get; set; }

        public override ComponentValue CalculateVoltage()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class InputPort : Port
    {
    }

    internal class OutputPort : Port
    {
    }
}