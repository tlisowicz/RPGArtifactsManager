using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGArtifactsManager.DatabaseRPG;
using RPGArtifactsManager.DatabaseRPG.MainTables;
using RPGArtifactsMenager;

namespace RPGArtifactsManager
{
    public partial class Viewer : Form
    {
        private InstanceEditor instanceEditor;
        internal DatabaseHandler databaseHandler;
        public Viewer()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler();
        }

        internal void UpdateControls()
        {
            List<string> categories = databaseHandler.GetCategories();
            categories.Insert(0, "<None>");

            cbx_parent_cat.Items.Clear();
            cbx_parent_cat.Items.AddRange(categories.ToArray());
            cbx_parent_cat.SelectedIndex = 0;

            cbx_del.Items.Clear();
            cbx_del.Items.AddRange(databaseHandler.GetCategories().ToArray());
            cbx_del.SelectedIndex = 0;

            cbx_edit_name.Items.Clear();
            cbx_edit_name.Items.AddRange(databaseHandler.GetCategories().ToArray());
            cbx_edit_name.SelectedIndex = 0;

            cbx_prop_type.Items.Clear();
            cbx_prop_type.Items.AddRange(databaseHandler.GetPropertiesUniqueTypes().ToArray());
            cbx_prop_type.SelectedIndex = 0;

            cbx_prop_name.Items.Clear();
            cbx_prop_name.Items.AddRange(databaseHandler.GetProperties().ToArray());
            cbx_prop_name.SelectedIndex = 0;

            cbx_prop_del.Items.Clear();
            cbx_prop_del.Items.AddRange(databaseHandler.GetProperties().ToArray());
            cbx_prop_del.SelectedIndex = 0;

            cbx_prop_edit_type.Items.Clear();
            cbx_prop_edit_type.Items.AddRange(databaseHandler.GetPropertiesUniqueTypes().ToArray());
            cbx_prop_edit_type.SelectedIndex = 0;

            cbx_ins_add.Items.Clear();
            cbx_ins_add.Items.AddRange(databaseHandler.GetCategories().ToArray());
            cbx_ins_add.SelectedIndex = 0;

            lbx_properties.Items.Clear();
            lbx_properties.Items.AddRange(databaseHandler.GetProperties().ToArray());

            lbx_new_properties.Items.Clear();
            var properties = databaseHandler.GetPropertiesByCategory(cbx_edit_name.SelectedItem.ToString());
            lbx_new_properties.Items.AddRange(databaseHandler.GetProperties().ToArray());
            for (int i = 0; i< lbx_new_properties.Items.Count; ++i)
            {
                if (properties.Contains(lbx_new_properties.Items[i].ToString()))
                {
                    lbx_new_properties.SetItemChecked(i, true);
                }
            }

                dataGridView1.Columns.Clear();

            dataGridView2.Columns.Clear();
            databaseHandler.Show5StrongestInstances(dataGridView2);

            treeView1.Nodes.Clear();
            databaseHandler.SetTreeView(treeView1);

        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }    

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Columns.Clear();
            string category = treeView1.SelectedNode.Text;
            databaseHandler.ShowData(dataGridView1, category);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_name.Text.Equals(String.Empty))
            {
                MessageBox.Show("Category name cannot be empty", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lbx_properties.CheckedItems.Count == 0)
            {
                MessageBox.Show("Category has to have at least one property assigned", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Items = lbx_properties.CheckedItems.Cast<string>().ToList();
            var feedback = databaseHandler.AddCategory(tbx_name.Text, cbx_parent_cat.SelectedItem.ToString(), Items);
            if (feedback.GetType() == typeof(string))
            {
                MessageBox.Show(feedback, "Error");
                return;
            }
            UpdateControls();
            MessageBox.Show("Category has been added successfully", "Added");

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category?", "Deleting", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            if (databaseHandler.IsParent(cbx_del.SelectedItem.ToString()))
            {
                MessageBox.Show("If you want to delete this category you have to delete all subcategories first.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            databaseHandler.DeleteCategory(cbx_del.SelectedItem.ToString());
            MessageBox.Show("Category successfully deleted.", "Deleted");
            UpdateControls();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UpdateControls();
            }
        }

        private void cbx_edit_name_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_edit_name.Checked)
            {
                tbx_edit_name.Enabled = true;
            }
            else
            {
                tbx_edit_name.Enabled = false;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tbx_edit_name.Enabled == true)
            {
                if (tbx_edit_name.Text.Equals(String.Empty))
                {
                    MessageBox.Show("New name cannot be empty.", "Error");
                    return;
                }

                if (databaseHandler.GetCategories().Contains(tbx_edit_name.Text))
                {
                    MessageBox.Show("Category with a given name already exists in database.", "Error");
                    return;
                }
            }
            List<string> elements = lbx_new_properties.CheckedItems.OfType<string>().ToList();
            var feedback = databaseHandler.UpdateCategory(cbx_edit_name.Text, tbx_edit_name.Text, elements);

            if (feedback.GetType() == typeof(string))
            {
                MessageBox.Show(feedback, "Error");
                return;
            }
            MessageBox.Show("Category edited successfully.");
            UpdateControls();

        }

        private void btn_prop_add_Click(object sender, EventArgs e)
        {
            if (tbx_prop_new_name.Text.Equals(String.Empty))
            {
                MessageBox.Show("New name cannot be empty.", "Error");
                return;
            }

            if (databaseHandler.GetProperties().Contains(tbx_prop_new_name.Text))
            {
                MessageBox.Show("Property with a given name already exists in database.", "Error");
                return;
            }

            var feedback = databaseHandler.AddProperty(tbx_prop_new_name.Text, cbx_prop_type.SelectedItem.ToString());

            if (feedback.GetType() == typeof(string))
            {
                MessageBox.Show(feedback, "Error");
                return;
            }
            MessageBox.Show("Property added successfully.");
            UpdateControls();
        }

        private void cb_prop_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_prop_edit.Checked)
            {
                tbx_prop_edit_name.Enabled = true;
            }
            else
            {
                tbx_prop_edit_name.Enabled = false;
            }
        }

        private void btn_prop_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this property?", "Deleting", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            var feedback = databaseHandler.DeleteProperty(cbx_prop_del.Text);

            if (feedback.GetType() == typeof(string))
            {
                MessageBox.Show(feedback, "Error");
                return;
            }
            MessageBox.Show("Property deleted successfully.");
            UpdateControls();
        }

        private void btn_prop_edit_Click(object sender, EventArgs e)
        {
            if (tbx_prop_edit_name.Enabled == true)
            {
                if (tbx_prop_edit_name.Text.Equals(String.Empty))
                {
                    MessageBox.Show("New name cannot be empty.", "Error");
                    return;
                }

                if (databaseHandler.GetProperties().Contains(tbx_prop_edit_name.Text))
                {
                    MessageBox.Show("Property with a given name already exists in database.", "Error");
                    return;
                }

                var feedback = databaseHandler.UpdateProperty(cbx_prop_name.SelectedItem.ToString(), 
                                                              tbx_prop_edit_name.Text, cbx_prop_edit_type.SelectedItem.ToString());
                if (feedback.GetType() == typeof(string))
                {
                    MessageBox.Show(feedback, "Error");
                    return;
                }
                MessageBox.Show("Property edited successfully.");
                UpdateControls();
            }
        }

        private dynamic EvaluateType(string type, string value)
        {
            int result = 0;
            decimal result2 = 0;
            switch (type)
            {
                case "String":
                    return value;

                case "Decimal":
                    if (!decimal.TryParse(value, out result2))
                    {
                        MessageBox.Show($"Invalid value type. It has to be {type}", "Error");
                        return false;
                    }
                    return result2;

                case "Integer": 
                    if (!int.TryParse(value, out result))
                    {
                        MessageBox.Show($"Invalid value type. It has to be {type}", "Error");
                        return false;
                    }
                    return result;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var propertyNames = databaseHandler.GetPropertiesByCategory(cbx_ins_add.SelectedItem.ToString());
            instanceEditor = new InstanceEditor(this, propertyNames);

            var types = databaseHandler.GetPropertiesTypes(propertyNames);
            instanceEditor.RenderFields(types, editMode: false);
            instanceEditor.Show();
        }

        private void btn_ins_del_Click(object sender, EventArgs e)
        {
            if (tbx_ins_del.Text.Equals(String.Empty))
            {
                MessageBox.Show("Instance ID not given", "Error");
                return;
            }

            int id;
            if (int.TryParse(tbx_ins_del.Text, out id) == false)
            {
                MessageBox.Show("It's not an integer number", "Error");
                return;

            }

            var feedback = databaseHandler.DeleteInstance(id);
            if (feedback.GetType() == typeof(string))
            {
                MessageBox.Show(feedback, "Error");
                return;
            }
            MessageBox.Show("Instance deleted successfully.");
            UpdateControls();
        }

        private void btn_ins_edit_Click(object sender, EventArgs e)
        {
            if (tbx_ins_edit.Text.Equals(String.Empty))
            {
                MessageBox.Show("Instance ID not given", "Error");
                return;
            }

            int id;
            if (int.TryParse(tbx_ins_edit.Text, out id) == false)
            {
                MessageBox.Show("It's not an integer number", "Error");
                return;
            }
            var categoryName = databaseHandler.GetCategoryNameByInstanceID(id);
            var propertyNames = databaseHandler.GetPropertiesByCategory(categoryName);
            var types = databaseHandler.GetPropertiesTypes(propertyNames);
            var values = databaseHandler.GetPropertyValuesByInstanceID(id);

            instanceEditor = new InstanceEditor(this, propertyNames);
            instanceEditor.RenderFields(types, editMode: true, id.ToString(), values);
            instanceEditor.Show();
        }

        private void cbx_edit_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_new_properties.Items.Clear();
            var properties = databaseHandler.GetPropertiesByCategory(cbx_edit_name.SelectedItem.ToString());
            lbx_new_properties.Items.AddRange(databaseHandler.GetProperties().ToArray());
            for (int i = 0; i < lbx_new_properties.Items.Count; ++i)
            {
                if (properties.Contains(lbx_new_properties.Items[i].ToString()))
                {
                    lbx_new_properties.SetItemChecked(i, true);
                }
            }
        }
    }
}
