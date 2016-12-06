namespace TheatreManagerApp
{
    partial class PriceEditPopUp
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
            this.NewAdultTxt = new System.Windows.Forms.TextBox();
            this.NewKidTxt = new System.Windows.Forms.TextBox();
            this.SavePopUpBtn = new System.Windows.Forms.Button();
            this.MatineePriceLb = new System.Windows.Forms.Label();
            this.SSPriceLb = new System.Windows.Forms.Label();
            this.AdultPriceLb = new System.Windows.Forms.Label();
            this.KidsPriceLb = new System.Windows.Forms.Label();
            this.NewMatTxt = new System.Windows.Forms.TextBox();
            this.NewSeniorTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewAdultTxt
            // 
            this.NewAdultTxt.Location = new System.Drawing.Point(17, 89);
            this.NewAdultTxt.Name = "NewAdultTxt";
            this.NewAdultTxt.Size = new System.Drawing.Size(256, 20);
            this.NewAdultTxt.TabIndex = 15;
            // 
            // NewKidTxt
            // 
            this.NewKidTxt.Location = new System.Drawing.Point(17, 36);
            this.NewKidTxt.Name = "NewKidTxt";
            this.NewKidTxt.Size = new System.Drawing.Size(256, 20);
            this.NewKidTxt.TabIndex = 14;
            // 
            // SavePopUpBtn
            // 
            this.SavePopUpBtn.Location = new System.Drawing.Point(198, 228);
            this.SavePopUpBtn.Name = "SavePopUpBtn";
            this.SavePopUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePopUpBtn.TabIndex = 16;
            this.SavePopUpBtn.Text = "Save";
            this.SavePopUpBtn.UseVisualStyleBackColor = true;
            this.SavePopUpBtn.Click += new System.EventHandler(this.SavePopUpBtn_Click);
            // 
            // MatineePriceLb
            // 
            this.MatineePriceLb.AutoSize = true;
            this.MatineePriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MatineePriceLb.Location = new System.Drawing.Point(13, 168);
            this.MatineePriceLb.Name = "MatineePriceLb";
            this.MatineePriceLb.Size = new System.Drawing.Size(125, 24);
            this.MatineePriceLb.TabIndex = 20;
            this.MatineePriceLb.Text = "Matinee Price";
            // 
            // SSPriceLb
            // 
            this.SSPriceLb.AutoSize = true;
            this.SSPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SSPriceLb.Location = new System.Drawing.Point(13, 115);
            this.SSPriceLb.Name = "SSPriceLb";
            this.SSPriceLb.Size = new System.Drawing.Size(182, 24);
            this.SSPriceLb.TabIndex = 19;
            this.SSPriceLb.Text = "Senior/Student Price";
            // 
            // AdultPriceLb
            // 
            this.AdultPriceLb.AutoSize = true;
            this.AdultPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AdultPriceLb.Location = new System.Drawing.Point(13, 62);
            this.AdultPriceLb.Name = "AdultPriceLb";
            this.AdultPriceLb.Size = new System.Drawing.Size(110, 24);
            this.AdultPriceLb.TabIndex = 18;
            this.AdultPriceLb.Text = "Adults Price";
            // 
            // KidsPriceLb
            // 
            this.KidsPriceLb.AutoSize = true;
            this.KidsPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.KidsPriceLb.Location = new System.Drawing.Point(13, 9);
            this.KidsPriceLb.Name = "KidsPriceLb";
            this.KidsPriceLb.Size = new System.Drawing.Size(94, 24);
            this.KidsPriceLb.TabIndex = 17;
            this.KidsPriceLb.Text = "Kids Price";
            // 
            // NewMatTxt
            // 
            this.NewMatTxt.Location = new System.Drawing.Point(17, 195);
            this.NewMatTxt.Name = "NewMatTxt";
            this.NewMatTxt.Size = new System.Drawing.Size(256, 20);
            this.NewMatTxt.TabIndex = 22;
            // 
            // NewSeniorTxt
            // 
            this.NewSeniorTxt.Location = new System.Drawing.Point(17, 142);
            this.NewSeniorTxt.Name = "NewSeniorTxt";
            this.NewSeniorTxt.Size = new System.Drawing.Size(256, 20);
            this.NewSeniorTxt.TabIndex = 21;
            // 
            // PriceEditPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NewMatTxt);
            this.Controls.Add(this.NewSeniorTxt);
            this.Controls.Add(this.MatineePriceLb);
            this.Controls.Add(this.SSPriceLb);
            this.Controls.Add(this.AdultPriceLb);
            this.Controls.Add(this.KidsPriceLb);
            this.Controls.Add(this.SavePopUpBtn);
            this.Controls.Add(this.NewAdultTxt);
            this.Controls.Add(this.NewKidTxt);
            this.Name = "PriceEditPopUp";
            this.Text = "PriceEditPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewAdultTxt;
        private System.Windows.Forms.TextBox NewKidTxt;
        private System.Windows.Forms.Button SavePopUpBtn;
        private System.Windows.Forms.Label MatineePriceLb;
        private System.Windows.Forms.Label SSPriceLb;
        private System.Windows.Forms.Label AdultPriceLb;
        private System.Windows.Forms.Label KidsPriceLb;
        private System.Windows.Forms.TextBox NewMatTxt;
        private System.Windows.Forms.TextBox NewSeniorTxt;
    }
}