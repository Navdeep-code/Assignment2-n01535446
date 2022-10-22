using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01535446.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This program determines how many ways value 10 can be obtained by rolling two dice with m and n number of sides
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <returns>String message showing the total number of ways the sum 10 be obtained when the two dice are rolled</returns>
        /// <example>
        /// GET : /api/J2/DiceGame/6/8        -> There are 5 total ways to get the sum 10.
        /// GET : /api/J2/DiceGame/12/4       -> There are 4 ways to get the sum 10.
        /// GET : /api/J2/DiceGame/3/3        -> There are 0 ways to get the sum 10.
        /// GET : /api/J2/Dicegame/5/5        -> There is 1 way to get the sum 10.
        /// </example>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m,int n) {
            int value=10;
            int counter = 0;
 
        for(int i= 1; i <= m; i++)
            {
                for (int j=1; j <= n; j++)
                {
                    if ((i+j) == value)
                    {
                        counter++;
                  
                    }
                }
            }
            return "There are "+counter+" total ways to get the sum "+value;
        }
    }
}
