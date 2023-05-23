namespace OOP_CP.AppendManager
{
    partial class AppendBus
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendBus));
            this.isEditText = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.remontText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fuelText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.routeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBusButton = new System.Windows.Forms.Button();
            this.driverName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(25, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 18);
            label3.TabIndex = 54;
            label3.Text = "ФИО водителя:";
            // 
            // isEditText
            // 
            this.isEditText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isEditText.AutoSize = true;
            this.isEditText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.isEditText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isEditText.Location = new System.Drawing.Point(12, 260);
            this.isEditText.Name = "isEditText";
            this.isEditText.Size = new System.Drawing.Size(372, 16);
            this.isEditText.TabIndex = 65;
            this.isEditText.Text = "Введите новую информацию в поля, которые хотите изменить";
            this.isEditText.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(206, 301);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(168, 42);
            this.backButton.TabIndex = 63;
            this.backButton.Text = "Вернуться назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // remontText
            // 
            this.remontText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remontText.Location = new System.Drawing.Point(245, 202);
            this.remontText.Name = "remontText";
            this.remontText.Size = new System.Drawing.Size(129, 20);
            this.remontText.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Траты на обслуживание:";
            // 
            // fuelText
            // 
            this.fuelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fuelText.Location = new System.Drawing.Point(245, 165);
            this.fuelText.Name = "fuelText";
            this.fuelText.Size = new System.Drawing.Size(129, 20);
            this.fuelText.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Расход топлива:";
            // 
            // routeText
            // 
            this.routeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.routeText.Location = new System.Drawing.Point(245, 130);
            this.routeText.Name = "routeText";
            this.routeText.Size = new System.Drawing.Size(129, 20);
            this.routeText.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Связанный маршрут: ";
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Location = new System.Drawing.Point(245, 56);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(129, 20);
            this.nameText.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Производитель и модель:";
            // 
            // numberText
            // 
            this.numberText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberText.Location = new System.Drawing.Point(245, 20);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(129, 20);
            this.numberText.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Транспортный номер:";
            // 
            // addBusButton
            // 
            this.addBusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBusButton.Location = new System.Drawing.Point(28, 301);
            this.addBusButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(168, 42);
            this.addBusButton.TabIndex = 49;
            this.addBusButton.Text = "Добавить маршрут";
            this.addBusButton.UseVisualStyleBackColor = true;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // driverName
            // 
            this.driverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.driverName.Location = new System.Drawing.Point(245, 93);
            this.driverName.Name = "driverName";
            this.driverName.Size = new System.Drawing.Size(129, 20);
            this.driverName.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "(1л/100км):";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "(на 5000 км):";
            // 
            // AppendBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 373);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.driverName);
            this.Controls.Add(this.isEditText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.remontText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fuelText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.routeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBusButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppendBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить автобус";
            this.Load += new System.EventHandler(this.AppendBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isEditText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox remontText;
        private System.Windows.Forms.TextBox fuelText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox routeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBusButton;
        private System.Windows.Forms.TextBox driverName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}