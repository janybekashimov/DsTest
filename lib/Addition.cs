using System.Drawing;

namespace ds.test.impl
{
    public class Addition : PluginAbstract, IPlugin
    {
        public string PluginName
        {
            get
            {
                return "Addition";
            }
        }

        public Image Image
        {
            get
            {
                return Image.FromFile("img/plus.png");
            }
        }

        public string Description
        {
            get
            {
                return "Объект, который реализует добавление";
            }
        }

        /// <summary>
        /// Возвращает сумму двух чисел
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}