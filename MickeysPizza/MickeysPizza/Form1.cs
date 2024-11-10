// Chapter 6, Lab Assignment
// Mickeys Pizza menu form
// Author: Alexander Santtana
// Date: 10/30/2024



namespace MickeysPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Initialize the form components when the program starts
        }

        private decimal getBasePrice()
        {
            // Check which pizza size is selected and return the correct base price
            if (rdoSmall.Checked)
                return 10.00m; // Small pizza costs $10
            else if (rdoMedium.Checked)
                return 12.00m; // Medium pizza costs $12
            else if (rdoLarge.Checked)
                return 15.00m; // Large pizza costs $15
            else
                return 0.00m; // If n size is selected, return 0 (just in case)
        }

        private decimal getToppingsPrice()
        {
            decimal toppingsPrice = 0.0m; // Start with no extra toppings cost

            // Add prices of toppings if each checkbox is selected
            if (chkPepperoni.Checked)
                toppingsPrice += 1.50m; // Pepperoni costs $1.50
            if (chkMushrooms.Checked)
                toppingsPrice += 2.00m; // Mushrooms cost $2
            if (chkPeppers.Checked)
                toppingsPrice += 0.50m; // Peppers cost $0.50

            return toppingsPrice; // Return the total price of all selected toppings
        }

        private decimal getExtrasPrice()
        {
            decimal extrasPrice = 0.0m; // Start with no extra ingredients cost

            // Add prices of extra ingredients if each checkbox is selected
            if (chkExtraSauce.Checked)
                extrasPrice += 1.00m; // Extra sauce costs $1
            if (chkExtraCheese.Checked)
                extrasPrice += 2.00m; // Extra cheese costs $2

            return extrasPrice; // Return the total price of all selected extras
        }

        private decimal calculatePizzaPrice()
        {
            // Calculate the full pizza price by adding base, toppings, and extras prices
            decimal basePrice = getBasePrice(); // Get base price based on pizza size
            decimal toppingsPrice = getToppingsPrice(); // Get total toppings price
            decimal extrasPrice = getExtrasPrice(); // Get total extras price

            return basePrice + toppingsPrice + extrasPrice; // Return total pizza price
        }

        private decimal calculateOrderTotal(decimal pizzaPrice, decimal tip)
        {
            // Calculate the tax as 7.5% of the pizza price
            decimal tax = pizzaPrice * 0.075m;
            // Add pizza price, tax, and tip to get the total order amount
            return pizzaPrice + tax + tip;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the total pizza price
            decimal pizzaPrice = calculatePizzaPrice();
            lblPizzaPrice.Text = $"${pizzaPrice:F2}"; // Display the pizza price

            // Try to read the tip amount entered by the user
            decimal tip = 0.0m;
            if (decimal.TryParse(txtTip.Text, out decimal parsedTip))
            {
                tip = parsedTip; // If valid, set the tip to the user-entered amount
                lblTipAmount.Text = $"${tip:F2}"; // Display the tip amount
            }
            else
            {
                MessageBox.Show("Please enter a valid tip amount."); // Show an error if tip is invalid
                lblTipAmount.Text = "$0.00"; // Set tip display to $0.00
            }

            // Calculate the tax on the pizza price only (7.5%)
            decimal tax = pizzaPrice * 0.075m;
            lblTaxAmount.Text = $"${tax:F2}"; // Display the tax amount

            // Calculate the total order price including pizza, tax, and tip
            decimal totalOrderPrice = calculateOrderTotal(pizzaPrice, tip);
            lblTotalOrderPrice.Text = $"${totalOrderPrice:F2}"; // Display the total order amount
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Uncheck all pizza size radio buttons
            rdoSmall.Checked = false;
            rdoMedium.Checked = false;
            rdoLarge.Checked = false;

            // Uncheck all toppings checkboxes
            chkPepperoni.Checked = false;
            chkMushrooms.Checked = false;
            chkPeppers.Checked = false;

            // Uncheck all extras checkboxes
            chkExtraSauce.Checked = false;
            chkExtraCheese.Checked = false;

            // Clear the tip TextBox
            txtTip.Clear();

            // Clear all labels that display prices
            lblPizzaPrice.Text = "";
            lblTipAmount.Text = "";
            lblTaxAmount.Text = "";
            lblTotalOrderPrice.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form when the user clicks the exit button
        }
    }
}
