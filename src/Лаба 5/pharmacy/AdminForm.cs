using pharmacy.data;
using pharmacy.service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pharmacy
{
    public partial class AdminController : Form
    {

        static public DataTable dtShop = new DataTable();
        private static bool changeDate = false;
        private static bool changeFactory = false;
        private static bool changeForm = false;
        private static bool changePrescription = false;

        private ShopService ShopService { get; }
        private BasketService BasketService { get; }
        private StatusService StatusService { get; }
        private StatisticsService StatisticsService { get; }
        private User User;
        private AuthorizationController authController { get;}

        private DataTable dummyData;


        public AdminController(User user, AuthorizationController authControl)
        {
            InitializeComponent();
            ShopService = ShopService.Instance;
            BasketService = BasketService.Instance;
            StatusService = StatusService.Instance;
            StatisticsService = StatisticsService.Instance;
            User = user;
            authController = authControl;
            this.dummyData = new DataTable();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            cmBxExpirationDate.SelectedIndexChanged += cmBxExpirationDate_SelectedIndexChanged;
            cmBxFactory.SelectedIndexChanged += cmBxFactory_SelectedIndexChanged;
            cmBxReleaseForm.SelectedIndexChanged += cmBxReleaseForm_SelectedIndexChanged;
            txtBxFindLine.TextChanged += txtBxFindLine_TextChanged;


            //Подгрузка срока годности для фильтра в разделе "Лекарства в аптеке"
            ShopService.GetMedicinesExpirationDate().ForEach(item => cmBxExpirationDate.Items.Add(item));

            //Подгрузка производителей для фильтра в разделе "Лекарства в аптеке"
            ShopService.GetMedicineWithFactory().ForEach(item => cmBxFactory.Items.Add(item));

            //Подгрузка формы выпуска для фильтра в разделе "Лекарства в аптеке"
            ShopService.GetAllReleaseForm().ForEach(item => cmBxReleaseForm.Items.Add(item));
            
            //Магазин
            ShopService.GetMedicinesInAdmin(User.PharmacyId);
            dtShop = ShopService.dtShop;
            MedicineTable.DataSource = dtShop;

            //Заказы

            refreshOrderList();

            //Статистика
            Series series = new Series("DataPoints");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            DataTable dummyData = StatisticsService.AdminGetCountBuyMedicinesStat(User.PharmacyId);

            StatChart.Series.Clear();

            foreach (DataRow row in dummyData.Rows)
            {
                DateTime date = (DateTime)row["Дата"];
                int quantity = (int)row["Значение"];
                DateTime monthYearDate = new DateTime(date.Year, date.Month, 1);

                series.Points.AddXY(monthYearDate.ToString("MM.yyyy"), quantity);
            }

            StatChart.Series.Add(series);

            StatusService.GetAllName().ForEach(item => cmBxStatusList.Items.Add(item)); //перенесено из метода TextBox_Admin_Orders_Click
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ЛЕКАРСТВА В АПТЕКЕ
        private void cmBxExpirationDate_SelectedIndexChanged(object sender, EventArgs e) //Обновление списка лекарств после выбора фильтра по сроку годности
        {
            if (cmBxExpirationDate.SelectedIndex != -1)
            {
                string selectedValue = cmBxExpirationDate.SelectedItem.ToString();
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"[{MedicineTable.Columns[6].HeaderText}] LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;
                }

            }
        }

        private void cmBxFactory_SelectedIndexChanged(object sender, EventArgs e) //Обновление списка лекарств после выбора фильтра по производителю
        {
            if (cmBxFactory.SelectedIndex != -1)
            {
                string selectedValue = cmBxFactory.SelectedItem.ToString();
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"[{MedicineTable.Columns[12].HeaderText}] LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;

                }
            }
        }

        private void cmBxReleaseForm_SelectedIndexChanged(object sender, EventArgs e) //Обновление списка лекарств после выбора фильтра по форме выпуска
        {
            if (cmBxReleaseForm.SelectedIndex != -1)
            {
                string selectedValue = cmBxReleaseForm.SelectedItem.ToString();
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"[{MedicineTable.Columns[11].HeaderText}] LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;

                }
            }
        }

        private void txtBxFindLine_TextChanged(object sender, EventArgs e) //Обновление списка лекарств после ввода текста с клавиатуры
        {
            if (txtBxFindLine.Text != "")
            {
                string selectedValue = txtBxFindLine.Text;
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"[{MedicineTable.Columns[2].HeaderText}] LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;

                }
            }
            else
            {
                ShopService.GetMedicinesInAdmin(User.PharmacyId);
                dtShop = ShopService.dtShop;
                MedicineTable.DataSource = dtShop;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e) //Товары в магазине - сбросить фильтры
        {
            cmBxExpirationDate.SelectedIndex = -1;
            cmBxFactory.SelectedIndex = -1;
            cmBxReleaseForm.SelectedIndex = -1;
            txtBxFindLine.Text = "";

            changeDate = false;
            changeFactory = false;
            changeForm = false;
            changePrescription = false;

            ShopService.GetMedicinesInAdmin(User.PharmacyId);
            dtShop = ShopService.dtShop;
            MedicineTable.DataSource = dtShop;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ЗАКАЗЫ
        private void TextBox_Admin_Orders_Click(object sender, EventArgs e) //Выбор заказа в разделе Заказы и подгрузка содержимого заказа
        {
            // Обработка события Click элемента TextBox
            System.Windows.Forms.TextBox clickedTextBox = (System.Windows.Forms.TextBox)sender;

            int startIndex = clickedTextBox.Text.IndexOf("Номер заказа: ") + "Номер заказа: ".Length;
            int endIndex = clickedTextBox.Text.IndexOf(Environment.NewLine, startIndex);
            int id;

            if (startIndex != -1 && endIndex != -1)
            {
                id = Int32.Parse(clickedTextBox.Text.Substring(startIndex, endIndex - startIndex));
                BasketService.GetBasketMedicines(id);
            }

            startIndex = clickedTextBox.Text.IndexOf("Имя заказчика: ") + "Имя заказчика: ".Length;
            endIndex = clickedTextBox.Text.IndexOf(Environment.NewLine, startIndex);
            txtBxCustomer.Text = clickedTextBox.Text.Substring(startIndex, endIndex - startIndex);

            

            startIndex = clickedTextBox.Text.IndexOf("Номер заказа: ") + "Номер заказа: ".Length;
            endIndex = clickedTextBox.Text.IndexOf(Environment.NewLine, startIndex);
            txtBxOrderNumberId.Text = clickedTextBox.Text.Substring(startIndex, endIndex - startIndex);

            startIndex = clickedTextBox.Text.IndexOf("Дата доставки: ") + "Дата доставки: ".Length;
            endIndex = clickedTextBox.Text.IndexOf(Environment.NewLine, startIndex);
            txtBxDeliveryDate.Text = clickedTextBox.Text.Substring(startIndex, endIndex - startIndex);

            startIndex = clickedTextBox.Text.IndexOf("Статус заказа: ") + "Статус заказа: ".Length;
            endIndex = clickedTextBox.Text.IndexOf(Environment.NewLine, startIndex);
            txtBxOrderStatus.Text = clickedTextBox.Text.Substring(startIndex, endIndex - startIndex);

            OrderTable.DataSource = BasketService.dtBasket;
            OrderTable.Columns["id"].Visible = false;

            txtBxOrderCost.Text = OrderTable.Rows
            .Cast<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells["Стоимость:"].Value)).ToString();
        }

        private void btnSaveStatus_Click(object sender, EventArgs e) //Кнопка "Сохранить новый статус" в разделе "Заказы"
        {
            if (txtBxOrderNumberId.Text != "")
            {
                if (cmBxStatusList.SelectedIndex != -1)
                {
                    BasketService.UpdateStatusByNameAndBasketNumber(txtBxOrderNumberId.Text, cmBxStatusList.SelectedItem.ToString());
                    txtBxOrderStatus.Text = cmBxStatusList.SelectedItem.ToString();
                    refreshOrderList();
                }
                else
                {
                    MessageBox.Show("Не выбран статус заказа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Не выбран заказ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Обновление перечня заказов
        private void refreshOrderList()
        {
            orderListPanel.Controls.Clear();
            orderListPanel.AutoScroll = true;
            System.Windows.Forms.TextBox textBox;
            List<string> ordersInfos = BasketService.GetOrdersInfosByPharmacyId(User.PharmacyId);
            foreach (var item in ordersInfos)
            {
                textBox = new System.Windows.Forms.TextBox()
                {
                    Multiline = true,
                    Size = new System.Drawing.Size(126, 120), // Устанавливаем размеры текстового поля
                    ReadOnly = true
                };
                textBox.MouseEnter += (sender, e) => { ((Control)sender).Cursor = Cursors.Hand; };
                textBox.Text = item;

                textBox.Click += TextBox_Admin_Orders_Click; // Обработчик события нажатия на текстовое поле

                orderListPanel.Controls.Add(textBox); // Добавляем TextBox в FlowLayoutPanel
            }
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел СТАТИСТИКА
        private void btnStatCountBuyMedInPharm_Click(object sender, EventArgs e) //Статистика - Количество купленного товара в магазине
        {
            dummyData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            StatChart.Series.Clear();
            StatChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            StatChart.ChartAreas.Add(chartArea);

            StatChart.Visible = true;
            StatTable.Visible = false;


            Series series = new Series("DataPoints");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            dummyData = StatisticsService.AdminGetCountBuyMedicinesStat(User.PharmacyId);

            StatChart.Series.Clear();

            foreach (DataRow row in dummyData.Rows)
            {
                DateTime date = (DateTime)row["Дата"];
                int quantity = (int)row["Значение"];
                DateTime monthYearDate = new DateTime(date.Year, date.Month, 1);

                series.Points.AddXY(monthYearDate.ToString("MM.yyyy"), quantity);
            }

            StatChart.Series.Add(series);
        }

        private void btnStatCountPurchasesInPharmacy_Click(object sender, EventArgs e) //Статистика - Количество покупок в магазине
        {
            dummyData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            StatChart.Series.Clear();
            StatChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            StatChart.ChartAreas.Add(chartArea);

            StatChart.Visible = true;
            StatTable.Visible = false;

            Series series = new Series("DataPoints");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            dummyData = StatisticsService.AdminGetCountBasketStat(User.PharmacyId);

            StatChart.Series.Clear();

            foreach (DataRow row in dummyData.Rows)
            {
                DateTime date = (DateTime)row["Дата"];
                int quantity = (int)row["Значение"];
                DateTime monthYearDate = new DateTime(date.Year, date.Month, 1);

                series.Points.AddXY(monthYearDate.ToString("MM.yyyy"), quantity);
            }

            StatChart.Series.Add(series);
        }

        private void btnStatTopCustomer_Click(object sender, EventArgs e) //Рейтинг покупателей
        {
            dummyData.Clear();
            StatisticsService.dtStat.Clear();
            StatisticsService.dtStat2.Clear();

            StatChart.Visible = false;
            StatTable.Visible = true;
            StatisticsService.getTopUsersInPharmacy(User.PharmacyId);
            StatTable.DataSource = StatisticsService.dtStat;

        }

        //Экспорт лекарств
        private void btnExportMed_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл Excel";
            saveFileDialog.FileName = "Отчет по товарам.xlsx"; // Имя файла по умолчанию

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelExport.ExportDataFromDataTable((DataTable)MedicineTable.DataSource, saveFileDialog, ShopService.dataColumns);
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Console.WriteLine("Сохранение файла отменено.");
            }
            Console.WriteLine("Сохранение файла отменено.");
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //ВЫХОД
        private void btnExit_Click(object sender, EventArgs e) //Кнопка ВЫХОД
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

        private void AdminController_FormClosing(object sender, FormClosingEventArgs e)
        {
            authController.Show();
        }

        //Экспорт статистики
        private void btnExportStat_Click(object sender, EventArgs e)
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
                    if (dummyData.Rows.Count != 0)
                    {
                        exportData = dummyData;
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
    }
}
