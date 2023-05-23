namespace OOP_CP.Management
{
    partial class BusManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusManager));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filterValueText = new System.Windows.Forms.TextBox();
            this.findBusButton = new System.Windows.Forms.Button();
            this.selectFiltreBox = new System.Windows.Forms.ComboBox();
            this.deleteAllBusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBus = new System.Windows.Forms.TextBox();
            this.editBusButton = new System.Windows.Forms.Button();
            this.deleteBusButton = new System.Windows.Forms.Button();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.addBusButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.busesGridView = new System.Windows.Forms.DataGridView();
            this.sortBussDownButton = new System.Windows.Forms.Button();
            this.sortBussButton = new System.Windows.Forms.Button();
            this.busCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.busIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busKilomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busBusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busManCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.busesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(284, 336);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "Введите значение:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 299);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 69;
            this.label1.Text = "Выберите тип фильтра:";
            // 
            // filterValueText
            // 
            this.filterValueText.AllowDrop = true;
            this.filterValueText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterValueText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterValueText.Location = new System.Drawing.Point(402, 332);
            this.filterValueText.Name = "filterValueText";
            this.filterValueText.Size = new System.Drawing.Size(121, 21);
            this.filterValueText.TabIndex = 68;
            // 
            // findBusButton
            // 
            this.findBusButton.AllowDrop = true;
            this.findBusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findBusButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.findBusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBusButton.Location = new System.Drawing.Point(967, 63);
            this.findBusButton.Name = "findBusButton";
            this.findBusButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.findBusButton.Size = new System.Drawing.Size(153, 60);
            this.findBusButton.TabIndex = 67;
            this.findBusButton.Text = "Найти автобус";
            this.findBusButton.UseVisualStyleBackColor = false;
            this.findBusButton.Click += new System.EventHandler(this.findBusButton_Click);
            // 
            // selectFiltreBox
            // 
            this.selectFiltreBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFiltreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFiltreBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFiltreBox.FormattingEnabled = true;
            this.selectFiltreBox.Items.AddRange(new object[] {
            "Номер",
            "Модель и производитель",
            "ФИО Водителя",
            "Маршрут",
            "Расход топлива",
            "Расход на ослуживание"});
            this.selectFiltreBox.Location = new System.Drawing.Point(402, 296);
            this.selectFiltreBox.Name = "selectFiltreBox";
            this.selectFiltreBox.Size = new System.Drawing.Size(121, 23);
            this.selectFiltreBox.TabIndex = 66;
            // 
            // deleteAllBusButton
            // 
            this.deleteAllBusButton.AllowDrop = true;
            this.deleteAllBusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteAllBusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteAllBusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.deleteAllBusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAllBusButton.Location = new System.Drawing.Point(967, 290);
            this.deleteAllBusButton.Name = "deleteAllBusButton";
            this.deleteAllBusButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteAllBusButton.Size = new System.Drawing.Size(153, 67);
            this.deleteAllBusButton.TabIndex = 65;
            this.deleteAllBusButton.Text = "Удалить все автобусы";
            this.deleteAllBusButton.UseVisualStyleBackColor = true;
            this.deleteAllBusButton.Click += new System.EventHandler(this.deleteAllBusButton_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(950, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Введите транспортный номер:";
            // 
            // selectBus
            // 
            this.selectBus.AllowDrop = true;
            this.selectBus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectBus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBus.Location = new System.Drawing.Point(967, 35);
            this.selectBus.Name = "selectBus";
            this.selectBus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectBus.Size = new System.Drawing.Size(153, 21);
            this.selectBus.TabIndex = 63;
            // 
            // editBusButton
            // 
            this.editBusButton.AllowDrop = true;
            this.editBusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editBusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.editBusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBusButton.Location = new System.Drawing.Point(967, 130);
            this.editBusButton.Name = "editBusButton";
            this.editBusButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editBusButton.Size = new System.Drawing.Size(153, 60);
            this.editBusButton.TabIndex = 62;
            this.editBusButton.Text = "Редактировать информацию об автобусе";
            this.editBusButton.UseVisualStyleBackColor = true;
            this.editBusButton.Click += new System.EventHandler(this.editBusButton_Click);
            // 
            // deleteBusButton
            // 
            this.deleteBusButton.AllowDrop = true;
            this.deleteBusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBusButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.deleteBusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteBusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.deleteBusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBusButton.Location = new System.Drawing.Point(967, 197);
            this.deleteBusButton.Name = "deleteBusButton";
            this.deleteBusButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteBusButton.Size = new System.Drawing.Size(153, 60);
            this.deleteBusButton.TabIndex = 61;
            this.deleteBusButton.Text = "Удалить автобус";
            this.deleteBusButton.UseVisualStyleBackColor = false;
            this.deleteBusButton.Click += new System.EventHandler(this.deleteBusButton_Click);
            // 
            // addFilterButton
            // 
            this.addFilterButton.AllowDrop = true;
            this.addFilterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addFilterButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.addFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFilterButton.Location = new System.Drawing.Point(541, 293);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addFilterButton.Size = new System.Drawing.Size(114, 64);
            this.addFilterButton.TabIndex = 60;
            this.addFilterButton.Text = "Задать фильтр";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.AllowDrop = true;
            this.resetFilterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetFilterButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.resetFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetFilterButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.resetFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetFilterButton.Location = new System.Drawing.Point(680, 290);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resetFilterButton.Size = new System.Drawing.Size(114, 67);
            this.resetFilterButton.TabIndex = 59;
            this.resetFilterButton.Text = "Сбросить фильтр";
            this.resetFilterButton.UseVisualStyleBackColor = false;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
            // 
            // addBusButton
            // 
            this.addBusButton.AllowDrop = true;
            this.addBusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBusButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.addBusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addBusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.addBusButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBusButton.Location = new System.Drawing.Point(11, 291);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addBusButton.Size = new System.Drawing.Size(157, 46);
            this.addBusButton.TabIndex = 58;
            this.addBusButton.Text = "Добавить автобус";
            this.addBusButton.UseVisualStyleBackColor = false;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(970, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 60);
            this.button2.TabIndex = 56;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.toMainMenuButton_Click);
            // 
            // busesGridView
            // 
            this.busesGridView.AllowDrop = true;
            this.busesGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.busesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.busesGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.busesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busesGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.busesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.busesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.busesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busIDCol,
            this.busNameCol,
            this.busTypeCol,
            this.busKilomCol,
            this.busBusCol,
            this.busManCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.busesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.busesGridView.Location = new System.Drawing.Point(11, 15);
            this.busesGridView.Name = "busesGridView";
            this.busesGridView.ReadOnly = true;
            this.busesGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.busesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.busesGridView.RowHeadersVisible = false;
            this.busesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.busesGridView.Size = new System.Drawing.Size(933, 260);
            this.busesGridView.TabIndex = 57;
            // 
            // sortBussDownButton
            // 
            this.sortBussDownButton.AllowDrop = true;
            this.sortBussDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortBussDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sortBussDownButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sortBussDownButton.Image = global::OOP_CP.Properties.Resources.down_arrow;
            this.sortBussDownButton.Location = new System.Drawing.Point(814, 290);
            this.sortBussDownButton.Name = "sortBussDownButton";
            this.sortBussDownButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortBussDownButton.Size = new System.Drawing.Size(56, 67);
            this.sortBussDownButton.TabIndex = 72;
            this.sortBussDownButton.UseVisualStyleBackColor = true;
            this.sortBussDownButton.Click += new System.EventHandler(this.sortBussDownButton_Click);
            // 
            // sortBussButton
            // 
            this.sortBussButton.AllowDrop = true;
            this.sortBussButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortBussButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sortBussButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sortBussButton.Image = global::OOP_CP.Properties.Resources.up_arrow;
            this.sortBussButton.Location = new System.Drawing.Point(888, 290);
            this.sortBussButton.Name = "sortBussButton";
            this.sortBussButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortBussButton.Size = new System.Drawing.Size(56, 67);
            this.sortBussButton.TabIndex = 71;
            this.sortBussButton.UseVisualStyleBackColor = true;
            this.sortBussButton.Click += new System.EventHandler(this.sortBussButton_Click);
            // 
            // busCount
            // 
            this.busCount.AllowDrop = true;
            this.busCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.busCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.busCount.Location = new System.Drawing.Point(121, 339);
            this.busCount.Name = "busCount";
            this.busCount.Size = new System.Drawing.Size(47, 21);
            this.busCount.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "Всего автобусов:";
            // 
            // busIDCol
            // 
            this.busIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.busIDCol.HeaderText = "Номер";
            this.busIDCol.MinimumWidth = 6;
            this.busIDCol.Name = "busIDCol";
            this.busIDCol.ReadOnly = true;
            this.busIDCol.Width = 110;
            // 
            // busNameCol
            // 
            this.busNameCol.FillWeight = 112.9234F;
            this.busNameCol.HeaderText = "Модель и производитель";
            this.busNameCol.MinimumWidth = 6;
            this.busNameCol.Name = "busNameCol";
            this.busNameCol.ReadOnly = true;
            // 
            // busTypeCol
            // 
            this.busTypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.busTypeCol.FillWeight = 112.9234F;
            this.busTypeCol.HeaderText = "ФИО Водителя";
            this.busTypeCol.MinimumWidth = 6;
            this.busTypeCol.Name = "busTypeCol";
            this.busTypeCol.ReadOnly = true;
            this.busTypeCol.Width = 109;
            // 
            // busKilomCol
            // 
            this.busKilomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.busKilomCol.FillWeight = 112.9234F;
            this.busKilomCol.HeaderText = "Маршрут";
            this.busKilomCol.MinimumWidth = 6;
            this.busKilomCol.Name = "busKilomCol";
            this.busKilomCol.ReadOnly = true;
            this.busKilomCol.Width = 78;
            // 
            // busBusCol
            // 
            this.busBusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.busBusCol.HeaderText = "Расход топлива";
            this.busBusCol.MinimumWidth = 6;
            this.busBusCol.Name = "busBusCol";
            this.busBusCol.ReadOnly = true;
            this.busBusCol.Width = 114;
            // 
            // busManCol
            // 
            this.busManCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.busManCol.FillWeight = 112.9234F;
            this.busManCol.HeaderText = "Расходы на обслуживание";
            this.busManCol.MinimumWidth = 6;
            this.busManCol.Name = "busManCol";
            this.busManCol.ReadOnly = true;
            this.busManCol.Width = 169;
            // 
            // BusManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1140, 490);
            this.Controls.Add(this.busCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortBussDownButton);
            this.Controls.Add(this.sortBussButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterValueText);
            this.Controls.Add(this.findBusButton);
            this.Controls.Add(this.selectFiltreBox);
            this.Controls.Add(this.deleteAllBusButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectBus);
            this.Controls.Add(this.editBusButton);
            this.Controls.Add(this.deleteBusButton);
            this.Controls.Add(this.addFilterButton);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.busesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление транспортом";
            this.Load += new System.EventHandler(this.BusManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sortBussDownButton;
        private System.Windows.Forms.Button sortBussButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterValueText;
        private System.Windows.Forms.Button findBusButton;
        private System.Windows.Forms.ComboBox selectFiltreBox;
        private System.Windows.Forms.Button deleteAllBusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectBus;
        private System.Windows.Forms.Button editBusButton;
        private System.Windows.Forms.Button deleteBusButton;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Button addBusButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView busesGridView;
        private System.Windows.Forms.TextBox busCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn busKilomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn busBusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn busManCol;
    }
}