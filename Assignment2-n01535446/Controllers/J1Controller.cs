using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01535446.Controllers
{
    public class J1Controller : ApiController
    {    /// <summary>
         /// At Chip’s Fast Food emporium there's a very simple menu. Each food item is selected by entering a digit choice.
         /// This program will compute the total Calories of the meal.
         /// </summary>
         /// <param name="burger">Integer representing the index burger choice</param>
         /// <param name="drink">Integer representing the index drink choice</param>
         /// <param name="side">Integer representing the index side order choice</param>
         /// <param name="dessert">Integer representing the index dessert choice</param>
         /// <returns>String message giving the computed total calories of the meal</returns>
         /// <example>
         /// Get: /api/J1/Menu/4/4/4/4        ->Your total calorie count is 0
         /// GET: /api/J1/Menu/1/2/3/4       ->Your total calorie count is 691
         /// </example>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger,int drink,int side,int dessert)
        {
           List<int> burgercal = new List<int> { 461,431,420,0};
            List<int> drinkcal = new List<int> { 130,160,118,0 };
            List<int> sidecal = new List<int> {100,57,70,0 };
            List<int> dessertcal = new List<int> { 167,266,75,0};
            int Caloryburger=0;
            int Calorydrink=0;
            int Caloryside=0;
            int Calorydessert=0;
            int totalcal;

            for (int i = 0; i < burgercal.Count; i++)
            {
                if ((i + 1) == burger) {
                    Caloryburger = burgercal[i];
                }
            }


            for (int i = 0; i < drinkcal.Count; i++)
            {
                if ((i + 1) == drink)
                {
                    Calorydrink = drinkcal[i];
                }
            }


            for (int i = 0; i < sidecal.Count; i++)
            {
                if ((i + 1) == side)
                {
                    Caloryside = sidecal[i];
                }
            }


            for (int i = 0; i < dessertcal.Count; i++)
            {
                if ((i + 1) == dessert)
                {
                    Calorydessert = dessertcal[i];
                }
            }

            totalcal = Caloryburger + Calorydrink + Caloryside + Calorydessert;

            return "The total calorie count is "+totalcal;
        }
    }
}
