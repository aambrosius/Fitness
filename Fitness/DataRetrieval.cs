using System;
using System.Collections.Generic;
using System.Linq;
using Fitness.Models;

namespace Fitness {
    public class DataRetrieval {
        public static List<WorkoutLogInfo> LoadLog() {
            return new List<WorkoutLogInfo> {
                new WorkoutLogInfo(DateTime.Today, "Back Sqaut", "4x3 @ 80%"),
                new WorkoutLogInfo(DateTime.Today.AddDays(-1), "Snatch", "20 EMOM @55%"),
                new WorkoutLogInfo(DateTime.Today.AddDays(-2), "Clean & Jerk", "10 EOMOM @70%")
            }.ToList();
        }
    }
}