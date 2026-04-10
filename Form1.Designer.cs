namespace BurgerKiosk
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
            lblBurgerKiosk = new Label();
            chkFries = new CheckBox();
            rbnHam1 = new RadioButton();
            grbSide = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            rbnHam2 = new RadioButton();
            grbMenu = new GroupBox();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamBurger = new PictureBox();
            rbnHam3 = new RadioButton();
            lstOrder = new ListBox();
            grbOrder = new GroupBox();
            lblTotalCost = new Label();
            btnOrder = new Button();
            btnClear = new Button();
            lblError = new Label();
            grbSide.SuspendLayout();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            grbOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblBurgerKiosk
            // 
            lblBurgerKiosk.AutoSize = true;
            lblBurgerKiosk.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblBurgerKiosk.ForeColor = Color.Cyan;
            lblBurgerKiosk.Location = new Point(68, 37);
            lblBurgerKiosk.Name = "lblBurgerKiosk";
            lblBurgerKiosk.Size = new Size(595, 86);
            lblBurgerKiosk.TabIndex = 0;
            lblBurgerKiosk.Text = "버거 주문 키오스크";
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkFries.ForeColor = Color.Black;
            chkFries.Location = new Point(6, 62);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(129, 36);
            chkFries.TabIndex = 0;
            chkFries.Tag = "3500";
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // rbnHam1
            // 
            rbnHam1.AutoSize = true;
            rbnHam1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rbnHam1.ForeColor = Color.Black;
            rbnHam1.Location = new Point(6, 80);
            rbnHam1.Name = "rbnHam1";
            rbnHam1.Size = new Size(104, 36);
            rbnHam1.TabIndex = 0;
            rbnHam1.TabStop = true;
            rbnHam1.Tag = "5000";
            rbnHam1.Text = "햄버거";
            rbnHam1.UseVisualStyleBackColor = true;
            // 
            // grbSide
            // 
            grbSide.Controls.Add(chkSauce);
            grbSide.Controls.Add(chkCheese);
            grbSide.Controls.Add(chkCola);
            grbSide.Controls.Add(chkFries);
            grbSide.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbSide.ForeColor = Color.LightCoral;
            grbSide.Location = new Point(472, 179);
            grbSide.Name = "grbSide";
            grbSide.Size = new Size(157, 261);
            grbSide.TabIndex = 3;
            grbSide.TabStop = false;
            grbSide.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(6, 188);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(137, 36);
            chkSauce.TabIndex = 3;
            chkSauce.Tag = "500";
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(6, 146);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(137, 36);
            chkCheese.TabIndex = 2;
            chkCheese.Tag = "1500";
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(6, 104);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(81, 36);
            chkCola.TabIndex = 1;
            chkCola.Tag = "2500";
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // rbnHam2
            // 
            rbnHam2.AutoSize = true;
            rbnHam2.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rbnHam2.ForeColor = Color.Black;
            rbnHam2.Location = new Point(6, 189);
            rbnHam2.Name = "rbnHam2";
            rbnHam2.Size = new Size(152, 36);
            rbnHam2.TabIndex = 1;
            rbnHam2.TabStop = true;
            rbnHam2.Tag = "4000";
            rbnHam2.Text = "불고기버거";
            rbnHam2.UseVisualStyleBackColor = true;
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(picChickenBurger);
            grbMenu.Controls.Add(picBulgogiBurger);
            grbMenu.Controls.Add(picHamBurger);
            grbMenu.Controls.Add(rbnHam3);
            grbMenu.Controls.Add(rbnHam2);
            grbMenu.Controls.Add(rbnHam1);
            grbMenu.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbMenu.ForeColor = Color.LightCoral;
            grbMenu.Location = new Point(68, 179);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(315, 390);
            grbMenu.TabIndex = 2;
            grbMenu.TabStop = false;
            grbMenu.Text = "메뉴 선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = Properties.Resources.치킨버거;
            picChickenBurger.Location = new Point(182, 266);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(127, 92);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 7;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = Properties.Resources.햄버거2;
            picBulgogiBurger.Location = new Point(182, 159);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(127, 92);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 6;
            picBulgogiBurger.TabStop = false;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = Properties.Resources.햄버거;
            picHamBurger.Location = new Point(182, 52);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(127, 92);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 5;
            picHamBurger.TabStop = false;
            // 
            // rbnHam3
            // 
            rbnHam3.AutoSize = true;
            rbnHam3.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rbnHam3.ForeColor = Color.Black;
            rbnHam3.Location = new Point(6, 298);
            rbnHam3.Name = "rbnHam3";
            rbnHam3.Size = new Size(128, 36);
            rbnHam3.TabIndex = 2;
            rbnHam3.TabStop = true;
            rbnHam3.Tag = "3000";
            rbnHam3.Text = "치킨버거";
            rbnHam3.UseVisualStyleBackColor = true;
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(16, 52);
            lstOrder.Name = "lstOrder";
            lstOrder.SelectionMode = SelectionMode.None;
            lstOrder.Size = new Size(353, 244);
            lstOrder.TabIndex = 5;
            lstOrder.TabStop = false;
            // 
            // grbOrder
            // 
            grbOrder.Controls.Add(lblTotalCost);
            grbOrder.Controls.Add(lstOrder);
            grbOrder.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbOrder.ForeColor = Color.LightCoral;
            grbOrder.Location = new Point(717, 179);
            grbOrder.Name = "grbOrder";
            grbOrder.Size = new Size(388, 351);
            grbOrder.TabIndex = 4;
            grbOrder.TabStop = false;
            grbOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.FromArgb(128, 128, 255);
            lblTotalCost.Location = new Point(16, 300);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(152, 32);
            lblTotalCost.TabIndex = 7;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(733, 553);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(161, 61);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(925, 553);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(161, 61);
            btnClear.TabIndex = 0;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(68, 37);
            lblError.Name = "lblError";
            lblError.Size = new Size(572, 86);
            lblError.TabIndex = 1;
            lblError.Text = "메뉴를 선택하세요";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 669);
            Controls.Add(lblError);
            Controls.Add(btnClear);
            Controls.Add(grbOrder);
            Controls.Add(btnOrder);
            Controls.Add(grbMenu);
            Controls.Add(grbSide);
            Controls.Add(lblBurgerKiosk);
            Name = "Form1";
            Text = "Burger kiosk";
            grbSide.ResumeLayout(false);
            grbSide.PerformLayout();
            grbMenu.ResumeLayout(false);
            grbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            grbOrder.ResumeLayout(false);
            grbOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBurgerKiosk;
        private CheckBox chkFries;
        private RadioButton rbnHam1;
        private GroupBox grbSide;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private RadioButton rbnHam2;
        private GroupBox grbMenu;
        private RadioButton rbnHam3;
        private ListBox lstOrder;
        private GroupBox grbOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnClear;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picHamBurger;
        private Label lblError;
    }
}
