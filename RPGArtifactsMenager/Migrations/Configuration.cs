namespace RPGArtifactsMenager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RPGArtifactsManager.DatabaseRPG.MainTables;
    using RPGArtifactsManager.DatabaseRPG.UtilTables;
    internal sealed class Configuration : DbMigrationsConfiguration<RPGArtifactsManager.DatabaseRPG.RPGContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RPGArtifactsManager.DatabaseRPG.RPGContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Users
            context.Users.AddOrUpdate(new User { UserID = 1, role = User.Role.ADMIN, Name = "admin", Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" });

            //Categories
            context.Categories.AddOrUpdate(new Category() { CategoryID = 1, Name = "Playable" });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 2, Name = "Monsters" });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 3, Name = "Enviroment" });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 4, Name = "Humans",ParentCategoryID = 1 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 5, Name = "Elves", ParentCategoryID = 1 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 6, Name = "Dragons", ParentCategoryID = 2 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 7, Name = "Mages", ParentCategoryID = 4 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 8, Name = "Orcs", ParentCategoryID = 2 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 9, Name = "Ents", ParentCategoryID = 2 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 10, Name = "Forests", ParentCategoryID = 3 });
            context.Categories.AddOrUpdate(new Category() { CategoryID = 11, Name = "Caves", ParentCategoryID = 10 });

            //Properties
            context.Properties.AddOrUpdate(new Property() { PropertyID = 1, Name = "Name" });
            context.Properties.AddOrUpdate(new Property() { PropertyID = 2, Name = "Age" });
            context.Properties.AddOrUpdate(new Property() { PropertyID = 3, Name = "Strength" });
            context.Properties.AddOrUpdate(new Property() { PropertyID = 4, Name = "MagicStrength" });
            context.Properties.AddOrUpdate(new Property() { PropertyID = 5, Name = "Height" });
            context.Properties.AddOrUpdate(new Property() { PropertyID = 6, Name = "Area" });
            context.Properties.AddOrUpdate(new Property() { PropertyID = 7, Name = "Size" });

            //Properties to Category

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 1, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 1, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 1, PropertyID = 3 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 2, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 2, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 2, PropertyID = 3 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 3, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 3, PropertyID = 6 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 4, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 4, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 4, PropertyID = 3 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 4, PropertyID = 5 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 5, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 5, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 5, PropertyID = 3 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 5, PropertyID = 5 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 6, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 6, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 6, PropertyID = 3 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 6, PropertyID = 7 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 7, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 7, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 7, PropertyID = 3 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 7, PropertyID = 4 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 7, PropertyID = 5 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 8, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 8, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 8, PropertyID = 3 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 8, PropertyID = 5 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 9, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 9, PropertyID = 2 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 9, PropertyID = 3 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 9, PropertyID = 5 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 10, PropertyID = 1});
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 10, PropertyID = 6 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 10, PropertyID = 7 });

            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 11, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 11, PropertyID = 1 });
            context.CategoryProperty.AddOrUpdate(new CategoryProperty() { CategoryID = 11, PropertyID = 6 });

            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 1, PropertyID = 1, Type = "String" });
            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 2, PropertyID = 2, Type = "Integer" });
            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 3, PropertyID = 3, Type = "Integer" });
            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 4, PropertyID = 4, Type = "Integer" });
            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 5, PropertyID = 5, Type = "Decimal" });
            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 6, PropertyID = 6, Type = "Decimal" });
            context.PropertyTypes.AddOrUpdate(new PropertyType() { PropertyTypeID = 7, PropertyID = 7, Type = "String" });

            //Instances
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 4 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 5 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 3, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 6 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 4, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 7 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 5, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 8 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 6, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 9 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 7, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 10 });
            context.Instances.AddOrUpdate(new Instance() { InstanceID = 8, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CategoryID = 11 });

            //Human Instacnce
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 1, PropertyID = 1, PropertyValue = "Tact" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 1, PropertyID = 2, PropertyValue = "20" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 1, PropertyID = 3, PropertyValue = "30" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 1, PropertyID = 5, PropertyValue = "1,83" });

            //Elf Instance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 2, PropertyID = 1, PropertyValue = "Amarra" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 2, PropertyID = 2, PropertyValue = "320" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 2, PropertyID = 3, PropertyValue = "37" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 2, PropertyID = 5, PropertyValue = "1,75" });

            //DragonInstance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 3, PropertyID = 1, PropertyValue = "Aryn" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 3, PropertyID = 2, PropertyValue = "1000" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 3, PropertyID = 3, PropertyValue = "150" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 3, PropertyID = 7, PropertyValue = "Big" });

            //MageInstance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 4, PropertyID = 1, PropertyValue = "Stewart" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 4, PropertyID = 2, PropertyValue = "42" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 4, PropertyID = 3, PropertyValue = "30" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 4, PropertyID = 4, PropertyValue = "60" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 4, PropertyID = 5, PropertyValue = "1,68" });

            //OrcInstance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 5, PropertyID = 1, PropertyValue = "Turnip" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 5, PropertyID = 2, PropertyValue = "10" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 5, PropertyID = 3, PropertyValue = "43" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 5, PropertyID = 5, PropertyValue = "1,95" });

            //EntInstance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 6, PropertyID = 1, PropertyValue = "Fen" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 6, PropertyID = 2, PropertyValue = "5000" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 6, PropertyID = 3, PropertyValue = "50" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 6, PropertyID = 5, PropertyValue = "5,42" });

            //ForestInstance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 7, PropertyID = 1, PropertyValue = "Dark Forest" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 7, PropertyID = 5, PropertyValue = "1520,00" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 7, PropertyID = 7, PropertyValue = "Large" });


            //CaveInstance
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 8, PropertyID = 1, PropertyValue = "Cave of Skulls" });
            context.InstanceProperty.AddOrUpdate(new InstanceProperty() { InstanceID = 8, PropertyID = 6, PropertyValue = "130,00" });


            context.SaveChanges();
        }
    }
}
