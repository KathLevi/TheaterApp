namespace TheatreManagerApp
{
    partial class EditPopUp
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
            this.NewQuantityTxt = new System.Windows.Forms.TextBox();
            this.NewPriceTxt = new System.Windows.Forms.TextBox();
            this.SavePopUpBtn = new System.Windows.Forms.Button();
            this.QuantityPopUpLb = new System.Windows.Forms.Label();
            this.PricePopUpLb = new System.Windows.Forms.Label();
            this.NewProductNameLb = new System.Windows.Forms.Label();
            this.ClickedProductNameLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewQuantityTxt
            // 
            this.NewQuantityTxt.Location = new System.Drawing.Point(16, 170);
            this.NewQuantityTxt.Name = "NewQuantityTxt";
            this.NewQuantityTxt.Size = new System.Drawing.Size(256, 20);
            this.NewQuantityTxt.TabIndex = 13;
            // 
            // NewPriceTxt
            // 
            this.NewPriceTxt.Location = new System.Drawing.Point(16, 106);
            this.NewPriceTxt.Name = "NewPriceTxt";
            this.NewPriceTxt.Size = new System.Drawing.Size(256, 20);
            this.NewPriceTxt.TabIndex = 12;
            // 
            // SavePopUpBtn
            // 
            this.SavePopUpBtn.Location = new System.Drawing.Point(197, 226);
            this.SavePopUpBtn.Name = "SavePopUpBtn";
            this.SavePopUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePopUpBtn.TabIndex = 10;
            this.SavePopUpBtn.Text = "Save";
            this.SavePopUpBtn.UseVisualStyleBackColor = true;
            this.SavePopUpBtn.Click += new System.EventHandler(this.SavePopUpBtn_Click);
            // 
            // QuantityPopUpLb
            // 
            this.QuantityPopUpLb.AutoSize = true;
            this.QuantityPopUpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityPopUpLb.Location = new System.Drawing.Point(12, 147);
            this.QuantityPopUpLb.Name = "QuantityPopUpLb";
            this.QuantityPopUpLb.Size = new System.Drawing.Size(68, 20);
            this.QuantityPopUpLb.TabIndex = 9;
            this.QuantityPopUpLb.Text = "Quantity";
            // 
            // PricePopUpLb
            // 
            this.PricePopUpLb.AutoSize = true;
            this.PricePopUpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePopUpLb.Location = new System.Drawing.Point(12, 83);
            this.PricePopUpLb.Name = "PricePopUpLb";
            this.PricePopUpLb.Size = new System.Drawing.Size(44, 20);
            this.PricePopUpLb.TabIndex = 8;
            this.PricePopUpLb.Text = "Price";
            // 
            // NewProductNameLb
            // 
            this.NewProductNameLb.AutoSize = true;
            this.NewProductNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductNameLb.Location = new System.Drawing.Point(12, 20);
            this.NewProductNameLb.Name = "NewProductNameLb";
            this.NewProductNameLb.Size = new System.Drawing.Size(110, 20);
            this.NewProductNameLb.TabIndex = 7;
            this.NewProductNameLb.Text = "Product Name";
            // 
            // ClickedProductNameLb
            // 
            this.ClickedProductNameLb.AutoSize = true;
            this.ClickedProductNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickedProductNameLb.Location = new System.Drawing.Point(18, 53);
            this.ClickedProductNameLb.Name = "ClickedProductNameLb";
            this.ClickedProductNameLb.Size = new System.Drawing.Size(0, 17);
            this.ClickedProductNameLb.TabIndex = 14;
            // 
            // EditPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ClickedProductNameLb);
            this.Controls.Add(this.NewQuantityTxt);
            this.Controls.Add(this.NewPriceTxt);
            this.Controls.Add(this.SavePopUpBtn);
            this.Controls.Add(this.QuantityPopUpLb);
            this.Controls.Add(this.PricePopUpLb);
            this.Controls.Add(this.NewProductNameLb);
            this.Name = "EditPopUp";
            this.Text = "Edit Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewQuantityTxt;
        private System.Windows.Forms.TextBox NewPriceTxt;
        private System.Windows.Forms.Button SavePopUpBtn;
        private System.Windows.Forms.Label QuantityPopUpLb;
        private System.Windows.Forms.Label PricePopUpLb;
        private System.Windows.Forms.Label NewProductNameLb;
        private System.Windows.Forms.Label ClickedProductNameLb;
    }
}