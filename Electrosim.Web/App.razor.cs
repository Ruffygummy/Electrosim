using Avalonia.Web.Blazor;

namespace Electrosim.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<Electrosim.App>()
            .SetupWithSingleViewLifetime();
    }
}