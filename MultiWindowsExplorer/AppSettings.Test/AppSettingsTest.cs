using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiWindowsExplorer;

namespace AppSettingsTest
{
    [TestClass]
    public class AppSettingsTest
    {
        [TestMethod]
        public void TestSimpleAdd()
        {
            int res = AppSettings.add(3,4);
            
            Assert.AreEqual(7,res);
        }

        [TestMethod]
        public void TestAppsettingsUpdate()
        {
            AppSettings.UpdateSettings("url1", "c:\\");
            String res = AppSettings.ReadSetting("url1");
            Assert.AreEqual("c:\\", res);
        }
    }
}
