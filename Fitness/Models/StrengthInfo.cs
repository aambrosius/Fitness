using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness.Models
{
    public class StrengthInfo {
        public static string[] GetLifts() {
            //private string[] test;
        string[] lift = {
                "Back Squat",
                "Front Squat",
                "Overhead Squat",
                "Clean & Jerk",
                "Snatch"};

            return lift;
        }
        
    }
}