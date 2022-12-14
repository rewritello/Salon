namespace spa
{
    partial class CatalogForRegisteredUserForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CatalogLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelTypeLabel = new System.Windows.Forms.Label();
            this.PriceTypeLabel = new System.Windows.Forms.Label();
            this.AddToBasketButton = new System.Windows.Forms.Button();
            this.PreviousModelButton = new System.Windows.Forms.Button();
            this.NextModelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 45);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CatalogLabel
            // 
            this.CatalogLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CatalogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatalogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CatalogLabel.Location = new System.Drawing.Point(222, 38);
            this.CatalogLabel.Name = "CatalogLabel";
            this.CatalogLabel.Size = new System.Drawing.Size(395, 60);
            this.CatalogLabel.TabIndex = 12;
            this.CatalogLabel.Text = "Каталог:";
            this.CatalogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelLabel.Location = new System.Drawing.Point(47, 150);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(225, 52);
            this.ModelLabel.TabIndex = 14;
            this.ModelLabel.Text = "Модель:";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceLabel.Location = new System.Drawing.Point(47, 223);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(225, 52);
            this.PriceLabel.TabIndex = 15;
            this.PriceLabel.Text = "Цена:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTypeLabel
            // 
            this.ModelTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModelTypeLabel.Location = new System.Drawing.Point(302, 150);
            this.ModelTypeLabel.Name = "ModelTypeLabel";
            this.ModelTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.ModelTypeLabel.TabIndex = 16;
            this.ModelTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceTypeLabel
            // 
            this.PriceTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PriceTypeLabel.Location = new System.Drawing.Point(302, 223);
            this.PriceTypeLabel.Name = "PriceTypeLabel";
            this.PriceTypeLabel.Size = new System.Drawing.Size(315, 52);
            this.PriceTypeLabel.TabIndex = 17;
            this.PriceTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddToBasketButton
            // 
            this.AddToBasketButton.Location = new System.Drawing.Point(302, 372);
            this.AddToBasketButton.Name = "AddToBasketButton";
            this.AddToBasketButton.Size = new System.Drawing.Size(209, 44);
            this.AddToBasketButton.TabIndex = 18;
            this.AddToBasketButton.Text = "Добавить в корзину";
            this.AddToBasketButton.UseVisualStyleBackColor = true;
            this.AddToBasketButton.Click += new System.EventHandler(this.AddToBasketButton_Click);
            // 
            // PreviousModelButton
            // 
            this.PreviousModelButton.Location = new System.Drawing.Point(47, 372);
            this.PreviousModelButton.Name = "PreviousModelButton";
            this.PreviousModelButton.Size = new System.Drawing.Size(209, 44);
            this.PreviousModelButton.TabIndex = 19;
            this.PreviousModelButton.Text = "Предыдущая модель";
            this.PreviousModelButton.UseVisualStyleBackColor = true;
            this.PreviousModelButton.Click += new System.EventHandler(this.PreviousModelButton_Click);
            // 
            // NextModelButton
            // 
            this.NextModelButton.Location = new System.Drawing.Point(553, 372);
            this.NextModelButton.Name = "NextModelButton";
            this.NextModelButton.Size = new System.Drawing.Size(209, 44);
            this.NextModelButton.TabIndex = 20;
            this.NextModelButton.Text = "Следующая модель";
            this.NextModelButton.UseVisualStyleBackColor = true;
            this.NextModelButton.Click += new System.EventHandler(this.NextModelButton_Click);
            // 
            // CatalogForRegisteredUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextModelButton);
            this.Controls.Add(this.PreviousModelButton);
            this.Controls.Add(this.AddToBasketButton);
            this.Controls.Add(this.PriceTypeLabel);
            this.Controls.Add(this.ModelTypeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CatalogLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CatalogForRegisteredUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPA";
            this.Load += new System.EventHandler(this.CatalogForRegisteredUserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CatalogLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelTypeLabel;
        private System.Windows.Forms.Label PriceTypeLabel;
        private System.Windows.Forms.Button AddToBasketButton;
        private System.Windows.Forms.Button PreviousModelButton;
        private System.Windows.Forms.Button NextModelButton;
    }
}