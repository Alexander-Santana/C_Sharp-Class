namespace ShoppingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Item> shoppingList = new List<Item>();

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(txtStore.Text) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {

                MessageBox.Show("Please enter valid item details.");
                return;

            }

            Item newItem = new Item(txtItemName.Text, txtStore.Text, price);
            shoppingList.Add(newItem);

            MessageBox.Show("Item added successfully!");

            txtItemName.Clear();
            txtStore.Clear();
            txtPrice.Clear();
        }

        private void btnDisplayList_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();

            if (shoppingList.Count == 0)
            {
                listBoxItems.Items.Add("No items in the shopping list.");
                return;
            }

            decimal total = 0;

            // Header
            listBoxItems.Items.Add(string.Format("{0,-15} {1,-10} {2,10}", "Item Name", "Store", "Price"));
            listBoxItems.Items.Add(new string('-', 40)); // Separator line

            foreach (Item item in shoppingList)
            {
                listBoxItems.Items.Add(string.Format("{0,-15} {1,-10} {2,10:C}",
                    item.Name, item.Store, item.Price));
                total += item.Price;
            }

            listBoxItems.Items.Add(new string('-', 40)); // Separator line
            listBoxItems.Items.Add(string.Format("{0,-25} {1,10:C}", "Total of items:", total));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtStore.Clear();
            txtPrice.Clear();
            listBoxItems.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
