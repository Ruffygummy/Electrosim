using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Electrosim.Simulation;

internal class Scene
{
    public List<BaseComponent> Components { get; set; }

    public string Name { get; set; }

    public static Scene Load(string filename)
    {
        Scene loadData = JsonConvert.DeserializeObject<Scene>(File.ReadAllText(filename));
        return loadData;
    }

    public void Save(string filename)
    {
        string saveData = JsonConvert.SerializeObject(this);
        File.WriteAllText(filename, saveData);
    }
}