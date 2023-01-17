namespace ds.test.impl.Service
{
    public interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }

        IPlugin GetPlugin(string pluginName);
    }
}