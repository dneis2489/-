namespace pharmacy
{
    partial class AdminController
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MedicineTable = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Объём = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release_form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_factory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBxStatusList = new System.Windows.Forms.ComboBox();
            this.btnSaveStatus = new System.Windows.Forms.Button();
            this.txtBxCustomer = new System.Windows.Forms.TextBox();
            this.txtBxOrderCost = new System.Windows.Forms.TextBox();
            this.txtBxOrderNumberId = new System.Windows.Forms.TextBox();
            this.txtBxDeliveryDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxOrderStatus = new System.Windows.Forms.TextBox();
            this.StatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatCountBuyMedInPharm = new System.Windows.Forms.Button();
            this.btnStatCountPurchasesInPharmacy = new System.Windows.Forms.Button();
            this.btnStatTopCustomer = new System.Windows.Forms.Button();
            this.StatTable = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cmBxExpirationDate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxFindLine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmBxFactory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmBxReleaseForm = new System.Windows.Forms.ComboBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pharmacy = new System.Windows.Forms.TabPage();
            this.btnExportMed = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.TabPage();
            this.orderListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statistic = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportStat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pharmacy.SuspendLayout();
            this.orders.SuspendLayout();
            this.statistic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedicineTable
            // 
            this.MedicineTable.AllowUserToAddRows = false;
            this.MedicineTable.AllowUserToDeleteRows = false;
            this.MedicineTable.AllowUserToResizeRows = false;
            this.MedicineTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Наименование,
            this.Стоимость,
            this.Количество,
            this.Объём,
            this.Column5,
            this.prescription,
            this.expiration_date,
            this.Column1,
            this.Column2,
            this.Column3,
            this.release_form,
            this.medicine_factory});
            this.MedicineTable.Location = new System.Drawing.Point(9, 55);
            this.MedicineTable.Name = "MedicineTable";
            this.MedicineTable.ReadOnly = true;
            this.MedicineTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineTable.Size = new System.Drawing.Size(1174, 435);
            this.MedicineTable.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id";
            this.Column4.HeaderText = "id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Наименование
            // 
            this.Наименование.DataPropertyName = "Наименование:";
            this.Наименование.HeaderText = "Наименование:";
            this.Наименование.Name = "Наименование";
            this.Наименование.ReadOnly = true;
            // 
            // Стоимость
            // 
            this.Стоимость.DataPropertyName = "Стоимость:";
            this.Стоимость.HeaderText = "Стоимость:";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            // 
            // Количество
            // 
            this.Количество.DataPropertyName = "Количество:";
            this.Количество.HeaderText = "Количество:";
            this.Количество.Name = "Количество";
            this.Количество.ReadOnly = true;
            // 
            // Объём
            // 
            this.Объём.DataPropertyName = "Объём:";
            this.Объём.HeaderText = "Объём:";
            this.Объём.Name = "Объём";
            this.Объём.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Магазин:";
            this.Column5.HeaderText = "Магазин";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // prescription
            // 
            this.prescription.DataPropertyName = "Рецепт:";
            this.prescription.HeaderText = "Рецепт:";
            this.prescription.Name = "prescription";
            this.prescription.ReadOnly = true;
            // 
            // expiration_date
            // 
            this.expiration_date.DataPropertyName = "Срок годности:";
            this.expiration_date.HeaderText = "Срок годности:";
            this.expiration_date.Name = "expiration_date";
            this.expiration_date.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Первичная упаковка:";
            this.Column1.HeaderText = "Первичная упаковка";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Активное вещество:";
            this.Column2.HeaderText = "Активное вещество";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Специальные свойства:";
            this.Column3.HeaderText = "Специальные свойства";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // release_form
            // 
            this.release_form.DataPropertyName = "Форма выпуска:";
            this.release_form.HeaderText = "Форма выпуска:";
            this.release_form.Name = "release_form";
            this.release_form.ReadOnly = true;
            // 
            // medicine_factory
            // 
            this.medicine_factory.DataPropertyName = "Производитель:";
            this.medicine_factory.HeaderText = "Производитель:";
            this.medicine_factory.Name = "medicine_factory";
            this.medicine_factory.ReadOnly = true;
            // 
            // OrderTable
            // 
            this.OrderTable.AllowUserToAddRows = false;
            this.OrderTable.AllowUserToDeleteRows = false;
            this.OrderTable.AllowUserToResizeRows = false;
            this.OrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Location = new System.Drawing.Point(140, 9);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.ReadOnly = true;
            this.OrderTable.Size = new System.Drawing.Size(741, 501);
            this.OrderTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Изменить статус заказа:";
            // 
            // cmBxStatusList
            // 
            this.cmBxStatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxStatusList.FormattingEnabled = true;
            this.cmBxStatusList.Location = new System.Drawing.Point(883, 329);
            this.cmBxStatusList.Name = "cmBxStatusList";
            this.cmBxStatusList.Size = new System.Drawing.Size(209, 21);
            this.cmBxStatusList.TabIndex = 31;
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.Location = new System.Drawing.Point(1098, 329);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(93, 23);
            this.btnSaveStatus.TabIndex = 32;
            this.btnSaveStatus.Text = "Сохранить";
            this.btnSaveStatus.UseVisualStyleBackColor = true;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);
            // 
            // txtBxCustomer
            // 
            this.txtBxCustomer.Location = new System.Drawing.Point(887, 93);
            this.txtBxCustomer.Name = "txtBxCustomer";
            this.txtBxCustomer.ReadOnly = true;
            this.txtBxCustomer.Size = new System.Drawing.Size(304, 20);
            this.txtBxCustomer.TabIndex = 33;
            // 
            // txtBxOrderCost
            // 
            this.txtBxOrderCost.Location = new System.Drawing.Point(887, 138);
            this.txtBxOrderCost.Name = "txtBxOrderCost";
            this.txtBxOrderCost.ReadOnly = true;
            this.txtBxOrderCost.Size = new System.Drawing.Size(304, 20);
            this.txtBxOrderCost.TabIndex = 34;
            // 
            // txtBxOrderNumberId
            // 
            this.txtBxOrderNumberId.Location = new System.Drawing.Point(887, 182);
            this.txtBxOrderNumberId.Name = "txtBxOrderNumberId";
            this.txtBxOrderNumberId.ReadOnly = true;
            this.txtBxOrderNumberId.Size = new System.Drawing.Size(304, 20);
            this.txtBxOrderNumberId.TabIndex = 35;
            // 
            // txtBxDeliveryDate
            // 
            this.txtBxDeliveryDate.Location = new System.Drawing.Point(887, 226);
            this.txtBxDeliveryDate.Name = "txtBxDeliveryDate";
            this.txtBxDeliveryDate.ReadOnly = true;
            this.txtBxDeliveryDate.Size = new System.Drawing.Size(304, 20);
            this.txtBxDeliveryDate.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(884, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Заказчик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Стоимость заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(884, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Номер заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(884, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Дата доставки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(884, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Статус заказа";
            // 
            // txtBxOrderStatus
            // 
            this.txtBxOrderStatus.Location = new System.Drawing.Point(887, 274);
            this.txtBxOrderStatus.Name = "txtBxOrderStatus";
            this.txtBxOrderStatus.ReadOnly = true;
            this.txtBxOrderStatus.Size = new System.Drawing.Size(304, 20);
            this.txtBxOrderStatus.TabIndex = 42;
            // 
            // StatChart
            // 
            chartArea1.Name = "ChartArea1";
            this.StatChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StatChart.Legends.Add(legend1);
            this.StatChart.Location = new System.Drawing.Point(191, 4);
            this.StatChart.Name = "StatChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StatChart.Series.Add(series1);
            this.StatChart.Size = new System.Drawing.Size(1003, 486);
            this.StatChart.TabIndex = 44;
            this.StatChart.Text = "chart1";
            // 
            // btnStatCountBuyMedInPharm
            // 
            this.btnStatCountBuyMedInPharm.Location = new System.Drawing.Point(6, 40);
            this.btnStatCountBuyMedInPharm.Name = "btnStatCountBuyMedInPharm";
            this.btnStatCountBuyMedInPharm.Size = new System.Drawing.Size(170, 40);
            this.btnStatCountBuyMedInPharm.TabIndex = 45;
            this.btnStatCountBuyMedInPharm.Text = "Количество купленного товара в аптеке";
            this.btnStatCountBuyMedInPharm.UseVisualStyleBackColor = true;
            this.btnStatCountBuyMedInPharm.Click += new System.EventHandler(this.btnStatCountBuyMedInPharm_Click);
            // 
            // btnStatCountPurchasesInPharmacy
            // 
            this.btnStatCountPurchasesInPharmacy.Location = new System.Drawing.Point(6, 148);
            this.btnStatCountPurchasesInPharmacy.Name = "btnStatCountPurchasesInPharmacy";
            this.btnStatCountPurchasesInPharmacy.Size = new System.Drawing.Size(170, 36);
            this.btnStatCountPurchasesInPharmacy.TabIndex = 46;
            this.btnStatCountPurchasesInPharmacy.Text = "Количество покупок в аптеке";
            this.btnStatCountPurchasesInPharmacy.UseVisualStyleBackColor = true;
            this.btnStatCountPurchasesInPharmacy.Click += new System.EventHandler(this.btnStatCountPurchasesInPharmacy_Click);
            // 
            // btnStatTopCustomer
            // 
            this.btnStatTopCustomer.Location = new System.Drawing.Point(6, 95);
            this.btnStatTopCustomer.Name = "btnStatTopCustomer";
            this.btnStatTopCustomer.Size = new System.Drawing.Size(170, 36);
            this.btnStatTopCustomer.TabIndex = 47;
            this.btnStatTopCustomer.Text = "Рейтинг покупателей";
            this.btnStatTopCustomer.UseVisualStyleBackColor = true;
            this.btnStatTopCustomer.Click += new System.EventHandler(this.btnStatTopCustomer_Click);
            // 
            // StatTable
            // 
            this.StatTable.AllowUserToAddRows = false;
            this.StatTable.AllowUserToDeleteRows = false;
            this.StatTable.AllowUserToResizeColumns = false;
            this.StatTable.AllowUserToResizeRows = false;
            this.StatTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatTable.Location = new System.Drawing.Point(191, 4);
            this.StatTable.Name = "StatTable";
            this.StatTable.ReadOnly = true;
            this.StatTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.StatTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StatTable.Size = new System.Drawing.Size(1003, 487);
            this.StatTable.TabIndex = 48;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cmBxExpirationDate
            // 
            this.cmBxExpirationDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxExpirationDate.FormattingEnabled = true;
            this.cmBxExpirationDate.Location = new System.Drawing.Point(251, 20);
            this.cmBxExpirationDate.Name = "cmBxExpirationDate";
            this.cmBxExpirationDate.Size = new System.Drawing.Size(187, 21);
            this.cmBxExpirationDate.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Поиск:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Срок годности:";
            // 
            // txtBxFindLine
            // 
            this.txtBxFindLine.Location = new System.Drawing.Point(9, 21);
            this.txtBxFindLine.Name = "txtBxFindLine";
            this.txtBxFindLine.Size = new System.Drawing.Size(224, 20);
            this.txtBxFindLine.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Производитель:";
            // 
            // cmBxFactory
            // 
            this.cmBxFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxFactory.FormattingEnabled = true;
            this.cmBxFactory.Location = new System.Drawing.Point(459, 20);
            this.cmBxFactory.Name = "cmBxFactory";
            this.cmBxFactory.Size = new System.Drawing.Size(182, 21);
            this.cmBxFactory.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Форма выпуска:";
            // 
            // cmBxReleaseForm
            // 
            this.cmBxReleaseForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxReleaseForm.FormattingEnabled = true;
            this.cmBxReleaseForm.Location = new System.Drawing.Point(656, 20);
            this.cmBxReleaseForm.Name = "cmBxReleaseForm";
            this.cmBxReleaseForm.Size = new System.Drawing.Size(178, 21);
            this.cmBxReleaseForm.TabIndex = 55;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(1028, 26);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(155, 23);
            this.btnClearFilter.TabIndex = 59;
            this.btnClearFilter.Text = "Сбросить фильтры";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pharmacy);
            this.tabControl1.Controls.Add(this.orders);
            this.tabControl1.Controls.Add(this.statistic);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 548);
            this.tabControl1.TabIndex = 60;
            // 
            // pharmacy
            // 
            this.pharmacy.Controls.Add(this.btnExportMed);
            this.pharmacy.Controls.Add(this.label8);
            this.pharmacy.Controls.Add(this.txtBxFindLine);
            this.pharmacy.Controls.Add(this.btnClearFilter);
            this.pharmacy.Controls.Add(this.label9);
            this.pharmacy.Controls.Add(this.label11);
            this.pharmacy.Controls.Add(this.cmBxReleaseForm);
            this.pharmacy.Controls.Add(this.cmBxExpirationDate);
            this.pharmacy.Controls.Add(this.label10);
            this.pharmacy.Controls.Add(this.cmBxFactory);
            this.pharmacy.Controls.Add(this.MedicineTable);
            this.pharmacy.Location = new System.Drawing.Point(4, 22);
            this.pharmacy.Name = "pharmacy";
            this.pharmacy.Padding = new System.Windows.Forms.Padding(3);
            this.pharmacy.Size = new System.Drawing.Size(1197, 522);
            this.pharmacy.TabIndex = 0;
            this.pharmacy.Text = "Лекарства в аптеке";
            this.pharmacy.UseVisualStyleBackColor = true;
            // 
            // btnExportMed
            // 
            this.btnExportMed.Location = new System.Drawing.Point(1037, 496);
            this.btnExportMed.Name = "btnExportMed";
            this.btnExportMed.Size = new System.Drawing.Size(146, 23);
            this.btnExportMed.TabIndex = 60;
            this.btnExportMed.Text = "Выгрузить в Excel";
            this.btnExportMed.UseVisualStyleBackColor = true;
            this.btnExportMed.Click += new System.EventHandler(this.btnExportMed_Click);
            // 
            // orders
            // 
            this.orders.Controls.Add(this.orderListPanel);
            this.orders.Controls.Add(this.btnSaveStatus);
            this.orders.Controls.Add(this.OrderTable);
            this.orders.Controls.Add(this.label2);
            this.orders.Controls.Add(this.cmBxStatusList);
            this.orders.Controls.Add(this.label3);
            this.orders.Controls.Add(this.txtBxCustomer);
            this.orders.Controls.Add(this.txtBxOrderStatus);
            this.orders.Controls.Add(this.txtBxOrderCost);
            this.orders.Controls.Add(this.label7);
            this.orders.Controls.Add(this.txtBxOrderNumberId);
            this.orders.Controls.Add(this.label6);
            this.orders.Controls.Add(this.txtBxDeliveryDate);
            this.orders.Controls.Add(this.label5);
            this.orders.Controls.Add(this.label4);
            this.orders.Location = new System.Drawing.Point(4, 22);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(3);
            this.orders.Size = new System.Drawing.Size(1197, 522);
            this.orders.TabIndex = 1;
            this.orders.Text = "Заказы";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // orderListPanel
            // 
            this.orderListPanel.Location = new System.Drawing.Point(6, 9);
            this.orderListPanel.Name = "orderListPanel";
            this.orderListPanel.Size = new System.Drawing.Size(128, 501);
            this.orderListPanel.TabIndex = 43;
            // 
            // statistic
            // 
            this.statistic.Controls.Add(this.groupBox1);
            this.statistic.Controls.Add(this.btnExportStat);
            this.statistic.Controls.Add(this.StatTable);
            this.statistic.Controls.Add(this.StatChart);
            this.statistic.Location = new System.Drawing.Point(4, 22);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(1197, 522);
            this.statistic.TabIndex = 2;
            this.statistic.Text = "Статистика";
            this.statistic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStatTopCustomer);
            this.groupBox1.Controls.Add(this.btnStatCountPurchasesInPharmacy);
            this.groupBox1.Controls.Add(this.btnStatCountBuyMedInPharm);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 486);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите статистику";
            // 
            // btnExportStat
            // 
            this.btnExportStat.Location = new System.Drawing.Point(1048, 496);
            this.btnExportStat.Name = "btnExportStat";
            this.btnExportStat.Size = new System.Drawing.Size(146, 23);
            this.btnExportStat.TabIndex = 61;
            this.btnExportStat.Text = "Выгрузить в Excel";
            this.btnExportStat.UseVisualStyleBackColor = true;
            this.btnExportStat.Click += new System.EventHandler(this.btnExportStat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1044, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 23);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 569);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminController";
            this.Text = "Модуль корпоративной информационной системы сети аптек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminController_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pharmacy.ResumeLayout(false);
            this.pharmacy.PerformLayout();
            this.orders.ResumeLayout(false);
            this.orders.PerformLayout();
            this.statistic.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MedicineTable;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBxStatusList;
        private System.Windows.Forms.Button btnSaveStatus;
        private System.Windows.Forms.TextBox txtBxCustomer;
        private System.Windows.Forms.TextBox txtBxOrderCost;
        private System.Windows.Forms.TextBox txtBxOrderNumberId;
        private System.Windows.Forms.TextBox txtBxDeliveryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxOrderStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatChart;
        private System.Windows.Forms.Button btnStatCountBuyMedInPharm;
        private System.Windows.Forms.Button btnStatCountPurchasesInPharmacy;
        private System.Windows.Forms.Button btnStatTopCustomer;
        private System.Windows.Forms.DataGridView StatTable;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cmBxExpirationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxFindLine;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmBxFactory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmBxReleaseForm;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pharmacy;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.TabPage statistic;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportMed;
        private System.Windows.Forms.Button btnExportStat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel orderListPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Объём;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_form;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_factory;
    }
}