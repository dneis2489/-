using pharmacy.data;
using pharmacy.service;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pharmacy
{
    public partial class RootController : Form
    {
        public RootController(AuthorizationController authControl)
        {
            InitializeComponent();
            ScheduleService = ScheduleService.Instance;
            UsersService = UsersService.Instance;
            PharmacyService = PharmacyService.Instance;
            StatusService = StatusService.Instance;
            CategoryService = CategoryService.Instance;
            StatisticsService = StatisticsService.Instance;
            authController = authControl;
            this.productSalesData = new DataTable();
        }

        private ScheduleService ScheduleService { get; }
        private UsersService UsersService { get; }
        private PharmacyService PharmacyService { get; }
        private StatusService StatusService { get; }
        private CategoryService CategoryService { get; }
        private StatisticsService StatisticsService { get; }

        private AuthorizationController authController { get;}

        private DataTable productSalesData;

        private void ClearFormBeforeLoading()
        {
            //Вкладка добавить данные
            cmbBxSchedulePhramacy.Items.Clear();
            cmbBxSystemRole.Items.Clear();
            cmbBxLinkedPharmacy.Items.Clear();
            cmbBxDeletePharmacyName.Items.Clear();
            cmbBxDeleteWorkScheduleName.Items.Clear();
            cmbBxDeleteUserFullName.Items.Clear();
            cmbBxDeleteOrderStatusName.Items.Clear();
            cmbBxDeleteCategoryName.Items.Clear();
        }

        private void RootForm1_Load(object sender, EventArgs e)
        {
            //Вкладка добавить данные
            ClearFormBeforeLoading();
            
            //Подгрузка графиков работ для добавления Магазина
            ScheduleService.GetAll().ForEach(item => cmbBxSchedulePhramacy.Items.Add(item));

            //Подгрузка системных ролей и магазинов для добавления пользователя
            var pharmacies = PharmacyService.GetAll();
            UsersService.GetAllRoles().ForEach(item => cmbBxSystemRole.Items.Add(item));            
            pharmacies.ForEach(item => cmbBxLinkedPharmacy.Items.Add(item));

            //Вкладка удалить данные
            //Магазины
            pharmacies.ForEach(item => cmbBxDeletePharmacyName.Items.Add(item));

            //Графики
            ScheduleService.GetAll().ForEach(item => cmbBxDeleteWorkScheduleName.Items.Add(item));

            //Пользователи            
            UsersService.GetAll().ForEach(item => cmbBxDeleteUserFullName.Items.Add(item));

            //Статусы            
            StatusService.GetAll().ForEach(item => cmbBxDeleteOrderStatusName.Items.Add(item));

            //Категории            
            CategoryService.GetAll().ForEach(item => cmbBxDeleteCategoryName.Items.Add(item));           

            //Вкладка статусы
            rootPharmaciesStatisticsTable.Visible = false;
            rootMedicinesStatisticsTable.Visible = false;
            rootRevenueChart.Visible = true;
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ДОБАВИТЬ ДАННЫЕ
        private void btnAddPharmacy_Click(object sender, EventArgs e) //Добавить магазин - Добавить
        {
            if (!Equals(cmbBxSchedulePhramacy.SelectedItem, "") && txtBxPhramacyName.Text != "" && txtBxPhramacyAddress.Text != "" && txtBxPhramacyPhoneNumber.Text != "")
            {
                string choice = cmbBxSchedulePhramacy.SelectedItem.ToString();
                char id = choice[0];
                int sheduleId = Int32.Parse(id.ToString());

                PharmacyService.Add(txtBxPhramacyName.Text, txtBxPhramacyAddress.Text, txtBxPhramacyPhoneNumber.Text, sheduleId);

                cmbBxSchedulePhramacy.SelectedIndex = -1;
                txtBxPhramacyName.Text = "";
                txtBxPhramacyAddress.Text = "";
                txtBxPhramacyPhoneNumber.Text = "";
                cmbBxDeletePharmacyName.Items.Clear();
                cmbBxLinkedPharmacy.Items.Clear();
                var pharmacies = PharmacyService.GetAll();
                pharmacies.ForEach(item => cmbBxDeletePharmacyName.Items.Add(item));
                pharmacies.ForEach(item => cmbBxLinkedPharmacy.Items.Add(item));
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearPharmacy_Click(object sender, EventArgs e)//Добавить магазин - Отчистить
        {
            cmbBxSchedulePhramacy.SelectedIndex = -1;
            txtBxPhramacyName.Text = "";
            txtBxPhramacyAddress.Text = "";
            txtBxPhramacyPhoneNumber.Text = "";
        }

        private void btnAddCategory_Click(object sender, EventArgs e) //Добавить категорию - Добавить
        {
            if (txtBxCategoryName.Text != "")
            {
                CategoryService.Add(txtBxCategoryName.Text);
                txtBxCategoryName.Text = "";
                cmbBxDeleteCategoryName.Items.Clear();
                CategoryService.GetAll().ForEach(item => cmbBxDeleteCategoryName.Items.Add(item));
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearCategory_Click(object sender, EventArgs e) //Добавить категорию - Отчистить
        {
            txtBxCategoryName.Text = "";
        }

        private void btnAddSchedule_Click(object sender, EventArgs e) // Добавить график работы - Добавить
        {
            if (txtBxStartOnWeekdays.Text != "" && txtBxEndOnWeekdays.Text != "" && txtBxStartOnWeekend.Text != "" && txtBxEndOnWeekend.Text != "")
            {
                ScheduleService.Add(txtBxStartOnWeekdays.Text, txtBxEndOnWeekdays.Text, txtBxStartOnWeekend.Text, txtBxEndOnWeekend.Text);
                txtBxStartOnWeekdays.Text = "";
                txtBxEndOnWeekdays.Text = "";
                txtBxStartOnWeekend.Text = "";
                txtBxEndOnWeekend.Text = "";
                cmbBxSchedulePhramacy.Items.Clear();
                cmbBxDeleteWorkScheduleName.Items.Clear();
                ScheduleService.GetAll().ForEach(item => cmbBxSchedulePhramacy.Items.Add(item));
                ScheduleService.GetAll().ForEach(item => cmbBxDeleteWorkScheduleName.Items.Add(item));
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearSchedule_Click(object sender, EventArgs e) // Добавить график работы - Отчитстить
        {
            txtBxStartOnWeekdays.Text = "";
            txtBxEndOnWeekdays.Text = "";
            txtBxStartOnWeekend.Text = "";
            txtBxEndOnWeekend.Text = "";
        }

        private void btnAddOrderStatus_Click(object sender, EventArgs e)//Добавить статус - Добавить
        {
            if (txtBxStatusName.Text != "")
            {
                StatusService.Add(txtBxStatusName.Text);
                txtBxStatusName.Text = "";
                cmbBxDeleteOrderStatusName.Items.Clear();
                StatusService.GetAll().ForEach(item => cmbBxDeleteOrderStatusName.Items.Add(item));
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearOrderStatus_Click(object sender, EventArgs e)//Добавить статус - Отчистить
        {
            txtBxStatusName.Text = "";
        }

        private void btnAddUser_Click(object sender, EventArgs e) //Добавить пользователей - Добавить
        {
            if (txtBxFullName.Text != "" && txtBxBirthDate.Text != "" && txtBxPhoneNumber.Text != "" && txtBxLogin.Text != "" && txtBxPassword.Text != "" && txtBxRetypePassword.Text != "" &&
                !Equals(cmbBxSystemRole.SelectedItem, ""))
            {
                if (txtBxPassword.Text == txtBxRetypePassword.Text && ((cmbBxSystemRole.SelectedItem.ToString() == "Администратор" && cmbBxLinkedPharmacy.SelectedIndex != -1) || (cmbBxSystemRole.SelectedItem.ToString() != "Администратор")))
                {
                    
                    string choiceRole = cmbBxSystemRole.SelectedItem.ToString();
                    char role = choiceRole[0];
                    int roleId = Int32.Parse(role.ToString());
                    if (cmbBxSystemRole.SelectedItem.ToString() == "2. Администратор" && cmbBxLinkedPharmacy.SelectedIndex != -1)
                    {
                        string choicePharm = cmbBxLinkedPharmacy.SelectedItem.ToString();
                        char pharm = choicePharm[0];
                        int pharmId = Int32.Parse(pharm.ToString());
                        UsersService.AddUser(txtBxFullName.Text, txtBxBirthDate.Text, txtBxPhoneNumber.Text, txtBxLogin.Text, txtBxPassword.Text, roleId, pharmId);
                    }
                    else
                    {
                        UsersService.AddUser(txtBxFullName.Text, txtBxBirthDate.Text, txtBxPhoneNumber.Text, txtBxLogin.Text, txtBxPassword.Text, roleId, 0);
                    }
                    txtBxFullName.Text = "";
                    txtBxBirthDate.Text = "";
                    txtBxPhoneNumber.Text = "";
                    txtBxLogin.Text = "";
                    txtBxPassword.Text = "";
                    txtBxRetypePassword.Text = "";
                    cmbBxSystemRole.SelectedIndex = -1;
                    cmbBxLinkedPharmacy.SelectedIndex = -1;
                    cmbBxDeleteUserFullName.Items.Clear();
                    UsersService.GetAll().ForEach(item => cmbBxDeleteUserFullName.Items.Add(item));
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Пожалуйста, попробуйте ещё раз", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ошибка подключения к базе с аптеками", "Пожалуйста, попробуйте ещё раз", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)//Добавить пользователей - Отчистить
        {
            txtBxFullName.Text = "";
            txtBxBirthDate.Text = "";
            txtBxPhoneNumber.Text = "";
            txtBxLogin.Text = "";
            txtBxPassword.Text = "";
            txtBxRetypePassword.Text = "";
            cmbBxSystemRole.SelectedIndex = -1;
            cmbBxLinkedPharmacy.SelectedIndex = -1;

        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел УДАЛИТЬ ДАННЫЕ
        private void btnDeletePharmacy_Click(object sender, EventArgs e) //Удалить Магазин - Удалить
        {
            if (cmbBxDeletePharmacyName.SelectedIndex != -1)
            {
                string choice = cmbBxDeletePharmacyName.SelectedItem.ToString();
                string[] parts = choice.Split('.');
                int pharmId = Int32.Parse(parts[0].ToString());
                if(pharmId == 1)
                {
                    MessageBox.Show("Невозможно удалить главную аптеку", "Пожалуйста, выберете другого пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PharmacyService.Delete(pharmId);
                }
                cmbBxDeletePharmacyName.SelectedIndex = -1;
                cmbBxDeletePharmacyName.Items.Clear();
                cmbBxLinkedPharmacy.Items.Clear();
                var pharmacies = PharmacyService.GetAll();
                pharmacies.ForEach(item => cmbBxDeletePharmacyName.Items.Add(item));
                pharmacies.ForEach(item => cmbBxLinkedPharmacy.Items.Add(item));


            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletePharmacyClear_Click(object sender, EventArgs e) //Удалить Магазин - Отчистить
        {
            cmbBxDeletePharmacyName.SelectedIndex = -1;
        }

        private void btnDeleteWorkSchedule_Click(object sender, EventArgs e) //Удалить График работы - Удалить
        {
            if (cmbBxDeleteWorkScheduleName.SelectedIndex != -1)
            {
                string choice = cmbBxDeleteWorkScheduleName.SelectedItem.ToString();
                string[] parts = choice.Split('.');
                int cheduleId = Int32.Parse(parts[0].ToString());
                if (cheduleId == 1)
                {
                    MessageBox.Show("Невозможно удалить главный график работы", "Пожалуйста, выберете другой график", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ScheduleService.Delete(cheduleId);
                }
                cmbBxDeleteWorkScheduleName.SelectedIndex = -1;
                cmbBxSchedulePhramacy.Items.Clear();
                cmbBxDeleteWorkScheduleName.Items.Clear();
                ScheduleService.GetAll().ForEach(item => cmbBxSchedulePhramacy.Items.Add(item));
                ScheduleService.GetAll().ForEach(item => cmbBxDeleteWorkScheduleName.Items.Add(item));
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteWorkScheduleClear_Click(object sender, EventArgs e) //Удалить График работы - Отчистить
        {
            cmbBxDeleteWorkScheduleName.SelectedIndex = -1;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e) //Удалить Пользователя - Удалить
        {
            if (cmbBxDeleteUserFullName.SelectedIndex != -1)
            {
                string choice = cmbBxDeleteUserFullName.SelectedItem.ToString();
                string[] parts = choice.Split('.');
                int userId = Int32.Parse(parts[0].ToString());
                if (userId == 1)
                {
                    MessageBox.Show("Невозможно удалить главного администратора", "Пожалуйста, выберете другого пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UsersService.Delete(userId);
                }

                cmbBxDeleteUserFullName.SelectedIndex = -1;
                cmbBxDeleteUserFullName.Items.Clear();
                UsersService.GetAll().ForEach(item => cmbBxDeleteUserFullName.Items.Add(item));
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUserClear_Click(object sender, EventArgs e) //Удалить Пользователя - Отчистить
        {
            cmbBxDeleteUserFullName.SelectedIndex = -1;
        }

        private void btnDeleteOrderStatus_Click(object sender, EventArgs e) //Удалить Статус - Удалить 
        {
            if (cmbBxDeleteOrderStatusName.SelectedIndex != -1)
            {
                string choice = cmbBxDeleteOrderStatusName.SelectedItem.ToString();
                string[] parts = choice.Split('.');
                int statId = Int32.Parse(parts[0].ToString());

                if (statId == 1)
                {
                    MessageBox.Show("Невозможно удалить основной статус", "Пожалуйста, выберете другой статус", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    StatusService.Delete(statId);
                }
                cmbBxDeleteOrderStatusName.SelectedIndex = -1;
                cmbBxDeleteOrderStatusName.Items.Clear();
                StatusService.GetAll().ForEach(item => cmbBxDeleteOrderStatusName.Items.Add(item));
                
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteOrderStatusClear_Click(object sender, EventArgs e) //Удалить Статус - Отчистить
        {
            cmbBxDeleteOrderStatusName.SelectedIndex = -1;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e) //Удалить Категорию - Удалить 
        {
            if (cmbBxDeleteCategoryName.SelectedIndex != -1)
            {
                string choice = cmbBxDeleteCategoryName.SelectedItem.ToString();
                string[] parts = choice.Split('.');
                int catId = Int32.Parse(parts[0].ToString());
                if (catId == 1)
                {
                    MessageBox.Show("Невозможно удалить освновную категорию", "Пожалуйста, выберете другую категорию", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CategoryService.Delete(catId);
                }
                cmbBxDeleteCategoryName.SelectedIndex = -1;
                cmbBxDeleteCategoryName.Items.Clear();
                CategoryService.GetAll().ForEach(item => cmbBxDeleteCategoryName.Items.Add(item));
                
            }
            else
            {
                MessageBox.Show("Заполнены не все обязательные поля", "Пожалуйста, заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteCategoryClear_Click(object sender, EventArgs e) //Удалить Категорию - Отчистить
        {
            cmbBxDeleteCategoryName.SelectedItem = "";
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел СТАТИСТИКА
        private void btnNumberProductSold_Click(object sender, EventArgs e) //Статистика - Количество проданной продукции
        {
            productSalesData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            rootRevenueChart.Series.Clear();
            rootRevenueChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            rootRevenueChart.ChartAreas.Add(chartArea);

            rootRevenueChart.Visible = true;
            rootPharmaciesStatisticsTable.Visible = false;
            rootMedicinesStatisticsTable.Visible = false;
            Series series = new Series("DataPoints");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            productSalesData.Clear();
            productSalesData = StatisticsService.RootGetCountBuyMedicinesStat();



            foreach (DataRow row in productSalesData.Rows)
            {
                DateTime date = (DateTime)row["Дата"];
                int quantity = (int)row["Значение"];
                DateTime monthYearDate = new DateTime(date.Year, date.Month, 1);

                series.Points.AddXY(monthYearDate.ToString("MM.yyyy"), quantity);
            }


            rootRevenueChart.Series.Add(series);
        }

        private void btnNumberOrders_Click(object sender, EventArgs e) //Статистика - Количество заказов
        {
            productSalesData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            rootRevenueChart.Series.Clear();
            rootRevenueChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            rootRevenueChart.ChartAreas.Add(chartArea);

            rootRevenueChart.Visible = true;
            rootPharmaciesStatisticsTable.Visible = false;
            rootMedicinesStatisticsTable.Visible = false;
            Series series = new Series("DataPoints");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            productSalesData.Clear();
            productSalesData = StatisticsService.RootGetCountBasketStat();

            rootRevenueChart.Series.Clear();

            foreach (DataRow row in productSalesData.Rows)
            {
                DateTime date = (DateTime)row["Дата"];
                int quantity = (int)row["Значение"];
                DateTime monthYearDate = new DateTime(date.Year, date.Month, 1);

                series.Points.AddXY(monthYearDate.ToString("MM.yyyy"), quantity);
            }

            rootRevenueChart.Series.Add(series);
        }

        private void btnTopPharmacies_Click(object sender, EventArgs e) //Статистика - Рейтинг магазинов
        {
            productSalesData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            rootRevenueChart.Visible = false;
            rootPharmaciesStatisticsTable.Visible = true;
            rootMedicinesStatisticsTable.Visible = false;
            StatisticsService.GetTopPharmacy();
            rootPharmaciesStatisticsTable.DataSource = StatisticsService.dtStat;
        }


        private void btnTopMedicines_Click(object sender, EventArgs e) //Рейтинг лекарств
        {
            productSalesData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            rootRevenueChart.Visible = false;
            rootPharmaciesStatisticsTable.Visible = false;
            rootMedicinesStatisticsTable.Visible = true;

            StatisticsService.GetTopMedicines();

            rootMedicinesStatisticsTable.DataSource = StatisticsService.dtStat2;
        }

        private void btnRevenue_Click(object sender, EventArgs e) //Статистика - Доходы
        {
            productSalesData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            rootRevenueChart.Series.Clear();
            rootRevenueChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            rootRevenueChart.ChartAreas.Add(chartArea);

            rootRevenueChart.Visible = true;
            rootPharmaciesStatisticsTable.Visible = false;
            rootMedicinesStatisticsTable.Visible = false;
            Series series = new Series("DataPoints");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            productSalesData = StatisticsService.RootGetRevenueByMonth();

            rootRevenueChart.Series.Clear();

            foreach (DataRow row in productSalesData.Rows)
            {
                DateTime date = (DateTime)row["Дата"];
                int quantity = (int)row["Значение"];
                DateTime monthYearDate = new DateTime(date.Year, date.Month, 1);

                series.Points.AddXY(monthYearDate.ToString("MM.yyyy"), quantity);
            }

            rootRevenueChart.Series.Add(series);
        }




        //Экспорт
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл Excel";
            saveFileDialog.FileName = "Отчет по статистике.xlsx"; // Имя файла по умолчанию

            DataTable exportData = new DataTable();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (productSalesData.Rows.Count != 0)
                    {
                        exportData = productSalesData;
                    }
                    else if (StatisticsService.dtStat.Rows.Count != 0)
                    {
                        exportData = StatisticsService.dtStat;
                    }
                    else
                    {
                        exportData = StatisticsService.dtStat2;
                    }

                    ExcelExport.ExportDataFromStat(exportData, saveFileDialog);
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Файл не сохранен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Console.WriteLine("Сохранение файла отменено.");
            }
            Console.WriteLine("Сохранение файла отменено.");
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ВЫХОД
        private void btnExit_Click(object sender, EventArgs e) //Кнопка "Выход"
        {
            authController.Show();
            this.Close();
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Закрытие приложения
        private void CloseButton_Click(object sender, FormClosingEventArgs e)
        {
            // Завершаем процесс приложения
            Application.Exit();
        }

        private void RootController_FormClosing(object sender, FormClosingEventArgs e)
        {
            authController.Show();
        }
    }
}
