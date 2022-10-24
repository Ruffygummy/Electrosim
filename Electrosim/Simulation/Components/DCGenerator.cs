namespace Electrosim.Simulation.Components
{
    internal class DCGenerator : BaseComponent
    {
        public ComponentValue Value;
        public OutputPort NPol { get; set; }
        public OutputPort PPol { get; set; }

        public override ComponentValue CalculateVoltage()
        {
            throw new System.NotImplementedException();
        }
    }
}