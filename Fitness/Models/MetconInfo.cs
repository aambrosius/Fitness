using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness.Models
{
    public class MetconInfo
    {
        public static string[] GetMetcons()
        {
            //private string[] test;
            string[] metcon = {
                "Diane",
                "Fran",
                "Nancy",
                "Filthy Fifty",
                "Grace"};

            return metcon;
        }
    }
}