namespace fitness_capstone_4.Migrations
{
    using fitness_capstone_4.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<fitness_capstone_4.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(fitness_capstone_4.Models.ApplicationDbContext context)
        {
            context.Workouts.AddOrUpdate(
                p => p.WorkoutType,
            new Workouts { WorkoutType = "Squats" },
            new Workouts { WorkoutType = "DeadLift" },
            new Workouts { WorkoutType = "CalfRaises" },
            new Workouts { WorkoutType = "BenchPress" },
            new Workouts { WorkoutType = "DumbellCurls" },
            new Workouts { WorkoutType = "PullUps" },
            new Workouts { WorkoutType = "PushUps" },
            new Workouts { WorkoutType = "DeadLift"}
                
            );
        }
    }
}
