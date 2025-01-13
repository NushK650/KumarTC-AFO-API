using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTC_AFO_API.Services
{
    public class RestaurantPickerService
    {
                public string RestaurantPicker(string FastFoodCasualDiningFineDining)
        {
            string[] FineDining = new string[]
{
"Mezzo" , "Prime Table Steakhouse"," The Kitchen at Stonebrier", "Yogi Korean BBQ" , "Wine & Roses Hotel" , "Rubys & Roses Restaurant" , "Locanda Capri" ,"Galletto Ristorante" , "Scotties Shutters Brasserie", "SR Primse Steakhouse"
};
string[] FastFood = new string[]
{
"Mcdonalds" , "Jack in the Box","Taco Bell", "Burger King" , "Subway" , "Chic-Fil-A" , "Panda Express" ,"In-N-Out Burger" , "Wendy's", "Popeyes"
};
string[] CasualDining = new string[]
{
"Sam's Donuts" , "Starbucks ","Dutch Bros", "Frank's downtown cafe" , " Bean and Leaf Cafe" , "Rainbow Velvet" , "Red's" ,"Cafe Aroma" , " Tea Amo", "Sunshine Cafe"

};
            Random random = new Random();
            switch (FastFoodCasualDiningFineDining)
            {
                case "fast food":
                    int ran = random.Next(0, FastFood.Length);
                    return FastFood[ran];
                

                case "fine dining":
                    int ran2 = random.Next(0, FineDining.Length);
                   return FineDining[ran2];
                   

                case "casual dining":
                    int ran3 = random.Next(0, CasualDining.Length);
                    return CasualDining[ran3];
                    

                default:
                    return " invalid input ";
                    

            }

        }
    
    }
}