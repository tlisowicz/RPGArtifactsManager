namespace RPGArtifactsMenager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentCategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.Categories", t => t.ParentCategoryID)
                .Index(t => t.ParentCategoryID);
            
            CreateTable(
                "dbo.CategoryProperty",
                c => new
                    {
                        CategoryID = c.Int(nullable: false),
                        PropertyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryID, t.PropertyID })
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.PropertyID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.PropertyID);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PropertyID);
            
            CreateTable(
                "dbo.InstanceProperty",
                c => new
                    {
                        InstanceID = c.Int(nullable: false),
                        PropertyID = c.Int(nullable: false),
                        PropertyValue = c.String(),
                    })
                .PrimaryKey(t => new { t.InstanceID, t.PropertyID })
                .ForeignKey("dbo.Instances", t => t.InstanceID, cascadeDelete: true)
                .ForeignKey("dbo.Properties", t => t.PropertyID, cascadeDelete: true)
                .Index(t => t.InstanceID)
                .Index(t => t.PropertyID);
            
            CreateTable(
                "dbo.Instances",
                c => new
                    {
                        InstanceID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InstanceID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.PropertyTypes",
                c => new
                    {
                        PropertyTypeID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        PropertyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyTypeID)
                .ForeignKey("dbo.Properties", t => t.PropertyID, cascadeDelete: true)
                .Index(t => t.PropertyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyTypes", "PropertyID", "dbo.Properties");
            DropForeignKey("dbo.InstanceProperty", "PropertyID", "dbo.Properties");
            DropForeignKey("dbo.InstanceProperty", "InstanceID", "dbo.Instances");
            DropForeignKey("dbo.Instances", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.CategoryProperty", "PropertyID", "dbo.Properties");
            DropForeignKey("dbo.CategoryProperty", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ParentCategoryID", "dbo.Categories");
            DropIndex("dbo.PropertyTypes", new[] { "PropertyID" });
            DropIndex("dbo.Instances", new[] { "CategoryID" });
            DropIndex("dbo.InstanceProperty", new[] { "PropertyID" });
            DropIndex("dbo.InstanceProperty", new[] { "InstanceID" });
            DropIndex("dbo.CategoryProperty", new[] { "PropertyID" });
            DropIndex("dbo.CategoryProperty", new[] { "CategoryID" });
            DropIndex("dbo.Categories", new[] { "ParentCategoryID" });
            DropTable("dbo.PropertyTypes");
            DropTable("dbo.Instances");
            DropTable("dbo.InstanceProperty");
            DropTable("dbo.Properties");
            DropTable("dbo.CategoryProperty");
            DropTable("dbo.Categories");
        }
    }
}
