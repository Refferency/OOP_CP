namespace OOP_CP.AppendManager
{
    partial class AppendRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendRoute));
            this.backButton = new System.Windows.Forms.Button();
            this.passanger_countText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kmText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.typeRouteBox = new System.Windows.Forms.ComboBox();
            this.isEditText = new System.Windows.Forms.Label();
            this.ticketText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(210, 280);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(168, 42);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "Вернуться назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // passanger_countText
            // 
            this.passanger_countText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passanger_countText.Location = new System.Drawing.Point(241, 168);
            this.passanger_countText.Name = "passanger_countText";
            this.passanger_countText.Size = new System.Drawing.Size(120, 20);
            this.passanger_countText.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Пассажиров за день:";
            // 
            // kmText
            // 
            this.kmText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kmText.Location = new System.Drawing.Point(241, 128);
            this.kmText.Name = "kmText";
            this.kmText.Size = new System.Drawing.Size(120, 20);
            this.kmText.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Километраж: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Тип маршрута:";
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Location = new System.Drawing.Point(241, 60);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(120, 20);
            this.nameText.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название:";
            // 
            // numberText
            // 
            this.numberText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberText.Location = new System.Drawing.Point(241, 29);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(120, 20);
            this.numberText.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Номер:";
            // 
            // addRouteButton
            // 
            this.addRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addRouteButton.Location = new System.Drawing.Point(32, 280);
            this.addRouteButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(168, 42);
            this.addRouteButton.TabIndex = 30;
            this.addRouteButton.Text = "Добавить маршрут";
            this.addRouteButton.UseVisualStyleBackColor = true;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // typeRouteBox
            // 
            this.typeRouteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeRouteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeRouteBox.FormattingEnabled = true;
            this.typeRouteBox.Items.AddRange(new object[] {
            "Городской",
            "Междугородний"});
            this.typeRouteBox.Location = new System.Drawing.Point(241, 92);
            this.typeRouteBox.Name = "typeRouteBox";
            this.typeRouteBox.Size = new System.Drawing.Size(120, 21);
            this.typeRouteBox.TabIndex = 47;
            this.typeRouteBox.SelectedIndexChanged += new System.EventHandler(this.typeRouteBox_SelectedIndexChanged);
            // 
            // isEditText
            // 
            this.isEditText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isEditText.AutoSize = true;
            this.isEditText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.isEditText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isEditText.Location = new System.Drawing.Point(19, 246);
            this.isEditText.Name = "isEditText";
            this.isEditText.Size = new System.Drawing.Size(372, 16);
            this.isEditText.TabIndex = 48;
            this.isEditText.Text = "Введите новую информацию в поля, которые хотите изменить";
            this.isEditText.Visible = false;
            // 
            // ticketText
            // 
            this.ticketText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketText.Location = new System.Drawing.Point(241, 202);
            this.ticketText.Name = "ticketText";
            this.ticketText.Size = new System.Drawing.Size(120, 20);
            this.ticketText.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(28, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Стоимость билета:";
            // 
            // AppendRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(402, 333);
            this.Controls.Add(this.isEditText);
            this.Controls.Add(this.typeRouteBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ticketText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passanger_countText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kmText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRouteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppendRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить маршрут";
            this.Load += new System.EventHandler(this.AppendRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox passanger_countText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kmText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRouteButton;
        private System.Windows.Forms.ComboBox typeRouteBox;
        private System.Windows.Forms.Label isEditText;
        private System.Windows.Forms.TextBox ticketText;
        private System.Windows.Forms.Label label7;
    }
}