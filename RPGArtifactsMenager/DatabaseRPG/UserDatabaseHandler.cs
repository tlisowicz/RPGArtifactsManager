using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGArtifactsManager.DatabaseRPG;
using RPGArtifactsManager.DatabaseRPG.MainTables;
using RPGArtifactsManager.DatabaseRPG.UtilTables;

namespace RPGArtifactsMenager.DatabaseRPG
{
    class UserDatabaseHandler
    {
        public string GenerateSHA256Hash(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.SHA256Managed sha256string = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256string.ComputeHash(bytes);

            StringBuilder hex = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }


        public List<string> GetUsers()
        {
            using (var context = new RPGContext())
            {
                var names = context.Users
                    .Select(x => x.Name)
                    .ToList();
                return names;
            }
        }


        public string FetchPassword(string UserName)
        {
            using (var context = new RPGContext())
            {
                var password = context.Users
                    .Where(x => x.Name.Equals(UserName))
                    .Select(x => x.Password)
                    .ToList()[0];

                return password;
            }
        }


        public bool AddUser(string name, string password, int role = 1)
        {
            try
            {
                var encryptedPassword = GenerateSHA256Hash(password);
                using (var context = new RPGContext())
                {
                    var user = new User()
                    {
                        Name = name,
                        Password = encryptedPassword,
                        role = (User.Role) role,
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public int GetUserRole(string name)
        {
            using (var context = new RPGContext())
            {
                var role = context.Users
                    .Where(x => x.Name.Equals(name))
                    .Select(x => x.role)
                    .ToArray()[0];

                return (int)role;
            }
        }

        public bool EditUser(string userName, string newName, string newPwd, string role)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    var user = context.Users
                        .Where(x => x.Name.Equals(userName))
                        .Select(x => x)
                        .ToArray()[0];

                    if (!newName.Equals(""))
                    {
                        user.Name = newName;
                    }

                    if (!newPwd.Equals(""))
                    {
                        user.Password = GenerateSHA256Hash(newPwd);
                    }

                    if (role.Equals("USER"))
                    {
                        user.role = User.Role.USER;
                    }

                    else if (role.Equals("ADMIN"))
                    {
                        user.role = User.Role.ADMIN;
                    }

                    context.SaveChanges();
                    return true;
                }
            } 
            catch (Exception)
            {
                return false;
            }
           
        }

        public bool DeleteUser(string userName)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    var user = context.Users
                        .Where(x => x.Name.Equals(userName))
                        .Select(x => x)
                        .ToArray()[0];

                    context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
