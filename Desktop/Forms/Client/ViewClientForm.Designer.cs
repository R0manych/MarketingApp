namespace Desktop.Forms.Client
{
    partial class ViewClientForm
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
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonShowProfit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShowHistory = new System.Windows.Forms.Button();
            this.monthForShowPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(12, 12);
            this.textBoxClient.Multiline = true;
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(366, 445);
            this.textBoxClient.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(396, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(182, 47);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOrder.Location = new System.Drawing.Point(396, 81);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(182, 47);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonShowProfit
            // 
            this.buttonShowProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowProfit.Location = new System.Drawing.Point(396, 155);
            this.buttonShowProfit.Name = "buttonShowProfit";
            this.buttonShowProfit.Size = new System.Drawing.Size(182, 47);
            this.buttonShowProfit.TabIndex = 3;
            this.buttonShowProfit.Text = "Показать доход";
            this.buttonShowProfit.UseVisualStyleBackColor = true;
            this.buttonShowProfit.Click += new System.EventHandler(this.buttonShowProfit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(396, 408);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(182, 47);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonShowHistory
            // 
            this.buttonShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowHistory.Location = new System.Drawing.Point(396, 224);
            this.buttonShowHistory.Name = "buttonShowHistory";
            this.buttonShowHistory.Size = new System.Drawing.Size(182, 47);
            this.buttonShowHistory.TabIndex = 5;
            this.buttonShowHistory.Text = "Открыть историю заказов";
            this.buttonShowHistory.UseVisualStyleBackColor = true;
            this.buttonShowHistory.Click += new System.EventHandler(this.buttonShowHistory_Click);
            // 
            // monthForShowPicker
            // 
            this.monthForShowPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthForShowPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthForShowPicker.Location = new System.Drawing.Point(396, 289);
            this.monthForShowPicker.Name = "monthForShowPicker";
            this.monthForShowPicker.Size = new System.Drawing.Size(182, 26);
            this.monthForShowPicker.TabIndex = 6;
            this.monthForShowPicker.ValueChanged += new System.EventHandler(this.monthForShowPicker_ValueChanged);
            // 
            // ViewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 467);
            this.Controls.Add(this.monthForShowPicker);
            this.Controls.Add(this.buttonShowHistory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonShowProfit);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxClient);
            this.MaximizeBox = false;
            this.Name = "ViewClientForm";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.ViewClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonShowProfit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonShowHistory;
        private System.Windows.Forms.DateTimePicker monthForShowPicker;
    }
}