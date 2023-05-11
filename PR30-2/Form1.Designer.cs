namespace PR30_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cookingBookDataSet = new PR30_2.CookingBookDataSet();
            this.cookingBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cookingBookTableAdapter = new PR30_2.CookingBookDataSetTableAdapters.CookingBookTableAdapter();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productScopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishsTableAdapter = new PR30_2.CookingBookDataSetTableAdapters.DishsTableAdapter();
            this.dishCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparationOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloryCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new PR30_2.CookingBookDataSetTableAdapters.ProductsTableAdapter();
            this.productCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCodeDataGridViewTextBoxColumn,
            this.dishCodeDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productScopeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cookingBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishCodeDataGridViewTextBoxColumn1,
            this.dishTypeDataGridViewTextBoxColumn,
            this.dishWeightDataGridViewTextBoxColumn,
            this.preparationOrderDataGridViewTextBoxColumn,
            this.caloryCountDataGridViewTextBoxColumn,
            this.carbCountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dishsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(863, 262);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn,
            this.measureUnitDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.productsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(2, 547);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(863, 300);
            this.dataGridView3.TabIndex = 2;
            // 
            // cookingBookDataSet
            // 
            this.cookingBookDataSet.DataSetName = "CookingBookDataSet";
            this.cookingBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cookingBookBindingSource
            // 
            this.cookingBookBindingSource.DataMember = "CookingBook";
            this.cookingBookBindingSource.DataSource = this.cookingBookDataSet;
            // 
            // cookingBookTableAdapter
            // 
            this.cookingBookTableAdapter.ClearBeforeFill = true;
            // 
            // bookCodeDataGridViewTextBoxColumn
            // 
            this.bookCodeDataGridViewTextBoxColumn.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.HeaderText = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCodeDataGridViewTextBoxColumn.Name = "bookCodeDataGridViewTextBoxColumn";
            this.bookCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dishCodeDataGridViewTextBoxColumn
            // 
            this.dishCodeDataGridViewTextBoxColumn.DataPropertyName = "DishCode";
            this.dishCodeDataGridViewTextBoxColumn.HeaderText = "DishCode";
            this.dishCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dishCodeDataGridViewTextBoxColumn.Name = "dishCodeDataGridViewTextBoxColumn";
            this.dishCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productScopeDataGridViewTextBoxColumn
            // 
            this.productScopeDataGridViewTextBoxColumn.DataPropertyName = "ProductScope";
            this.productScopeDataGridViewTextBoxColumn.HeaderText = "ProductScope";
            this.productScopeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productScopeDataGridViewTextBoxColumn.Name = "productScopeDataGridViewTextBoxColumn";
            this.productScopeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dishsBindingSource
            // 
            this.dishsBindingSource.DataMember = "Dishs";
            this.dishsBindingSource.DataSource = this.cookingBookDataSet;
            // 
            // dishsTableAdapter
            // 
            this.dishsTableAdapter.ClearBeforeFill = true;
            // 
            // dishCodeDataGridViewTextBoxColumn1
            // 
            this.dishCodeDataGridViewTextBoxColumn1.DataPropertyName = "DishCode";
            this.dishCodeDataGridViewTextBoxColumn1.HeaderText = "DishCode";
            this.dishCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dishCodeDataGridViewTextBoxColumn1.Name = "dishCodeDataGridViewTextBoxColumn1";
            this.dishCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dishCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dishTypeDataGridViewTextBoxColumn
            // 
            this.dishTypeDataGridViewTextBoxColumn.DataPropertyName = "DishType";
            this.dishTypeDataGridViewTextBoxColumn.HeaderText = "DishType";
            this.dishTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dishTypeDataGridViewTextBoxColumn.Name = "dishTypeDataGridViewTextBoxColumn";
            this.dishTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dishWeightDataGridViewTextBoxColumn
            // 
            this.dishWeightDataGridViewTextBoxColumn.DataPropertyName = "DishWeight";
            this.dishWeightDataGridViewTextBoxColumn.HeaderText = "DishWeight";
            this.dishWeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dishWeightDataGridViewTextBoxColumn.Name = "dishWeightDataGridViewTextBoxColumn";
            this.dishWeightDataGridViewTextBoxColumn.Width = 125;
            // 
            // preparationOrderDataGridViewTextBoxColumn
            // 
            this.preparationOrderDataGridViewTextBoxColumn.DataPropertyName = "PreparationOrder";
            this.preparationOrderDataGridViewTextBoxColumn.HeaderText = "PreparationOrder";
            this.preparationOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preparationOrderDataGridViewTextBoxColumn.Name = "preparationOrderDataGridViewTextBoxColumn";
            this.preparationOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // caloryCountDataGridViewTextBoxColumn
            // 
            this.caloryCountDataGridViewTextBoxColumn.DataPropertyName = "CaloryCount";
            this.caloryCountDataGridViewTextBoxColumn.HeaderText = "CaloryCount";
            this.caloryCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caloryCountDataGridViewTextBoxColumn.Name = "caloryCountDataGridViewTextBoxColumn";
            this.caloryCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // carbCountDataGridViewTextBoxColumn
            // 
            this.carbCountDataGridViewTextBoxColumn.DataPropertyName = "CarbCount";
            this.carbCountDataGridViewTextBoxColumn.HeaderText = "CarbCount";
            this.carbCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carbCountDataGridViewTextBoxColumn.Name = "carbCountDataGridViewTextBoxColumn";
            this.carbCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.cookingBookDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productCodeDataGridViewTextBoxColumn1
            // 
            this.productCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn1.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.productCodeDataGridViewTextBoxColumn1.Name = "productCodeDataGridViewTextBoxColumn1";
            this.productCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // measureUnitDataGridViewTextBoxColumn
            // 
            this.measureUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasureUnit";
            this.measureUnitDataGridViewTextBoxColumn.HeaderText = "MeasureUnit";
            this.measureUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measureUnitDataGridViewTextBoxColumn.Name = "measureUnitDataGridViewTextBoxColumn";
            this.measureUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 859);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private CookingBookDataSet cookingBookDataSet;
        private System.Windows.Forms.BindingSource cookingBookBindingSource;
        private CookingBookDataSetTableAdapters.CookingBookTableAdapter cookingBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productScopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dishsBindingSource;
        private CookingBookDataSetTableAdapters.DishsTableAdapter dishsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparationOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloryCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CookingBookDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureUnitDataGridViewTextBoxColumn;
    }
}

