using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgorovTestLib
{
    public static class MaterialCalculator
    {
        public static int CalculateMaterial(int count, double width, double length, string productType, string materialType)
        {
            if (productType != "Type 1" && productType != "Type 2" && productType != "Type 3")
                return -1;


            if (materialType != "Type 1" && materialType != "Type 2")
                return -1;

            double productTypeMultiplier = 0;
            double materialTypeMultiplier = 0;

            switch (productType)
            {
                case "Type 1":
                    productTypeMultiplier = 1.1;
                    break;
                case "Type 2":
                    productTypeMultiplier = 2.5;
                    break;
                case "Type 3":
                    productTypeMultiplier = 8.43;
                    break;
            }

            switch (materialType)
            {
                case "Type 1":
                    materialTypeMultiplier = 1.003;
                    break;
                case "Type 2":
                    materialTypeMultiplier = 1.0012;
                    break;
            }

            return (int)Math.Round((count * width * length * productTypeMultiplier * materialTypeMultiplier));
        }

    }
}
