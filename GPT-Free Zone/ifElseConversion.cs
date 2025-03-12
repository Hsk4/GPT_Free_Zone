using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_Free_Zone
{
    internal class ifElseConversion
    {
        public static void Statements() 
        {
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";


            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-shirt";
                    break ;

                case "03":
                    type = "Sweat Pants";
                    break ;
                default:
                    type = "other";
                    break ;

            }  
            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break ;

                default:
                    color = "White";
                    break ;

            }
            switch (product[2])
            {
                case "S":
                    type = "Large";
                    break;
                case "M":
                    size = "Medium";
                    break ;

                case "L":
                    size = "Large";
                    break ;
                default:
                    size = "other";
                    break ;

            }


            Console.WriteLine($"Product: {size}-{color}-{type} ");
            Console.ReadLine();
        }
    }
}
