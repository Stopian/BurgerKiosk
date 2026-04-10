namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            //에러 메시지 
            lblError.Text = "메뉴를 선택하세요.";
            lblError.ForeColor = Color.Red;
            lblError.Visible = false;

            
            this.AcceptButton = btnOrder; //enter키로 주문하기 버튼 클릭
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            
            grbMenu.TabIndex = 0; //Tab 키로 이동할 때의 순서를 설정합니다.
            grbSide.TabIndex = 1;
            grbOrder.TabIndex = 2;
            btnOrder.TabIndex = 3;
            btnClear.TabIndex = 4;


            // 모든 항목의 Checked 상태가 변할 때 Item_CheckedChanged 이벤트를 실행합니다.
            rbnHam1.CheckedChanged += Item_CheckedChanged;
            rbnHam2.CheckedChanged += Item_CheckedChanged;
            rbnHam3.CheckedChanged += Item_CheckedChanged;

            chkFries.CheckedChanged += Item_CheckedChanged;
            chkCola.CheckedChanged += Item_CheckedChanged;
            chkCheese.CheckedChanged += Item_CheckedChanged;
            chkSauce.CheckedChanged += Item_CheckedChanged;

            // 포커스 자동 체크 방지
            this.ActiveControl = lblTotalCost;
        }


        private void Item_CheckedChanged(object sender, EventArgs e) // 모든 체크박스와 라디오버튼의 Checked 상태가 변경될 때마다 호출되는 이벤트 핸들러
        {
            UpdateOrder();
        }

        int viewtotalCost = 0; // 총 금액을 저장하는 변수
        int totalCost = 0; // 현재 주문의 금액을 저장하는 변수

        private void UpdateOrder()
        {

            lstOrder.Items.Clear(); // 주문 내역 초기화
            totalCost = 0 ;


            if (rbnHam1.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rbnHam2.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rbnHam3.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            
            if (chkFries.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }


            lblTotalCost.Text = $"총 금액: {viewtotalCost + totalCost:N0}원"; // 총 금액을 천 단위로 구분하여 표시


            if (rbnHam1.Checked || rbnHam2.Checked || rbnHam3.Checked)
            {
                lblError.Visible = false;
            }
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (!rbnHam1.Checked && !rbnHam2.Checked && !rbnHam3.Checked)
            {
                lblError.Visible = true;
                return; // 햄버거가 선택되지 않은 경우 에러 메시지를 표시하고 주문을 중단
            }

            lblError.Visible = false;

            MessageBox.Show("주문이 성공적으로 완료되었습니다!", "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            viewtotalCost += totalCost; // 총 금액에 현재 주문의 금액을 추가
        }


        private void btnClear_Click(object sender, EventArgs e )// 주문 초기화 버튼 클릭 이벤트 핸들러
        {
            
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;


            lblError.Visible = false;

            this.ActiveControl = lblTotalCost;
        }

      
    }
}