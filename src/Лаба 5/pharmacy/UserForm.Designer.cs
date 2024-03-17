namespace pharmacy
{
    partial class UserController
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
            this.components = new System.ComponentModel.Container();
            this.MedicineTable = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release_form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_factory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxNumberOfMedicines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.basketTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.on_prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryPackaging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveSubstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtBxOrderCost = new System.Windows.Forms.TextBox();
            this.txtBxOrderNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteFromList = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxCustomerName = new System.Windows.Forms.TextBox();
            this.cmbBxDeliveryAddress = new System.Windows.Forms.ComboBox();
            this.btnChangeNumberOfProduct = new System.Windows.Forms.Button();
            this.txtBxNumberOfProduct = new System.Windows.Forms.TextBox();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Объём = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmBxReleaseForm = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmBxFactory = new System.Windows.Forms.ComboBox();
            this.txtBxFindLine = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmBxExpirationDate = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pharm = new System.Windows.Forms.TabPage();
            this.medicinesListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ordres = new System.Windows.Forms.TabPage();
            this.orderListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.basket = new System.Windows.Forms.TabPage();
            this.btnUserFormExit = new System.Windows.Forms.Button();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineTable)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pharm.SuspendLayout();
            this.ordres.SuspendLayout();
            this.basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineTable
            // 
            this.MedicineTable.AllowUserToAddRows = false;
            this.MedicineTable.AllowUserToDeleteRows = false;
            this.MedicineTable.AllowUserToResizeColumns = false;
            this.MedicineTable.AllowUserToResizeRows = false;
            this.MedicineTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.prescription,
            this.expiration_date,
            this.Column5,
            this.Column6,
            this.Column7,
            this.release_form,
            this.medicine_factory});
            this.MedicineTable.Location = new System.Drawing.Point(144, 54);
            this.MedicineTable.Name = "MedicineTable";
            this.MedicineTable.ReadOnly = true;
            this.MedicineTable.RowHeadersWidth = 20;
            this.MedicineTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineTable.Size = new System.Drawing.Size(1036, 416);
            this.MedicineTable.TabIndex = 1;
            // 
            // Номер
            // 
            this.Номер.DataPropertyName = "id";
            this.Номер.HeaderText = "id";
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            this.Номер.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Наименование";
            this.Column8.HeaderText = "Наименование";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Стоимость";
            this.Column1.HeaderText = "Стоимость";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Количество";
            this.Column2.HeaderText = "Количество";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Объём";
            this.Column4.HeaderText = "Объём";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Магазин";
            this.Column3.HeaderText = "Магазин";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // prescription
            // 
            this.prescription.DataPropertyName = "prescription";
            this.prescription.HeaderText = "Рецепт";
            this.prescription.Name = "prescription";
            this.prescription.ReadOnly = true;
            // 
            // expiration_date
            // 
            this.expiration_date.DataPropertyName = "expiration_date";
            this.expiration_date.HeaderText = "Срок годности";
            this.expiration_date.Name = "expiration_date";
            this.expiration_date.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Первичная упаковка";
            this.Column5.HeaderText = "Первичная упаковка";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Активное вещество";
            this.Column6.HeaderText = "Активное вещество";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Специальные свойства";
            this.Column7.HeaderText = "Специальные свойства";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // release_form
            // 
            this.release_form.DataPropertyName = "release_form";
            this.release_form.HeaderText = "Форма выпуска";
            this.release_form.Name = "release_form";
            this.release_form.ReadOnly = true;
            // 
            // medicine_factory
            // 
            this.medicine_factory.DataPropertyName = "medicine_factory";
            this.medicine_factory.HeaderText = "Производитель";
            this.medicine_factory.Name = "medicine_factory";
            this.medicine_factory.ReadOnly = true;
            // 
            // txtBxNumberOfMedicines
            // 
            this.txtBxNumberOfMedicines.Location = new System.Drawing.Point(885, 488);
            this.txtBxNumberOfMedicines.Name = "txtBxNumberOfMedicines";
            this.txtBxNumberOfMedicines.Size = new System.Drawing.Size(166, 20);
            this.txtBxNumberOfMedicines.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество:";
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(1057, 486);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(123, 23);
            this.btnAddToBasket.TabIndex = 4;
            this.btnAddToBasket.Text = "Добавить в корзину";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(94, 26);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.всеToolStripMenuItem.Text = "Все";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // basketTable
            // 
            this.basketTable.AllowUserToAddRows = false;
            this.basketTable.AllowUserToDeleteRows = false;
            this.basketTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basketTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.on_prescription,
            this.costs,
            this.count,
            this.ExpirationDate,
            this.Volume,
            this.PrimaryPackaging,
            this.ActiveSubstance,
            this.SpecialProperties,
            this.ReleaseForm});
            this.basketTable.Location = new System.Drawing.Point(14, 16);
            this.basketTable.Name = "basketTable";
            this.basketTable.ReadOnly = true;
            this.basketTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketTable.Size = new System.Drawing.Size(763, 432);
            this.basketTable.TabIndex = 10;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Наименование:";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // on_prescription
            // 
            this.on_prescription.DataPropertyName = "OnPrescription";
            this.on_prescription.HeaderText = "Рецепт";
            this.on_prescription.Name = "on_prescription";
            this.on_prescription.ReadOnly = true;
            // 
            // costs
            // 
            this.costs.DataPropertyName = "Costs";
            this.costs.HeaderText = "Стоимость:";
            this.costs.Name = "costs";
            this.costs.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "Count";
            this.count.HeaderText = "Количество:";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "ExpirationDate";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            this.ExpirationDate.Visible = false;
            // 
            // Volume
            // 
            this.Volume.DataPropertyName = "Volume";
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Visible = false;
            // 
            // PrimaryPackaging
            // 
            this.PrimaryPackaging.DataPropertyName = "PrimaryPackaging";
            this.PrimaryPackaging.HeaderText = "PrimaryPackaging";
            this.PrimaryPackaging.Name = "PrimaryPackaging";
            this.PrimaryPackaging.ReadOnly = true;
            this.PrimaryPackaging.Visible = false;
            // 
            // ActiveSubstance
            // 
            this.ActiveSubstance.DataPropertyName = "ActiveSubstance";
            this.ActiveSubstance.HeaderText = "ActiveSubstance";
            this.ActiveSubstance.Name = "ActiveSubstance";
            this.ActiveSubstance.ReadOnly = true;
            this.ActiveSubstance.Visible = false;
            // 
            // SpecialProperties
            // 
            this.SpecialProperties.DataPropertyName = "SpecialProperties";
            this.SpecialProperties.HeaderText = "SpecialProperties";
            this.SpecialProperties.Name = "SpecialProperties";
            this.SpecialProperties.ReadOnly = true;
            this.SpecialProperties.Visible = false;
            // 
            // ReleaseForm
            // 
            this.ReleaseForm.DataPropertyName = "ReleaseForm";
            this.ReleaseForm.HeaderText = "ReleaseForm";
            this.ReleaseForm.Name = "ReleaseForm";
            this.ReleaseForm.ReadOnly = true;
            this.ReleaseForm.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата доставки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Стоимость доставки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Адрес доставки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Номер заказа";
            // 
            // txtBxDeliveryDate
            // 
            this.txtBxDeliveryDate.Location = new System.Drawing.Point(828, 200);
            this.txtBxDeliveryDate.Name = "txtBxDeliveryDate";
            this.txtBxDeliveryDate.ReadOnly = true;
            this.txtBxDeliveryDate.Size = new System.Drawing.Size(292, 20);
            this.txtBxDeliveryDate.TabIndex = 15;
            // 
            // txtBxOrderCost
            // 
            this.txtBxOrderCost.Location = new System.Drawing.Point(828, 161);
            this.txtBxOrderCost.Name = "txtBxOrderCost";
            this.txtBxOrderCost.ReadOnly = true;
            this.txtBxOrderCost.Size = new System.Drawing.Size(292, 20);
            this.txtBxOrderCost.TabIndex = 16;
            // 
            // txtBxOrderNumber
            // 
            this.txtBxOrderNumber.Location = new System.Drawing.Point(828, 239);
            this.txtBxOrderNumber.Name = "txtBxOrderNumber";
            this.txtBxOrderNumber.ReadOnly = true;
            this.txtBxOrderNumber.Size = new System.Drawing.Size(292, 20);
            this.txtBxOrderNumber.TabIndex = 18;
            // 
            // btnDeleteFromList
            // 
            this.btnDeleteFromList.Location = new System.Drawing.Point(829, 339);
            this.btnDeleteFromList.Name = "btnDeleteFromList";
            this.btnDeleteFromList.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteFromList.TabIndex = 19;
            this.btnDeleteFromList.Text = "Удалить из списка";
            this.btnDeleteFromList.UseVisualStyleBackColor = true;
            this.btnDeleteFromList.Click += new System.EventHandler(this.btnDeleteFromList_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(1002, 339);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(118, 23);
            this.btnCreateOrder.TabIndex = 20;
            this.btnCreateOrder.Text = "Сделать заказ";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(827, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Имя заказчика";
            // 
            // txtBxCustomerName
            // 
            this.txtBxCustomerName.Location = new System.Drawing.Point(828, 278);
            this.txtBxCustomerName.Name = "txtBxCustomerName";
            this.txtBxCustomerName.ReadOnly = true;
            this.txtBxCustomerName.Size = new System.Drawing.Size(292, 20);
            this.txtBxCustomerName.TabIndex = 22;
            // 
            // cmbBxDeliveryAddress
            // 
            this.cmbBxDeliveryAddress.FormattingEnabled = true;
            this.cmbBxDeliveryAddress.Location = new System.Drawing.Point(829, 121);
            this.cmbBxDeliveryAddress.Name = "cmbBxDeliveryAddress";
            this.cmbBxDeliveryAddress.Size = new System.Drawing.Size(291, 21);
            this.cmbBxDeliveryAddress.TabIndex = 23;
            // 
            // btnChangeNumberOfProduct
            // 
            this.btnChangeNumberOfProduct.Location = new System.Drawing.Point(828, 310);
            this.btnChangeNumberOfProduct.Name = "btnChangeNumberOfProduct";
            this.btnChangeNumberOfProduct.Size = new System.Drawing.Size(186, 23);
            this.btnChangeNumberOfProduct.TabIndex = 24;
            this.btnChangeNumberOfProduct.Text = "Изменить количество товара";
            this.btnChangeNumberOfProduct.UseVisualStyleBackColor = true;
            this.btnChangeNumberOfProduct.Click += new System.EventHandler(this.btnChangeNumberOfProduct_Click);
            // 
            // txtBxNumberOfProduct
            // 
            this.txtBxNumberOfProduct.Location = new System.Drawing.Point(1020, 312);
            this.txtBxNumberOfProduct.Name = "txtBxNumberOfProduct";
            this.txtBxNumberOfProduct.Size = new System.Drawing.Size(100, 20);
            this.txtBxNumberOfProduct.TabIndex = 25;
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column19,
            this.Объём,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.ordersTable.Location = new System.Drawing.Point(157, 13);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.ReadOnly = true;
            this.ordersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersTable.Size = new System.Drawing.Size(1018, 470);
            this.ordersTable.TabIndex = 27;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "id";
            this.Column9.HeaderText = "id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Наименование:";
            this.Column10.HeaderText = "Наименование:";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Стоимость:";
            this.Column11.HeaderText = "Стоимость:";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "Количество:";
            this.Column19.HeaderText = "Количество:";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Объём
            // 
            this.Объём.DataPropertyName = "Объём:";
            this.Объём.HeaderText = "Объём:";
            this.Объём.Name = "Объём";
            this.Объём.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Рецепт:";
            this.Column12.HeaderText = "Рецепт:";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Срок годности:";
            this.Column13.HeaderText = "Срок годности:";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Первичная упаковка:";
            this.Column14.HeaderText = "Первичная упаковка:";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Активное вещество:";
            this.Column15.HeaderText = "Активное вещество:";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Специальные свойства:";
            this.Column16.HeaderText = "Специальные свойства:";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Форма выпуска:";
            this.Column17.HeaderText = "Форма выпуска:";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "Производитель:";
            this.Column18.HeaderText = "Производитель:";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(1025, 25);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(155, 23);
            this.btnClearFilter.TabIndex = 68;
            this.btnClearFilter.Text = "Сбросить фильтры";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(672, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Форма выпуска:";
            // 
            // cmBxReleaseForm
            // 
            this.cmBxReleaseForm.FormattingEnabled = true;
            this.cmBxReleaseForm.Location = new System.Drawing.Point(675, 27);
            this.cmBxReleaseForm.Name = "cmBxReleaseForm";
            this.cmBxReleaseForm.Size = new System.Drawing.Size(127, 21);
            this.cmBxReleaseForm.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Производитель:";
            // 
            // cmBxFactory
            // 
            this.cmBxFactory.FormattingEnabled = true;
            this.cmBxFactory.Location = new System.Drawing.Point(526, 27);
            this.cmBxFactory.Name = "cmBxFactory";
            this.cmBxFactory.Size = new System.Drawing.Size(127, 21);
            this.cmBxFactory.TabIndex = 64;
            // 
            // txtBxFindLine
            // 
            this.txtBxFindLine.Location = new System.Drawing.Point(144, 28);
            this.txtBxFindLine.Name = "txtBxFindLine";
            this.txtBxFindLine.Size = new System.Drawing.Size(186, 20);
            this.txtBxFindLine.TabIndex = 63;
            this.txtBxFindLine.TextChanged += new System.EventHandler(this.txtBxFindLine_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Срок годности:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Поиск:";
            // 
            // cmBxExpirationDate
            // 
            this.cmBxExpirationDate.FormattingEnabled = true;
            this.cmBxExpirationDate.Location = new System.Drawing.Point(366, 27);
            this.cmBxExpirationDate.Name = "cmBxExpirationDate";
            this.cmBxExpirationDate.Size = new System.Drawing.Size(127, 21);
            this.cmBxExpirationDate.TabIndex = 60;
            this.cmBxExpirationDate.SelectedIndexChanged += new System.EventHandler(this.cmBxExpirationDate_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pharm);
            this.tabControl1.Controls.Add(this.ordres);
            this.tabControl1.Controls.Add(this.basket);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 541);
            this.tabControl1.TabIndex = 69;
            // 
            // pharm
            // 
            this.pharm.Controls.Add(this.medicinesListPanel);
            this.pharm.Controls.Add(this.label1);
            this.pharm.Controls.Add(this.txtBxNumberOfMedicines);
            this.pharm.Controls.Add(this.btnAddToBasket);
            this.pharm.Controls.Add(this.btnClearFilter);
            this.pharm.Controls.Add(this.MedicineTable);
            this.pharm.Controls.Add(this.label11);
            this.pharm.Controls.Add(this.txtBxFindLine);
            this.pharm.Controls.Add(this.cmBxReleaseForm);
            this.pharm.Controls.Add(this.label8);
            this.pharm.Controls.Add(this.label10);
            this.pharm.Controls.Add(this.cmBxExpirationDate);
            this.pharm.Controls.Add(this.cmBxFactory);
            this.pharm.Controls.Add(this.label9);
            this.pharm.Location = new System.Drawing.Point(4, 22);
            this.pharm.Name = "pharm";
            this.pharm.Padding = new System.Windows.Forms.Padding(3);
            this.pharm.Size = new System.Drawing.Size(1191, 515);
            this.pharm.TabIndex = 0;
            this.pharm.Text = "Лекарства";
            this.pharm.UseVisualStyleBackColor = true;
            // 
            // medicinesListPanel
            // 
            this.medicinesListPanel.Location = new System.Drawing.Point(6, 6);
            this.medicinesListPanel.Name = "medicinesListPanel";
            this.medicinesListPanel.Size = new System.Drawing.Size(135, 497);
            this.medicinesListPanel.TabIndex = 69;
            // 
            // ordres
            // 
            this.ordres.Controls.Add(this.orderListPanel);
            this.ordres.Controls.Add(this.btnExcelExport);
            this.ordres.Controls.Add(this.ordersTable);
            this.ordres.Location = new System.Drawing.Point(4, 22);
            this.ordres.Name = "ordres";
            this.ordres.Padding = new System.Windows.Forms.Padding(3);
            this.ordres.Size = new System.Drawing.Size(1191, 515);
            this.ordres.TabIndex = 1;
            this.ordres.Text = "Заказы";
            this.ordres.UseVisualStyleBackColor = true;
            // 
            // orderListPanel
            // 
            this.orderListPanel.Location = new System.Drawing.Point(6, 6);
            this.orderListPanel.Name = "orderListPanel";
            this.orderListPanel.Size = new System.Drawing.Size(145, 499);
            this.orderListPanel.TabIndex = 29;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(1019, 489);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(156, 23);
            this.btnExcelExport.TabIndex = 28;
            this.btnExcelExport.Text = "Выгрузить в Excel";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // basket
            // 
            this.basket.Controls.Add(this.basketTable);
            this.basket.Controls.Add(this.btnCreateOrder);
            this.basket.Controls.Add(this.label2);
            this.basket.Controls.Add(this.label3);
            this.basket.Controls.Add(this.txtBxNumberOfProduct);
            this.basket.Controls.Add(this.label4);
            this.basket.Controls.Add(this.btnChangeNumberOfProduct);
            this.basket.Controls.Add(this.label5);
            this.basket.Controls.Add(this.cmbBxDeliveryAddress);
            this.basket.Controls.Add(this.txtBxDeliveryDate);
            this.basket.Controls.Add(this.txtBxCustomerName);
            this.basket.Controls.Add(this.txtBxOrderCost);
            this.basket.Controls.Add(this.label6);
            this.basket.Controls.Add(this.txtBxOrderNumber);
            this.basket.Controls.Add(this.btnDeleteFromList);
            this.basket.Location = new System.Drawing.Point(4, 22);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(1191, 515);
            this.basket.TabIndex = 2;
            this.basket.Text = "Корзина";
            this.basket.UseVisualStyleBackColor = true;
            // 
            // btnUserFormExit
            // 
            this.btnUserFormExit.Location = new System.Drawing.Point(1092, 5);
            this.btnUserFormExit.Name = "btnUserFormExit";
            this.btnUserFormExit.Size = new System.Drawing.Size(115, 23);
            this.btnUserFormExit.TabIndex = 70;
            this.btnUserFormExit.Text = "Выход";
            this.btnUserFormExit.UseVisualStyleBackColor = true;
            this.btnUserFormExit.Click += new System.EventHandler(this.btnUserFormExit_Click);
            // 
            // UserController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 567);
            this.Controls.Add(this.btnUserFormExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserController";
            this.Text = "Модуль корпоративной информационной системы сети аптек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserController_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineTable)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basketTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pharm.ResumeLayout(false);
            this.pharm.PerformLayout();
            this.ordres.ResumeLayout(false);
            this.basket.ResumeLayout(false);
            this.basket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MedicineTable;
        private System.Windows.Forms.TextBox txtBxNumberOfMedicines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.DataGridView basketTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxDeliveryDate;
        private System.Windows.Forms.TextBox txtBxOrderCost;
        private System.Windows.Forms.TextBox txtBxOrderNumber;
        private System.Windows.Forms.Button btnDeleteFromList;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxCustomerName;
        private System.Windows.Forms.ComboBox cmbBxDeliveryAddress;
        private System.Windows.Forms.Button btnChangeNumberOfProduct;
        private System.Windows.Forms.TextBox txtBxNumberOfProduct;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmBxReleaseForm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmBxFactory;
        private System.Windows.Forms.TextBox txtBxFindLine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmBxExpirationDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pharm;
        private System.Windows.Forms.TabPage ordres;
        private System.Windows.Forms.TabPage basket;
        private System.Windows.Forms.Button btnUserFormExit;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_form;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_factory;
        private System.Windows.Forms.FlowLayoutPanel orderListPanel;
        private System.Windows.Forms.FlowLayoutPanel medicinesListPanel;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn on_prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn costs;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryPackaging;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveSubstance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Объём;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
    }
}