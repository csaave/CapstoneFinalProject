namespace fitness_capstone_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingstartofmiscclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ActivityId = c.Int(nullable: false),
                        Duration = c.Double(nullable: false),
                        Exclude = c.Boolean(nullable: false),
                        Notes = c.String(maxLength: 200),
                        Workouts_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workouts", t => t.Workouts_Id)
                .Index(t => t.Workouts_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "Workouts_Id", "dbo.Workouts");
            DropIndex("dbo.Entries", new[] { "Workouts_Id" });
            DropTable("dbo.Entries");
        }
    }
}
