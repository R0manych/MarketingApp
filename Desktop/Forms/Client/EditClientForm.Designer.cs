namespace Desktop.Forms.Client
{
    partial class EditClientForm
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
            this.textBoxParent = new System.Windows.Forms.TextBox();
            this.comboBoxParent = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxContract = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxBank = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxParent
            // 
            this.textBoxParent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxParent.Location = new System.Drawing.Point(13, 297);
            this.textBoxParent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxParent.Name = "textBoxParent";
            this.textBoxParent.ReadOnly = true;
            this.textBoxParent.Size = new System.Drawing.Size(122, 26);
            this.textBoxParent.TabIndex = 25;
            this.textBoxParent.Text = "Пригласил:";
            this.textBoxParent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxParent
            // 
            this.comboBoxParent.FormattingEnabled = true;
            this.comboBoxParent.Location = new System.Drawing.Point(143, 297);
            this.comboBoxParent.Name = "comboBoxParent";
            this.comboBoxParent.Size = new System.Drawing.Size(270, 28);
            this.comboBoxParent.TabIndex = 22;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(257, 351);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(155, 37);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 351);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 37);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(213, 261);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(200, 26);
            this.birthdayPicker.TabIndex = 21;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxPassport.Location = new System.Drawing.Point(13, 83);
            this.textBoxPassport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(399, 26);
            this.textBoxPassport.TabIndex = 15;
            this.textBoxPassport.Text = "Паспорт";
            this.textBoxPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPassport.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxContract
            // 
            this.textBoxContract.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxContract.Location = new System.Drawing.Point(13, 119);
            this.textBoxContract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContract.Name = "textBoxContract";
            this.textBoxContract.Size = new System.Drawing.Size(399, 26);
            this.textBoxContract.TabIndex = 17;
            this.textBoxContract.Text = "Контракт";
            this.textBoxContract.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxContract.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxAdress.Location = new System.Drawing.Point(13, 155);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(399, 26);
            this.textBoxAdress.TabIndex = 18;
            this.textBoxAdress.Text = "Адрес";
            this.textBoxAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAdress.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxBank
            // 
            this.textBoxBank.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxBank.Location = new System.Drawing.Point(13, 191);
            this.textBoxBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new System.Drawing.Size(399, 26);
            this.textBoxBank.TabIndex = 19;
            this.textBoxBank.Text = "Номер счета";
            this.textBoxBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBank.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxEmail.Location = new System.Drawing.Point(14, 227);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(399, 26);
            this.textBoxEmail.TabIndex = 20;
            this.textBoxEmail.Text = "E-mail";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxBirth.Location = new System.Drawing.Point(14, 261);
            this.textBoxBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.ReadOnly = true;
            this.textBoxBirth.Size = new System.Drawing.Size(192, 26);
            this.textBoxBirth.TabIndex = 16;
            this.textBoxBirth.Text = "Дата рождения:";
            this.textBoxBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxPhone.Location = new System.Drawing.Point(13, 47);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(399, 26);
            this.textBoxPhone.TabIndex = 14;
            this.textBoxPhone.Text = "Телефон";
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPhone.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxName
            // 
            this.textBoxName.ForeColor = System.Drawing.Color.LightSlateGray;
            this.textBoxName.Location = new System.Drawing.Point(13, 11);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(399, 26);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.Text = "ФИО";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxName.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 401);
            this.Controls.Add(this.textBoxParent);
            this.Controls.Add(this.comboBoxParent);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxContract);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxBank);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxBirth);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditClientForm";
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParent;
        private System.Windows.Forms.ComboBox comboBoxParent;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxContract;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxBank;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxBirth;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
    }
}