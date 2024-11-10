namespace MickeysPizza
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
            grpSize = new GroupBox();
            rdoLarge = new RadioButton();
            rdoMedium = new RadioButton();
            rdoSmall = new RadioButton();
            grpToppings = new GroupBox();
            chkPeppers = new CheckBox();
            chkMushrooms = new CheckBox();
            chkPepperoni = new CheckBox();
            grpExtras = new GroupBox();
            chkExtraCheese = new CheckBox();
            chkExtraSauce = new CheckBox();
            grpTaxTips = new GroupBox();
            txtTip = new TextBox();
            labelTip = new Label();
            labelTax = new Label();
            grpTotal = new GroupBox();
            lblTotalOrderPrice = new Label();
            lblTaxAmount = new Label();
            lblTipAmount = new Label();
            lblPizzaPrice = new Label();
            labelTotal = new Label();
            labelTaxTotal = new Label();
            labelTipTotal = new Label();
            labelPizzaTotal = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpSize.SuspendLayout();
            grpToppings.SuspendLayout();
            grpExtras.SuspendLayout();
            grpTaxTips.SuspendLayout();
            grpTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpSize
            // 
            grpSize.Controls.Add(rdoLarge);
            grpSize.Controls.Add(rdoMedium);
            grpSize.Controls.Add(rdoSmall);
            grpSize.Location = new Point(29, 36);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(165, 125);
            grpSize.TabIndex = 0;
            grpSize.TabStop = false;
            grpSize.Text = "Size";
            // 
            // rdoLarge
            // 
            rdoLarge.AutoSize = true;
            rdoLarge.Location = new Point(9, 98);
            rdoLarge.Name = "rdoLarge";
            rdoLarge.Size = new Size(124, 24);
            rdoLarge.TabIndex = 2;
            rdoLarge.TabStop = true;
            rdoLarge.Text = "Large - $15.00";
            rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(9, 68);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(142, 24);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Medium - $12.00";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            rdoSmall.AutoSize = true;
            rdoSmall.Location = new Point(9, 38);
            rdoSmall.Name = "rdoSmall";
            rdoSmall.Size = new Size(124, 24);
            rdoSmall.TabIndex = 0;
            rdoSmall.TabStop = true;
            rdoSmall.Text = "Small - $10.00";
            rdoSmall.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            grpToppings.Controls.Add(chkPeppers);
            grpToppings.Controls.Add(chkMushrooms);
            grpToppings.Controls.Add(chkPepperoni);
            grpToppings.Location = new Point(29, 192);
            grpToppings.Name = "grpToppings";
            grpToppings.Size = new Size(165, 125);
            grpToppings.TabIndex = 1;
            grpToppings.TabStop = false;
            grpToppings.Text = "Toppings";
            // 
            // chkPeppers
            // 
            chkPeppers.AutoSize = true;
            chkPeppers.Location = new Point(8, 94);
            chkPeppers.Name = "chkPeppers";
            chkPeppers.Size = new Size(124, 24);
            chkPeppers.TabIndex = 2;
            chkPeppers.Text = "Peppers - $.50";
            chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(9, 65);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(151, 24);
            chkMushrooms.TabIndex = 1;
            chkMushrooms.Text = "Mushroom - $2.00";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(9, 37);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(147, 24);
            chkPepperoni.TabIndex = 0;
            chkPepperoni.Text = "Pepperoni - $1.50";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // grpExtras
            // 
            grpExtras.Controls.Add(chkExtraCheese);
            grpExtras.Controls.Add(chkExtraSauce);
            grpExtras.Location = new Point(279, 36);
            grpExtras.Name = "grpExtras";
            grpExtras.Size = new Size(165, 125);
            grpExtras.TabIndex = 2;
            grpExtras.TabStop = false;
            grpExtras.Text = "Extras";
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Location = new Point(11, 63);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(127, 24);
            chkExtraCheese.TabIndex = 1;
            chkExtraCheese.Text = "Cheese - $2.00";
            chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // chkExtraSauce
            // 
            chkExtraSauce.AutoSize = true;
            chkExtraSauce.Location = new Point(11, 34);
            chkExtraSauce.Name = "chkExtraSauce";
            chkExtraSauce.Size = new Size(119, 24);
            chkExtraSauce.TabIndex = 0;
            chkExtraSauce.Text = "Sauce - $1.00";
            chkExtraSauce.UseVisualStyleBackColor = true;
            // 
            // grpTaxTips
            // 
            grpTaxTips.Controls.Add(txtTip);
            grpTaxTips.Controls.Add(labelTip);
            grpTaxTips.Controls.Add(labelTax);
            grpTaxTips.Location = new Point(279, 192);
            grpTaxTips.Name = "grpTaxTips";
            grpTaxTips.Size = new Size(165, 125);
            grpTaxTips.TabIndex = 3;
            grpTaxTips.TabStop = false;
            grpTaxTips.Text = "Tax and Tip";
            // 
            // txtTip
            // 
            txtTip.BorderStyle = BorderStyle.FixedSingle;
            txtTip.Location = new Point(59, 38);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(85, 27);
            txtTip.TabIndex = 2;
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.Location = new Point(11, 41);
            labelTip.Name = "labelTip";
            labelTip.Size = new Size(42, 20);
            labelTip.TabIndex = 1;
            labelTip.Text = "Tip $";
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Location = new Point(11, 81);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(109, 20);
            labelTax.TabIndex = 0;
            labelTax.Text = "Tax rate = 7.5%";
            // 
            // grpTotal
            // 
            grpTotal.Controls.Add(lblTotalOrderPrice);
            grpTotal.Controls.Add(lblTaxAmount);
            grpTotal.Controls.Add(lblTipAmount);
            grpTotal.Controls.Add(lblPizzaPrice);
            grpTotal.Controls.Add(labelTotal);
            grpTotal.Controls.Add(labelTaxTotal);
            grpTotal.Controls.Add(labelTipTotal);
            grpTotal.Controls.Add(labelPizzaTotal);
            grpTotal.Location = new Point(29, 341);
            grpTotal.Name = "grpTotal";
            grpTotal.Size = new Size(250, 162);
            grpTotal.TabIndex = 4;
            grpTotal.TabStop = false;
            grpTotal.Text = "Order Total";
            // 
            // lblTotalOrderPrice
            // 
            lblTotalOrderPrice.BorderStyle = BorderStyle.FixedSingle;
            lblTotalOrderPrice.Location = new Point(125, 128);
            lblTotalOrderPrice.Name = "lblTotalOrderPrice";
            lblTotalOrderPrice.Size = new Size(100, 25);
            lblTotalOrderPrice.TabIndex = 7;
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.BorderStyle = BorderStyle.FixedSingle;
            lblTaxAmount.Location = new Point(125, 96);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new Size(99, 25);
            lblTaxAmount.TabIndex = 6;
            // 
            // lblTipAmount
            // 
            lblTipAmount.BorderStyle = BorderStyle.FixedSingle;
            lblTipAmount.Location = new Point(125, 61);
            lblTipAmount.Name = "lblTipAmount";
            lblTipAmount.Size = new Size(100, 25);
            lblTipAmount.TabIndex = 5;
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPizzaPrice.Location = new Point(125, 27);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(100, 25);
            lblPizzaPrice.TabIndex = 4;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(21, 128);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(42, 20);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Total";
            // 
            // labelTaxTotal
            // 
            labelTaxTotal.AutoSize = true;
            labelTaxTotal.Location = new Point(21, 97);
            labelTaxTotal.Name = "labelTaxTotal";
            labelTaxTotal.Size = new Size(30, 20);
            labelTaxTotal.TabIndex = 2;
            labelTaxTotal.Text = "Tax";
            // 
            // labelTipTotal
            // 
            labelTipTotal.AutoSize = true;
            labelTipTotal.Location = new Point(21, 66);
            labelTipTotal.Name = "labelTipTotal";
            labelTipTotal.Size = new Size(30, 20);
            labelTipTotal.TabIndex = 1;
            labelTipTotal.Text = "Tip";
            // 
            // labelPizzaTotal
            // 
            labelPizzaTotal.AutoSize = true;
            labelPizzaTotal.Location = new Point(21, 32);
            labelPizzaTotal.Name = "labelPizzaTotal";
            labelPizzaTotal.Size = new Size(79, 20);
            labelPizzaTotal.TabIndex = 0;
            labelPizzaTotal.Text = "Pizza Price";
            labelPizzaTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(335, 361);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Place Order";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(335, 407);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear Order";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(338, 451);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 515);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(grpTotal);
            Controls.Add(grpTaxTips);
            Controls.Add(grpExtras);
            Controls.Add(grpToppings);
            Controls.Add(grpSize);
            Name = "Form1";
            Text = "Mickey's Pizza";
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            grpExtras.ResumeLayout(false);
            grpExtras.PerformLayout();
            grpTaxTips.ResumeLayout(false);
            grpTaxTips.PerformLayout();
            grpTotal.ResumeLayout(false);
            grpTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSize;
        private RadioButton rdoLarge;
        private RadioButton rdoMedium;
        private RadioButton rdoSmall;
        private GroupBox grpToppings;
        private CheckBox chkMushrooms;
        private CheckBox chkPepperoni;
        private CheckBox chkPeppers;
        private GroupBox grpExtras;
        private CheckBox chkExtraCheese;
        private CheckBox chkExtraSauce;
        private GroupBox grpTaxTips;
        private Label labelTip;
        private Label labelTax;
        private TextBox txtTip;
        private GroupBox grpTotal;
        private Label labelTotal;
        private Label labelTaxTotal;
        private Label labelTipTotal;
        private Label labelPizzaTotal;
        private Label lblPizzaPrice;
        private Label lblTotalOrderPrice;
        private Label lblTaxAmount;
        private Label lblTipAmount;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
