
namespace RPGArtifactsManager
{
    partial class Viewer
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mages");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Humans", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Elves");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Playable", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Dragons");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Orcs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ents");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Monsters", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Caves");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Forests", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Enviroment", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_ins_edit = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_ins_del = new System.Windows.Forms.Button();
            this.tbx_ins_del = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_ins_edit = new System.Windows.Forms.Button();
            this.btn_ins_add = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.cbx_ins_add = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_prop_del = new System.Windows.Forms.Button();
            this.btn_prop_edit = new System.Windows.Forms.Button();
            this.btn_prop_add = new System.Windows.Forms.Button();
            this.cbx_prop_del = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbx_prop_name = new System.Windows.Forms.ComboBox();
            this.tbx_prop_edit_name = new System.Windows.Forms.TextBox();
            this.cb_prop_edit = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbx_prop_edit_type = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbx_prop_type = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx_prop_new_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tbx_edit_name = new System.Windows.Forms.TextBox();
            this.cb_edit_name = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbx_new_properties = new System.Windows.Forms.CheckedListBox();
            this.cbx_edit_name = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_del = new System.Windows.Forms.ComboBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_parent_cat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbx_properties = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1233, 750);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbx_ins_edit);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.btn_ins_del);
            this.tabPage1.Controls.Add(this.tbx_ins_del);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.btn_ins_edit);
            this.tabPage1.Controls.Add(this.btn_ins_add);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.cbx_ins_add);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browse Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Instance ID:";
            // 
            // tbx_ins_edit
            // 
            this.tbx_ins_edit.Location = new System.Drawing.Point(170, 542);
            this.tbx_ins_edit.Name = "tbx_ins_edit";
            this.tbx_ins_edit.Size = new System.Drawing.Size(54, 20);
            this.tbx_ins_edit.TabIndex = 46;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(249, 363);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "Instance ID:";
            // 
            // btn_ins_del
            // 
            this.btn_ins_del.Location = new System.Drawing.Point(225, 417);
            this.btn_ins_del.Name = "btn_ins_del";
            this.btn_ins_del.Size = new System.Drawing.Size(100, 23);
            this.btn_ins_del.TabIndex = 44;
            this.btn_ins_del.Text = "Delete";
            this.btn_ins_del.UseVisualStyleBackColor = true;
            this.btn_ins_del.Click += new System.EventHandler(this.btn_ins_del_Click);
            // 
            // tbx_ins_del
            // 
            this.tbx_ins_del.Location = new System.Drawing.Point(252, 380);
            this.tbx_ins_del.Name = "tbx_ins_del";
            this.tbx_ins_del.Size = new System.Drawing.Size(54, 20);
            this.tbx_ins_del.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(201, 323);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(161, 25);
            this.label25.TabIndex = 42;
            this.label25.Text = "Delete Instance";
            // 
            // btn_ins_edit
            // 
            this.btn_ins_edit.Location = new System.Drawing.Point(148, 578);
            this.btn_ins_edit.Name = "btn_ins_edit";
            this.btn_ins_edit.Size = new System.Drawing.Size(100, 23);
            this.btn_ins_edit.TabIndex = 41;
            this.btn_ins_edit.Text = "Choose Values";
            this.btn_ins_edit.UseVisualStyleBackColor = true;
            this.btn_ins_edit.Click += new System.EventHandler(this.btn_ins_edit_Click);
            // 
            // btn_ins_add
            // 
            this.btn_ins_add.Location = new System.Drawing.Point(40, 417);
            this.btn_ins_add.Name = "btn_ins_add";
            this.btn_ins_add.Size = new System.Drawing.Size(115, 23);
            this.btn_ins_add.TabIndex = 38;
            this.btn_ins_add.Text = "Choose Values";
            this.btn_ins_add.UseVisualStyleBackColor = true;
            this.btn_ins_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(72, 363);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Category:";
            // 
            // cbx_ins_add
            // 
            this.cbx_ins_add.FormattingEnabled = true;
            this.cbx_ins_add.Location = new System.Drawing.Point(39, 379);
            this.cbx_ins_add.Name = "cbx_ins_add";
            this.cbx_ins_add.Size = new System.Drawing.Size(121, 21);
            this.cbx_ins_add.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(35, 323);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 25);
            this.label23.TabIndex = 25;
            this.label23.Text = "Add Instance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(670, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Filtered Instance List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(635, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Top 5 strongest Instances";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(570, 56);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(419, 161);
            this.dataGridView2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(127, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Edit Instance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Tree";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(49, 72);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Mages";
            treeNode1.Text = "Mages";
            treeNode2.Name = "Humans";
            treeNode2.Text = "Humans";
            treeNode3.Name = "Elves";
            treeNode3.Text = "Elves";
            treeNode4.Name = "Playable";
            treeNode4.Text = "Playable";
            treeNode5.Name = "Dragons";
            treeNode5.Text = "Dragons";
            treeNode6.Name = "Orcs";
            treeNode6.Text = "Orcs";
            treeNode7.Name = "Ents";
            treeNode7.Text = "Ents";
            treeNode8.Name = "Monsters";
            treeNode8.Text = "Monsters";
            treeNode9.Name = "Caves";
            treeNode9.Text = "Caves";
            treeNode10.Name = "Forests";
            treeNode10.Text = "Forests";
            treeNode11.Name = "Enviroment";
            treeNode11.Text = "Enviroment";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(214, 177);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(381, 293);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.btn_prop_del);
            this.tabPage2.Controls.Add(this.btn_prop_edit);
            this.tabPage2.Controls.Add(this.btn_prop_add);
            this.tabPage2.Controls.Add(this.cbx_prop_del);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.cbx_prop_name);
            this.tabPage2.Controls.Add(this.tbx_prop_edit_name);
            this.tabPage2.Controls.Add(this.cb_prop_edit);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.cbx_prop_edit_type);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cbx_prop_type);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbx_prop_new_name);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btn_edit);
            this.tabPage2.Controls.Add(this.tbx_edit_name);
            this.tabPage2.Controls.Add(this.cb_edit_name);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lbx_new_properties);
            this.tabPage2.Controls.Add(this.cbx_edit_name);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cbx_del);
            this.tabPage2.Controls.Add(this.btn_del);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbx_parent_cat);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lbx_properties);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbx_name);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_add);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1225, 724);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Categories Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(527, 222);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "Properties";
            // 
            // btn_prop_del
            // 
            this.btn_prop_del.Location = new System.Drawing.Point(832, 458);
            this.btn_prop_del.Name = "btn_prop_del";
            this.btn_prop_del.Size = new System.Drawing.Size(100, 23);
            this.btn_prop_del.TabIndex = 58;
            this.btn_prop_del.Text = "Delete";
            this.btn_prop_del.UseVisualStyleBackColor = true;
            this.btn_prop_del.Click += new System.EventHandler(this.btn_prop_del_Click);
            // 
            // btn_prop_edit
            // 
            this.btn_prop_edit.Location = new System.Drawing.Point(597, 544);
            this.btn_prop_edit.Name = "btn_prop_edit";
            this.btn_prop_edit.Size = new System.Drawing.Size(100, 23);
            this.btn_prop_edit.TabIndex = 57;
            this.btn_prop_edit.Text = "Edit";
            this.btn_prop_edit.UseVisualStyleBackColor = true;
            this.btn_prop_edit.Click += new System.EventHandler(this.btn_prop_edit_Click);
            // 
            // btn_prop_add
            // 
            this.btn_prop_add.Location = new System.Drawing.Point(366, 507);
            this.btn_prop_add.Name = "btn_prop_add";
            this.btn_prop_add.Size = new System.Drawing.Size(100, 23);
            this.btn_prop_add.TabIndex = 56;
            this.btn_prop_add.Text = "Add";
            this.btn_prop_add.UseVisualStyleBackColor = true;
            this.btn_prop_add.Click += new System.EventHandler(this.btn_prop_add_Click);
            // 
            // cbx_prop_del
            // 
            this.cbx_prop_del.FormattingEnabled = true;
            this.cbx_prop_del.Location = new System.Drawing.Point(832, 419);
            this.cbx_prop_del.Name = "cbx_prop_del";
            this.cbx_prop_del.Size = new System.Drawing.Size(100, 21);
            this.cbx_prop_del.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(773, 427);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "Name:";
            // 
            // cbx_prop_name
            // 
            this.cbx_prop_name.FormattingEnabled = true;
            this.cbx_prop_name.Location = new System.Drawing.Point(597, 419);
            this.cbx_prop_name.Name = "cbx_prop_name";
            this.cbx_prop_name.Size = new System.Drawing.Size(100, 21);
            this.cbx_prop_name.TabIndex = 53;
            // 
            // tbx_prop_edit_name
            // 
            this.tbx_prop_edit_name.Enabled = false;
            this.tbx_prop_edit_name.Location = new System.Drawing.Point(597, 463);
            this.tbx_prop_edit_name.Name = "tbx_prop_edit_name";
            this.tbx_prop_edit_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_prop_edit_name.TabIndex = 52;
            // 
            // cb_prop_edit
            // 
            this.cb_prop_edit.AutoSize = true;
            this.cb_prop_edit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_prop_edit.Location = new System.Drawing.Point(506, 464);
            this.cb_prop_edit.Name = "cb_prop_edit";
            this.cb_prop_edit.Size = new System.Drawing.Size(75, 17);
            this.cb_prop_edit.TabIndex = 51;
            this.cb_prop_edit.Text = "Edit Name";
            this.cb_prop_edit.UseVisualStyleBackColor = true;
            this.cb_prop_edit.CheckedChanged += new System.EventHandler(this.cb_prop_edit_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(538, 507);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Type:";
            // 
            // cbx_prop_edit_type
            // 
            this.cbx_prop_edit_type.FormattingEnabled = true;
            this.cbx_prop_edit_type.Location = new System.Drawing.Point(597, 504);
            this.cbx_prop_edit_type.Name = "cbx_prop_edit_type";
            this.cbx_prop_edit_type.Size = new System.Drawing.Size(100, 21);
            this.cbx_prop_edit_type.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(538, 427);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(307, 470);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Type:";
            // 
            // cbx_prop_type
            // 
            this.cbx_prop_type.FormattingEnabled = true;
            this.cbx_prop_type.Location = new System.Drawing.Point(366, 467);
            this.cbx_prop_type.Name = "cbx_prop_type";
            this.cbx_prop_type.Size = new System.Drawing.Size(100, 21);
            this.cbx_prop_type.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(307, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Name:";
            // 
            // tbx_prop_new_name
            // 
            this.tbx_prop_new_name.Location = new System.Drawing.Point(366, 424);
            this.tbx_prop_new_name.Name = "tbx_prop_new_name";
            this.tbx_prop_new_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_prop_new_name.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(573, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 25);
            this.label16.TabIndex = 42;
            this.label16.Text = "Edit property";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(801, 373);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 25);
            this.label15.TabIndex = 41;
            this.label15.Text = "Delete property";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(317, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "Add new property";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(597, 298);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 23);
            this.btn_edit.TabIndex = 39;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tbx_edit_name
            // 
            this.tbx_edit_name.Enabled = false;
            this.tbx_edit_name.Location = new System.Drawing.Point(597, 148);
            this.tbx_edit_name.Name = "tbx_edit_name";
            this.tbx_edit_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_edit_name.TabIndex = 38;
            // 
            // cb_edit_name
            // 
            this.cb_edit_name.AutoSize = true;
            this.cb_edit_name.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_edit_name.Location = new System.Drawing.Point(506, 149);
            this.cb_edit_name.Name = "cb_edit_name";
            this.cb_edit_name.Size = new System.Drawing.Size(75, 17);
            this.cb_edit_name.TabIndex = 37;
            this.cb_edit_name.Text = "Edit Name";
            this.cb_edit_name.UseVisualStyleBackColor = true;
            this.cb_edit_name.CheckedChanged += new System.EventHandler(this.cbx_edit_name_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Name:";
            // 
            // lbx_new_properties
            // 
            this.lbx_new_properties.FormattingEnabled = true;
            this.lbx_new_properties.Location = new System.Drawing.Point(597, 184);
            this.lbx_new_properties.Name = "lbx_new_properties";
            this.lbx_new_properties.Size = new System.Drawing.Size(100, 94);
            this.lbx_new_properties.TabIndex = 35;
            // 
            // cbx_edit_name
            // 
            this.cbx_edit_name.FormattingEnabled = true;
            this.cbx_edit_name.Location = new System.Drawing.Point(597, 111);
            this.cbx_edit_name.Name = "cbx_edit_name";
            this.cbx_edit_name.Size = new System.Drawing.Size(100, 21);
            this.cbx_edit_name.TabIndex = 34;
            this.cbx_edit_name.SelectedIndexChanged += new System.EventHandler(this.cbx_edit_name_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(573, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "Edit Category";
            // 
            // cbx_del
            // 
            this.cbx_del.FormattingEnabled = true;
            this.cbx_del.Location = new System.Drawing.Point(832, 123);
            this.cbx_del.Name = "cbx_del";
            this.cbx_del.Size = new System.Drawing.Size(100, 21);
            this.cbx_del.TabIndex = 32;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(832, 158);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 23);
            this.btn_del.TabIndex = 31;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(786, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Delete category";
            // 
            // cbx_parent_cat
            // 
            this.cbx_parent_cat.FormattingEnabled = true;
            this.cbx_parent_cat.Location = new System.Drawing.Point(366, 147);
            this.cbx_parent_cat.Name = "cbx_parent_cat";
            this.cbx_parent_cat.Size = new System.Drawing.Size(100, 21);
            this.cbx_parent_cat.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(306, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Parent Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Properties";
            // 
            // lbx_properties
            // 
            this.lbx_properties.FormattingEnabled = true;
            this.lbx_properties.Location = new System.Drawing.Point(366, 184);
            this.lbx_properties.Name = "lbx_properties";
            this.lbx_properties.Size = new System.Drawing.Size(100, 94);
            this.lbx_properties.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name:";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(366, 112);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(317, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Add new category";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(366, 298);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 774);
            this.Controls.Add(this.tabControl1);
            this.Name = "Viewer";
            this.Text = "RPCArtifactsDatabase";
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbx_del;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_parent_cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox lbx_properties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tbx_edit_name;
        private System.Windows.Forms.CheckBox cb_edit_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox lbx_new_properties;
        private System.Windows.Forms.ComboBox cbx_edit_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_prop_del;
        private System.Windows.Forms.Button btn_prop_edit;
        private System.Windows.Forms.Button btn_prop_add;
        private System.Windows.Forms.ComboBox cbx_prop_del;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbx_prop_name;
        private System.Windows.Forms.TextBox tbx_prop_edit_name;
        private System.Windows.Forms.CheckBox cb_prop_edit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbx_prop_edit_type;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbx_prop_type;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbx_prop_new_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ins_add;
        private System.Windows.Forms.Button btn_ins_edit;
        internal System.Windows.Forms.ComboBox cbx_ins_add;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_ins_del;
        private System.Windows.Forms.TextBox tbx_ins_del;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_ins_edit;
    }
}

