namespace Avtoservis2
{
    partial class FormFull
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
            this.clients = new System.Windows.Forms.TabPage();
            this.grid_clients = new System.Windows.Forms.DataGridView();
            this.employees = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editEmpl = new System.Windows.Forms.Button();
            this.btn_addEmployees = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_employees = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.TabPage();
            this.grid_product = new System.Windows.Forms.DataGridView();
            this.technical = new System.Windows.Forms.TabPage();
            this.grid_technical = new System.Windows.Forms.DataGridView();
            this.sales = new System.Windows.Forms.TabPage();
            this.grid_sell = new System.Windows.Forms.DataGridView();
            this.scan = new System.Windows.Forms.TabPage();
            this.filter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.param = new System.Windows.Forms.TextBox();
            this.box_param = new System.Windows.Forms.ComboBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.box_str = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_table = new System.Windows.Forms.ComboBox();
            this.grid_poisk = new System.Windows.Forms.DataGridView();
            this.report = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_box_s = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_summEmpl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).BeginInit();
            this.employees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).BeginInit();
            this.product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
            this.technical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_technical)).BeginInit();
            this.sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).BeginInit();
            this.scan.SuspendLayout();
            this.filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_poisk)).BeginInit();
            this.report.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clients);
            this.tabControl1.Controls.Add(this.employees);
            this.tabControl1.Controls.Add(this.product);
            this.tabControl1.Controls.Add(this.technical);
            this.tabControl1.Controls.Add(this.sales);
            this.tabControl1.Controls.Add(this.scan);
            this.tabControl1.Controls.Add(this.report);
            this.tabControl1.Location = new System.Drawing.Point(2, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // clients
            // 
            this.clients.Controls.Add(this.grid_clients);
            this.clients.Location = new System.Drawing.Point(4, 22);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(694, 374);
            this.clients.TabIndex = 2;
            this.clients.Text = "Клиенты";
            // 
            // grid_clients
            // 
            this.grid_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_clients.Location = new System.Drawing.Point(5, 3);
            this.grid_clients.Name = "grid_clients";
            this.grid_clients.Size = new System.Drawing.Size(489, 348);
            this.grid_clients.TabIndex = 0;
            this.grid_clients.Text = "dataGridView1";
            // 
            // employees
            // 
            this.employees.Controls.Add(this.groupBox1);
            this.employees.Controls.Add(this.grid_employees);
            this.employees.Location = new System.Drawing.Point(4, 22);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(694, 374);
            this.employees.TabIndex = 3;
            this.employees.Text = "Сотрудники";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editEmpl);
            this.groupBox1.Controls.Add(this.btn_addEmployees);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(475, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление сотрудниками";
            // 
            // editEmpl
            // 
            this.editEmpl.Location = new System.Drawing.Point(15, 101);
            this.editEmpl.Name = "editEmpl";
            this.editEmpl.Size = new System.Drawing.Size(181, 27);
            this.editEmpl.TabIndex = 3;
            this.editEmpl.Text = "Редактировать данные сотрудника";
            this.editEmpl.UseVisualStyleBackColor = true;
            this.editEmpl.Click += new System.EventHandler(this.editEmpl_Click);
            // 
            // btn_addEmployees
            // 
            this.btn_addEmployees.Location = new System.Drawing.Point(15, 30);
            this.btn_addEmployees.Name = "btn_addEmployees";
            this.btn_addEmployees.Size = new System.Drawing.Size(182, 30);
            this.btn_addEmployees.TabIndex = 1;
            this.btn_addEmployees.Text = "Добавить сотрудника";
            this.btn_addEmployees.UseVisualStyleBackColor = true;
            this.btn_addEmployees.Click += new System.EventHandler(this.btn_addEmployees_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Уволить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_employees
            // 
            this.grid_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_employees.Location = new System.Drawing.Point(5, 3);
            this.grid_employees.Name = "grid_employees";
            this.grid_employees.Size = new System.Drawing.Size(466, 369);
            this.grid_employees.TabIndex = 0;
            this.grid_employees.Text = "dataGridView1";
            // 
            // product
            // 
            this.product.Controls.Add(this.grid_product);
            this.product.Location = new System.Drawing.Point(4, 22);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(694, 374);
            this.product.TabIndex = 1;
            this.product.Text = "Товар";
            this.product.UseVisualStyleBackColor = true;
            // 
            // grid_product
            // 
            this.grid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_product.Location = new System.Drawing.Point(3, 3);
            this.grid_product.Name = "grid_product";
            this.grid_product.Size = new System.Drawing.Size(685, 365);
            this.grid_product.TabIndex = 0;
            this.grid_product.Text = "dataGridView1";
            // 
            // technical
            // 
            this.technical.Controls.Add(this.grid_technical);
            this.technical.Location = new System.Drawing.Point(4, 22);
            this.technical.Name = "technical";
            this.technical.Size = new System.Drawing.Size(694, 374);
            this.technical.TabIndex = 5;
            this.technical.Text = "Технические данные";
            // 
            // grid_technical
            // 
            this.grid_technical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_technical.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_technical.Location = new System.Drawing.Point(5, 3);
            this.grid_technical.Name = "grid_technical";
            this.grid_technical.Size = new System.Drawing.Size(562, 321);
            this.grid_technical.TabIndex = 0;
            this.grid_technical.Text = "dataGridView1";
            // 
            // sales
            // 
            this.sales.Controls.Add(this.grid_sell);
            this.sales.Location = new System.Drawing.Point(4, 22);
            this.sales.Name = "sales";
            this.sales.Padding = new System.Windows.Forms.Padding(3);
            this.sales.Size = new System.Drawing.Size(694, 374);
            this.sales.TabIndex = 0;
            this.sales.Text = "Продажи";
            this.sales.UseVisualStyleBackColor = true;
            // 
            // grid_sell
            // 
            this.grid_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sell.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_sell.Location = new System.Drawing.Point(6, 6);
            this.grid_sell.Name = "grid_sell";
            this.grid_sell.Size = new System.Drawing.Size(682, 362);
            this.grid_sell.TabIndex = 0;
            this.grid_sell.Text = "dataGridView1";
            // 
            // scan
            // 
            this.scan.Controls.Add(this.filter);
            this.scan.Controls.Add(this.grid_poisk);
            this.scan.Location = new System.Drawing.Point(4, 22);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(694, 374);
            this.scan.TabIndex = 6;
            this.scan.Text = "Поиск";
            // 
            // filter
            // 
            this.filter.Controls.Add(this.label2);
            this.filter.Controls.Add(this.param);
            this.filter.Controls.Add(this.box_param);
            this.filter.Controls.Add(this.btn_enter);
            this.filter.Controls.Add(this.name);
            this.filter.Controls.Add(this.box_str);
            this.filter.Controls.Add(this.label1);
            this.filter.Controls.Add(this.box_table);
            this.filter.Location = new System.Drawing.Point(0, 3);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(691, 73);
            this.filter.TabIndex = 3;
            this.filter.TabStop = false;
            this.filter.Text = "Фильтр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Условие отбора";
            // 
            // param
            // 
            this.param.Location = new System.Drawing.Point(370, 41);
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(99, 20);
            this.param.TabIndex = 5;
            // 
            // box_param
            // 
            this.box_param.FormattingEnabled = true;
            this.box_param.Items.AddRange(new object[] {
            "Like",
            "<",
            ">",
            "="});
            this.box_param.Location = new System.Drawing.Point(249, 41);
            this.box_param.Name = "box_param";
            this.box_param.Size = new System.Drawing.Size(104, 21);
            this.box_param.TabIndex = 4;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(483, 41);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(84, 20);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "Применить";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(0, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Выберите таблицу";
            // 
            // box_str
            // 
            this.box_str.FormattingEnabled = true;
            this.box_str.Location = new System.Drawing.Point(127, 41);
            this.box_str.Name = "box_str";
            this.box_str.Size = new System.Drawing.Size(104, 21);
            this.box_str.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Параметр";
            // 
            // box_table
            // 
            this.box_table.FormattingEnabled = true;
            this.box_table.Items.AddRange(new object[] {
            "Клиенты",
            "Сотрудники",
            "Товар",
            "Технические данные",
            "Продажи"});
            this.box_table.Location = new System.Drawing.Point(3, 41);
            this.box_table.Name = "box_table";
            this.box_table.Size = new System.Drawing.Size(104, 21);
            this.box_table.TabIndex = 1;
            this.box_table.SelectedIndexChanged += new System.EventHandler(this.box_table_SelectedIndexChanged);
            this.box_table.SelectedValueChanged += new System.EventHandler(this.box_table_SelectedValueChanged);
            // 
            // grid_poisk
            // 
            this.grid_poisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_poisk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_poisk.Location = new System.Drawing.Point(3, 81);
            this.grid_poisk.Name = "grid_poisk";
            this.grid_poisk.Size = new System.Drawing.Size(688, 290);
            this.grid_poisk.TabIndex = 0;
            this.grid_poisk.Text = "dataGridView1";
            // 
            // report
            // 
            this.report.Controls.Add(this.groupBox2);
            this.report.Location = new System.Drawing.Point(4, 22);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(694, 374);
            this.report.TabIndex = 4;
            this.report.Text = "Отчеты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tx_box_s);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_summEmpl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(16, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 370);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Бухгалтерия";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 252);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Выдать информацию о всех покупках на определенный период:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tx_box_s
            // 
            this.tx_box_s.Location = new System.Drawing.Point(136, 290);
            this.tx_box_s.Name = "tx_box_s";
            this.tx_box_s.Size = new System.Drawing.Size(120, 20);
            this.tx_box_s.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Общая сумма продаж";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Сумма продаж каждого сотрудника:";
            // 
            // btn_summEmpl
            // 
            this.btn_summEmpl.Location = new System.Drawing.Point(9, 209);
            this.btn_summEmpl.Name = "btn_summEmpl";
            this.btn_summEmpl.Size = new System.Drawing.Size(114, 31);
            this.btn_summEmpl.TabIndex = 0;
            this.btn_summEmpl.Text = "Открыть отчет";
            this.btn_summEmpl.UseVisualStyleBackColor = true;
            this.btn_summEmpl.Click += new System.EventHandler(this.btn_summEmpl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сумма продаж моделей каждой марки:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Открыть отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сумма продаж каждого работника";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(603, 434);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 24);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 86);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Итог по заработной плате";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 31);
            this.button5.TabIndex = 12;
            this.button5.Text = "Открыть отчет";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Введите период";
            // 
            // FormFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 484);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFull";
            this.Text = "Директор";
            this.Load += new System.EventHandler(this.FormFull_Load);
            this.tabControl1.ResumeLayout(false);
            this.clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clients)).EndInit();
            this.employees.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_employees)).EndInit();
            this.product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
            this.technical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_technical)).EndInit();
            this.sales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).EndInit();
            this.scan.ResumeLayout(false);
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_poisk)).EndInit();
            this.report.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clients;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.TabPage technical;
        private System.Windows.Forms.TabPage sales;
        private System.Windows.Forms.TabPage report;
        private System.Windows.Forms.DataGridView grid_clients;
        private System.Windows.Forms.DataGridView grid_product;
        private System.Windows.Forms.DataGridView grid_technical;
        private System.Windows.Forms.Button btn_addEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editEmpl;
        
        private System.Windows.Forms.DataGridView grid_sell;
        private System.Windows.Forms.TabPage scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_str;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox box_table;
        private System.Windows.Forms.DataGridView grid_poisk;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox param;
        private System.Windows.Forms.ComboBox box_param;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView grid_employees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_summEmpl;
        private System.Windows.Forms.TextBox tx_box_s;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
    }
}