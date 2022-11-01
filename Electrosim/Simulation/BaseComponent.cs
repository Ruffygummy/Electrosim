using Electrosim.Simulation.Components;

namespace Electrosim.Simulation
{

    internal abstract class BaseComponent
    {
        public abstract ComponentValue CalculateVoltage();
    }
}