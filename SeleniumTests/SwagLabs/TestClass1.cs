using Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.SwagLabs
{
    internal class TestClass1
    {
        [Test]
        public void test1()
        {
            var t = AppConfiguration.Browser.Hedless;
        }
    }
}
