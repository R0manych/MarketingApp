namespace Desktop.Forms
{
    partial class MainForm
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
            this.treeViewClients = new System.Windows.Forms.TreeView();
            this.groupBoxClientControls = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxOrdersControl = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStripClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxClientControls.SuspendLayout();
            this.groupBoxOrdersControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewClients
            // 
            this.treeViewClients.Location = new System.Drawing.Point(12, 12);
            this.treeViewClients.Name = "treeViewClients";
            this.treeViewClients.Size = new System.Drawing.Size(561, 388);
            this.treeViewClients.TabIndex = 0;
            // 
            // groupBoxClientControls
            // 
            this.groupBoxClientControls.Controls.Add(this.buttonDelete);
            this.groupBoxClientControls.Controls.Add(this.buttonEdit);
            this.groupBoxClientControls.Controls.Add(this.buttonOpen);
            this.groupBoxClientControls.Controls.Add(this.buttonAdd);
            this.groupBoxClientControls.Location = new System.Drawing.Point(589, 12);
            this.groupBoxClientControls.Name = "groupBoxClientControls";
            this.groupBoxClientControls.Size = new System.Drawing.Size(230, 249);
            this.groupBoxClientControls.TabIndex = 1;
            this.groupBoxClientControls.TabStop = false;
            this.groupBoxClientControls.Text = "Клиент";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 81);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(214, 47);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(6, 28);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(214, 47);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(6, 134);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(214, 47);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(6, 187);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(214, 47);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxOrdersControl
            // 
            this.groupBoxOrdersControl.Controls.Add(this.button2);
            this.groupBoxOrdersControl.Controls.Add(this.button1);
            this.groupBoxOrdersControl.Location = new System.Drawing.Point(589, 267);
            this.groupBoxOrdersControl.Name = "groupBoxOrdersControl";
            this.groupBoxOrdersControl.Size = new System.Drawing.Size(230, 133);
            this.groupBoxOrdersControl.TabIndex = 2;
            this.groupBoxOrdersControl.TabStop = false;
            this.groupBoxOrdersControl.Text = "Заказы";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Новый заказ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(10, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "История заказов";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripClient
            // 
            this.contextMenuStripClient.Name = "contextMenuStripClient";
            this.contextMenuStripClient.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 418);
            this.Controls.Add(this.groupBoxOrdersControl);
            this.Controls.Add(this.groupBoxClientControls);
            this.Controls.Add(this.treeViewClients);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBoxClientControls.ResumeLayout(false);
            this.groupBoxOrdersControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewClients;
        private System.Windows.Forms.GroupBox groupBoxClientControls;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxOrdersControl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClient;
    }
}