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
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteEverything = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.TotalItems = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.ItemQuantity);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Controls.Add(this.ItemPrice);
            this.panel1.Location = new System.Drawing.Point(20, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 289);
            this.panel1.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(347, 192);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 74);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(191, 192);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(148, 74);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove ";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(35, 192);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(148, 74);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.Location = new System.Drawing.Point(164, 107);
            this.ItemQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.ItemQuantity.MaxLength = 2;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(43, 26);
            this.ItemQuantity.TabIndex = 2;
            this.ItemQuantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(164, 28);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4);
            this.ItemName.MaxLength = 25;
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(225, 26);
            this.ItemName.TabIndex = 0;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // ItemPrice
            // 
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.Location = new System.Drawing.Point(164, 68);
            this.ItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ItemPrice.MaxLength = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(113, 26);
            this.ItemPrice.TabIndex = 1;
            this.ItemPrice.TextChanged += new System.EventHandler(this.ItemPrice_TextChanged);
            // 
            // closeForm
            // 
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm.Location = new System.Drawing.Point(8, 101);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(536, 74);
            this.closeForm.TabIndex = 15;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteEverything);
            this.panel2.Controls.Add(this.closeForm);
            this.panel2.Location = new System.Drawing.Point(16, 414);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 179);
            this.panel2.TabIndex = 1;
            // 
            // DeleteEverything
            // 
            this.DeleteEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEverything.Location = new System.Drawing.Point(8, 19);
            this.DeleteEverything.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteEverything.Name = "DeleteEverything";
            this.DeleteEverything.Size = new System.Drawing.Size(536, 74);
            this.DeleteEverything.TabIndex = 14;
            this.DeleteEverything.Text = "Empty Shopping Bin";
            this.DeleteEverything.UseVisualStyleBackColor = true;
            this.DeleteEverything.Click += new System.EventHandler(this.DeleteEverything_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(568, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 428);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TotalPrice);
            this.panel4.Controls.Add(this.TotalItems);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(568, 450);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(665, 190);
            this.panel4.TabIndex = 3;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(344, 72);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(49, 20);
            this.TotalPrice.TabIndex = 16;
            this.TotalPrice.Text = "€0.00";
            // 
            // TotalItems
            // 
            this.TotalItems.AutoSize = true;
            this.TotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItems.Location = new System.Drawing.Point(344, 52);
            this.TotalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(18, 20);
            this.TotalItems.TabIndex = 15;
            this.TotalItems.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Price(€):      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Items:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1249, 646);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label TotalItems;
        private System.Windows.Forms.Button DeleteEverything;
    }
}

