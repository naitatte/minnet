using Autofac;
using Newtonsoft.Json;

namespace Minnet.Tests;

public abstract class TestBase
{
    protected TestBase()
    {
        ModuleInitializer.Initialize();

        container = ModuleInitializer.Container;
        jsonSerializerSettings = container.Resolve<JsonSerializerSettings>();
    }

    protected readonly IContainer container;
    protected readonly JsonSerializerSettings jsonSerializerSettings;
}
