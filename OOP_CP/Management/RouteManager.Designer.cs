namespace OOP_CP.Management
{
    partial class RouteManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteManager));
            this.toMainMenuButton = new System.Windows.Forms.Button();
            this.routesGridView = new System.Windows.Forms.DataGridView();
            this.routeIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeKilomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeBusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeManCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeTicketCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.deleteRouteButton = new System.Windows.Forms.Button();
            this.editRouteButton = new System.Windows.Forms.Button();
            this.selectRoute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteAllRouteButton = new System.Windows.Forms.Button();
            this.selectFiltreBox = new System.Windows.Forms.ComboBox();
            this.findRouteButton = new System.Windows.Forms.Button();
            this.filterValueText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.financialTurnoverButton = new System.Windows.Forms.Button();
            this.sortRoutesDownButton = new System.Windows.Forms.Button();
            this.sortRoutesButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.routeCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.routesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toMainMenuButton
            // 
            this.toMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toMainMenuButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.toMainMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toMainMenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.toMainMenuButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMainMenuButton.Location = new System.Drawing.Point(971, 412);
            this.toMainMenuButton.Name = "toMainMenuButton";
            this.toMainMenuButton.Size = new System.Drawing.Size(153, 60);
            this.toMainMenuButton.TabIndex = 2;
            this.toMainMenuButton.Text = "Назад";
            this.toMainMenuButton.UseVisualStyleBackColor = false;
            this.toMainMenuButton.Click += new System.EventHandler(this.toMainMenuButton_Click);
            // 
            // routesGridView
            // 
            this.routesGridView.AllowDrop = true;
            this.routesGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.routesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.routesGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.routesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.routesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.routesGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.routesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.routesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.routesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeIDCol,
            this.routeNameCol,
            this.routeTypeCol,
            this.routeKilomCol,
            this.routeBusCol,
            this.routeManCol,
            this.routeTicketCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.routesGridView.Location = new System.Drawing.Point(12, 13);
            this.routesGridView.Name = "routesGridView";
            this.routesGridView.ReadOnly = true;
            this.routesGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.routesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.routesGridView.RowHeadersVisible = false;
            this.routesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.routesGridView.Size = new System.Drawing.Size(933, 255);
            this.routesGridView.TabIndex = 27;
            // 
            // routeIDCol
            // 
            this.routeIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.routeIDCol.HeaderText = "№";
            this.routeIDCol.MinimumWidth = 6;
            this.routeIDCol.Name = "routeIDCol";
            this.routeIDCol.ReadOnly = true;
            this.routeIDCol.Width = 45;
            // 
            // routeNameCol
            // 
            this.routeNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.routeNameCol.FillWeight = 112.9234F;
            this.routeNameCol.HeaderText = "Название";
            this.routeNameCol.MinimumWidth = 6;
            this.routeNameCol.Name = "routeNameCol";
            this.routeNameCol.ReadOnly = true;
            this.routeNameCol.Width = 81;
            // 
            // routeTypeCol
            // 
            this.routeTypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.routeTypeCol.FillWeight = 112.9234F;
            this.routeTypeCol.HeaderText = "Тип";
            this.routeTypeCol.MinimumWidth = 6;
            this.routeTypeCol.Name = "routeTypeCol";
            this.routeTypeCol.ReadOnly = true;
            this.routeTypeCol.Width = 50;
            // 
            // routeKilomCol
            // 
            this.routeKilomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.routeKilomCol.FillWeight = 112.9234F;
            this.routeKilomCol.HeaderText = "Километраж";
            this.routeKilomCol.MinimumWidth = 6;
            this.routeKilomCol.Name = "routeKilomCol";
            this.routeKilomCol.ReadOnly = true;
            this.routeKilomCol.Width = 97;
            // 
            // routeBusCol
            // 
            this.routeBusCol.HeaderText = "Связанный транспорт";
            this.routeBusCol.MinimumWidth = 6;
            this.routeBusCol.Name = "routeBusCol";
            this.routeBusCol.ReadOnly = true;
            // 
            // routeManCol
            // 
            this.routeManCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.routeManCol.FillWeight = 112.9234F;
            this.routeManCol.HeaderText = "Среднее кол.во пассажиров";
            this.routeManCol.MinimumWidth = 6;
            this.routeManCol.Name = "routeManCol";
            this.routeManCol.ReadOnly = true;
            this.routeManCol.Width = 161;
            // 
            // routeTicketCol
            // 
            this.routeTicketCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.routeTicketCol.FillWeight = 112.9234F;
            this.routeTicketCol.HeaderText = "Цена билета за проезд";
            this.routeTicketCol.MinimumWidth = 6;
            this.routeTicketCol.Name = "routeTicketCol";
            this.routeTicketCol.ReadOnly = true;
            this.routeTicketCol.Width = 104;
            // 
            // addRouteButton
            // 
            this.addRouteButton.AllowDrop = true;
            this.addRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addRouteButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.addRouteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addRouteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.addRouteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRouteButton.Location = new System.Drawing.Point(12, 279);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addRouteButton.Size = new System.Drawing.Size(157, 46);
            this.addRouteButton.TabIndex = 28;
            this.addRouteButton.Text = "Добавить маршрут";
            this.addRouteButton.UseVisualStyleBackColor = false;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.AllowDrop = true;
            this.resetFilterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetFilterButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.resetFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetFilterButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.resetFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetFilterButton.Location = new System.Drawing.Point(681, 276);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resetFilterButton.Size = new System.Drawing.Size(114, 67);
            this.resetFilterButton.TabIndex = 29;
            this.resetFilterButton.Text = "Сбросить фильтр";
            this.resetFilterButton.UseVisualStyleBackColor = false;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
            // 
            // addFilterButton
            // 
            this.addFilterButton.AllowDrop = true;
            this.addFilterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addFilterButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.addFilterButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFilterButton.Location = new System.Drawing.Point(542, 279);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addFilterButton.Size = new System.Drawing.Size(114, 64);
            this.addFilterButton.TabIndex = 30;
            this.addFilterButton.Text = "Задать фильтр";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // deleteRouteButton
            // 
            this.deleteRouteButton.AllowDrop = true;
            this.deleteRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteRouteButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.deleteRouteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteRouteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.deleteRouteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRouteButton.Location = new System.Drawing.Point(968, 195);
            this.deleteRouteButton.Name = "deleteRouteButton";
            this.deleteRouteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteRouteButton.Size = new System.Drawing.Size(153, 60);
            this.deleteRouteButton.TabIndex = 31;
            this.deleteRouteButton.Text = "Удалить маршрут";
            this.deleteRouteButton.UseVisualStyleBackColor = false;
            this.deleteRouteButton.Click += new System.EventHandler(this.deleteRouteButton_Click);
            // 
            // editRouteButton
            // 
            this.editRouteButton.AllowDrop = true;
            this.editRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editRouteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editRouteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.editRouteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRouteButton.Location = new System.Drawing.Point(968, 128);
            this.editRouteButton.Name = "editRouteButton";
            this.editRouteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editRouteButton.Size = new System.Drawing.Size(153, 60);
            this.editRouteButton.TabIndex = 32;
            this.editRouteButton.Text = "Редактировать маршрут";
            this.editRouteButton.UseVisualStyleBackColor = true;
            this.editRouteButton.Click += new System.EventHandler(this.editRouteButton_Click);
            // 
            // selectRoute
            // 
            this.selectRoute.AllowDrop = true;
            this.selectRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectRoute.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectRoute.Location = new System.Drawing.Point(968, 33);
            this.selectRoute.Name = "selectRoute";
            this.selectRoute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectRoute.Size = new System.Drawing.Size(153, 21);
            this.selectRoute.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(974, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Введите номер маршрута:";
            // 
            // deleteAllRouteButton
            // 
            this.deleteAllRouteButton.AllowDrop = true;
            this.deleteAllRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteAllRouteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteAllRouteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.deleteAllRouteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAllRouteButton.Location = new System.Drawing.Point(968, 276);
            this.deleteAllRouteButton.Name = "deleteAllRouteButton";
            this.deleteAllRouteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteAllRouteButton.Size = new System.Drawing.Size(153, 67);
            this.deleteAllRouteButton.TabIndex = 37;
            this.deleteAllRouteButton.Text = "Удалить все маршруты";
            this.deleteAllRouteButton.UseVisualStyleBackColor = true;
            this.deleteAllRouteButton.Click += new System.EventHandler(this.deleteAllRouteButton_Click);
            // 
            // selectFiltreBox
            // 
            this.selectFiltreBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFiltreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFiltreBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFiltreBox.FormattingEnabled = true;
            this.selectFiltreBox.Items.AddRange(new object[] {
            "Номер",
            "Название",
            "Тип",
            "Километраж",
            "Кол.во пассажиров",
            "Цена"});
            this.selectFiltreBox.Location = new System.Drawing.Point(403, 282);
            this.selectFiltreBox.Name = "selectFiltreBox";
            this.selectFiltreBox.Size = new System.Drawing.Size(121, 23);
            this.selectFiltreBox.TabIndex = 48;
            this.selectFiltreBox.SelectedIndexChanged += new System.EventHandler(this.selectFilteBox_SelectedIndexChanged);
            // 
            // findRouteButton
            // 
            this.findRouteButton.AllowDrop = true;
            this.findRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findRouteButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.findRouteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.findRouteButton.FlatAppearance.BorderSize = 2;
            this.findRouteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.findRouteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.findRouteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findRouteButton.Location = new System.Drawing.Point(968, 61);
            this.findRouteButton.Name = "findRouteButton";
            this.findRouteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.findRouteButton.Size = new System.Drawing.Size(153, 60);
            this.findRouteButton.TabIndex = 49;
            this.findRouteButton.Text = "Найти маршрут";
            this.findRouteButton.UseVisualStyleBackColor = false;
            this.findRouteButton.Click += new System.EventHandler(this.findRouteButton_Click);
            // 
            // filterValueText
            // 
            this.filterValueText.AllowDrop = true;
            this.filterValueText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterValueText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterValueText.Location = new System.Drawing.Point(403, 318);
            this.filterValueText.Name = "filterValueText";
            this.filterValueText.Size = new System.Drawing.Size(121, 21);
            this.filterValueText.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 285);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Выберите тип фильтра:";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(285, 322);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Введите значение:";
            // 
            // financialTurnoverButton
            // 
            this.financialTurnoverButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.financialTurnoverButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.financialTurnoverButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.financialTurnoverButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.financialTurnoverButton.Location = new System.Drawing.Point(12, 414);
            this.financialTurnoverButton.Name = "financialTurnoverButton";
            this.financialTurnoverButton.Size = new System.Drawing.Size(160, 60);
            this.financialTurnoverButton.TabIndex = 55;
            this.financialTurnoverButton.Text = "Рассчитать доходы и расходы";
            this.financialTurnoverButton.UseVisualStyleBackColor = true;
            this.financialTurnoverButton.Click += new System.EventHandler(this.financialTurnoverButton_Click);
            // 
            // sortRoutesDownButton
            // 
            this.sortRoutesDownButton.AllowDrop = true;
            this.sortRoutesDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortRoutesDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sortRoutesDownButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sortRoutesDownButton.Image = ((System.Drawing.Image)(resources.GetObject("sortRoutesDownButton.Image")));
            this.sortRoutesDownButton.Location = new System.Drawing.Point(815, 276);
            this.sortRoutesDownButton.Name = "sortRoutesDownButton";
            this.sortRoutesDownButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortRoutesDownButton.Size = new System.Drawing.Size(56, 67);
            this.sortRoutesDownButton.TabIndex = 54;
            this.sortRoutesDownButton.UseVisualStyleBackColor = true;
            this.sortRoutesDownButton.Click += new System.EventHandler(this.sortRoutesDownButton_Click);
            // 
            // sortRoutesButton
            // 
            this.sortRoutesButton.AllowDrop = true;
            this.sortRoutesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortRoutesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sortRoutesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.sortRoutesButton.Image = global::OOP_CP.Properties.Resources.up_arrow;
            this.sortRoutesButton.Location = new System.Drawing.Point(889, 276);
            this.sortRoutesButton.Name = "sortRoutesButton";
            this.sortRoutesButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortRoutesButton.Size = new System.Drawing.Size(56, 67);
            this.sortRoutesButton.TabIndex = 53;
            this.sortRoutesButton.UseVisualStyleBackColor = true;
            this.sortRoutesButton.Click += new System.EventHandler(this.sortRoutesButton_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 331);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Всего маршрутов:";
            // 
            // routeCount
            // 
            this.routeCount.AllowDrop = true;
            this.routeCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.routeCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeCount.Location = new System.Drawing.Point(122, 328);
            this.routeCount.Name = "routeCount";
            this.routeCount.Size = new System.Drawing.Size(47, 21);
            this.routeCount.TabIndex = 57;
            // 
            // RouteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1136, 486);
            this.Controls.Add(this.routeCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.financialTurnoverButton);
            this.Controls.Add(this.sortRoutesDownButton);
            this.Controls.Add(this.sortRoutesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterValueText);
            this.Controls.Add(this.findRouteButton);
            this.Controls.Add(this.selectFiltreBox);
            this.Controls.Add(this.deleteAllRouteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectRoute);
            this.Controls.Add(this.editRouteButton);
            this.Controls.Add(this.deleteRouteButton);
            this.Controls.Add(this.addFilterButton);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.addRouteButton);
            this.Controls.Add(this.toMainMenuButton);
            this.Controls.Add(this.routesGridView);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление маршрутами";
            this.Load += new System.EventHandler(this.RouteManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toMainMenuButton;
        private System.Windows.Forms.DataGridView routesGridView;
        private System.Windows.Forms.Button addRouteButton;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.Button deleteRouteButton;
        private System.Windows.Forms.Button editRouteButton;
        private System.Windows.Forms.TextBox selectRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteAllRouteButton;
        private System.Windows.Forms.ComboBox selectFiltreBox;
        private System.Windows.Forms.Button findRouteButton;
        private System.Windows.Forms.TextBox filterValueText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sortRoutesButton;
        private System.Windows.Forms.Button sortRoutesDownButton;
        private System.Windows.Forms.Button financialTurnoverButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeKilomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeBusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeManCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeTicketCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox routeCount;
    }
}