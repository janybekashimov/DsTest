using System.Drawing;

namespace ds.test.impl
{
    public class Subtraction : PluginAbstract, IPlugin
    {
        public string PluginName
        {
            get
            {
                return "Subtraction";
            }
        }

        public Image Image
        {
            get
            {
                return Image.FromFile("img/minus.png");
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
        /// Возвращает разность двух чисел
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}