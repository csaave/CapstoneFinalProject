//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Web;
//using fitness_capstone_4.Models;

//namespace fitness_capstone_4.Data
//{
//    public static class Data
//    {
//        public static List<Activity> Activities { get; set; }


//        public static List<Entry> Entries { get; set; }

//        static Data()
//        {
//            InitData();
//        }

//        public static void InitData()
//        {

//            var Workouts = new List<Workouts>()
//            {
//                new Workouts(Models.Workouts.ActivityType.Squats),
//                new Workouts(Models.Workouts.ActivityType.Deadlift),
//                new Workouts(Models.Workouts.ActivityType.CalfRaises),
//                new Workouts(Models.Workouts.ActivityType.BenchPress),
//                new Workouts(Models.Workouts.ActivityType.DumbellCurls),
//                new Workouts(Models.Workouts.ActivityType.PullUps),
//                new Workouts(Models.Workouts.ActivityType.PushUps),
//            };

//            var entries = new List<Entry>()
//            {
//                new Entry(1, 2016, 7, 8, Models.Workouts.ActivityType.Squats, 10.0),
//                new Entry(2, 2016, 7, 9, Models.Workouts.ActivityType.Deadlift, 12.2),
//                new Entry(3, 2016, 7, 10, Models.Workouts.ActivityType.CalfRaises, 123.0),
//                new Entry(4, 2016, 7, 12, Models.Workouts.ActivityType.BenchPress, 10.0),
//                new Entry(5, 2016, 7, 13, Models.Workouts.ActivityType.DumbellCurls, 32.2),
//                new Entry(6, 2016, 7, 13, Models.Workouts.ActivityType.PullUps, 13.3),
//                new Entry(7, 2016, 7, 14, Models.Workouts.ActivityType.PushUps, 10.0),
//            };

//            Workouts = Workouts;
//            Entries = entries;
//        }
//    }
//}