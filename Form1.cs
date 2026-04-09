namespace BurgerKiosk

{
    using System.Threading.Tasks;
    public partial class Form1 : Form
    {
        int totalCost = 0;
        int HamBergerCost = 5000;
        int BulgogiBurgerCost = 4000;
        int ChickenBurgerCost = 3000;
        int PotatoCost = 3500;
        int ColaCost = 2500;
        int CheeseCost = 1500;
        int SauceCost = 500;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            if (rdoHamBurger.Checked)
            {
                totalCost += HamBergerCost;
                lstOrder.Items.Add($"{rdoHamBurger.Text} {HamBergerCost:N0}원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += BulgogiBurgerCost;
                lstOrder.Items.Add($"{rdoBulgogiBurger.Text} {BulgogiBurgerCost:N0}원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += ChickenBurgerCost;
                lstOrder.Items.Add($"{rdoChickenBurger.Text} {ChickenBurgerCost:N0}원");
            }
            else
            {
                lblError.Visible = true;
                return;
            }

            // 사이드 메뉴 및 옵션 부분
            if (chkPotato.Checked)
            {
                totalCost += PotatoCost;
                lstOrder.Items.Add($"{chkPotato.Text} {PotatoCost:N0}원");
            }

            if (chkCola.Checked)
            {
                totalCost += ColaCost;
                lstOrder.Items.Add($"{chkCola.Text} {ColaCost:N0}원");
            }

            if (chkCheese.Checked)
            {
                totalCost += CheeseCost;
                lstOrder.Items.Add($"{chkCheese.Text} {CheeseCost:N0}원");
            }

            if (chkSauce.Checked)
            {
                totalCost += SauceCost;
                lstOrder.Items.Add($"{chkSauce.Text} {SauceCost:N0}원");
            }
            lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";
            lblError.Visible = false;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = "총 금액 : 0원";
        }
    }
}


