namespace fitness_capstone_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWorkouts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkoutType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workouts");
        }
    }
}
