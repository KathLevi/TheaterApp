using System.Windows.Forms;

namespace TheatreManagerApp
{
    partial class AppWindow
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
               this.Price_panel = new System.Windows.Forms.Panel();
               this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
               this.seniorPrice = new System.Windows.Forms.Label();
               this.TicketPricesLb = new System.Windows.Forms.Label();
               this.MatineePriceLb = new System.Windows.Forms.Label();
               this.SSPriceLb = new System.Windows.Forms.Label();
               this.EditPriceBtn = new System.Windows.Forms.Button();
               this.AdultPriceLb = new System.Windows.Forms.Label();
               this.KidsPriceLb = new System.Windows.Forms.Label();
               this.kidPrice = new System.Windows.Forms.Label();
               this.matPrice = new System.Windows.Forms.Label();
               this.adultPrice = new System.Windows.Forms.Label();
               this.Inventory_panel = new System.Windows.Forms.Panel();
               this.Menu_panel = new System.Windows.Forms.Panel();
               this.RestockBtn = new System.Windows.Forms.Button();
               this.DeleteLowStockBtn = new System.Windows.Forms.Button();
               this.EditBtn = new System.Windows.Forms.Button();
               this.RemoveBtn = new System.Windows.Forms.Button();
               this.AddBtn = new System.Windows.Forms.Button();
               this.Stock_List = new System.Windows.Forms.ListBox();
               this.Menu_List = new System.Windows.Forms.ListBox();
               this.Low_Stock = new System.Windows.Forms.Label();
               this.MenuLb = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.dtpEnd = new System.Windows.Forms.DateTimePicker();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.dtpStart = new System.Windows.Forms.DateTimePicker();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.CalendarLb = new System.Windows.Forms.Label();
               this.AdvancedDetailsLb = new System.Windows.Forms.Label();
               this.Image_Movie_Product = new System.Windows.Forms.PictureBox();
               this.ContextBox = new System.Windows.Forms.ListBox();
               this.Price_panel.SuspendLayout();
               this.Menu_panel.SuspendLayout();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Image_Movie_Product)).BeginInit();
               this.SuspendLayout();
               // 
               // Price_panel
               // 
               this.Price_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.Price_panel.Controls.Add(this.flowLayoutPanel1);
               this.Price_panel.Controls.Add(this.seniorPrice);
               this.Price_panel.Controls.Add(this.TicketPricesLb);
               this.Price_panel.Controls.Add(this.MatineePriceLb);
               this.Price_panel.Controls.Add(this.SSPriceLb);
               this.Price_panel.Controls.Add(this.EditPriceBtn);
               this.Price_panel.Controls.Add(this.AdultPriceLb);
               this.Price_panel.Controls.Add(this.KidsPriceLb);
               this.Price_panel.Controls.Add(this.kidPrice);
               this.Price_panel.Controls.Add(this.matPrice);
               this.Price_panel.Controls.Add(this.adultPrice);
               this.Price_panel.Location = new System.Drawing.Point(-1, -1);
               this.Price_panel.Name = "Price_panel";
               this.Price_panel.Size = new System.Drawing.Size(360, 175);
               this.Price_panel.TabIndex = 0;
               // 
               // flowLayoutPanel1
               // 
               this.flowLayoutPanel1.Location = new System.Drawing.Point(360, 0);
               this.flowLayoutPanel1.Name = "flowLayoutPanel1";
               this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 677);
               this.flowLayoutPanel1.TabIndex = 3;
               // 
               // seniorPrice
               // 
               this.seniorPrice.AutoSize = true;
               this.seniorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.seniorPrice.Location = new System.Drawing.Point(310, 104);
               this.seniorPrice.Name = "seniorPrice";
               this.seniorPrice.Size = new System.Drawing.Size(44, 24);
               this.seniorPrice.TabIndex = 6;
               this.seniorPrice.Text = "SPL";
               // 
               // TicketPricesLb
               // 
               this.TicketPricesLb.AutoSize = true;
               this.TicketPricesLb.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.TicketPricesLb.Location = new System.Drawing.Point(3, 1);
               this.TicketPricesLb.Name = "TicketPricesLb";
               this.TicketPricesLb.Size = new System.Drawing.Size(221, 39);
               this.TicketPricesLb.TabIndex = 2;
               this.TicketPricesLb.Text = "Ticket Prices";
               this.TicketPricesLb.Click += new System.EventHandler(this.TicketPricesLb_Click);
               // 
               // MatineePriceLb
               // 
               this.MatineePriceLb.AutoSize = true;
               this.MatineePriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.MatineePriceLb.Location = new System.Drawing.Point(22, 133);
               this.MatineePriceLb.Name = "MatineePriceLb";
               this.MatineePriceLb.Size = new System.Drawing.Size(125, 24);
               this.MatineePriceLb.TabIndex = 3;
               this.MatineePriceLb.Text = "Matinee Price";
               // 
               // SSPriceLb
               // 
               this.SSPriceLb.AutoSize = true;
               this.SSPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.SSPriceLb.Location = new System.Drawing.Point(22, 104);
               this.SSPriceLb.Name = "SSPriceLb";
               this.SSPriceLb.Size = new System.Drawing.Size(182, 24);
               this.SSPriceLb.TabIndex = 2;
               this.SSPriceLb.Text = "Senior/Student Price";
               // 
               // EditPriceBtn
               // 
               this.EditPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.EditPriceBtn.Location = new System.Drawing.Point(301, 8);
               this.EditPriceBtn.Name = "EditPriceBtn";
               this.EditPriceBtn.Size = new System.Drawing.Size(53, 29);
               this.EditPriceBtn.TabIndex = 9;
               this.EditPriceBtn.Text = "Edit";
               this.EditPriceBtn.UseVisualStyleBackColor = true;
               this.EditPriceBtn.Click += new System.EventHandler(this.EditPriceBtn_Click);
               // 
               // AdultPriceLb
               // 
               this.AdultPriceLb.AutoSize = true;
               this.AdultPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.AdultPriceLb.Location = new System.Drawing.Point(22, 75);
               this.AdultPriceLb.Name = "AdultPriceLb";
               this.AdultPriceLb.Size = new System.Drawing.Size(110, 24);
               this.AdultPriceLb.TabIndex = 1;
               this.AdultPriceLb.Text = "Adults Price";
               // 
               // KidsPriceLb
               // 
               this.KidsPriceLb.AutoSize = true;
               this.KidsPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.KidsPriceLb.Location = new System.Drawing.Point(22, 46);
               this.KidsPriceLb.Name = "KidsPriceLb";
               this.KidsPriceLb.Size = new System.Drawing.Size(94, 24);
               this.KidsPriceLb.TabIndex = 0;
               this.KidsPriceLb.Text = "Kids Price";
               // 
               // kidPrice
               // 
               this.kidPrice.AutoSize = true;
               this.kidPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.kidPrice.Location = new System.Drawing.Point(310, 46);
               this.kidPrice.Name = "kidPrice";
               this.kidPrice.Size = new System.Drawing.Size(44, 24);
               this.kidPrice.TabIndex = 4;
               this.kidPrice.Text = "KPL";
               // 
               // matPrice
               // 
               this.matPrice.AutoSize = true;
               this.matPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.matPrice.Location = new System.Drawing.Point(308, 133);
               this.matPrice.Name = "matPrice";
               this.matPrice.Size = new System.Drawing.Size(48, 24);
               this.matPrice.TabIndex = 7;
               this.matPrice.Text = "MPL";
               // 
               // adultPrice
               // 
               this.adultPrice.AutoSize = true;
               this.adultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.adultPrice.Location = new System.Drawing.Point(309, 75);
               this.adultPrice.Name = "adultPrice";
               this.adultPrice.Size = new System.Drawing.Size(45, 24);
               this.adultPrice.TabIndex = 5;
               this.adultPrice.Text = "APL";
               // 
               // Inventory_panel
               // 
               this.Inventory_panel.BackColor = System.Drawing.Color.Coral;
               this.Inventory_panel.Location = new System.Drawing.Point(-1, 180);
               this.Inventory_panel.Name = "Inventory_panel";
               this.Inventory_panel.Size = new System.Drawing.Size(360, 496);
               this.Inventory_panel.TabIndex = 1;
               this.Inventory_panel.Visible = false;
               // 
               // Menu_panel
               // 
               this.Menu_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.Menu_panel.Controls.Add(this.RestockBtn);
               this.Menu_panel.Controls.Add(this.DeleteLowStockBtn);
               this.Menu_panel.Controls.Add(this.EditBtn);
               this.Menu_panel.Controls.Add(this.RemoveBtn);
               this.Menu_panel.Controls.Add(this.AddBtn);
               this.Menu_panel.Controls.Add(this.Stock_List);
               this.Menu_panel.Controls.Add(this.Menu_List);
               this.Menu_panel.Controls.Add(this.Low_Stock);
               this.Menu_panel.Controls.Add(this.MenuLb);
               this.Menu_panel.Location = new System.Drawing.Point(-1, 180);
               this.Menu_panel.Name = "Menu_panel";
               this.Menu_panel.Size = new System.Drawing.Size(360, 496);
               this.Menu_panel.TabIndex = 1;
               // 
               // RestockBtn
               // 
               this.RestockBtn.Location = new System.Drawing.Point(198, 316);
               this.RestockBtn.Name = "RestockBtn";
               this.RestockBtn.Size = new System.Drawing.Size(75, 23);
               this.RestockBtn.TabIndex = 24;
               this.RestockBtn.Text = "Restock";
               this.RestockBtn.UseVisualStyleBackColor = true;
               this.RestockBtn.Click += new System.EventHandler(this.RestockBtn_Click);
               // 
               // DeleteLowStockBtn
               // 
               this.DeleteLowStockBtn.Location = new System.Drawing.Point(279, 316);
               this.DeleteLowStockBtn.Name = "DeleteLowStockBtn";
               this.DeleteLowStockBtn.Size = new System.Drawing.Size(75, 23);
               this.DeleteLowStockBtn.TabIndex = 23;
               this.DeleteLowStockBtn.Text = "Delete";
               this.DeleteLowStockBtn.UseVisualStyleBackColor = true;
               this.DeleteLowStockBtn.Click += new System.EventHandler(this.DeleteLowStockBtn_Click);
               // 
               // EditBtn
               // 
               this.EditBtn.Location = new System.Drawing.Point(198, 14);
               this.EditBtn.Name = "EditBtn";
               this.EditBtn.Size = new System.Drawing.Size(75, 23);
               this.EditBtn.TabIndex = 22;
               this.EditBtn.Text = "Edit";
               this.EditBtn.UseVisualStyleBackColor = true;
               this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
               // 
               // RemoveBtn
               // 
               this.RemoveBtn.Location = new System.Drawing.Point(279, 14);
               this.RemoveBtn.Name = "RemoveBtn";
               this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
               this.RemoveBtn.TabIndex = 21;
               this.RemoveBtn.Text = "Delete";
               this.RemoveBtn.UseVisualStyleBackColor = true;
               this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
               // 
               // AddBtn
               // 
               this.AddBtn.Location = new System.Drawing.Point(117, 14);
               this.AddBtn.Name = "AddBtn";
               this.AddBtn.Size = new System.Drawing.Size(75, 23);
               this.AddBtn.TabIndex = 20;
               this.AddBtn.Text = "Add";
               this.AddBtn.UseVisualStyleBackColor = true;
               this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
               // 
               // Stock_List
               // 
               this.Stock_List.BackColor = System.Drawing.Color.Silver;
               this.Stock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Stock_List.FormattingEnabled = true;
               this.Stock_List.ItemHeight = 16;
               this.Stock_List.Location = new System.Drawing.Point(10, 345);
               this.Stock_List.Name = "Stock_List";
               this.Stock_List.Size = new System.Drawing.Size(344, 132);
               this.Stock_List.TabIndex = 19;
               this.Stock_List.SelectedIndexChanged += new System.EventHandler(this.Stock_List_SelectedIndexChanged);
               // 
               // Menu_List
               // 
               this.Menu_List.BackColor = System.Drawing.Color.Silver;
               this.Menu_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Menu_List.FormattingEnabled = true;
               this.Menu_List.ItemHeight = 16;
               this.Menu_List.Location = new System.Drawing.Point(10, 41);
               this.Menu_List.Name = "Menu_List";
               this.Menu_List.Size = new System.Drawing.Size(344, 244);
               this.Menu_List.TabIndex = 18;
               this.Menu_List.SelectedIndexChanged += new System.EventHandler(this.Menu_List_SelectedIndexChanged);
               // 
               // Low_Stock
               // 
               this.Low_Stock.AutoSize = true;
               this.Low_Stock.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Low_Stock.Location = new System.Drawing.Point(3, 305);
               this.Low_Stock.Name = "Low_Stock";
               this.Low_Stock.Size = new System.Drawing.Size(181, 39);
               this.Low_Stock.TabIndex = 17;
               this.Low_Stock.Text = "Low Stock";
               // 
               // MenuLb
               // 
               this.MenuLb.AutoSize = true;
               this.MenuLb.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.MenuLb.Location = new System.Drawing.Point(3, 0);
               this.MenuLb.Name = "MenuLb";
               this.MenuLb.Size = new System.Drawing.Size(105, 39);
               this.MenuLb.TabIndex = 16;
               this.MenuLb.Text = "Menu";
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.panel1.Controls.Add(this.dtpEnd);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Controls.Add(this.dtpStart);
               this.panel1.Controls.Add(this.dataGridView1);
               this.panel1.Controls.Add(this.CalendarLb);
               this.panel1.Location = new System.Drawing.Point(360, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(360, 676);
               this.panel1.TabIndex = 2;
               // 
               // dtpEnd
               // 
               this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpEnd.Location = new System.Drawing.Point(108, 76);
               this.dtpEnd.Name = "dtpEnd";
               this.dtpEnd.Size = new System.Drawing.Size(80, 20);
               this.dtpEnd.TabIndex = 18;
               this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
               this.label2.Location = new System.Drawing.Point(22, 74);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(73, 18);
               this.label2.TabIndex = 17;
               this.label2.Text = "End Date:";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
               this.label1.Location = new System.Drawing.Point(22, 49);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(78, 18);
               this.label1.TabIndex = 16;
               this.label1.Text = "Start Date:";
               // 
               // dtpStart
               // 
               this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpStart.Location = new System.Drawing.Point(108, 49);
               this.dtpStart.Name = "dtpStart";
               this.dtpStart.Size = new System.Drawing.Size(80, 20);
               this.dtpStart.TabIndex = 15;
               this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
               // 
               // dataGridView1
               // 
               this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
               this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
               this.dataGridView1.Location = new System.Drawing.Point(5, 108);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.ReadOnly = true;
               this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.RowTemplate.ReadOnly = true;
               this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
               this.dataGridView1.Size = new System.Drawing.Size(352, 551);
               this.dataGridView1.TabIndex = 14;
               this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
               // 
               // CalendarLb
               // 
               this.CalendarLb.AutoSize = true;
               this.CalendarLb.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.CalendarLb.Location = new System.Drawing.Point(18, 7);
               this.CalendarLb.Name = "CalendarLb";
               this.CalendarLb.Size = new System.Drawing.Size(159, 39);
               this.CalendarLb.TabIndex = 13;
               this.CalendarLb.Text = "Calendar";
               // 
               // AdvancedDetailsLb
               // 
               this.AdvancedDetailsLb.AutoSize = true;
               this.AdvancedDetailsLb.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.AdvancedDetailsLb.Location = new System.Drawing.Point(725, 0);
               this.AdvancedDetailsLb.Name = "AdvancedDetailsLb";
               this.AdvancedDetailsLb.Size = new System.Drawing.Size(293, 39);
               this.AdvancedDetailsLb.TabIndex = 13;
               this.AdvancedDetailsLb.Text = "Advanced Details";
               // 
               // Image_Movie_Product
               // 
               this.Image_Movie_Product.BackColor = System.Drawing.Color.Silver;
               this.Image_Movie_Product.Location = new System.Drawing.Point(732, 45);
               this.Image_Movie_Product.Name = "Image_Movie_Product";
               this.Image_Movie_Product.Size = new System.Drawing.Size(318, 162);
               this.Image_Movie_Product.TabIndex = 14;
               this.Image_Movie_Product.TabStop = false;
               // 
               // ContextBox
               // 
               this.ContextBox.BackColor = System.Drawing.Color.Silver;
               this.ContextBox.FormattingEnabled = true;
               this.ContextBox.Location = new System.Drawing.Point(732, 221);
               this.ContextBox.Name = "ContextBox";
               this.ContextBox.Size = new System.Drawing.Size(318, 433);
               this.ContextBox.TabIndex = 15;
               this.ContextBox.SelectedIndexChanged += new System.EventHandler(this.ContextBox_SelectedIndexChanged);
               // 
               // AppWindow
               // 
               this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.ClientSize = new System.Drawing.Size(1062, 673);
               this.Controls.Add(this.ContextBox);
               this.Controls.Add(this.Image_Movie_Product);
               this.Controls.Add(this.AdvancedDetailsLb);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.Menu_panel);
               this.Controls.Add(this.Price_panel);
               this.MaximizeBox = false;
               this.Name = "AppWindow";
               this.Price_panel.ResumeLayout(false);
               this.Price_panel.PerformLayout();
               this.Menu_panel.ResumeLayout(false);
               this.Menu_panel.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Image_Movie_Product)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }
        
        private Panel Price_panel;
        private Panel Menu_panel;
        private Panel Inventory_panel;
        private Label TicketPricesLb;
        private Label seniorPrice;
        private Label MatineePriceLb;
        private Label SSPriceLb;
        private Button EditPriceBtn;
        private Label AdultPriceLb;
        private Label KidsPriceLb;
        private Label kidPrice;
        private Label matPrice;
        private Label adultPrice;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label CalendarLb;
        private DataGridView dataGridView1;
        private Label MenuLb;
        private Label Low_Stock;
        private ListBox Stock_List;
        private ListBox Menu_List;
        private Label AdvancedDetailsLb;
        private PictureBox Image_Movie_Product;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button EditBtn;
        private Label label1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label2;
        private Button RestockBtn;
        private Button DeleteLowStockBtn;
        private ListBox ContextBox;
    }
    #endregion
}

