﻿using System;
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

namespace RPGArtifactsManager
{
    public partial class Viewer : Form
    {
        private DatabaseHandler databaseHandler;
        public Viewer()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler(this);
        }

        private void UpdateListControls()
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
            cbx_prop_type.Items.AddRange(databaseHandler.GetPropertiesTypes().ToArray());
            cbx_prop_type.SelectedIndex = 0;

            cbx_prop_name.Items.Clear();
            cbx_prop_name.Items.AddRange(databaseHandler.GetProperties().ToArray());
            cbx_prop_name.SelectedIndex = 0;

            cbx_prop_del.Items.Clear();
            cbx_prop_del.Items.AddRange(databaseHandler.GetProperties().ToArray());
            cbx_prop_del.SelectedIndex = 0;

            cbx_prop_edit_type.Items.Clear();
            cbx_prop_edit_type.Items.AddRange(databaseHandler.GetPropertiesTypes().ToArray());
            cbx_prop_edit_type.SelectedIndex = 0;

            lbx_properties.Items.Clear();
            lbx_properties.Items.AddRange(databaseHandler.GetProperties().ToArray());

            lbx_new_properties.Items.Clear();
            lbx_new_properties.Items.AddRange(databaseHandler.GetProperties().ToArray());

            treeView1.Nodes.Clear();
            databaseHandler.SetTreeView(treeView1);
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            UpdateListControls();
            databaseHandler.SetTreeView(treeView1);
            databaseHandler.Show5StrongestInstances(dataGridView2);
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
                MessageBox.Show("Category name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lbx_properties.CheckedItems.Count == 0)
            {
                MessageBox.Show("Category has to have at least one property assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Items = lbx_properties.CheckedItems.Cast<string>().ToList();
            var feedback = databaseHandler.AddCategory(tbx_name.Text, cbx_parent_cat.SelectedItem.ToString(), Items);
            if (feedback.GetType() == typeof(string))
            {
                MessageBox.Show(feedback, "Error");
                return;
            }
            UpdateListControls();
            MessageBox.Show("Category has been added successfully", "Added");

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            if (databaseHandler.IsParent(cbx_del.SelectedItem.ToString()))
            {
                MessageBox.Show("If you want to delete this category you have to delete all subcategories first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            databaseHandler.DeleteCategory(cbx_del.SelectedItem.ToString());
            MessageBox.Show("Category successfully deleted.", "Deleted");
            UpdateListControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                dataGridView2.Columns.Clear();
                dataGridView2.Rows.Clear();
                databaseHandler.Show5StrongestInstances(dataGridView2);
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
            UpdateListControls();

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
            UpdateListControls();
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
            if (MessageBox.Show("Are you sure you want to delete this property?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
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
            UpdateListControls();
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

                var feedback = databaseHandler.UpdateProperty(cbx_prop_name.SelectedItem.ToString(), tbx_prop_edit_name.Text, cbx_prop_edit_type.SelectedItem.ToString());
                if (feedback.GetType() == typeof(string))
                {
                    MessageBox.Show(feedback, "Error");
                    return;
                }
                MessageBox.Show("Property edited successfully.");
                UpdateListControls();
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
            {
                /*var lista = dataGridView1.SelectedRows[0].As
                lbx_ins_add_porp.Items.AddRange()*/
            }
        }
    }
}
