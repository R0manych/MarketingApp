namespace Desktop.Forms.ShoppingCart
{
    partial class AddShoppingCartForm
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
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCart
            // 
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCart.Location = new System.Drawing.Point(12, 12);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.Size = new System.Drawing.Size(721, 296);
            this.dataGridCart.TabIndex = 0;
            // 
            // AddShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 390);
            this.Controls.Add(this.dataGridCart);
            this.Name = "AddShoppingCartForm";
            this.Text = "AddShoppingCartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCart;
    }
}