namespace Best_Oil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum OilTypes { Ai_92,Ai_95,Ai_98,Dizel}
        List<KeyValuePair<string, double>> list = new List<KeyValuePair<string, double>>();
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(new KeyValuePair<string, double>("Ai-92", 1.70));
            list.Add(new KeyValuePair<string, double>("Ai-95", 2.30));
            list.Add(new KeyValuePair<string, double>("Ai-98", 2.70));
            list.Add(new KeyValuePair<string, double>("Dizel", 1.00));
            for (int i = 0; i < list.Count; i++)
            {
            Fuel_cmbbox.Items.Add(list[i].Key);
            }
            
        }
        void ResultCafe()
        {
            TotalPriceCafe_lbl.Text = (double.Parse(Hamburgercount_txtbox.Text) * double.Parse(Hamburgerprice_txtbox.Text) +
                double.Parse(Friescount_txtbox.Text) * double.Parse(Friesprice_txtbox.Text) +
                double.Parse(Colacount_txtbox.Text) * double.Parse(Colaprice_txtbox.Text)+
                double.Parse(Watercount_txtbox.Text) * double.Parse(Waterprice_txtbox.Text)).ToString();
        }

        private void Fuel_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        BuyLitr_txtbox.ReadOnly = false;
        BuyPrice_txtbox.ReadOnly = false;

        FuelPrice_txtbox.Text = list[Fuel_cmbbox.SelectedIndex].Value.ToString();         
            

        }

        private void ltr_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ltr_rdbtn.Checked)
            {
                BuyPrice_txtbox.ReadOnly = true;
                BuyPrice_txtbox.Text = string.Empty;
            }
            else if(price_rdbtn.Checked)
            {
                BuyLitr_txtbox.ReadOnly = true;
                BuyLitr_txtbox.Text = "0";
            }
            
                

        }

        private void Hamburger_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Hamburger_chckbox.Checked)
            {
                Hamburgercount_txtbox.ReadOnly = false;
                Hamburgerprice_txtbox.Enabled = true;

            }
            else
            {
                Hamburgercount_txtbox.ReadOnly = true;
                Hamburgercount_txtbox.Text = "0";
            }
            

        }

        private void Fries_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Fries_chckbox.Checked)
            {
                Friescount_txtbox.ReadOnly = false;
                Friesprice_txtbox.Enabled = true;
            }
            else
            {
                Friescount_txtbox.ReadOnly = true;
                Friescount_txtbox.Text = "0";
            }

        }

        private void Cola_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Cola_chckbox.Checked)
            {
                Colacount_txtbox.ReadOnly = false;
                Colaprice_txtbox.Enabled = true;
            }
            else
            {
                Colacount_txtbox.ReadOnly = true;
                Colacount_txtbox.Text = "0";
            }

        }

        private void Water_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Water_chkbox.Checked)
            {
                Watercount_txtbox.ReadOnly = false;
                Waterprice_txtbox.Enabled = true;
            }
            else
            {
                Watercount_txtbox.ReadOnly = true;
                Watercount_txtbox.Text = "0";
            }
            

        }

        private void Hamburgercount_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Hamburgerprice_txtbox.Text))
            {
                Hamburgerprice_txtbox.Text = "0";
            }
            ResultCafe();
        }

        private void Friescount_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Friesprice_txtbox.Text))
            {
                Friesprice_txtbox.Text = "0";
            }
            ResultCafe();
        }

        private void Colacount_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Colaprice_txtbox.Text))
            {
                Colaprice_txtbox.Text = "0";
            }
            ResultCafe();
        }

        private void Watercount_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Waterprice_txtbox.Text))
            {
                Waterprice_txtbox.Text = "0";
            }
            ResultCafe();
        }

        private void BuyLitr_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (BuyLitr_txtbox.Text != "0"){
                TotalPriceOil_lbl.Text = (double.Parse(BuyLitr_txtbox.Text) * double.Parse(FuelPrice_txtbox.Text)).ToString();
                TotalPrice_txtbox.Text = (double.Parse(TotalPriceCafe_lbl.Text) + double.Parse(TotalPriceOil_lbl.Text)).ToString();
            }
        }

        private void BuyPrice_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (BuyPrice_txtbox.Text != "0"){
                TotalPriceOil_lbl.Text = (double.Parse(BuyPrice_txtbox.Text) / double.Parse(FuelPrice_txtbox.Text)).ToString();
                TotalPrice_txtbox.Text=(double.Parse(TotalPriceCafe_lbl.Text) + double.Parse(TotalPriceOil_lbl.Text)).ToString();
            }
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            if(Cash_rdbtn.Checked==false && Card_rdbtn.Checked == false)
            {
                MessageBox.Show("Please choose payment metod ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("See you later,Good bye !!!", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}