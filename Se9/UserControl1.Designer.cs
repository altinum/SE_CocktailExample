namespace Se9
{
    partial class UserControl1
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            typeBindingSource = new BindingSource(components);
            cocktailBindingSource = new BindingSource(components);
            cocktailSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "Coctails";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cocktailSkDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeFkDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cocktailBindingSource;
            dataGridView1.Location = new Point(3, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 307);
            dataGridView1.TabIndex = 1;
            // 
            // typeBindingSource
            // 
            typeBindingSource.DataSource = typeof(CocktailModels.Type);
            // 
            // cocktailBindingSource
            // 
            cocktailBindingSource.DataSource = typeof(CocktailModels.Cocktail);
            // 
            // cocktailSkDataGridViewTextBoxColumn
            // 
            cocktailSkDataGridViewTextBoxColumn.DataPropertyName = "CocktailSk";
            cocktailSkDataGridViewTextBoxColumn.HeaderText = "CocktailSk";
            cocktailSkDataGridViewTextBoxColumn.Name = "cocktailSkDataGridViewTextBoxColumn";
            cocktailSkDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeFkDataGridViewTextBoxColumn
            // 
            typeFkDataGridViewTextBoxColumn.DataPropertyName = "TypeFk";
            typeFkDataGridViewTextBoxColumn.DataSource = typeBindingSource;
            typeFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            typeFkDataGridViewTextBoxColumn.HeaderText = "TypeFk";
            typeFkDataGridViewTextBoxColumn.Name = "typeFkDataGridViewTextBoxColumn";
            typeFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            typeFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            typeFkDataGridViewTextBoxColumn.ValueMember = "TypeId";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(574, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(buttonSave);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(652, 405);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cocktailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource cocktailBindingSource;
        private BindingSource typeBindingSource;
        private DataGridViewTextBoxColumn cocktailSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn typeFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Button buttonSave;
    }
}
