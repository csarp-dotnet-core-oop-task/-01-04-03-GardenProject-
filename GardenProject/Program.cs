using System;

namespace GardenProject
{
    public class GardenParcel
    {
        private double sideFirst;
        private double sideSecond;

        public double SideFirst { get => sideFirst;  }
        public double SideSecond { get => sideSecond; }

        public GardenParcel(double sideFirst, double sideSecond)
        {
            this.sideFirst = sideFirst;
            this.sideSecond = sideSecond;
        }

        public double Area
        {
            get
            {
                double area = sideFirst * sideSecond;
                return area;
            }
        }

        public double Perimeter
        {
            get
            {
                double perimeter = 2 * sideFirst + 2 * sideSecond;
                return perimeter;
            }
        }

        public double PartEnclosed
        {
            get
            {
                if (sideFirst < sideSecond)
                    return Perimeter - sideFirst;
                else
                    return Perimeter - sideSecond;
            }
        }



        public override string ToString()
        {
            string output = "A " + sideFirst + "x" + sideSecond + " méretekkel adott parcella területe " + Area + " négyzetméter, kerülete " + Perimeter + " méter.";
            return output;
        }
    }
    public class Garden
    {
        private string gardenOwner;
        private GardenParcel flowerGarden;
        private GardenParcel kitchenGarden;

        public Garden(string gardenOwner, GardenParcel flowerGarden, GardenParcel kitchenGarden)
        {
            if ((flowerGarden.SideFirst == kitchenGarden.SideFirst) || (flowerGarden.SideFirst == kitchenGarden.SideSecond) ||
                (flowerGarden.SideSecond == kitchenGarden.SideFirst) || (flowerGarden.SideSecond == kitchenGarden.SideSecond))
            {
                this.gardenOwner = gardenOwner;
                this.flowerGarden = flowerGarden;
                this.kitchenGarden = kitchenGarden;
            }
            else
            {
                this.gardenOwner = string.Empty;
                this.flowerGarden = null;
                this.kitchenGarden = null;
            }
        }

        public bool IsGardenGood
        {
            get
            {
                if ((flowerGarden != null) && (kitchenGarden != null))
                    return true;
                else
                    return false;
            }
        }

        public double TotalArea
        {
            get
            {
                if (IsGardenGood)
                {
                    double result = flowerGarden.Area + kitchenGarden.Area;
                    return result;
                }
                else
                    return 0;
            }
        }

        public int KitchenGardenFenceElementsNumber
        {
            get
            {
                if (IsGardenGood)
                {
                    double fenceElementWidth = 0.4;
                    int result = (int)Math.Ceiling(kitchenGarden.Perimeter / fenceElementWidth);
                    return result;
                }
                else
                    return 0;
            }
        }

        public int FlowerGardenFenceElementsNumber
        {
            get
            {
                if (IsGardenGood)
                {
                    double fenceElementWidth = 0.4;
                    int result = (int)Math.Ceiling(flowerGarden.Perimeter / fenceElementWidth);
                    return result;
                }
                else
                    return 0;
            }
        }

        public int GardenFenceNumber
        {
            get
            {
                if (IsGardenGood)
                {
                    double fenceElementWidth = 0.4;
                    double gardenPerimeter = flowerGarden.PartEnclosed + kitchenGarden.Perimeter;
                    int fencedPerimeter = (int)Math.Ceiling(gardenPerimeter / fenceElementWidth);
                    return fencedPerimeter;
                }
                else
                    return 0;
            }
        }


        public override string ToString()
        {
            if (IsGardenGood)
            {
                string output = gardenOwner + " kertjének összeterülete " + TotalArea + " négyzetméter.";
                return output;
            }
            else
                return string.Empty;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GardenParcel flowerGarden = new GardenParcel(10, 15);
            Console.WriteLine(flowerGarden);

            GardenParcel kitchenGarden = new GardenParcel(10, 6);
            Garden marysGarden = new Garden("Mária", flowerGarden,kitchenGarden);
            Console.WriteLine(marysGarden);
            Console.WriteLine(marysGarden.KitchenGardenFenceElementsNumber);
            Console.WriteLine(marysGarden.FlowerGardenFenceElementsNumber);
            Console.WriteLine(marysGarden.GardenFenceNumber);

        }
    }
}
