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
            chkPotato = new CheckBox();
            rdoHamBurger = new RadioButton();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            rdoBulgogiBurger = new RadioButton();
            grpMenu = new GroupBox();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            lstOrder = new ListBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            btnOrder = new Button();
            btnInit = new Button();
            lblError = new Label();
            grpOption.SuspendLayout();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            grpOrder.SuspendLayout();
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
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(6, 62);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(129, 36);
            chkPotato.TabIndex = 1;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(6, 80);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(104, 36);
            rdoHamBurger.TabIndex = 2;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.LightCoral;
            grpOption.Location = new Point(472, 179);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(157, 261);
            grpOption.TabIndex = 3;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(6, 188);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(137, 36);
            chkSauce.TabIndex = 4;
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
            chkCheese.TabIndex = 3;
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
            chkCola.TabIndex = 2;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(6, 189);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(152, 36);
            rdoBulgogiBurger.TabIndex = 3;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.LightCoral;
            grpMenu.Location = new Point(68, 179);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(315, 390);
            grpMenu.TabIndex = 4;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
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
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(6, 298);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(128, 36);
            rdoChickenBurger.TabIndex = 4;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
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
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.LightCoral;
            grpOrder.Location = new Point(717, 179);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(388, 351);
            grpOrder.TabIndex = 6;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
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
            btnOrder.TabIndex = 7;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnInit.ForeColor = Color.White;
            btnInit.Location = new Point(925, 553);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(161, 61);
            btnInit.TabIndex = 8;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(68, 37);
            lblError.Name = "lblError";
            lblError.Size = new Size(572, 86);
            lblError.TabIndex = 9;
            lblError.Text = "메뉴를 선택하세요";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 669);
            Controls.Add(lblError);
            Controls.Add(btnInit);
            Controls.Add(grpOrder);
            Controls.Add(btnOrder);
            Controls.Add(grpMenu);
            Controls.Add(grpOption);
            Controls.Add(lblBurgerKiosk);
            Name = "Form1";
            Text = "Burger kiosk";
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBurgerKiosk;
        private CheckBox chkPotato;
        private RadioButton rdoHamBurger;
        private GroupBox grpOption;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private RadioButton rdoBulgogiBurger;
        private GroupBox grpMenu;
        private RadioButton rdoChickenBurger;
        private ListBox lstOrder;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnInit;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picHamBurger;
        private Label lblError;
    }
}
