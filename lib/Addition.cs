using ds.test.impl.Service;
using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DsTest
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
