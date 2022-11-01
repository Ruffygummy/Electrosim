using System;
using System.Collections.Generic;
using System.Text;

namespace Electrosim.Simulation.Components
{
    class Diode : BaseComponent
    {
        public InputPort Input { get; set; }
        public OutputPort Output { get; set; }
        public override ComponentValue CalculateVoltage()
        {
            throw new NotImplementedException();
        }
    }
}
