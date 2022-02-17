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
    public class TestsGarden
    {
        [TestMethod()]
        public void GardenConstructor()
        {
            try
            {
                    GardenParcel flowerGarden = new GardenParcel(10, 15);
                    GardenParcel kitchenGarden = new GardenParcel(10, 16);
                    Garden marysGarden = new Garden("Mária", flowerGarden, kitchenGarden);
            }
            catch (Exception e)
            {
                Assert.Fail("A kert konstruktor kivételt dob:" + e.Message);
            }
        }


        [TestMethod()]
        public void GardenConstructorToString()
        {
            try
            {
                GardenParcel flowerGarden = new GardenParcel(10, 15);
                GardenParcel kitchenGarden = new GardenParcel(10, 16);
                Garden marysGarden = new Garden("Mária", flowerGarden, kitchenGarden);
                string expected = "Mária kertjének összeterülete 310 négyzetméter.";
                string actual = marysGarden.ToString();
                Assert.AreEqual(expected, actual, "A konstruktor nem megfelelően működik vagy a ToString nem megfelelő eredményt adja.");
            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész konstruktor kivételt dob:" + e.Message);
            }
        }

        [TestMethod()]
        public void GardenConstructorWrongGarden()
        {
            try
            {
                GardenParcel flowerGarden = new GardenParcel(11, 15);
                GardenParcel kitchenGarden = new GardenParcel(10, 16);
                Garden marysGarden = new Garden("Mária", flowerGarden, kitchenGarden);

                Assert.IsFalse(marysGarden.IsGardenGood, "Rossz kertméret esetén a kertet mégis jónak ítéli a kód.");

                
                string expected = "";
                string actual = marysGarden.ToString();
                Assert.AreEqual(expected, actual, "Rossz kertméret esetén a kert ToString metódusa nem üres karakterlánc.");

                double expectedProperties = 0;
                double actualProperties = marysGarden.TotalArea;
                Assert.AreEqual(expectedProperties, actualProperties, "Rossz kertméret esetén az összterület nem nulla.");

                int expectedFence = 0;
                int actualFence = marysGarden.FlowerGardenFenceElementsNumber;
                Assert.AreEqual(expectedFence, actualFence, "Rossz kertméret esetén a virágos kert esetén a kerítéselemek száma nem nulla.");


                actualFence = marysGarden.KitchenGardenFenceElementsNumber;
                Assert.AreEqual(expectedFence, actualFence, "Rossz kertméret esetén a konyha kert esetén a kerítéselemek száma nem nulla.");

                actualFence = marysGarden.GardenFenceNumber;
                Assert.AreEqual(expectedFence, actualFence, "Rossz kertméret esetén a kert esetén a kerítéselemek száma nem nulla.");

            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész  kivételt dob:" + e.Message);
            }
        }

        [TestMethod()]
        public void GardenProperties()
        {
            try
            {
                GardenParcel flowerGarden = new GardenParcel(10.25, 15.33);
                GardenParcel kitchenGarden = new GardenParcel(10.25, 19.54);
                Garden marysGarden = new Garden("Mária", flowerGarden, kitchenGarden);
                double expected = 357.4175;
                double actual = marysGarden.TotalArea;
                Assert.AreEqual(expected, actual, 0.01, "A területet nem megfelelően számolta ki.");
                int expectedFlowerGardenFence = 128;
                int expectedKitchenGardenFence = 149;
                int actualFlowerGardenFence = marysGarden.FlowerGardenFenceElementsNumber;
                int actualKitchenGardenFence = marysGarden.KitchenGardenFenceElementsNumber;
                Assert.AreEqual(expectedFlowerGardenFence, actualFlowerGardenFence, "A virágoskert kerítéselemek számát nem jól határozta meg!");
                Assert.AreEqual(expectedKitchenGardenFence, actualKitchenGardenFence, "A konyhakert kerítéselemeinek számát nem jól határozta meg!");
                int expectedGardenFence = 252;
                int actualGardenFence = marysGarden.GardenFenceNumber;
                Assert.AreEqual(expectedGardenFence, actualGardenFence,"A kertek bekerítéséhez szükséges kerítéselemek számát nem jól határozta meg!");
            }
            catch (Exception e)
            {
                Assert.Fail("A kert rész  kivételt dob:" + e.Message);
            }
        }

           }
}