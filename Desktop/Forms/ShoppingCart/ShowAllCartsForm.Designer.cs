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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shoppingCartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingCartDataSet = new Desktop.ShoppingCartDataSet();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxCartControls = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.toolStripComboBoxClient = new System.Windows.Forms.ToolStripComboBox();
            this.fillByClientIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.shoppingCartsTableAdapter = new Desktop.ShoppingCartDataSetTableAdapters.ShoppingCartsTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataSet)).BeginInit();
            this.groupBoxCartControls.SuspendLayout();
            this.fillByClientIdToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCarts
            // 
            this.dataGridViewCarts.AllowUserToAddRows = false;
            this.dataGridViewCarts.AutoGenerateColumns = false;
            this.dataGridViewCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.deliveredDataGridViewCheckBoxColumn});
            this.dataGridViewCarts.DataSource = this.shoppingCartsBindingSource;
            this.dataGridViewCarts.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewCarts.Name = "dataGridViewCarts";
            this.dataGridViewCarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarts.Size = new System.Drawing.Size(343, 264);
            this.dataGridViewCarts.TabIndex = 0;
            this.dataGridViewCarts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewCarts_RowsRemoved);
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
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliveredDataGridViewCheckBoxColumn
            // 
            this.deliveredDataGridViewCheckBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.HeaderText = "Доставлено";
            this.deliveredDataGridViewCheckBoxColumn.Name = "deliveredDataGridViewCheckBoxColumn";
            this.deliveredDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // shoppingCartsBindingSource
            // 
            this.shoppingCartsBindingSource.DataMember = "ShoppingCarts";
            this.shoppingCartsBindingSource.DataSource = this.shoppingCartDataSet;
            // 
            // shoppingCartDataSet
            // 
            this.shoppingCartDataSet.DataSetName = "ShoppingCartDataSet";
            this.shoppingCartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(398, 268);
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
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBoxCartControls
            // 
            this.groupBoxCartControls.Controls.Add(this.buttonAdd);
            this.groupBoxCartControls.Controls.Add(this.buttonEdit);
            this.groupBoxCartControls.Controls.Add(this.buttonDelete);
            this.groupBoxCartControls.Controls.Add(this.buttonOpen);
            this.groupBoxCartControls.Location = new System.Drawing.Point(379, 44);
            this.groupBoxCartControls.Name = "groupBoxCartControls";
            this.groupBoxCartControls.Size = new System.Drawing.Size(213, 208);
            this.groupBoxCartControls.TabIndex = 5;
            this.groupBoxCartControls.TabStop = false;
            this.groupBoxCartControls.Text = "Заказы";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(19, 113);
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
            this.buttonDelete.Location = new System.Drawing.Point(19, 160);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 41);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripComboBoxClient
            // 
            this.toolStripComboBoxClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripComboBoxClient.Name = "toolStripComboBoxClient";
            this.toolStripComboBoxClient.Size = new System.Drawing.Size(200, 29);
            this.toolStripComboBoxClient.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxClient_SelectedIndexChanged);
            // 
            // fillByClientIdToolStrip
            // 
            this.fillByClientIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxClient});
            this.fillByClientIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByClientIdToolStrip.Name = "fillByClientIdToolStrip";
            this.fillByClientIdToolStrip.Size = new System.Drawing.Size(604, 29);
            this.fillByClientIdToolStrip.TabIndex = 6;
            this.fillByClientIdToolStrip.Text = "fillByClientIdToolStrip";
            // 
            // shoppingCartsTableAdapter
            // 
            this.shoppingCartsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(19, 66);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(174, 41);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ShowAllCartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 320);
            this.Controls.Add(this.fillByClientIdToolStrip);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxCartControls);
            this.Controls.Add(this.dataGridViewCarts);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(622, 359);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(622, 359);
            this.Name = "ShowAllCartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы клиента";
            this.Load += new System.EventHandler(this.ShowAllCartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataSet)).EndInit();
            this.groupBoxCartControls.ResumeLayout(false);
            this.fillByClientIdToolStrip.ResumeLayout(false);
            this.fillByClientIdToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxClient;
        private System.Windows.Forms.ToolStrip fillByClientIdToolStrip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delivered;
        private ShoppingCartDataSet shoppingCartDataSet;
        private System.Windows.Forms.BindingSource shoppingCartsBindingSource;
        private ShoppingCartDataSetTableAdapters.ShoppingCartsTableAdapter shoppingCartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonAdd;
    }
}