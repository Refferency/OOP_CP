namespace OOP_CP.Management
{
    partial class FinancialTurnover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialTurnover));
            this.backButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.routeNumber = new System.Windows.Forms.TextBox();
            this.fuelPrice = new System.Windows.Forms.TextBox();
            this.driverCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printResult = new System.Windows.Forms.RichTextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.backButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(635, 157);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(153, 60);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveFileButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.saveFileButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.Location = new System.Drawing.Point(12, 157);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(153, 60);
            this.saveFileButton.TabIndex = 4;
            this.saveFileButton.Text = "Сохранить в файл для печати";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Цена 1л бензина:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Номер маршрута:";
            // 
            // routeNumber
            // 
            this.routeNumber.AllowDrop = true;
            this.routeNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.routeNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeNumber.Location = new System.Drawing.Point(127, 15);
            this.routeNumber.Name = "routeNumber";
            this.routeNumber.Size = new System.Drawing.Size(111, 21);
            this.routeNumber.TabIndex = 54;
            // 
            // fuelPrice
            // 
            this.fuelPrice.AllowDrop = true;
            this.fuelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fuelPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelPrice.Location = new System.Drawing.Point(127, 60);
            this.fuelPrice.Name = "fuelPrice";
            this.fuelPrice.Size = new System.Drawing.Size(111, 21);
            this.fuelPrice.TabIndex = 57;
            // 
            // driverCost
            // 
            this.driverCost.AllowDrop = true;
            this.driverCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.driverCost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverCost.Location = new System.Drawing.Point(127, 111);
            this.driverCost.Name = "driverCost";
            this.driverCost.Size = new System.Drawing.Size(111, 21);
            this.driverCost.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "ЗП водителя:";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 121);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 60;
            this.label4.Text = "за месяц";
            // 
            // printResult
            // 
            this.printResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printResult.Location = new System.Drawing.Point(268, 12);
            this.printResult.Name = "printResult";
            this.printResult.ReadOnly = true;
            this.printResult.Size = new System.Drawing.Size(520, 123);
            this.printResult.TabIndex = 119;
            this.printResult.Text = "";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calculateButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(325, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(153, 60);
            this.calculateButton.TabIndex = 120;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // FinancialTurnover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.printResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.driverCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuelPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.routeNumber);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(600, 550);
            this.Name = "FinancialTurnover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Получить финансовый отчет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox routeNumber;
        private System.Windows.Forms.TextBox fuelPrice;
        private System.Windows.Forms.TextBox driverCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox printResult;
        private System.Windows.Forms.Button calculateButton;
    }
}