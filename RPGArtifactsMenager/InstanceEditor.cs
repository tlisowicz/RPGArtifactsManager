using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGArtifactsManager;
using RPGArtifactsManager.DatabaseRPG;

namespace RPGArtifactsMenager
{
    public partial class InstanceEditor : Form
    {
        private Viewer viewer;
        private DatabaseHandler databaseHandler;
        private List<string> properties;
        private bool isUpdate;
        public InstanceEditor(Viewer viewer, List<string> properties)
        {
            InitializeComponent();
            this.viewer = viewer;
            this.databaseHandler = viewer.databaseHandler;
            this.properties = properties;
        }

        public void RenderFields(List<string> types, bool editMode, string id = null, List<string> values = null)
        {
            isUpdate = editMode;
            if (editMode)
            {
                label23.Text = "Edit Instance";
                var ID = new Label()
                {
                    Location = new Point(130, 70),
                    Text = id,
                    Name = "lbl_id"
                };
                var label = new Label()
                {
                    Text = "ID:",
                    Location = new Point(ID.Location.X - 70,  70),
                };
                Controls.Add(ID);
                Controls.Add(label);
            }

            foreach (var (property, index) in properties.Select((property, index) => (property, index)))
            {
                var textbox = new TextBox()
                {
                    Size = new Size(100, 20),
                    Location = new Point(130, 100 +(35 * index)),
                    Name = "tbx" + index,
                    Tag = index,
                    Text = editMode == true ? values[index] : ""
                };
                var propertyName = new Label()
                {
                    Text = property + ":",
                    Location = new Point(textbox.Location.X - 70, 100 + (35 * index)),
                    Name = "name" + index,
                    Tag = index
                };

                var type = new Label()
                {
                    Text = types[index],
                    Location = new Point(textbox.Location.X + textbox.Width + 20, 100 + (35 * index)),
                    Name = "type" + index,
                    Tag =index

                };
                Controls.Add(textbox);
                Controls.Add(propertyName);
                Controls.Add(type);
                this.Size += new Size(0, 40);
            };
            var addButton = new Button()
            {
                Name = editMode == false ? "btn_add" : "btn_edit",
                Text = editMode == false ? "Add Instance" : "Edit Instance",
                Size = new Size(100, 25),
                Location = new Point(130, this.Height - 70),
            };
            addButton.Click += new EventHandler(btn_add_Clicked);
            Controls.Add(addButton);
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

        private List<TextBox> GetTextBoxes()
        {
            var textBoxes = new List<TextBox>();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add((TextBox)c);
                }
            }
            return textBoxes;
        }

        public void btn_add_Clicked(object sender, EventArgs e)
        {
            List<TextBox> textboxes = this.GetTextBoxes();
            List<string> values = new List<string>();

            bool incorrectValueType = false;
            foreach (TextBox textBox in textboxes)
            {
                if (textBox.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Value not given", "Error");
                    return;
                }
                var labelWithType = this.Controls.Find("type" + textBox.Tag, false)[0];
                var result = EvaluateType(labelWithType.Text, textBox.Text);
                values.Add(textBox.Text);

                if (result.GetType() == typeof(bool))
                {
                    incorrectValueType = true;
                    break;
                }
            }
            if (!incorrectValueType)
            {
                string id = null;
                if (isUpdate)
                {
                    var label = Controls.Find("lbl_id", false)[0] as Label;
                    id = label.Text;
                }                
                databaseHandler.AddOrUpdateInstance(viewer.cbx_ins_add.Text, properties, values, id, isUpdate: isUpdate);
                viewer.UpdateControls();
                MessageBox.Show("Instance successfully added.", "Added");
                this.Dispose();
                return;
            }
             MessageBox.Show("An Error occurred while updating adding instance", "Error");

        }
    }
}
