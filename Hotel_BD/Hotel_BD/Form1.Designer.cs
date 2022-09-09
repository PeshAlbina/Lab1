namespace Hotel_BD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.table = new System.Windows.Forms.DataGridView();
            this.choose_table = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.work_with_table = new System.Windows.Forms.TabPage();
            this.accessNow = new System.Windows.Forms.Label();
            this.actons_table = new System.Windows.Forms.GroupBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.check_access = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.accessEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sum_purchase_mounthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataHotel = new Hotel_BD.DataHotel();
            this.dataHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Hotel_BD.DataHotelTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new Hotel_BD.DataHotelTableAdapters.TableAdapterManager();
            this.department_working_with_clientsTableAdapter = new Hotel_BD.DataHotelTableAdapters.Department_working_with_clientsTableAdapter();
            this.guestsTableAdapter = new Hotel_BD.DataHotelTableAdapters.GuestsTableAdapter();
            this.hotel_roomTableAdapter = new Hotel_BD.DataHotelTableAdapters.Hotel_roomTableAdapter();
            this.kitchenTableAdapter = new Hotel_BD.DataHotelTableAdapters.KitchenTableAdapter();
            this.management_departmentTableAdapter = new Hotel_BD.DataHotelTableAdapters.Management_departmentTableAdapter();
            this.mealScheduleTableAdapter = new Hotel_BD.DataHotelTableAdapters.MealScheduleTableAdapter();
            this.postTableAdapter = new Hotel_BD.DataHotelTableAdapters.PostTableAdapter();
            this.purchaseTableAdapter = new Hotel_BD.DataHotelTableAdapters.PurchaseTableAdapter();
            this.repair_requestTableAdapter = new Hotel_BD.DataHotelTableAdapters.Repair_requestTableAdapter();
            this.supporting_departmentTableAdapter = new Hotel_BD.DataHotelTableAdapters.Supporting_departmentTableAdapter();
            this.department_working_with_clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.management_departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repair_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supporting_departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.free_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.free_roomTableAdapter = new Hotel_BD.DataHotelTableAdapters.Free_roomTableAdapter();
            this.sum_purchase_mounthTableAdapter = new Hotel_BD.DataHotelTableAdapters.sum_purchase_mounthTableAdapter();
            this.month = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.input_month = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.work_with_table.SuspendLayout();
            this.actons_table.SuspendLayout();
            this.check_access.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_purchase_mounthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_working_with_clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repair_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supporting_departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.free_roomBindingSource)).BeginInit();
            this.input_month.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(23, 51);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowTemplate.Height = 28;
            this.table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table.Size = new System.Drawing.Size(752, 270);
            this.table.TabIndex = 0;
            // 
            // choose_table
            // 
            this.choose_table.FormattingEnabled = true;
            this.choose_table.Location = new System.Drawing.Point(316, 18);
            this.choose_table.Name = "choose_table";
            this.choose_table.Size = new System.Drawing.Size(180, 27);
            this.choose_table.TabIndex = 1;
            this.choose_table.Text = "Выберите таблицу";
            this.choose_table.SelectedIndexChanged += new System.EventHandler(this.choose_table_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.work_with_table);
            this.tabControl1.Controls.Add(this.check_access);
            this.tabControl1.Location = new System.Drawing.Point(-3, -6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 440);
            this.tabControl1.TabIndex = 2;
            // 
            // work_with_table
            // 
            this.work_with_table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("work_with_table.BackgroundImage")));
            this.work_with_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.work_with_table.Controls.Add(this.input_month);
            this.work_with_table.Controls.Add(this.accessNow);
            this.work_with_table.Controls.Add(this.actons_table);
            this.work_with_table.Controls.Add(this.choose_table);
            this.work_with_table.Controls.Add(this.table);
            this.work_with_table.Location = new System.Drawing.Point(4, 28);
            this.work_with_table.Name = "work_with_table";
            this.work_with_table.Padding = new System.Windows.Forms.Padding(3);
            this.work_with_table.Size = new System.Drawing.Size(797, 408);
            this.work_with_table.TabIndex = 0;
            this.work_with_table.Text = "Работа с таблицами";
            this.work_with_table.UseVisualStyleBackColor = true;
            // 
            // accessNow
            // 
            this.accessNow.AutoSize = true;
            this.accessNow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accessNow.Location = new System.Drawing.Point(536, 18);
            this.accessNow.Name = "accessNow";
            this.accessNow.Size = new System.Drawing.Size(120, 19);
            this.accessNow.TabIndex = 6;
            this.accessNow.Text = "Текущий доступ";
            // 
            // actons_table
            // 
            this.actons_table.Controls.Add(this.UPDATE);
            this.actons_table.Controls.Add(this.INSERT);
            this.actons_table.Controls.Add(this.DELETE);
            this.actons_table.Controls.Add(this.SAVE);
            this.actons_table.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.actons_table.Location = new System.Drawing.Point(109, 327);
            this.actons_table.Name = "actons_table";
            this.actons_table.Size = new System.Drawing.Size(618, 75);
            this.actons_table.TabIndex = 5;
            this.actons_table.TabStop = false;
            this.actons_table.Text = "Действия с таблицой";
            this.actons_table.Visible = false;
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UPDATE.Location = new System.Drawing.Point(352, 24);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(105, 37);
            this.UPDATE.TabIndex = 5;
            this.UPDATE.Text = "Изменить";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click_1);
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.INSERT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.INSERT.Location = new System.Drawing.Point(6, 25);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(151, 36);
            this.INSERT.TabIndex = 2;
            this.INSERT.Text = "Добавить строку";
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DELETE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DELETE.Location = new System.Drawing.Point(484, 25);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(101, 37);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "Удалить";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SAVE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SAVE.Location = new System.Drawing.Point(203, 25);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(117, 37);
            this.SAVE.TabIndex = 3;
            this.SAVE.Text = "Сохранить";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // check_access
            // 
            this.check_access.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_access.BackgroundImage")));
            this.check_access.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check_access.Controls.Add(this.button1);
            this.check_access.Controls.Add(this.password);
            this.check_access.Controls.Add(this.accessEmployee);
            this.check_access.Controls.Add(this.label2);
            this.check_access.Controls.Add(this.label1);
            this.check_access.Location = new System.Drawing.Point(4, 28);
            this.check_access.Name = "check_access";
            this.check_access.Padding = new System.Windows.Forms.Padding(3);
            this.check_access.Size = new System.Drawing.Size(797, 408);
            this.check_access.TabIndex = 1;
            this.check_access.Text = "Уровень доступа";
            this.check_access.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(371, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password.Location = new System.Drawing.Point(302, 228);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(213, 26);
            this.password.TabIndex = 3;
            // 
            // accessEmployee
            // 
            this.accessEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.accessEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accessEmployee.FormattingEnabled = true;
            this.accessEmployee.Items.AddRange(new object[] {
            "Администратор",
            "Сотрудник управляющего отдела",
            "Сотрудник отдела по работе с гостями",
            "Сотрудник поддерживающего отдела"});
            this.accessEmployee.Location = new System.Drawing.Point(302, 126);
            this.accessEmployee.Name = "accessEmployee";
            this.accessEmployee.Size = new System.Drawing.Size(213, 27);
            this.accessEmployee.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(347, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(318, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите уровень доступа";
            // 
            // sum_purchase_mounthBindingSource
            // 
            this.sum_purchase_mounthBindingSource.DataMember = "sum_purchase_mounth";
            this.sum_purchase_mounthBindingSource.DataSource = this.dataHotel;
            // 
            // dataHotel
            // 
            this.dataHotel.DataSetName = "DataHotel";
            this.dataHotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataHotelBindingSource
            // 
            this.dataHotelBindingSource.DataSource = this.dataHotel;
            this.dataHotelBindingSource.Position = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataHotel;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Department_working_with_clientsTableAdapter = this.department_working_with_clientsTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.GuestsTableAdapter = this.guestsTableAdapter;
            this.tableAdapterManager.Hotel_roomTableAdapter = this.hotel_roomTableAdapter;
            this.tableAdapterManager.KitchenTableAdapter = this.kitchenTableAdapter;
            this.tableAdapterManager.Management_departmentTableAdapter = this.management_departmentTableAdapter;
            this.tableAdapterManager.MealScheduleTableAdapter = this.mealScheduleTableAdapter;
            this.tableAdapterManager.PostTableAdapter = this.postTableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = this.purchaseTableAdapter;
            this.tableAdapterManager.Repair_requestTableAdapter = this.repair_requestTableAdapter;
            this.tableAdapterManager.Supporting_departmentTableAdapter = this.supporting_departmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hotel_BD.DataHotelTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // department_working_with_clientsTableAdapter
            // 
            this.department_working_with_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // hotel_roomTableAdapter
            // 
            this.hotel_roomTableAdapter.ClearBeforeFill = true;
            // 
            // kitchenTableAdapter
            // 
            this.kitchenTableAdapter.ClearBeforeFill = true;
            // 
            // management_departmentTableAdapter
            // 
            this.management_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // mealScheduleTableAdapter
            // 
            this.mealScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // repair_requestTableAdapter
            // 
            this.repair_requestTableAdapter.ClearBeforeFill = true;
            // 
            // supporting_departmentTableAdapter
            // 
            this.supporting_departmentTableAdapter.ClearBeforeFill = true;
            // 
            // department_working_with_clientsBindingSource
            // 
            this.department_working_with_clientsBindingSource.DataMember = "Department_working_with_clients";
            this.department_working_with_clientsBindingSource.DataSource = this.dataHotel;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.dataHotel;
            // 
            // hotel_roomBindingSource
            // 
            this.hotel_roomBindingSource.DataMember = "Hotel_room";
            this.hotel_roomBindingSource.DataSource = this.dataHotel;
            // 
            // kitchenBindingSource
            // 
            this.kitchenBindingSource.DataMember = "Kitchen";
            this.kitchenBindingSource.DataSource = this.dataHotel;
            // 
            // management_departmentBindingSource
            // 
            this.management_departmentBindingSource.DataMember = "Management_department";
            this.management_departmentBindingSource.DataSource = this.dataHotel;
            // 
            // mealScheduleBindingSource
            // 
            this.mealScheduleBindingSource.DataMember = "MealSchedule";
            this.mealScheduleBindingSource.DataSource = this.dataHotel;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.dataHotel;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.dataHotel;
            // 
            // repair_requestBindingSource
            // 
            this.repair_requestBindingSource.DataMember = "Repair_request";
            this.repair_requestBindingSource.DataSource = this.dataHotel;
            // 
            // supporting_departmentBindingSource
            // 
            this.supporting_departmentBindingSource.DataMember = "Supporting_department";
            this.supporting_departmentBindingSource.DataSource = this.dataHotel;
            // 
            // free_roomBindingSource
            // 
            this.free_roomBindingSource.DataMember = "Free_room";
            this.free_roomBindingSource.DataSource = this.dataHotel;
            // 
            // free_roomTableAdapter
            // 
            this.free_roomTableAdapter.ClearBeforeFill = true;
            // 
            // sum_purchase_mounthTableAdapter
            // 
            this.sum_purchase_mounthTableAdapter.ClearBeforeFill = true;
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.month.ForeColor = System.Drawing.Color.White;
            this.month.Location = new System.Drawing.Point(68, 22);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(63, 26);
            this.month.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Месяц:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(148, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input_month
            // 
            this.input_month.Controls.Add(this.label3);
            this.input_month.Controls.Add(this.button2);
            this.input_month.Controls.Add(this.month);
            this.input_month.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.input_month.Location = new System.Drawing.Point(23, 327);
            this.input_month.Name = "input_month";
            this.input_month.Size = new System.Drawing.Size(285, 51);
            this.input_month.TabIndex = 10;
            this.input_month.TabStop = false;
            this.input_month.Text = "Выбор месяца";
            this.input_month.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 434);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Гранд Отель Чайковский";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.work_with_table.ResumeLayout(false);
            this.work_with_table.PerformLayout();
            this.actons_table.ResumeLayout(false);
            this.check_access.ResumeLayout(false);
            this.check_access.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum_purchase_mounthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_working_with_clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.management_departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repair_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supporting_departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.free_roomBindingSource)).EndInit();
            this.input_month.ResumeLayout(false);
            this.input_month.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.BindingSource dataHotelBindingSource;
        private DataHotel dataHotel;
        private System.Windows.Forms.ComboBox choose_table;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataHotelTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DataHotelTableAdapters.TableAdapterManager tableAdapterManager;
        private DataHotelTableAdapters.Department_working_with_clientsTableAdapter department_working_with_clientsTableAdapter;
        private System.Windows.Forms.BindingSource department_working_with_clientsBindingSource;
        private DataHotelTableAdapters.GuestsTableAdapter guestsTableAdapter;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private DataHotelTableAdapters.Hotel_roomTableAdapter hotel_roomTableAdapter;
        private System.Windows.Forms.BindingSource hotel_roomBindingSource;
        private DataHotelTableAdapters.KitchenTableAdapter kitchenTableAdapter;
        private System.Windows.Forms.BindingSource kitchenBindingSource;
        private DataHotelTableAdapters.Management_departmentTableAdapter management_departmentTableAdapter;
        private System.Windows.Forms.BindingSource management_departmentBindingSource;
        private DataHotelTableAdapters.MealScheduleTableAdapter mealScheduleTableAdapter;
        private System.Windows.Forms.BindingSource mealScheduleBindingSource;
        private DataHotelTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource postBindingSource;
        private DataHotelTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private DataHotelTableAdapters.Repair_requestTableAdapter repair_requestTableAdapter;
        private System.Windows.Forms.BindingSource repair_requestBindingSource;
        private DataHotelTableAdapters.Supporting_departmentTableAdapter supporting_departmentTableAdapter;
        private System.Windows.Forms.BindingSource supporting_departmentBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage work_with_table;
        private System.Windows.Forms.TabPage check_access;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.GroupBox actons_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox accessEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accessNow;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.BindingSource free_roomBindingSource;
        private DataHotelTableAdapters.Free_roomTableAdapter free_roomTableAdapter;
        private System.Windows.Forms.BindingSource sum_purchase_mounthBindingSource;
        private DataHotelTableAdapters.sum_purchase_mounthTableAdapter sum_purchase_mounthTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.GroupBox input_month;
    }
}

