namespace TheatreManagerApp
{
    partial class AddPopUp
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
            this.NewProductNameLb = new System.Windows.Forms.Label();
            this.PricePopUpLb = new System.Windows.Forms.Label();
            this.QuantityPopUpLb = new System.Windows.Forms.Label();
            this.SavePopUpBtn = new System.Windows.Forms.Button();
            this.NewProductTxt = new System.Windows.Forms.TextBox();
            this.NewPriceTxt = new System.Windows.Forms.TextBox();
            this.NewQuantityTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewProductNameLb
            // 
            this.NewProductNameLb.AutoSize = true;
            this.NewProductNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductNameLb.Location = new System.Drawing.Point(12, 20);
            this.NewProductNameLb.Name = "NewProductNameLb";
            this.NewProductNameLb.Size = new System.Drawing.Size(145, 20);
            this.NewProductNameLb.TabIndex = 0;
            this.NewProductNameLb.Text = "New Product Name";
            // 
            // PricePopUpLb
            // 
            this.PricePopUpLb.AutoSize = true;
            this.PricePopUpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePopUpLb.Location = new System.Drawing.Point(12, 83);
            this.PricePopUpLb.Name = "PricePopUpLb";
            this.PricePopUpLb.Size = new System.Drawing.Size(44, 20);
            this.PricePopUpLb.TabIndex = 1;
            this.PricePopUpLb.Text = "Price";
            // 
            // QuantityPopUpLb
            // 
            this.QuantityPopUpLb.AutoSize = true;
            this.QuantityPopUpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityPopUpLb.Location = new System.Drawing.Point(12, 147);
            this.QuantityPopUpLb.Name = "QuantityPopUpLb";
            this.QuantityPopUpLb.Size = new System.Drawing.Size(68, 20);
            this.QuantityPopUpLb.TabIndex = 2;
            this.QuantityPopUpLb.Text = "Quantity";
            // 
            // SavePopUpBtn
            // 
            this.SavePopUpBtn.Location = new System.Drawing.Point(197, 226);
            this.SavePopUpBtn.Name = "SavePopUpBtn";
            this.SavePopUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePopUpBtn.TabIndex = 3;
            this.SavePopUpBtn.Text = "Save";
            this.SavePopUpBtn.UseVisualStyleBackColor = true;
            this.SavePopUpBtn.Click += new System.EventHandler(this.SavePopUpBtn_Click);
            // 
            // NewProductTxt
            // 
            this.NewProductTxt.Location = new System.Drawing.Point(16, 44);
            this.NewProductTxt.Name = "NewProductTxt";
            this.NewProductTxt.Size = new System.Drawing.Size(256, 20);
            this.NewProductTxt.TabIndex = 4;
            this.NewProductTxt.Text = "Type Name Here";
            // 
            // NewPriceTxt
            // 
            this.NewPriceTxt.Location = new System.Drawing.Point(16, 106);
            this.NewPriceTxt.Name = "NewPriceTxt";
            this.NewPriceTxt.Size = new System.Drawing.Size(256, 20);
            this.NewPriceTxt.TabIndex = 5;
            this.NewPriceTxt.Text = "0";
            // 
            // NewQuantityTxt
            // 
            this.NewQuantityTxt.Location = new System.Drawing.Point(16, 170);
            this.NewQuantityTxt.Name = "NewQuantityTxt";
            this.NewQuantityTxt.Size = new System.Drawing.Size(256, 20);
            this.NewQuantityTxt.TabIndex = 6;
            this.NewQuantityTxt.Text = "0";
            // 
            // AddPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NewQuantityTxt);
            this.Controls.Add(this.NewPriceTxt);
            this.Controls.Add(this.NewProductTxt);
            this.Controls.Add(this.SavePopUpBtn);
            this.Controls.Add(this.QuantityPopUpLb);
            this.Controls.Add(this.PricePopUpLb);
            this.Controls.Add(this.NewProductNameLb);
            this.Name = "AddPopUp";
            this.Text = "Add New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewProductNameLb;
        private System.Windows.Forms.Label PricePopUpLb;
        private System.Windows.Forms.Label QuantityPopUpLb;
        private System.Windows.Forms.Button SavePopUpBtn;
        private System.Windows.Forms.TextBox NewProductTxt;
        private System.Windows.Forms.TextBox NewPriceTxt;
        private System.Windows.Forms.TextBox NewQuantityTxt;
    }
}