namespace Best_Oil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuyPrice_txtbox = new System.Windows.Forms.TextBox();
            this.BuyLitr_txtbox = new System.Windows.Forms.TextBox();
            this.FuelPrice_txtbox = new System.Windows.Forms.TextBox();
            this.Fuel_cmbbox = new System.Windows.Forms.ComboBox();
            this.fuel_lbl = new System.Windows.Forms.Label();
            this.price_rdbtn = new System.Windows.Forms.RadioButton();
            this.ltr_rdbtn = new System.Windows.Forms.RadioButton();
            this.OilResult_grpbox = new System.Windows.Forms.GroupBox();
            this.TotalPriceOil_lbl = new System.Windows.Forms.Label();
            this.MiniCafe_grpbox = new System.Windows.Forms.GroupBox();
            this.Watercount_txtbox = new System.Windows.Forms.TextBox();
            this.Waterprice_txtbox = new System.Windows.Forms.TextBox();
            this.Colacount_txtbox = new System.Windows.Forms.TextBox();
            this.Colaprice_txtbox = new System.Windows.Forms.TextBox();
            this.Friescount_txtbox = new System.Windows.Forms.TextBox();
            this.Hamburgercount_txtbox = new System.Windows.Forms.TextBox();
            this.Hamburgerprice_txtbox = new System.Windows.Forms.TextBox();
            this.Friesprice_txtbox = new System.Windows.Forms.TextBox();
            this.count_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Water_chkbox = new System.Windows.Forms.CheckBox();
            this.Cola_chckbox = new System.Windows.Forms.CheckBox();
            this.Fries_chckbox = new System.Windows.Forms.CheckBox();
            this.Hamburger_chckbox = new System.Windows.Forms.CheckBox();
            this.MiniCafeResult_grpbox = new System.Windows.Forms.GroupBox();
            this.TotalPriceCafe_lbl = new System.Windows.Forms.Label();
            this.Total_grpbx = new System.Windows.Forms.GroupBox();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.Cash_rdbtn = new System.Windows.Forms.RadioButton();
            this.Card_rdbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPrice_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.OilResult_grpbox.SuspendLayout();
            this.MiniCafe_grpbox.SuspendLayout();
            this.MiniCafeResult_grpbox.SuspendLayout();
            this.Total_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BuyPrice_txtbox);
            this.groupBox1.Controls.Add(this.BuyLitr_txtbox);
            this.groupBox1.Controls.Add(this.FuelPrice_txtbox);
            this.groupBox1.Controls.Add(this.Fuel_cmbbox);
            this.groupBox1.Controls.Add(this.fuel_lbl);
            this.groupBox1.Controls.Add(this.price_rdbtn);
            this.groupBox1.Controls.Add(this.ltr_rdbtn);
            this.groupBox1.Controls.Add(this.OilResult_grpbox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price";
            // 
            // BuyPrice_txtbox
            // 
            this.BuyPrice_txtbox.Location = new System.Drawing.Point(213, 181);
            this.BuyPrice_txtbox.Name = "BuyPrice_txtbox";
            this.BuyPrice_txtbox.ReadOnly = true;
            this.BuyPrice_txtbox.Size = new System.Drawing.Size(142, 33);
            this.BuyPrice_txtbox.TabIndex = 7;
            this.BuyPrice_txtbox.TextChanged += new System.EventHandler(this.BuyPrice_txtbox_TextChanged);
            // 
            // BuyLitr_txtbox
            // 
            this.BuyLitr_txtbox.Location = new System.Drawing.Point(213, 133);
            this.BuyLitr_txtbox.Name = "BuyLitr_txtbox";
            this.BuyLitr_txtbox.ReadOnly = true;
            this.BuyLitr_txtbox.Size = new System.Drawing.Size(142, 33);
            this.BuyLitr_txtbox.TabIndex = 6;
            this.BuyLitr_txtbox.TextChanged += new System.EventHandler(this.BuyLitr_txtbox_TextChanged);
            // 
            // FuelPrice_txtbox
            // 
            this.FuelPrice_txtbox.Location = new System.Drawing.Point(213, 85);
            this.FuelPrice_txtbox.Name = "FuelPrice_txtbox";
            this.FuelPrice_txtbox.ReadOnly = true;
            this.FuelPrice_txtbox.Size = new System.Drawing.Size(142, 33);
            this.FuelPrice_txtbox.TabIndex = 5;
            // 
            // Fuel_cmbbox
            // 
            this.Fuel_cmbbox.FormattingEnabled = true;
            this.Fuel_cmbbox.Location = new System.Drawing.Point(213, 32);
            this.Fuel_cmbbox.Name = "Fuel_cmbbox";
            this.Fuel_cmbbox.Size = new System.Drawing.Size(142, 33);
            this.Fuel_cmbbox.TabIndex = 4;
            this.Fuel_cmbbox.SelectedIndexChanged += new System.EventHandler(this.Fuel_cmbbox_SelectedIndexChanged);
            // 
            // fuel_lbl
            // 
            this.fuel_lbl.AutoSize = true;
            this.fuel_lbl.Location = new System.Drawing.Point(14, 41);
            this.fuel_lbl.Name = "fuel_lbl";
            this.fuel_lbl.Size = new System.Drawing.Size(47, 25);
            this.fuel_lbl.TabIndex = 3;
            this.fuel_lbl.Text = "Fuel";
            // 
            // price_rdbtn
            // 
            this.price_rdbtn.AutoSize = true;
            this.price_rdbtn.Location = new System.Drawing.Point(14, 181);
            this.price_rdbtn.Name = "price_rdbtn";
            this.price_rdbtn.Size = new System.Drawing.Size(72, 29);
            this.price_rdbtn.TabIndex = 2;
            this.price_rdbtn.TabStop = true;
            this.price_rdbtn.Text = "Price";
            this.price_rdbtn.UseVisualStyleBackColor = true;
            this.price_rdbtn.CheckedChanged += new System.EventHandler(this.ltr_rdbtn_CheckedChanged);
            // 
            // ltr_rdbtn
            // 
            this.ltr_rdbtn.AutoSize = true;
            this.ltr_rdbtn.Location = new System.Drawing.Point(14, 137);
            this.ltr_rdbtn.Name = "ltr_rdbtn";
            this.ltr_rdbtn.Size = new System.Drawing.Size(57, 29);
            this.ltr_rdbtn.TabIndex = 1;
            this.ltr_rdbtn.TabStop = true;
            this.ltr_rdbtn.Text = "Litr";
            this.ltr_rdbtn.UseVisualStyleBackColor = true;
            this.ltr_rdbtn.CheckedChanged += new System.EventHandler(this.ltr_rdbtn_CheckedChanged);
            // 
            // OilResult_grpbox
            // 
            this.OilResult_grpbox.Controls.Add(this.TotalPriceOil_lbl);
            this.OilResult_grpbox.Location = new System.Drawing.Point(14, 220);
            this.OilResult_grpbox.Name = "OilResult_grpbox";
            this.OilResult_grpbox.Size = new System.Drawing.Size(341, 111);
            this.OilResult_grpbox.TabIndex = 0;
            this.OilResult_grpbox.TabStop = false;
            this.OilResult_grpbox.Text = "Result";
            // 
            // TotalPriceOil_lbl
            // 
            this.TotalPriceOil_lbl.AutoSize = true;
            this.TotalPriceOil_lbl.Location = new System.Drawing.Point(155, 44);
            this.TotalPriceOil_lbl.Name = "TotalPriceOil_lbl";
            this.TotalPriceOil_lbl.Size = new System.Drawing.Size(22, 25);
            this.TotalPriceOil_lbl.TabIndex = 0;
            this.TotalPriceOil_lbl.Text = "0";
            // 
            // MiniCafe_grpbox
            // 
            this.MiniCafe_grpbox.Controls.Add(this.Watercount_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Waterprice_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Colacount_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Colaprice_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Friescount_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Hamburgercount_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Hamburgerprice_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.Friesprice_txtbox);
            this.MiniCafe_grpbox.Controls.Add(this.count_lbl);
            this.MiniCafe_grpbox.Controls.Add(this.label4);
            this.MiniCafe_grpbox.Controls.Add(this.Water_chkbox);
            this.MiniCafe_grpbox.Controls.Add(this.Cola_chckbox);
            this.MiniCafe_grpbox.Controls.Add(this.Fries_chckbox);
            this.MiniCafe_grpbox.Controls.Add(this.Hamburger_chckbox);
            this.MiniCafe_grpbox.Controls.Add(this.MiniCafeResult_grpbox);
            this.MiniCafe_grpbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiniCafe_grpbox.Location = new System.Drawing.Point(434, 30);
            this.MiniCafe_grpbox.Name = "MiniCafe_grpbox";
            this.MiniCafe_grpbox.Size = new System.Drawing.Size(374, 358);
            this.MiniCafe_grpbox.TabIndex = 1;
            this.MiniCafe_grpbox.TabStop = false;
            this.MiniCafe_grpbox.Text = "Mini-Cafe";
            // 
            // Watercount_txtbox
            // 
            this.Watercount_txtbox.Location = new System.Drawing.Point(294, 167);
            this.Watercount_txtbox.Multiline = true;
            this.Watercount_txtbox.Name = "Watercount_txtbox";
            this.Watercount_txtbox.ReadOnly = true;
            this.Watercount_txtbox.Size = new System.Drawing.Size(62, 29);
            this.Watercount_txtbox.TabIndex = 14;
            this.Watercount_txtbox.Text = "0";
            this.Watercount_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Watercount_txtbox.TextChanged += new System.EventHandler(this.Watercount_txtbox_TextChanged);
            // 
            // Waterprice_txtbox
            // 
            this.Waterprice_txtbox.Location = new System.Drawing.Point(208, 169);
            this.Waterprice_txtbox.Multiline = true;
            this.Waterprice_txtbox.Name = "Waterprice_txtbox";
            this.Waterprice_txtbox.ReadOnly = true;
            this.Waterprice_txtbox.Size = new System.Drawing.Size(62, 29);
            this.Waterprice_txtbox.TabIndex = 13;
            this.Waterprice_txtbox.Text = "0,5";
            // 
            // Colacount_txtbox
            // 
            this.Colacount_txtbox.Location = new System.Drawing.Point(294, 132);
            this.Colacount_txtbox.Multiline = true;
            this.Colacount_txtbox.Name = "Colacount_txtbox";
            this.Colacount_txtbox.ReadOnly = true;
            this.Colacount_txtbox.Size = new System.Drawing.Size(62, 29);
            this.Colacount_txtbox.TabIndex = 12;
            this.Colacount_txtbox.Text = "0";
            this.Colacount_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Colacount_txtbox.TextChanged += new System.EventHandler(this.Colacount_txtbox_TextChanged);
            // 
            // Colaprice_txtbox
            // 
            this.Colaprice_txtbox.Location = new System.Drawing.Point(208, 134);
            this.Colaprice_txtbox.Multiline = true;
            this.Colaprice_txtbox.Name = "Colaprice_txtbox";
            this.Colaprice_txtbox.ReadOnly = true;
            this.Colaprice_txtbox.Size = new System.Drawing.Size(62, 29);
            this.Colaprice_txtbox.TabIndex = 11;
            this.Colaprice_txtbox.Text = "1";
            // 
            // Friescount_txtbox
            // 
            this.Friescount_txtbox.Location = new System.Drawing.Point(295, 99);
            this.Friescount_txtbox.Multiline = true;
            this.Friescount_txtbox.Name = "Friescount_txtbox";
            this.Friescount_txtbox.ReadOnly = true;
            this.Friescount_txtbox.Size = new System.Drawing.Size(61, 27);
            this.Friescount_txtbox.TabIndex = 10;
            this.Friescount_txtbox.Text = "0";
            this.Friescount_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Friescount_txtbox.TextChanged += new System.EventHandler(this.Friescount_txtbox_TextChanged);
            // 
            // Hamburgercount_txtbox
            // 
            this.Hamburgercount_txtbox.Location = new System.Drawing.Point(295, 66);
            this.Hamburgercount_txtbox.Multiline = true;
            this.Hamburgercount_txtbox.Name = "Hamburgercount_txtbox";
            this.Hamburgercount_txtbox.ReadOnly = true;
            this.Hamburgercount_txtbox.Size = new System.Drawing.Size(61, 27);
            this.Hamburgercount_txtbox.TabIndex = 10;
            this.Hamburgercount_txtbox.Text = "0";
            this.Hamburgercount_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Hamburgercount_txtbox.TextChanged += new System.EventHandler(this.Hamburgercount_txtbox_TextChanged);
            // 
            // Hamburgerprice_txtbox
            // 
            this.Hamburgerprice_txtbox.Location = new System.Drawing.Point(208, 66);
            this.Hamburgerprice_txtbox.Multiline = true;
            this.Hamburgerprice_txtbox.Name = "Hamburgerprice_txtbox";
            this.Hamburgerprice_txtbox.ReadOnly = true;
            this.Hamburgerprice_txtbox.Size = new System.Drawing.Size(62, 27);
            this.Hamburgerprice_txtbox.TabIndex = 9;
            this.Hamburgerprice_txtbox.Text = "2,70";
            // 
            // Friesprice_txtbox
            // 
            this.Friesprice_txtbox.Location = new System.Drawing.Point(208, 99);
            this.Friesprice_txtbox.Multiline = true;
            this.Friesprice_txtbox.Name = "Friesprice_txtbox";
            this.Friesprice_txtbox.ReadOnly = true;
            this.Friesprice_txtbox.Size = new System.Drawing.Size(62, 29);
            this.Friesprice_txtbox.TabIndex = 8;
            this.Friesprice_txtbox.Text = "1,30";
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_lbl.Location = new System.Drawing.Point(294, 29);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(52, 21);
            this.count_lbl.TabIndex = 7;
            this.count_lbl.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(208, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // Water_chkbox
            // 
            this.Water_chkbox.AutoSize = true;
            this.Water_chkbox.Location = new System.Drawing.Point(26, 169);
            this.Water_chkbox.Name = "Water_chkbox";
            this.Water_chkbox.Size = new System.Drawing.Size(81, 29);
            this.Water_chkbox.TabIndex = 5;
            this.Water_chkbox.Text = "Water";
            this.Water_chkbox.UseVisualStyleBackColor = true;
            this.Water_chkbox.CheckedChanged += new System.EventHandler(this.Water_chkbox_CheckedChanged);
            // 
            // Cola_chckbox
            // 
            this.Cola_chckbox.AutoSize = true;
            this.Cola_chckbox.Location = new System.Drawing.Point(26, 134);
            this.Cola_chckbox.Name = "Cola_chckbox";
            this.Cola_chckbox.Size = new System.Drawing.Size(119, 29);
            this.Cola_chckbox.TabIndex = 4;
            this.Cola_chckbox.Text = "Coca-Cola";
            this.Cola_chckbox.UseVisualStyleBackColor = true;
            this.Cola_chckbox.CheckedChanged += new System.EventHandler(this.Cola_chckbox_CheckedChanged);
            // 
            // Fries_chckbox
            // 
            this.Fries_chckbox.AutoSize = true;
            this.Fries_chckbox.Location = new System.Drawing.Point(26, 99);
            this.Fries_chckbox.Name = "Fries_chckbox";
            this.Fries_chckbox.Size = new System.Drawing.Size(70, 29);
            this.Fries_chckbox.TabIndex = 3;
            this.Fries_chckbox.Text = "Fries";
            this.Fries_chckbox.UseVisualStyleBackColor = true;
            this.Fries_chckbox.CheckedChanged += new System.EventHandler(this.Fries_chckbox_CheckedChanged);
            // 
            // Hamburger_chckbox
            // 
            this.Hamburger_chckbox.AutoSize = true;
            this.Hamburger_chckbox.Location = new System.Drawing.Point(26, 59);
            this.Hamburger_chckbox.Name = "Hamburger_chckbox";
            this.Hamburger_chckbox.Size = new System.Drawing.Size(127, 29);
            this.Hamburger_chckbox.TabIndex = 2;
            this.Hamburger_chckbox.Text = "Hamburger";
            this.Hamburger_chckbox.UseVisualStyleBackColor = true;
            this.Hamburger_chckbox.CheckedChanged += new System.EventHandler(this.Hamburger_chckbox_CheckedChanged);
            // 
            // MiniCafeResult_grpbox
            // 
            this.MiniCafeResult_grpbox.Controls.Add(this.TotalPriceCafe_lbl);
            this.MiniCafeResult_grpbox.Location = new System.Drawing.Point(15, 219);
            this.MiniCafeResult_grpbox.Name = "MiniCafeResult_grpbox";
            this.MiniCafeResult_grpbox.Size = new System.Drawing.Size(341, 111);
            this.MiniCafeResult_grpbox.TabIndex = 1;
            this.MiniCafeResult_grpbox.TabStop = false;
            this.MiniCafeResult_grpbox.Text = "Result";
            // 
            // TotalPriceCafe_lbl
            // 
            this.TotalPriceCafe_lbl.AutoSize = true;
            this.TotalPriceCafe_lbl.Location = new System.Drawing.Point(162, 44);
            this.TotalPriceCafe_lbl.Name = "TotalPriceCafe_lbl";
            this.TotalPriceCafe_lbl.Size = new System.Drawing.Size(22, 25);
            this.TotalPriceCafe_lbl.TabIndex = 1;
            this.TotalPriceCafe_lbl.Text = "0";
            // 
            // Total_grpbx
            // 
            this.Total_grpbx.Controls.Add(this.Pay_btn);
            this.Total_grpbx.Controls.Add(this.Cash_rdbtn);
            this.Total_grpbx.Controls.Add(this.Card_rdbtn);
            this.Total_grpbx.Controls.Add(this.label3);
            this.Total_grpbx.Controls.Add(this.TotalPrice_txtbox);
            this.Total_grpbx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total_grpbx.Location = new System.Drawing.Point(27, 429);
            this.Total_grpbx.Name = "Total_grpbx";
            this.Total_grpbx.Size = new System.Drawing.Size(781, 150);
            this.Total_grpbx.TabIndex = 2;
            this.Total_grpbx.TabStop = false;
            this.Total_grpbx.Text = "Total";
            // 
            // Pay_btn
            // 
            this.Pay_btn.Location = new System.Drawing.Point(575, 52);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(120, 50);
            this.Pay_btn.TabIndex = 13;
            this.Pay_btn.Text = "Pay";
            this.Pay_btn.UseVisualStyleBackColor = true;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // Cash_rdbtn
            // 
            this.Cash_rdbtn.AutoSize = true;
            this.Cash_rdbtn.Location = new System.Drawing.Point(38, 41);
            this.Cash_rdbtn.Name = "Cash_rdbtn";
            this.Cash_rdbtn.Size = new System.Drawing.Size(71, 29);
            this.Cash_rdbtn.TabIndex = 12;
            this.Cash_rdbtn.TabStop = true;
            this.Cash_rdbtn.Text = "Cash";
            this.Cash_rdbtn.UseVisualStyleBackColor = true;
            // 
            // Card_rdbtn
            // 
            this.Card_rdbtn.AutoSize = true;
            this.Card_rdbtn.Location = new System.Drawing.Point(38, 96);
            this.Card_rdbtn.Name = "Card_rdbtn";
            this.Card_rdbtn.Size = new System.Drawing.Size(70, 29);
            this.Card_rdbtn.TabIndex = 11;
            this.Card_rdbtn.TabStop = true;
            this.Card_rdbtn.Text = "Card";
            this.Card_rdbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // TotalPrice_txtbox
            // 
            this.TotalPrice_txtbox.Location = new System.Drawing.Point(157, 62);
            this.TotalPrice_txtbox.Multiline = true;
            this.TotalPrice_txtbox.Name = "TotalPrice_txtbox";
            this.TotalPrice_txtbox.ReadOnly = true;
            this.TotalPrice_txtbox.Size = new System.Drawing.Size(244, 39);
            this.TotalPrice_txtbox.TabIndex = 0;
            this.TotalPrice_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 591);
            this.Controls.Add(this.Total_grpbx);
            this.Controls.Add(this.MiniCafe_grpbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OilResult_grpbox.ResumeLayout(false);
            this.OilResult_grpbox.PerformLayout();
            this.MiniCafe_grpbox.ResumeLayout(false);
            this.MiniCafe_grpbox.PerformLayout();
            this.MiniCafeResult_grpbox.ResumeLayout(false);
            this.MiniCafeResult_grpbox.PerformLayout();
            this.Total_grpbx.ResumeLayout(false);
            this.Total_grpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox BuyPrice_txtbox;
        private TextBox BuyLitr_txtbox;
        private TextBox FuelPrice_txtbox;
        private ComboBox Fuel_cmbbox;
        private Label fuel_lbl;
        private RadioButton price_rdbtn;
        private RadioButton ltr_rdbtn;
        private GroupBox OilResult_grpbox;
        private GroupBox MiniCafe_grpbox;
        private CheckBox Water_chkbox;
        private CheckBox Cola_chckbox;
        private CheckBox Fries_chckbox;
        private CheckBox Hamburger_chckbox;
        private GroupBox MiniCafeResult_grpbox;
        private GroupBox Total_grpbx;
        private Button Pay_btn;
        private RadioButton Cash_rdbtn;
        private RadioButton Card_rdbtn;
        private Label label3;
        private TextBox TotalPrice_txtbox;
        private Label count_lbl;
        private Label label4;
        private TextBox Watercount_txtbox;
        private TextBox Waterprice_txtbox;
        private TextBox Colacount_txtbox;
        private TextBox Colaprice_txtbox;
        private TextBox Friescount_txtbox;
        private TextBox Hamburgercount_txtbox;
        private TextBox Hamburgerprice_txtbox;
        private TextBox Friesprice_txtbox;
        private Label TotalPriceOil_lbl;
        private Label TotalPriceCafe_lbl;
    }
}