using System;
using System.Collections.Generic;
using System.Text;

namespace Electrosim.Simulation.Components
{
    class Relais : BaseComponent
    {
        public Switch ControlSwitch { get; set; }
        public InputPort Input { get; set; }
        public OutputPort Output { get; set; }
        public override ComponentValue CalculateVoltage()
        {
            throw new NotImplementedException();
        }
    }
}
