using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGArtifactsManager.DatabaseRPG.UtilTables;

namespace RPGArtifactsManager.DatabaseRPG.MainTables
{

    class Instance
    {
        public int InstanceID { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<InstanceProperty> Properties { get; set; }

    }
}
