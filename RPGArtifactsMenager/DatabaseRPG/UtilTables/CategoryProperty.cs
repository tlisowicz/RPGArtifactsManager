using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGArtifactsManager.DatabaseRPG.MainTables;

namespace RPGArtifactsManager.DatabaseRPG.UtilTables
{
    [Table("CategoryProperty")]
    class CategoryProperty
    {
        [Key, Column(Order = 1)]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [Key, Column(Order = 2)]
        public int PropertyID { get; set; }
        public virtual Property Property { get; set; }
    }
}
