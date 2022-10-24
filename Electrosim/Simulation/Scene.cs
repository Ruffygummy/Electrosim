using System.Collections.Generic;

namespace Electrosim.Simulation;

internal class Scene
{
    public List<BaseComponent> Components { get; set; }

    public string Name { get; set; }

    public static Scene Load(string filename)
    {
        return null;
    }

    public void Save(string filename)
    {
    }
}