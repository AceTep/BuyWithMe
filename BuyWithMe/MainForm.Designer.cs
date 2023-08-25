namespace BuyWithMe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taxeble = new System.Windows.Forms.CheckBox();
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.loadList = new System.Windows.Forms.Button();
            this.saveList = new System.Windows.Forms.Button();
            this.shareList = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TaxebleItems = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.TotalItems = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.taxeble);
            this.panel1.Controls.Add(this.ItemQuantity);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Controls.Add(this.ItemPrice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 235);
            this.panel1.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(260, 156);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 60);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(143, 156);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 60);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove ";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(26, 156);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 60);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Price: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // taxeble
            // 
            this.taxeble.AutoSize = true;
            this.taxeble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxeble.Location = new System.Drawing.Point(123, 119);
            this.taxeble.Name = "taxeble";
            this.taxeble.Size = new System.Drawing.Size(107, 21);
            this.taxeble.TabIndex = 3;
            this.taxeble.Text = "Taxeble item";
            this.taxeble.UseVisualStyleBackColor = true;
            this.taxeble.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.Location = new System.Drawing.Point(123, 87);
            this.ItemQuantity.MaxLength = 2;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(33, 26);
            this.ItemQuantity.TabIndex = 2;
            this.ItemQuantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(123, 23);
            this.ItemName.MaxLength = 25;
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(170, 26);
            this.ItemName.TabIndex = 0;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // ItemPrice
            // 
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.Location = new System.Drawing.Point(123, 55);
            this.ItemPrice.MaxLength = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(86, 26);
            this.ItemPrice.TabIndex = 1;
            this.ItemPrice.TextChanged += new System.EventHandler(this.ItemPrice_TextChanged);
            // 
            // loadList
            // 
            this.loadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadList.Location = new System.Drawing.Point(0, 3);
            this.loadList.Name = "loadList";
            this.loadList.Size = new System.Drawing.Size(408, 60);
            this.loadList.TabIndex = 11;
            this.loadList.Text = "Load";
            this.loadList.UseVisualStyleBackColor = true;
            this.loadList.Click += new System.EventHandler(this.loadList_Click);
            // 
            // saveList
            // 
            this.saveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveList.Location = new System.Drawing.Point(0, 69);
            this.saveList.Name = "saveList";
            this.saveList.Size = new System.Drawing.Size(405, 60);
            this.saveList.TabIndex = 12;
            this.saveList.Text = "Save";
            this.saveList.UseVisualStyleBackColor = true;
            this.saveList.Click += new System.EventHandler(this.saveList_Click);
            // 
            // shareList
            // 
            this.shareList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareList.Location = new System.Drawing.Point(3, 135);
            this.shareList.Name = "shareList";
            this.shareList.Size = new System.Drawing.Size(402, 60);
            this.shareList.TabIndex = 13;
            this.shareList.Text = "Share";
            this.shareList.UseVisualStyleBackColor = true;
            this.shareList.Click += new System.EventHandler(this.shareList_Click);
            // 
            // closeForm
            // 
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm.Location = new System.Drawing.Point(3, 201);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(402, 60);
            this.closeForm.TabIndex = 14;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeForm);
            this.panel2.Controls.Add(this.shareList);
            this.panel2.Controls.Add(this.saveList);
            this.panel2.Controls.Add(this.loadList);
            this.panel2.Location = new System.Drawing.Point(12, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 267);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(426, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 348);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TaxebleItems);
            this.panel4.Controls.Add(this.Subtotal);
            this.panel4.Controls.Add(this.TotalItems);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(426, 366);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 154);
            this.panel4.TabIndex = 3;
            // 
            // TaxebleItems
            // 
            this.TaxebleItems.AutoSize = true;
            this.TaxebleItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxebleItems.Location = new System.Drawing.Point(258, 62);
            this.TaxebleItems.Name = "TaxebleItems";
            this.TaxebleItems.Size = new System.Drawing.Size(18, 20);
            this.TaxebleItems.TabIndex = 17;
            this.TaxebleItems.Text = "0";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.Location = new System.Drawing.Point(258, 83);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(49, 20);
            this.Subtotal.TabIndex = 16;
            this.Subtotal.Text = "€0.00";
            // 
            // TotalItems
            // 
            this.TotalItems.AutoSize = true;
            this.TotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItems.Location = new System.Drawing.Point(258, 42);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(18, 20);
            this.TotalItems.TabIndex = 15;
            this.TotalItems.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Taxeble Items:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Items:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 525);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BuyWithMe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ItemQuantity;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.CheckBox taxeble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button loadList;
        private System.Windows.Forms.Button saveList;
        private System.Windows.Forms.Button shareList;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TaxebleItems;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label TotalItems;
    }
}

