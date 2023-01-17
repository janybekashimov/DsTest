using ds.test.impl.Service;
using NUnit.Framework;
using System;
using System.Drawing;

namespace DSLibTests
{
    [TestFixture]
    public class LibTests
    {
        private Plugins _plugins;
        private IPlugin _addition;
        private IPlugin _subtraction;

        [SetUp]
        public void UnitTest()
        {
            _plugins = new Plugins();
            _addition = _plugins.GetPlugin("Addition");
            _subtraction = _plugins.GetPlugin("Subtraction");
        }
 
        [Test]
        public void TestPlugin()
        {
            Assert.IsInstanceOf(typeof(IPlugin), _addition);
            Assert.IsInstanceOf(typeof(IPlugin), _subtraction);
            Assert.Throws<Exception>(() => _plugins.GetPlugin("Не правильное название."));
        }

        [Test]
        public void TestAddition() 
        {
            Assert.AreEqual(9, _addition.Run(5, 4));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.AreEqual(6, _subtraction.Run(10, 4));
        }
    }
}