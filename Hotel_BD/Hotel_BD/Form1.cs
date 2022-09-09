using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_BD
{
   

    public partial class Form1 : Form
    {
        SqlConnection CONNECT;
        string connection = @" Data Source= LAPTOP-VQTN067N\SQLEXPRESS; Initial catalog=Hotel; Integrated Security=True";
        string chooseTable;
        TabPage page_Table;
        TabPage page_Access;
        string passAdmin = "admin";
        string passManagment = "managment";
        string passSupport = "support";
        string passGuest = "guests";
        string writePass = ""; 
        string[] admin = { "Сотрудники", "Отдел по работе с гостями", "Управляющий отдел", "Поддерживающий отдел" , "Номера отеля" , "Гости" , "Кухня", "Расписание питания" , "Должности" , "Закупки" , "Запросы на ремонт", "Свободные номера", "Сумма затрат за месяц"};
        string[] managment = { "Сотрудники", "Номера отеля", "Гости", "Кухня", "Расписание питания", "Должности", "Закупки", "Запросы на ремонт", "Свободные номера", "Сумма затрат за месяц" };
        string[] support = { "Запросы на ремонт" };
        string[] guests = { "Отдел по работе с гостями", "Поддерживающий отдел", "Номера отеля", "Гости", "Расписание питания", "Запросы на ремонт", "Свободные номера" };
        public  BindingSource getChooseTable(string choose)
        {
            BindingSource nameTable = null;
            switch (choose)
            {
                case "Сотрудники": nameTable = employeeBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Отдел по работе с гостями": nameTable = department_working_with_clientsBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Управляющий отдел": nameTable = management_departmentBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Поддерживающий отдел": nameTable = supporting_departmentBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Номера отеля": nameTable = hotel_roomBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Гости":  nameTable = guestsBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Кухня": nameTable = kitchenBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Расписание питания": nameTable = mealScheduleBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Должности": nameTable = postBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Закупки": nameTable = purchaseBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Запросы на ремонт":  nameTable = repair_requestBindingSource; actons_table.Visible = true; input_month.Visible = false; break;
                case "Свободные номера": nameTable = free_roomBindingSource; actons_table.Visible = false; input_month.Visible = false; break;
                case "Сумма затрат за месяц": nameTable = sum_purchase_mounthBindingSource; actons_table.Visible = false; input_month.Visible = true; break;
            }

            return nameTable;
        }

        public Form1()
        {
            InitializeComponent();
            table.Visible = false;
            table.ReadOnly = true;
            actons_table.Visible = false;
            page_Table = tabControl1.TabPages[0];
            page_Access = tabControl1.TabPages[1];
            tabControl1.TabPages.Remove(page_Table);
        }

        private void choose_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseTable = choose_table.Text;
            table.Visible = true;
            switch (accessEmployee.Text)
            {
                case "Администратор":
                    actons_table.Visible = true;
                    break;
                case "Сотрудник управляющего отдела":
                    actons_table.Visible = true;
                    break;
                case "Сотрудник отдела по работе с гостями":
                    actons_table.Visible = true;
                    break;
                case "Сотрудник поддерживающего отдела":
                    break;
            }
            CONNECT = new SqlConnection(connection);
            CONNECT.Open();
            table.DataSource = getChooseTable(chooseTable);
            CONNECT.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Free_room". При необходимости она может быть перемещена или удалена.
            this.free_roomTableAdapter.Fill(this.dataHotel.Free_room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Supporting_department". При необходимости она может быть перемещена или удалена.
            this.supporting_departmentTableAdapter.Fill(this.dataHotel.Supporting_department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Repair_request". При необходимости она может быть перемещена или удалена.
            this.repair_requestTableAdapter.Fill(this.dataHotel.Repair_request);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.dataHotel.Purchase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.dataHotel.Post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.MealSchedule". При необходимости она может быть перемещена или удалена.
            this.mealScheduleTableAdapter.Fill(this.dataHotel.MealSchedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Management_department". При необходимости она может быть перемещена или удалена.
            this.management_departmentTableAdapter.Fill(this.dataHotel.Management_department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Kitchen". При необходимости она может быть перемещена или удалена.
            this.kitchenTableAdapter.Fill(this.dataHotel.Kitchen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Hotel_room". При необходимости она может быть перемещена или удалена.
            this.hotel_roomTableAdapter.Fill(this.dataHotel.Hotel_room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Guests". При необходимости она может быть перемещена или удалена.
            this.guestsTableAdapter.Fill(this.dataHotel.Guests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Department_working_with_clients". При необходимости она может быть перемещена или удалена.
            this.department_working_with_clientsTableAdapter.Fill(this.dataHotel.Department_working_with_clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataHotel.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataHotel.Employee);

        }

        private void INSERT_Click(object sender, EventArgs e) //Добавление строки
        {
            getChooseTable(chooseTable).AddNew();
            table.ReadOnly = false;
        }

        private void UPDATE_Click(object sender, EventArgs e) //Сохранение изменений
        {
            getChooseTable(chooseTable).EndEdit();
            switch (chooseTable)
            {
                case "Сотрудники": employeeTableAdapter.Update(dataHotel); break;
                case "Отдел по работе с гостями": department_working_with_clientsTableAdapter.Update(dataHotel); break;
                case "Управляющий отдел": management_departmentTableAdapter.Update(dataHotel); break;
                case "Поддерживающий отдел": supporting_departmentTableAdapter.Update(dataHotel); break;
                case "Номера отеля": hotel_roomTableAdapter.Update(dataHotel); break;
                case "Гости": guestsTableAdapter.Update(dataHotel); break;
                case "Кухня": kitchenTableAdapter.Update(dataHotel); break;
                case "Расписание питания": mealScheduleTableAdapter.Update(dataHotel); break;
                case "Должности": postTableAdapter.Update(dataHotel); break;
                case "Закупки": purchaseTableAdapter.Update(dataHotel); break;
                case "Запросы на ремонт": repair_requestTableAdapter.Update(dataHotel); break;
            }
            table.ReadOnly = true;
        }

        private void UPDATE_Click_1(object sender, EventArgs e) //Изменить
        {
            table.ReadOnly = false;
        }

        private void DELETE_Click(object sender, EventArgs e) //Удаить
        {
            getChooseTable(chooseTable).RemoveCurrent();
            getChooseTable(chooseTable).EndEdit();
            switch (chooseTable)
            {
                case "Сотрудники":  employeeTableAdapter.Update(dataHotel); break;
                case "Отдел по работе с гостями": department_working_with_clientsTableAdapter.Update(dataHotel); break;
                case "Управляющий отдел": management_departmentTableAdapter.Update(dataHotel); break;
                case "Поддерживающий отдел": supporting_departmentTableAdapter.Update(dataHotel); break;
                case "Номера отеля": hotel_roomTableAdapter.Update(dataHotel); break;
                case "Гости": guestsTableAdapter.Update(dataHotel); break;
                case "Кухня": kitchenTableAdapter.Update(dataHotel); break;
                case "Расписание питания": mealScheduleTableAdapter.Update(dataHotel); break;
                case "Должности": postTableAdapter.Update(dataHotel); break;
                case "Закупки": purchaseTableAdapter.Update(dataHotel); break;
                case "Запросы на ремонт": repair_requestTableAdapter.Update(dataHotel); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string access = accessEmployee.Text;
            writePass = password.Text;
            switch (access)
            {
                case "Администратор":  
                    if (writePass == passAdmin)
                    {
                        tabControl1.TabPages.Add(page_Table);
                        for (int i = 0; i < admin.Length; i++)
                            choose_table.Items.Add(admin[i]);
                        tabControl1.TabPages.Remove(page_Access);
                    }
                    else { 
                    MessageBox.Show("Ошибка входа, проверьте пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Сотрудник управляющего отдела":
                    if (writePass == passManagment)
                    {
                        tabControl1.TabPages.Add(page_Table);
                        for (int i = 0; i < managment.Length; i++)
                            choose_table.Items.Add(managment[i]);
                        tabControl1.TabPages.Remove(page_Access);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка входа, проверьте пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Сотрудник отдела по работе с гостями":
                    if (writePass == passGuest)
                    {
                        tabControl1.TabPages.Add(page_Table);
                        for (int i = 0; i < guests.Length; i++)
                            choose_table.Items.Add(guests[i]);
                        tabControl1.TabPages.Remove(page_Access);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка входа, проверьте пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Сотрудник поддерживающего отдела":
                    if (writePass == passSupport)
                    {
                        tabControl1.TabPages.Add(page_Table);
                        for (int i = 0; i < support.Length; i++)
                            choose_table.Items.Add(support[i]);
                        tabControl1.TabPages.Remove(page_Access);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка входа, проверьте пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                   
            }
            accessNow.Text = access;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.sum_purchase_mounthTableAdapter.Fill(this.dataHotel.sum_purchase_mounth, new System.Nullable<int>(((int)(System.Convert.ChangeType(month.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
