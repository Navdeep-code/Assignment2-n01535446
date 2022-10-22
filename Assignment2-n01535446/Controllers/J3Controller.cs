using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace Assignment2_n01535446.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// this program calculates how much time is needed to type certain words in an old cell phone with buttons.
        /// The assumption used here is that it takes one second per press, and
      ///  whenever there is a pause there is a lose of additional two seconds.This program calculates
      ///  the minimal time needed to type a message, under the above assumptions.
        /// </summary>
        /// <param name="s1">String input of a word i want to calculate the typing time for</param>
        /// <returns>returns the time in seconds that it takes to type the word</returns>
        /// <example>
        /// GET : /api/J3/Cell/a                    ->  1 seconds
        /// GET : /api/J3/Cell/dada                 ->  4 seconds
        /// GET : /api/J3/Cell/bob                  ->  7 seconds
        /// GET : /api/J3/Cell/abba                 ->  12 seconds
        /// GET : /api/J3/Cell/cell                 ->  13 seconds
        /// GET : /api/J3/Cell/www                  ->  7 seconds
        /// </example>
                [Route("api/J3/Cell/{s1}")]
        [HttpGet]
    public string Cell(string s1)
        {
            List<String> input = new List<string> {"abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
            List<int> plus = new List<int> { };
            int time = 0;
            
        for(int i = 0; i < s1.Length; i++)
            {
                for(int j=0; j < input.Count; j++)
                {
                 for(int k = 0; k < input[j].Length; k++)
                    {

                        if (input[j].ElementAt(k) == s1.ElementAt(i))
                        {
                            time=time+(k+1);
                            plus.Add(j);
                        }
                    }
                }
            }
        for(int i = 0; i < plus.Count; i++)
            {
                if (i>0 && plus[i-1] == plus[i])
                {
                    time = time + 2;
                }
            }
            
            return time+" seconds"; 
        }
    }
}
