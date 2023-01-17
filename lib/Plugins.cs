using System;

namespace ds.test.impl
{
    public class Plugins : IPluginFactory
    {
        /// <summary>
        /// Возвращает количество плагинов
        /// </summary>
        public int PluginsCount { get { return 2; } }

        /// <summary>
        /// Для использования плагина доступны только эти значении("Addition", "Subrtaction")
        /// </summary>
        public string[] GetPluginNames
        {
            get
            {
                return new[] { "Addition", "Subrtaction" };
            }
        }

        /// <summary>
        /// Метод выполняющие математические операции
        /// Доступны следующие операции:
        /// <item><term>Addition</term></item>
        /// <item><term>Subtraction</term></item>
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IPlugin GetPlugin(string pluginName)
        {
            IPlugin plugin;
            switch (pluginName)
            {
                case "Addition":
                    plugin = new Addition();
                    break;

                case "Subtraction":
                    plugin = new Subtraction();
                    break;

                default:
                    throw new Exception($"Этот плагин не поддерживается. Вы можете использовать след. плагины{GetPluginNames}");
            }
            return plugin;
        }
    }
}