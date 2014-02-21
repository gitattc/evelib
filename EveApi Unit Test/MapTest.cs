﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eZet.Eve.EolNet.Test {
    /// <summary>
    /// Summary description for MapTest
    /// </summary>
    /// 
    [TestClass]
    public class MapTest {

        private readonly EolNet api = new EolNet();
  

        [TestMethod]
        public void TestFacWarSystems() {
            var xml = api.Map.GetFactionWarSystems();
            Assert.IsNotNull(xml.Result.SolarSystems.First().SolarSystemName);
        }

        [TestMethod]
        public void TestJumps() {
            var xml = api.Map.GetJumps();
            Assert.AreNotEqual(0, xml.Result.SolarSystems.First().SolarSystemId);
        }

        [TestMethod]
        public void TestKills() {
            var xml = api.Map.GetKills();
            Assert.AreNotEqual(0, xml.Result.SolarSystems.First().SolarSystemId);
        }

        [TestMethod]
        public void TestSovereignty() {
            var xml = api.Map.GetSovereignty();
            Assert.IsNotNull(xml.Result.SolarSystems.First().SolarSystemName);
        }

        [TestMethod]
        public void TestSovereigntyStatus() {
            //api.Map.GetSovereigntyStatus();
        }





    }
}
