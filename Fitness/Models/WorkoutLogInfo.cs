using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fitness.Models
{
    public class WorkoutLogInfo {

        public WorkoutLogInfo(DateTime date, string strength, string title) {
            Date = date;
            Strength = strength;
            Title = title;
        }
        public DateTime Date { get; set; }
        public string Strength { get; set; }
        public string Title { get; set; }
    }
}