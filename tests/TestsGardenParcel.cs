using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using GardenProject;

namespace GardenProject.Tests
{
    [TestClass()]
    public class TestsGardenParcel
    {
        [TestMethod()]
        public void GardenParcelConstructor()
        {
            try
            {
                    GardenParcel flowerGarden = new GardenParcel(10, 15);
            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész konstruktor kivételt dob:" + e.Message);
            }
        }


        [TestMethod()]
        public void GardenParcelConstructorToString()
        {
            try
            {
                GardenParcel flowerGarden = new GardenParcel(10, 15);
                string expected = "A 10x15 méretekkel adott parcella területe 150 négyzetméter, kerülete 50 méter.";
                string actual = flowerGarden.ToString();
                Assert.AreEqual(expected, actual, "A konstruktor nem megfelelően működik vagy a ToString nem megfelelő eredményt adja.");
            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész konstruktor kivételt dob:" + e.Message);
            }
        }
        [TestMethod()]
        public void GardenParcelProperties()
        {
            try
            {
                GardenParcel flowerGarden = new GardenParcel(10, 15);
                double expected = 150;
                double actual = flowerGarden.Area;
                Assert.AreEqual(expected, actual, 0.01, "A területet nem megfelelően számolta ki.");
                expected = 50;
                actual = flowerGarden.Perimeter;
                Assert.AreEqual(expected, actual, 0.01, "A kerületet nem megfelelően számolta ki.");

            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész konstruktor kivételt dob:" + e.Message);
            }
        }

        [TestMethod()]
        public void GardenParcelPropertiesDouble()
        {
            try
            {
                GardenParcel flowerGarden = new GardenParcel(10.2, 15.8);
                double expected = 161.16;
                double actual = flowerGarden.Area;
                Assert.AreEqual(expected, actual, 0.01, "A területet nem megfelelően számolta ki.");
                expected = 52;
                actual = flowerGarden.Perimeter;
                Assert.AreEqual(expected, actual, 0.01, "A kerületet nem megfelelően számolta ki.");

            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész konstruktor kivételt dob:" + e.Message);
            }
        }
    }
}