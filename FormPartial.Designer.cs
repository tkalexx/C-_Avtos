namespace Avtoservis2
{
    partial class FormPartial
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookkeeping = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tx_box_s = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grid_employees = new System.Windows.Forms.DataGridView();
            this.sale = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.red_sale = new System.Windows.Forms.Button();
            this.grid_sell = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grid_product = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.bookkeeping.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).BeginInit();
            this.sale.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bookkeeping);
            this.tabControl1.Controls.Add(this.sale);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // bookkeeping
            // 
            this.bookkeeping.Controls.Add(this.groupBox3);
            this.bookkeeping.Controls.Add(this.groupBox2);
            this.bookkeeping.Controls.Add(this.grid_employees);
            this.bookkeeping.Location = new System.Drawing.Point(4, 22);
            this.bookkeeping.Name = "bookkeeping";
            this.bookkeeping.Padding = new System.Windows.Forms.Padding(3);
            this.bookkeeping.Size = new System.Drawing.Size(750, 351);
            this.bookkeeping.TabIndex = 0;
            this.bookkeeping.Text = "Бухгалтерия/кадры";
            this.bookkeeping.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tx_box_s);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(506, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 127);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отчеты";
            // 
            // tx_box_s
            // 
            this.tx_box_s.Location = new System.Drawing.Point(122, 97);
            this.tx_box_s.Name = "tx_box_s";
            this.tx_box_s.Size = new System.Drawing.Size(86, 20);
            this.tx_box_s.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Выполнить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Общая сумма продаж";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "Открыть отчет";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итог по зарплате";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(505, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление сотрудниками";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать данные сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Добавить сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Уволить сотрудника";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grid_employees
            // 
            this.grid_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_employees.Location = new System.Drawing.Point(0, 3);
            this.grid_employees.Name = "grid_employees";
            this.grid_employees.Size = new System.Drawing.Size(499, 341);
            this.grid_employees.TabIndex = 0;
            this.grid_employees.Text = "dataGridView1";
            // 
            // sale
            // 
            this.sale.Controls.Add(this.groupBox1);
            this.sale.Controls.Add(this.grid_sell);
            this.sale.Location = new System.Drawing.Point(4, 22);
            this.sale.Name = "sale";
            this.sale.Padding = new System.Windows.Forms.Padding(3);
            this.sale.Size = new System.Drawing.Size(750, 351);
            this.sale.TabIndex = 1;
            this.sale.Text = "Продажи";
            this.sale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.red_sale);
            this.groupBox1.Location = new System.Drawing.Point(524, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление продажами";
            // 
            // red_sale
            // 
            this.red_sale.Location = new System.Drawing.Point(25, 34);
            this.red_sale.Name = "red_sale";
            this.red_sale.Size = new System.Drawing.Size(195, 25);
            this.red_sale.TabIndex = 2;
            this.red_sale.Text = "Редактировать данные";
            this.red_sale.UseVisualStyleBackColor = true;
            this.red_sale.Click += new System.EventHandler(this.red_sale_Click);
            // 
            // grid_sell
            // 
            this.grid_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sell.Location = new System.Drawing.Point(3, 3);
            this.grid_sell.Name = "grid_sell";
            this.grid_sell.Size = new System.Drawing.Size(516, 341);
            this.grid_sell.TabIndex = 0;
            this.grid_sell.Text = "dataGridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Редактировать данные сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.grid_product);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(750, 351);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Товар";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid_product
            // 
            this.grid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_product.Location = new System.Drawing.Point(4, 3);
            this.grid_product.Name = "grid_product";
            this.grid_product.Size = new System.Drawing.Size(516, 345);
            this.grid_product.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(526, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 126);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление товарами";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(47, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 30);
            this.button7.TabIndex = 0;
            this.button7.Text = "Добавить товар";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(47, 54);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "Удалить товар";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(47, 90);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 30);
            this.button9.TabIndex = 2;
            this.button9.Text = "Редактировать данные";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(646, 410);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 26);
            this.button10.TabIndex = 1;
            this.button10.Text = "Выход";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // FormPartial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 448);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPartial";
            this.Text = "Управляющая группа";
            this.Load += new System.EventHandler(this.FormPartial_Load);
            this.tabControl1.ResumeLayout(false);
            this.bookkeeping.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).EndInit();
            this.sale.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookkeeping;
        private System.Windows.Forms.TabPage sale;
        private System.Windows.Forms.DataGridView grid_employees;
        private System.Windows.Forms.DataGridView grid_sell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button red_sale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tx_box_s;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView grid_product;
        private System.Windows.Forms.Button button10;
    }
}