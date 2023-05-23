namespace OOP_CP
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.routeManagerButton = new System.Windows.Forms.Button();
            this.busManagerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // routeManagerButton
            // 
            this.routeManagerButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.routeManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.routeManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.routeManagerButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.routeManagerButton.Location = new System.Drawing.Point(485, 243);
            this.routeManagerButton.Name = "routeManagerButton";
            this.routeManagerButton.Size = new System.Drawing.Size(195, 56);
            this.routeManagerButton.TabIndex = 0;
            this.routeManagerButton.Text = "Управление маршрутами";
            this.routeManagerButton.UseVisualStyleBackColor = false;
            this.routeManagerButton.Click += new System.EventHandler(this.routeManagerButton_Click);
            // 
            // busManagerButton
            // 
            this.busManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.busManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.busManagerButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.busManagerButton.Location = new System.Drawing.Point(485, 322);
            this.busManagerButton.Name = "busManagerButton";
            this.busManagerButton.Size = new System.Drawing.Size(195, 56);
            this.busManagerButton.TabIndex = 1;
            this.busManagerButton.Text = "Управление транспортом";
            this.busManagerButton.UseVisualStyleBackColor = true;
            this.busManagerButton.Click += new System.EventHandler(this.busManagerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(513, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Главное меню";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1164, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busManagerButton);
            this.Controls.Add(this.routeManagerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button routeManagerButton;
        private System.Windows.Forms.Button busManagerButton;
        private System.Windows.Forms.Label label3;
    }
}