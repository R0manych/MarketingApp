namespace Desktop.Forms.ShoppingCart
{
    partial class ShowAllCartsForm
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
            this.dataGridViewCarts = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxCartControls = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.fillByClientIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingCartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartsDataSet = new Desktop.CartsDataSet();
            this.shoppingCartsTableAdapter = new Desktop.CartsDataSetTableAdapters.ShoppingCartsTableAdapter();
            this.toolStripComboBoxClient = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarts)).BeginInit();
            this.groupBoxCartControls.SuspendLayout();
            this.fillByClientIdToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarts
            // 
            this.dataGridViewCarts.AutoGenerateColumns = false;
            this.dataGridViewCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridViewCarts.DataSource = this.shoppingCartsBindingSource;
            this.dataGridViewCarts.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewCarts.Name = "dataGridViewCarts";
            this.dataGridViewCarts.Size = new System.Drawing.Size(343, 256);
            this.dataGridViewCarts.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(388, 260);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(174, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(19, 19);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(174, 41);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // groupBoxCartControls
            // 
            this.groupBoxCartControls.Controls.Add(this.buttonEdit);
            this.groupBoxCartControls.Controls.Add(this.buttonDelete);
            this.groupBoxCartControls.Controls.Add(this.buttonOpen);
            this.groupBoxCartControls.Location = new System.Drawing.Point(369, 59);
            this.groupBoxCartControls.Name = "groupBoxCartControls";
            this.groupBoxCartControls.Size = new System.Drawing.Size(213, 163);
            this.groupBoxCartControls.TabIndex = 5;
            this.groupBoxCartControls.TabStop = false;
            this.groupBoxCartControls.Text = "Заказы";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(19, 66);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 41);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(19, 113);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 41);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // fillByClientIdToolStrip
            // 
            this.fillByClientIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxClient});
            this.fillByClientIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByClientIdToolStrip.Name = "fillByClientIdToolStrip";
            this.fillByClientIdToolStrip.Size = new System.Drawing.Size(594, 29);
            this.fillByClientIdToolStrip.TabIndex = 6;
            this.fillByClientIdToolStrip.Text = "fillByClientIdToolStrip";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // shoppingCartsBindingSource
            // 
            this.shoppingCartsBindingSource.DataMember = "ShoppingCarts";
            this.shoppingCartsBindingSource.DataSource = this.cartsDataSet;
            // 
            // cartsDataSet
            // 
            this.cartsDataSet.DataSetName = "CartsDataSet";
            this.cartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingCartsTableAdapter
            // 
            this.shoppingCartsTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripComboBoxClient
            // 
            this.toolStripComboBoxClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripComboBoxClient.Name = "toolStripComboBoxClient";
            this.toolStripComboBoxClient.Size = new System.Drawing.Size(200, 29);
            this.toolStripComboBoxClient.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxClient_SelectedIndexChanged);
            // 
            // ShowAllCartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 316);
            this.Controls.Add(this.fillByClientIdToolStrip);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxCartControls);
            this.Controls.Add(this.dataGridViewCarts);
            this.Name = "ShowAllCartsForm";
            this.Text = "ShowCartsForm";
            this.Load += new System.EventHandler(this.ShowAllCartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarts)).EndInit();
            this.groupBoxCartControls.ResumeLayout(false);
            this.fillByClientIdToolStrip.ResumeLayout(false);
            this.fillByClientIdToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarts;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxCartControls;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private CartsDataSet cartsDataSet;
        private System.Windows.Forms.BindingSource shoppingCartsBindingSource;
        private CartsDataSetTableAdapters.ShoppingCartsTableAdapter shoppingCartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByClientIdToolStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxClient;
    }
}