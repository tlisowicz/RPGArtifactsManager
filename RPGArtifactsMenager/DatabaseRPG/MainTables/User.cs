using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGArtifactsManager.DatabaseRPG.MainTables
{
    class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public enum Role { ADMIN, USER }

        public Role role { get; set; }
    }
}
