using pharmacy.data;
using pharmacy.service;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class UserController : Form
    {
        static public DataTable dtShop = new DataTable();
        private User User;


        //Перечень препаратов в корзине
        BindingList<Medicine> med = new BindingList<Medicine>();

        public static string EditOnPrescriptionMedicines, 
            EditNameMedicines, 
            EditBestBeforeDateMedicines, 
            EditVolumeMedicines, 
            EditPrimaryPackagingMedicines, 
            EditActiveSubstanceMedicines, 
            EditSpecialPropertiesMedicines, 
            EditReleaseFormMedicines;

        public static int Editcount, EditIdMedicines, EditCostsMedicines;
        private ShopService ShopService { get; }
        private PharmacyService PharmacyService { get; }
        private BasketService BasketService { get; }
        private CategoryService CategoryService { get; }
        private AuthorizationController authController { get; }

        private string activeOrder;

        public UserController(User user, AuthorizationController authControl)
        {
            InitializeComponent();
            User = user;
            authController = authControl;
            ShopService = ShopService.Instance;
            PharmacyService = PharmacyService.Instance;
            BasketService = BasketService.Instance;
            CategoryService = CategoryService.Instance;

            ShopService.GetMedicines();
            dtShop = ShopService.dtShop;
            MedicineTable.DataSource = dtShop;
            txtBxFindLine.TextChanged += txtBxFindLine_TextChanged;
            cmbBxDeliveryAddress.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmBxExpirationDate.SelectedIndexChanged += cmBxExpirationDate_SelectedIndexChanged;
            cmBxFactory.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            cmBxReleaseForm.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShopService.GetMedicines();
            dtShop = ShopService.dtShop;
            MedicineTable.DataSource = dtShop;
            txtBxFindLine.TextChanged += txtBxFindLine_TextChanged;
            cmBxExpirationDate.SelectedIndexChanged += cmBxExpirationDate_SelectedIndexChanged;
            cmBxFactory.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            cmBxReleaseForm.SelectedIndexChanged += comboBox4_SelectedIndexChanged;

            //Подгрузка сроков годности для фильтров
            cmBxExpirationDate.Items.AddRange(ShopService.GetMedicinesExpirationDate().ToArray());

            //Подгрузка производителей для фильтров
            cmBxFactory.Items.AddRange(ShopService.GetMedicineWithFactory().ToArray());

            //Подгрузка форм выпуска для фильтра
            cmBxReleaseForm.Items.AddRange(ShopService.GetAllReleaseForm().ToArray());

            //Подгрузка категорий
            getCategories();

            //Подгрузка истории заказов
            RefreshOrderList();


            //Подгрузка аптек для совершения заказа
            cmbBxDeliveryAddress.Items.AddRange(PharmacyService.GetAllName().ToArray());
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ЛЕКАРСТВА

        private void TextBox_Click(object sender, EventArgs e) //Обновление перечня лекарств при новой категории
        {
            // Обработка события Click элемента TextBox
            System.Windows.Forms.TextBox clickedTextBox = (System.Windows.Forms.TextBox)sender;
            if (clickedTextBox.Text == "Все")
            {
                ShopService.GetMedicines();
                MedicineTable.DataSource = ShopService.dtShop;
                MedicineTable.Columns["id"].Visible = false;
                //dataGridView1.Columns["category"].Visible = false;
            }
            else
            {
                ShopService.UpdateViaCategory(clickedTextBox.Text);
                MedicineTable.DataSource = ShopService.dtShop;
            }
        }

        private void getCategories()
        {
            var categories = CategoryService.GetAllName();
            System.Windows.Forms.TextBox textBoxCategory;
            medicinesListPanel.Controls.Clear();
            medicinesListPanel.AutoScroll = true;

            var ordersInfos = BasketService.GetOrdersInfosByUserId(User.UserId);

            foreach (var item in categories)
            {
                textBoxCategory = new System.Windows.Forms.TextBox()
                {
                    Multiline = true,
                    Size = new System.Drawing.Size(126, 50), // Устанавливаем размеры текстового поля
                    ReadOnly = true
                };
                textBoxCategory.MouseEnter += (sender, e) => { ((Control)sender).Cursor = Cursors.Hand; };
                textBoxCategory.Text = item;
                textBoxCategory.Click += TextBox_Click; // Обработчик события нажатия на текстовое поле

                medicinesListPanel.Controls.Add(textBoxCategory); // Добавляем TextBox в FlowLayoutPanel
            }
        }

        private void cmBxExpirationDate_SelectedIndexChanged(object sender, EventArgs e) //Обновление списка лекарств после выбора фильтра по сроку годности
        {
            if (cmBxExpirationDate.SelectedIndex != -1)
            {
                string selectedValue = cmBxExpirationDate.SelectedItem.ToString();
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"expiration_date LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) //Обновление списка лекарств после выбора фильтра по производителю
        {
            if (cmBxFactory.SelectedIndex != -1)
            {
                string selectedValue = cmBxFactory.SelectedItem.ToString();
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"medicine_factory LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;

                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) //Обновление списка лекарств после выбора фильтра по форме выпуска
        {
            if (cmBxReleaseForm.SelectedIndex != -1)
            {
                string selectedValue = cmBxReleaseForm.SelectedItem.ToString();
                if (dtShop != null)
                {
                    DataView dv = new DataView(dtShop);
                    dv.RowFilter = $"release_form LIKE '%{selectedValue}%'";
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
                    dv.RowFilter = $"Наименование LIKE '%{selectedValue}%'";
                    MedicineTable.DataSource = dv;

                }
            }
            else
            {
                ShopService.GetMedicines();
                dtShop = ShopService.dtShop;
                MedicineTable.DataSource = dtShop;
            }
        }

        private void button5_Click(object sender, EventArgs e) //Товары в магазине - сбросить фильтры
        {
            cmBxExpirationDate.SelectedIndex = -1;
            cmBxFactory.SelectedIndex = -1;
            cmBxReleaseForm.SelectedIndex = -1;
            txtBxFindLine.Text = "";

            ShopService.GetMedicines();
            dtShop = ShopService.dtShop;
            MedicineTable.DataSource = dtShop;
        }

        private void button1_Click(object sender, EventArgs e) //Добавление товара в корзину
        {
            if (txtBxNumberOfMedicines.Text != "")
            {
                if(Int32.Parse(MedicineTable.CurrentRow.Cells[3].Value.ToString()) > 0)
                {
                    EditIdMedicines = Int32.Parse(MedicineTable.CurrentRow.Cells[0].Value.ToString());
                    EditNameMedicines = MedicineTable.CurrentRow.Cells[1].Value.ToString();
                    EditCostsMedicines = Int32.Parse(MedicineTable.CurrentRow.Cells[2].Value.ToString());
                    EditOnPrescriptionMedicines = MedicineTable.CurrentRow.Cells[5].Value.ToString();


                    Editcount = Int32.Parse(txtBxNumberOfMedicines.Text);
                    med.Add(new Medicine
                    {
                        Id = EditIdMedicines,
                        Name = EditNameMedicines,
                        Costs = EditCostsMedicines,
                        OnPrescription = EditOnPrescriptionMedicines,
                        Count = Editcount,
                    }
                    );
                    txtBxNumberOfMedicines.Text = null;
                }
                else
                {
                    MessageBox.Show("Товара нет в налии!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Пожалуйста, установите количество покупаемого товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            basketCountingValues();
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ЗАКАЗЫ

        private void TextBox_My_Orders_Click(object sender, EventArgs e) //Отображение данных по выбранному заказу
        {
            // Обработка события Click элемента TextBox
            System.Windows.Forms.TextBox clickedTextBox = (System.Windows.Forms.TextBox)sender;
            activeOrder = clickedTextBox.Text;


            int startIndex = clickedTextBox.Text.IndexOf("Номер заказа: ") + "Номер заказа: ".Length;
            int endIndex = clickedTextBox.Text.IndexOf(Environment.NewLine, startIndex);
            int id;

            if (startIndex != -1 && endIndex != -1)
            {
                id = Int32.Parse(clickedTextBox.Text.Substring(startIndex, endIndex - startIndex));
                BasketService.GetBasketMedicines(id);
            }

            ordersTable.DataSource = BasketService.dtBasket;
            //dataGridView3.Columns["id"].Visible = false;
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел КОРЗИНА

        
        public void basketCountingValues() //Заполнение основных данных по покупке в корзине
        {
            basketTable.Refresh();
            basketTable.DataSource = med;
            

            //dataGridView2.DataSource = null;

            int basket_costs = 0;
            int[] medicineId = new int[med.Count];

            for (int i = 0; i < med.Count; i++)
            {
                basket_costs += med[i].Costs * med[i].Count;
            }

            for (int i = 0; i < med.Count; i++)
            {
                medicineId[i] = med[i].Id;
            }
            txtBxOrderCost.Text = basket_costs.ToString();
            if(med.Count == 0)
            {
                txtBxDeliveryDate.Text = null;
                cmbBxDeliveryAddress.SelectedIndex = -1;
            }
            if (cmbBxDeliveryAddress.SelectedIndex !=-1 && med.Count != 0)
            {
                txtBxDeliveryDate.Text = BasketService.OrerDate(medicineId, cmbBxDeliveryAddress.SelectedItem.ToString());
            }
            txtBxOrderNumber.Text = BasketService.BasketNumber().ToString();
            txtBxCustomerName.Text = User.Name;
        }

        private void btnDeleteFromList_Click(object sender, EventArgs e) //Кнопка "удалить из списка"
        {
            if(med.Count > 0)
            {
                EditIdMedicines = Int32.Parse(basketTable.CurrentRow.Cells[0].Value.ToString());
                Medicine itemToRemove = med.FirstOrDefault(x => x.Id == EditIdMedicines);
                med.Remove(itemToRemove);
                basketCountingValues();
            }
            else
            {
                MessageBox.Show("Корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnChangeNumberOfProduct_Click(object sender, EventArgs e) //Кнопка "Изменить количество товара"
        {
            if(txtBxNumberOfProduct.Text != "")
            {
                if (txtBxNumberOfProduct.Text.All(char.IsDigit))
                {
                    if (med.Count > 0)
                    {
                        if (Int32.Parse(txtBxNumberOfProduct.Text) == 0)
                        {
                            EditIdMedicines = Int32.Parse(basketTable.CurrentRow.Cells[0].Value.ToString());
                            Medicine itemToRemove = med.FirstOrDefault(x => x.Id == EditIdMedicines);
                            med.Remove(itemToRemove);
                            txtBxNumberOfProduct.Text = "";
                            basketCountingValues();
                        }
                        else
                        {
                            EditIdMedicines = Int32.Parse(basketTable.CurrentRow.Cells[0].Value.ToString());
                            Medicine itemToUpdate = med.FirstOrDefault(x => x.Id == EditIdMedicines);
                            itemToUpdate.Count = Int32.Parse(txtBxNumberOfProduct.Text);
                            basketTable.Refresh();
                            txtBxNumberOfProduct.Text = "";
                            basketCountingValues();
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Количество должно быть указано в виде положительного целого числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, установите количество товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Подгрузка истории заказов
        public void RefreshOrderList() 
        {
            orderListPanel.Controls.Clear();
            System.Windows.Forms.TextBox textBoxOrderList;
            orderListPanel.AutoScroll = true;

            var ordersInfos = BasketService.GetOrdersInfosByUserId(User.UserId);

            foreach (var orderInfo in ordersInfos)
            {
                textBoxOrderList = new System.Windows.Forms.TextBox()
                {
                    Multiline = true,
                    Size = new System.Drawing.Size(126, 90), // Устанавливаем размеры текстового поля
                    ReadOnly = true
                };
                textBoxOrderList.MouseEnter += (sender, e) => { ((Control)sender).Cursor = Cursors.Hand; };

                textBoxOrderList.Text = orderInfo;

                textBoxOrderList.Click += TextBox_My_Orders_Click; // Обработчик события нажатия на текстовое поле

                orderListPanel.Controls.Add(textBoxOrderList); // Добавляем TextBox в FlowLayoutPanel
            }
        }


        private void btnCreateOrder_Click(object sender, EventArgs e) //Кнопка "Сделать заказ"
        {
            if(med.Count > 0)
            {
                if(cmbBxDeliveryAddress.SelectedIndex != -1 && txtBxDeliveryDate.Text != "")
                {
                    BasketService.AddBasketInDB(med, cmbBxDeliveryAddress.SelectedItem.ToString(), txtBxDeliveryDate.Text, txtBxOrderNumber.Text, User.UserId);
                    cmbBxDeliveryAddress.SelectedIndex = -1;
                    txtBxDeliveryDate.Text = "";
                    txtBxOrderCost.Text = "";
                    txtBxOrderNumber.Text = "";
                    med.Clear();
                    basketTable.Refresh();

                    RefreshOrderList();
                }
                else
                {
                    MessageBox.Show("Не выбран адрес доставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) //Перерасчет даты доставки в зависимости от выбранного пункта выдачи
        {
            int[] medicineId = new int[med.Count];
            for (int i = 0; i < med.Count; i++)
            {
                medicineId[i] = med[i].Id;
            }
            if (cmbBxDeliveryAddress.SelectedItem != null && med.Count != 0)
            {
                txtBxDeliveryDate.Text = BasketService.OrerDate(medicineId, cmbBxDeliveryAddress.SelectedItem.ToString());
            }
        }

        //Кнопка "Экспорт в Excel" у заказа
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл Excel";
            saveFileDialog.FileName = "Отчет по заказу.xlsx"; // Имя файла по умолчанию

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelExport.ExportOrderFromDataTable((DataTable)ordersTable.DataSource, activeOrder, saveFileDialog, BasketService.orderDataColumns);
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

        private void UserController_FormClosing(object sender, FormClosingEventArgs e)
        {
            authController.Show();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //Раздел ВЫХОД
        private void btnUserFormExit_Click(object sender, EventArgs e) //Кнопка выход
        {

            authController.Show();
            this.Close();
        }
    }
}
