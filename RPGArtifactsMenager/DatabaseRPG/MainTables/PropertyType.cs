using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RPGArtifactsManager.DatabaseRPG.UtilTables;

namespace RPGArtifactsManager.DatabaseRPG.MainTables
{
    class PropertyType
    {
        public int PropertyTypeID { get; set; }

        public string Type { get; set; }

        public int PropertyID { get; set; }
        public virtual Property Property { get; set; }

    }
}
