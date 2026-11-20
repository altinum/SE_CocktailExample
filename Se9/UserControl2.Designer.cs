namespace Se9
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            cocktailBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            materialBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            recepieSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recepieEntryBindingSource = new BindingSource(components);
            textBoxCocktailFilter = new TextBox();
            textBoxMaterialFilter = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            buttonAdd = new Button();
            buttonRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recepieEntryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.DataSource = cocktailBindingSource;
            listBox1.DisplayMember = "Name";
            listBox1.FormattingEnabled = true;
            listBox1.IntegralHeight = false;
            listBox1.Location = new Point(0, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 334);
            listBox1.TabIndex = 0;
            // 
            // cocktailBindingSource
            // 
            cocktailBindingSource.DataSource = typeof(CocktailModels.Cocktail);
            cocktailBindingSource.CurrentChanged += cocktailBindingSource_CurrentChanged;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox2.DataSource = materialBindingSource;
            listBox2.DisplayMember = "Name";
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(637, 88);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(188, 334);
            listBox2.TabIndex = 0;
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(CocktailModels.Material);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { recepieSkDataGridViewTextBoxColumn, materialNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = recepieEntryBindingSource;
            dataGridView1.Location = new Point(194, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(333, 334);
            dataGridView1.TabIndex = 1;
            // 
            // recepieSkDataGridViewTextBoxColumn
            // 
            recepieSkDataGridViewTextBoxColumn.DataPropertyName = "RecepieSk";
            recepieSkDataGridViewTextBoxColumn.HeaderText = "RecepieSk";
            recepieSkDataGridViewTextBoxColumn.Name = "recepieSkDataGridViewTextBoxColumn";
            recepieSkDataGridViewTextBoxColumn.ReadOnly = true;
            recepieSkDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            materialNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            materialNameDataGridViewTextBoxColumn.HeaderText = "MaterialName";
            materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            unitNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recepieEntryBindingSource
            // 
            recepieEntryBindingSource.DataSource = typeof(RecepieEntry);
            // 
            // textBoxCocktailFilter
            // 
            textBoxCocktailFilter.Location = new Point(0, 59);
            textBoxCocktailFilter.Name = "textBoxCocktailFilter";
            textBoxCocktailFilter.PlaceholderText = "Filter cocktails";
            textBoxCocktailFilter.Size = new Size(188, 23);
            textBoxCocktailFilter.TabIndex = 2;
            // 
            // textBoxMaterialFilter
            // 
            textBoxMaterialFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMaterialFilter.Location = new Point(637, 59);
            textBoxMaterialFilter.Name = "textBoxMaterialFilter";
            textBoxMaterialFilter.PlaceholderText = "Filter materials";
            textBoxMaterialFilter.Size = new Size(188, 23);
            textBoxMaterialFilter.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 3;
            label1.Text = "Recepies";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(533, 88);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(98, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Location = new Point(533, 117);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(98, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemove.Location = new Point(533, 146);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(98, 23);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(textBoxMaterialFilter);
            Controls.Add(textBoxCocktailFilter);
            Controls.Add(dataGridView1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "UserControl2";
            Size = new Size(842, 435);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)recepieEntryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private DataGridView dataGridView1;
        private TextBox textBoxCocktailFilter;
        private TextBox textBoxMaterialFilter;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button buttonAdd;
        private Button buttonRemove;
        private BindingSource cocktailBindingSource;
        private BindingSource materialBindingSource;
        private DataGridViewTextBoxColumn recepieSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private BindingSource recepieEntryBindingSource;
    }
}
