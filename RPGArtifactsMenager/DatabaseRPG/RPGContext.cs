using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RPGArtifactsManager.DatabaseRPG.MainTables;
using RPGArtifactsManager.DatabaseRPG.UtilTables;

namespace RPGArtifactsManager.DatabaseRPG
{
    class RPGContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instance> Instances { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<InstanceProperty> InstanceProperty { get; set; }
        public DbSet<CategoryProperty> CategoryProperty { get; set; }


    }
}
