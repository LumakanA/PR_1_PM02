namespace Grocery_store
{
    partial class ListOfProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_1DataSet = new Grocery_store.PR_1DataSet();
            this.товарTableAdapter = new Grocery_store.PR_1DataSetTableAdapters.ТоварTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(533, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список товаров";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1078, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерТовараDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.датаПоступленияDataGridViewTextBoxColumn,
            this.срокГодностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(297, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // номерТовараDataGridViewTextBoxColumn
            // 
            this.номерТовараDataGridViewTextBoxColumn.DataPropertyName = "Номер товара";
            this.номерТовараDataGridViewTextBoxColumn.HeaderText = "Номер товара";
            this.номерТовараDataGridViewTextBoxColumn.Name = "номерТовараDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // датаПоступленияDataGridViewTextBoxColumn
            // 
            this.датаПоступленияDataGridViewTextBoxColumn.DataPropertyName = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.датаПоступленияDataGridViewTextBoxColumn.Name = "датаПоступленияDataGridViewTextBoxColumn";
            // 
            // срокГодностиDataGridViewTextBoxColumn
            // 
            this.срокГодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.Name = "срокГодностиDataGridViewTextBoxColumn";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.pR1DataSetBindingSource;
            // 
            // pR1DataSetBindingSource
            // 
            this.pR1DataSetBindingSource.DataSource = this.pR_1DataSet;
            this.pR1DataSetBindingSource.Position = 0;
            // 
            // pR_1DataSet
            // 
            this.pR_1DataSet.DataSetName = "PR_1DataSet";
            this.pR_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // ListOfProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ListOfProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_of_products";
            this.Load += new System.EventHandler(this.List_of_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR_1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pR1DataSetBindingSource;
        private PR_1DataSet pR_1DataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private PR_1DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокГодностиDataGridViewTextBoxColumn;
    }
}