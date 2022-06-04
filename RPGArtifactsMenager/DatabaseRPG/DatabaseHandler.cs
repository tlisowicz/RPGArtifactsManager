using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGArtifactsManager.DatabaseRPG.MainTables;
using RPGArtifactsManager.DatabaseRPG.UtilTables;
using RPGArtifactsMenager;
namespace RPGArtifactsManager.DatabaseRPG
{
    class DatabaseHandler
    {

        public List<string> GetCategories()
        {
            using (var context = new RPGContext())
            {
                var categories = context.Categories
                    .Select(x => x.Name)
                    .ToList();

                return categories;
            }
        }

        public List<string> GetPropertiesUniqueTypes()
        {
            using (var context = new RPGContext())
            {
                var types = context.PropertyTypes
                    .Select(x => x.Type)
                    .ToHashSet()
                    .ToList();

                return types;
            }
        }

        public string GetPropertyType(string propertyName)
        {
            using (var context = new RPGContext())
            {
                var id = context.Properties
                    .Where(x => x.Name.Equals(propertyName))
                    .Select(x => x.PropertyID)
                    .ToList()[0];

                var type = context.PropertyTypes
                    .Where(x => x.PropertyID == id)
                    .Select(x => x.Type)
                    .ToList()[0];

                return type;
            }
        }

        public List<string> GetPropertiesTypes(List<string> propertiesNames)
        {
            var result = new List<string>();
            using (var context = new RPGContext())
            {
               foreach(var property in propertiesNames)
               {
                    result.Add(GetPropertyType(property));
               }
            }
            return result;
        }
        public List<string> GetPropertiesByCategory( string categoryName)
        {
            var category = FindCategoryByName(categoryName);

            using (var context = new RPGContext())
            {
                var propertiesIDs = context.CategoryProperty
                    .Where(x => x.CategoryID == category.CategoryID)
                    .Select(x => x.PropertyID)
                    .ToList();

                var propertiesNames = context.Properties
                    .Where(x => propertiesIDs.Contains(x.PropertyID))
                    .Select(x => x.Name)
                    .ToList();

                return propertiesNames;
            }
        }

        private Category FindCategoryByName(string name)
        {
            using (var context = new RPGContext())
            {
                var Category = context.Categories
                    .Where(x => x.Name.Equals(name))
                    .Select(x => x)
                    .ToList()[0];

                return Category;
            }
        }
        public List<string> GetProperties()
        {
            using (var context = new RPGContext())
            {
                var properties = context.Properties
                    .Select(x => x.Name)
                    .ToList();

                return properties;
            }
        }

        public string GetCategoryNameByInstanceID(int id)
        {
            using (var context = new RPGContext())
            {
                var categoryID = context.Instances
                    .Where(x => x.InstanceID == id)
                    .Select(x => x.CategoryID)
                    .ToList()[0];

                var categoryName = context.Categories
                    .Where(x => x.CategoryID == categoryID)
                    .Select(x => x.Name)
                    .ToList()[0];

                return categoryName;
            }
        }

        public List<string> GetPropertyValuesByInstanceID(int id)
        {
            using (var context = new RPGContext())
            {
                var values = context.InstanceProperty
                    .Where(x => x.InstanceID == id)
                    .Select(x => x.PropertyValue)
                    .ToList();

                return values;
            }
        }

        public bool IsParent(string category)
        {
            using (var context = new RPGContext())
            {
                Category cat = FindCategoryByName(category);

                var ChildCategories = context.Categories
                    .Where(x => x.ParentCategoryID == cat.CategoryID)
                    .Select(x => x)
                    .ToList();

                return ChildCategories.Count == 0 ? false : true;
            }
        }
        public dynamic AddCategory(string category, string parentCategory, List<string> properties)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    if (context.Categories
                        .Select(x => x.Name)
                        .ToList()
                        .Contains(category))
                    {
                        return "Category with a given name exists in database";
                    }
                    if (parentCategory.Equals("<None>"))
                    {
                        context.Categories.Add(
                       new Category()
                       {
                           Name = category,
                       });
                    }
                    else
                    {
                        context.Categories.Add(
                        new Category()
                        {
                            Name = category,
                            ParentCategoryID = context.Categories
                                    .Where(x => x.Name.Equals(parentCategory))
                                    .Select(x => x.CategoryID)
                                    .ToList()[0],
                        });
                    }                    
                    context.SaveChanges();

                    int addedCategoryID = context.Categories
                        .Where(x => x.Name.Equals(category))
                        .Select(x => x.CategoryID)
                        .ToList()[0];

                    foreach (var property in properties)
                    {
                        context.CategoryProperty.Add(
                            new CategoryProperty()
                            {
                                CategoryID = addedCategoryID,
                                PropertyID = context.Properties
                                    .Where(x => x.Name.Equals(property))
                                    .Select(x => x.PropertyID)
                                    .ToList()[0]
                            });
                    }
                    context.SaveChanges();
                    return true;
;                }
            } catch (Exception)
            {
                return "An error has occurred while inserting data to database." ;
            }    
        }

        public dynamic AddProperty(string name, string type)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    var TypeID = context.PropertyTypes
                        .Where(x => x.Type.Equals(type))
                        .Select(x => x.PropertyTypeID)
                        .ToList()[0];

                    context.Properties.Add(new Property() { Name = name });
                    context.SaveChanges();

                    var addedPropertyID = context.Properties
                        .Where(x => x.Name.Equals(name))
                        .Select(x => x.PropertyID)
                        .ToList()[0];

                    context.PropertyTypes.Add(new PropertyType() { PropertyID = addedPropertyID, Type = type });
                    context.SaveChanges();

                    return true;
                }
            } catch (Exception)
            {
                return "An error has occurred while inserting data to database.";
            }
        }
        public dynamic UpdateCategory(string name, string newName, List<string> properties)
        {
            try {
                using (var context = new RPGContext())
                {
                    Category category = FindCategoryByName(name);

                    var oldProperties = context.CategoryProperty
                        .Where(x => x.CategoryID == category.CategoryID)
                        .Select(x => x.PropertyID)
                        .ToList();

                    var newProperties = context.Properties
                        .Where(x => properties.Contains(x.Name))
                        .Select(x => x.PropertyID)
                        .ToList();

                    foreach (var prop in oldProperties)
                    {
                        CategoryProperty categoryProperty = context.CategoryProperty
                            .Where(x => x.PropertyID == prop && x.CategoryID == category.CategoryID)
                            .Select(x => x)
                            .ToList()[0];
                        context.CategoryProperty.Remove(categoryProperty);
                    }
                    context.SaveChanges();

                    foreach (var prop in newProperties)
                    {
                        context.CategoryProperty.Add(new CategoryProperty()
                        {
                            CategoryID = category.CategoryID,
                            PropertyID = prop
                        });
                    }
                    context.SaveChanges();

                    if (!(newName is null))
                    {
                        category.Name = newName;
                    }
                    context.SaveChanges();
                    return true;
                }
            } catch (Exception)
            {
                return "An error occured during updating Category";
            }    
        }

        public dynamic AddOrUpdateInstance(string category, List<string> properties, List<string> values, string instanceID = null, bool isUpdate = false)
        {
            try {
                using (var context = new RPGContext())
                {
                    var cat = FindCategoryByName(category);
                    Instance instance;
                    if (isUpdate)
                    {
                        int id;
                        int.TryParse(instanceID, out id);

                        instance = context.Instances
                            .Where(x => x.InstanceID == id)
                            .Select(x => x)
                            .ToList()[0];

                        instance.UpdatedAt = DateTime.Now;
                    } else
                    {
                        instance = new Instance()
                        {
                            CategoryID = cat.CategoryID,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now

                        };
                    }                  
                    context.Instances.AddOrUpdate(instance);
                    context.SaveChanges();

                    var propertiesIDs = context.Properties
                        .Where(x => properties.Contains(x.Name))
                        .Select(x => x.PropertyID)
                        .ToList();

                    foreach(var (propertyID, index) in propertiesIDs.Select((propertyID, index) => (propertyID, index)))
                    {
                        context.InstanceProperty.AddOrUpdate(new InstanceProperty()
                        {
                            PropertyID = propertyID,
                            InstanceID = instance.InstanceID,
                            PropertyValue = values[index]
                        });
                    }
                    context.SaveChanges();
                    return true;
                }
            } catch (Exception)
            {
                return $"An Error occurred while updating adding instance";
            }
}
        public dynamic UpdateProperty(string propertyName, string newName, string type)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    Property property = context.Properties
                        .Where(x => x.Name.Equals(propertyName))
                        .Select(x => x)
                        .ToList()[0];

                    PropertyType propertyType = context.PropertyTypes
                        .Where(x => x.PropertyID == property.PropertyID)
                        .Select(x => x)
                        .ToList()[0];
                    
                    if (!(newName is null))
                    {
                        property.Name = newName;
                    }
                    propertyType.Type = type;

                    context.SaveChanges();
                    return true;
                }
            } catch (Exception)
            {
                return $"An Error occurred while updating an property with name: {propertyName}";
            }
        }
        public dynamic DeleteInstance(int instanceID)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    var ValuesToDelete = context.InstanceProperty
                        .Where(x => x.InstanceID == instanceID)
                        .Select(x => x)
                        .ToList();
                    context.InstanceProperty.RemoveRange(ValuesToDelete);

                    var Instance = context.Instances
                        .Where(x => x.InstanceID == instanceID)
                        .Select(x => x)
                        .ToList()[0];

                    context.InstanceProperty.RemoveRange(ValuesToDelete);
                    context.Instances.Remove(Instance);
                    context.SaveChanges();

                    return true;
                }

            } catch (Exception)
            {
                return $"An Error occurred while deleting an instance with id: {instanceID}";
            }  
        }
        public void DeleteCategory(string categoryName)
        {
            using (var context = new RPGContext())
            {
                Category cat = FindCategoryByName(categoryName);

                var instancesIDs = context.Instances
                    .Where(x => x.CategoryID == cat.CategoryID)
                    .Select(x => x.InstanceID)
                    .ToList();

                foreach (var id in instancesIDs)
                {
                    DeleteInstance(id);
                }
                context.Entry(cat).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public dynamic DeleteProperty(string propertyName)
        {
            try
            {
                using (var context = new RPGContext())
                {
                    var property = context.Properties
                        .Where(x => x.Name == propertyName)
                        .Select(x => x)
                        .ToList()[0];

                    var InstanceProperties = context.InstanceProperty
                        .Where(x => x.PropertyID == property.PropertyID)
                        .Select(x => x)
                        .ToList();

                    var PropertyType = context.PropertyTypes
                        .Where(x => x.PropertyID == property.PropertyID)
                        .Select(x => x)
                        .ToList()[0];

                    context.InstanceProperty.RemoveRange(InstanceProperties);
                    context.PropertyTypes.Remove(PropertyType);
                    context.Entry(property).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return $"An Error occurred while deleting property with name: {propertyName}";
            }
        }  
        public void SetTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            using (var context = new RPGContext())
            {
                List<Category> rootCategories = context.Categories
                    .Where(x => x.ParentCategoryID == null)
                    .Select(x => x)
                    .ToList();

                foreach (var category in rootCategories)
                {
                    TreeNode root = new TreeNode
                    {
                        Text = category.Name,
                        Name = category.Name
                    };
                    treeView.Nodes.Add(root);
                    generateChild(category, root);
                }
            }    
        }
        public void generateChild(Category category, TreeNode parentNode)
        {
            using (var context = new RPGContext())
            {
                var Children = context.Categories
                    .Where(x => x.ParentCategoryID == category.CategoryID)
                    .Select(x => x)
                    .ToList();

                foreach (var cat in Children)
                {
                    TreeNode child = new TreeNode
                    {
                        Text = cat.Name,
                        Name = cat.Name
                    };
                    parentNode.Nodes.Add(child);
                    generateChild(cat, child);
                }
            }
        }
        public void ShowData(DataGridView dataGridView1,string catName)
        {
            using (var context = new RPGContext())
            {
                Category category = FindCategoryByName(catName);

                var CategoryProperty = context.CategoryProperty
                    .Where(x => x.CategoryID == category.CategoryID)
                    .Select(x => x.PropertyID)
                    .ToList();

                var Properties = context.Properties
                    .Where(x => CategoryProperty.Contains(x.PropertyID))
                    .Select(x => new { x.Name, x.PropertyID })
                    .ToList();

                var Instances = context.Instances
                    .Where(x => x.CategoryID == category.CategoryID)
                    .Select(x =>  x.InstanceID)
                    .ToList();   

                List<string> header = new List<string>();

                header.Add("Category");
                header.Add("InstanceID");
                foreach (var property in Properties)
                {
                    header.Add(property.Name);
                }

                //initializing datagrid columns
                dataGridView1.ColumnCount = header.Count;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Name = header[column.Index];
                }

                //filling datagrid rows
                List<List<string>> Query = new List<List<string>>();

                foreach (var instance in Instances)
                { 
                    List<string> Row = new List<string>();                    
                    Row.Add(category.Name);
                    Row.Add(instance.ToString());

                    var PropertiesValues = context.InstanceProperty
                    .Where(x => x.InstanceID == instance)
                    .Select(x => new { x.PropertyValue, x.PropertyID })
                    .ToList();

                    foreach (var value in PropertiesValues)
                    {
                        Row.Add(value.PropertyValue);
                    }
                    Query.Add(Row);
                }

                foreach(var row in Query)
                {
                    dataGridView1.Rows.Add(row.ToArray());
                }
            }
        }

        public void Show5StrongestInstances(DataGridView dataGridView)
        {
            List<string> header = new List<string>();

            header.Add("Category");
            header.Add("InstanceID");
            header.Add("Name");
            header.Add("Strength");

            dataGridView.ColumnCount = header.Count;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Name = header[column.Index];
            }

            List<List<string>> Query = new List<List<string>>();
            using (var context = new RPGContext())
            {
                var Instances = context.Instances
                     .Select(x => new { x.InstanceID, x.CategoryID })
                     .ToList();

                foreach (var instance in Instances)
                {
                    List<string> Row = new List<string>();

                    var strengthPropID = context.Properties
                        .Where(x => x.Name.Equals("Strength"))
                        .Select(x => x.PropertyID)
                        .ToList()[0];

                    int hasStrength = context.InstanceProperty
                        .Where(x => x.PropertyID == strengthPropID
                               && x.InstanceID == instance.InstanceID)
                        .Select(x => x)
                        .ToList()
                        .Count;
                    if (hasStrength == 0)
                    {
                        continue;
                    }
                    var category = context.Categories
                        .Where(x => x.CategoryID == instance.CategoryID)
                        .Select(x => x.Name)
                        .ToList()[0];

                    var Properties = context.Properties
                        .Where(x => header.Contains(x.Name))
                        .Select(x => x.PropertyID)
                        .ToList();

                    var InstanceProperties = context.InstanceProperty
                   .Where(x => x.InstanceID == instance.InstanceID && Properties.Contains(x.PropertyID))
                   .Select(x => x.PropertyValue)
                   .ToList();

                    Row.Add(category);
                    Row.Add(instance.InstanceID.ToString());
                    Row.AddRange(InstanceProperties);

                    Query.Add(Row);
                }

                List<List<string>> FilteredQuery = Query
                    .OrderByDescending(list => int.Parse(list[list.Count - 1]))
                    .Take(5)
                    .ToList();

                foreach (var row in FilteredQuery)
                {
                    dataGridView.Rows.Add(row.ToArray());
                }
            }
        }
    }
}
