namespace Electrosim.Simulation.Components
{
    internal class Resistor : BaseComponent
    {
        public ComponentValue Value;
        public InputPort Input { get; set; }
        public OutputPort Output { get; set; }

        public override ComponentValue CalculateVoltage()
        {
            var input = Input.CalculateVoltage();
            var output = Output.CalculateVoltage();

            throw new System.NotImplementedException();
        }
    }
}