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
    [Table("InstanceProperty")]
    class InstanceProperty
    {
        [Key, Column(Order = 1)]
        public int InstanceID { get; set; }
        public virtual Instance Instance { get; set; }

        [Key, Column(Order = 2)]
        public int PropertyID { get; set; }
        public virtual Property Property { get; set; }

        public string PropertyValue { get; set; }
    }
}
