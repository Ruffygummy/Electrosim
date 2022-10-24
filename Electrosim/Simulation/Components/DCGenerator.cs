namespace Electrosim.Simulation.Components
{
    internal class DCGenerator : BaseComponent
    {
        public ComponentValue Value;
        public int NPol { get; set; }
        public int PPol { get; set; }

        public override ComponentValue CalculateVoltage()
        {
            throw new System.NotImplementedException();
        }
    }
}