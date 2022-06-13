namespace FoodMarket
{
    partial class CatalogForm
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
            this.CatalogGrid = new System.Windows.Forms.DataGridView();
            this.Catalog = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogGrid
            // 
            this.CatalogGrid.AllowUserToAddRows = false;
            this.CatalogGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatalogGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CatalogGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CatalogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Catalog});
            this.CatalogGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CatalogGrid.Location = new System.Drawing.Point(0, 301);
            this.CatalogGrid.Name = "CatalogGrid";
            this.CatalogGrid.RowHeadersVisible = false;
            this.CatalogGrid.RowHeadersWidth = 51;
            this.CatalogGrid.Size = new System.Drawing.Size(800, 149);
            this.CatalogGrid.TabIndex = 0;
            this.CatalogGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CatalogGrid_CellMouseClick);
            // 
            // Catalog
            // 
            this.Catalog.HeaderText = "Каталог";
            this.Catalog.MinimumWidth = 6;
            this.Catalog.Name = "Catalog";
            this.Catalog.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Кабінет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Корзина";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatalogGrid);
            this.Name = "CatalogForm";
            this.Text = "FoodMarket";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatalogGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CatalogGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn Catalog;
    }
}

