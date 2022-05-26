using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RPGArtifactsManager.DatabaseRPG.UtilTables;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPGArtifactsManager.DatabaseRPG.MainTables
{
    class Category
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public int? ParentCategoryID { get; set; }

        [ForeignKey("ParentCategoryID")]
        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<CategoryProperty> Properties { get; set; }
    }
}
