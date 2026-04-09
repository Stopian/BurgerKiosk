namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add(rdoHamBurger.Text + " 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add(rdoBulgogiBurger.Text + " 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add(rdoChickenBurger.Text + " 3,000원");
            }
            else if
        }
    }
}


