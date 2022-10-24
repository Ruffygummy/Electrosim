namespace Electrosim.Simulation.Components
{
    internal class Resistor : BaseComponent
    {
        public ComponentValue Value;
        public int Input { get; set; }
        public int Output { get; set; }

        public override ComponentValue CalculateVoltage()
        {
            throw new System.NotImplementedException();
        }
    }
}