using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VoytovichKA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VoytovichKA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Клим";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Клим", res);
        }
    }
}
