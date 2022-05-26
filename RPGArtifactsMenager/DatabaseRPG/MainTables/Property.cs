using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RPGArtifactsManager.DatabaseRPG.UtilTables;

namespace RPGArtifactsManager.DatabaseRPG.MainTables
{
    class Property
    {
        public int PropertyID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<InstanceProperty> Values { get; set; }

        public virtual ICollection<CategoryProperty> Categories { get; set; }

    }
}
